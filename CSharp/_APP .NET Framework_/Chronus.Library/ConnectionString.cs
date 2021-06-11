using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronus.Library
{
    public class ConnectionString
    {
        private ConnectionString()
        {
        }

        public static string SaveConnectionString(string fileconfig, string connection, string connectionstring, string providername)
        {
            try
            {
                var configMap = new ExeConfigurationFileMap();
                configMap.ExeConfigFilename = fileconfig;

                var config = ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None);
                if (config.ConnectionStrings.ConnectionStrings[connection] == null)
                    config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings(connection, connectionstring, providername));
                else
                {
                    config.ConnectionStrings.ConnectionStrings[connection].ConnectionString = connectionstring;
                    config.ConnectionStrings.ConnectionStrings[connection].ProviderName = providername;
                }

                config.Save();
                return "";
            }
            catch (Exception erro)
            {
                return erro.InnerException != null ? erro.InnerException.Message : erro.Message;
            }
        }

        public static string SaveAndProtectConnectionString(string fileconfig, string connection, string connectionstring, string providername)
        {
            try
            {
                var configMap = new ExeConfigurationFileMap();
                configMap.ExeConfigFilename = fileconfig;

                var config = ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None);
                if (config.ConnectionStrings.ConnectionStrings[connection] == null)
                    config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings(connection, connectionstring, providername));
                else
                {
                    config.ConnectionStrings.ConnectionStrings[connection].ConnectionString = connectionstring;
                    config.ConnectionStrings.ConnectionStrings[connection].ProviderName = providername;
                }

                var section = config.GetSection("connectionStrings");
                if (section != null && !section.SectionInformation.IsProtected)
                {
                    section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                    section.SectionInformation.ForceSave = true;
                }

                config.Save();
                return "";
            }
            catch (Exception erro)
            {
                return erro.InnerException != null ? erro.InnerException.Message : erro.Message;
            }
        }        

        public static string GetConnectionStringFastReport(string connection)
        {
            if (connection.ToLower().Contains(".fdb"))
            {
                string initialcatalog = "";
                string userid = "";
                string password = "";

                foreach (string s in connection.Split(';'))
                {
                    if (s.Split('=')[0].ToLower() == "datasource")
                        initialcatalog += s.Split('=')[1];
                    else if (s.Split('=')[0].ToLower() == "database")
                        initialcatalog += ":" + s.Split('=')[1];
                    else if (s.Split('=')[0].ToLower() == "user")
                        userid = s.Split('=')[1];
                    else if (s.Split('=')[0].ToLower() == "password")
                        password = s.Split('=')[1];
                }
                return string.Format("initial catalog={0};user id={1};password={2}", initialcatalog, userid, password);
            }
            else
                return connection;
        }

        public static string GetProviderName(string tipo)
        {
            switch (tipo)
            {
                case "F":
                    return "FirebirdSql.Data.FirebirdClient";
                case "S":
                    return "System.Data.SqlClient";
                default:
                    return "";
            }
        }

        public static string GetConnectionString(string tipo, string servidor, string bancodados, string usuario, string senha)
        {
            switch (tipo)
            {
                case "F":
                    return string.Format("DataSource={0};Database={1};User={2};Password={3};Charset=WIN1252", servidor, bancodados, usuario, senha);
                case "S":
                    return string.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};Integrated Security=False;Persist Security Info=True;Multipleactiveresultsets=True;", servidor, bancodados, usuario, senha);
                default:
                    return "";
            }
        }

    }
}
