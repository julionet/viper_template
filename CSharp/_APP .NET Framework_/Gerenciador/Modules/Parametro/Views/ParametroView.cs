using VIPER.Modules.Parametro.Interfaces;
using VIPER.Service;
using Chronus.DXperience;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VIPER.Modules.Parametro.Views
{
    public partial class ParametroView : FrmManutencao, IPresenterToViewParametro
    {
        public IViewToPresenterParametro presenter;

        private SplashScreen _splash;

        public ParametroView(int funcao)
        {
            InitializeComponent();
            FuncaoId = funcao;

            PermiteIncluir = true;
            PermiteAlterar = true;
            PermiteExcluir = true;

            UpdateLookup_Dominio();
        }

        private void UpdateLookup_Dominio()
        {
            letCategoria.Properties.DataSource = Global.Instance.DominioItens.Where(p => p.DominioId == 1).OrderBy(p => p.Descricao).ToArray();
        }

        protected override void IncluirRegistro()
        {
            (principalBindingSource.Current as Entity.Parametro).Id = iKey = 0;
            (principalBindingSource.Current as Entity.Parametro).PermiteUsuario = false;
            principalBindingSource.ResetCurrentItem();

            icbTipo_EditValueChanged(icbTipo, null);
        }

        protected override void AlterarRegistro()
        {
            iKey = (principalBindingSource.Current as Entity.Parametro).Id;
            icbTipo_EditValueChanged(icbTipo, null);
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

        protected override void ExcluirRegistro()
        {
            _splash = new SplashScreen("Excluindo registro...");
            presenter.Excluir(principalBindingSource.Current as Entity.Parametro);
        }

        protected override void GravarRegistro()
        {
            _splash = new SplashScreen("Gravando registro...");
            presenter.Gravar(principalBindingSource.Current as Entity.Parametro);
        }

        private void gvwAcesso_DoubleClick(object sender, EventArgs e)
        {
            btnEditar_Click(null, null);
        }

        private void icbTipo_EditValueChanged(object sender, EventArgs e)
        {
            if (bInsertOrEdit)
            {
                metLista.Enabled = icbTipo.EditValue != null && (icbTipo.EditValue.ToString() == "S" || icbTipo.EditValue.ToString() == "L" || icbTipo.EditValue.ToString() == "C");
            }
        }

        public void ObterDadosPrincipalSucesso(List<Entity.Parametro> dados)
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
