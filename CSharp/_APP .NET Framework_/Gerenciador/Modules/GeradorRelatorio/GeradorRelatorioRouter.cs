using VIPER.Modules.GeradorRelatorio.Interactors;
using VIPER.Modules.GeradorRelatorio.Interfaces;
using VIPER.Modules.GeradorRelatorio.Presenters;
using VIPER.Modules.GeradorRelatorio.Views;
using Chronus.DXperience;
using System.Windows.Forms;
using Chronus.Comum;

namespace VIPER.Modules.GeradorRelatorio.Routers
{
    public class GeradorRelatorioRouter : IPresenterToRouterGeradorRelatorio
    {
        public static Form New(int funcao)
        {
            return new GeradorRelatorioRouter().LoadModule(funcao);
        }

        public void CarregarImportaRelatorio()
        {
            using (var form = ImportaRelatorio.Routers.ImportaRelatorioRouter.New())
            {
                form.ShowDialog();
            }
        }

        public void CarregarManutencao(BindingSource source, out bool ok)
        {
            using (var form = GeradorRelatorioManutencao.Routers.GeradorRelatorioManutencaoRouter.New(source))
            {
                ok = form.ShowDialog() == DialogResult.OK;
            }
        }

        public void CarregarParametroRelatorio(string descricao, string xml, out bool ok, out string xmlparameter)
        {
            using (var form = new FrmParametroRelatorioDX(descricao, xml))
            {
                xmlparameter = "";
                ok = form.ShowDialog() == DialogResult.OK;
                if (ok)
                    xmlparameter = form.XmlParameter;
            }
        }

        public void CarregarRelatorio(int? relatorio)
        {
            using (var form = new FrmParametroRelatorio(relatorio))
            {
                form.ShowDialog();
            }
        }

        private Form LoadModule(int funcao)
        {
            GeradorRelatorioPresenter presenter = new GeradorRelatorioPresenter();
            GeradorRelatorioInteractor interactor = new GeradorRelatorioInteractor();
            GeradorRelatorioRouter router = new GeradorRelatorioRouter();
            GeradorRelatorioView form = new GeradorRelatorioView(funcao);
			
            form.presenter = presenter;

            presenter.interactor = interactor;
            presenter.router = router;
            presenter.view = form;
			
            interactor.presenter = presenter;

            return form;
        }
    }
}
