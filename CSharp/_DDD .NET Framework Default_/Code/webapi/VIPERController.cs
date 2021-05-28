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
        public IHttpActionResult Post(VIPER entity)
        {
            using (var context = new _NAMESPACE_Context())
            {
                using (var transaction = _NAMESPACE_Transaction.CreateDbContextTransaction(context))
                {
                    using (var repository = new VIPERRepository())
                    {
                        _mensagem = repository.Incluir(entity);

                        if (_mensagem == "")
                        {
                            transaction.Commit();
                            return Ok();
                        }
                        else
                        {
                            transaction.Rollback();
                            return BadRequest(_mensagem);
                        }
                    }
                }
            }
        }

        [HttpPut]
        public IHttpActionResult Put(VIPER entity)
        {
            using (var context = new _NAMESPACE_Context())
            {
                using (var transaction = _NAMESPACE_Transaction.CreateDbContextTransaction(context))
                {
                    using (var repository = new VIPERRepository())
                    {
                        _mensagem = repository.Alterar(entity);

                        if (_mensagem == "")
                        {
                            transaction.Commit();
                            return Ok();
                        }
                        else
                        {
                            transaction.Rollback();
                            return BadRequest(_mensagem);
                        }
                    }
                }
            }
        }

        [HttpDelete]
        [Route("id")]
        public IHttpActionResult Delete(int id)
        {
            using (var context = new _NAMESPACE_Context())
            {
                using (var transaction = _NAMESPACE_Transaction.CreateDbContextTransaction(context))
                {
                    using (var repository = new VIPERRepository())
                    {
                        var entity = repository.Selecionar(id);
                        if (entity != null)
                            _mensagem = repository.Excluir(entity);
                        else
                            _mensagem = "Registro não encontrado!";

                        if (_mensagem == "")
                        {
                            transaction.Commit();
                            return Ok();
                        }
                        else
                        {
                            transaction.Rollback();
                            return BadRequest(_mensagem);
                        }
                    }
                }
            }
        }

        [HttpGet]
        [Route("{id}")]
        public VIPER Get(int id)
        {
            return new VIPERRepository().Selecionar(id);
        }

        [HttpGet]
        public IEnumerable<VIPER> GetAll()
        {
            return new VIPERRepository().SelecionarTodos();
        }

        [HttpGet]
        [Route("filter")]
        public IEnumerable<VIPER> Filter(string condicao)
        {
            return new VIPERRepository().Filtrar(condicao);
        }

    }
}