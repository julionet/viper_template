using VIPER.Modules.ControleAcesso.Interactors;
using VIPER.Modules.ControleAcesso.Interfaces;
using VIPER.Modules.ControleAcesso.Presenters;
using VIPER.Modules.ControleAcesso.Views;
using VIPER.Modules.PermissaoAcesso.Views;
using System.Windows.Forms;

namespace VIPER.Modules.ControleAcesso.Routers
{
    public class ControleAcessoRouter : IPresenterToRouterControleAcesso
    {
        public static Form New(int funcao)
        {
            return new ControleAcessoRouter().LoadModule(funcao);
        }

        public void CarregarPermissaoAcesso(string descricao, ref bool incluir, ref bool alterar, ref bool excluir, out bool ok)
        {
            using (var form = PermissaoAcesso.Routers.PermissaoAcessoRouter.New(descricao, incluir, alterar, excluir))
            {
                ok = form.ShowDialog() == DialogResult.OK;
                if (ok)
                {
                    incluir = (form as PermissaoAcessoView).PermiteIncluir;
                    alterar = (form as PermissaoAcessoView).PermiteAlterar;
                    excluir = (form as PermissaoAcessoView).PermiteExcluir;
                }
            }
        }

        private Form LoadModule(int funcao)
        {
            ControleAcessoPresenter presenter = new ControleAcessoPresenter();
            ControleAcessoInteractor interactor = new ControleAcessoInteractor();
            ControleAcessoRouter router = new ControleAcessoRouter();
            ControleAcessoView form = new ControleAcessoView(funcao);
            
            form.presenter = presenter;

            presenter.interactor = interactor;
            presenter.router = router;
            presenter.view = form;
            
            interactor.presenter = presenter;

            return form;
        }
    }
}
