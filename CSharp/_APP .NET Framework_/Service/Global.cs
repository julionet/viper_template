using VIPER.Entity;

namespace VIPER.Service
{
    public sealed class Global
    {
        private static readonly Global _instance = new Global();

        private Global() { }

        public static Global Instance
        {
            get
            {
                return _instance;
            }
        }

        public string ServidorAPI
        {
            get { return Properties.Settings.Default.ServidorAPI; }
        }

        public string UsuarioAPI
        {
            get { return Properties.Settings.Default.UsuarioAPI; }
        }

        public string SenhaAPI
        {
            get { return Properties.Settings.Default.SenhaAPI; }
        }

        private int _versaoatualbancodados = 1;

        public bool PrecisaAtualizarBanco
        {
            get { return Parametros.Instance.VersaoBanco < _versaoatualbancodados; }
        }

        private Usuario _usuariologado = null;
        public Usuario UsuarioLogado
        {
            get { return _usuariologado; }
            set { _usuariologado = value; }
        }

        private bool _gerenciadorsistema = true;
        public bool GerenciadorSistema
        {
            get { return _gerenciadorsistema; }
            set { _gerenciadorsistema = value; }
        }

        private bool _temvariossistema = true;
        public bool TemVariosSistema
        {
            get { return _temvariossistema; }
            set { _temvariossistema = value; }
        }

        private Sistema _sistema = null;
        public Sistema Sistema
        {
            get { return _sistema; }
            set { _sistema = value; }
        }

        private DominioItem[] _dominioitem = null;
        public DominioItem[] DominioItens
        {
            get
            {
                if (_dominioitem == null)
                    _dominioitem = Servicos.dominioItemService.SelecionarTodos().ToArray();
                return _dominioitem;
            }
            set
            {
                _dominioitem = value;
            }
        }

        private Funcao[] _funcaos = null;
        public Funcao[] Funcaos
        {
            get
            {
                if (_funcaos == null)
                    _funcaos = Servicos.funcaoService.SelecionarTodos().ToArray();
                return _funcaos;
            }
        }

        private Sistema[] _sistemas = null;
        public Sistema[] Sistemas
        {
            get
            {
                if (_sistemas == null)
                    _sistemas = Servicos.sistemaService.SelecionarTodos().ToArray();
                return _sistemas;
            }
        }
    }
}
