namespace VIPER.Service
{
    public class SettingsDefault
    {
        public SettingsDefault()
        {
        }

        public string ServidorAPI
        {
            get { return Properties.Settings.Default.ServidorAPI; }
            set { Properties.Settings.Default.ServidorAPI = value; }
        }

        public void Save()
        {
            Properties.Settings.Default.Save();
        }
    }
}
