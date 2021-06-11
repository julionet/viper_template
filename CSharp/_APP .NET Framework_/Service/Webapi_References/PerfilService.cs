using VIPER.DTO;
using VIPER.Entity;
using System.Collections.Generic;

namespace VIPER.Service.Webapi_References
{
    public class PerfilService : BaseClassService<Perfil>
    {
        public PerfilService(string uri) : base(uri)
        {

        }

        public string Salvar(PerfilPerfilFuncaoDTO entity)
        {
            return WebapiSerializer.HttpPost<PerfilPerfilFuncaoDTO, string>(entity, _uri, "salvar");
        }

        public List<PerfilFuncaoDTO> SelecionarPorPerfil(int usuario, int sistema)
        {
            return WebapiSerializer.HttpGet<List<PerfilFuncaoDTO>>(_uri, string.Format("selecionarporperfil/{0}/{1}", usuario, sistema));
        }   
    }
}
