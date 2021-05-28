using System.Collections.Generic;
using System.Web.Http;
using NAMESPACE.Entity;
using NAMESPACE.Infrastructure;
using NAMESPACE.Repository;

namespace NAMESPACE.Controller.Controllers
{
    [RoutePrefix("api/VIPER")]
    public class VIPERController : ApiController
    {
        private string _mensagem = "";

        [HttpPost]
		[Route("salvar")]
        public string Salvar(VIPER entity)
        {
            using (var context = new _NAMESPACE_Context())
            {
                using (var transaction = _NAMESPACE_Transaction.CreateDbContextTransaction(context))
                {
                    using (var repository = new VIPERRepository())
                    {
						if (entity.Id == 0)
							_mensagem = repository.Incluir(entity);
						else
							_mensagem = repository.Alterar(entity);

                        if (_mensagem == "")
                        {
                            transaction.Commit();
                        }
                        else
                        {
                            transaction.Rollback();
                        }
                    }
                }
            }
			
			return _mensagem;
        }

        [HttpPost]
        [Route("excluir")]
        public string Excluir(VIPER entity)
        {
            using (var context = new _NAMESPACE_Context())
            {
                using (var transaction = _NAMESPACE_Transaction.CreateDbContextTransaction(context))
                {
                    using (var repository = new VIPERRepository())
                    {
                        _mensagem = repository.Excluir(entity);
                        
                        if (_mensagem == "")
                        {
                            transaction.Commit();
                        }
                        else
                        {
                            transaction.Rollback();
                        }
                    }
                }
            }
			
			return _mensagem;
        }

        [HttpGet]
        [Route("selecionar/{id}")]
        public VIPER Selecionar(int id)
        {
            return new VIPERRepository().Selecionar(id);
        }

        [HttpGet]
		[Route("selecionartodos")]
        public IEnumerable<VIPER> SelecionarTodos()
        {
            return new VIPERRepository().SelecionarTodos();
        }

        [HttpGet]
        [Route("filtrar")]
        public IEnumerable<VIPER> Filtrar(string condicao)
        {
            return new VIPERRepository().Filtrar(condicao);
        }

    }
}