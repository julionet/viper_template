using VIPER.Entity;
using System.Collections.Generic;

namespace VIPER.Service.Webapi_References
{
    public class ParametroUsuarioService : BaseClassService<ParametroUsuario>
    {
        public ParametroUsuarioService(string uri) : base(uri)
        {

        }

        public List<ParametroUsuario> SelecionarPorParametro(int id)
        {
            return WebapiSerializer.HttpGet<List<ParametroUsuario>>(_uri, string.Format("selecionarporparametro/{0}", id));
        }
    }
}
