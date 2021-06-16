using Chronus.DXperience;
using DevExpress.XtraEditors;
using System.ComponentModel.Composition;

namespace VIPER.Sistema.MEF
{
    [Export(typeof(IFormulario))]
    public class Formulario : IFormulario
    {
        private string _nomemodulo = "VIPER.Sistema";

        public Formulario()
        {
        }

        public XtraForm Carregar(string formulario, int funcao)
        {
            switch (formulario)
            {
				case "DesbloqueioRegistroView": return (XtraForm)Modules.DesbloqueioRegistro.Routers.DesbloqueioRegistroRouter.New(funcao);
				case "UsuarioView": return (XtraForm)Modules.Usuario.Routers.UsuarioRouter.New(funcao);
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
