using VIPER.DTO;
using VIPER.Entity;

namespace VIPER.Service.Webapi_References
{
    public class BloqueioService : BaseClassService<Bloqueio>
    {
        public BloqueioService(string uri) : base(uri)
        {
        }

        public string BloquearRegistro(BloquearRegistroDTO bloqueio)
        {
            return WebapiSerializer.HttpPost<BloquearRegistroDTO, string>(bloqueio, _uri, string.Format($"bloquearregistro"));
        }

        public void ExcluirBloqueio(string classe, int referencia)
        {
            WebapiSerializer.HttpGet<object>(_uri, string.Format("excluirbloqueio/{0}/{1}", classe, referencia));
        }

        public void AtualizarBloqueio(string classe, int referencia)
        {
            WebapiSerializer.HttpGet<object>(_uri, string.Format("atualizarbloqueio/{0}/{1}", classe, referencia));
        }

        public string ConsultarBloqueio(string classe, int referencia)
        {
            return WebapiSerializer.HttpGet<string>(_uri, string.Format("consultarbloqueio/{0}/{1}", classe, referencia));
        }
    }
}
