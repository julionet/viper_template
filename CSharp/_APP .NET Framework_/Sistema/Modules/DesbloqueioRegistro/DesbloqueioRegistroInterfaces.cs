using VIPER.Entity;
using System.Collections.Generic;

namespace VIPER.Modules.DesbloqueioRegistro.Interfaces
{
    public interface IViewToPresenterDesbloqueioRegistro
    {
        void SelecionarTodos();
        void Desbloquear(Bloqueio entity);
        void DesbloquearTodos(Bloqueio[] dados);
    }

    public interface IPresenterToViewDesbloqueioRegistro
    {
        void SelecionarTodosSucesso(List<Bloqueio> dados);
        void SelecionarTodosFalha(string mensagem);
        void DesbloquearSucesso();
        void DesbloquearFalha(string mensagem);
        void DesbloquearTodosSucesso();
        void DesbloquearTodosFalha(string mensagem);
    }

    public interface IPresenterToInteractorDesbloqueioRegistro
    {
        void SelecionarTodos();
        void Desbloquear(Bloqueio entity);
        void DesbloquearTodos(Bloqueio[] dados);
    }

    public interface IInteractorToPresenterDesbloqueioRegistro
    {
        void SelecionarTodosSucesso(List<Bloqueio> dados);
        void SelecionarTodosFalha(string mensagem);
        void DesbloquearSucesso();
        void DesbloquearFalha(string mensagem);
        void DesbloquearTodosSucesso();
        void DesbloquearTodosFalha(string mensagem);
    }

    public interface IPresenterToRouterDesbloqueioRegistro
    {
        
    }
}
