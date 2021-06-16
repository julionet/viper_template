using VIPER.Entity;
using VIPER.Infrastructure;
using VIPER.Repository.Interface;
using System;
using System.Linq;

namespace VIPER.Repository
{
    public class PerfilRepository : IPadraoRepository<Perfil>, IDisposable
    {
        private _VIPER_Context _db = new _VIPER_Context();
        private IRepository<Perfil> _repository;

        public PerfilRepository(_VIPER_Context context = null)
        {
            _repository = new Repository<Perfil>(context ?? new _VIPER_Context());
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

        public string Incluir(Perfil entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(Perfil entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(Perfil entity)
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

        public Perfil Selecionar(int id)
        {
            return _repository.GetById(id);
        }

        public IQueryable<Perfil> SelecionarTodos()
        {
            return _repository.GetAll();
        }

        public IQueryable<Perfil> Filtrar(string condicao)
        {
            return _repository.Filter(condicao);
        }

        public string ExcluirCascata(Perfil entity)
        {
            var mensagem = "";
            var repository = new PerfilFuncaoRepository(_repository.GetContext() as _VIPER_Context);
            foreach (var registro in repository.SelecionarPorPerfil(entity.Id).ToArray())
            {
                mensagem = repository.Excluir(registro);
                if (mensagem != "")
                    break;
            }
            return mensagem;
        }

        public string ValidarDados(Perfil entity)
        {
            if (string.IsNullOrWhiteSpace(entity.Descricao))
                return "Descrição não informada!";
            else if (entity.QuantidadeFuncoes == 0)
                return "Nenhuma função foi associada ao perfil!";
            else
                return "";
        }

        public string ValidarExclusao(Perfil entity)
        {
            if ((from q in _db.Perfils from p in q.Usuario where q.Id == entity.Id select q).Count() != 0)
                return "Não é permitido excluir um perfil associado a um ou mais usuários!";
            else
                return "";
        }
    }
}
