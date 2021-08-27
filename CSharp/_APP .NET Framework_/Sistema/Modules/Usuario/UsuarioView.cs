using VIPER.Modules.Usuario.Interfaces;
using Chronus.DXperience;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VIPER.Modules.Usuario.Views
{
    public partial class UsuarioView : FrmManutencao, IPresenterToViewUsuario
    {
        public IViewToPresenterUsuario presenter;

        private SplashScreen _splash;

        public UsuarioView(int funcao)
        {
            InitializeComponent();

            FuncaoId = funcao;

            PermiteIncluir = true;
            PermiteAlterar = true;
            PermiteExcluir = true;
        }

        protected override void IncluirRegistro()
        {
            (principalBindingSource.Current as Entity.Usuario).Id = iKey = 0;
            (principalBindingSource.Current as Entity.Usuario).Master = false;
            (principalBindingSource.Current as Entity.Usuario).Bloqueado = false;
            (principalBindingSource.Current as Entity.Usuario).Administrador = false;
            (principalBindingSource.Current as Entity.Usuario).AlterarSenha = true;
            (principalBindingSource.Current as Entity.Usuario).NuncaExpira = false;
            (principalBindingSource.Current as Entity.Usuario).DataAlteracao = DateTime.Today;
            (principalBindingSource.Current as Entity.Usuario).DiasExpirar = 90;
            principalBindingSource.ResetCurrentItem();

            ckeNuncaExpira_CheckedChanged(null, null);
            txtSenha.Enabled = true;
        }

        protected override void AlterarRegistro()
        {
            iKey = (principalBindingSource.Current as Entity.Usuario).Id;
            ckeNuncaExpira_CheckedChanged(null, null);
            txtSenha.Enabled = false;
        }

        protected override void ObterDadosPrincipal()
        {
            principalBindingSource.Clear();
            if (!string.IsNullOrWhiteSpace(sCondicao))
            {
                _splash = new SplashScreen("Buscando informações...");
                presenter.ObterDadosPrincipal(sCondicao);
            }
        }
        protected override void GravarRegistro()
        {
            _splash = new SplashScreen("Gravando registro...");
            presenter.Gravar(principalBindingSource.Current as Entity.Usuario);
        }

        protected override void ExcluirRegistro()
        {
            _splash = new SplashScreen("Excluindo registro...");
            presenter.Excluir(principalBindingSource.Current as Entity.Usuario);
        }

        private void gvwAcesso_DoubleClick(object sender, EventArgs e)
        {
            btnEditar_Click(null, null);
        }

        private void ckeNuncaExpira_CheckedChanged(object sender, EventArgs e)
        {
            if (bInsertOrEdit)
                cetDias.Enabled = !ckeNuncaExpira.Checked;
        }

        public void ObterDadosPrincipalSucesso(List<Entity.Usuario> dados)
        {
            _splash.FinalizarSplashScreen();
            principalBindingSource.DataSource = dados;
        }

        public void ObterDadosPrincipalFalha()
        {
            _splash.FinalizarSplashScreen();
        }

        public void GravarSucesso()
        {
            _splash.FinalizarSplashScreen();
            ExecutarAposGravar();
        }

        public void GravarFalha(string mensagem)
        {
            _splash.FinalizarSplashScreen();
            XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void ExcluirSucesso()
        {
            _splash.FinalizarSplashScreen();
            ExecutarAposExcluir();
        }

        public void ExcluirFalha(string mensagem)
        {
            _splash.FinalizarSplashScreen();
            XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
