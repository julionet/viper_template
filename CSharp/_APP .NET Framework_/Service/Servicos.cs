using VIPER.Service.Webapi_References;

namespace VIPER.Service
{
    public static class Servicos
    {
		public static AtualizacaoService atualizacaoService = new AtualizacaoService(Global.Instance.ServidorAPI + "atualizacao/");
		public static BloqueioService bloqueioService = new BloqueioService(Global.Instance.ServidorAPI + "bloqueio/");
        public static DashboardService dashboardService = new DashboardService(Global.Instance.ServidorAPI + "dashboard/");
        public static DatabaseService databaseService = new DatabaseService(Global.Instance.ServidorAPI + "database/");
        public static DominioItemService dominioItemService = new DominioItemService(Global.Instance.ServidorAPI + "dominioitem/");
        public static FuncaoService funcaoService = new FuncaoService(Global.Instance.ServidorAPI + "funcao/");
        public static ModuloService moduloService = new ModuloService(Global.Instance.ServidorAPI + "modulo/");
        public static ParametroService parametroService = new ParametroService(Global.Instance.ServidorAPI + "parametro/");
        public static ParametroUsuarioService parametroUsuarioService = new ParametroUsuarioService(Global.Instance.ServidorAPI + "parametrousuario/");
        public static PerfilService perfilService = new PerfilService(Global.Instance.ServidorAPI + "perfil/");
        public static RelatorioService relatorioService = new RelatorioService(Global.Instance.ServidorAPI + "relatorio/");
        public static SequencialService sequencialService = new SequencialService(Global.Instance.ServidorAPI + "sequencial/");
        public static SistemaService sistemaService = new SistemaService(Global.Instance.ServidorAPI + "sistema/");
        public static UsuarioFuncaoService usuarioFuncaoService = new UsuarioFuncaoService(Global.Instance.ServidorAPI + "usuariofuncao/");
        public static UsuarioService usuarioService = new UsuarioService(Global.Instance.ServidorAPI + "usuario/");
    }
}
