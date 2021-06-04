using System.Collections.Generic;
using System.Runtime.Serialization;

namespace VIPER.Entity
{
    public class Parametro : BaseClass
    {
        public string Codigo { get; set; }

        public string Descricao { get; set; }

        public string Observacao { get; set; }

        public string Tipo { get; set; }

        public string ValorPadrao { get; set; }

        public string ValorPersonalizado { get; set; }

        public string Lista { get; set; }

        public bool PermiteUsuario { get; set; }

        public string Categoria { get; set; }

        [IgnoreDataMember]
        public ICollection<ParametroUsuario> ParametroUsuario { get; set; }

        public Parametro()
        {
            ParametroUsuario = new HashSet<ParametroUsuario>();
        }
    }
}
