using VIPER.Modules.ParametroEdicao.Interactors;
using VIPER.Modules.ParametroEdicao.Interfaces;
using VIPER.Modules.ParametroEdicao.Presenters;
using VIPER.Modules.ParametroEdicao.Views;
using System.Windows.Forms;

namespace VIPER.Modules.ParametroEdicao.Routers
{
    public class ParametroEdicaoRouter : IPresenterToRouterParametroEdicao
    {
        public static Form New(string descricao, string tipocomponente, string valorpadrao, string lista, string valorpersonalizado, bool editavel)
        {
            return new ParametroEdicaoRouter().LoadModule(descricao, tipocomponente, valorpadrao, lista, valorpersonalizado, editavel);
        }

        private Form LoadModule(string descricao, string tipocomponente, string valorpadrao, string lista, string valorpersonalizado, bool editavel)
        {
            ParametroEdicaoPresenter presenter = new ParametroEdicaoPresenter();
            ParametroEdicaoInteractor interactor = new ParametroEdicaoInteractor();
            ParametroEdicaoRouter router = new ParametroEdicaoRouter();
            ParametroEdicaoView form = new ParametroEdicaoView(descricao, tipocomponente, valorpadrao, lista, valorpersonalizado, editavel);
			
            form.presenter = presenter;

            presenter.interactor = interactor;
            presenter.router = router;
            presenter.view = form;
			
            interactor.presenter = presenter;

            return form;
        }
    }
}
