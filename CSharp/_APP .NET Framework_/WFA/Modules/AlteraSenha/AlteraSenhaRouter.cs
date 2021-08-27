using VIPER.Modules.AlteraSenha.Interactors;
using VIPER.Modules.AlteraSenha.Interfaces;
using VIPER.Modules.AlteraSenha.Presenters;
using VIPER.Modules.AlteraSenha.Views;
using System.Windows.Forms;

namespace VIPER.Modules.AlteraSenha.Routers
{
    public class AlteraSenhaRouter : IPresenterToRouterAlteraSenha
    {
        public static Form New(string senha)
        {
            return new AlteraSenhaRouter().LoadModule(senha);
        }

        private Form LoadModule(string senha)
        {
            AlteraSenhaPresenter presenter = new AlteraSenhaPresenter();
            AlteraSenhaInteractor interactor = new AlteraSenhaInteractor();
            AlteraSenhaRouter router = new AlteraSenhaRouter();
            AlteraSenhaView form = new AlteraSenhaView(senha);
			
            form.presenter = presenter;

            presenter.interactor = interactor;
            presenter.router = router;
            presenter.view = form;
			
            interactor.presenter = presenter;

            return form;
        }
    }
}
