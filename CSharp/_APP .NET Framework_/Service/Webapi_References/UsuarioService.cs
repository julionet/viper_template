using VIPER.DTO;
using VIPER.Entity;
using System.Collections.Generic;

namespace VIPER.Service.Webapi_References
{
    public class UsuarioService : BaseClassService<Usuario>
    {
        public UsuarioService(string uri) : base(uri)
        {

        }

        public new List<UsuarioDTO> Filtrar(string condicao)
        {
            return WebapiSerializer.HttpPost<string, List<UsuarioDTO>>(condicao, _uri, "filtrar");
        }

        public UsuarioDTO SelecionarLogin(string login)
        {
            return WebapiSerializer.HttpGet<UsuarioDTO>(_uri, string.Format("selecionarlogin/{0}", login));
        }

        public List<Usuario> SelecionarNaoMaster()
        {
            return WebapiSerializer.HttpGet<List<Usuario>>(_uri, "selecionarnaomaster");
        }

        public string ValidarLogin(AutenticacaoDTO login)
        {
            return WebapiSerializer.HttpPost<AutenticacaoDTO, string>(login, _uri, "validarlogin");
        }

        public bool DeveAlterarSenha(string usuario)
        {
            return WebapiSerializer.HttpGet<bool>(_uri, string.Format("devealterarsenha/{0}", usuario));
        }

        public string AlterarSenha(LoginDTO login)
        {
            return WebapiSerializer.HttpPost<LoginDTO, string>(login, _uri, "alterarsenha");
        }

        public List<Perfil> SelecionarPerfis(int usuario)
        {
            return WebapiSerializer.HttpGet<List<Perfil>>(_uri, string.Format("selecionarperfis/{0}", usuario));
        }
    }
}
