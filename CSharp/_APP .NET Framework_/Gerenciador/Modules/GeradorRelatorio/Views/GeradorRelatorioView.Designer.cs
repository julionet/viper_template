namespace VIPER.Modules.GeradorRelatorio.Views
{
    partial class GeradorRelatorioView
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
            this.gridControlRelatorio = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            this.marcarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desmarcarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewRelatorio = new DevExpress.XtraGrid.Views.Grid.GridViewWithButtons();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditData = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEditTamanho = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.checkEditRelatorio = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButtonFiltrar = new DevExpress.XtraEditors.SimpleButton();
            this.textEditFiltro = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonExportar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonImportar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panBackground)).BeginInit();
            this.panBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panBotoes)).BeginInit();
            this.panBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panBottom)).BeginInit();
            this.panBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRelatorio)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRelatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditData.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEditTamanho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditRelatorio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(247, 3);
            this.btnCancelar.Visible = false;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOk.Text = "&Inserir";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panBackground
            // 
            this.panBackground.Controls.Add(this.gridControlRelatorio);
            this.panBackground.Controls.Add(this.panelControl2);
            this.panBackground.Controls.Add(this.panelControl1);
            this.panBackground.Padding = new System.Windows.Forms.Padding(4);
            this.panBackground.Size = new System.Drawing.Size(996, 401);
            // 
            // detalheBindingSource
            // 
            this.detalheBindingSource.DataSource = typeof(Entity.Relatorio);
            // 
            // panBotoes
            // 
            this.panBotoes.Controls.Add(this.simpleButtonImportar);
            this.panBotoes.Controls.Add(this.simpleButtonExportar);
            this.panBotoes.Size = new System.Drawing.Size(330, 29);
            this.panBotoes.Controls.SetChildIndex(this.btnOk, 0);
            this.panBotoes.Controls.SetChildIndex(this.btnCancelar, 0);
            this.panBotoes.Controls.SetChildIndex(this.simpleButtonExportar, 0);
            this.panBotoes.Controls.SetChildIndex(this.simpleButtonImportar, 0);
            // 
            // panBottom
            // 
            this.panBottom.Location = new System.Drawing.Point(6, 411);
            this.panBottom.Size = new System.Drawing.Size(996, 33);
            // 
            // panSeparadorBottom
            // 
            this.panSeparadorBottom.Location = new System.Drawing.Point(6, 407);
            this.panSeparadorBottom.Size = new System.Drawing.Size(996, 4);
            // 
            // gridControlRelatorio
            // 
            this.gridControlRelatorio.ContextMenuStrip = this.contextMenuStrip;
            this.gridControlRelatorio.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlRelatorio.DataSource = this.detalheBindingSource;
            this.gridControlRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlRelatorio.Location = new System.Drawing.Point(6, 72);
            this.gridControlRelatorio.MainView = this.gridViewRelatorio;
            this.gridControlRelatorio.Name = "gridControlRelatorio";
            this.gridControlRelatorio.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEditData,
            this.repositoryItemCalcEditTamanho});
            this.gridControlRelatorio.Size = new System.Drawing.Size(984, 323);
            this.gridControlRelatorio.TabIndex = 5;
            this.gridControlRelatorio.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRelatorio});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcarTodosToolStripMenuItem,
            this.desmarcarTodosToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(166, 48);
            // 
            // marcarTodosToolStripMenuItem
            // 
            this.marcarTodosToolStripMenuItem.Name = "marcarTodosToolStripMenuItem";
            this.marcarTodosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.marcarTodosToolStripMenuItem.Text = "Marcar Todos";
            this.marcarTodosToolStripMenuItem.Click += new System.EventHandler(this.marcarTodosToolStripMenuItem_Click);
            // 
            // desmarcarTodosToolStripMenuItem
            // 
            this.desmarcarTodosToolStripMenuItem.Name = "desmarcarTodosToolStripMenuItem";
            this.desmarcarTodosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.desmarcarTodosToolStripMenuItem.Text = "Desmarcar Todos";
            this.desmarcarTodosToolStripMenuItem.Click += new System.EventHandler(this.desmarcarTodosToolStripMenuItem_Click);
            // 
            // gridViewRelatorio
            // 
            this.gridViewRelatorio.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn2,
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridViewRelatorio.GridControl = this.gridControlRelatorio;
            this.gridViewRelatorio.Name = "gridViewRelatorio";
            this.gridViewRelatorio.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewRelatorio.OptionsCustomization.AllowColumnMoving = false;
            this.gridViewRelatorio.OptionsCustomization.AllowColumnResizing = false;
            this.gridViewRelatorio.OptionsCustomization.AllowFilter = false;
            this.gridViewRelatorio.OptionsCustomization.AllowGroup = false;
            this.gridViewRelatorio.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridViewRelatorio.OptionsMenu.EnableColumnMenu = false;
            this.gridViewRelatorio.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewRelatorio.OptionsView.ShowGroupPanel = false;
            this.gridViewRelatorio.OptionsView.ShowIndicator = false;
            this.gridViewRelatorio.OptionsView.ShowViewCaption = true;
            this.gridViewRelatorio.ShowButtons = false;
            this.gridViewRelatorio.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn2, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewRelatorio.ViewCaption = "Relatórios do Sistema";
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "Selecionar?";
            this.gridColumn6.FieldName = "Selecionar";
            this.gridColumn6.MaxWidth = 70;
            this.gridColumn6.MinWidth = 70;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            this.gridColumn6.Width = 70;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Código";
            this.gridColumn2.FieldName = "Codigo";
            this.gridColumn2.MaxWidth = 150;
            this.gridColumn2.MinWidth = 150;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 150;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Nome do Relatório";
            this.gridColumn1.FieldName = "Nome";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Data de Modificação";
            this.gridColumn3.ColumnEdit = this.repositoryItemDateEditData;
            this.gridColumn3.FieldName = "Modificado";
            this.gridColumn3.MaxWidth = 150;
            this.gridColumn3.MinWidth = 150;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 150;
            // 
            // repositoryItemDateEditData
            // 
            this.repositoryItemDateEditData.AutoHeight = false;
            this.repositoryItemDateEditData.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditData.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditData.Mask.EditMask = "G";
            this.repositoryItemDateEditData.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEditData.Name = "repositoryItemDateEditData";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tamanho";
            this.gridColumn4.ColumnEdit = this.repositoryItemCalcEditTamanho;
            this.gridColumn4.FieldName = "Tamanho";
            this.gridColumn4.MaxWidth = 100;
            this.gridColumn4.MinWidth = 100;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 100;
            // 
            // repositoryItemCalcEditTamanho
            // 
            this.repositoryItemCalcEditTamanho.AutoHeight = false;
            this.repositoryItemCalcEditTamanho.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEditTamanho.Mask.EditMask = "n0";
            this.repositoryItemCalcEditTamanho.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemCalcEditTamanho.Name = "repositoryItemCalcEditTamanho";
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "Matricial?";
            this.gridColumn5.FieldName = "Matricial";
            this.gridColumn5.MaxWidth = 80;
            this.gridColumn5.MinWidth = 80;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 80;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.checkEditRelatorio);
            this.panelControl1.Controls.Add(this.simpleButtonFiltrar);
            this.panelControl1.Controls.Add(this.textEditFiltro);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(6, 6);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(984, 62);
            this.panelControl1.TabIndex = 6;
            // 
            // checkEditRelatorio
            // 
            this.checkEditRelatorio.EditValue = true;
            this.checkEditRelatorio.Location = new System.Drawing.Point(49, 37);
            this.checkEditRelatorio.Name = "checkEditRelatorio";
            this.checkEditRelatorio.Properties.Caption = "Selecionar apenas relatórios vinculados";
            this.checkEditRelatorio.Size = new System.Drawing.Size(216, 19);
            this.checkEditRelatorio.TabIndex = 3;
            // 
            // simpleButtonFiltrar
            // 
            this.simpleButtonFiltrar.Location = new System.Drawing.Point(404, 9);
            this.simpleButtonFiltrar.Name = "simpleButtonFiltrar";
            this.simpleButtonFiltrar.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonFiltrar.TabIndex = 2;
            this.simpleButtonFiltrar.Text = "&Filtrar";
            this.simpleButtonFiltrar.Click += new System.EventHandler(this.simpleButtonFiltrar_Click);
            // 
            // textEditFiltro
            // 
            this.textEditFiltro.Location = new System.Drawing.Point(49, 11);
            this.textEditFiltro.Name = "textEditFiltro";
            this.textEditFiltro.Size = new System.Drawing.Size(349, 20);
            this.textEditFiltro.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Filtrar";
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(6, 68);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(984, 4);
            this.panelControl2.TabIndex = 7;
            // 
            // simpleButtonExportar
            // 
            this.simpleButtonExportar.Location = new System.Drawing.Point(85, 3);
            this.simpleButtonExportar.Name = "simpleButtonExportar";
            this.simpleButtonExportar.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonExportar.TabIndex = 3;
            this.simpleButtonExportar.Text = "&Exportar";
            this.simpleButtonExportar.Click += new System.EventHandler(this.simpleButtonExportar_Click);
            // 
            // simpleButtonImportar
            // 
            this.simpleButtonImportar.Location = new System.Drawing.Point(166, 3);
            this.simpleButtonImportar.Name = "simpleButtonImportar";
            this.simpleButtonImportar.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonImportar.TabIndex = 4;
            this.simpleButtonImportar.Text = "Im&portar";
            this.simpleButtonImportar.Click += new System.EventHandler(this.simpleButtonImportar_Click);
            // 
            // FrmGeradorRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 450);
            this.FirstControl = this.textEditFiltro;
            this.Name = "FrmGeradorRelatorio";
            this.Text = "FrmGeradorRelatorio";
            this.Controls.SetChildIndex(this.panBottom, 0);
            this.Controls.SetChildIndex(this.panSeparadorBottom, 0);
            this.Controls.SetChildIndex(this.panBackground, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panBackground)).EndInit();
            this.panBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detalheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panBotoes)).EndInit();
            this.panBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panBottom)).EndInit();
            this.panBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRelatorio)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRelatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditData.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEditTamanho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditRelatorio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl gridControlRelatorio;
        public DevExpress.XtraGrid.Views.Grid.GridViewWithButtons gridViewRelatorio;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit textEditFiltro;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonFiltrar;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditData;
        private DevExpress.XtraEditors.CheckEdit checkEditRelatorio;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem marcarTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desmarcarTodosToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton simpleButtonExportar;
        private DevExpress.XtraEditors.SimpleButton simpleButtonImportar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEditTamanho;
    }
}