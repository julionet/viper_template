namespace VIPER.Gerenciador
{
    public class SettingsDefault
    {
        public SettingsDefault()
        {
        }

        public string SkinName
        {
            get { return Properties.Settings.Default.SkinName; }
            set { Properties.Settings.Default.SkinName = value; }
        }

        public double FontSize
        {
            get { return Properties.Settings.Default.FontSize; }
            set { Properties.Settings.Default.FontSize = value; }
        }

        public void Salvar()
        {
            Properties.Settings.Default.Save();
        }
    }
}
