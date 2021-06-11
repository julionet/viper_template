using VIPER.Modules.GeradorRelatorio.Interfaces;

namespace VIPER.Modules.GeradorRelatorio.Presenters
{
    public class GeradorRelatorioPresenter : IViewToPresenterGeradorRelatorio, IInteractorToPresenterGeradorRelatorio
    {
        public IPresenterToInteractorGeradorRelatorio interactor;
        public IPresenterToRouterGeradorRelatorio router;
        public IPresenterToViewGeradorRelatorio view;

    }
}
