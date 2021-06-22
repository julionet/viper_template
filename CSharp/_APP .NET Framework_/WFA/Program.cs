using VIPER.Service;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace VIPER.WFA
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            WindowsFormsSettings.SetDPIAware();
            WindowsFormsSettings.AllowPixelScrolling = DefaultBoolean.True;
            WindowsFormsSettings.ScrollUIMode = ScrollUIMode.Touch;

            SkinManager.EnableFormSkins();
            BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle(new Gerenciador.SettingsDefault().SkinName);
            AppearanceObject.DefaultFont = new Font("Tahoma", (float)new Gerenciador.SettingsDefault().FontSize);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var culture = new CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            FastReport.Utils.Res.LoadLocale("Portuguese (Brazil).frl");

            string versaoSistema = null;
            try
            {
                SplashScreenManager.ShowForm(typeof(global::VIPER.WFA.SplashScreenLogin));
                versaoSistema = Parametros.Instance.VersaoSistema;
                SplashScreenManager.CloseDefaultSplashScreen();
            }
            catch (Exception erro)
            {
                XtraMessageBox.Show("Falha ao tentar conectar no banco de dados!\r\nVerique as configurações do banco de dados e tente novamente.\r\n" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                using (var form = Modules.ConfigBanco.Routers.ConfigBancoRouter.New())
                {
                    form.ShowDialog();
                }
                Application.Exit();
                return;
            }

            if (string.IsNullOrWhiteSpace(versaoSistema))
            {
                XtraMessageBox.Show($"Falha ao tentar comunicar com serviço {Global.Instance.ServidorAPI}!\r\nVerique as configurações do serviço e tente novamente.", 
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                using (var form = Modules.ConfigBanco.Routers.ConfigBancoRouter.New())
                {
                    form.ShowDialog();
                }
                Application.Exit();
                return;
            }

            if (Application.ProductVersion != versaoSistema)
            {
                if (XtraMessageBox.Show($"O aplicativo não poderá ser executado pois encontra-se disponível uma nova versão.\r\nVersão disponível para download {versaoSistema}.\r\nDeseja baixar a nova versão do aplicativo agora?\r\nCaso não seja baixado o aplicativo será finalizado.",
                        "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Title = "Salvar Donwload";
                    dialog.FileName = "setup_workflow.exe";
                    dialog.Filter = "Arquivo Executável|*.exe";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        SplashScreenManager.ShowForm(typeof(global::VIPER.WFA.SplashScreenDownload));
                        string arquivo = Global.Instance.ServidorAPI.Replace("api/", "setup/setup.exe");
                        using (var client = new WebClient())
                        {
                            client.DownloadFile(arquivo, dialog.FileName);
                        }
                        SplashScreenManager.CloseDefaultSplashScreen();

                        Application.Exit();
                        System.Diagnostics.Process.Start(dialog.FileName);
                        return;
                    }
                    else
                    {
                        Application.Exit();
                        return;
                    }
                }
                else
                {
                    Application.Exit();
                    return;
                }
            }

            string _mensagem = new AtualizacaoVersao().Atualizar();
            if (_mensagem == "")
            {
                using (var form = Modules.Login.Routers.LoginRouter.New())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        using (var formprincipal = Modules.Principal.Routers.PrincipalRouter.New())
                        {
                            Application.Run(formprincipal);
                        }
                    }
                    else
                        Application.Exit();
                }
            }
            else
            {
                XtraMessageBox.Show(_mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
        }
    }
}
