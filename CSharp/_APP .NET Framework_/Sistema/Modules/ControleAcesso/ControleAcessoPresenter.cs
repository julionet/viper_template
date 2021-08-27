using VIPER.DTO;
using VIPER.Modules.ControleAcesso.Interfaces;
using System.Collections.Generic;

namespace VIPER.Modules.ControleAcesso.Presenters
{
    public class ControleAcessoPresenter : IViewToPresenterControleAcesso, IInteractorToPresenterControleAcesso
    {
        public IPresenterToInteractorControleAcesso interactor;
        public IPresenterToRouterControleAcesso router;
        public IPresenterToViewControleAcesso view;

        public void CarregarPermissaoAcesso(string descricao, ref bool incluir, ref bool alterar, ref bool excluir, out bool ok)
        {
            router.CarregarPermissaoAcesso(descricao, ref incluir, ref alterar, ref excluir, out ok);
        }

        public void Salvar(UsuarioUsuarioFuncaoDTO entity)
        {
            interactor.Salvar(entity);
        }

        public void SalvarFalha(string mensagem)
        {
            view.SalvarFalha(mensagem);
        }

        public void SalvarSucesso()
        {
            view.SalvarSucesso();
        }

        public void SelecionarListaFuncoes(int usuario)
        {
            interactor.SelecionarListaFuncoes(usuario);
        }

        public void SelecionarListaFuncoesSucesso(List<UsuarioFuncaoDTO> usuarioFuncaos, List<FuncaoDTO> funcaos)
        {
            view.SelecionarListaFuncoesSucesso(usuarioFuncaos, funcaos);
        }

        public void SelecionarPerfis(int usuario)
        {
            interactor.SelecionarPerfis(usuario);
        }

        public void SelecionarPerfisSucesso(List<Entity.Perfil> perfilselecionados, List<Entity.Perfil> perfiltodos)
        {
            view.SelecionarPerfisSucesso(perfilselecionados, perfiltodos);
        }

        public void SelecionarUsuario(int usuario)
        {
            interactor.SelecionarUsuario(usuario);
        }

        public void SelecionarUsuarioFalha()
        {
            view.SelecionarUsuarioFalha();
        }

        public void SelecionarUsuarioSucesso(Entity.Usuario usuario)
        {
            view.SelecionarUsuarioSucesso(usuario);
        }
    }
}
