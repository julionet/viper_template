using VIPER.DTO;
using System;

namespace VIPER.Service.Webapi_References
{
    public class DatabaseService
    {
        private string _uri;

        public DatabaseService(string uri)
        {
            _uri = uri;
        }

        public string GravarConnectionString(ConfiguracaoBancoDTO configuracao)
        {
            return WebapiSerializer.HttpPost<ConfiguracaoBancoDTO, string>(configuracao, _uri, "gravarconnectionstring");
        }

        public string CarregarConnectionString(string connectionstringname)
        {
            return WebapiSerializer.HttpGet<string>(_uri, string.Format("carregarconnectionstring/{0}", connectionstringname));
        }

        public string ConectarBanco()
        {
            return WebapiSerializer.HttpGet<string>(_uri, "conectarbanco");
        }

        public string ExecutarComandoSQL(string sql)
        {
            return WebapiSerializer.HttpPost<string, string>(sql, _uri, "executarcomandosql");
        }

        public DateTime ObterDataHoraServidor()
        {
            return WebapiSerializer.HttpGet<DateTime>(_uri, "obterdatahoraservidor");
        }

        public string ObterNumeroSerieHD()
        {
            return WebapiSerializer.HttpGet<string>(_uri, "obternumeroseriehd");
        }

        public int ObterDatabase()
        {
            return WebapiSerializer.HttpGet<int>(_uri, "obterdatabase");
        }
    }
}
