using NAMESPACE.Entity;
using NAMESPACE.Infrastructure;
using NAMESPACE.Repository.Interface;
using System;
using System.Linq;

namespace NAMESPACE.Repository
{
    public class VIPERRepository : IPadraoRepository<VIPER>, IDisposable
    {
        private _NAMESPACE_Context _db = new _NAMESPACE_Context();
        private readonly IRepository<VIPER> _repository;

        public VIPERRepository(_NAMESPACE_Context context = null)
        {
            _repository = new Repository<VIPER>(context ?? new _NAMESPACE_Context());
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

        public string Incluir(VIPER entity)
        {
            string mensagem = ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(VIPER entity)
        {
            string mensagem = ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(VIPER entity)
        {
            string mensagem = ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Delete(entity.Id);
            }
            return mensagem;
        }

        public VIPER Selecionar(int id)
        {
            return _repository.GetById(id);
        }

        public IQueryable<VIPER> SelecionarTodos()
        {
            return _repository.GetAll();
        }

        public IQueryable<VIPER> Filtrar(string condicao)
        {
            return _repository.Filter(condicao);
        }

        public string ValidarDados(VIPER entity)
        {
            return "";
        }

        public string ValidarExclusao(VIPER entity)
        {
            return "";
        }
    }
}
