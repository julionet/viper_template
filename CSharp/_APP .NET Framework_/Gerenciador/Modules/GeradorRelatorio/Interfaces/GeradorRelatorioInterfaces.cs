using VIPER.Entity;
using FastReport.Design.StandardDesigner;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VIPER.Modules.GeradorRelatorio.Interfaces
{
    public interface IViewToPresenterGeradorRelatorio
    {
        void Salvar(Relatorio entity, DesignerControl designer, bool close);
        void Excluir(Relatorio entity);
        void Filtrar(string condicao);
        void SelecionarPorSistema(int sistema);
        void CarregarManutencao(BindingSource source, out bool ok);
        void CarregarImportaRelatorio();
        void CarregarParametroRelatorio(string descricao, string xml, out bool ok, out string xmlparameter);
        void CarregarRelatorio(int? relatorio);
    }

    public interface IPresenterToViewGeradorRelatorio
    {
        void SalvarSucesso(DesignerControl designer, bool close);
        void SalvarFalha(string mensagem);
        void ExcluirSucesso();
        void ExcluirFalha(string mensagem);
        void FiltrarSucesso(List<Relatorio> dados);
        void FiltrarFalha(string mensagem);
        void SelecionarPorSistemaSucesso(List<int> dados);
        void SelecionarPorSistemaFalha();
    }

    public interface IPresenterToInteractorGeradorRelatorio
    {
        void Salvar(Relatorio entity, DesignerControl designer, bool close);
        void Excluir(Relatorio entity);
        void Filtrar(string condicao);
        void SelecionarPorSistema(int sistema);
    }

    public interface IInteractorToPresenterGeradorRelatorio
    {
        void SalvarSucesso(DesignerControl designer, bool close);
        void SalvarFalha(string mensagem);
        void ExcluirSucesso();
        void ExcluirFalha(string mensagem);
        void FiltrarSucesso(List<Relatorio> dados);
        void FiltrarFalha(string mensagem);
        void SelecionarPorSistemaSucesso(List<int> dados);
        void SelecionarPorSistemaFalha();
    }

    public interface IPresenterToRouterGeradorRelatorio
    {
        void CarregarManutencao(BindingSource source, out bool ok);
        void CarregarImportaRelatorio();
        void CarregarParametroRelatorio(string descricao, string xml, out bool ok, out string xmlparameter);
        void CarregarRelatorio(int? relatorio);
    }
}
