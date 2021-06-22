using VIPER.DTO;
using VIPER.Modules.Sistema.Interfaces;
using VIPER.Service;

namespace VIPER.Modules.Sistema.Interactors
{
    public class SistemaInteractor : IPresenterToInteractorSistema
    {
        public IInteractorToPresenterSistema presenter;

        public void Excluir(Entity.Sistema entity)
        {
            var mensagem = Servicos.sistemaService.Excluir(entity);
            if (mensagem != "")
                presenter.ExcluirFalha(mensagem);
            else
                presenter.ExcluirSucesso();
        }

        public void Gravar(SistemaModuloFuncaoDTO entity)
        {
            var mensagem = Servicos.sistemaService.Salvar(entity);
            if (mensagem != "")
                presenter.GravarFalha(mensagem);
            else
                presenter.GravarSucesso();
        }

        public void ObterDadosPrincipal(string condicao)
        {
            var dados = Servicos.sistemaService.Filtrar(condicao);
            if (dados.Count == 0)
                presenter.ObterDadosPrincipalFalha();
            else
                presenter.ObterDadosPrincipalSucesso(dados);
        }

        public void ObterFuncaos(int id)
        {
            var dados = Servicos.funcaoService.SelecionarPorModulo(id);
            if (dados.Count == 0)
                presenter.ObterFuncaosFalha();
            else
                presenter.ObterFuncaosSucesso(dados, id);
        }

        public void ObterModulos(int id)
        {
            var dados = Servicos.moduloService.SelecionarPorSistema(id);
            if (dados.Count == 0)
                presenter.ObterModulosFalha();
            else
                presenter.ObterModulosSucesso(dados);
        }
    }
}
