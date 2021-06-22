using VIPER.Modules.GeradorRelatorio.Interfaces;
using Chronus.DXperience;
using Chronus.Library;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using FastReport;
using FastReport.Design.StandardDesigner;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIPER.Modules.GeradorRelatorio.Views
{
    public partial class GeradorRelatorioView : FrmModelo, IPresenterToViewGeradorRelatorio
    {
        public IViewToPresenterGeradorRelatorio presenter;

        private SplashScreen _splash;
        private string _condicao = "";

        public GeradorRelatorioView(int funcao)
        {
            InitializeComponent();

            CreateGridButtons(gridViewRelatorio);
        }

        private void SalvarRelatorio(Entity.Relatorio relatorio, DesignerControl designer = null, bool close = false)
        {
            _splash = new SplashScreen("Salvando relatório...");
            presenter.Salvar(relatorio, designer, close);
        }

        protected override void CreateGridButtons(GridViewWithButtons gridView)
        {
            gridView.ButtonsPanel.Buttons.Add(new EditorButton(ButtonPredefines.Glyph) { Caption = "Alterar" });
            gridView.ButtonsPanel.Buttons[0].Click += (s, e) =>
            {
                var registro = (detalheBindingSource.Current as Entity.Relatorio);
                var itemBackup = Classe.CloneClass<Entity.Relatorio>(registro);

                presenter.CarregarManutencao(detalheBindingSource, out bool ok);
                if (!ok)
                {
                    var i = detalheBindingSource.IndexOf(detalheBindingSource.Current);
                    detalheBindingSource.RemoveCurrent();
                    detalheBindingSource.Insert(i, itemBackup);
                    gridViewRelatorio.RefreshData();
                }
            };

            gridView.ButtonsPanel.Buttons.Add(new EditorButton(ButtonPredefines.Glyph) { Caption = "Excluir" });
            gridView.ButtonsPanel.Buttons[1].Click += (s, e) =>
            {
                if (XtraMessageBox.Show("Deseja realmente excluir relatório selecionado?", "Confirmação", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    _splash = new SplashScreen("Excluindo relatório...");
                    presenter.Excluir(detalheBindingSource.Current as Entity.Relatorio);
                }
            };

            gridView.ButtonsPanel.Buttons.Add(new EditorButton(ButtonPredefines.Glyph) { Caption = "Designer" });
            gridView.ButtonsPanel.Buttons[2].Click += (s, e) =>
            {
                using (var report = new Report())
                {
                    if (!string.IsNullOrWhiteSpace((detalheBindingSource.Current as Entity.Relatorio).Modelo))
                    {
                        var b = Encoding.UTF8.GetBytes((detalheBindingSource.Current as Entity.Relatorio).Modelo);
                        var ms = new MemoryStream(b);
                        report.Load(ms);
                        ms.Dispose();
                    }
                    using (DesignerForm designer = new DesignerForm())
                    {
                        ToolbarBase standardToolbar = designer.Designer.Plugins.Find("StandardToolbar") as ToolbarBase;
                        standardToolbar.Items["btnStdNew"].Visible = false;
                        standardToolbar.Items["btnStdOpen"].Visible = false;
                        standardToolbar.Items["btnStdSaveAll"].Visible = false;
                        designer.Designer.MainMenu.Items[0].SubItems[0].Visible = false;
                        designer.Designer.MainMenu.Items[0].SubItems[1].Visible = false;
                        designer.Designer.MainMenu.Items[0].SubItems[4].Text = "Salvar e Sair";
                        designer.Designer.cmdSave.CustomAction += CmdSave_CustomAction;
                        designer.Designer.cmdSaveAs.CustomAction += CmdSaveAs_CustomAction;
                        designer.Designer.AskSave = false;
                        designer.Designer.Report = report;
                        designer.ShowDialog();
                        if (designer.Designer.Modified)
                        {
                            if (XtraMessageBox.Show("Alterações no relatório não foram salvas, deseja salvar agora?", "Confirmação",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            {
                                (detalheBindingSource.Current as Entity.Relatorio).Modelo = designer.Designer.Report.SaveToString();
                                (detalheBindingSource.Current as Entity.Relatorio).Tamanho = (detalheBindingSource.Current as Entity.Relatorio).Modelo.Length;
                                (detalheBindingSource.Current as Entity.Relatorio).Modificado = DateTime.Now;
                                detalheBindingSource.ResetCurrentItem();
                                SalvarRelatorio(detalheBindingSource.Current as Entity.Relatorio);
                            }
                        }
                        FiltrarRelatorios();
                    }
                }
            };

            gridView.ButtonsPanel.Buttons.Add(new EditorButton(ButtonPredefines.Glyph) { Caption = "Parâmetros" });
            gridView.ButtonsPanel.Buttons[3].Click += (s, e) =>
            {
                presenter.CarregarParametroRelatorio((detalheBindingSource.Current as Entity.Relatorio).Nome,
                    (detalheBindingSource.Current as Entity.Relatorio).Parametro, out bool ok, out string xmlparameter);
                if (ok)
                {
                    (detalheBindingSource.Current as Entity.Relatorio).Parametro = xmlparameter;
                    detalheBindingSource.ResetCurrentItem();
                    SalvarRelatorio(detalheBindingSource.Current as Entity.Relatorio);
                }
            };

            gridView.ButtonsPanel.Buttons.Add(new EditorButton(ButtonPredefines.Glyph) { Caption = "Executar" });
            gridView.ButtonsPanel.Buttons[4].Click += (s, e) =>
            {
                if (!string.IsNullOrWhiteSpace((detalheBindingSource.Current as Entity.Relatorio).Parametro))
                    presenter.CarregarRelatorio((int?)(detalheBindingSource.Current as Entity.Relatorio).Id);
                else
                    XtraMessageBox.Show("Não é possível executar um relatório sem parâmetros definidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            };

            base.CreateGridButtons(gridView);

            gridView.Columns[gridView.Columns.Count - 1].MaxWidth = 350;
            gridView.Columns[gridView.Columns.Count - 1].MinWidth = 350;
            gridView.Columns[gridView.Columns.Count - 1].OptionsColumn.AllowEdit = false;
        }

        private void CmdSave_CustomAction(object sender, EventArgs e)
        {
            (detalheBindingSource.Current as Entity.Relatorio).Modelo = (sender as DesignerControl).Report.SaveToString();
            (detalheBindingSource.Current as Entity.Relatorio).Tamanho = (detalheBindingSource.Current as Entity.Relatorio).Modelo.Length;
            (detalheBindingSource.Current as Entity.Relatorio).Modificado = DateTime.Now;
            detalheBindingSource.ResetCurrentItem();
            SalvarRelatorio(detalheBindingSource.Current as Entity.Relatorio, sender as DesignerControl);
        }

        private void CmdSaveAs_CustomAction(object sender, EventArgs e)
        {
            (detalheBindingSource.Current as Entity.Relatorio).Modelo = (sender as DesignerControl).Report.SaveToString();
            (detalheBindingSource.Current as Entity.Relatorio).Tamanho = (detalheBindingSource.Current as Entity.Relatorio).Modelo.Length;
            (detalheBindingSource.Current as Entity.Relatorio).Modificado = DateTime.Now;
            detalheBindingSource.ResetCurrentItem();
            SalvarRelatorio(detalheBindingSource.Current as Entity.Relatorio, sender as DesignerControl, true);
        }

        private void simpleButtonFiltrar_Click(object sender, EventArgs e)
        {
            if (textEditFiltro.Text == "")
                XtraMessageBox.Show("Nenhum filtro foi definido para pesquisa!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                _condicao = Pesquisa.GerarCondicaoFiltro(textEditFiltro, gridViewRelatorio);
                FiltrarRelatorios();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            detalheBindingSource.AddNew();
            (detalheBindingSource.Current as Entity.Relatorio).Origem = "F";
            (detalheBindingSource.Current as Entity.Relatorio).Modificado = DateTime.Now;

            presenter.CarregarManutencao(detalheBindingSource, out bool ok);
            if (ok)
                FiltrarRelatorios();
            else
                detalheBindingSource.RemoveCurrent();
        }

        private void FiltrarRelatorios()
        {
            detalheBindingSource.Clear();
            if (!string.IsNullOrWhiteSpace(_condicao))
            {
                _splash = new SplashScreen("Carregando relatórios...");
                presenter.Filtrar(_condicao);
            }
        }

        private void simpleButtonExportar_Click(object sender, EventArgs e)
        {
            if ((detalheBindingSource.List as IList<Entity.Relatorio>).Where(p => p.Selecionar).Count() != 0)
                this.ExportarRelatorios();
            else
                XtraMessageBox.Show("Nenhum relatório foi selecionado para ser exportado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ExportarRelatorios()
        {
            var xml = "<?xml version=\"1.0\" encoding=\"iso-8859-1\"?>" + Environment.NewLine;
            xml += "<Relatorios>" + Environment.NewLine;
            foreach (var relatorio in (detalheBindingSource.List as IList<Entity.Relatorio>).Where(p => p.Selecionar))
            {
                var bmodelo = Encoding.GetEncoding("ISO-8859-1").GetBytes(relatorio.Modelo);
                var modelo64 = Convert.ToBase64String(bmodelo);
                var parametro64 = "";
                if (relatorio.Parametro != null)
                {
                    var bparametro = Encoding.GetEncoding("ISO-8859-1").GetBytes(relatorio.Parametro);
                    parametro64 = Convert.ToBase64String(bparametro);
                }

                xml += "  <Relatorio>" + Environment.NewLine;
                xml += $"    <Id>{relatorio.Id}</Id>" + Environment.NewLine;
                xml += $"    <Codigo>{relatorio.Codigo}</Codigo>" + Environment.NewLine;
                xml += $"    <Nome>{relatorio.Nome}</Nome>" + Environment.NewLine;
                xml += $"    <Origem>{relatorio.Origem}</Origem>" + Environment.NewLine;
                xml += $"    <Tamanho>{relatorio.Tamanho}</Tamanho>" + Environment.NewLine;
                xml += $"    <Modificado>{relatorio.Modificado.ToString("yyyy-MM-dd'T'hh:mm:ss")}</Modificado>" + Environment.NewLine;
                xml += $"    <Modelo>{modelo64}</Modelo>" + Environment.NewLine;
                xml += $"    <Parametro>{parametro64}</Parametro>" + Environment.NewLine;
                xml += $"    <Matricial>{relatorio.Matricial}</Matricial>" + Environment.NewLine;
                xml += $"    <Visualizar>{relatorio.Visualizar}</Visualizar>" + Environment.NewLine;
                xml += $"    <QuebraPagina>{relatorio.QuebraPagina}</QuebraPagina>" + Environment.NewLine;
                xml += $"    <GraficoTexto>{relatorio.GraficoTexto}</GraficoTexto>" + Environment.NewLine;
                xml += $"    <LinhaBranco>{relatorio.LinhaBranco}</LinhaBranco>" + Environment.NewLine;
                xml += $"    <EscalaX>{relatorio.EscalaX}</EscalaX>" + Environment.NewLine;
                xml += $"    <EscalaY>{relatorio.EscalaY}</EscalaY>" + Environment.NewLine;
                xml += "  </Relatorio>" + Environment.NewLine;
            }
            xml += "</Relatorios>" + Environment.NewLine;

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "xml";
            saveFileDialog.Filter = "Arquivo XML|*.xml";
            saveFileDialog.Title = "Exportar Relatórios";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, xml, Encoding.GetEncoding("ISO-8859-1"));
                XtraMessageBox.Show("Relatórios exportados com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void marcarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var relatorio in (detalheBindingSource.List as IList<Entity.Relatorio>))
                relatorio.Selecionar = true;
            gridViewRelatorio.RefreshData();
        }

        private void desmarcarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var relatorio in (detalheBindingSource.List as IList<Entity.Relatorio>))
                relatorio.Selecionar = false;
            gridViewRelatorio.RefreshData();
        }

        private void simpleButtonImportar_Click(object sender, EventArgs e)
        {
            presenter.CarregarImportaRelatorio();
            detalheBindingSource.Clear();
        }

        public void SalvarSucesso(DesignerControl designer, bool close)
        {
            if (designer != null)
                designer.Modified = false;

            if (close)
                (designer.Parent as Form).DialogResult = DialogResult.OK;

            _splash.FinalizarSplashScreen();
        }

        public void SalvarFalha(string mensagem)
        {
            _splash.FinalizarSplashScreen();
            XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.DialogResult = DialogResult.None;
        }

        public void ExcluirSucesso()
        {
            _splash.FinalizarSplashScreen();
            FiltrarRelatorios();
        }

        public void ExcluirFalha(string mensagem)
        {
            _splash.FinalizarSplashScreen();
            XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void FiltrarSucesso(List<Entity.Relatorio> dados)
        {
            _splash.FinalizarSplashScreen();
            foreach (var registro in dados)
                detalheBindingSource.Add(registro);
            detalheBindingSource.CurrencyManager.Position = 0;
        }

        public void FiltrarFalha(string mensagem)
        {
            _splash.FinalizarSplashScreen();
            detalheBindingSource.CurrencyManager.Position = 0;
            XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void SelecionarPorSistemaSucesso(List<int> dados)
        {
            _splash.FinalizarSplashScreen();
        }

        public void SelecionarPorSistemaFalha()
        {
            _splash.FinalizarSplashScreen();
        }
    }
}
