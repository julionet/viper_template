using VIPER.DTO;
using VIPER.Modules.ParametroUsuario.Interfaces;
using Chronus.DXperience;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VIPER.Modules.ParametroUsuario.Views
{
    public partial class ParametroUsuarioView : FrmManutencao, IPresenterToViewParametroUsuario
    {
        public IViewToPresenterParametroUsuario presenter;

        private SplashScreen _splash;
        private BaseControl _componente;
        private int _parametro = 0;
        private string _lista = "";
        private string _tipocomponente = "";

        public ParametroUsuarioView(int parametro, string tipocomponente, string lista, string descricaoparametro)
        {
            InitializeComponent();

            _parametro = parametro;
            _tipocomponente = tipocomponente;
            _lista = lista;

            PermiteIncluir = true;
            PermiteAlterar = true;
            PermiteExcluir = true;

            lblTitulo.Text = descricaoparametro;

            presenter.SelecionarUsuarios();
        }

        protected override void IncluirRegistro()
        {
            (principalBindingSource.Current as Entity.ParametroUsuario).Id = iKey = 0;
            (principalBindingSource.Current as Entity.ParametroUsuario).ParametroId = _parametro;
            principalBindingSource.ResetCurrentItem();

            lkUsuario.Text = "";
            _componente.Text = "";
        }

        protected override void AlterarRegistro()
        {
            iKey = (principalBindingSource.Current as Entity.ParametroUsuario).Id;

            _componente.Text = (principalBindingSource.Current as Entity.ParametroUsuario).Valor.ToString();
        }

        protected override void ObterDadosPrincipal()
        {
            principalBindingSource.Clear();
            _splash = new SplashScreen("Buscando informações...");
            presenter.ObterDadosPrincipal(_parametro);
        }

        protected override void ExcluirRegistro()
        {
            _splash = new SplashScreen("Excluindo registro...");
            presenter.Excluir(principalBindingSource.Current as Entity.ParametroUsuario);
        }

        protected override void GravarRegistro()
        {
            var valor = _componente.Text;

            ((Entity.ParametroUsuario)principalBindingSource.Current).Valor = valor;
            ((Entity.ParametroUsuario)principalBindingSource.Current).ParametroId = _parametro;
            ((Entity.ParametroUsuario)principalBindingSource.Current).UsuarioId = Convert.ToInt32(lkUsuario.EditValue);

            _splash = new SplashScreen("Gravando registro...");
            presenter.Gravar(principalBindingSource.Current as Entity.ParametroUsuario);
        }

        private void gvwAcesso_DoubleClick(object sender, EventArgs e)
        {
            btnEditar_Click(null, null);
        }

        public void ObterDadosPrincipalSucesso(List<Entity.ParametroUsuario> dados)
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

        public void SelecionarUsuariosSucesso(List<Entity.Usuario> dados)
        {
            lkUsuario.Properties.DataSource = dados;
            repUsuario.DataSource = lkUsuario.Properties.DataSource;
            presenter.ExecutarSQL(_lista);
        }

        public void SelecionarUsuarioFalha()
        {
            presenter.ExecutarSQL(_lista);
        }

        public void ExecutarSQLSucesso(List<LookupDataSourceDTO> dados)
        {
            var componenteparametro = new ComponenteParametro(_tipocomponente);
            componenteparametro.PosicaoX = 84;
            componenteparametro.PosicaoY = 62;
            _componente = componenteparametro.Criar("", _lista, _tipocomponente == "C" || _tipocomponente == "S" ? dados : null);
            xscManutencao.Controls.Add(_componente);

            ObterDadosPrincipal();
        }

        public void ExecutarSQLFalha()
        {
            ObterDadosPrincipal();
        }
    }
}
