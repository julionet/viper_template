using VIPER.DTO;
using VIPER.Entity;
using VIPER.Modules.Funcao.Interfaces;
using Chronus.DXperience;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VIPER.Modules.Funcao.Views
{
    public partial class FuncaoView : FrmModelo, IPresenterToViewFuncao
    {
        public IViewToPresenterFuncao presenter;

        public FuncaoView(BindingSource source, int id, string descricao)
            : base(source)
        {
            InitializeComponent();

            iKey = id;

            lblModulo.Text = descricao;
        }

        private void UpdateLookup_Relatorios()
        {
            presenter.SelecionarRelatorios();
        }

        private void UpdateLookup_Dashboards()
        {
            presenter.SelecionarDashboardas();            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            presenter.Validar(detalheBindingSource.Current as Entity.Funcao);
        }

        private void icbTipo_EditValueChanged(object sender, EventArgs e)
        {
            var registro = detalheBindingSource.Current as Entity.Funcao;
            if (bInsertOrEdit && registro != null)
            {
                registro.Tipo = !icbTipo.IsNullOrDbnull() ? icbTipo.EditValue.ToString() : registro.Tipo;

                tetNomeAssembly.Enabled = !icbTipo.IsNullOrDbnull() && icbTipo.EditValue.ToString() == "F";
                tetNomeFormulario.Enabled = !icbTipo.IsNullOrDbnull() && icbTipo.EditValue.ToString() == "F";
                letRelatorio.Enabled = !icbTipo.IsNullOrDbnull() && icbTipo.EditValue.ToString() == "R";
                letDashboard.Enabled = !icbTipo.IsNullOrDbnull() && icbTipo.EditValue.ToString() == "D";

                if (registro.Tipo == "R")
                {
                    registro.NomeAssembly = null;
                    registro.NomeFormulario = null;
                    tetNomeAssembly.EditValue = null;
                    tetNomeFormulario.EditValue = null;
                }
                else if (registro.Tipo == "F")
                {
                    registro.RelatorioId = null;
                    letRelatorio.EditValue = null;
                }
                else if (registro.Tipo == "D")
                {
                    registro.DashboardId = null;
                    letDashboard.EditValue = null;
                }
            }
        }

        public void SelecionarDashboardasSucesso(List<Dashboard> dados)
        {
            letDashboard.Properties.DataSource = dados;
            UpdateLookup_Relatorios();
        }

        public void SelecionarDashboardasFalha()
        {
            UpdateLookup_Relatorios();
        }

        public void SelecionarRelatoriosSucesso(List<RelatorioRetornoDTO> dados)
        {
            letRelatorio.Properties.DataSource = dados;
        }

        public void SelecionarRelatoriosFalha()
        {
            
        }

        public void ValidarSucesso()
        {
            DialogResult = DialogResult.OK;
        }

        public void ValidarFalha(string mensagem)
        {
            XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DialogResult = DialogResult.None;
        }

        private void FuncaoView_Load(object sender, EventArgs e)
        {
            UpdateLookup_Dashboards();
        }
    }
}
