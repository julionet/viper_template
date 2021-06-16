namespace Chronus.DXperience
{
    public class SettingsDefault
    {
        public SettingsDefault()
        {
        }

        public bool EnterMudaCampo
        {
            get { return Properties.Settings.Default.EnterMudaCampo; }
            set { Properties.Settings.Default.EnterMudaCampo = value; }
        }

        public bool ExibirRegistroPopup
        {
            get { return Properties.Settings.Default.ExibirRegistroPopup; }
            set { Properties.Settings.Default.ExibirRegistroPopup = value; }
        }

        public bool ExibirTodosRegistros
        {
            get { return Properties.Settings.Default.ExibirTodosRegistros; }
            set { Properties.Settings.Default.ExibirTodosRegistros = value; }
        }

        public void Salvar()
        {
            Properties.Settings.Default.Save();
        }
    }
}
