using System.Collections.Generic;
using System.Runtime.Serialization;

namespace VIPER.Entity
{
    public class Funcao : BaseClass
    {
        public string Descricao { get; set; }

        public string Codigo { get; set; }

        public string Grupo { get; set; }

        public string Tipo { get; set; }

        public string NomeAssembly { get; set; }

        public string NomeFormulario { get; set; }

        public bool Manutencao { get; set; }

        public int? RelatorioId { get; set; }

        public int? DashboardId { get; set; }

        public int ModuloId { get; set; }

        [IgnoreDataMember]
        public Modulo Modulo { get; set; }

        [IgnoreDataMember]
        public Relatorio Relatorio { get; set; }

        [IgnoreDataMember]
        public Dashboard Dashboard { get; set; }

        [IgnoreDataMember]
        public ICollection<UsuarioFuncao> UsuarioFuncao { get; set; }

        [IgnoreDataMember]
        public ICollection<PerfilFuncao> PerfilFuncao { get; set; }

        public string Flag { get; set; }

        public Funcao()
        {
            UsuarioFuncao = new HashSet<UsuarioFuncao>();
            PerfilFuncao = new HashSet<PerfilFuncao>();
        }
    }
}
