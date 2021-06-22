namespace VIPER.Modules.Modulo.Views
{
    partial class ModuloView
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
            this.cpeCor = new DevExpress.XtraEditors.ColorPickEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tetGrupo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tetDescricao = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblSistema = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.gclFuncao = new DevExpress.XtraGrid.GridControl();
            this.funcaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvwFuncao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.btnExcluirFuncao = new DevExpress.XtraEditors.SimpleButton();
            this.btnAlterarFuncao = new DevExpress.XtraEditors.SimpleButton();
            this.btnIncluirFuncao = new DevExpress.XtraEditors.SimpleButton();
            this.petImagem = new DevExpress.XtraEditors.PictureEdit();
            this.tetCodigo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit3 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panBackground)).BeginInit();
            this.panBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panBotoes)).BeginInit();
            this.panBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panBottom)).BeginInit();
            this.panBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpeCor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gclFuncao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwFuncao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petImagem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panBackground
            // 
            this.panBackground.Controls.Add(this.checkEdit1);
            this.panBackground.Controls.Add(this.checkEdit3);
            this.panBackground.Controls.Add(this.tetCodigo);
            this.panBackground.Controls.Add(this.labelControl9);
            this.panBackground.Controls.Add(this.petImagem);
            this.panBackground.Controls.Add(this.btnExcluirFuncao);
            this.panBackground.Controls.Add(this.btnAlterarFuncao);
            this.panBackground.Controls.Add(this.btnIncluirFuncao);
            this.panBackground.Controls.Add(this.gclFuncao);
            this.panBackground.Controls.Add(this.labelControl6);
            this.panBackground.Controls.Add(this.lblSistema);
            this.panBackground.Controls.Add(this.cpeCor);
            this.panBackground.Controls.Add(this.labelControl4);
            this.panBackground.Controls.Add(this.tetGrupo);
            this.panBackground.Controls.Add(this.labelControl2);
            this.panBackground.Controls.Add(this.tetDescricao);
            this.panBackground.Controls.Add(this.labelControl1);
            this.panBackground.Size = new System.Drawing.Size(620, 413);
            // 
            // detalheBindingSource
            // 
            this.detalheBindingSource.DataSource = typeof(VIPER.Entity.Modulo);
            // 
            // panBottom
            // 
            this.panBottom.Location = new System.Drawing.Point(6, 423);
            this.panBottom.Size = new System.Drawing.Size(620, 33);
            // 
            // panSeparadorBottom
            // 
            this.panSeparadorBottom.Location = new System.Drawing.Point(6, 419);
            this.panSeparadorBottom.Size = new System.Drawing.Size(620, 4);
            // 
            // cpeCor
            // 
            this.cpeCor.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detalheBindingSource, "Cor", true));
            this.cpeCor.EditValue = System.Drawing.Color.Empty;
            this.cpeCor.Location = new System.Drawing.Point(120, 96);
            this.cpeCor.Name = "cpeCor";
            this.cpeCor.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cpeCor.Properties.AutomaticColor = System.Drawing.Color.Black;
            this.cpeCor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.cpeCor.Properties.ColorAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cpeCor.Properties.StoreColorAsInteger = true;
            this.cpeCor.Size = new System.Drawing.Size(62, 20);
            this.cpeCor.TabIndex = 2;
            this.cpeCor.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cpeCor_ButtonClick);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(97, 99);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(17, 13);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "Cor";
            // 
            // tetGrupo
            // 
            this.tetGrupo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detalheBindingSource, "Grupo", true));
            this.tetGrupo.Location = new System.Drawing.Point(120, 122);
            this.tetGrupo.Name = "tetGrupo";
            this.tetGrupo.Properties.MaxLength = 40;
            this.tetGrupo.Size = new System.Drawing.Size(350, 20);
            this.tetGrupo.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(85, 125);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Grupo";
            // 
            // tetDescricao
            // 
            this.tetDescricao.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detalheBindingSource, "Descricao", true));
            this.tetDescricao.Location = new System.Drawing.Point(120, 44);
            this.tetDescricao.Name = "tetDescricao";
            this.tetDescricao.Properties.MaxLength = 60;
            this.tetDescricao.Size = new System.Drawing.Size(350, 20);
            this.tetDescricao.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(68, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Descrição";
            // 
            // lblSistema
            // 
            this.lblSistema.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSistema.Appearance.Options.UseFont = true;
            this.lblSistema.Location = new System.Drawing.Point(120, 25);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(217, 13);
            this.lblSistema.TabIndex = 28;
            this.lblSistema.Text = "Xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(77, 25);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(37, 13);
            this.labelControl6.TabIndex = 29;
            this.labelControl6.Text = "Sistema";
            // 
            // gclFuncao
            // 
            this.gclFuncao.Cursor = System.Windows.Forms.Cursors.Default;
            this.gclFuncao.DataSource = this.funcaoBindingSource;
            this.gclFuncao.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gclFuncao.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gclFuncao.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gclFuncao.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gclFuncao.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gclFuncao.Location = new System.Drawing.Point(120, 198);
            this.gclFuncao.MainView = this.gvwFuncao;
            this.gclFuncao.Name = "gclFuncao";
            this.gclFuncao.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2,
            this.repositoryItemImageComboBox2});
            this.gclFuncao.Size = new System.Drawing.Size(479, 174);
            this.gclFuncao.TabIndex = 6;
            this.gclFuncao.TabStop = false;
            this.gclFuncao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwFuncao});
            // 
            // funcaoBindingSource
            // 
            this.funcaoBindingSource.DataSource = typeof(VIPER.Entity.Funcao);
            // 
            // gvwFuncao
            // 
            this.gvwFuncao.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn5});
            this.gvwFuncao.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvwFuncao.GridControl = this.gclFuncao;
            this.gvwFuncao.Name = "gvwFuncao";
            this.gvwFuncao.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvwFuncao.OptionsBehavior.Editable = false;
            this.gvwFuncao.OptionsCustomization.AllowColumnMoving = false;
            this.gvwFuncao.OptionsCustomization.AllowColumnResizing = false;
            this.gvwFuncao.OptionsCustomization.AllowFilter = false;
            this.gvwFuncao.OptionsCustomization.AllowGroup = false;
            this.gvwFuncao.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gvwFuncao.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gvwFuncao.OptionsMenu.EnableColumnMenu = false;
            this.gvwFuncao.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvwFuncao.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvwFuncao.OptionsView.ShowGroupPanel = false;
            this.gvwFuncao.OptionsView.ShowIndicator = false;
            this.gvwFuncao.OptionsView.ShowViewCaption = true;
            this.gvwFuncao.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn5, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvwFuncao.ViewCaption = "Funções";
            this.gvwFuncao.DoubleClick += new System.EventHandler(this.btnAlterarFuncao_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Código";
            this.gridColumn2.FieldName = "Codigo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 100;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Descrição";
            this.gridColumn5.FieldName = "Descricao";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 300;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Inactive;
            // 
            // repositoryItemImageComboBox2
            // 
            this.repositoryItemImageComboBox2.AutoHeight = false;
            this.repositoryItemImageComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox2.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Física", "F", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Jurídica", "J", -1)});
            this.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2";
            // 
            // btnExcluirFuncao
            // 
            this.btnExcluirFuncao.Location = new System.Drawing.Point(524, 378);
            this.btnExcluirFuncao.Name = "btnExcluirFuncao";
            this.btnExcluirFuncao.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirFuncao.TabIndex = 9;
            this.btnExcluirFuncao.Text = "&Excluir";
            this.btnExcluirFuncao.Click += new System.EventHandler(this.btnExcluirFuncao_Click);
            // 
            // btnAlterarFuncao
            // 
            this.btnAlterarFuncao.Location = new System.Drawing.Point(443, 378);
            this.btnAlterarFuncao.Name = "btnAlterarFuncao";
            this.btnAlterarFuncao.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarFuncao.TabIndex = 8;
            this.btnAlterarFuncao.Text = "&Alterar";
            this.btnAlterarFuncao.Click += new System.EventHandler(this.btnAlterarFuncao_Click);
            // 
            // btnIncluirFuncao
            // 
            this.btnIncluirFuncao.Location = new System.Drawing.Point(362, 378);
            this.btnIncluirFuncao.Name = "btnIncluirFuncao";
            this.btnIncluirFuncao.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirFuncao.TabIndex = 7;
            this.btnIncluirFuncao.Text = "&Incluir";
            this.btnIncluirFuncao.Click += new System.EventHandler(this.btnIncluirFuncao_Click);
            // 
            // petImagem
            // 
            this.petImagem.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detalheBindingSource, "Imagem", true));
            this.petImagem.Location = new System.Drawing.Point(488, 25);
            this.petImagem.Name = "petImagem";
            this.petImagem.Properties.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.petImagem.Properties.Appearance.Options.UseBackColor = true;
            this.petImagem.Properties.NullText = "Imagem";
            this.petImagem.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.petImagem.Size = new System.Drawing.Size(111, 117);
            this.petImagem.TabIndex = 37;
            this.petImagem.EditValueChanged += new System.EventHandler(this.petImagem_EditValueChanged);
            // 
            // tetCodigo
            // 
            this.tetCodigo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detalheBindingSource, "Codigo", true));
            this.tetCodigo.Location = new System.Drawing.Point(120, 70);
            this.tetCodigo.Name = "tetCodigo";
            this.tetCodigo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tetCodigo.Properties.MaxLength = 20;
            this.tetCodigo.Size = new System.Drawing.Size(100, 20);
            this.tetCodigo.TabIndex = 1;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(81, 73);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(33, 13);
            this.labelControl9.TabIndex = 39;
            this.labelControl9.Text = "Código";
            // 
            // checkEdit3
            // 
            this.checkEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detalheBindingSource, "Navegacao", true));
            this.checkEdit3.Location = new System.Drawing.Point(120, 173);
            this.checkEdit3.Name = "checkEdit3";
            this.checkEdit3.Properties.Caption = "Exibir na área de navegação?";
            this.checkEdit3.Size = new System.Drawing.Size(169, 20);
            this.checkEdit3.TabIndex = 5;
            // 
            // checkEdit1
            // 
            this.checkEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detalheBindingSource, "Administracao", true));
            this.checkEdit1.Location = new System.Drawing.Point(120, 148);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Módulo de administração de sistema?";
            this.checkEdit1.Size = new System.Drawing.Size(198, 20);
            this.checkEdit1.TabIndex = 4;
            // 
            // ModuloView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(632, 462);
            this.Name = "ModuloView";
            this.Text = "Módulo";
            ((System.ComponentModel.ISupportInitialize)(this.panBackground)).EndInit();
            this.panBackground.ResumeLayout(false);
            this.panBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panBotoes)).EndInit();
            this.panBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panBottom)).EndInit();
            this.panBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cpeCor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gclFuncao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwFuncao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petImagem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ColorPickEdit cpeCor;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit tetGrupo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox2;
        private DevExpress.XtraEditors.SimpleButton btnExcluirFuncao;
        private DevExpress.XtraEditors.SimpleButton btnAlterarFuncao;
        private DevExpress.XtraEditors.SimpleButton btnIncluirFuncao;
        private System.Windows.Forms.BindingSource funcaoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.TextEdit tetCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.CheckEdit checkEdit3;
        public DevExpress.XtraEditors.LabelControl lblSistema;
        public DevExpress.XtraGrid.GridControl gclFuncao;
        public DevExpress.XtraGrid.Views.Grid.GridView gvwFuncao;
        public DevExpress.XtraEditors.TextEdit tetDescricao;
        public DevExpress.XtraEditors.PictureEdit petImagem;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}
