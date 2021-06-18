using VIPER.DTO;
using VIPER.Modules.ControleAcesso.Interfaces;
using VIPER.Service;
using System.Linq;

namespace VIPER.Modules.ControleAcesso.Interactors
{
    public class ControleAcessoInteractor : IPresenterToInteractorControleAcesso
    {
        public IInteractorToPresenterControleAcesso presenter;

        public void Salvar(UsuarioUsuarioFuncaoDTO entity)
        {
            var mensagem = Servicos.usuarioFuncaoService.Salvar(entity);
            if (mensagem != "")
                presenter.SalvarFalha(mensagem);
            else
                presenter.SalvarSucesso();
        }

        public void SelecionarListaFuncoes(int usuario)
        {
            var usuariofuncaos = Servicos.usuarioFuncaoService.SelecionarPorUsuario(usuario, Global.Instance.Sistema.Id);
            var funcaos = Servicos.funcaoService.SelecionarTodosCompleto();
            presenter.SelecionarListaFuncoesSucesso(usuariofuncaos, funcaos);

        }

        public void SelecionarPerfis(int usuario)
        {
            var selecionados = Servicos.usuarioService.SelecionarPerfis(usuario).ToList();
            var todos = Servicos.perfilService.SelecionarTodos();
            presenter.SelecionarPerfisSucesso(selecionados, todos);
        }

        public void SelecionarUsuario(int usuario)
        {
            var u = Servicos.usuarioService.Selecionar(usuario);
            if (u != null)
                presenter.SelecionarUsuarioSucesso(u);
            else
                presenter.SelecionarUsuarioFalha();
        }
    }
}
