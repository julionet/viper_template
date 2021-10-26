using Chronus.DXperience;
using NAMESPACE.Modules.__MODULENAME__.Interfaces;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NAMESPACE.Modules.__MODULENAME__.Views
{
    public partial class VIPERView : FrmManutencao, IPresenterToViewVIPER
    {
        public IViewToPresenterVIPER presenter;

        public VIPERView(int funcao)
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

        protected override void GravarRegistro()
        {			
        }

        protected override void ExcluirRegistro()
        {			
        }

        private void gvwAcesso_DoubleClick(object sender, EventArgs e)
        {
            btnEditar_Click(null, null);
        }
    }
}
