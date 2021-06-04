using System.Runtime.Serialization;

namespace VIPER.Entity
{
    public class PerfilFuncao : BaseClass
    {
        public int PerfilId { get; set; }

        public int FuncaoId { get; set; }

        public bool PermiteIncluir { get; set; }

        public bool PermiteAlterar { get; set; }

        public bool PermiteExcluir { get; set; }

        [IgnoreDataMember]
        public Perfil Perfil { get; set; }

        [IgnoreDataMember]
        public Funcao Funcao { get; set; }
    }
}
