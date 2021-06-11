﻿using System;

namespace VIPER.Entity
{
    public class Atualizacao : BaseClass
    {
        public int Numero { get; set; }

        public DateTime Data { get; set; }

        public string Descricao { get; set; }

        public string Versao { get; set; }

        public string Banco { get; set; }

        public string Sql { get; set; }

        public bool SqlProcedimento { get; set; }

        public string Status { get; set; }

        public string Mensagem { get; set; }

        public bool Obrigatorio { get; set; }
    }
}
