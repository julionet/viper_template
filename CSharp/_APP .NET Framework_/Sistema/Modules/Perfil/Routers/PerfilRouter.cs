using VIPER.Modules.Perfil.Interactors;
using VIPER.Modules.Perfil.Interfaces;
using VIPER.Modules.Perfil.Presenters;
using VIPER.Modules.Perfil.Views;
using VIPER.Modules.PermissaoAcesso.Views;
using System.Windows.Forms;

namespace VIPER.Modules.Perfil.Routers
{
    public class PerfilRouter : IPresenterToRouterPerfil
    {
        public static Form New(int funcao)
        {
            return new PerfilRouter().LoadModule(funcao);
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
            PerfilPresenter presenter = new PerfilPresenter();
            PerfilInteractor interactor = new PerfilInteractor();
            PerfilRouter router = new PerfilRouter();
            PerfilView form = new PerfilView(funcao);
			
            form.presenter = presenter;

            presenter.interactor = interactor;
            presenter.router = router;
            presenter.view = form;
			
            interactor.presenter = presenter;

            return form;
        }
    }
}
