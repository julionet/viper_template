using Chronus.DX;
using NAMESPACE.Interfaces;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NAMESPACE.Views
{
    public partial class VIPERView : FrmManutencao, IPresenterToViewVIPER
    {
        public IViewToPresenterVIPER presenter;

        public VIPERView()
        {
            InitializeComponent();
        }

        protected override void IncluirRegistro()
        {
        }

        protected override void AlterarRegistro()
        {
        }

        protected override void ObterDadosPrincipal()
        {
        }

        protected override bool GravarRegistro()
        {
			return true;
        }

        protected override bool ExcluirRegistro()
        {
			return true;
        }

        private void gvwAcesso_DoubleClick(object sender, EventArgs e)
        {
            btnEditar_Click(null, null);
        }
    }
}
