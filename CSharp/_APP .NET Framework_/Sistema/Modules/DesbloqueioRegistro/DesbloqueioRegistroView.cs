using VIPER.Entity;
using VIPER.Modules.DesbloqueioRegistro.Interfaces;
using Chronus.DXperience;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VIPER.Modules.DesbloqueioRegistro.Views
{
    public partial class DesbloqueioRegistroView : FrmModelo, IPresenterToViewDesbloqueioRegistro
    {
        public IViewToPresenterDesbloqueioRegistro presenter;

        private SplashScreen _splash;

        public DesbloqueioRegistroView(int funcao)
        {
            InitializeComponent();
        }

        public void DesbloquearFalha(string mensagem)
        {
            _splash.FinalizarSplashScreen();
            XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void DesbloquearSucesso()
        {
            _splash.FinalizarSplashScreen();
            _splash = new SplashScreen("Buscando bloqueios...");
            presenter.SelecionarTodos();
        }

        public void DesbloquearTodosFalha(string mensagem)
        {
            _splash.FinalizarSplashScreen();
            XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void DesbloquearTodosSucesso()
        {
            _splash.FinalizarSplashScreen();
            _splash = new SplashScreen("Buscando bloqueios...");
            presenter.SelecionarTodos();
        }

        public void SelecionarTodosFalha(string mensagem)
        {
            _splash.FinalizarSplashScreen();
        }

        public void SelecionarTodosSucesso(List<Bloqueio> dados)
        {
            _splash.FinalizarSplashScreen();
            detalheBindingSource.DataSource = dados;
            btnDesbloquearSelecionado.Enabled = dados.Count != 0;
            btnDesbloquearTodos.Enabled = dados.Count != 0;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            _splash = new SplashScreen("Buscando bloqueios...");
            presenter.SelecionarTodos();
        }

        private void btnDesbloquearSelecionado_Click(object sender, EventArgs e)
        {
            _splash = new SplashScreen("Excluindo bloqueio...");
            presenter.Desbloquear(detalheBindingSource.Current as Bloqueio);
        }

        private void btnDesbloquearTodos_Click(object sender, EventArgs e)
        {
            _splash = new SplashScreen("Excluindo bloqueios...");
            presenter.DesbloquearTodos((detalheBindingSource.List as IList<Bloqueio>).ToArray());
        }
    }
}
