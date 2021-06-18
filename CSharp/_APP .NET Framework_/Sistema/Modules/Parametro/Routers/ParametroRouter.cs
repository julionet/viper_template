using VIPER.Modules.Parametro.Interactors;
using VIPER.Modules.Parametro.Interfaces;
using VIPER.Modules.Parametro.Presenters;
using VIPER.Modules.Parametro.Views;
using VIPER.Modules.ParametroEdicao.Views;
using System.Windows.Forms;

namespace VIPER.Modules.Parametro.Routers
{
    public class ParametroRouter : IPresenterToRouterParametro
    {
        public static Form New(int funcao)
        {
            return new ParametroRouter().LoadModule(funcao);
        }

        public void CarregarParametroEdicao(string descricao, string tipocomponente, string valorpadrao, string lista, bool editavel, ref string valorpersonalizado, out bool ok)
        {
            using (var form = ParametroEdicao.Routers.ParametroEdicaoRouter.New(descricao, tipocomponente, valorpadrao, lista, valorpersonalizado, editavel))
            {
                ok = form.ShowDialog() == DialogResult.OK;
                if (ok)
                    valorpersonalizado = (form as ParametroEdicaoView).ValorPersonalizado;
            }
        }

        public void CarregarParametroUsuario(int parametro, string tipocomponente, string lista, string descricaoparametro)
        {
            using (var form = ParametroUsuario.Routers.ParametroUsuarioRouter.New(parametro, tipocomponente, lista, descricaoparametro))
            {
                form.ShowDialog();
            }
        }

        private Form LoadModule(int funcao)
        {
            ParametroPresenter presenter = new ParametroPresenter();
            ParametroInteractor interactor = new ParametroInteractor();
            ParametroRouter router = new ParametroRouter();
            ParametroView form = new ParametroView(funcao);
			
            form.presenter = presenter;

            presenter.interactor = interactor;
            presenter.router = router;
            presenter.view = form;
			
            interactor.presenter = presenter;

            return form;
        }
    }
}
