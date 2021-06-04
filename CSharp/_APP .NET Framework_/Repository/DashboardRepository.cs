using VIPER.DTO;
using VIPER.Entity;
using VIPER.Infrastructure;
using VIPER.Repository.Interface;
using System;
using System.Linq;

namespace VIPER.Repository
{
    public class DashboardRepository : IPadraoRepository<Dashboard>, IDisposable
    {
        private _VIPER_Context _db = new _VIPER_Context();
        private IRepository<Dashboard> _repository;

        public DashboardRepository(_VIPER_Context context = null)
        {
            _repository = new Repository<Dashboard>(context ?? new _VIPER_Context());
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

        public string Incluir(Dashboard entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(Dashboard entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(Dashboard entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Delete(entity.Id);
            }
            return mensagem;
        }

        public Dashboard Selecionar(int id)
        {
            return _repository.GetById(id);
        }

        public IQueryable<Dashboard> SelecionarTodos()
        {
            return _repository.GetAll();
        }

        public IQueryable<Dashboard> Filtrar(string condicao)
        {
            return _repository.Filter(condicao);
        }

        public string ValidarDados(Dashboard entity)
        {
            if (string.IsNullOrWhiteSpace(entity.Nome))
                return "Nome não informado!";
            else if (string.IsNullOrWhiteSpace(entity.Xml))
                return "Xml não informado!";
            else
                return "";
        }

        public string ValidarExclusao(Dashboard entity)
        {
            if ((from q in _db.Funcaos where q.DashboardId == entity.Id select q).Count() != 0)
                return "Não é permitido excluir uma Dashboard associada a uma ou mais recepções de protesto!";
            else
                return "";
        }
    }
}
