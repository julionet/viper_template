using System.Collections.Generic;

namespace VIPER.Modules.TrocaSistema.Interfaces
{
    public interface IViewToPresenterTrocaSistema
    {
        void SelecionarSistemas();
    }

    public interface IPresenterToViewTrocaSistema
    {
        void SelecionarSistemasSucesso(List<Entity.Sistema> sistemas);
        void SelecionarSistemasFalha(string mensagem);
    }

    public interface IPresenterToInteractorTrocaSistema
    {
        void SelecionarSistemas();
    }

    public interface IInteractorToPresenterTrocaSistema
    {
        void SelecionarSistemasSucesso(List<Entity.Sistema> sistemas);
        void SelecionarSistemasFalha(string mensagem);
    }

    public interface IPresenterToRouterTrocaSistema
    {
        
    }
}
