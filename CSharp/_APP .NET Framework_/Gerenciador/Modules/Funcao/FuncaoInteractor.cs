using VIPER.Modules.Funcao.Interfaces;
using VIPER.Service;
using System.Linq;

namespace VIPER.Modules.Funcao.Interactors
{
    public class FuncaoInteractor : IPresenterToInteractorFuncao
    {
        public IInteractorToPresenterFuncao presenter;

        public void SelecionarDashboardas()
        {
            var dados = Servicos.dashboardService.SelecionarTodos().OrderBy(p => p.Nome).ToList();
            if (dados.Count != 0)
                presenter.SelecionarDashboardasSucesso(dados);
            else
                presenter.SelecionarDashboardasFalha();
        }

        public void SelecionarRelatorios()
        {
            var dados = Servicos.relatorioService.SelecionarTodos().OrderBy(p => p.Nome).ToList();
            if (dados.Count != 0)
                presenter.SelecionarRelatoriosSucesso(dados);
            else
                presenter.SelecionarRelatoriosFalha();
        }

        public void Validar(Entity.Funcao entity)
        {
            var mensagem = Servicos.funcaoService.ValidarDados(entity);
            if (mensagem != "")
                presenter.ValidarFalha(mensagem);
            else
                presenter.ValidarSucesso();
        }
    }
}
