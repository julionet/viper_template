using System.Collections.Generic;
using System.Runtime.Serialization;

namespace VIPER.Entity
{
    public class Modulo : BaseClass
    {
        public string Descricao { get; set; }

        public string Codigo { get; set; }

        public string Grupo { get; set; }

        public byte[] Imagem { get; set; }

        public int Cor { get; set; }

        public bool Administracao { get; set; }

        public bool Navegacao { get; set; }

        public int SistemaId { get; set; }

        [IgnoreDataMember]
        public Sistema Sistema { get; set; }

        [IgnoreDataMember]
        public ICollection<Funcao> Funcao { get; set; }

        public string Flag { get; set; }

        public int QuantidadeFuncao { get; set; }

        public Modulo()
        {
            Funcao = new HashSet<Funcao>();
        }
    }
}
