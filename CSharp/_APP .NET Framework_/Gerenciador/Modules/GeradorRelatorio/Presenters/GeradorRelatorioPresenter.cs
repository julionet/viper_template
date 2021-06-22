using VIPER.Entity;
using VIPER.Modules.GeradorRelatorio.Interfaces;
using FastReport.Design.StandardDesigner;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VIPER.Modules.GeradorRelatorio.Presenters
{
    public class GeradorRelatorioPresenter : IViewToPresenterGeradorRelatorio, IInteractorToPresenterGeradorRelatorio
    {
        public IPresenterToInteractorGeradorRelatorio interactor;
        public IPresenterToRouterGeradorRelatorio router;
        public IPresenterToViewGeradorRelatorio view;

        public void CarregarImportaRelatorio()
        {
            router.CarregarImportaRelatorio();
        }

        public void CarregarManutencao(BindingSource source, out bool ok)
        {
            router.CarregarManutencao(source, out ok);
        }

        public void CarregarParametroRelatorio(string descricao, string xml, out bool ok, out string xmlparameter)
        {
            router.CarregarParametroRelatorio(descricao, xml, out ok, out xmlparameter);
        }

        public void CarregarRelatorio(int? relatorio)
        {
            router.CarregarRelatorio(relatorio);
        }

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

        public void FiltrarFalha(string mensagem)
        {
            view.FiltrarFalha(mensagem);
        }

        public void FiltrarSucesso(List<Relatorio> dados)
        {
            view.FiltrarSucesso(dados);
        }

        public void Salvar(Relatorio entity, DesignerControl designer, bool close)
        {
            interactor.Salvar(entity, designer, close);
        }

        public void SalvarFalha(string mensagem)
        {
            view.SalvarFalha(mensagem);
        }

        public void SalvarSucesso(DesignerControl designer, bool close)
        {
            view.SalvarSucesso(designer, close);
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
