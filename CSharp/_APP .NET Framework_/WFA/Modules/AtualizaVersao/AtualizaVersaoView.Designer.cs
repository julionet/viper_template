namespace VIPER.Modules.AtualizaVersao.Views
{
    partial class AtualizaVersaoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtualizaVersaoView));
            this.gclPrincipal = new DevExpress.XtraGrid.GridControl();
            this.gvwAcesso = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.memAtualizacao = new DevExpress.XtraEditors.MemoEdit();
            this.dsAtualizacao = new System.Data.DataSet();
            this.dtAtualizacao = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panBackground)).BeginInit();
            this.panBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panBotoes)).BeginInit();
            this.panBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panBottom)).BeginInit();
            this.panBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gclPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwAcesso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memAtualizacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAtualizacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAtualizacao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOk.Text = "&Atualizar";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panBackground
            // 
            this.panBackground.Controls.Add(this.memAtualizacao);
            this.panBackground.Controls.Add(this.panelControl1);
            this.panBackground.Controls.Add(this.gclPrincipal);
            this.panBackground.Padding = new System.Windows.Forms.Padding(3);
            this.panBackground.Size = new System.Drawing.Size(786, 522);
            // 
            // detalheBindingSource
            // 
            this.detalheBindingSource.DataSource = typeof(VIPER.Entity.Atualizacao);
            // 
            // panBottom
            // 
            this.panBottom.Location = new System.Drawing.Point(6, 532);
            this.panBottom.Size = new System.Drawing.Size(786, 33);
            // 
            // panSeparadorBottom
            // 
            this.panSeparadorBottom.Location = new System.Drawing.Point(6, 528);
            this.panSeparadorBottom.Size = new System.Drawing.Size(786, 4);
            // 
            // gclPrincipal
            // 
            this.gclPrincipal.DataSource = this.detalheBindingSource;
            this.gclPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.gclPrincipal.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gclPrincipal.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gclPrincipal.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gclPrincipal.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gclPrincipal.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gclPrincipal.Location = new System.Drawing.Point(5, 5);
            this.gclPrincipal.MainView = this.gvwAcesso;
            this.gclPrincipal.Name = "gclPrincipal";
            this.gclPrincipal.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1});
            this.gclPrincipal.Size = new System.Drawing.Size(776, 351);
            this.gclPrincipal.TabIndex = 14;
            this.gclPrincipal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwAcesso});
            // 
            // gvwAcesso
            // 
            this.gvwAcesso.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gvwAcesso.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvwAcesso.GridControl = this.gclPrincipal;
            this.gvwAcesso.Name = "gvwAcesso";
            this.gvwAcesso.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvwAcesso.OptionsBehavior.Editable = false;
            this.gvwAcesso.OptionsCustomization.AllowColumnMoving = false;
            this.gvwAcesso.OptionsCustomization.AllowColumnResizing = false;
            this.gvwAcesso.OptionsCustomization.AllowFilter = false;
            this.gvwAcesso.OptionsCustomization.AllowGroup = false;
            this.gvwAcesso.OptionsCustomization.AllowSort = false;
            this.gvwAcesso.OptionsMenu.EnableColumnMenu = false;
            this.gvwAcesso.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvwAcesso.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvwAcesso.OptionsView.ShowGroupPanel = false;
            this.gvwAcesso.OptionsView.ShowIndicator = false;
            this.gvwAcesso.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvwAcesso.DoubleClick += new System.EventHandler(this.gvwAcesso_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Identificação";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 100;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Data";
            this.gridColumn2.FieldName = "Data";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Versão";
            this.gridColumn3.FieldName = "Versao";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 100;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Descrição";
            this.gridColumn4.FieldName = "Descricao";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 405;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Situação";
            this.gridColumn5.ColumnEdit = this.repositoryItemImageComboBox1;
            this.gridColumn5.FieldName = "Status";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 80;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Pendente", "P", 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Erro", "E", 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("OK", "O", 2)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.SmallImages = this.imageCollection;
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "error.png");
            this.imageCollection.Images.SetKeyName(1, "wait.png");
            this.imageCollection.Images.SetKeyName(2, "ok.png");
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(5, 356);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(776, 3);
            this.panelControl1.TabIndex = 15;
            // 
            // memAtualizacao
            // 
            this.memAtualizacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memAtualizacao.Location = new System.Drawing.Point(5, 359);
            this.memAtualizacao.Name = "memAtualizacao";
            this.memAtualizacao.Properties.ReadOnly = true;
            this.memAtualizacao.Size = new System.Drawing.Size(776, 158);
            this.memAtualizacao.TabIndex = 16;
            // 
            // dsAtualizacao
            // 
            this.dsAtualizacao.DataSetName = "Atualizacoes";
            this.dsAtualizacao.Tables.AddRange(new System.Data.DataTable[] {
            this.dtAtualizacao});
            // 
            // dtAtualizacao
            // 
            this.dtAtualizacao.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8});
            this.dtAtualizacao.TableName = "Atualizacao";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Id";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Data";
            this.dataColumn2.DataType = typeof(System.DateTime);
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Versao";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Descricao";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Sql";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "SqlProcedimento";
            this.dataColumn6.DataType = typeof(bool);
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "Status";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "Mensagem";
            // 
            // AtualizaVersaoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(798, 571);
            this.Name = "AtualizaVersaoView";
            this.Text = "Atualização de Versão";
            this.Load += new System.EventHandler(this.AtualizaVersaoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panBackground)).EndInit();
            this.panBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detalheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panBotoes)).EndInit();
            this.panBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panBottom)).EndInit();
            this.panBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gclPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwAcesso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memAtualizacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAtualizacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAtualizacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gclPrincipal;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwAcesso;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.MemoEdit memAtualizacao;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Data.DataSet dsAtualizacao;
        private System.Data.DataTable dtAtualizacao;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.Utils.ImageCollection imageCollection;
    }
}
