using VIPER.Entity;

namespace VIPER.DTO
{
    public class SistemaModuloFuncaoDTO
    {
        public Sistema Sistema { get; set; }
        public Modulo[] Modulos { get; set; }
        public Funcao[] Funcoes { get; set; }
    }
}
