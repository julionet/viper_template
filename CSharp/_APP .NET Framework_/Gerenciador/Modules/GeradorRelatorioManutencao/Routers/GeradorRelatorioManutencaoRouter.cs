using VIPER.Modules.GeradorRelatorioManutencao.Interactors;
using VIPER.Modules.GeradorRelatorioManutencao.Interfaces;
using VIPER.Modules.GeradorRelatorioManutencao.Presenters;
using VIPER.Modules.GeradorRelatorioManutencao.Views;
using System.Windows.Forms;

namespace VIPER.Modules.GeradorRelatorioManutencao.Routers
{
    public class GeradorRelatorioManutencaoRouter : IPresenterToRouterGeradorRelatorioManutencao
    {
        public static Form New(BindingSource source)
        {
            return new GeradorRelatorioManutencaoRouter().LoadModule(source);
        }

        private Form LoadModule(BindingSource source)
        {
            GeradorRelatorioManutencaoPresenter presenter = new GeradorRelatorioManutencaoPresenter();
            GeradorRelatorioManutencaoInteractor interactor = new GeradorRelatorioManutencaoInteractor();
            GeradorRelatorioManutencaoRouter router = new GeradorRelatorioManutencaoRouter();
            GeradorRelatorioManutencaoView form = new GeradorRelatorioManutencaoView(source);
			
            form.presenter = presenter;

            presenter.interactor = interactor;
            presenter.router = router;
            presenter.view = form;
			
            interactor.presenter = presenter;

            return form;
        }
    }
}
