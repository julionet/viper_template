using VIPER.Modules.Modulo.Interfaces;
using VIPER.Service;

namespace VIPER.Modules.Modulo.Interactors
{
    public class ModuloInteractor : IPresenterToInteractorModulo
    {
        public IInteractorToPresenterModulo presenter;

        public void Validar(Entity.Modulo entity)
        {
            string mensagem = Servicos.moduloService.ValidarDados(entity);
            if (mensagem != "")
                presenter.ValidarFalha(mensagem);
            else
                presenter.ValidarSucesso();
        }
    }
}
