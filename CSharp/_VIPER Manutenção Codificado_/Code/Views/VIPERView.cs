using Chronus.DXperience;
using NAMESPACE.Modules.__MODULENAME__.Interfaces;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NAMESPACE.Modules.__MODULENAME__.Views
{
    public partial class VIPERView : FrmManutencao, IPresenterToViewVIPER
    {
        public IViewToPresenterVIPER presenter;

        private SplashScreen _splash;

        public VIPERView()
        {
            InitializeComponent();
        }

        protected override void IncluirRegistro()
        {
            (principalBindingSource.Current as Entity.VIPER).Id = iKey = 0;
            principalBindingSource.ResetCurrentItem();
        }

        protected override void AlterarRegistro()
        {
            iKey = (principalBindingSource.Current as Entity.VIPER).Id;
        }

        protected override void ObterDadosPrincipal()
        {
            _splash = new SplashScreen("Buscando informações...");
            presenter.ObterDadosPrincipal(sCondicao);
        }

        protected override void GravarRegistro()
        {
            _splash = new SplashScreen("Gravando informação...");
            presenter.Gravar(principalBindingSource.Current as Entity.VIPER);
        }

        protected override void ExcluirRegistro()
        {
            _splash = new SplashScreen("Excluindo informação...");
            presenter.Excluir(principalBindingSource.Current as Entity.VIPER);
        }

        private void gvwAcesso_DoubleClick(object sender, EventArgs e)
        {
            btnEditar_Click(null, null);
        }

        public void ObterDadosPrincipalSucesso(List<Entity.VIPER> dados)
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
            ExecutarAntesGravar();
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
