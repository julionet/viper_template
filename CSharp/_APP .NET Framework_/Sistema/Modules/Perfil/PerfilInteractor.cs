using VIPER.DTO;
using VIPER.Modules.Perfil.Interfaces;
using VIPER.Service;
using System.Linq;

namespace VIPER.Modules.Perfil.Interactors
{
    public class PerfilInteractor : IPresenterToInteractorPerfil
    {
        public IInteractorToPresenterPerfil presenter;

        public void Excluir(Entity.Perfil entity)
        {
            var mensagem = Servicos.perfilService.Excluir(entity);
            if (mensagem != "")
                presenter.ExcluirFalha(mensagem);
            else
                presenter.ExcluirSucesso();
        }

        public void Gravar(PerfilPerfilFuncaoDTO entity)
        {
            var mensagem = Servicos.perfilService.Salvar(entity);
            if (mensagem != "")
                presenter.ExcluirFalha(mensagem);
            else
                presenter.ExcluirSucesso();
        }

        public void ObterDadosPrincipal(string condicao)
        {
            var dados = Servicos.perfilService.Filtrar(condicao);
            if (dados.Count != 0)
                presenter.ObterDadosPrincipalSucesso(dados);
            else
                presenter.ObterDadosPrincipalFalha();
        }

        public void SelecionarPerfilFuncao(int perfil, int sistema)
        {
            var perfils = Servicos.perfilService.SelecionarPorPerfil(perfil, sistema).ToList();
            var funcaos = Servicos.funcaoService.SelecionarTodosCompleto().ToList();

            presenter.SelecionarPerfilFuncaoSucesso(perfils, funcaos);
        }
    }
}
