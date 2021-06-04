using System;

namespace VIPER.Entity
{
    public class Bloqueio : BaseClass
    {
        public string Classe { get; set; }

        public string Usuario { get; set; }

        public string Computador { get; set; }

        public DateTime DataHora { get; set; }

        public int Referencia { get; set; }
    }
}
