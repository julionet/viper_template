using Chronus.DXperience;
using NAMESPACE.Modules.__MODULENAME__.Interfaces;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NAMESPACE.Modules.__MODULENAME__.Views
{
    public partial class VIPERView : FrmModelo, IPresenterToViewVIPER
    {
        public IViewToPresenterVIPER presenter;

        public VIPERView()
        {
            InitializeComponent();
        }
    }
}
