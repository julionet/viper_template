using VIPER.Modules.Modulo.Interactors;
using VIPER.Modules.Modulo.Interfaces;
using VIPER.Modules.Modulo.Presenters;
using VIPER.Modules.Modulo.Views;
using System.Windows.Forms;

namespace VIPER.Modules.Modulo.Routers
{
    public class ModuloRouter : IPresenterToRouterModulo
    {
        public static Form New(BindingSource source, BindingSource funcoes, int id, string descricao)
        {
            return new ModuloRouter().LoadModule(source, funcoes, id, descricao);
        }

        public void CarregarFuncao(BindingSource source, int id, string descricao, out bool ok)
        {
            using (var form = Funcao.Routers.FuncaoRouter.New(source, id, descricao))
            {
                ok = form.ShowDialog() == DialogResult.OK;
            }
        }

        private Form LoadModule(BindingSource source, BindingSource funcoes, int id, string descricao)
        {
            ModuloPresenter presenter = new ModuloPresenter();
            ModuloInteractor interactor = new ModuloInteractor();
            ModuloRouter router = new ModuloRouter();
            ModuloView form = new ModuloView(source, funcoes, id, descricao);
			
            form.presenter = presenter;

            presenter.interactor = interactor;
            presenter.router = router;
            presenter.view = form;
			
            interactor.presenter = presenter;

            return form;
        }
    }
}
