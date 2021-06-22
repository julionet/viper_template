using VIPER.DTO;
using VIPER.Modules.Sistema.Interfaces;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VIPER.Modules.Sistema.Presenters
{
    public class SistemaPresenter : IViewToPresenterSistema, IInteractorToPresenterSistema
    {
        public IPresenterToInteractorSistema interactor;
        public IPresenterToRouterSistema router;
        public IPresenterToViewSistema view;

        public void CarregarModulo(BindingSource source, BindingSource funcoes, int id, string descricao, out bool ok)
        {
            router.CarregarModulo(source, funcoes, id, descricao, out ok);
        }

        public void Excluir(Entity.Sistema entity)
        {
            interactor.Excluir(entity);
        }

        public void ExcluirFalha(string mensagem)
        {
            view.ExcluirFalha(mensagem);
        }

        public void ExcluirSucesso()
        {
            view.ExcluirSucesso();
        }

        public void Gravar(SistemaModuloFuncaoDTO entity)
        {
            interactor.Gravar(entity);
        }

        public void GravarFalha(string mensagem)
        {
            view.GravarFalha(mensagem);
        }

        public void GravarSucesso()
        {
            view.GravarSucesso();
        }

        public void ObterDadosPrincipal(string condicao)
        {
            interactor.ObterDadosPrincipal(condicao);
        }

        public void ObterDadosPrincipalFalha()
        {
            view.ObterDadosPrincipalFalha();
        }

        public void ObterDadosPrincipalSucesso(List<Entity.Sistema> dados)
        {
            view.ObterDadosPrincipalSucesso(dados);
        }

        public void ObterFuncaos(int id)
        {
            interactor.ObterFuncaos(id);
        }

        public void ObterFuncaosFalha()
        {
            view.ObterFuncaosFalha();
        }

        public void ObterFuncaosSucesso(List<Entity.Funcao> dados, int moduloid)
        {
            view.ObterFuncaosSucesso(dados, moduloid);
        }

        public void ObterModulos(int id)
        {
            interactor.ObterModulos(id);
        }

        public void ObterModulosFalha()
        {
            view.ObterModulosFalha();
        }

        public void ObterModulosSucesso(List<Entity.Modulo> dados)
        {
            view.ObterModulosSucesso(dados);
        }
    }
}
