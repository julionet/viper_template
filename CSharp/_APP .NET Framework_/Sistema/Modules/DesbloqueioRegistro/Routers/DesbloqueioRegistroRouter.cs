using VIPER.Modules.DesbloqueioRegistro.Interactors;
using VIPER.Modules.DesbloqueioRegistro.Interfaces;
using VIPER.Modules.DesbloqueioRegistro.Presenters;
using VIPER.Modules.DesbloqueioRegistro.Views;
using System.Windows.Forms;

namespace VIPER.Modules.DesbloqueioRegistro.Routers
{
    public class DesbloqueioRegistroRouter : IPresenterToRouterDesbloqueioRegistro
    {
        public static Form New(int funcao)
        {
            return new DesbloqueioRegistroRouter().LoadModule(funcao);
        }

        private Form LoadModule(int funcao)
        {
            DesbloqueioRegistroPresenter presenter = new DesbloqueioRegistroPresenter();
            DesbloqueioRegistroInteractor interactor = new DesbloqueioRegistroInteractor();
            DesbloqueioRegistroRouter router = new DesbloqueioRegistroRouter();
            DesbloqueioRegistroView form = new DesbloqueioRegistroView(funcao);
			
            form.presenter = presenter;

            presenter.interactor = interactor;
            presenter.router = router;
            presenter.view = form;
			
            interactor.presenter = presenter;

            return form;
        }
    }
}
