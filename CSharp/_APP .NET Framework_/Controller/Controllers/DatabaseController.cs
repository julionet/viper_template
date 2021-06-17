using VIPER.Controller.App_Start;
using VIPER.DTO;
using VIPER.Infrastructure;
using VIPER.Repository;
using Chronus.Library;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Hosting;
using System.Web.Http;

namespace VIPER.Controller.Controllers
{
    [RoutePrefix("api/database")]
    [BasicAuthentication]
    public class DatabaseController : ApiController
    {
        private string _mensagem = "";

        [HttpPost]
        [Route("gravarconnectionstring")]
        public string GravarConnectionString(ConfiguracaoBancoDTO configuracao)
        {
            var web_config = new AppConfig(HostingEnvironment.ApplicationPhysicalPath + "Web.config");
            web_config.Tag = "connectionStrings";
            web_config.AtributoChave = "name";
            web_config.Atributo = "connectionString";
            if (!web_config.SetValue("_VIPER_ConnectionString", ConnectionString.GetConnectionString(configuracao.Tipo, configuracao.Servidor, configuracao.BancoDados, configuracao.Usuario, configuracao.Senha), ref _mensagem))
            {
                return _mensagem;
            }
            else
            {
                web_config.Atributo = "providerName";
                if (!web_config.SetValue("_VIPER_ConnectionString", ConnectionString.GetProviderName(configuracao.Tipo), ref _mensagem))
                {
                    return _mensagem;
                }
                else
                {
                    return "";
                }
            }

        }

        [HttpGet]
        [Route("carregarconnectionstring/{connectionstringname}")]
        public string CarregarConnectionString(string connectionstringname)
        {
            return ConfigurationManager.ConnectionStrings[connectionstringname].ConnectionString;
        }

        [HttpGet]
        [Route("conectarbanco")]
        public string ConectarBanco()
        {
            try
            {
                var db = new _VIPER_Context();
                if (db.Database.Exists())
                {
                    db.Database.Connection.Open();
                    return "";
                }
                else
                    return "Banco de dados não encontrado!";
            }
            catch (Exception erro)
            {
                if (erro.InnerException != null)
                    return erro.InnerException.Message;
                else
                    return erro.Message;
            }
        }

        [HttpPost]
        [Route("executarcomandosql")]
        public string ExecutarComandoSQL([FromBody]string sql)
        {
            return new DatabaseRepository().ExecutarComandoSQL(sql);
        }

        [HttpGet]
        [Route("obterdatahoraservidor")]
        public DateTime ObterDataHoraServidor()
        {
            return new DatabaseRepository().GetDateTimeServer();
        }

        [HttpGet]
        [Route("obternumeroseriehd")]
        public string ObterNumeroSerieHD()
        {
            return new DatabaseRepository().GetSerialNumberHD();
        }
		
		[HttpPost]
        [Route("executarsql")]
        public List<LookupDataSourceDTO> ExecutarSQL([FromBody] string sql)
        {
            return new DatabaseRepository().ExecutarSQL<LookupDataSourceDTO>(sql).ToList();
        }
    }
}