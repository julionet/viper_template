using VIPER.DTO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VIPER.Modules.Sistema.Interfaces
{
    public interface IViewToPresenterSistema
    {
        void ObterDadosPrincipal(string condicao);
        void ObterModulos(int id);
        void ObterFuncaos(int id);
        void Gravar(SistemaModuloFuncaoDTO entity);
        void Excluir(Entity.Sistema entity);
        void CarregarModulo(BindingSource source, BindingSource funcoes, int id, string descricao, out bool ok);
    }

    public interface IPresenterToViewSistema
    {
        void GravarSucesso();
        void GravarFalha(string mensagem);
        void ExcluirSucesso();
        void ExcluirFalha(string mensagem);
        void ObterDadosPrincipalSucesso(List<Entity.Sistema> dados);
        void ObterDadosPrincipalFalha();
        void ObterModulosSucesso(List<Entity.Modulo> dados);
        void ObterModulosFalha();
        void ObterFuncaosSucesso(List<Entity.Funcao> dados, int moduloid);
        void ObterFuncaosFalha();
    }

    public interface IPresenterToInteractorSistema
    {
        void ObterDadosPrincipal(string condicao);
        void ObterModulos(int id);
        void ObterFuncaos(int id);
        void Gravar(SistemaModuloFuncaoDTO entity);
        void Excluir(Entity.Sistema entity);
    }

    public interface IInteractorToPresenterSistema
    {
        void GravarSucesso();
        void GravarFalha(string mensagem);
        void ExcluirSucesso();
        void ExcluirFalha(string mensagem);
        void ObterDadosPrincipalSucesso(List<Entity.Sistema> dados);
        void ObterDadosPrincipalFalha();
        void ObterModulosSucesso(List<Entity.Modulo> dados);
        void ObterModulosFalha();
        void ObterFuncaosSucesso(List<Entity.Funcao> dados, int moduloid);
        void ObterFuncaosFalha();
    }

    public interface IPresenterToRouterSistema
    {
        void CarregarModulo(BindingSource source, BindingSource funcoes, int id, string descricao, out bool ok);
    }
}
