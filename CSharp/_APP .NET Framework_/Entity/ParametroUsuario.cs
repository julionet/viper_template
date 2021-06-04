using System.Runtime.Serialization;

namespace VIPER.Entity
{
    public class ParametroUsuario : BaseClass
    {
        public int ParametroId { get; set; }

        public int UsuarioId { get; set; }

        public string Valor { get; set; }

        [IgnoreDataMember]
        public Parametro Parametro { get; set; }

        [IgnoreDataMember]
        public Usuario Usuario { get; set; }
    }
}
