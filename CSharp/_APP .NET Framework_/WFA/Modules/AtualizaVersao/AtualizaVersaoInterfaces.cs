using System.Collections.Generic;
using VIPER.Entity;

namespace VIPER.Modules.AtualizaVersao.Interfaces
{
    public interface IViewToPresenterAtualizaVersao
    {
        void SelecionarPendentes();
        void Atualizar(List<Atualizacao> atualizacoes);
    }

    public interface IPresenterToViewAtualizaVersao
    {
        void SelecionarPendentesSucesso(List<Atualizacao> dados);
        void SelecionarPendentesFalha();
        void AtualizarSucesso(string mensagem);
        void AtualizarFalha(string mensagem);
        void AtualizarConcluido();
    }

    public interface IPresenterToInteractorAtualizaVersao
    {
        void SelecionarPendentes();
        void Atualizar(List<Atualizacao> atualizacoes);
    }

    public interface IInteractorToPresenterAtualizaVersao
    {
        void SelecionarPendentesSucesso(List<Atualizacao> dados);
        void SelecionarPendentesFalha();
        void AtualizarSucesso(string mensagem);
        void AtualizarFalha(string mensagem);
        void AtualizarConcluido();
    }

    public interface IPresenterToRouterAtualizaVersao
    {
        
    }
}
