using System.Runtime.Serialization;

namespace VIPER.Entity
{
    public class DominioItem : BaseClass
    {
        public string Descricao { get; set; }

        public string Valor { get; set; }

        public int DominioId { get; set; }

        [IgnoreDataMember]
        public Dominio Dominio { get; set; }
    }
}
