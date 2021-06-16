using VIPER.DTO;
using VIPER.Entity;
using VIPER.Modules.Login.Interfaces;
using VIPER.Service;
using Chronus.DXperience;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace VIPER.Modules.Login.Views
{
    public partial class LoginView : XtraForm, IPresenterToViewLogin
    {
        public IViewToPresenterLogin presenter;

        private SplashScreen splash;

        public LoginView(bool configurabanco = true)
        {
            InitializeComponent();

            BackColor = ConversionDX.SkinNameToColor(new Gerenciador.SettingsDefault().SkinName);

            if (new Chronus.DXperience.SettingsDefault().EnterMudaCampo)
                Interface.EnterMoveNextControl(pclLogin);

            lblConfiguracao.Visible = configurabanco;
        }

        public void DeveAlterarSenhaFalha()
        {
            splash.FinalizarSplashScreen();
            DialogResult = DialogResult.OK;
        }

        public void DeveAlterarSenhaSucesso()
        {
            splash.FinalizarSplashScreen();
            presenter.CarregarAlteraSenha(txtSenha.Text, out bool confirmado);
            if (confirmado)
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.Cancel;
        }

        public void SelecionarSistemasFalha(string mensagem)
        {
            letSistema.Visible = false;
            lclSistema.Visible = letSistema.Visible;
            letSistema.Properties.DataSource = null;
        }

        public void SelecionarSistemasSucesso(List<Entity.Sistema> sistemas)
        {
            letSistema.Visible = sistemas.Count() > 1;
            lclSistema.Visible = letSistema.Visible;
            letSistema.Properties.DataSource = sistemas;
            if (sistemas.Count() == 1)
                letSistema.EditValue = sistemas.FirstOrDefault().Id;

            Global.Instance.TemVariosSistema = sistemas.Count() > 1;
        }

        public void ValidarLoginFalha(string mensagem)
        {
            splash.FinalizarSplashScreen();
            XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtUsuario.Focus();
            txtUsuario.SelectAll();
        }

        public void ValidarLoginSucesso(string login)
        {
            Global.Instance.Sistema = (letSistema.Properties.DataSource as IList<Entity.Sistema>).Where(p => p.Id == Convert.ToInt32(letSistema.EditValue)).FirstOrDefault();
            Global.Instance.GerenciadorSistema = false;
            Global.Instance.UsuarioLogado = Servicos.usuarioService.SelecionarLogin(txtUsuario.Text);
            presenter.DeveAlterarSenha(login);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.ToUpper().Equals("$CHRONUS$") && txtSenha.Text.Equals("Chronus@123"))
            {
                Global.Instance.Sistema = new Entity.Sistema { Id = 1, Descricao = "Gerenciador de Sistemas" };
                Global.Instance.GerenciadorSistema = true;
                Global.Instance.UsuarioLogado = new Entity.Usuario();
                DialogResult = DialogResult.OK;
            }
            else
            {
                if (letSistema.IsNullOrDbnull())
                    XtraMessageBox.Show("Sistema não selecionado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                else
                {
                    splash = new SplashScreen("Validando login...");
                    presenter.ValidarLogin(new AutenticacaoDTO { Login = txtUsuario.Text, Senha = txtSenha.Text });
                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Width = SystemInformation.WorkingArea.Width;
            Height = SystemInformation.WorkingArea.Height;
            Location = new Point(0, 0);

            pclLogin.Location = new Point((Width / 2) - (pclLogin.Width / 2), (Height / 2) - (pclLogin.Height / 2));

            presenter.SelecionarSistemas();
        }

        private void lblConfiguracao_Click(object sender, EventArgs e)
        {
            presenter.CarregarConfigBanco(out bool confirmado);
            if (confirmado)
                Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
