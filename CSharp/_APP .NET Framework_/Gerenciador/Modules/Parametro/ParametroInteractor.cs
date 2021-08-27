using VIPER.Modules.Parametro.Interfaces;
using VIPER.Service;

namespace VIPER.Modules.Parametro.Interactors
{
    public class ParametroInteractor : IPresenterToInteractorParametro
    {
        public IInteractorToPresenterParametro presenter;

        public void Excluir(Entity.Parametro entity)
        {
            var mensagem = Servicos.parametroService.Excluir(entity);
            if (mensagem != "")
                presenter.ExcluirFalha(mensagem);
            else
                presenter.ExcluirSucesso();
        }

        public void Gravar(Entity.Parametro entity)
        {
            var mensagem = Servicos.parametroService.Salvar(entity);
            if (mensagem != "")
                presenter.GravarFalha(mensagem);
            else
                presenter.GravarSucesso();
        }

        public void ObterDadosPrincipal(string condicao)
        {
            var dados = Servicos.parametroService.Filtrar(condicao);
            if (dados.Count != 0)
                presenter.ObterDadosPrincipalSucesso(dados);
            else
                presenter.ObterDadosPrincipalFalha();
        }
    }
}
