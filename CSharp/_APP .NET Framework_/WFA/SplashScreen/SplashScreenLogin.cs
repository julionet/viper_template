using DevExpress.XtraSplashScreen;
using System;
using System.Reflection;

namespace VIPER.WFA
{
    public partial class SplashScreenLogin : SplashScreen
    {
        public SplashScreenLogin()
        {
            InitializeComponent();

            labelControlVersao.Text = string.Format("Versão {0}", Assembly.GetExecutingAssembly().GetName().Version.ToString());
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
