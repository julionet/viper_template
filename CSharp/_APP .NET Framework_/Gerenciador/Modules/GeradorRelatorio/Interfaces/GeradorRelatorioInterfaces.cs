using VIPER.Entity;
using System.Collections.Generic;

namespace VIPER.Modules.GeradorRelatorio.Interfaces
{
    public interface IViewToPresenterGeradorRelatorio
    {
        void Salvar(Entity.Relatorio entity);
        void Excluir(Entity.Relatorio entity);
        void Filtrar(string condicao);
        void SelecionarPorSistema(int sistema);
    }

    public interface IPresenterToViewGeradorRelatorio
    {
        void SalvarSucesso();
        void SalvarFalha(string mensagem);
        void ExcluirSucesso();
        void ExcluirFalha(string mensagem);
        void FiltrarSucesso(List<Relatorio> dados);
        void FiltrarFalha();
        void SelecionarPorSistemaSucesso(List<int> dados);
        void SelecionarPorSistemaFalha();
    }

    public interface IPresenterToInteractorGeradorRelatorio
    {
        void Salvar(Entity.Relatorio entity);
        void Excluir(Entity.Relatorio entity);
        void Filtrar(string condicao);
        void SelecionarPorSistema(int sistema);
    }

    public interface IInteractorToPresenterGeradorRelatorio
    {
        void SalvarSucesso();
        void SalvarFalha(string mensagem);
        void ExcluirSucesso();
        void ExcluirFalha(string mensagem);
        void FiltrarSucesso(List<Relatorio> dados);
        void FiltrarFalha();
        void SelecionarPorSistemaSucesso(List<int> dados);
        void SelecionarPorSistemaFalha();
    }

    public interface IPresenterToRouterGeradorRelatorio
    {
        
    }
}
