using VIPER.Entity;

namespace VIPER.DTO
{
    public class PerfilFuncaoDTO : PerfilFuncao
    {
        public string FuncaoDescricao { get; set; }
        public bool FuncaoManutencao { get; set; }
        public int ModuloId { get; set; }
        public string ModuloDescricao { get; set; }
        public bool Selecionado { get; set; }
    }
}
