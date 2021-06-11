using DevExpress.XtraSplashScreen;
using System;

namespace VIPER.WFA
{
    public partial class SplashScreenDownload : SplashScreen
    {
        public SplashScreenDownload()
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
    }
}