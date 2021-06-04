using VIPER.Controller.App_Start;
using VIPER.Entity;
using VIPER.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Cartsys.Service.Controllers
{
    [RoutePrefix("api/modulo")]
    [BasicAuthentication]
    public class ModuloController : ApiController
    {
        [HttpGet]
        [Route("selecionar/{id}")]
        public Modulo Selecionar(int id)
        {
            return new ModuloRepository().Selecionar(id);
        }

        [HttpGet]
        [Route("selecionartodos")]
        public List<Modulo> SelecionarTodos()
        {
            return new ModuloRepository().SelecionarTodos().ToList();
        }

        [HttpGet]
        [Route("selecionarporsistema/{sistema}")]
        public List<Modulo> SelecionarPorSistema(int sistema)
        {
            return new ModuloRepository().SelecionarPorSistema(sistema).ToList();
        }

        [HttpGet]
        [Route("selecionarporsistemausuario/{sistema}/{usuario}")]
        public List<Modulo> SelecionarPorSistemaUsuario(int sistema, int usuario)
        {
            return new ModuloRepository().SelecionarPorSistemaUsuario(sistema, usuario).ToList();
        }

        [HttpGet]
        [Route("filtrar")]
        public List<Modulo> Filtrar(string condicao)
        {
            return new ModuloRepository().Filtrar(condicao).ToList();
        }

        [HttpPost]
        [Route("validardados")]
        public string ValidarDados(Modulo entity)
        {
            return new ModuloRepository().ValidarDados(entity);
        }
    }
}