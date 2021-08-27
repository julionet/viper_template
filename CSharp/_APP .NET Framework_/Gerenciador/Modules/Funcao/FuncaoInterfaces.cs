using VIPER.DTO;
using VIPER.Entity;
using System.Collections.Generic;

namespace VIPER.Modules.Funcao.Interfaces
{
    public interface IViewToPresenterFuncao
    {
        void SelecionarDashboardas();
        void SelecionarRelatorios();
        void Validar(Entity.Funcao entity);
    }

    public interface IPresenterToViewFuncao
    {
        void SelecionarDashboardasSucesso(List<Dashboard> dados);
        void SelecionarDashboardasFalha();
        void SelecionarRelatoriosSucesso(List<RelatorioRetornoDTO> dados);
        void SelecionarRelatoriosFalha();
        void ValidarSucesso();
        void ValidarFalha(string mensagem);
    }

    public interface IPresenterToInteractorFuncao
    {
        void SelecionarDashboardas();
        void SelecionarRelatorios();
        void Validar(Entity.Funcao entity);
    }

    public interface IInteractorToPresenterFuncao
    {
        void SelecionarDashboardasSucesso(List<Dashboard> dados);
        void SelecionarDashboardasFalha();
        void SelecionarRelatoriosSucesso(List<RelatorioRetornoDTO> dados);
        void SelecionarRelatoriosFalha();
        void ValidarSucesso();
        void ValidarFalha(string mensagem);
    }

    public interface IPresenterToRouterFuncao
    {
        
    }
}
