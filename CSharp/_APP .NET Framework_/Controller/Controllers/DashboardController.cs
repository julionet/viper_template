using VIPER.Controller.App_Start;
using VIPER.Entity;
using VIPER.Infrastructure;
using VIPER.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace VIPER.Controller.Controllers
{
    [RoutePrefix("api/dashboard")]
    [BasicAuthentication]
    public class DashboardController : ApiController
    {
        private string _mensagem = "";

        [HttpPost]
        [Route("salvar")]
        public string Salvar(Dashboard entity)
        {
            using (var _db = new _VIPER_Context())
            {
                using (var transacao = _VIPER_Transaction.CreateDbContextTransaction(_db))
                {
                    if (entity.Id == 0)
                        _mensagem = new DashboardRepository(_db).Incluir(entity);
                    else
                        _mensagem = new DashboardRepository(_db).Alterar(entity);

                    if (_mensagem == "")
                        transacao.Commit();
                    else
                        transacao.Rollback();
                }
            }
            return _mensagem;
        }

        [HttpPost]
        [Route("excluir")]
        public string Excluir(Dashboard entity)
        {
            using (var _db = new _VIPER_Context())
            {
                using (var transacao = _VIPER_Transaction.CreateDbContextTransaction(_db))
                {
                    _mensagem = new DashboardRepository(_db).Excluir(entity);
                    if (_mensagem == "")
                        transacao.Commit();
                    else
                        transacao.Rollback();
                }
            }
            return _mensagem;
        }

        [HttpGet]
        [Route("selecionar/{id}")]
        public Dashboard Selecionar(int id)
        {
            return new DashboardRepository().Selecionar(id);
        }

        [HttpGet]
        [Route("selecionartodos")]
        public List<Dashboard> SelecionarTodos()
        {
            return new DashboardRepository().SelecionarTodos().ToList();
        }

        [HttpGet]
        [Route("filtrar")]
        public List<Dashboard> Filtrar(string condicao)
        {
            return new DashboardRepository().Filtrar(condicao).ToList();
        }
    }
}