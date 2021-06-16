using VIPER.Controller.App_Start;
using VIPER.DTO;
using VIPER.Entity;
using VIPER.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace VIPER.Controller.Controllers
{
    [RoutePrefix("api/funcao")]
    [BasicAuthentication]
    public class FuncaoController : ApiController
    {
        [HttpGet]
        [Route("selecionar/{id}")]
        public Funcao Selecionar(int id)
        {
            return new FuncaoRepository().Selecionar(id);
        }

        [HttpGet]
        [Route("selecionarcodigo/{codigo}")]
        public Funcao SelecionarCodigo(string codigo)
        {
            return new FuncaoRepository().Selecionar(codigo);
        }

        [HttpGet]
        [Route("selecionartodos")]
        public List<Funcao> SelecionarTodos()
        {
            return new FuncaoRepository().SelecionarTodos().ToList();
        }

        [HttpGet]
        [Route("selecionarpormodulo/{id}")]
        public List<Funcao> SelecionarPorModulo(int id)
        {
            return new FuncaoRepository().SelecionarPorModulo(id).ToList();
        }

        [HttpGet]
        [Route("filtrar")]
        public List<Funcao> Filtrar(string condicao)
        {
            return new FuncaoRepository().Filtrar(condicao).ToList();
        }

        [HttpPost]
        [Route("validardados")]
        public string ValidarDados(Funcao entity)
        {
            return new FuncaoRepository().ValidarDados(entity);
        }

        [HttpGet]
        [Route("selecionartodoscompleto")]
        public List<FuncaoDTO> SelecionarTodosCompleto()
        {
            return new FuncaoRepository().SelecionarTodosCompleto().ToList();
        }
		
		[HttpGet]
        [Route("selecionarrelatorioporsistema/{sistema}")]
        public List<Funcao> SelecionarRelatorioPorSistema(int sistema)
        {
            return new FuncaoRepository().SelecionarRelatorioPorSistema(sistema).ToList();
        }
    }
}