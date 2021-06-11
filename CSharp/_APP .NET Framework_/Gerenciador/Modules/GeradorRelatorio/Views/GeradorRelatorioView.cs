using VIPER.Modules.GeradorRelatorio.Interfaces;
using Chronus.DXperience;
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
        private List<int> _relatorios;

        public GeradorRelatorioView(int funcao)
        {
            InitializeComponent();

            this.CreateGridButtons(gridViewRelatorio);
        }

        private void SalvarRelatorio(Entity.Relatorio relatorio)
        {
            _splash = new SplashScreen("Gravando relatório...");
            presenter.Salvar(relatorio);
        }

        protected override void CreateGridButtons(GridViewWithButtons gridView)
        {
            gridView.ButtonsPanel.Buttons.Add(new EditorButton(ButtonPredefines.Glyph) { Caption = "Alterar" });
            gridView.ButtonsPanel.Buttons[0].Click += (s, e) =>
            {
                /*Entity.Relatorio registro = (detalheBindingSource.Current as Entity.Relatorio);
                Entity.Relatorio itemBackup = Classe.CloneClass<Entity.Relatorio>(registro);

                FrmGeradorRelatorioManutencao form = new FrmGeradorRelatorioManutencao(detalheBindingSource);
                if (form.ShowDialog() != DialogResult.OK)
                {
                    int i = detalheBindingSource.IndexOf(detalheBindingSource.Current);
                    detalheBindingSource.RemoveCurrent();
                    detalheBindingSource.Insert(i, itemBackup);
                    gridViewRelatorio.RefreshData();
                }
                form.Dispose();*/
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
                using (Report report = new Report())
                {
                    if (!string.IsNullOrWhiteSpace((detalheBindingSource.Current as Entity.Relatorio).Modelo))
                    {
                        var b = Encoding.UTF8.GetBytes((detalheBindingSource.Current as Entity.Relatorio).Modelo);
                        MemoryStream ms = new MemoryStream(b);
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
                            if (XtraMessageBox.Show("Alterações no relatório não foram salvar, deseja salvar?", "Confirmação", MessageBoxButtons.YesNo, 
                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            {
                                this.SalvarRelatorio(detalheBindingSource.Current as Entity.Relatorio);
                            }
                        }
                        FiltrarRelatorios();
                    }
                }
            };

            gridView.ButtonsPanel.Buttons.Add(new EditorButton(ButtonPredefines.Glyph) { Caption = "Parâmetros" });
            gridView.ButtonsPanel.Buttons[3].Click += (s, e) =>
            {
                /*using (FrmParametroRelatorioDX form = new FrmParametroRelatorioDX((detalheBindingSource.Current as Entity.Relatorio).Nome, (detalheBindingSource.Current as Entity.Relatorio).Parametro))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        (detalheBindingSource.Current as Entity.Relatorio).Parametro = form.XmlParameter;
                        detalheBindingSource.ResetCurrentItem();
                        this.SalvarRelatorio(detalheBindingSource.Current as Entity.Relatorio);
                    }
                }*/
            };

            gridView.ButtonsPanel.Buttons.Add(new EditorButton(ButtonPredefines.Glyph) { Caption = "Executar" });
            gridView.ButtonsPanel.Buttons[4].Click += (s, e) =>
            {
                /*if (!string.IsNullOrWhiteSpace((detalheBindingSource.Current as Entity.Relatorio).Parametro))
                {
                    using (FrmParametroRelatorio form = new FrmParametroRelatorio((int?)(detalheBindingSource.Current as Entity.Relatorio).Id))
                    {
                        form.ShowDialog();
                    }
                }
                else
                    XtraMessageBox.Show("Não é possível executar um relatório sem parâmetros definidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);*/
            };

            base.CreateGridButtons(gridView);

            gridView.Columns[gridView.Columns.Count - 1].MaxWidth = 350;
            gridView.Columns[gridView.Columns.Count - 1].MinWidth = 350;
            gridView.Columns[gridView.Columns.Count - 1].OptionsColumn.AllowEdit = false;
        }

        private void CmdSave_CustomAction(object sender, EventArgs e)
        {
            (detalheBindingSource.Current as Entity.Relatorio).Modelo = (sender as DesignerControl).Report.SaveToString();
            (detalheBindingSource.Current as Entity.Relatorio).Modificado = DateTime.Now;
            detalheBindingSource.ResetCurrentItem();
            this.SalvarRelatorio(detalheBindingSource.Current as Entity.Relatorio);
                //(sender as DesignerControl).Modified = false;
        }

        private void CmdSaveAs_CustomAction(object sender, EventArgs e)
        {
            (detalheBindingSource.Current as Entity.Relatorio).Modelo = (sender as DesignerControl).Report.SaveToString();
            (detalheBindingSource.Current as Entity.Relatorio).Modificado = DateTime.Now;
            detalheBindingSource.ResetCurrentItem();
            this.SalvarRelatorio(detalheBindingSource.Current as Entity.Relatorio);
                //(sender as DesignerControl).Modified = false;
                //((sender as DesignerControl).Parent as Form).DialogResult = DialogResult.OK;
        }

        private void simpleButtonFiltrar_Click(object sender, EventArgs e)
        {
            if (textEditFiltro.Text == "")
                XtraMessageBox.Show("Nenhum filtro foi definido para pesquisa!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                _condicao = DXperience.Pesquisa.GerarCondicaoFiltro(textEditFiltro, gridViewRelatorio);
                this.FiltrarRelatorios();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            detalheBindingSource.AddNew();
            (detalheBindingSource.Current as Entity.Relatorio).Origem = "F";
            (detalheBindingSource.Current as Entity.Relatorio).Modificado = DateTime.Now;

            /*using (FrmGeradorRelatorioManutencao form = new FrmGeradorRelatorioManutencao(detalheBindingSource))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (!string.IsNullOrWhiteSpace(_condicao))
                        this.FiltrarRelatorios();
                }
                else
                {
                    detalheBindingSource.RemoveCurrent();
                }
            }*/
        }

        private void FiltrarRelatorios()
        {
            detalheBindingSource.Clear();
            _splash = new SplashScreen("Carregando relatórios...");
            presenter.Filtrar(_condicao);
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
            string xml = "<?xml version=\"1.0\" encoding=\"iso-8859-1\"?>" + Environment.NewLine;
            xml += "<Relatorios>" + Environment.NewLine;
            foreach (var relatorio in (detalheBindingSource.List as IList<Entity.Relatorio>).Where(p => p.Selecionar))
            {
                byte[] bmodelo = Encoding.GetEncoding("ISO-8859-1").GetBytes(relatorio.Modelo);
                string modelo64 = Convert.ToBase64String(bmodelo);
                string parametro64 = "";
                if (relatorio.Parametro != null)
                {
                    byte[] bparametro = Encoding.GetEncoding("ISO-8859-1").GetBytes(relatorio.Parametro);
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

            SaveFileDialog saveFileDialog = new SaveFileDialog();
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
            /*using (FrmImportarRelatorio form = new FrmImportarRelatorio())
            {
                form.ShowDialog();
                detalheBindingSource.Clear();
            }*/
        }

        public void SalvarSucesso()
        {
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
            foreach (Entity.Relatorio registro in dados)
            {
                if (!checkEditRelatorio.Checked)
                    detalheBindingSource.Add(registro);
                else
                {
                    if (_relatorios.Where(p => p == registro.Id).Count() != 0)
                        detalheBindingSource.Add(registro);
                }
            }
            _splash.FinalizarSplashScreen();
            detalheBindingSource.CurrencyManager.Position = 0;
        }

        public void FiltrarFalha()
        {
            _splash.FinalizarSplashScreen();
            detalheBindingSource.CurrencyManager.Position = 0;
        }

        public void SelecionarPorSistemaSucesso(List<int> dados)
        {
            _relatorios = dados;
            _splash.FinalizarSplashScreen();
        }

        public void SelecionarPorSistemaFalha()
        {
            _splash.FinalizarSplashScreen();
        }
    }
}
