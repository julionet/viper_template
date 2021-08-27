using System.Collections.Generic;
using VIPER.Entity;
using VIPER.Modules.AtualizaVersao.Interfaces;

namespace VIPER.Modules.AtualizaVersao.Presenters
{
    public class AtualizaVersaoPresenter : IViewToPresenterAtualizaVersao, IInteractorToPresenterAtualizaVersao
    {
        public IPresenterToInteractorAtualizaVersao interactor;
        public IPresenterToRouterAtualizaVersao router;
        public IPresenterToViewAtualizaVersao view;

        public void Atualizar(List<Atualizacao> atualizacoes)
        {
            interactor.Atualizar(atualizacoes);
        }

        public void AtualizarConcluido()
        {
            view.AtualizarConcluido();
        }

        public void AtualizarFalha(string mensagem)
        {
            view.AtualizarFalha(mensagem);
        }

        public void AtualizarSucesso(string mensagem)
        {
            view.AtualizarSucesso(mensagem);
        }

        public void SelecionarPendentes()
        {
            interactor.SelecionarPendentes();
        }

        public void SelecionarPendentesFalha()
        {
            view.SelecionarPendentesFalha();
        }

        public void SelecionarPendentesSucesso(List<Atualizacao> dados)
        {
            view.SelecionarPendentesSucesso(dados);
        }
    }
}
