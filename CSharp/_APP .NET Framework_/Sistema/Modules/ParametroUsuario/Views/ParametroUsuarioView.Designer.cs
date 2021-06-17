namespace VIPER.Modules.ParametroUsuario.Views
{
    partial class ParametroUsuarioView
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
            this.gclPrincipal = new DevExpress.XtraGrid.GridControl();
            this.gvwAcesso = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repUsuario = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lkUsuario = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblTitulo = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pclAcesso)).BeginInit();
            this.pclAcesso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pclAcessoBottom)).BeginInit();
            this.xtpManutencao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pclManutencao)).BeginInit();
            this.pclManutencao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.principalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtcPaginas)).BeginInit();
            this.xtcPaginas.SuspendLayout();
            this.xtpAcesso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pclBotoesManutencao)).BeginInit();
            this.pclBotoesManutencao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pclPesquisar)).BeginInit();
            this.pclPesquisar.SuspendLayout();
            this.xscManutencao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pclSeparadorAcesso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gclPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwAcesso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pclAcesso
            // 
            this.pclAcesso.Controls.Add(this.gclPrincipal);
            this.pclAcesso.Size = new System.Drawing.Size(571, 192);
            // 
            // pclAcessoBottom
            // 
            this.pclAcessoBottom.Size = new System.Drawing.Size(571, 0);
            // 
            // xtpManutencao
            // 
            this.xtpManutencao.Size = new System.Drawing.Size(547, 260);
            // 
            // pclManutencao
            // 
            this.pclManutencao.Size = new System.Drawing.Size(547, 226);
            // 
            // txtPesquisa
            // 
            // 
            // principalBindingSource
            // 
            this.principalBindingSource.DataSource = typeof(Entity.ParametroUsuario);
            // 
            // xtcPaginas
            // 
            this.xtcPaginas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.xtcPaginas.Location = new System.Drawing.Point(6, 33);
            this.xtcPaginas.Size = new System.Drawing.Size(571, 260);
            // 
            // xtpAcesso
            // 
            this.xtpAcesso.Size = new System.Drawing.Size(571, 260);
            // 
            // pclBotoesManutencao
            // 
            this.pclBotoesManutencao.Location = new System.Drawing.Point(0, 230);
            this.pclBotoesManutencao.Size = new System.Drawing.Size(547, 30);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(1, 3);
            // 
            // pclPesquisar
            // 
            this.pclPesquisar.Size = new System.Drawing.Size(571, 35);
            this.pclPesquisar.Visible = false;
            // 
            // xscManutencao
            // 
            this.xscManutencao.Controls.Add(this.label2);
            this.xscManutencao.Controls.Add(this.lkUsuario);
            this.xscManutencao.Controls.Add(this.label1);
            this.xscManutencao.Size = new System.Drawing.Size(547, 226);
            // 
            // pclSeparadorAcesso
            // 
            this.pclSeparadorAcesso.Size = new System.Drawing.Size(571, 4);
            this.pclSeparadorAcesso.Visible = false;
            // 
            // gclPrincipal
            // 
            this.gclPrincipal.Cursor = System.Windows.Forms.Cursors.Default;
            this.gclPrincipal.DataSource = this.principalBindingSource;
            this.gclPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gclPrincipal.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gclPrincipal.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gclPrincipal.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gclPrincipal.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gclPrincipal.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gclPrincipal.Location = new System.Drawing.Point(0, 3);
            this.gclPrincipal.MainView = this.gvwAcesso;
            this.gclPrincipal.Name = "gclPrincipal";
            this.gclPrincipal.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repUsuario});
            this.gclPrincipal.Size = new System.Drawing.Size(571, 189);
            this.gclPrincipal.TabIndex = 9;
            this.gclPrincipal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwAcesso});
            // 
            // gvwAcesso
            // 
            this.gvwAcesso.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gvwAcesso.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvwAcesso.GridControl = this.gclPrincipal;
            this.gvwAcesso.Name = "gvwAcesso";
            this.gvwAcesso.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvwAcesso.OptionsBehavior.Editable = false;
            this.gvwAcesso.OptionsCustomization.AllowColumnMoving = false;
            this.gvwAcesso.OptionsCustomization.AllowColumnResizing = false;
            this.gvwAcesso.OptionsCustomization.AllowFilter = false;
            this.gvwAcesso.OptionsCustomization.AllowGroup = false;
            this.gvwAcesso.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gvwAcesso.OptionsFilter.UseNewCustomFilterDialog = true;
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
            this.gridColumn1.Caption = "Usuário";
            this.gridColumn1.ColumnEdit = this.repUsuario;
            this.gridColumn1.FieldName = "UsuarioId";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // repUsuario
            // 
            this.repUsuario.AutoHeight = false;
            this.repUsuario.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repUsuario.DisplayMember = "Login";
            this.repUsuario.Name = "repUsuario";
            this.repUsuario.NullText = "";
            this.repUsuario.ValueMember = "Id";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Valor";
            this.gridColumn2.FieldName = "Valor";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Id";
            this.gridColumn3.FieldName = "Id";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            // 
            // lkUsuario
            // 
            this.lkUsuario.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.principalBindingSource, "UsuarioId", true));
            this.lkUsuario.Location = new System.Drawing.Point(84, 36);
            this.lkUsuario.Name = "lkUsuario";
            this.lkUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkUsuario.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Login", "Login")});
            this.lkUsuario.Properties.DisplayMember = "Login";
            this.lkUsuario.Properties.NullText = "";
            this.lkUsuario.Properties.ShowFooter = false;
            this.lkUsuario.Properties.ShowHeader = false;
            this.lkUsuario.Properties.ShowLines = false;
            this.lkUsuario.Properties.ShowPopupShadow = false;
            this.lkUsuario.Properties.ValueMember = "Id";
            this.lkUsuario.Size = new System.Drawing.Size(232, 20);
            this.lkUsuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblTitulo);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(6, 6);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(571, 28);
            this.panelControl1.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(9, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(0, 13);
            this.lblTitulo.TabIndex = 0;
            // 
            // FrmParametroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(583, 299);
            this.Controls.Add(this.panelControl1);
            this.FirstControl = this.lkUsuario;
            this.KeyPreview = false;
            this.Name = "FrmParametroUsuario";
            this.Text = "Parâmetros do Sistema por Usuário";
            this.Controls.SetChildIndex(this.xtcPaginas, 0);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pclAcesso)).EndInit();
            this.pclAcesso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pclAcessoBottom)).EndInit();
            this.xtpManutencao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pclManutencao)).EndInit();
            this.pclManutencao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.principalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtcPaginas)).EndInit();
            this.xtcPaginas.ResumeLayout(false);
            this.xtpAcesso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pclBotoesManutencao)).EndInit();
            this.pclBotoesManutencao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pclPesquisar)).EndInit();
            this.pclPesquisar.ResumeLayout(false);
            this.pclPesquisar.PerformLayout();
            this.xscManutencao.ResumeLayout(false);
            this.xscManutencao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pclSeparadorAcesso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gclPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwAcesso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gclPrincipal;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwAcesso;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraEditors.LookUpEdit lkUsuario;
        public DevExpress.XtraEditors.LabelControl lblTitulo;
        public DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repUsuario;
    }
}
