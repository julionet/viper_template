using VIPER.Entity;
using VIPER.Modules.GeradorRelatorio.Interfaces;
using VIPER.Service;
using System.Linq;

namespace VIPER.GeradorRelatorio.Interactors
{
    public class GeradorRelatorioInteractor : IPresenterToInteractorGeradorRelatorio
    {
        public IInteractorToPresenterGeradorRelatorio presenter;

        public void Excluir(Relatorio entity)
        {
            throw new System.NotImplementedException();
        }

        public void Filtrar(string condicao)
        {
            throw new System.NotImplementedException();
        }

        public void Salvar(Relatorio entity)
        {
            var mensagem = Servicos.relatorioService.Salvar(entity);
            if (mensagem != "")
                presenter.SalvarFalha(mensagem);
            else
                presenter.SalvarSucesso();
        }

        public void SelecionarPorSistema(int sistema)
        {
            var dados = Servicos.funcaoService.SelecionarRelatorioPorSistema(sistema).Select(p => p.RelatorioId.Value).ToList();
            if (dados.Count != 0)
                presenter.SelecionarPorSistemaSucesso(dados);
            else
                presenter.SelecionarPorSistemaFalha();
        }
    }
}
