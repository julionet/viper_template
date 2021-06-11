using VIPER.DTO;
using VIPER.Entity;
using System.Collections.Generic;

namespace VIPER.Service.Webapi_References
{
    public class FuncaoService : BaseClassService<Funcao>
    {
        public FuncaoService(string uri) : base(uri)
        {

        }

        public Funcao SelecionarCodigo(string codigo)
        {
            return WebapiSerializer.HttpGet<Funcao>(_uri, string.Format("selecionarcodigo/{0}", codigo));
        }

        public List<Funcao> SelecionarPorModulo(int id)
        {
            return WebapiSerializer.HttpGet<List<Funcao>>(_uri, string.Format("selecionarpormodulo/{0}", id));
        }

        public string ValidarDados(Funcao entity)
        {
            return WebapiSerializer.HttpPost<Funcao, string>(entity, _uri, "validardados");
        }

        public List<FuncaoDTO> SelecionarTodosCompleto()
        {
            return WebapiSerializer.HttpGet<List<FuncaoDTO>>(_uri, "selecionartodoscompleto");
        }
    }
}
