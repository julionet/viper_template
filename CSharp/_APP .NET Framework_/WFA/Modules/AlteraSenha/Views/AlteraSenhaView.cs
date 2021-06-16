using System;
using System.Windows.Forms;
using VIPER.DTO;
using VIPER.Modules.AlteraSenha.Interfaces;
using VIPER.Service;
using Chronus.DXperience;
using DevExpress.XtraEditors;

namespace VIPER.Modules.AlteraSenha.Views
{
    public partial class AlteraSenhaView : FrmModelo, IPresenterToViewAlteraSenha
    {
        public IViewToPresenterAlteraSenha presenter;

        private SplashScreen splash;

        public AlteraSenhaView(string senhaantiga)
        {
            InitializeComponent();

            if (!string.IsNullOrWhiteSpace(senhaantiga))
            {
                txtSenhaAntiga.EditValue = senhaantiga;
                txtSenhaAntiga.Properties.ReadOnly = true;
            }
        }

        public void AlterarSenhaFalha(string mensagem)
        {
            splash.FinalizarSplashScreen();
            XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtSenhaAntiga.Focus();
            txtSenhaAntiga.SelectAll();
            DialogResult = DialogResult.None;
        }

        public void AlterarSenhaSucesso()
        {
            splash.FinalizarSplashScreen();
            XtraMessageBox.Show("Senha alterada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            splash = new SplashScreen("Alterando senha do usuário...");
            presenter.AlterarSenha(new LoginDTO
            {
                Usuario = Global.Instance.UsuarioLogado.Login,
                Senha = txtSenhaAntiga.Text,
                NovaSenha = txtNovaSenha.Text,
                Confirmacao = txtConfirmacao.Text
            });
        }

        private void FrmAlterarSenha_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Global.Instance.UsuarioLogado.Nome;
            txtSenhaAntiga.Focus();
            txtSenhaAntiga.Select();
        }
    }
}
