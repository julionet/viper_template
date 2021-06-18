using System.Collections.Generic;

namespace VIPER.Modules.Parametro.Interfaces
{
    public interface IViewToPresenterParametro
    {
        void SelecionarCategorias();
        void SelecionarParametrosPorCategoria(string categoria);
        void Salvar(Entity.Parametro entity);
        void CarregarParametroEdicao(string descricao, string tipocomponente, string valorpadrao, string lista, bool editavel, ref string valorpersonalizado, out bool ok);
        void CarregarParametroUsuario(int parametro, string tipocomponente, string lista, string descricaoparametro);
    }

    public interface IPresenterToViewParametro
    {
        void SelecionarCategoriasSucesso(List<Entity.DominioItem> dados);
        void SelecionarCategoriasFalha();
        void SelecionarParametrosPorCategoriaSucesso(List<Entity.Parametro> parametros);
        void SelecionarParametrosPorCategoriaFalha();
        void SalvarSucesso();
        void SalvarFalha(string mensagem);
    }

    public interface IPresenterToInteractorParametro
    {
        void SelecionarCategorias();
        void SelecionarParametrosPorCategoria(string categoria);
        void Salvar(Entity.Parametro entity);
    }

    public interface IInteractorToPresenterParametro
    {
        void SelecionarCategoriasSucesso(List<Entity.DominioItem> dados);
        void SelecionarCategoriasFalha();
        void SelecionarParametrosPorCategoriaSucesso(List<Entity.Parametro> parametros);
        void SelecionarParametrosPorCategoriaFalha();
        void SalvarSucesso();
        void SalvarFalha(string mensagem);
    }

    public interface IPresenterToRouterParametro
    {
        void CarregarParametroEdicao(string descricao, string tipocomponente, string valorpadrao, string lista, bool editavel, ref string valorpersonalizado, out bool ok);
        void CarregarParametroUsuario(int parametro, string tipocomponente, string lista, string descricaoparametro);
    }
}
