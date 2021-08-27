namespace VIPER.Service
{
    public sealed class Parametros
    {
        private static readonly int _versaoatualbancodados = 1;
        
        private static readonly Parametros _instance = new Parametros();

        private Parametros() { }

        public static Parametros Instance
        {
            get
            {
                return _instance;
            }
        }

        private string _versaosistema = null;
        public string VersaoSistema
        {
            get
            {
                if (_versaosistema == null)
                    _versaosistema = Servicos.parametroService.SelecionarValorParametro("999", 0);
                return _versaosistema;
            }
        }

        private int? _versaobanco = null;
        public int VersaoBanco
        {
            get
            {
                if (_versaobanco == null)
                {
                    if (int.TryParse(Servicos.parametroService.SelecionarValorParametro("998", 0), out int versao))
                        _versaobanco = versao;
                }
                return _versaobanco.Value;
            }
        }
        
        public bool PrecisaAtualizarBanco
        {
            get { return VersaoBanco < _versaoatualbancodados; }
        }

        public void Reload()
        {
            _versaosistema = null;
            _versaobanco = null;
        }
    }
}
