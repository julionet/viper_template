using VIPER.Modules.Login.Interactors;
using VIPER.Modules.Login.Interfaces;
using VIPER.Modules.Login.Presenters;
using VIPER.Modules.Login.Views;
using System.Windows.Forms;

namespace VIPER.Modules.Login.Routers
{
    public class LoginRouter : IPresenterToRouterLogin
    {
        public static Form New()
        {
            return new LoginRouter().LoadModule();
        }

        public void CarregarAlteraSenha(string senha, out bool confirmado)
        {
            using (var form = AlteraSenha.Routers.AlteraSenhaRouter.New(senha))
            {
                confirmado = form.ShowDialog() == DialogResult.OK;
            }
        }

        public void CarregarConfigBanco(out bool confirmado)
        {
            using (var form = ConfigBanco.Routers.ConfigBancoRouter.New())
            {
                confirmado = form.ShowDialog() == DialogResult.OK;
            }
        }

        private Form LoadModule()
        {
            LoginPresenter presenter = new LoginPresenter();
            LoginInteractor interactor = new LoginInteractor();
            LoginRouter router = new LoginRouter();
            LoginView form = new LoginView();
            
            form.presenter = presenter;

            presenter.interactor = interactor;
            presenter.router = router;
            presenter.view = form;
            
            interactor.presenter = presenter;

            return form;
        }
    }
}
