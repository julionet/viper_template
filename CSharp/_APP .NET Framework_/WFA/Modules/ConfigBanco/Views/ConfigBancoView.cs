using VIPER.Modules.ConfigBanco.Interfaces;
using Chronus.DXperience;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace VIPER.Modules.ConfigBanco.Views
{
    public partial class ConfigBancoView : FrmModelo, IPresenterToViewConfigBanco
    {
        public IViewToPresenterConfigBanco presenter;

        public ConfigBancoView()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtServico.Text))
            {
                XtraMessageBox.Show("Serviço não informada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
            }
            else
            {
                var settings = new Service.SettingsDefault
                {
                    ServidorAPI = txtServico.Text
                };
                settings.Save();
				XtraMessageBox.Show("Configurações salvas com sucesso!\r\nÉ necessário reiniciar o aplicativo!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void icbTipo_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void InitializeConfigurations()
        {
            presenter.CarregarConfiguracao("_VIPER_ConnectionString");
        }

        public void CarregarConfiguracaoSucesso(string connectionstring)
        {
            icbTipo.EditValue = "S";
            foreach (string tag in connectionstring.Split(';'))
            {
                if (tag.ToLower().Contains("data source"))
                    txtServidor.Text = tag.Split('=')[1];
                else if (tag.ToLower().Contains("initial catalog"))
                    betBancoDados.Text = tag.Split('=')[1];
                else if (tag.ToLower().Contains("user id"))
                    txtUsuario.Text = tag.Split('=')[1];
                else if (tag.ToLower().Contains("password"))
                    txtSenha.Text = tag.Split('=')[1];
            }
            txtServico.Text = new Service.SettingsDefault().ServidorAPI;
        }

        public void CarregarConfiguracaoFalha(string mensagem)
        {
            txtServico.Text = new Service.SettingsDefault().ServidorAPI;
        }

        private void ConfigBancoView_Load(object sender, EventArgs e)
        {
            InitializeConfigurations();
            icbTipo_EditValueChanged(null, null);
        }
    }
}
