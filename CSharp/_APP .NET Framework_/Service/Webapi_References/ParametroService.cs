using VIPER.Entity;
using System.Collections.Generic;

namespace VIPER.Service.Webapi_References
{
    public class ParametroService : BaseClassService<Parametro>
    {
        public ParametroService(string uri) : base(uri)
        {
        }

        public string SelecionarValorParametro(string codigo, int usuario)
        {
            return WebapiSerializer.HttpGet<string>(_uri, string.Format("selecionarvalorparametro/{0}/{1}", codigo, usuario));
        }

        public List<Parametro> SelecionarPorCategoria(string categoria)
        {
            return WebapiSerializer.HttpGet<List<Parametro>>(_uri, string.Format("selecionarporcategoria/{0}", categoria));
        }

        public string GravarParametro(Parametro[] parametros)
        {
            return WebapiSerializer.HttpPost<Parametro[], string>(parametros, _uri, "gravarparametro");
        }
    }
}
