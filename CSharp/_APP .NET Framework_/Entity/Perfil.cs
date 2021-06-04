using System.Collections.Generic;
using System.Runtime.Serialization;

namespace VIPER.Entity
{
    public class Perfil : BaseClass
    {
        public string Descricao { get; set; }

        [IgnoreDataMember]
        public ICollection<PerfilFuncao> PerfilFuncao { get; set; }

        [IgnoreDataMember]
        public ICollection<Usuario> Usuario { get; set; }

        public int QuantidadeFuncoes { get; set; }

        public Perfil()
        {
            PerfilFuncao = new HashSet<PerfilFuncao>();
            Usuario = new HashSet<Usuario>();
        }
    }
}
