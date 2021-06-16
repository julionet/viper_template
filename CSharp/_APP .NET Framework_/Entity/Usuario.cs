using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace VIPER.Entity
{
    public class Usuario : BaseClass
    {
        public string Login { get; set; }

        public string Nome { get; set; }

        public string Senha { get; set; }

        public bool Master { get; set; }

        public bool Bloqueado { get; set; }

        public bool Administrador { get; set; }

        public bool NuncaExpira { get; set; }

        public bool AlterarSenha { get; set; }
        
        public int? DiasExpirar { get; set; }
        
        public DateTime? DataAlteracao { get; set; }

        [IgnoreDataMember]
        public ICollection<UsuarioFuncao> UsuarioFuncao { get; set; }

        [IgnoreDataMember]
        public ICollection<Perfil> Perfil {  get; set; }

        [IgnoreDataMember]
        public ICollection<ParametroUsuario> ParametroUsuario { get; set; }

        public string ListaPerfis { get; set; }

        public Usuario()
        {
            UsuarioFuncao = new HashSet<UsuarioFuncao>();
            Perfil = new HashSet<Perfil>();
            ParametroUsuario = new HashSet<ParametroUsuario>();         
        }
    }
}
