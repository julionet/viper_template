using VIPER.Entity;
using VIPER.Infrastructure;
using VIPER.Repository.Interface;
using System;
using System.Linq;

namespace VIPER.Repository
{
    public class ModuloRepository : IPadraoRepository<Modulo>, IDisposable
    {
        private _VIPER_Context _db = new _VIPER_Context();
        private IRepository<Modulo> _repository;

        public ModuloRepository(_VIPER_Context context = null)
        {
            _repository = new Repository<Modulo>(context ?? new _VIPER_Context());
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

        public string Incluir(Modulo entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(Modulo entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                Modulo entityold = _db.Set<Modulo>().Find(entity.Id);

                mensagem = _repository.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(Modulo entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = this.ExcluirCascata(entity);
                if (mensagem == "")
                    mensagem = _repository.Delete(entity.Id);
            }
            return mensagem;
        }

        public Modulo Selecionar(int id)
        {
            return _repository.GetById(id);
        }

        public IQueryable<Modulo> SelecionarTodos()
        {
            return _repository.GetAll();
        }

        public IQueryable<Modulo> Filtrar(string condicao)
        {
            return _repository.Filter(condicao);
        }

        public string ExcluirCascata(Modulo entity)
        {
            var mensagem = "";
            var repository = new FuncaoRepository(_repository.GetContext() as _VIPER_Context);
            foreach (var registro in repository.SelecionarPorModulo(entity.Id).ToArray())
            {
                mensagem = repository.Excluir(registro);
                if (mensagem != "")
                    break;
            }
            return mensagem;
        }

        public IQueryable<Modulo> SelecionarPorSistema(int id)
        {
            return _repository.GetAll().Where(p => p.SistemaId == id);
        }

        public IQueryable<Modulo> SelecionarPorSistemaUsuario(int sistema, int usuario)
        {
            var us = new UsuarioRepository().Selecionar(usuario);

            IQueryable<int> dados;

            if (us.Master)
                dados = (from m in _db.Modulos
                         where !m.Administracao && m.SistemaId == sistema
                         select m.Id);
            else
                dados = (from q in _db.UsuarioFuncaos
                         join f in _db.Funcaos on q.FuncaoId equals f.Id
                         join m in _db.Modulos on f.ModuloId equals m.Id
                         where q.UsuarioId == usuario && m.SistemaId == sistema
                         select m.Id).Union((from pf in _db.PerfilFuncaos
                                          join f in _db.Funcaos on pf.FuncaoId equals f.Id
                                          join m in _db.Modulos on f.ModuloId equals m.Id
                                          where (from u in _db.Usuarios
                                                 from p in u.Perfil
                                                 where u.Id == usuario && m.SistemaId == sistema
                                                 select p.Id).Contains(pf.PerfilId)
                                          select m.Id));

            if (us.Administrador)
                dados = dados.Union((from m in _db.Modulos
                                     where m.Administracao && m.SistemaId == sistema
                                     select m.Id));

            return (from m in _db.Modulos
                    where dados.Distinct().Contains(m.Id)
                    select m);
        }

        public string ValidarDados(Modulo entity)
        {
            if (string.IsNullOrWhiteSpace(entity.Descricao))
                return "Descrição não informada!";
            else if (string.IsNullOrWhiteSpace(entity.Codigo))
                return "Código não informado!";
            else if (entity.QuantidadeFuncao == 0)
                return "Nenhuma função associada ao módulo!";
            else
                return "";
        }

        public string ValidarExclusao(Modulo entity)
        {
            if (new UsuarioFuncaoRepository().SelecionarTodos().Where(p => p.Funcao.ModuloId == entity.Id).Count() != 0)
                return "Não é permitido excluir uma função associada a um ou mais usuários!";
            else if (new PerfilFuncaoRepository().SelecionarTodos().Where(p => p.Funcao.ModuloId == entity.Id).Count() != 0)
                return "Não é permitido excluir uma função associada a um ou mais perfis!";
            else
                return "";
        }
    }
}
