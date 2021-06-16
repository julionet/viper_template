using Chronus.App.Modules.Perfil.Interfaces;
using Chronus.DXperience;
using System;

namespace Chronus.App.Modules.Perfil.Views
{
    public partial class PerfilView : FrmManutencao, IPresenterToViewPerfil
    {
        public IViewToPresenterPerfil presenter;

        private bool _cancelou = false;

        public PerfilView(int funcao)
        {
            InitializeComponent();

            FuncaoId = funcao;

            PermiteIncluir = true;
            PermiteAlterar = true;
            PermiteExcluir = true;
        }

        protected override void IncluirRegistro()
        {
            //_perfilinterface.IncluirRegistro(ref iKey);
        }

        protected override void AlterarRegistro()
        {
            //_perfilinterface.AlterarRegistro(ref iKey);
        }

        protected override void ObterDadosPrincipal()
        {
            //_perfilinterface.ObterDadosPrincipal(sCondicao);
        }
        protected override void GravarRegistro()
        {
            //return _perfilinterface.GravarRegistro();
        }

        protected override void ExcluirRegistro()
        {
            //return _perfilinterface.ExcluirRegistro();
        }

        private void gvwAcesso_DoubleClick(object sender, EventArgs e)
        {
            btnEditar_Click(null, null);
        }

        private void gvwFuncoes_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //_perfilinterface.ControleAcessoGradeMudado(ref _cancelou);
        }

        private void gvwFuncoes_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //_perfilinterface.MudandoControleAcessoGrade(e, ref _cancelou);
        }

        private void gvwFuncoes_DoubleClick(object sender, EventArgs e)
        {
            //_perfilinterface.EditarControleAcesso();
        }
    }
}
