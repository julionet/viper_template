using VIPER.Entity;
using VIPER.Modules.DesbloqueioRegistro.Interfaces;
using VIPER.Service;
using System.Linq;

namespace VIPER.Modules.DesbloqueioRegistro.Interactors
{
    public class DesbloqueioRegistroInteractor : IPresenterToInteractorDesbloqueioRegistro
    {
        public IInteractorToPresenterDesbloqueioRegistro presenter;

        public void Desbloquear(Bloqueio entity)
        {
            Servicos.bloqueioService.ExcluirBloqueio(entity.Classe, entity.Referencia);
            presenter.DesbloquearSucesso();
        }

        public void DesbloquearTodos(Bloqueio[] dados)
        {
            foreach (var registro in dados)
                Servicos.bloqueioService.ExcluirBloqueio(registro.Classe, registro.Referencia);
            presenter.DesbloquearTodosSucesso();
        }

        public void SelecionarTodos()
        {
            var dados = Servicos.bloqueioService.SelecionarTodos().OrderBy(p => p.DataHora).ToList();
            if (dados.Count != 0)
                presenter.SelecionarTodosSucesso(dados);
            else
                presenter.SelecionarTodosFalha("Nenhum registro de bloqueio foi encontrado!");
        }
    }
}
