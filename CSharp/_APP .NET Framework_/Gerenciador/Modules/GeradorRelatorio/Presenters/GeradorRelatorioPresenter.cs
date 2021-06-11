using VIPER.Entity;
using VIPER.Modules.GeradorRelatorio.Interfaces;
using System.Collections.Generic;

namespace VIPER.Modules.GeradorRelatorio.Presenters
{
    public class GeradorRelatorioPresenter : IViewToPresenterGeradorRelatorio, IInteractorToPresenterGeradorRelatorio
    {
        public IPresenterToInteractorGeradorRelatorio interactor;
        public IPresenterToRouterGeradorRelatorio router;
        public IPresenterToViewGeradorRelatorio view;

        public void Excluir(Relatorio entity)
        {
            interactor.Excluir(entity);
        }

        public void ExcluirFalha(string mensagem)
        {
            view.ExcluirFalha(mensagem);
        }

        public void ExcluirSucesso()
        {
            view.ExcluirSucesso();
        }

        public void Filtrar(string condicao)
        {
            interactor.Filtrar(condicao);
        }

        public void FiltrarFalha()
        {
            view.FiltrarFalha();
        }

        public void FiltrarSucesso(List<Relatorio> dados)
        {
            view.FiltrarSucesso(dados);
        }

        public void Salvar(Relatorio entity)
        {
            interactor.Salvar(entity);
        }

        public void SalvarFalha(string mensagem)
        {
            view.SalvarFalha(mensagem);
        }

        public void SalvarSucesso()
        {
            view.SalvarSucesso();
        }

        public void SelecionarPorSistema(int sistema)
        {
            interactor.SelecionarPorSistema(sistema);
        }

        public void SelecionarPorSistemaFalha()
        {
            view.SelecionarPorSistemaFalha();
        }

        public void SelecionarPorSistemaSucesso(List<int> dados)
        {
            view.SelecionarPorSistemaSucesso(dados);
        }
    }
}
