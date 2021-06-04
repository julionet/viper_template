﻿using VIPER.Entity;

namespace VIPER.DTO
{
    public class UsuarioFuncaoDTO : UsuarioFuncao
    {
        public string FuncaoDescricao { get; set; }
        public bool FuncaoManutencao { get; set; }
        public string FuncaoGrupo { get; set; }
        public int ModuloId { get; set; }
        public int ModuloCor { get; set; }
        public string ModuloDescricao { get; set; }
        public int SistemaId { get; set; }
        public bool Selecionado { get; set; }
    }
}
