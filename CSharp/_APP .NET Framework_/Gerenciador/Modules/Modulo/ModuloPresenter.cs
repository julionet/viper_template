using VIPER.Modules.Modulo.Interfaces;
using System.Windows.Forms;

namespace VIPER.Modules.Modulo.Presenters
{
    public class ModuloPresenter : IViewToPresenterModulo, IInteractorToPresenterModulo
    {
        public IPresenterToInteractorModulo interactor;
        public IPresenterToRouterModulo router;
        public IPresenterToViewModulo view;

        public void CarregarFuncao(BindingSource source, int id, string descricao, out bool ok)
        {
            router.CarregarFuncao(source, id, descricao, out ok);
        }

        public void Validar(Entity.Modulo entity)
        {
            interactor.Validar(entity);
        }

        public void ValidarFalha(string mensagem)
        {
            view.ValidarFalha(mensagem);
        }

        public void ValidarSucesso()
        {
            view.ValidarSucesso();
        }
    }
}
