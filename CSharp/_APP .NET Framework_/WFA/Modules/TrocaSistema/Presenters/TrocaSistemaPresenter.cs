using VIPER.Modules.TrocaSistema.Interfaces;
using System.Collections.Generic;

namespace VIPER.Modules.TrocaSistema.Presenters
{
    public class TrocaSistemaPresenter : IViewToPresenterTrocaSistema, IInteractorToPresenterTrocaSistema
    {
        public IPresenterToInteractorTrocaSistema interactor;
        public IPresenterToRouterTrocaSistema router;
        public IPresenterToViewTrocaSistema view;

        public void SelecionarSistemas()
        {
            interactor.SelecionarSistemas();
        }

        public void SelecionarSistemasFalha(string mensagem)
        {
            view.SelecionarSistemasFalha(mensagem);
        }

        public void SelecionarSistemasSucesso(List<Entity.Sistema> sistemas)
        {
            view.SelecionarSistemasSucesso(sistemas);
        }
    }
}
