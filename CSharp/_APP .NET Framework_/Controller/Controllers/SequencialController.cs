using VIPER.Controller.App_Start;
using VIPER.Repository;
using System.Web.Http;

namespace Cartsys.Service.Controllers
{
    [RoutePrefix("api/sequencial")]
    [BasicAuthentication]
    public class SequencialController : ApiController
    {
        [HttpGet]
        [Route("buscar")]
        public int Buscar(string nome)
        {
            return new SequencialRepository().Buscar(nome);
        }


        [HttpGet]
        [Route("consultar")]
        public int Consultar(string nome)
        {
            return new SequencialRepository().Consultar(nome);
        }


    }
}