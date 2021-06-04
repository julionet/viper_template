using VIPER.Entity;
using VIPER.Infrastructure;
using VIPER.Repository.Interface;
using System.Linq;

namespace VIPER.Repository
{
    public class DominioItemRepository
    {
        private IRepository<DominioItem> _repository;

        public DominioItemRepository()
        {
            _repository = new Repository<DominioItem>(new _VIPER_Context());
        }

        public IQueryable<DominioItem> SelecionarTodos()
        {
            return _repository.GetAll();
        }

        public IQueryable<DominioItem> SelecionarPorDominio(int id)
        {
            return _repository.GetAll().Where(p => p.DominioId == id);
        }

        public bool ValidarDominioItem(int dominio, string valor)
        {
            return this.SelecionarPorDominio(dominio).Where(p => p.Valor == valor).Count() != 0;
        }
    }
}
