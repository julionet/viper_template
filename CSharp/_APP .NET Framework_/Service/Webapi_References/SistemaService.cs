using VIPER.DTO;
using VIPER.Entity;
using System.Collections.Generic;

namespace VIPER.Service.Webapi_References
{
    public class SistemaService : BaseClassService<Sistema>
    {
        public SistemaService(string uri) : base(uri)
        {
        }

        public string Salvar(SistemaModuloFuncaoDTO entity)
        {
            return WebapiSerializer.HttpPost<SistemaModuloFuncaoDTO, string>(entity, _uri, "salvar");
        }

        public List<Sistema> SelecionarAtivos()
        {
            return WebapiSerializer.HttpGet<List<Sistema>>(_uri, "selecionarativos");
        }

        public List<Sistema> SelecionarAtivosPorTipo(string tipo)
        {
            return WebapiSerializer.HttpGet<List<Sistema>>(_uri, string.Format("selecionarativosportipo/{0}", tipo));
        }
    }
}
