using Chronus.App.Modules.ControleAcesso.Interfaces;
using Chronus.DXperience;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Chronus.App.Modules.ControleAcesso.Views
{
    public partial class ControleAcessoView : FrmModelo, IPresenterToViewControleAcesso
    {
        public IViewToPresenterControleAcesso presenter;

        private bool _ehcomum = false;
        private bool _cancelou = false;
        private ucPesquisa ucUsuario;

        public ControleAcessoView(int funcao)
        {
            InitializeComponent();

            //_usuariofuncaointerface = new UsuarioFuncaoInterface(this, detalheBindingSource);
        }

        private void FrmUsuarioFuncao_Load(object sender, EventArgs e)
        {
            //_usuariofuncaointerface.InicializarControleAcesso();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            //_usuariofuncaointerface.SelecionarFuncoesUsuario(ref _ehcomum);
        }

        private new void btnCancelar_Click(object sender, EventArgs e)
        {
            //_usuariofuncaointerface.CancelarControleAcesso();
        }

        private void gvwFuncoes_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //_usuariofuncaointerface.ControleAcessoGradeMudado(ref _cancelou);
        }

        private void gvwFuncoes_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //_usuariofuncaointerface.MudandoControleAcessoGrade(_ehcomum, e, ref _cancelou);
        }

        private void gvwFuncoes_DoubleClick(object sender, EventArgs e)
        {
            //_usuariofuncaointerface.EditarControleAcesso();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            /*if (!pceUsuario.Enabled)
            {
                _usuariofuncaointerface.GravarAcessoUsuario();
            }
            else
            {
                if (this.ParentControl != null)
                    ParentControl.TabPages.Remove(ParentPage);
            }*/
        }

        private void pceUsuario_QueryPopUp(object sender, CancelEventArgs e)
        {
            //_usuariofuncaointerface.Usuario_QueryPopup(ref ucUsuario);
        }

        private void pceUsuario_QueryResultValue(object sender, DevExpress.XtraEditors.Controls.QueryResultValueEventArgs e)
        {
            //_usuariofuncaointerface.Usuario_QueryResult(ref ucUsuario, e);
        }

        private void pceUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            //_usuariofuncaointerface.Usuario_KeyDown(sender, e);
        }
    }
}
