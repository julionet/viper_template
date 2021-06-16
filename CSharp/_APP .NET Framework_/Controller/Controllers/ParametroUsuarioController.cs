using VIPER.Controller.App_Start;
using VIPER.Entity;
using VIPER.Infrastructure;
using VIPER.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace VIPER.Controller.Controllers
{
    [RoutePrefix("api/parametrousuario")]
    [BasicAuthentication]
    public class ParametroUsuarioController : ApiController
    {
        private string _mensagem = "";

        [HttpPost]
        [Route("salvar")]
        public string Salvar(ParametroUsuario entity)
        {
            using (var _db = new _VIPER_Context())
            {
                using (var transacao = _VIPER_Transaction.CreateDbContextTransaction(_db))
                {
                    if (entity.Id == 0)
                        _mensagem = new ParametroUsuarioRepository(_db).Incluir(entity);
                    else
                        _mensagem = new ParametroUsuarioRepository(_db).Alterar(entity);

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
        public string Excluir(ParametroUsuario entity)
        {
            using (var _db = new _VIPER_Context())
            {
                using (var transacao = _VIPER_Transaction.CreateDbContextTransaction(_db))
                {
                    _mensagem = new ParametroUsuarioRepository(_db).Excluir(entity);

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
        public ParametroUsuario Selecionar(int id)
        {
            return new ParametroUsuarioRepository().Selecionar(id);
        }

        [HttpGet]
        [Route("selecionartodos")]
        public List<ParametroUsuario> SelecionarTodos()
        {
            return new ParametroUsuarioRepository().SelecionarTodos().ToList();
        }

        [HttpGet]
        [Route("selecionarporparametro/{id}")]
        public List<ParametroUsuario> SelecionarPorParametro(int id)
        {
            return new ParametroUsuarioRepository().SelecionarPorParametro(id).ToList();
        }

        [HttpGet]
        [Route("filtrar")]
        public List<ParametroUsuario> Filtrar(string condicao)
        {
            return new ParametroUsuarioRepository().Filtrar(condicao).ToList();
        }
    }
}