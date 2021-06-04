using VIPER.Entity;

namespace VIPER.DTO
{
    public class PerfilPerfilFuncaoDTO
    {
        public int SistemaId { get; set; }
        public Perfil Perfil { get; set; }
        public PerfilFuncao[] PerfilFuncoes { get; set; }
    }
}
