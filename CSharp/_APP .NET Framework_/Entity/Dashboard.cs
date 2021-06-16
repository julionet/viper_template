using System.Collections.Generic;
using System.Runtime.Serialization;

namespace VIPER.Entity
{
    public class Dashboard : BaseClass
    {
        public string Nome { get; set; }

        public string Xml { get; set; }

        [IgnoreDataMember]
        public virtual ICollection<Funcao> Funcao { get; set; }

        public Dashboard()
        {
            Funcao = new HashSet<Funcao>();
        }
    }
}
