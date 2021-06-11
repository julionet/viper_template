using VIPER.Modules.TrocaSistema.Interfaces;
using VIPER.Service;
using System.Linq;

namespace VIPER.Modules.TrocaSistema.Interactors
{
    public class TrocaSistemaInteractor : IPresenterToInteractorTrocaSistema
    {
        public IInteractorToPresenterTrocaSistema presenter;

        public void SelecionarSistemas()
        {
            var sistemas = Global.Instance.Sistemas.Where(p => p.Ativo && !p.Gerenciador).OrderBy(p => p.Descricao).ToList();
            if (sistemas.Count() != 0)
                presenter.SelecionarSistemasSucesso(sistemas);
            else
                presenter.SelecionarSistemasFalha("Não há sistemas cadastrados!");
        }
    }
}
