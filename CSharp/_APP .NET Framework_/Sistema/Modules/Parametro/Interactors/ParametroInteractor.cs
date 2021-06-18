using VIPER.Modules.Parametro.Interfaces;
using VIPER.Service;
using System.Linq;

namespace VIPER.Modules.Parametro.Interactors
{
    public class ParametroInteractor : IPresenterToInteractorParametro
    {
        public IInteractorToPresenterParametro presenter;

        public void Salvar(Entity.Parametro entity)
        {
            var mensagem = Servicos.parametroService.Salvar(entity);
            if (mensagem != "")
                presenter.SalvarFalha(mensagem);
            else
            {
                Parametros.Instance.Reload();
                presenter.SalvarSucesso();
            }
        }

        public void SelecionarCategorias()
        {
            var dados = Servicos.dominioItemService.SelecionarPorDominio(1).OrderBy(p => p.Descricao).ToList();
            if (dados.Count() != 0)
                presenter.SelecionarCategoriasSucesso(dados);
            else
                presenter.SelecionarCategoriasFalha();
        }

        public void SelecionarParametrosPorCategoria(string categoria)
        {
            var parametros = Servicos.parametroService.SelecionarPorCategoria(categoria).OrderBy(p => p.Descricao).ToList();
            if (parametros.Count() != 0)
                presenter.SelecionarParametrosPorCategoriaSucesso(parametros);
            else
                presenter.SelecionarParametrosPorCategoriaFalha();
        }
    }
}
