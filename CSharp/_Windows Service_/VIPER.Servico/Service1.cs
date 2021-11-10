using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Timers;

namespace VIPER.Servico
{
    public partial class Service1 : ServiceBase
    {
        private readonly string _filenamelog = "VIPER.Servico.log";
        private Timer _timer;

        public Service1()
        {
            InitializeComponent();

            int.TryParse(ConfigurationManager.AppSettings["time"], out int tempo);

            _timer = new Timer(tempo);
            _timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);

            SaveLog("Service1", "Serviço criado com sucesso!");
        }

        protected override void OnStart(string[] args)
        {
            _timer.Enabled = true;
            SaveLog("OnStart", "Serviço iniciado com sucesso!");
        }

        protected override void OnStop()
        {
            _timer.Enabled = false;
            SaveLog("OnStop", "Serviço parado com sucesso!");
        }

        protected override void OnPause()
        {
            _timer.Enabled = false;
            SaveLog("OnPause", "Serviço pausado com sucesso!");
        }

        protected override void OnContinue()
        {
            _timer.Enabled = true;
            SaveLog("OnContinue", "Serviço continuado com sucesso!");
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                _timer.Enabled = false;
                
                try
                {
                    var timeSpan = DateTime.Now.TimeOfDay;
                    var inicioTimeSpan = TimeSpan.Parse("08:00:00");
                    var terminoTimeSpan = TimeSpan.Parse("21:00:00");

                    if (timeSpan >= inicioTimeSpan && timeSpan < terminoTimeSpan)
                    {
                        
                    }
                }
                catch (Exception erro)
                {
                    SaveLog("timer_Elapsed", erro.InnerException != null ? erro.InnerException.Message : erro.Message);
                }
            }
            finally
            {
                _timer.Enabled = true;
            }
        }

        private void SaveLog(string metodo, string texto)
        {
            string arquivolog = Path.Combine(Path.GetTempPath(), _filenamelog);
            List<string> log;

            if (File.Exists(arquivolog))
                log = File.ReadAllLines(arquivolog).ToList();
            else
                log = new List<string>();

            if (!texto.Equals("\r\n"))
                log.Add($"[{DateTime.Now:dd/MM/yyyy hh:mm:ss}] - [{metodo}] - {texto}");

            File.WriteAllLines(arquivolog, log.ToArray());
        }
    }
}
