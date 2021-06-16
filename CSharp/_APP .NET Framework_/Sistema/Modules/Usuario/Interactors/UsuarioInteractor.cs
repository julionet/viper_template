using VIPER.Modules.Usuario.Interfaces;
using VIPER.Service;

namespace VIPER.Modules.Usuario.Interactors
{
    public class UsuarioInteractor : IPresenterToInteractorUsuario
    {
        public IInteractorToPresenterUsuario presenter;

        public void Excluir(Entity.Usuario entity)
        {
            var mensagem = Servicos.usuarioService.Excluir(entity);
            if (mensagem != "")
                presenter.ExcluirFalha(mensagem);
            else
                presenter.ExcluirSucesso();
        }

        public void Gravar(Entity.Usuario entity)
        {
            var mensagem = Servicos.usuarioService.Salvar(entity);
            if (mensagem != "")
                presenter.GravarFalha(mensagem);
            else
                presenter.GravarSucesso();
        }

        public void ObterDadosPrincipal(string condicao)
        {
            var dados = Servicos.usuarioService.Filtrar(condicao);
            if (dados.Count != 0)
                presenter.ObterDadosPrincipalSucesso(dados);
            else
                presenter.ObterDadosPrincipalFalha();
        }
    }
}
