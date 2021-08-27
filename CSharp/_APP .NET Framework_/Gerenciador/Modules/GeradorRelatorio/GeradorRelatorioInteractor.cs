using VIPER.Entity;
using VIPER.Modules.GeradorRelatorio.Interfaces;
using VIPER.Service;
using FastReport.Design.StandardDesigner;
using System.Linq;

namespace VIPER.Modules.GeradorRelatorio.Interactors
{
    public class GeradorRelatorioInteractor : IPresenterToInteractorGeradorRelatorio
    {
        public IInteractorToPresenterGeradorRelatorio presenter;

        public void Excluir(Relatorio entity)
        {
            var mensagem = Servicos.relatorioService.Excluir(entity);
            if (mensagem != "")
                presenter.ExcluirFalha(mensagem);
            else
                presenter.ExcluirSucesso();
        }

        public void Filtrar(string condicao)
        {
            var dados = Servicos.relatorioService.Filtrar(condicao).OrderBy(p => p.Codigo).ToList();
            if (dados.Count != 0)
                presenter.FiltrarSucesso(dados);
            else
                presenter.FiltrarFalha("Nenhum registro encontrado com critério de busca!");
        }

        public void Salvar(Relatorio entity, DesignerControl designer, bool close)
        {
            var mensagem = Servicos.relatorioService.Salvar(entity);
            if (mensagem != "")
                presenter.SalvarFalha(mensagem);
            else
                presenter.SalvarSucesso(designer, close);
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
