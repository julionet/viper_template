using VIPER.DTO;
using VIPER.Entity;
using VIPER.Infrastructure;
using VIPER.Repository.Interface;
using Chronus.Library;
using System;
using System.Linq;
using System.Linq.Dynamic;

namespace VIPER.Repository
{
    public class UsuarioRepository : IPadraoRepository<Usuario>, IDisposable
    {
        private _VIPER_Context _db = new _VIPER_Context();
        private IRepository<Usuario> _repository;

        public UsuarioRepository(_VIPER_Context context = null)
        {
            _repository = new Repository<Usuario>(context ?? new _VIPER_Context());
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public string Incluir(Usuario entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                entity.Senha = Security.GetMD5(entity.Senha);
                mensagem = _repository.Insert(entity);

                if (mensagem == "")
                    mensagem = _repository.JoinEntity<Perfil>(entity.Perfil, entity.ListaPerfis);
            }
            return mensagem;
        }

        public string Alterar(Usuario entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Update(entity);

                if (mensagem == "")
                {
                    _repository.GetContext().Entry(entity).Collection(c => c.Perfil).Load();
                    mensagem = _repository.JoinEntity<Perfil>(entity.Perfil, entity.ListaPerfis);
                }
            }
            return mensagem;
        }

        public string Excluir(Usuario entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = this.ExcluirCascata(entity);
                if (mensagem == "")
                {
                    mensagem = _repository.Delete(entity.Id);
                }
            }
            return mensagem;
        }

        public Usuario Selecionar(int id)
        {
            return _repository.GetById(id);
        }

        public IQueryable<Usuario> SelecionarTodos()
        {
            return _repository.GetAll();
        }

        public IQueryable<Usuario> Filtrar(string condicao)
        {
            return _repository.Filter(condicao);
        }

        public string ExcluirCascata(Usuario entity)
        {
            var mensagem = "";
            var repository = new UsuarioFuncaoRepository(_repository.GetContext() as _VIPER_Context);
            foreach (UsuarioFuncao registro in repository.SelecionarPorUsuario(entity.Id).ToArray())
            {
                mensagem = repository.Excluir(registro);
                if (mensagem != "")
                    break;
            }
            return mensagem;
        }

        public Usuario Selecionar(string login)
        {
            return _repository.GetAll().Where(p => p.Login == login).FirstOrDefault();
        }

        public IQueryable<Usuario> SelecionarNaoMaster()
        {
            return SelecionarTodos().Where(p => !p.Master);
        }

        public IQueryable<Perfil> SelecionarPerfis(int usuario)
        {
            return (from q in _db.Usuarios from p in q.Perfil where q.Id == usuario select p);
        }

        public string ValidarDados(Usuario entity)
        {
            if (string.IsNullOrWhiteSpace(entity.Login))
                return "Login n??o informado!";
            else if (SelecionarTodos().Where(p => p.Login == entity.Login && p.Id != entity.Id).Count() != 0)
                return "Login j?? informado para outro usu??rio!";
            else if (string.IsNullOrWhiteSpace(entity.Nome))
                return "Nome n??o informado!";
            else if (string.IsNullOrWhiteSpace(entity.Senha))
                return "Senha n??o informada!";
            return "";
        }

        public string ValidarExclusao(Usuario entity)
        {
            if ((from q in _db.UsuarioFuncaos where q.UsuarioId == entity.Id select q).Count() != 0)
                return "N??o ?? permitido excluir um usu??rio associado a uma ou mais fun????es do sistema!";
            else if ((from q in _db.ParametroUsuarios where q.UsuarioId == entity.Id select q).Count() != 0)
                return "N??o ?? permitido excluir um usu??rio associado a um ou mais par??metros!";
            return "";
        }

        public string ValidarLogin(string usuario, string senha)
        {
            var u = this.Selecionar(usuario.ToUpper());

            if (string.IsNullOrWhiteSpace(usuario))
                return "Usu??rio n??o informado!";
            else if (string.IsNullOrWhiteSpace(senha))
                return "Senha n??o informada!";
            else if (u == null)
                return "Usu??rio n??o cadastrado!";
            else if (u.Bloqueado)
                return "Usu??rio bloqueado!";
            else if (u.Senha != Security.GetMD5(senha).ToUpper())
                return "Senha incorreta!";
            else
                return "";
        }

        public bool DeveAlterarSenha(string usuario)
        {
            var u = this.Selecionar(usuario);
            return (u.AlterarSenha || (u.DataAlteracao.Value.AddDays(u.DiasExpirar ?? 0) < DateTime.Now));
        }

        public string AlterarSenha(string usuario, string senhaantiga, string novasenha, string confirmacao)
        {
            if (string.IsNullOrWhiteSpace(usuario))
                return "Usu??rio n??o informado!";
            else if (string.IsNullOrWhiteSpace(senhaantiga))
                return "Senha antiga n??o informada!";
            else if (string.IsNullOrWhiteSpace(novasenha))
                return "Nova senha n??o informada!";
            else if (string.IsNullOrWhiteSpace(confirmacao))
                return "Confirma????o n??o informada!";
            else if (novasenha != confirmacao)
                return "Confirma????o n??o confere com a nova senha!";
            else
            {
                var u = this.Selecionar(usuario);
                if (u == null)
                    return "Usu??rio n??o cadastrado!";
                else if (u.Senha != Security.GetMD5(senhaantiga))
                    return "Senha antiga est?? incorreta!";
                else if (u.Senha == Security.GetMD5(novasenha))
                    return "Nova senha deve ser diferente da senha antiga!";
                else
                {
                    u.Senha = Security.GetMD5(novasenha);
                    u.AlterarSenha = false;
                    u.DataAlteracao = DateTime.Today;
                    return this.Alterar(u);
                }
            }
        }
    }
}
