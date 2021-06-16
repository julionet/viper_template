using VIPER.Modules.Configuracao.Interfaces;
using Chronus.DXperience;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors.Controls;
using System;
using System.Windows.Forms;

namespace VIPER.Modules.Configuracao.Views
{
    public partial class ConfiguracaoView : FrmModelo, IPresenterToViewConfiguracao
    {
        public IViewToPresenterConfiguracao presenter;

        Gerenciador.SettingsDefault settingslocal = new Gerenciador.SettingsDefault();
        DXperience.SettingsDefault settingslibrary = new DXperience.SettingsDefault();

        public ConfiguracaoView(int funcao)
        {
            InitializeComponent();

            cbeSkinName.EditValue = settingslocal.SkinName;
            cetTamanhoFonte.EditValue = settingslocal.FontSize;

            ckeEnter.Checked = settingslibrary.EnterMudaCampo;

            SkinContainerCollection skins = SkinManager.Default.Skins;
            foreach (var skin in skins)
            {
                cbeSkinName.Properties.Items.Add(new ImageComboBoxItem { Description = (skin as SkinContainer).SkinName, Value = (skin as SkinContainer).SkinName });
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            settingslocal.SkinName = cbeSkinName.EditValue.ToString();
            settingslocal.FontSize = Convert.ToDouble(cetTamanhoFonte.EditValue);
            settingslocal.Salvar();

            settingslibrary.EnterMudaCampo = ckeEnter.Checked;
            settingslibrary.Salvar();

            btnCancelar_Click(sender, e);
        }

        private void cbeSkinName_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle(cbeSkinName.Text);
            var form = Application.OpenForms["PrincipalView"];
            if (form != null)
            {
                foreach (var item in (form.Controls["tileBarPrincipal"] as TileBar).Groups[0].Items)
                {
                    (item as TileBarItem).AppearanceItem.Normal.BackColor = ConversionDX.SkinNameToColor(cbeSkinName.Text); //(form.Controls["tileNavPanePrincipal"] as TileNavPane).Appearance.BackColor;
                    (item as TileBarItem).AppearanceItem.Disabled.BackColor = ConversionDX.SkinNameToColor(cbeSkinName.Text);
                    (item as TileBarItem).AppearanceItem.Hovered.BackColor = ConversionDX.SkinNameToColor(cbeSkinName.Text);
                    (item as TileBarItem).AppearanceItem.Selected.BackColor = ConversionDX.SkinNameToColor(cbeSkinName.Text);
                }
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle(settingslocal.SkinName);
        }
    }
}
