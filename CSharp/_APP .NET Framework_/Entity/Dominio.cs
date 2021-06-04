using System.Collections.Generic;
using System.Runtime.Serialization;

namespace VIPER.Entity
{
    public class Dominio : BaseClass
    {
        public string Descricao { get; set; }

        [IgnoreDataMember]
        public ICollection<DominioItem> DominioItem { get; set; }

        public Dominio()
        {
            DominioItem = new HashSet<DominioItem>();
        }
    }
}
