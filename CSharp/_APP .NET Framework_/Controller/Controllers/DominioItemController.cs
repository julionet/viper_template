using VIPER.Controller.App_Start;
using VIPER.Entity;
using VIPER.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace VIPER.Controller.Controllers
{
    [RoutePrefix("api/dominioitem")]
    [BasicAuthentication]
    public class DominioItemController : ApiController
    {
        [HttpGet]
        [Route("selecionartodos")]
        public List<DominioItem> SelecionarTodos()
        {
            return new DominioItemRepository().SelecionarTodos().ToList();
        }

        [HttpGet]
        [Route("selecionarpordominio/{id}")]
        public List<DominioItem> SelecionarPorDominio(int id)
        {
            return new DominioItemRepository().SelecionarPorDominio(id).ToList();
        }
    }
}