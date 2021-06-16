namespace Chronus.App.Modules.ControleAcesso.Views
{
    partial class ControleAcessoView
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
            this.btnSelecionar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pceUsuario = new DevExpress.XtraEditors.PopupContainerEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gclFuncoes = new DevExpress.XtraGrid.GridControl();
            this.gvwFuncoes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSelecionado = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.clbPerfil = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panBackground)).BeginInit();
            this.panBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panBotoes)).BeginInit();
            this.panBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panBottom)).BeginInit();
            this.panBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pceUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gclFuncoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwFuncoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSelecionado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clbPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnOk
            // 
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panBackground
            // 
            this.panBackground.Controls.Add(this.gclFuncoes);
            this.panBackground.Controls.Add(this.panelControl3);
            this.panBackground.Controls.Add(this.clbPerfil);
            this.panBackground.Controls.Add(this.panelControl2);
            this.panBackground.Controls.Add(this.panelControl1);
            this.panBackground.Padding = new System.Windows.Forms.Padding(4);
            this.panBackground.Size = new System.Drawing.Size(737, 367);
            // 
            // detalheBindingSource
            // 
            this.detalheBindingSource.DataSource = typeof(DTO.UsuarioFuncaoDTO);
            // 
            // panBottom
            // 
            this.panBottom.Location = new System.Drawing.Point(6, 377);
            this.panBottom.Size = new System.Drawing.Size(737, 33);
            // 
            // panSeparadorBottom
            // 
            this.panSeparadorBottom.Location = new System.Drawing.Point(6, 373);
            this.panSeparadorBottom.Size = new System.Drawing.Size(737, 4);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSelecionar);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.pceUsuario);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(6, 6);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(725, 41);
            this.panelControl1.TabIndex = 0;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(261, 8);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 2;
            this.btnSelecionar.Text = "&Selecionar";
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Usuário";
            // 
            // pceUsuario
            // 
            this.pceUsuario.Location = new System.Drawing.Point(60, 10);
            this.pceUsuario.Name = "pceUsuario";
            this.pceUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pceUsuario.Size = new System.Drawing.Size(194, 20);
            this.pceUsuario.TabIndex = 1;
            this.pceUsuario.QueryResultValue += new DevExpress.XtraEditors.Controls.QueryResultValueEventHandler(this.pceUsuario_QueryResultValue);
            this.pceUsuario.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.pceUsuario_QueryPopUp);
            this.pceUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pceUsuario_KeyDown);
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(6, 47);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(725, 4);
            this.panelControl2.TabIndex = 1;
            // 
            // gclFuncoes
            // 
            this.gclFuncoes.Cursor = System.Windows.Forms.Cursors.Default;
            this.gclFuncoes.DataSource = this.detalheBindingSource;
            this.gclFuncoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gclFuncoes.Location = new System.Drawing.Point(6, 51);
            this.gclFuncoes.MainView = this.gvwFuncoes;
            this.gclFuncoes.Name = "gclFuncoes";
            this.gclFuncoes.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSelecionado});
            this.gclFuncoes.Size = new System.Drawing.Size(725, 217);
            this.gclFuncoes.TabIndex = 4;
            this.gclFuncoes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwFuncoes});
            // 
            // gvwFuncoes
            // 
            this.gvwFuncoes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gvwFuncoes.GridControl = this.gclFuncoes;
            this.gvwFuncoes.GroupCount = 1;
            this.gvwFuncoes.Name = "gvwFuncoes";
            this.gvwFuncoes.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvwFuncoes.OptionsCustomization.AllowColumnMoving = false;
            this.gvwFuncoes.OptionsCustomization.AllowColumnResizing = false;
            this.gvwFuncoes.OptionsCustomization.AllowFilter = false;
            this.gvwFuncoes.OptionsCustomization.AllowGroup = false;
            this.gvwFuncoes.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvwFuncoes.OptionsCustomization.AllowSort = false;
            this.gvwFuncoes.OptionsMenu.EnableColumnMenu = false;
            this.gvwFuncoes.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvwFuncoes.OptionsView.ShowGroupPanel = false;
            this.gvwFuncoes.OptionsView.ShowIndicator = false;
            this.gvwFuncoes.OptionsView.ShowViewCaption = true;
            this.gvwFuncoes.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn3, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvwFuncoes.ViewCaption = "Funções";
            this.gvwFuncoes.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvwFuncoes_CellValueChanged);
            this.gvwFuncoes.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvwFuncoes_CellValueChanging);
            this.gvwFuncoes.DoubleClick += new System.EventHandler(this.gvwFuncoes_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Módulo";
            this.gridColumn1.FieldName = "ModuloDescricao";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.FieldName = "FuncaoId";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Função";
            this.gridColumn3.FieldName = "FuncaoDescricao";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 401;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "Permite Incluir?";
            this.gridColumn4.FieldName = "PermiteIncluir";
            this.gridColumn4.MaxWidth = 100;
            this.gridColumn4.MinWidth = 100;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 100;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "Permite Alterar?";
            this.gridColumn5.FieldName = "PermiteAlterar";
            this.gridColumn5.MaxWidth = 100;
            this.gridColumn5.MinWidth = 100;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 100;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "Permite Excluir?";
            this.gridColumn6.FieldName = "PermiteExcluir";
            this.gridColumn6.MaxWidth = 100;
            this.gridColumn6.MinWidth = 100;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 100;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "gridColumn7";
            this.gridColumn7.ColumnEdit = this.repSelecionado;
            this.gridColumn7.FieldName = "Selecionado";
            this.gridColumn7.MaxWidth = 20;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.ShowCaption = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            this.gridColumn7.Width = 41;
            // 
            // repSelecionado
            // 
            this.repSelecionado.AutoHeight = false;
            this.repSelecionado.Name = "repSelecionado";
            this.repSelecionado.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repSelecionado.ValueGrayed = false;
            // 
            // clbPerfil
            // 
            this.clbPerfil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clbPerfil.Location = new System.Drawing.Point(6, 272);
            this.clbPerfil.Name = "clbPerfil";
            this.clbPerfil.Size = new System.Drawing.Size(725, 89);
            this.clbPerfil.TabIndex = 5;
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(6, 268);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(725, 4);
            this.panelControl3.TabIndex = 6;
            // 
            // FrmUsuarioFuncao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(749, 416);
            this.Name = "FrmUsuarioFuncao";
            this.Text = "Controle de Acesso";
            this.Load += new System.EventHandler(this.FrmUsuarioFuncao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panBackground)).EndInit();
            this.panBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detalheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panBotoes)).EndInit();
            this.panBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panBottom)).EndInit();
            this.panBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pceUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gclFuncoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwFuncoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSelecionado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clbPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repSelecionado;
        public DevExpress.XtraGrid.GridControl gclFuncoes;
        public DevExpress.XtraGrid.Views.Grid.GridView gvwFuncoes;
        public DevExpress.XtraEditors.SimpleButton btnSelecionar;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        public DevExpress.XtraEditors.CheckedListBoxControl clbPerfil;
        public DevExpress.XtraEditors.PopupContainerEdit pceUsuario;
    }
}
