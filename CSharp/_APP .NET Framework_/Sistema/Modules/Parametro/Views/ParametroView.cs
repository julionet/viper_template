using VIPER.Entity;
using VIPER.Modules.Parametro.Interfaces;
using Chronus.DXperience;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VIPER.Modules.Parametro.Views
{
    public partial class ParametroView : FrmModelo, IPresenterToViewParametro
    {
        public IViewToPresenterParametro presenter;

        private SplashScreen _splash;

        public ParametroView(int funcao)
        {
            InitializeComponent();
        }

        private void FrmDiretivas_Load(object sender, EventArgs e)
        {
            presenter.SelecionarCategorias();
        }

        private void gvwDiretivas_DoubleClick(object sender, EventArgs e)
        {
            if (gridViewParametros.DataRowCount != 0)
            {
                var parametro = (detalheBindingSource.Current as Entity.Parametro);
                if (parametro.Codigo != "999" && parametro.Codigo != "998")
                {
                    var valorpersonalizado = parametro.ValorPersonalizado;
                    presenter.CarregarParametroEdicao(parametro.Descricao, parametro.Tipo, 
                        parametro.ValorPadrao, parametro.Lista, parametro.Codigo != "313", ref valorpersonalizado, 
                        out bool ok);
                    if (ok)
                    {
                        parametro.ValorPersonalizado = valorpersonalizado;
                        _splash = new SplashScreen("Gravando informações...");
                        presenter.Salvar(parametro);
                    }
                }
                else
                    XtraMessageBox.Show("Parâmetro não pode ser modificado pelo usuário!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bbiParametroUsuario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var parametro = (detalheBindingSource.Current as Entity.Parametro);
            if (parametro.PermiteUsuario)
                presenter.CarregarParametroUsuario(parametro.Id, parametro.Tipo, parametro.Lista, parametro.Descricao);
            else
                XtraMessageBox.Show("Parâmetro não permite configuração por usuário!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gvwDiretivas_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = sender as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRowCell) popupMenu.ShowPopup(barManager, view.GridControl.PointToScreen(e.Point));
        }

        private void toolTipController_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            if (e.SelectedControl != gridControlParametros)
                return;

            GridHitInfo hitInfo = gridViewParametros.CalcHitInfo(e.ControlMousePosition);

            if (!hitInfo.InRow)
                return;

            string BodyText = "";
            string TitleText = "";

            var drCurrentRow = (gridViewParametros.GetRow(hitInfo.RowHandle) as Entity.Parametro);
            if (drCurrentRow != null)
            {
                BodyText = drCurrentRow.Observacao ?? "";
                TitleText = drCurrentRow.Codigo + " - " + drCurrentRow.Descricao;
            }

            if (BodyText.Equals(""))
                return;

            SuperToolTipSetupArgs toolTipArgs = new SuperToolTipSetupArgs();
            toolTipArgs.Title.Text = TitleText;
            toolTipArgs.Contents.Text = BodyText;

            e.Info = new ToolTipControlInfo();
            e.Info.Object = hitInfo.HitTest.ToString() + hitInfo.RowHandle.ToString(); 
            e.Info.ToolTipType = ToolTipType.SuperTip;
            e.Info.SuperTip = new SuperToolTip();
            e.Info.SuperTip.Setup(toolTipArgs);
        }

        private void bindingSourceCategoria_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSourceCategoria.Current != null)
                presenter.SelecionarParametrosPorCategoria((bindingSourceCategoria.Current as DominioItem).Valor);
            else
                detalheBindingSource.Clear();
        }

        private void gridControlParametros_Click(object sender, EventArgs e)
        {

        }

        public void SalvarSucesso()
        {
            _splash.FinalizarSplashScreen();            
        }

        public void SalvarFalha(string mensagem)
        {
            _splash.FinalizarSplashScreen();
            XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void SelecionarCategoriasSucesso(List<DominioItem> dados)
        {
            bindingSourceCategoria.DataSource = dados;
            gridControlCategoria.Focus();

        }

        public void SelecionarCategoriasFalha()
        {
            gridControlCategoria.Focus();
        }

        public void SelecionarParametrosPorCategoriaSucesso(List<Entity.Parametro> parametros)
        {
            detalheBindingSource.DataSource = parametros;
            gridViewParametros.RefreshData();
        }

        public void SelecionarParametrosPorCategoriaFalha()
        {
            gridViewParametros.RefreshData();
        }
    }
}
