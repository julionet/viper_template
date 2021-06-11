using VIPER.Modules.Principal.Interactors;
using VIPER.Modules.Principal.Interfaces;
using VIPER.Modules.Principal.Presenters;
using VIPER.Modules.Principal.Views;
using System.Windows.Forms;

namespace VIPER.Modules.Principal.Routers
{
    public class PrincipalRouter : IPresenterToRouterPrincipal
    {
        public static Form New()
        {
            return new PrincipalRouter().LoadModule();
        }

        public void CarregarAlteraSenha()
        {
            using (var form = AlteraSenha.Routers.AlteraSenhaRouter.New(string.Empty))
            {
                form.ShowDialog();
            }
        }

        public void CarregarLogin(out bool confirmado)
        {
            using (var form = Login.Routers.LoginRouter.New())
            {
                confirmado = form.ShowDialog() == DialogResult.OK;
            }
        }

        public void CarregarTrocaSistema(out bool confirmado)
        {
            using (var form = TrocaSistema.Routers.TrocaSistemaRouter.New())
            {
                confirmado = form.ShowDialog() == DialogResult.OK;
            }
        }

        private Form LoadModule()
        {
            PrincipalPresenter presenter = new PrincipalPresenter();
            PrincipalInteractor interactor = new PrincipalInteractor();
            PrincipalRouter router = new PrincipalRouter();
            PrincipalView form = new PrincipalView();
			
            form.presenter = presenter;

            presenter.interactor = interactor;
            presenter.router = router;
            presenter.view = form;
			
            interactor.presenter = presenter;

            return form;
        }
    }
}
