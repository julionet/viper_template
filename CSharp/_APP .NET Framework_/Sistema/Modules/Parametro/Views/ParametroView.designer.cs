namespace VIPER.Modules.Parametro.Views
{
    partial class ParametroView
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
            this.gridControlParametros = new DevExpress.XtraGrid.GridControl();
            this.gridViewParametros = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repMemo = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.toolTipController = new DevExpress.Utils.ToolTipController(this.components);
            this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.gridControlCategoria = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceCategoria = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewCategoria = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panBackground)).BeginInit();
            this.panBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panBotoes)).BeginInit();
            this.panBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panBottom)).BeginInit();
            this.panBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlParametros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParametros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repMemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.None;
            // 
            // panBackground
            // 
            this.panBackground.Controls.Add(this.gridControlParametros);
            this.panBackground.Controls.Add(this.panelControl1);
            this.panBackground.Controls.Add(this.gridControlCategoria);
            this.panBackground.Padding = new System.Windows.Forms.Padding(4);
            this.panBackground.Size = new System.Drawing.Size(1002, 357);
            // 
            // detalheBindingSource
            // 
            this.detalheBindingSource.DataSource = typeof(Entity.Parametro);
            // 
            // panBottom
            // 
            this.panBottom.Location = new System.Drawing.Point(6, 367);
            this.panBottom.Size = new System.Drawing.Size(1002, 33);
            this.panBottom.Visible = false;
            // 
            // panSeparadorBottom
            // 
            this.panSeparadorBottom.Location = new System.Drawing.Point(6, 363);
            this.panSeparadorBottom.Size = new System.Drawing.Size(1002, 4);
            // 
            // gridControlParametros
            // 
            this.gridControlParametros.DataSource = this.detalheBindingSource;
            this.gridControlParametros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlParametros.Location = new System.Drawing.Point(264, 6);
            this.gridControlParametros.MainView = this.gridViewParametros;
            this.gridControlParametros.MenuManager = this.barManager;
            this.gridControlParametros.Name = "gridControlParametros";
            this.gridControlParametros.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repMemo});
            this.gridControlParametros.Size = new System.Drawing.Size(732, 345);
            this.gridControlParametros.TabIndex = 3;
            this.gridControlParametros.ToolTipController = this.toolTipController;
            this.gridControlParametros.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewParametros});
            this.gridControlParametros.Click += new System.EventHandler(this.gridControlParametros_Click);
            // 
            // gridViewParametros
            // 
            this.gridViewParametros.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn1,
            this.gridColumn5,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn6});
            this.gridViewParametros.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewParametros.GridControl = this.gridControlParametros;
            this.gridViewParametros.Name = "gridViewParametros";
            this.gridViewParametros.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewParametros.OptionsBehavior.Editable = false;
            this.gridViewParametros.OptionsCustomization.AllowColumnMoving = false;
            this.gridViewParametros.OptionsCustomization.AllowColumnResizing = false;
            this.gridViewParametros.OptionsCustomization.AllowFilter = false;
            this.gridViewParametros.OptionsCustomization.AllowGroup = false;
            this.gridViewParametros.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridViewParametros.OptionsMenu.EnableColumnMenu = false;
            this.gridViewParametros.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewParametros.OptionsView.RowAutoHeight = true;
            this.gridViewParametros.OptionsView.ShowGroupPanel = false;
            this.gridViewParametros.OptionsView.ShowIndicator = false;
            this.gridViewParametros.OptionsView.ShowViewCaption = true;
            this.gridViewParametros.ViewCaption = "Parâmetros";
            this.gridViewParametros.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvwDiretivas_PopupMenuShowing);
            this.gridViewParametros.DoubleClick += new System.EventHandler(this.gvwDiretivas_DoubleClick);
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn4.Caption = "Código";
            this.gridColumn4.FieldName = "Codigo";
            this.gridColumn4.MaxWidth = 60;
            this.gridColumn4.MinWidth = 60;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 60;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn1.Caption = "Descrição";
            this.gridColumn1.ColumnEdit = this.repMemo;
            this.gridColumn1.FieldName = "Descricao";
            this.gridColumn1.MaxWidth = 330;
            this.gridColumn1.MinWidth = 330;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 330;
            // 
            // repMemo
            // 
            this.repMemo.Name = "repMemo";
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "Usuário?";
            this.gridColumn5.FieldName = "PermiteUsuario";
            this.gridColumn5.MaxWidth = 60;
            this.gridColumn5.MinWidth = 60;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 60;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Valor Padrão";
            this.gridColumn2.FieldName = "ValorPadrao";
            this.gridColumn2.MaxWidth = 180;
            this.gridColumn2.MinWidth = 180;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 180;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Valor Personalizado";
            this.gridColumn3.FieldName = "ValorPersonalizado";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 200;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "gridColumn6";
            this.gridColumn6.FieldName = "Observacao";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // barManager
            // 
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1});
            this.barManager.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(6, 6);
            this.barDockControlTop.Size = new System.Drawing.Size(1002, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(6, 400);
            this.barDockControlBottom.Size = new System.Drawing.Size(1002, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(6, 6);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 394);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1008, 6);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 394);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Parâmetros por Usuário";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiParametroUsuario_ItemClick);
            // 
            // toolTipController
            // 
            this.toolTipController.GetActiveObjectInfo += new DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(this.toolTipController_GetActiveObjectInfo);
            // 
            // popupMenu
            // 
            this.popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.popupMenu.Manager = this.barManager;
            this.popupMenu.Name = "popupMenu";
            // 
            // gridControlCategoria
            // 
            this.gridControlCategoria.DataSource = this.bindingSourceCategoria;
            this.gridControlCategoria.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControlCategoria.Location = new System.Drawing.Point(6, 6);
            this.gridControlCategoria.MainView = this.gridViewCategoria;
            this.gridControlCategoria.MenuManager = this.barManager;
            this.gridControlCategoria.Name = "gridControlCategoria";
            this.gridControlCategoria.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.gridControlCategoria.Size = new System.Drawing.Size(254, 345);
            this.gridControlCategoria.TabIndex = 13;
            this.gridControlCategoria.ToolTipController = this.toolTipController;
            this.gridControlCategoria.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCategoria});
            // 
            // bindingSourceCategoria
            // 
            this.bindingSourceCategoria.DataSource = typeof(Entity.DominioItem);
            this.bindingSourceCategoria.CurrentChanged += new System.EventHandler(this.bindingSourceCategoria_CurrentChanged);
            // 
            // gridViewCategoria
            // 
            this.gridViewCategoria.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn8});
            this.gridViewCategoria.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewCategoria.GridControl = this.gridControlCategoria;
            this.gridViewCategoria.Name = "gridViewCategoria";
            this.gridViewCategoria.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewCategoria.OptionsBehavior.Editable = false;
            this.gridViewCategoria.OptionsCustomization.AllowColumnMoving = false;
            this.gridViewCategoria.OptionsCustomization.AllowColumnResizing = false;
            this.gridViewCategoria.OptionsCustomization.AllowFilter = false;
            this.gridViewCategoria.OptionsCustomization.AllowGroup = false;
            this.gridViewCategoria.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridViewCategoria.OptionsMenu.EnableColumnMenu = false;
            this.gridViewCategoria.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewCategoria.OptionsView.RowAutoHeight = true;
            this.gridViewCategoria.OptionsView.ShowColumnHeaders = false;
            this.gridViewCategoria.OptionsView.ShowGroupPanel = false;
            this.gridViewCategoria.OptionsView.ShowIndicator = false;
            this.gridViewCategoria.OptionsView.ShowViewCaption = true;
            this.gridViewCategoria.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn8, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewCategoria.ViewCaption = "Categorias";
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn8.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn8.Caption = "Descrição";
            this.gridColumn8.ColumnEdit = this.repositoryItemMemoEdit1;
            this.gridColumn8.FieldName = "Descricao";
            this.gridColumn8.MinWidth = 80;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            this.gridColumn8.Width = 350;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(260, 6);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(4, 345);
            this.panelControl1.TabIndex = 14;
            // 
            // FrmParametroSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1014, 406);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmParametroSistema";
            this.Text = "Parâmetros do Sistema";
            this.Load += new System.EventHandler(this.FrmDiretivas_Load);
            this.Controls.SetChildIndex(this.barDockControlTop, 0);
            this.Controls.SetChildIndex(this.barDockControlBottom, 0);
            this.Controls.SetChildIndex(this.barDockControlRight, 0);
            this.Controls.SetChildIndex(this.barDockControlLeft, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControlParametros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParametros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repMemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControlParametros;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewParametros;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.PopupMenu popupMenu;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repMemo;
        private DevExpress.Utils.ToolTipController toolTipController;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControlCategoria;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCategoria;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private System.Windows.Forms.BindingSource bindingSourceCategoria;
    }
}
