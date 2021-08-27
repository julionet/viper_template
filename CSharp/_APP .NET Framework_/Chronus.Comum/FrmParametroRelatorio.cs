using VIPER.DTO;
using VIPER.Service;
using Chronus.DXperience;
using Chronus.Library;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chronus.Comum
{
    public partial class FrmParametroRelatorio : FrmModelo
    {
        private CheckedListBoxControl _componentefoco;
        private int _relatorio = 0;
        private bool _temparametro = false;
        private string _sqlrelatorio = "";
        private RelatorioRetornoDTO _report;
        private List<ComponenteParametro> _componentesformulario = new List<ComponenteParametro>();

        public FrmParametroRelatorio(int? relatorio)
        {
            InitializeComponent();

            this.Width = 900;
            this.Height = 700;
            this.InicializarFormulario(relatorio.Value);
        }

        public FrmParametroRelatorio(int funcao)
        {
            InitializeComponent();
            var _funcao = Servicos.funcaoService.Selecionar(funcao);
            this.InicializarFormulario((int)_funcao.RelatorioId);
        }

        private void InicializarFormulario(int relatorio)
        {
            _report = Servicos.relatorioService.Selecionar(relatorio);
            if (_report != null)
            {
                Text = _report.Nome;
                _relatorio = _report.Id;

                previewControl.UIStyle = FastReport.Utils.UIStyle.VistaGlass;
                xtcRelatorios.SelectedTabPage = _report.Origem == "F" ? xtpFastReport : _report.Origem == "R" ? xtpReportBuilder : xtpXtraReport;

                if (!string.IsNullOrWhiteSpace(_report.Parametro))
                {
                    _temparametro = true;
                    DataSet ds = new DataSet();
                    ds.ReadXml(Conversion.StringToStream(_report.Parametro));

                    panBackground.Size = new System.Drawing.Size(Convert.ToInt32(ds.Tables["Interface"].Rows[0]["Width"]),
                        Convert.ToInt32(ds.Tables["Interface"].Rows[0]["Height"]));

                    DataView dv = ds.Tables["Parametro"].AsDataView();
                    dv.Sort = "TabIndex";
                    foreach (DataRowView dr in dv)
                        CreateComponente(dr);

                    foreach (Control control in panBackground.Controls)
                    {
                        if (control is GroupControl)
                        {
                        }
                        else if (control is CheckEdit)
                        {
                            checkbox_CheckedChanged(control, null);
                        }
                    }

                    ComponenteParametro componente = _componentesformulario.Where(p => p.Name == "FormularioDX").FirstOrDefault();
                    if (componente != null && !string.IsNullOrWhiteSpace(componente.Load))
                        ExecuteDynamicCode(componente.Load);
                }
                else
                {
                    panBackground.Visible = false;
                    panSeparadorBottom.Visible = false;
                }
            }
        }

        private object ExecuteDynamicCode(string code)
        {
            string mensagem = "";
            object o = null;
            DynamicCode dc = new DynamicCode();
            dc.LanguageName = "CSharp";
            dc.MethodName = "Executar";
            dc.InstanceName = "Cartsys.RegraParametro";
            dc.Assemblys.Add("System.dll");
            dc.Assemblys.Add("System.Data.dll");
            dc.Assemblys.Add("System.Windows.Forms.dll");
            dc.Assemblys.Add("System.Runtime.Serialization.dll");
            dc.Assemblys.Add("DevExpress.XtraEditors.v20.2.dll");
            dc.Assemblys.Add("DevExpress.XtraGrid.v20.2.dll");
            dc.Assemblys.Add("DevExpress.Utils.v20.2.dll");
            dc.Assemblys.Add("DevExpress.Data.v20.2.dll");
            dc.Assemblys.Add("System.Linq.dll");
            dc.Assemblys.Add("Cartsys.Comunication.dll");
            dc.Parameters.Add(this.panBackground as Control);
            dc.Code = code;
            if (!dc.Execute(ref o, ref mensagem))
                MessageError.ShowDialog("Falha na execução de código dinâmico!", mensagem);
            return o;
        }

        private Control FirstControlParametro(Control bc)
        {
            Control controle = null;
            foreach (Control ctrl in bc.Controls)
                if (!(ctrl is LabelControl))
                    controle = controle == null ? ctrl : ctrl.TabIndex < controle.TabIndex ? ctrl : controle;
            return controle;
        }
        
        private void FrmParametroRelatorio_Load(object sender, EventArgs e)
        {
            Control c = FirstControlParametro(panBackground);
            if (c != null)
                c.Select();
        }

        private void DateEdit_Leave(object sender, EventArgs e)
        {
            DXperience.Interface.ClearDateEdit(sender as DateEdit);
        }

        private void tetHora_Leave(object sender, EventArgs e)
        {
            if (((TimeEdit)sender).EditValue == null ||
                ((TimeEdit)sender).EditValue.ToString() == "" ||
                !Funcoes.IsTimeSpan(((TimeEdit)sender).EditValue.ToString()) ||
                (((TimeEdit)sender).EditValue.ToString().Length < 5))
                ((TimeEdit)sender).EditValue = null;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            if (btnOk.Text == "&Imprimir")
            {
                foreach(Control ctrl in panBackground.Controls.Cast<Control>().OrderBy(p => p.TabIndex))
                {
                    if (ctrl is BaseEdit)
                    {
                        if (((ctrl as BaseEdit).EditValue == null || (ctrl as BaseEdit).EditValue.ToString() == "") &&
                            (ctrl as BaseEdit).Properties.Tag.ToString().Split('|')[0].Equals("1"))
                        {
                            XtraMessageBox.Show((ctrl as BaseEdit).Properties.Tag.ToString().Split('|')[1], "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else if (ctrl is CheckedListBoxControl)
                    {
                        if (((ctrl as CheckedListBoxControl).CheckedItems.Count == 0) &&
                            (ctrl as CheckedListBoxControl).AccessibleDescription.ToString().Split('|')[0].Equals("1"))
                        {
                            XtraMessageBox.Show((ctrl as CheckedListBoxControl).AccessibleDescription.ToString().Split('|')[1], "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                ComponenteParametro componente = _componentesformulario.Where(p => p.Name == "FormularioDX").FirstOrDefault();
                if (componente != null && !string.IsNullOrWhiteSpace(componente.BeforePrint))
                {
                    object resposta = ExecuteDynamicCode(componente.BeforePrint);
                    if (resposta != null && !Convert.ToBoolean(resposta))
                        return;
                }

                btnOk.Enabled = false;
                string sParametro = "";
                for (int i = 0; i < panBackground.Controls.Count; i++)
                {
                    if (panBackground.Controls[i].GetType().Name == "TextEdit")
                    {
                        if ((panBackground.Controls[i] as DevExpress.XtraEditors.TextEdit).EditValue == null)
                            sParametro += (panBackground.Controls[i] as DevExpress.XtraEditors.TextEdit).Tag + ";null|";
                        else
                        {
                            if ((panBackground.Controls[i] as DevExpress.XtraEditors.TextEdit).Properties.Mask.MaskType == DevExpress.XtraEditors.Mask.MaskType.Numeric)
                                sParametro += (panBackground.Controls[i] as DevExpress.XtraEditors.TextEdit).Tag + ";" +
                                    (panBackground.Controls[i] as DevExpress.XtraEditors.TextEdit).EditValue.ToString() + "|";
                            else
                                sParametro += (panBackground.Controls[i] as DevExpress.XtraEditors.TextEdit).Tag + ";" +
                                    "'" + (panBackground.Controls[i] as DevExpress.XtraEditors.TextEdit).EditValue.ToString() + "'|";
                        }
                    }
                    else if (panBackground.Controls[i].GetType().Name == "DateEdit")
                    {
                        if ((panBackground.Controls[i] as DevExpress.XtraEditors.DateEdit).EditValue == null)
                            sParametro += (panBackground.Controls[i] as DevExpress.XtraEditors.DateEdit).Tag + ";null|";
                        else
                            sParametro += (panBackground.Controls[i] as DevExpress.XtraEditors.DateEdit).Tag + ";" +
                                "'" + (panBackground.Controls[i] as DevExpress.XtraEditors.DateEdit).DateTime.ToString("yyyy-MM-dd") + "'|";
                    }
                    else if (panBackground.Controls[i].GetType().Name == "TimeEdit")
                    {
                        if ((panBackground.Controls[i] as DevExpress.XtraEditors.TimeEdit).EditValue == null)
                            sParametro += (panBackground.Controls[i] as DevExpress.XtraEditors.TimeEdit).Tag + ";null|";
                        else
                            sParametro += (panBackground.Controls[i] as DevExpress.XtraEditors.TimeEdit).Tag + ";" +
                                "'" + (panBackground.Controls[i] as DevExpress.XtraEditors.TimeEdit).Time.ToString("HH:mm") + "'|";
                    }
                    else if (panBackground.Controls[i].GetType().Name == "SpinEdit")
                    {
                        if ((panBackground.Controls[i] as DevExpress.XtraEditors.SpinEdit).EditValue == null)
                            sParametro += (panBackground.Controls[i] as DevExpress.XtraEditors.SpinEdit).Tag + ";null|";
                        else
                            sParametro += (panBackground.Controls[i] as DevExpress.XtraEditors.SpinEdit).Tag + ";" +
                                (panBackground.Controls[i] as DevExpress.XtraEditors.SpinEdit).EditValue.ToString() + "|";
                    }
                    else if (panBackground.Controls[i].GetType().Name == "CheckEdit")
                    {
                        sParametro += (panBackground.Controls[i] as DevExpress.XtraEditors.CheckEdit).Tag + ";" +
                            "'" + (panBackground.Controls[i] as DevExpress.XtraEditors.CheckEdit).EditValue.ToString() + "'|";
                    }
                    else if (panBackground.Controls[i].GetType().Name == "ImageComboBoxEdit")
                    {
                        if ((panBackground.Controls[i] as DevExpress.XtraEditors.ImageComboBoxEdit).EditValue == null)
                            sParametro += (panBackground.Controls[i] as DevExpress.XtraEditors.ImageComboBoxEdit).Tag + ";null|";
                        else
                            sParametro += (panBackground.Controls[i] as DevExpress.XtraEditors.ImageComboBoxEdit).Tag + ";" +
                                "'" + (panBackground.Controls[i] as DevExpress.XtraEditors.ImageComboBoxEdit).EditValue.ToString() + "'|";
                    }
                    else if (panBackground.Controls[i].GetType().Name == "GroupControl")
                    {
                        for (int j = 0; j < panBackground.Controls[i].Controls.Count; j++)
                        {
                            if (panBackground.Controls[i].Controls[j].GetType().Name == "RadioGroup")
                            {
                                if ((panBackground.Controls[i].Controls[j] as DevExpress.XtraEditors.RadioGroup).EditValue == null)
                                    sParametro += (panBackground.Controls[i].Controls[j] as DevExpress.XtraEditors.RadioGroup).Tag + ";null|";
                                else
                                    sParametro += (panBackground.Controls[i].Controls[j] as DevExpress.XtraEditors.RadioGroup).Tag + ";" +
                                        "'" + (panBackground.Controls[i].Controls[j] as DevExpress.XtraEditors.RadioGroup).EditValue.ToString() + "'|";
                            }
                        }
                    }
                    else if (panBackground.Controls[i].GetType().Name == "LookUpEdit")
                    {
                        if ((panBackground.Controls[i] as DevExpress.XtraEditors.LookUpEdit).EditValue == null)
                            sParametro += (panBackground.Controls[i] as DevExpress.XtraEditors.LookUpEdit).Tag + ";null|";
                        else
                            sParametro += (panBackground.Controls[i] as DevExpress.XtraEditors.LookUpEdit).Tag + ";" +
                                "'" + (panBackground.Controls[i] as DevExpress.XtraEditors.LookUpEdit).EditValue.ToString() + "'|";
                    }
                    else if (panBackground.Controls[i].GetType().Name == "SearchLookUpEdit")
                    {
                        if ((panBackground.Controls[i] as DevExpress.XtraEditors.SearchLookUpEdit).EditValue == null)
                            sParametro += (panBackground.Controls[i] as DevExpress.XtraEditors.SearchLookUpEdit).Tag + ";null|";
                        else
                            sParametro += (panBackground.Controls[i] as DevExpress.XtraEditors.SearchLookUpEdit).Tag + ";" +
                                "'" + (panBackground.Controls[i] as DevExpress.XtraEditors.SearchLookUpEdit).EditValue.ToString() + "'|";
                    }
                    else if (panBackground.Controls[i].GetType().Name == "CheckedListBoxControl")
                    {
                        string sItens = "";

                        foreach (var item in (panBackground.Controls[i] as DevExpress.XtraEditors.CheckedListBoxControl).CheckedItems)
                        {
                            if (sItens == "")
                                sItens = "'" + (item is LookupDataSourceDTO ? (item as LookupDataSourceDTO).Value.ToString() : (item as DevExpress.XtraEditors.Controls.ListBoxItem).Value.ToString()) + "'";
                            else
                                sItens += "," + "'" + (item is LookupDataSourceDTO ? (item as LookupDataSourceDTO).Value.ToString() : (item as DevExpress.XtraEditors.Controls.ListBoxItem).Value.ToString()) + "'";
                        }
                        
                        if (sItens == "")
                            sParametro += (panBackground.Controls[i] as DevExpress.XtraEditors.CheckedListBoxControl).Tag + ";''|";
                        else
                            sParametro += (panBackground.Controls[i] as DevExpress.XtraEditors.CheckedListBoxControl).Tag + ";" + sItens + "|";
                    }
                }

                sParametro = !string.IsNullOrWhiteSpace(sParametro) ? sParametro.Substring(0, sParametro.Length - 1) : "";
                sParametro += !string.IsNullOrWhiteSpace(sParametro) ? "|@USUARIO;" + Global.Instance.UsuarioLogado.Id : "";

                if (xtcRelatorios.SelectedTabPage == xtpReportBuilder)
                {
                    string s = ""; // Servicos.relatorioServico.GetReportBuilder(_relatorio, sParametro);
                    if (!string.IsNullOrWhiteSpace(s))
                    {
                        if (!s.Contains("<erro>"))
                            pdfViewer.LoadDocument(new MemoryStream(Convert.FromBase64String(s)));
                        else
                            DevExpress.XtraEditors.XtraMessageBox.Show(s, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        DevExpress.XtraEditors.XtraMessageBox.Show("Falha ao tentar gerar relatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (xtcRelatorios.SelectedTabPage == xtpFastReport)
                {
                    FastReportDTO fastreport = Servicos.relatorioService.GetFastReport(new RelatorioDTO() { RelatorioId = _relatorio, Parametros = sParametro });
                    if (fastreport != null)
                    {
                        string s = fastreport.Relatorio;
                        _sqlrelatorio = fastreport.Sql;
                        if (!string.IsNullOrWhiteSpace(s) && !s.Contains("#ERRO#"))
                        {
                            MemoryStream ms = new MemoryStream(Convert.FromBase64String(s));
                            FastReport.Report report = new FastReport.Report();
                            report.LoadPrepared(ms);

                            if (_report.Matricial)
                            {
                                if (_report.Visualizar)
                                {
                                    FastReport.Export.Text.TextExport export = new FastReport.Export.Text.TextExport();
                                    export.PageBreaks = _report.QuebraPagina;
                                    export.TextFrames = _report.GraficoTexto;
                                    export.EmptyLines = _report.LinhaBranco;
                                    export.ScaleX = (float)_report.EscalaX;
                                    export.ScaleY = (float)_report.EscalaY;
                                    export.SetReport(report);
                                    export.ShowDialog();
                                }
                                else
                                    FastReport.Export.Text.TextExportPrint.PrintStream("", "", 1, ms);

                                btnOk.Enabled = true;
                            }
                            else
                            {
                                report.Preview = previewControl;
                                report.ShowPrepared();

                                panBackground.Visible = false;
                                panSeparadorBottom.Visible = false;
                                xtcRelatorios.Visible = true;

                                if (_temparametro) btnOk.Text = "F&iltros";
                                btnOk.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageError.ShowDialog("Falha ao tentar gerar relatório!", (_sqlrelatorio.Contains("#ERRO#") ? _sqlrelatorio.Replace("#ERRO#", "").Split('#')[0] + "\r\n" : "") + string.Format("\r\nRélatório: {0} \r\nParâmetros: {1} \r\n\r\nConsultas do Relatório: \r\n{2}", _relatorio, sParametro, _sqlrelatorio.Replace("#ERRO#", "").Split('#')[1]));
                            btnOk.Enabled = true;
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Falha ao tentar gerar relatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnOk.Enabled = true;
                    }
                }
                else if (xtcRelatorios.SelectedTabPage == xtpXtraReport)
                {
                    /*XtraReportDTO xtrareport = Servicos.relatorioServico.GetXtraReport(new RelatorioDTO() { RelatorioId = _relatorio, Parametros = sParametro });
                    if (xtrareport != null)
                    {
                        string s = xtrareport.Relatorio;
                        _sqlrelatorio = xtrareport.Sql;
                        if (!string.IsNullOrWhiteSpace(s) && !s.Contains("#ERRO#"))
                        {
                            ucXtraReport report = new ucXtraReport(s);
                            xucXtraReport.Controls.Add(report);

                            if (_report.Matricial)
                            {
                                btnOk.Enabled = true;
                            }
                            else
                            {
                                panBackground.Visible = false;
                                panSeparadorBottom.Visible = false;
                                xtcRelatorios.Visible = true;

                                if (_temparametro) btnOk.Text = "F&iltros";
                                btnOk.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageError.ShowDialog("Falha ao tentar gerar relatório!", (_sqlrelatorio.Contains("#ERRO#") ? _sqlrelatorio.Replace("#ERRO#", "").Split('#')[0] + "\r\n" : "") + string.Format("\r\nRélatório: {0} \r\nParâmetros: {1} \r\n\r\nConsultas do Relatório: \r\n{2}", _relatorio, sParametro, _sqlrelatorio.Replace("#ERRO#", "").Split('#')[1]));
                            btnOk.Enabled = true;
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Falha ao tentar gerar relatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnOk.Enabled = true;
                    }*/
                }

                if (componente != null && !string.IsNullOrWhiteSpace(componente.AfterPrint))
                    ExecuteDynamicCode(componente.AfterPrint);
            }
            else if (btnOk.Text == "F&iltros")
            {
                panBackground.Visible = true;
                panSeparadorBottom.Visible = true;
                btnOk.Text = "&Imprimir";
            }
        }

        private void CreateComponente(DataRowView dr)
        {
            ((System.ComponentModel.ISupportInitialize)(panBackground)).BeginInit();
            panBackground.SuspendLayout();
            if (dr["Type"].ToString() == "TShapeDX")
            {
                DevExpress.XtraEditors.PanelControl panel = new DevExpress.XtraEditors.PanelControl();
                panel.Appearance.BackColor = System.Drawing.Color.White;
                panel.Appearance.BorderColor = System.Drawing.Color.Black;
                panel.Appearance.Options.UseBackColor = true;
                panel.Appearance.Options.UseBorderColor = true;
                panel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                panel.Location = new Point(Convert.ToInt32(dr["Left"]), Convert.ToInt32(dr["Top"]));
                panel.LookAndFeel.UseDefaultLookAndFeel = false;
                panel.LookAndFeel.UseWindowsXPTheme = true;
                panel.Name = dr["Name"].ToString();
                panel.Size = new System.Drawing.Size(Convert.ToInt32(dr["Width"]), Convert.ToInt32(dr["Height"]));
                panel.TabStop = false;
                panel.TabIndex = 0;
                panBackground.Controls.Add(panel);
                panel.SendToBack();
            }
            else if (dr["Type"].ToString() == "TFormularioDX")
            {
                _componentesformulario.Add(new ComponenteParametro() { Name = "FormularioDX", Load = dr["Load"].ToString(), Close = dr["Close"].ToString(), BeforePrint = dr["BeforePrint"].ToString(), AfterPrint = dr["AfterPrint"].ToString() });
            }
            else if (dr["Type"].ToString() == "TLabelDX")
            {
                DevExpress.XtraEditors.LabelControl label = new DevExpress.XtraEditors.LabelControl();
                label.Location = new Point(Convert.ToInt32(dr["Left"]), Convert.ToInt32(dr["Top"]));
                label.Name = dr["Name"].ToString();
                label.Size = new System.Drawing.Size(Convert.ToInt32(dr["Width"]), Convert.ToInt32(dr["Height"]));
                label.Text = dr["Caption"].ToString();
                label.Visible = dr["Caption"].ToString() != "[UNIDADE]";
                panBackground.Controls.Add(label);
                label.BringToFront();
            }
            else if (dr["Type"].ToString() == "TGroupBoxDX")
            {
                DevExpress.XtraEditors.GroupControl group = new DevExpress.XtraEditors.GroupControl();
                group.Location = new Point(Convert.ToInt32(dr["Left"]), Convert.ToInt32(dr["Top"]));
                group.Name = dr["Name"].ToString();
                group.Size = new System.Drawing.Size(Convert.ToInt32(dr["Width"]), Convert.ToInt32(dr["Height"]));
                group.TabIndex = Convert.ToInt32(dr["TabIndex"]);
                group.Text = dr["Caption"].ToString();
                panBackground.Controls.Add(group);
                group.SendToBack();
            }
            else if (dr["Type"].ToString() == "TTextEditDX")
            {
                DevExpress.XtraEditors.TextEdit text = new DevExpress.XtraEditors.TextEdit();
                text.Location = new Point(Convert.ToInt32(dr["Left"]), Convert.ToInt32(dr["Top"]));
                text.Name = dr["Name"].ToString();
                text.Properties.Appearance.Options.UseTextOptions = true;
                switch (Convert.ToInt32(dr["Alignment"]))
                {
                    case 0:
                        text.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
                        break;
                    case 1:
                        text.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                        break;
                    case 2:
                        text.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        break;
                }
                text.Size = new System.Drawing.Size(Convert.ToInt32(dr["Width"]), Convert.ToInt32(dr["Height"]));
                text.TabIndex = Convert.ToInt32(dr["TabIndex"]);
                if (dr["Hint"].ToString() != "")
                {
                    text.ToolTip = dr["Hint"].ToString();
                    text.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
                    text.ToolTipTitle = "Informação!";
                }
                if (dr["Mask"].ToString() != "")
                {
                    text.Properties.Mask.EditMask = dr["Mask"].ToString().Substring(dr["Mask"].ToString().IndexOf(':') + 1);
                    text.Properties.Mask.MaskType = ConversionDX.StringToMaskType(dr["Mask"].ToString().Substring(0, dr["Mask"].ToString().IndexOf(':')));
                    text.Properties.Mask.UseMaskAsDisplayFormat = true;
                }
                if (dr["NullText"].ToString() != "")
                {
                    text.Properties.NullValuePromptShowForEmptyValue = true;
                    text.Properties.NullValuePrompt = dr["NullText"].ToString();
                }
                text.Tag = dr["Parameter"].ToString();
                text.EditValue = dr["DefaultValue"].ToString();
                text.Properties.Tag = dr["Required"].ToString() + "|" + dr["RequiredMessage"].ToString();
                text.Leave += new EventHandler(this.componente_Leave);
                text.Enter += new EventHandler(this.componente_Enter);
                text.EditValueChanged += new EventHandler(this.componente_Change);
                panBackground.Controls.Add(text);
                _componentesformulario.Add(new ComponenteParametro() { Name = text.Name, Leave = dr["Leave"].ToString(), Enter = dr["Enter"].ToString(), Change = dr["Change"].ToString() });
                text.BringToFront();
            }
            else if (dr["Type"].ToString() == "TDateEditDX")
            {
                DevExpress.XtraEditors.DateEdit date = new DevExpress.XtraEditors.DateEdit();
                date.EditValue = null;
                date.Location = new Point(Convert.ToInt32(dr["Left"]), Convert.ToInt32(dr["Top"]));
                date.Name = dr["Name"].ToString();
                date.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.Default;
                date.Properties.Mask.EditMask = "99/99/9999";
                date.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
                date.Properties.Mask.UseMaskAsDisplayFormat = true;
                date.Properties.ShowToday = false;
                date.Properties.ShowClear = true;
                date.Size = new System.Drawing.Size(Convert.ToInt32(dr["Width"]), Convert.ToInt32(dr["Height"]));
                date.TabIndex = Convert.ToInt32(dr["TabIndex"]);
                if (dr["Hint"].ToString() != "")
                {
                    date.ToolTip = dr["Hint"].ToString();
                    date.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
                    date.ToolTipTitle = "Informação!";
                }
                date.Tag = dr["Parameter"].ToString();
                date.EditValue = dr["DefaultValue"].ToString().ToUpper() == "[DATA_ATUAL]" ? DateTime.Today : (DateTime?)null;
                date.Properties.Tag = dr["Required"].ToString() + "|" + dr["RequiredMessage"].ToString();
                date.Leave += new EventHandler(this.DateEdit_Leave);
                date.Leave += new EventHandler(this.componente_Leave);
                date.Enter += new EventHandler(this.componente_Enter);
                date.EditValueChanged += new EventHandler(this.componente_Change);
                panBackground.Controls.Add(date);
                _componentesformulario.Add(new ComponenteParametro() { Name = date.Name, Leave = dr["Leave"].ToString(), Enter = dr["Enter"].ToString(), Change = dr["Change"].ToString() });
                date.BringToFront();
            }
            else if (dr["Type"].ToString() == "TTimeEditDX")
            {
                DevExpress.XtraEditors.TimeEdit time = new DevExpress.XtraEditors.TimeEdit();
                time.EditValue = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
                time.Location = new Point(Convert.ToInt32(dr["Left"]), Convert.ToInt32(dr["Top"]));
                time.Name = dr["Name"].ToString();
                time.Size = new System.Drawing.Size(Convert.ToInt32(dr["Width"]), Convert.ToInt32(dr["Height"]));
                time.TabIndex = Convert.ToInt32(dr["TabIndex"]);
                if (dr["Hint"].ToString() != "")
                {
                    time.ToolTip = dr["Hint"].ToString();
                    time.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
                    time.ToolTipTitle = "Informação!";
                }
                time.Tag = dr["Parameter"].ToString();
                time.EditValue = dr["DefaultValue"].ToString().ToUpper() == "[HORA_ATUAL]" ? DateTime.Now.TimeOfDay :
                    dr["DefaultValue"].ToString().ToUpper() == "[HORA_0000]" ? (TimeSpan?)new System.TimeSpan(0, 0, 0) :
                    dr["DefaultValue"].ToString().ToUpper() == "[HORA_2359]" ? (TimeSpan?)new System.TimeSpan(23, 59, 59) : null;
                time.Properties.Buttons.Clear();
                time.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                time.Properties.Mask.EditMask = @"(0\d|1\d|2[0-3])\:[0-5]\d";
                time.CausesValidation = false;
                time.Properties.Mask.UseMaskAsDisplayFormat = true;
                time.Properties.Mask.IgnoreMaskBlank = true;
                time.Properties.Tag = dr["Required"].ToString() + "|" + dr["RequiredMessage"].ToString();
                time.Leave += new EventHandler(this.componente_Leave);
                time.Leave += tetHora_Leave;
                time.Enter += new EventHandler(this.componente_Enter);
                time.EditValueChanged += new EventHandler(this.componente_Change);
                panBackground.Controls.Add(time);
                _componentesformulario.Add(new ComponenteParametro() { Name = time.Name, Leave = dr["Leave"].ToString(), Enter = dr["Enter"].ToString(), Change = dr["Change"].ToString() });
                time.BringToFront();
            }
            else if (dr["Type"].ToString() == "TSpinEditDX")
            {
                DevExpress.XtraEditors.SpinEdit spin = new DevExpress.XtraEditors.SpinEdit();
                spin.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
                spin.Location = new Point(Convert.ToInt32(dr["Left"]), Convert.ToInt32(dr["Top"]));
                spin.Name = dr["Name"].ToString();
                spin.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
                spin.Properties.IsFloatValue = false;
                spin.Properties.Mask.EditMask = "n0";
                spin.Properties.Mask.UseMaskAsDisplayFormat = true;
                spin.Size = new System.Drawing.Size(Convert.ToInt32(dr["Width"]), Convert.ToInt32(dr["Height"]));
                spin.TabIndex = Convert.ToInt32(dr["TabIndex"]);
                if (dr["Hint"].ToString() != "")
                {
                    spin.ToolTip = dr["Hint"].ToString();
                    spin.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
                    spin.ToolTipTitle = "Informação!";
                }
                spin.Properties.Appearance.Options.UseTextOptions = true;
                spin.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
                spin.Tag = dr["Parameter"].ToString();
                spin.Properties.MinValue = Convert.ToInt32(dr["MinValue"]);
                spin.Properties.MaxValue = Convert.ToInt32(dr["MaxValue"]);
                spin.EditValue = dr["DefaultValue"].ToString().ToUpper() == "[ANO]" ? DateTime.Today.Year : dr["DefaultValue"].ToString() != "" ? Convert.ToInt32(dr["DefaultValue"].ToString()) : (int?)null;
                spin.Properties.Tag = dr["Required"].ToString() + "|" + dr["RequiredMessage"].ToString();
                spin.Leave += new EventHandler(this.componente_Leave);
                spin.Enter += new EventHandler(this.componente_Enter);
                spin.EditValueChanged += new EventHandler(this.componente_Change);
                panBackground.Controls.Add(spin);
                _componentesformulario.Add(new ComponenteParametro() { Name = spin.Name, Leave = dr["Leave"].ToString(), Enter = dr["Enter"].ToString(), Change = dr["Change"].ToString() });
                spin.BringToFront();
            }
            else if (dr["Type"].ToString() == "TCheckBoxDX")
            {
                DevExpress.XtraEditors.CheckEdit check = new DevExpress.XtraEditors.CheckEdit();
                check.Location = new Point(Convert.ToInt32(dr["Left"]), Convert.ToInt32(dr["Top"]));
                check.Name = dr["Name"].ToString();
                check.Properties.Caption = dr["Caption"].ToString();
                check.Size = new System.Drawing.Size(Convert.ToInt32(dr["Width"]), Convert.ToInt32(dr["Height"]));
                check.Checked = dr["DefaultValue"].ToString().ToUpper() == "[TRUE]" ? true : dr["DefaultValue"].ToString().ToUpper() == "[FALSE]" ? false : false;
                check.TabIndex = Convert.ToInt32(dr["TabIndex"]);
                if (dr["Hint"].ToString() != "")
                {
                    check.ToolTip = dr["Hint"].ToString();
                    check.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
                    check.ToolTipTitle = "Informação!";
                }
                check.Tag = dr["Parameter"].ToString();
                check.Properties.Tag = dr["Components"].ToString();
                check.CheckedChanged += checkbox_CheckedChanged;
                check.Leave += new EventHandler(this.componente_Leave);
                check.Enter += new EventHandler(this.componente_Enter);
                check.EditValueChanged += new EventHandler(this.componente_Change);
                panBackground.Controls.Add(check);
                _componentesformulario.Add(new ComponenteParametro() { Name = check.Name, Leave = dr["Leave"].ToString(), Enter = dr["Enter"].ToString(), Change = dr["Change"].ToString() });
                check.BringToFront();
            }
            else if (dr["Type"].ToString() == "TRadioButtonDX")
            {
                DevExpress.XtraEditors.CheckEdit radiobutton = new DevExpress.XtraEditors.CheckEdit();
                radiobutton.Location = new Point(Convert.ToInt32(dr["Left"]), Convert.ToInt32(dr["Top"]));
                radiobutton.Name = dr["Name"].ToString();
                radiobutton.Properties.Caption = dr["Caption"].ToString();
                radiobutton.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
                radiobutton.Properties.ValueChecked = dr["ValueChecked"].ToString();
                radiobutton.Properties.ValueUnchecked = dr["ValueUnchecked"].ToString();
                radiobutton.Size = new System.Drawing.Size(Convert.ToInt32(dr["Width"]), Convert.ToInt32(dr["Height"]));
                radiobutton.Checked = dr["DefaultValue"].ToString().ToUpper() == "[TRUE]" ? true : dr["DefaultValue"].ToString().ToUpper() == "[FALSE]" ? false : false;
                radiobutton.Properties.RadioGroupIndex = Convert.ToInt32(dr["GroupIndex"]);
                radiobutton.TabIndex = Convert.ToInt32(dr["TabIndex"]);
                if (dr["Hint"].ToString() != "")
                {
                    radiobutton.ToolTip = dr["Hint"].ToString();
                    radiobutton.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
                    radiobutton.ToolTipTitle = "Informação!";
                }
                radiobutton.Tag = dr["Parameter"].ToString();
                radiobutton.Leave += new EventHandler(this.componente_Leave);
                radiobutton.Enter += new EventHandler(this.componente_Enter);
                radiobutton.EditValueChanged += new EventHandler(this.componente_Change);
                panBackground.Controls.Add(radiobutton);
                _componentesformulario.Add(new ComponenteParametro() { Name = radiobutton.Name, Leave = dr["Leave"].ToString(), Enter = dr["Enter"].ToString(), Change = dr["Change"].ToString() });
                radiobutton.BringToFront();
            }
            else if (dr["Type"].ToString() == "TComboBoxDX")
            {
                DevExpress.XtraEditors.ImageComboBoxEdit combobox = new DevExpress.XtraEditors.ImageComboBoxEdit();
                combobox.Location = new Point(Convert.ToInt32(dr["Left"]), Convert.ToInt32(dr["Top"]));
                combobox.Name = dr["Name"].ToString();
                combobox.Size = new System.Drawing.Size(Convert.ToInt32(dr["Width"]), Convert.ToInt32(dr["Height"]));
                combobox.TabIndex = Convert.ToInt32(dr["TabIndex"]);
                if (dr["NullText"].ToString() != "")
                {
                    combobox.Properties.NullValuePromptShowForEmptyValue = true;
                    combobox.Properties.NullValuePrompt = dr["NullText"].ToString();
                }
                if (dr["Hint"].ToString() != "")
                {
                    combobox.ToolTip = dr["Hint"].ToString();
                    combobox.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
                    combobox.ToolTipTitle = "Informação!";
                }
                if ((dr["Descriptions"].ToString() != "") && (dr["Values"].ToString() != ""))
                {
                    char[] c = { (char)13, (char)10 };
                    string[] descriptions = dr["Descriptions"].ToString().Split(c);
                    string[] values = dr["Values"].ToString().Split(c);
                    for (int i = 0; i < descriptions.Length; i++)
                        if ((descriptions[i] != "") && (values[i] != ""))
                            combobox.Properties.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(descriptions[i], values[i]));
                }
                combobox.Tag = dr["Parameter"].ToString();
                combobox.EditValue = dr["DefaultValue"].ToString().ToUpper() == "[MES]" ? DateTime.Today.Month.ToString("00") : dr["DefaultValue"].ToString() != "" ? dr["DefaultValue"].ToString() : null;
                combobox.Properties.Tag = dr["Required"].ToString() + "|" + dr["RequiredMessage"].ToString();
                combobox.Leave += new EventHandler(this.componente_Leave);
                combobox.Enter += new EventHandler(this.componente_Enter);
                combobox.EditValueChanged += new EventHandler(this.componente_Change);
                panBackground.Controls.Add(combobox);
                _componentesformulario.Add(new ComponenteParametro() { Name = combobox.Name, Leave = dr["Leave"].ToString(), Enter = dr["Enter"].ToString(), Change = dr["Change"].ToString() });
                combobox.BringToFront();
            }
            else if (dr["Type"].ToString() == "TCheckListBoxDX")
            {
                DevExpress.XtraEditors.CheckedListBoxControl checkedlistbox = new DevExpress.XtraEditors.CheckedListBoxControl();
                checkedlistbox.CheckOnClick = true;
                checkedlistbox.IncrementalSearch = true;
                checkedlistbox.Location = new Point(Convert.ToInt32(dr["Left"]), Convert.ToInt32(dr["Top"]));
                checkedlistbox.Name = dr["Name"].ToString();
                checkedlistbox.Size = new System.Drawing.Size(Convert.ToInt32(dr["Width"]), Convert.ToInt32(dr["Height"]));
                checkedlistbox.TabIndex = Convert.ToInt32(dr["TabIndex"]);
                if (dr["Hint"].ToString() != "")
                {
                    checkedlistbox.ToolTip = dr["Hint"].ToString();
                    checkedlistbox.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
                    checkedlistbox.ToolTipTitle = "Informação!";
                }
                if ((dr["Descriptions"].ToString() != "") && (dr["Values"].ToString() != ""))
                {
                    char[] c = { (char)13, (char)10 };
                    string[] descriptions = dr["Descriptions"].ToString().Split(c);
                    string[] values = dr["Values"].ToString().Split(c);
                    for (int i = 0; i < descriptions.Length; i++)
                        if ((descriptions[i] != "") && (values[i] != ""))
                            checkedlistbox.Items.Add(values[i], descriptions[i], dr["CheckAll"].ToString() == "1" ? CheckState.Checked : CheckState.Unchecked, true);
                }
                checkedlistbox.Tag = dr["Parameter"].ToString();
                checkedlistbox.AccessibleDescription = dr["Required"].ToString() + "|" + dr["RequiredMessage"].ToString();
                checkedlistbox.MouseDown += componente_MouseDown;
                checkedlistbox.Leave += new EventHandler(this.componente_Leave);
                checkedlistbox.Enter += new EventHandler(this.componente_Enter);
                //checkedlistbox.EditValueChanged += new EventHandler(this.componente_Change);
                panBackground.Controls.Add(checkedlistbox);
                _componentesformulario.Add(new ComponenteParametro() { Name = checkedlistbox.Name, Leave = dr["Leave"].ToString(), Enter = dr["Enter"].ToString(), Change = dr["Change"].ToString() });
                checkedlistbox.BringToFront();
                this.barManager.SetPopupContextMenu(checkedlistbox, this.popupMenu);
            }
            else if (dr["Type"].ToString() == "TRadioGroupDX")
            {
                DevExpress.XtraEditors.GroupControl groupcontrol = new DevExpress.XtraEditors.GroupControl();
                groupcontrol.Location = new Point(Convert.ToInt32(dr["Left"]), Convert.ToInt32(dr["Top"]));
                groupcontrol.Name = "gc" + dr["Name"].ToString();
                groupcontrol.Text = dr["Caption"].ToString();
                groupcontrol.Size = new System.Drawing.Size(Convert.ToInt32(dr["Width"]), Convert.ToInt32(dr["Height"]));
                groupcontrol.TabIndex = Convert.ToInt32(dr["TabIndex"]);

                DevExpress.XtraEditors.RadioGroup radiogroup = new DevExpress.XtraEditors.RadioGroup();
                radiogroup.Name = dr["Name"].ToString();
                radiogroup.Properties.Columns = Convert.ToInt32(dr["Columns"]);
                if (dr["Hint"].ToString() != "")
                {
                    radiogroup.ToolTip = dr["Hint"].ToString();
                    radiogroup.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
                    radiogroup.ToolTipTitle = "Informação!";
                }
                if ((dr["Descriptions"].ToString() != "") && (dr["Values"].ToString() != ""))
                {
                    char[] c = { (char)13, (char)10 };
                    string[] descriptions = dr["Descriptions"].ToString().Split(c);
                    string[] values = dr["Values"].ToString().Split(c);
                    for (int i = 0; i < descriptions.Length; i++)
                        if ((descriptions[i] != "") && (values[i] != ""))
                            radiogroup.Properties.Items.Add(new DevExpress.XtraEditors.Controls.RadioGroupItem(values[i], descriptions[i], true));
                }
                radiogroup.EditValue = dr["DefaultValue"].ToString() != "" ? dr["DefaultValue"].ToString() : null;
                //radiogroup.SelectedIndex = 0;
                radiogroup.Tag = dr["Parameter"].ToString();
                //radiogroup.Properties.AccessibleDescription = dr["Components"].ToString();
                //radiogroup.EditValueChanged += radiogroup_EditValueChanged;
                radiogroup.Dock = DockStyle.Fill;
                radiogroup.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                radiogroup.Leave += new EventHandler(this.componente_Leave);
                radiogroup.Enter += new EventHandler(this.componente_Enter);
                radiogroup.EditValueChanged += new EventHandler(this.componente_Change);
                groupcontrol.Controls.Add(radiogroup);
                panBackground.Controls.Add(groupcontrol);
                _componentesformulario.Add(new ComponenteParametro() { Name = radiogroup.Name, Leave = dr["Leave"].ToString(), Enter = dr["Enter"].ToString(), Change = dr["Change"].ToString() });
                groupcontrol.BringToFront();
            }
            else if (dr["Type"].ToString() == "TDBComboBoxDX")
            {
                DevExpress.XtraGrid.Columns.GridColumn gridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
                gridColumn.Caption = "Descrição";
                gridColumn.FieldName = "Display";
                gridColumn.Name = "gridColumn";
                gridColumn.Visible = true;
                gridColumn.VisibleIndex = 0;

                DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
                searchLookUpEditView.Columns.Clear();
                searchLookUpEditView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn });
                searchLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
                searchLookUpEditView.Name = "searchLookUpEditView";
                searchLookUpEditView.OptionsBehavior.Editable = false;
                searchLookUpEditView.OptionsCustomization.AllowColumnMoving = false;
                searchLookUpEditView.OptionsCustomization.AllowColumnResizing = false;
                searchLookUpEditView.OptionsCustomization.AllowFilter = false;
                searchLookUpEditView.OptionsMenu.EnableColumnMenu = false;
                searchLookUpEditView.OptionsMenu.EnableFooterMenu = false;
                searchLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
                searchLookUpEditView.OptionsView.ShowGroupPanel = false;
                searchLookUpEditView.OptionsView.ShowIndicator = false;
                searchLookUpEditView.OptionsView.ShowColumnHeaders = false;

                SearchLookUpEdit comboboxdb = new SearchLookUpEdit();
                comboboxdb.Location = new Point(Convert.ToInt32(dr["Left"]), Convert.ToInt32(dr["Top"]));
                comboboxdb.Name = dr["Name"].ToString();
                comboboxdb.Size = new System.Drawing.Size(Convert.ToInt32(dr["Width"]), Convert.ToInt32(dr["Height"]));
                comboboxdb.TabIndex = Convert.ToInt32(dr["TabIndex"]);
                if (dr["NullText"].ToString() != "")
                {
                    comboboxdb.Properties.NullValuePromptShowForEmptyValue = true;
                    comboboxdb.Properties.NullValuePrompt = dr["NullText"].ToString();
                }
                if (dr["Hint"].ToString() != "")
                {
                    comboboxdb.ToolTip = dr["Hint"].ToString();
                    comboboxdb.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
                    comboboxdb.ToolTipTitle = "Informação!";
                }
                comboboxdb.Tag = dr["Parameter"].ToString();
                if ((dr["SQL"].ToString() != "") && !dr["SQL"].ToString().Contains("@"))
                    comboboxdb.Properties.DataSource = Servicos.databaseService.ExecutarSQL(dr["SQL"].ToString());
                comboboxdb.Properties.ValueMember = dr["KeyField"].ToString();
                comboboxdb.Properties.DisplayMember = dr["ShowField"].ToString();
                comboboxdb.Properties.Tag = dr["Required"].ToString() + "|" + dr["RequiredMessage"].ToString();
                comboboxdb.Properties.NullText = "";
                comboboxdb.Properties.PopupSizeable = false;
                comboboxdb.Properties.View = searchLookUpEditView;
                comboboxdb.Properties.Buttons.Clear();
                comboboxdb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
                    new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
                comboboxdb.Leave += new EventHandler(this.componente_Leave);
                comboboxdb.Enter += new EventHandler(this.componente_Enter);
                comboboxdb.EditValueChanged += new EventHandler(this.componente_Change);
                comboboxdb.EditValue = dr["DefaultValue"].ToString().ToUpper() == "[USUARIO_LOGADO]" ? Global.Instance.UsuarioLogado.Login : null;
                panBackground.Controls.Add(comboboxdb);
                _componentesformulario.Add(new ComponenteParametro() { Name = comboboxdb.Name, Leave = dr["Leave"].ToString(), Enter = dr["Enter"].ToString(), Change = dr["Change"].ToString() });
                comboboxdb.BringToFront();
            }
            else if (dr["Type"].ToString() == "TDBCheckListBoxDX")
            {
                DevExpress.XtraEditors.CheckedListBoxControl checkedlistboxdb = new DevExpress.XtraEditors.CheckedListBoxControl();
                checkedlistboxdb.CheckOnClick = true;
                checkedlistboxdb.IncrementalSearch = true;
                checkedlistboxdb.Location = new Point(Convert.ToInt32(dr["Left"]), Convert.ToInt32(dr["Top"]));
                checkedlistboxdb.Name = dr["Name"].ToString();
                checkedlistboxdb.Size = new System.Drawing.Size(Convert.ToInt32(dr["Width"]), Convert.ToInt32(dr["Height"]));
                checkedlistboxdb.TabIndex = Convert.ToInt32(dr["TabIndex"]);
                if (dr["Hint"].ToString() != "")
                {
                    checkedlistboxdb.ToolTip = dr["Hint"].ToString();
                    checkedlistboxdb.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
                    checkedlistboxdb.ToolTipTitle = "Informação!";
                }
                if (dr["SQL"].ToString() != "")
                    foreach (LookupDataSourceDTO item in Servicos.databaseService.ExecutarSQL(dr["SQL"].ToString()))
                        checkedlistboxdb.Items.Add(item.Value, item.Display);
                if (dr["CheckAll"].ToString() == "1") 
                    checkedlistboxdb.CheckAll();
                checkedlistboxdb.Tag = dr["Parameter"].ToString();
                checkedlistboxdb.AccessibleDescription = dr["Required"].ToString() + "|" + dr["RequiredMessage"].ToString();
                checkedlistboxdb.MouseDown += componente_MouseDown;
                checkedlistboxdb.Leave += new EventHandler(this.componente_Leave);
                checkedlistboxdb.Enter += new EventHandler(this.componente_Enter);
                //checkedlistboxdb.EditValueChanged += new EventHandler(this.componente_Change);
                panBackground.Controls.Add(checkedlistboxdb);
                _componentesformulario.Add(new ComponenteParametro() { Name = checkedlistboxdb.Name, Leave = dr["Leave"].ToString(), Enter = dr["Enter"].ToString(), Change = dr["Change"].ToString() });
                checkedlistboxdb.BringToFront();
                this.barManager.SetPopupContextMenu(checkedlistboxdb, this.popupMenu);
            }
            else if (dr["Type"].ToString() == "TDBRadioGroupDX")
            {
                DevExpress.XtraEditors.RadioGroup radiogroupdb = new DevExpress.XtraEditors.RadioGroup();
                radiogroupdb.Location = new Point(Convert.ToInt32(dr["Left"]), Convert.ToInt32(dr["Top"]));
                radiogroupdb.Name = dr["Name"].ToString();
                radiogroupdb.Text = dr["Caption"].ToString();
                radiogroupdb.Size = new System.Drawing.Size(Convert.ToInt32(dr["Width"]), Convert.ToInt32(dr["Height"]));
                radiogroupdb.TabIndex = Convert.ToInt32(dr["TabIndex"]);
                if (dr["Hint"].ToString() != "")
                {
                    radiogroupdb.ToolTip = dr["Hint"].ToString();
                    radiogroupdb.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
                    radiogroupdb.ToolTipTitle = "Informação!";
                }
                if ((dr["KeyField"].ToString() != "") && (dr["ShowField"].ToString() != "") && (dr["SQL"].ToString() != ""))
                {
                    foreach (var ds in Servicos.databaseService.ExecutarSQL(dr["SQL"].ToString()))
                        radiogroupdb.Properties.Items.Add(new DevExpress.XtraEditors.Controls.RadioGroupItem(ds.Value, ds.Display, true));
                }
                radiogroupdb.Tag = dr["Parameter"].ToString();
                radiogroupdb.Leave += new EventHandler(this.componente_Leave);
                radiogroupdb.Enter += new EventHandler(this.componente_Enter);
                radiogroupdb.EditValueChanged += new EventHandler(this.componente_Change);
                panBackground.Controls.Add(radiogroupdb);
                _componentesformulario.Add(new ComponenteParametro() { Name = radiogroupdb.Name, Leave = dr["Leave"].ToString(), Enter = dr["Enter"].ToString(), Change = dr["Change"].ToString() });
                radiogroupdb.BringToFront();
            }
            ((System.ComponentModel.ISupportInitialize)(panBackground)).EndInit();
            panBackground.ResumeLayout(false);
        }

        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as DevExpress.XtraEditors.CheckEdit).Properties.Tag != null)
                foreach (var edit in panBackground.Controls)
                {
                    if (edit is CheckedListBoxControl)
                    {
                        if ((sender as DevExpress.XtraEditors.CheckEdit).Properties.Tag.ToString().Contains((edit as CheckedListBoxControl).Name))
                            (edit as CheckedListBoxControl).Enabled = (sender as DevExpress.XtraEditors.CheckEdit).Checked;
                    }
                    else if (edit is BaseEdit)
                    {
                        if ((sender as DevExpress.XtraEditors.CheckEdit).Properties.Tag.ToString().Contains((edit as BaseEdit).Name))
                            (edit as BaseEdit).Enabled = (sender as DevExpress.XtraEditors.CheckEdit).Checked;
                    }
                }
        }

        private void radiogroup_EditValueChanged(object sender, EventArgs e)
        {
            if ((sender as DevExpress.XtraEditors.RadioGroup).AccessibleDescription != "")
            {
                List<string> itens = new List<string>();
                foreach (string s1 in (sender as DevExpress.XtraEditors.RadioGroup).Properties.AccessibleDescription.ToString().Split('\n'))
                    if (s1 != "")
                        itens.Add(s1.Replace("\r", ""));

                List<string> _components = new List<string>();
                foreach (string s1 in (sender as DevExpress.XtraEditors.RadioGroup).Properties.AccessibleDescription.ToString().Split('\n'))
                    foreach (string s2 in s1.Split('|'))
                        if (s2 != "")
                            _components.Add(s2.Replace("\r", ""));

                foreach (Control control in panBackground.Controls)
                    if (_components.Where(p => p == control.Name).Count() != 0)
                    {
                        if (itens[(sender as DevExpress.XtraEditors.RadioGroup).SelectedIndex].Split('|').Where(p => p == control.Name).Count() != 0)
                            control.Enabled = true;
                        else
                        {
                            control.Enabled = false;
                            if (control is DevExpress.XtraEditors.TextEdit)
                                (control as DevExpress.XtraEditors.TextEdit).EditValue = null;
                            else if (control is DevExpress.XtraEditors.LookUpEdit)
                                (control as DevExpress.XtraEditors.LookUpEdit).EditValue = null;
                            else if (control is DevExpress.XtraEditors.DateEdit)
                                (control as DevExpress.XtraEditors.DateEdit).EditValue = null;
                            else if (control is DevExpress.XtraEditors.CheckedListBoxControl)
                                (control as DevExpress.XtraEditors.CheckedListBoxControl).UnCheckAll();
                        }
                    }
            }
        }

        private void FrmParametroRelatorio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && (e.KeyCode == Keys.Q) && !string.IsNullOrWhiteSpace(_sqlrelatorio))
            {
                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.IO.File.WriteAllText(saveFileDialog.FileName, _sqlrelatorio, Encoding.ASCII);
                    XtraMessageBox.Show("Arquivo '" + saveFileDialog.FileName + "' salvo com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void bbiMarcarTodos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_componentefoco is CheckedListBoxControl)
                (_componentefoco as CheckedListBoxControl).CheckAll();
        }

        private void bbiDesmarcarTodos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_componentefoco is CheckedListBoxControl)
                (_componentefoco as CheckedListBoxControl).UnCheckAll();
        }

        private void componente_MouseDown(object sender, MouseEventArgs e)
        {
            _componentefoco = sender as CheckedListBoxControl;
        }

        private void componente_Leave(object sender, EventArgs e)
        {
            ComponenteParametro componente = _componentesformulario.Where(p => p.Name == (sender as Control).Name).FirstOrDefault();
            if (componente != null && !string.IsNullOrWhiteSpace(componente.Leave))
                ExecuteDynamicCode(componente.Leave);
        }

        private void componente_Enter(object sender, EventArgs e)
        {
            ComponenteParametro componente = _componentesformulario.Where(p => p.Name == (sender as Control).Name).FirstOrDefault();
            if (componente != null && !string.IsNullOrWhiteSpace(componente.Enter))
                ExecuteDynamicCode(componente.Enter);
        }

        private void componente_Change(object sender, EventArgs e)
        {
            ComponenteParametro componente = _componentesformulario.Where(p => p.Name == (sender as Control).Name).FirstOrDefault();
            if (componente != null && !string.IsNullOrWhiteSpace(componente.Change))
                ExecuteDynamicCode(componente.Change);
        }
    }
}
