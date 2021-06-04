using System.Runtime.Serialization;

namespace VIPER.Entity
{
    public class UsuarioFuncao : BaseClass
    {
        public int UsuarioId { get; set; }

        public int FuncaoId { get; set; }

        public bool PermiteIncluir { get; set; }

        public bool PermiteAlterar { get; set; }

        public bool PermiteExcluir { get; set; }

        [IgnoreDataMember]
        public Usuario Usuario { get; set; }

        [IgnoreDataMember]
        public Funcao Funcao { get; set; }
    }
}
