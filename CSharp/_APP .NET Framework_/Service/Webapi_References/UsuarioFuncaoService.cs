using VIPER.DTO;
using VIPER.Entity;
using System.Collections.Generic;

namespace VIPER.Service.Webapi_References
{
    public class UsuarioFuncaoService : BaseClassService<UsuarioFuncao>
    {
        public UsuarioFuncaoService(string uri) : base(uri)
        {

        }

        public string Salvar(UsuarioUsuarioFuncaoDTO entity)
        {
            return WebapiSerializer.HttpPost<UsuarioUsuarioFuncaoDTO, string>(entity, _uri, "salvar");
        }

        public UsuarioFuncao SelecionarFuncao(int usuario, int funcao)
        {
            return WebapiSerializer.HttpGet<UsuarioFuncao>(_uri, string.Format("selecionarfuncao/{0}/{1}", usuario, funcao));
        }

        public List<UsuarioFuncaoDTO> SelecionarPorUsuario(int usuario, int sistema)
        {
            return WebapiSerializer.HttpGet<List<UsuarioFuncaoDTO>>(_uri, string.Format("selecionarporusuario/{0}/{1}", usuario, sistema));
        }

        public List<UsuarioFuncaoDTO> SelecionarAcessoPorUsuarioModulo(int usuario, int modulo, int sistema)
        {
            return WebapiSerializer.HttpGet<List<UsuarioFuncaoDTO>>(_uri, string.Format("selecionaracessoporusuariomodulo/{0}/{1}/{2}", usuario, modulo, sistema));
        }        
    }
}
