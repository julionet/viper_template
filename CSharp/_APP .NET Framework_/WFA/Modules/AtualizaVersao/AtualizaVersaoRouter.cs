using VIPER.Modules.AtualizaVersao.Interactors;
using VIPER.Modules.AtualizaVersao.Interfaces;
using VIPER.Modules.AtualizaVersao.Presenters;
using VIPER.Modules.AtualizaVersao.Views;
using System.Windows.Forms;

namespace VIPER.Modules.AtualizaVersao.Routers
{
    public class AtualizaVersaoRouter : IPresenterToRouterAtualizaVersao
    {
        public static Form New()
        {
            return new AtualizaVersaoRouter().LoadModule();
        }

        private Form LoadModule()
        {
            AtualizaVersaoPresenter presenter = new AtualizaVersaoPresenter();
            AtualizaVersaoInteractor interactor = new AtualizaVersaoInteractor();
            AtualizaVersaoRouter router = new AtualizaVersaoRouter();
            AtualizaVersaoView form = new AtualizaVersaoView();
            
            form.presenter = presenter;

            presenter.interactor = interactor;
            presenter.router = router;
            presenter.view = form;
            
            interactor.presenter = presenter;

            return form;
        }
    }
}
