namespace VIPER.Modules.DesbloqueioRegistro.Views
{
    partial class DesbloqueioRegistroView
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnAtualizar = new DevExpress.XtraEditors.SimpleButton();
            this.btnDesbloquearSelecionado = new DevExpress.XtraEditors.SimpleButton();
            this.btnDesbloquearTodos = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gclPrincipal = new DevExpress.XtraGrid.GridControl();
            this.gvwAcesso = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repData = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panBackground)).BeginInit();
            this.panBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panBotoes)).BeginInit();
            this.panBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panBottom)).BeginInit();
            this.panBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gclPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwAcesso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repData.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.TabIndex = 0;
            // 
            // panBackground
            // 
            this.panBackground.Controls.Add(this.gclPrincipal);
            this.panBackground.Controls.Add(this.panelControl2);
            this.panBackground.Controls.Add(this.panelControl1);
            this.panBackground.Padding = new System.Windows.Forms.Padding(4);
            this.panBackground.Size = new System.Drawing.Size(580, 352);
            // 
            // detalheBindingSource
            // 
            this.detalheBindingSource.DataSource = typeof(Entity.Bloqueio);
            // 
            // panBottom
            // 
            this.panBottom.Location = new System.Drawing.Point(6, 362);
            this.panBottom.Size = new System.Drawing.Size(580, 33);
            this.panBottom.Visible = false;
            // 
            // panSeparadorBottom
            // 
            this.panSeparadorBottom.Location = new System.Drawing.Point(6, 358);
            this.panSeparadorBottom.Size = new System.Drawing.Size(580, 4);
            this.panSeparadorBottom.Visible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnAtualizar);
            this.panelControl1.Controls.Add(this.btnDesbloquearSelecionado);
            this.panelControl1.Controls.Add(this.btnDesbloquearTodos);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(6, 6);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(568, 34);
            this.panelControl1.TabIndex = 0;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(5, 5);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(70, 23);
            this.btnAtualizar.TabIndex = 0;
            this.btnAtualizar.Text = "&Atualizar";
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnDesbloquearSelecionado
            // 
            this.btnDesbloquearSelecionado.Enabled = false;
            this.btnDesbloquearSelecionado.Location = new System.Drawing.Point(206, 5);
            this.btnDesbloquearSelecionado.Name = "btnDesbloquearSelecionado";
            this.btnDesbloquearSelecionado.Size = new System.Drawing.Size(139, 23);
            this.btnDesbloquearSelecionado.TabIndex = 2;
            this.btnDesbloquearSelecionado.Text = "Desbloquear &Selecionado";
            this.btnDesbloquearSelecionado.Click += new System.EventHandler(this.btnDesbloquearSelecionado_Click);
            // 
            // btnDesbloquearTodos
            // 
            this.btnDesbloquearTodos.Enabled = false;
            this.btnDesbloquearTodos.Location = new System.Drawing.Point(81, 5);
            this.btnDesbloquearTodos.Name = "btnDesbloquearTodos";
            this.btnDesbloquearTodos.Size = new System.Drawing.Size(119, 23);
            this.btnDesbloquearTodos.TabIndex = 1;
            this.btnDesbloquearTodos.Text = "Desbloquear &Todos";
            this.btnDesbloquearTodos.Click += new System.EventHandler(this.btnDesbloquearTodos_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(6, 40);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(568, 4);
            this.panelControl2.TabIndex = 1;
            // 
            // gclPrincipal
            // 
            this.gclPrincipal.Cursor = System.Windows.Forms.Cursors.Default;
            this.gclPrincipal.DataSource = this.detalheBindingSource;
            this.gclPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gclPrincipal.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gclPrincipal.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gclPrincipal.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gclPrincipal.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gclPrincipal.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gclPrincipal.Location = new System.Drawing.Point(6, 44);
            this.gclPrincipal.MainView = this.gvwAcesso;
            this.gclPrincipal.Name = "gclPrincipal";
            this.gclPrincipal.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repData});
            this.gclPrincipal.Size = new System.Drawing.Size(568, 302);
            this.gclPrincipal.TabIndex = 1;
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
            this.gridColumn5,
            this.gridColumn6});
            this.gvwAcesso.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvwAcesso.GridControl = this.gclPrincipal;
            this.gvwAcesso.Name = "gvwAcesso";
            this.gvwAcesso.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvwAcesso.OptionsBehavior.Editable = false;
            this.gvwAcesso.OptionsCustomization.AllowColumnMoving = false;
            this.gvwAcesso.OptionsCustomization.AllowColumnResizing = false;
            this.gvwAcesso.OptionsCustomization.AllowGroup = false;
            this.gvwAcesso.OptionsMenu.EnableColumnMenu = false;
            this.gvwAcesso.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvwAcesso.OptionsView.ColumnAutoWidth = false;
            this.gvwAcesso.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvwAcesso.OptionsView.ShowGroupPanel = false;
            this.gvwAcesso.OptionsView.ShowIndicator = false;
            this.gvwAcesso.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn2, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Classe";
            this.gridColumn2.FieldName = "Classe";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 120;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Usuário";
            this.gridColumn3.FieldName = "Usuario";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 120;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Computador";
            this.gridColumn4.FieldName = "Computador";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 120;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Data/Hora";
            this.gridColumn5.ColumnEdit = this.repData;
            this.gridColumn5.FieldName = "DataHora";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 120;
            // 
            // repData
            // 
            this.repData.AutoHeight = false;
            this.repData.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repData.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repData.Mask.EditMask = "G";
            this.repData.Mask.UseMaskAsDisplayFormat = true;
            this.repData.Name = "repData";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Referência";
            this.gridColumn6.FieldName = "Referencia";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 80;
            // 
            // FrmDesbloqueioRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(592, 401);
            this.Name = "FrmDesbloqueioRegistro";
            this.Text = "Desbloqueio de Registros";
            ((System.ComponentModel.ISupportInitialize)(this.panBackground)).EndInit();
            this.panBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detalheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panBotoes)).EndInit();
            this.panBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panBottom)).EndInit();
            this.panBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gclPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwAcesso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repData.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gclPrincipal;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwAcesso;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton btnAtualizar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        public DevExpress.XtraEditors.SimpleButton btnDesbloquearSelecionado;
        public DevExpress.XtraEditors.SimpleButton btnDesbloquearTodos;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repData;
    }
}
