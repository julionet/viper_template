using Chronus.App.Modules.ParametroUsuario.Interfaces;
using Chronus.DXperience;
using DevExpress.XtraEditors;
using System;

namespace Chronus.App.Modules.ParametroUsuario.Views
{
    public partial class ParametroUsuarioView : FrmManutencao, IPresenterToViewParametroUsuario
    {
        public IViewToPresenterParametroUsuario presenter;

        private BaseControl componente;

        public ParametroUsuarioView(int parametro, string tipocomponente, string lista, string descricaoparametro)
        {
            InitializeComponent();

            //_parametrousuariointerface = new ParametroUsuarioInterface(this, principalBindingSource, parametro, ref componente);
            //_parametrousuariointerface.InicializarFormulario(ref PermiteIncluir, ref PermiteAlterar, ref PermiteExcluir, tipocomponente, lista, descricaoparametro);
        }

        protected override void IncluirRegistro()
        {
            //_parametrousuariointerface.IncluirRegistro(ref iKey);
        }

        protected override void AlterarRegistro()
        {
            //_parametrousuariointerface.AlterarRegistro(ref iKey);
        }

        protected override void ObterDadosPrincipal()
        {
            //_parametrousuariointerface.ObterDadosPrincipal();
        }

        protected override void ExcluirRegistro()
        {
            //return _parametrousuariointerface.ExcluirRegistro();
        }

        protected override void GravarRegistro()
        {
            //return _parametrousuariointerface.GravarRegistro();
        }

        private void gvwAcesso_DoubleClick(object sender, EventArgs e)
        {
            btnEditar_Click(null, null);
        }
    }
}
