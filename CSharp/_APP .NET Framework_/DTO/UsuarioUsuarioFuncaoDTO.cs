using VIPER.Entity;

namespace VIPER.DTO
{
    public class UsuarioUsuarioFuncaoDTO
    {
        public int SistemaId { get; set; }
        public Usuario Usuario { get; set; }
        public UsuarioFuncao[] UsuarioFuncoes { get; set; }
    }
}
