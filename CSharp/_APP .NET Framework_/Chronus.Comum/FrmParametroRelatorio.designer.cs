namespace Chronus.Comum
{
    partial class FrmParametroRelatorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.xtcRelatorios = new DevExpress.XtraTab.XtraTabControl();
            this.xtpFastReport = new DevExpress.XtraTab.XtraTabPage();
            this.previewControl = new FastReport.Preview.PreviewControl();
            this.xtpReportBuilder = new DevExpress.XtraTab.XtraTabPage();
            this.pdfViewer = new DevExpress.XtraPdfViewer.PdfViewer();
            this.xtpXtraReport = new DevExpress.XtraTab.XtraTabPage();
            this.xucXtraReport = new DevExpress.XtraEditors.XtraUserControl();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bbiMarcarTodos = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDesmarcarTodos = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panBotoes)).BeginInit();
            this.panBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panBottom)).BeginInit();
            this.panBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtcRelatorios)).BeginInit();
            this.xtcRelatorios.SuspendLayout();
            this.xtpFastReport.SuspendLayout();
            this.xtpReportBuilder.SuspendLayout();
            this.xtpXtraReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Text = "&Fechar";
            this.btnCancelar.Visible = false;
            // 
            // btnOk
            // 
            this.btnOk.Text = "&Imprimir";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panBackground
            // 
            this.panBackground.Dock = System.Windows.Forms.DockStyle.Top;
            this.panBackground.Size = new System.Drawing.Size(434, 217);
            // 
            // panBottom
            // 
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.panBottom.Location = new System.Drawing.Point(6, 227);
            // 
            // panSeparadorBottom
            // 
            this.panSeparadorBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSeparadorBottom.Location = new System.Drawing.Point(6, 223);
            // 
            // xtcRelatorios
            // 
            this.xtcRelatorios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtcRelatorios.Location = new System.Drawing.Point(6, 260);
            this.xtcRelatorios.Name = "xtcRelatorios";
            this.xtcRelatorios.SelectedTabPage = this.xtpFastReport;
            this.xtcRelatorios.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtcRelatorios.Size = new System.Drawing.Size(434, 156);
            this.xtcRelatorios.TabIndex = 3;
            this.xtcRelatorios.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpFastReport,
            this.xtpReportBuilder,
            this.xtpXtraReport});
            this.xtcRelatorios.Visible = false;
            // 
            // xtpFastReport
            // 
            this.xtpFastReport.Controls.Add(this.previewControl);
            this.xtpFastReport.Name = "xtpFastReport";
            this.xtpFastReport.Size = new System.Drawing.Size(432, 154);
            this.xtpFastReport.Text = "FastReport";
            // 
            // previewControl
            // 
            this.previewControl.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.previewControl.Buttons = ((FastReport.PreviewButtons)(((((((((FastReport.PreviewButtons.Print | FastReport.PreviewButtons.Save) 
            | FastReport.PreviewButtons.Email) 
            | FastReport.PreviewButtons.Find) 
            | FastReport.PreviewButtons.Zoom) 
            | FastReport.PreviewButtons.Outline) 
            | FastReport.PreviewButtons.PageSetup) 
            | FastReport.PreviewButtons.Watermark) 
            | FastReport.PreviewButtons.Navigator)));
            this.previewControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewControl.FastScrolling = true;
            this.previewControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.previewControl.Location = new System.Drawing.Point(0, 0);
            this.previewControl.Name = "previewControl";
            this.previewControl.PageOffset = new System.Drawing.Point(10, 10);
            this.previewControl.Size = new System.Drawing.Size(432, 154);
            this.previewControl.StatusbarVisible = false;
            this.previewControl.TabIndex = 0;
            this.previewControl.UIStyle = FastReport.Utils.UIStyle.Office2007Black;
            // 
            // xtpReportBuilder
            // 
            this.xtpReportBuilder.Controls.Add(this.pdfViewer);
            this.xtpReportBuilder.Name = "xtpReportBuilder";
            this.xtpReportBuilder.Size = new System.Drawing.Size(432, 154);
            this.xtpReportBuilder.Text = "ReportBuilder";
            // 
            // pdfViewer
            // 
            this.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer.Location = new System.Drawing.Point(0, 0);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.Size = new System.Drawing.Size(432, 154);
            this.pdfViewer.TabIndex = 0;
            // 
            // xtpXtraReport
            // 
            this.xtpXtraReport.Controls.Add(this.xucXtraReport);
            this.xtpXtraReport.Name = "xtpXtraReport";
            this.xtpXtraReport.Size = new System.Drawing.Size(432, 154);
            this.xtpXtraReport.Text = "XtraReport";
            // 
            // xucXtraReport
            // 
            this.xucXtraReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xucXtraReport.Location = new System.Drawing.Point(0, 0);
            this.xucXtraReport.Name = "xucXtraReport";
            this.xucXtraReport.Size = new System.Drawing.Size(432, 154);
            this.xucXtraReport.TabIndex = 0;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Arquivos SQL (*.sql)|*.sql";
            this.saveFileDialog.Title = "Exportar SQL";
            // 
            // barManager
            // 
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiMarcarTodos,
            this.bbiDesmarcarTodos});
            this.barManager.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(6, 6);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(434, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(6, 416);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(434, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(6, 6);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 410);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(440, 6);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 410);
            // 
            // bbiMarcarTodos
            // 
            this.bbiMarcarTodos.Caption = "Marcar todos";
            this.bbiMarcarTodos.Id = 0;
            this.bbiMarcarTodos.Name = "bbiMarcarTodos";
            this.bbiMarcarTodos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiMarcarTodos_ItemClick);
            // 
            // bbiDesmarcarTodos
            // 
            this.bbiDesmarcarTodos.Caption = "Desmarcar todos";
            this.bbiDesmarcarTodos.Id = 1;
            this.bbiDesmarcarTodos.Name = "bbiDesmarcarTodos";
            this.bbiDesmarcarTodos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDesmarcarTodos_ItemClick);
            // 
            // popupMenu
            // 
            this.popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiMarcarTodos),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDesmarcarTodos)});
            this.popupMenu.Manager = this.barManager;
            this.popupMenu.Name = "popupMenu";
            // 
            // FrmParametroRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(446, 422);
            this.Controls.Add(this.xtcRelatorios);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmParametroRelatorio";
            this.Text = "Parâmetros de Relatórios";
            this.Load += new System.EventHandler(this.FrmParametroRelatorio_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmParametroRelatorio_KeyDown);
            this.Controls.SetChildIndex(this.barDockControlTop, 0);
            this.Controls.SetChildIndex(this.barDockControlBottom, 0);
            this.Controls.SetChildIndex(this.barDockControlRight, 0);
            this.Controls.SetChildIndex(this.barDockControlLeft, 0);
            this.Controls.SetChildIndex(this.panBackground, 0);
            this.Controls.SetChildIndex(this.panSeparadorBottom, 0);
            this.Controls.SetChildIndex(this.panBottom, 0);
            this.Controls.SetChildIndex(this.xtcRelatorios, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panBotoes)).EndInit();
            this.panBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panBottom)).EndInit();
            this.panBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtcRelatorios)).EndInit();
            this.xtcRelatorios.ResumeLayout(false);
            this.xtpFastReport.ResumeLayout(false);
            this.xtpReportBuilder.ResumeLayout(false);
            this.xtpXtraReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtcRelatorios;
        private DevExpress.XtraTab.XtraTabPage xtpFastReport;
        private DevExpress.XtraTab.XtraTabPage xtpReportBuilder;
        private FastReport.Preview.PreviewControl previewControl;
        private DevExpress.XtraPdfViewer.PdfViewer pdfViewer;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiMarcarTodos;
        private DevExpress.XtraBars.BarButtonItem bbiDesmarcarTodos;
        private DevExpress.XtraBars.PopupMenu popupMenu;
        private DevExpress.XtraTab.XtraTabPage xtpXtraReport;
        private DevExpress.XtraEditors.XtraUserControl xucXtraReport;
    }
}
