using System.ComponentModel;
using System.Configuration;

namespace VIPER.Servico
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();

            var configMap = new ExeConfigurationFileMap();
            configMap.ExeConfigFilename = "VIPER.Servico.exe.config";
            var config = ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None);
            if (config != null)
            {
                if (config.AppSettings.Settings["service_name"] != null)
                    serviceInstaller.ServiceName = config.AppSettings.Settings["service_name"].Value;

                if (config.AppSettings.Settings["display_name"] != null)
                    serviceInstaller.DisplayName = config.AppSettings.Settings["display_name"].Value;

                if (config.AppSettings.Settings["description"] != null)
                    serviceInstaller.Description = config.AppSettings.Settings["description"].Value;
            }
        }
    }
}
