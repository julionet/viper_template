using Chronus.DXperience;
using VIPER.Modules.GeradorRelatorio.Interfaces;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VIPER.Modules.GeradorRelatorio.Views
{
    public partial class GeradorRelatorioView : FrmModelo, IPresenterToViewGeradorRelatorio
    {
        public IViewToPresenterGeradorRelatorio presenter;

        public GeradorRelatorioView()
        {
            InitializeComponent();
        }
    }
}
