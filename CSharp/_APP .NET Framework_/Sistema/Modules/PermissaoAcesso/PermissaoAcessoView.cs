using VIPER.Modules.PermissaoAcesso.Interfaces;
using Chronus.DXperience;

namespace VIPER.Modules.PermissaoAcesso.Views
{
    public partial class PermissaoAcessoView : FrmModelo, IPresenterToViewPermissaoAcesso
    {
        public IViewToPresenterPermissaoAcesso presenter;

        public bool PermiteIncluir
        {
            get { return ckPermiteIncluir.Checked; }
        }

        public bool PermiteAlterar
        {
            get { return ckPermiteAlterar.Checked; }
        }

        public bool PermiteExcluir
        {
            get { return ckPermiteExcluir.Checked; }
        }

        public PermissaoAcessoView(string descricao, bool incluir, bool alterar, bool excluir)
        {
            InitializeComponent();

            lbFuncao.Text = descricao;
            ckPermiteIncluir.Checked = incluir;
            ckPermiteAlterar.Checked = alterar;
            ckPermiteExcluir.Checked = excluir;
        }
    }
}
