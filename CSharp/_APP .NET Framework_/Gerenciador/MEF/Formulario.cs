using Chronus.DXperience;
using DevExpress.XtraEditors;
using System.ComponentModel.Composition;

namespace VIPER.Gerenciador.MEF
{
    [Export(typeof(IFormulario))]
    public class Formulario : IFormulario
    {
        private string _nomemodulo = "VIPER.Gerenciador";

        public Formulario()
        {
        }

        public XtraForm Carregar(string formulario, int funcao)
        {
            switch (formulario)
            {
                case "SistemaView": return (XtraForm)Modules.Sistema.Routers.SistemaRouter.New(funcao);
                case "ParametroView": return (XtraForm)Modules.Parametro.Routers.ParametroRouter.New(funcao);
				case "GeradorRelatorioView": return (XtraForm)Modules.GeradorRelatorio.Routers.GeradorRelatorioRouter.New(funcao);
                default:
                    return null;
            }
        }

        public override string ToString()
        {
            return _nomemodulo;
        }
    }
}
