using VIPER.Modules.Funcao.Interactors;
using VIPER.Modules.Funcao.Interfaces;
using VIPER.Modules.Funcao.Presenters;
using VIPER.Modules.Funcao.Views;
using System.Windows.Forms;

namespace VIPER.Modules.Funcao.Routers
{
    public class FuncaoRouter : IPresenterToRouterFuncao
    {
        public static Form New(BindingSource source, int id, string descricao)
        {
            return new FuncaoRouter().LoadModule(source, id, descricao);
        }

        private Form LoadModule(BindingSource source, int id, string descricao)
        {
            FuncaoPresenter presenter = new FuncaoPresenter();
            FuncaoInteractor interactor = new FuncaoInteractor();
            FuncaoRouter router = new FuncaoRouter();
            FuncaoView form = new FuncaoView(source, id, descricao);
			
            form.presenter = presenter;

            presenter.interactor = interactor;
            presenter.router = router;
            presenter.view = form;
			
            interactor.presenter = presenter;

            return form;
        }
    }
}
