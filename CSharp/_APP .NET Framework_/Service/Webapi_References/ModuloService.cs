using VIPER.Entity;
using System.Collections.Generic;

namespace VIPER.Service.Webapi_References
{
    public class ModuloService : BaseClassService<Modulo>
    {
        public ModuloService(string uri) : base(uri)
        {

        }

        public List<Modulo> SelecionarPorSistema(int sistema)
        {
            return WebapiSerializer.HttpGet<List<Modulo>>(_uri, string.Format("selecionarporsistema/{0}", sistema));
        }

        public List<Modulo> SelecionarPorSistemaUsuario(int sistema, int usuario)
        {
            return WebapiSerializer.HttpGet<List<Modulo>>(_uri, string.Format("selecionarporsistemausuario/{0}/{1}", sistema, usuario));
        }

        public string ValidarDados(Modulo entity)
        {
            return WebapiSerializer.HttpPost<Modulo, string>(entity, _uri, "validardados");
        }
    }
}
