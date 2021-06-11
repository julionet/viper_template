using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chronus.DXperience
{
    public partial class SplashScreen : XtraForm
    {
        private string _caption, _texto;

        public SplashScreen()
        {
            InitializeComponent();
        }

        public void AtualizaTexto(string texto)
        {

            this._texto = texto;
            if (SplashScreenManager.Default != null) {
                SplashScreenManager.Default.SetWaitFormDescription(_texto);
                SplashScreenManager.Default.SetWaitFormCaption(_caption);
            }            
        }

        public SplashScreen(string texto, string caption = "Por favor, aguarde!")
        {
            InitializeComponent();
            this._caption = caption;
            this._texto = texto;
            this.Show();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            this.Width = SystemInformation.WorkingArea.Width;
            this.Height = SystemInformation.WorkingArea.Height;
            this.Location = new Point(0, 0);
            InicializarSplashScreen();
        }

        private void InicializarSplashScreen()
        {
            SplashScreenManager.ShowForm(this, typeof(FrmWaitForm), false, false, false);
            if (!string.IsNullOrWhiteSpace(_caption) && !string.IsNullOrWhiteSpace(_texto))
            {
                SplashScreenManager.Default.SetWaitFormCaption(_caption);
                SplashScreenManager.Default.SetWaitFormDescription(_texto);
            }
        }

        public void FinalizarSplashScreen() 
        {
            this.Close();
        }

        private void SplashScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            SplashScreenManager.CloseForm(false);
        }
    }
}
