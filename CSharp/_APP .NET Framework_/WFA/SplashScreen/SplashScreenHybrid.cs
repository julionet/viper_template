using VIPER.Service;
using DevExpress.XtraSplashScreen;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace VIPER.WFA
{
    public partial class SplashScreenHybrid : SplashScreen
    {
        public SplashScreenHybrid()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void SplashScreenHybrid_Load(object sender, EventArgs e)
        {
            Width = SystemInformation.WorkingArea.Width;
            Height = SystemInformation.WorkingArea.Height;
            Location = new Point(0, 0);

            labelControl2.Text = Global.Instance.Sistema.Descricao;

            progressPanel.Left = (Width / 2) - (progressPanel.Width / 2);
            panelControlTopo.Height = (int)(Height * 0.30);
            panelControlBottom.Height = (int)(Height * 0.30);
        }
    }
}