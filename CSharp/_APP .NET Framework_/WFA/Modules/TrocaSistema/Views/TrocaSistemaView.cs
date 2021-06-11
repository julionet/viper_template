using VIPER.Entity;
using VIPER.Modules.TrocaSistema.Interfaces;
using VIPER.Service;
using Chronus.DXperience;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace VIPER.Modules.TrocaSistema.Views
{
    public partial class TrocaSistemaView : FrmModelo, IPresenterToViewTrocaSistema
    {
        public IViewToPresenterTrocaSistema presenter;

        public TrocaSistemaView()
        {
            InitializeComponent();
        }

        public void SelecionarSistemasFalha(string mensagem)
        {
            XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void SelecionarSistemasSucesso(List<Entity.Sistema> sistemas)
        {
            letSistema.Properties.DataSource = Servicos.sistemaService.SelecionarAtivos().OrderBy(p => p.Descricao).ToArray();
            if (Global.Instance.Sistema.Id != 0) letSistema.EditValue = Global.Instance.Sistema.Id;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (letSistema.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Sistema não selecionado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                letSistema.Focus();
                DialogResult = DialogResult.None;
            }
            else
            {
                Global.Instance.Sistema.Id = Convert.ToInt32(letSistema.EditValue);
            }
        }

        private void TrocaSistemaView_Load(object sender, EventArgs e)
        {
            presenter.SelecionarSistemas();
        }
    }
}
