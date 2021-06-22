using VIPER.Entity;
using VIPER.Modules.DesbloqueioRegistro.Interfaces;
using System.Collections.Generic;

namespace VIPER.Modules.DesbloqueioRegistro.Presenters
{
    public class DesbloqueioRegistroPresenter : IViewToPresenterDesbloqueioRegistro, IInteractorToPresenterDesbloqueioRegistro
    {
        public IPresenterToInteractorDesbloqueioRegistro interactor;
        public IPresenterToRouterDesbloqueioRegistro router;
        public IPresenterToViewDesbloqueioRegistro view;

        public void Desbloquear(Bloqueio entity)
        {
            interactor.Desbloquear(entity);
        }

        public void DesbloquearFalha(string mensagem)
        {
            view.DesbloquearFalha(mensagem);
        }

        public void DesbloquearSucesso()
        {
            view.DesbloquearSucesso();
        }

        public void DesbloquearTodos(Bloqueio[] dados)
        {
            interactor.DesbloquearTodos(dados);
        }

        public void DesbloquearTodosFalha(string mensagem)
        {
            view.DesbloquearTodosFalha(mensagem);
        }

        public void DesbloquearTodosSucesso()
        {
            view.DesbloquearTodosSucesso();
        }

        public void SelecionarTodos()
        {
            interactor.SelecionarTodos();
        }

        public void SelecionarTodosFalha(string mensagem)
        {
            view.SelecionarTodosFalha(mensagem);
        }

        public void SelecionarTodosSucesso(List<Bloqueio> dados)
        {
            view.SelecionarTodosSucesso(dados);
        }
    }
}
