using VIPER.Modules.Parametro.Interfaces;
using System.Collections.Generic;

namespace VIPER.Modules.Parametro.Presenters
{
    public class ParametroPresenter : IViewToPresenterParametro, IInteractorToPresenterParametro
    {
        public IPresenterToInteractorParametro interactor;
        public IPresenterToRouterParametro router;
        public IPresenterToViewParametro view;

        public void CarregarParametroEdicao(string descricao, string tipocomponente, string valorpadrao, string lista, bool editavel, ref string valorpersonalizado, out bool ok)
        {
            router.CarregarParametroEdicao(descricao, tipocomponente, valorpadrao, lista, editavel, ref valorpersonalizado, out ok);
        }

        public void CarregarParametroUsuario(int parametro, string tipocomponente, string lista, string descricaoparametro)
        {
            router.CarregarParametroUsuario(parametro, tipocomponente, lista, descricaoparametro);
        }

        public void Salvar(Entity.Parametro entity)
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

        public void SelecionarCategorias()
        {
            interactor.SelecionarCategorias();
        }

        public void SelecionarCategoriasFalha()
        {
            view.SelecionarCategoriasFalha();
        }

        public void SelecionarParametrosPorCategoria(string categoria)
        {
            interactor.SelecionarParametrosPorCategoria(categoria);
        }

        public void SelecionarParametrosPorCategoriaFalha()
        {
            view.SelecionarParametrosPorCategoriaFalha();
        }

        public void SelecionarParametrosPorCategoriaSucesso(List<Entity.Parametro> parametros)
        {
            view.SelecionarParametrosPorCategoriaSucesso(parametros);
        }

        public void SelecionarCategoriasSucesso(List<Entity.DominioItem> dados)
        {
            view.SelecionarCategoriasSucesso(dados);
        }
    }
}
