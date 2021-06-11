using VIPER.Modules.Modulo.Routers;
using VIPER.Modules.Sistema.Interactors;
using VIPER.Modules.Sistema.Interfaces;
using VIPER.Modules.Sistema.Presenters;
using VIPER.Modules.Sistema.Views;
using System.Windows.Forms;

namespace VIPER.Modules.Sistema.Routers
{
    public class SistemaRouter : IPresenterToRouterSistema
    {
        public static Form New(int funcao)
        {
            return new SistemaRouter().LoadModule(funcao);
        }

        public void CarregarModulo(BindingSource source, BindingSource funcoes, int id, string descricao, out bool ok)
        {
            using (var form = ModuloRouter.New(source, funcoes, id, descricao))
            {
                ok = form.ShowDialog() == DialogResult.OK;
            }
        }

        private Form LoadModule(int funcao)
        {
            SistemaPresenter presenter = new SistemaPresenter();
            SistemaInteractor interactor = new SistemaInteractor();
            SistemaRouter router = new SistemaRouter();
            SistemaView form = new SistemaView(funcao);
			
            form.presenter = presenter;

            presenter.interactor = interactor;
            presenter.router = router;
            presenter.view = form;
			
            interactor.presenter = presenter;

            return form;
        }
    }
}
