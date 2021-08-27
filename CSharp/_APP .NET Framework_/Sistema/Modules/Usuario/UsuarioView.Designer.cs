namespace VIPER.Modules.Usuario.Views
{
    partial class UsuarioView
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
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ckeMaster = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ckeBloqueado = new DevExpress.XtraEditors.CheckEdit();
            this.ckeAdministrador = new DevExpress.XtraEditors.CheckEdit();
            this.ckeAlterarSenha = new DevExpress.XtraEditors.CheckEdit();
            this.ckeNuncaExpira = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cetDias = new DevExpress.XtraEditors.CalcEdit();
            this.txtLogin = new DevExpress.XtraEditors.TextEdit();
            this.txtNome = new DevExpress.XtraEditors.TextEdit();
            this.txtSenha = new DevExpress.XtraEditors.TextEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.pclBotoesAcesso)).BeginInit();
            this.pclBotoesAcesso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gclPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwAcesso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeMaster.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeBloqueado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeAdministrador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeAlterarSenha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeNuncaExpira.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cetDias.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pclAcesso
            // 
            this.pclAcesso.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pclAcesso.Appearance.Options.UseBackColor = true;
            this.pclAcesso.Controls.Add(this.gclPrincipal);
            this.pclAcesso.Size = new System.Drawing.Size(874, 446);
            // 
            // pclAcessoBottom
            // 
            this.pclAcessoBottom.Size = new System.Drawing.Size(874, 0);
            // 
            // xtpManutencao
            // 
            this.xtpManutencao.Size = new System.Drawing.Size(874, 519);
            // 
            // pclManutencao
            // 
            this.pclManutencao.Size = new System.Drawing.Size(874, 484);
            // 
            // txtPesquisa
            // 
            // 
            // principalBindingSource
            // 
            this.principalBindingSource.DataSource = typeof(VIPER.Entity.Usuario);
            // 
            // xtcPaginas
            // 
            this.xtcPaginas.SelectedTabPage = this.xtpAcesso;
            this.xtcPaginas.Size = new System.Drawing.Size(874, 519);
            // 
            // xtpAcesso
            // 
            this.xtpAcesso.Size = new System.Drawing.Size(874, 519);
            // 
            // pclBotoesManutencao
            // 
            this.pclBotoesManutencao.Location = new System.Drawing.Point(0, 488);
            this.pclBotoesManutencao.Size = new System.Drawing.Size(874, 31);
            // 
            // pclPesquisar
            // 
            this.pclPesquisar.Size = new System.Drawing.Size(874, 35);
            // 
            // xscManutencao
            // 
            this.xscManutencao.Controls.Add(this.txtLogin);
            this.xscManutencao.Controls.Add(this.ckeNuncaExpira);
            this.xscManutencao.Controls.Add(this.txtSenha);
            this.xscManutencao.Controls.Add(this.labelControl4);
            this.xscManutencao.Controls.Add(this.labelControl1);
            this.xscManutencao.Controls.Add(this.ckeAlterarSenha);
            this.xscManutencao.Controls.Add(this.txtNome);
            this.xscManutencao.Controls.Add(this.labelControl5);
            this.xscManutencao.Controls.Add(this.ckeMaster);
            this.xscManutencao.Controls.Add(this.ckeAdministrador);
            this.xscManutencao.Controls.Add(this.labelControl2);
            this.xscManutencao.Controls.Add(this.ckeBloqueado);
            this.xscManutencao.Controls.Add(this.cetDias);
            this.xscManutencao.Controls.Add(this.labelControl3);
            this.xscManutencao.Size = new System.Drawing.Size(870, 480);
            // 
            // pclSeparadorAcesso
            // 
            this.pclSeparadorAcesso.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pclSeparadorAcesso.Appearance.Options.UseBackColor = true;
            this.pclSeparadorAcesso.Size = new System.Drawing.Size(874, 4);
            // 
            // pclBotoesAcesso
            // 
            this.pclBotoesAcesso.Size = new System.Drawing.Size(874, 34);
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
            this.gclPrincipal.Size = new System.Drawing.Size(874, 443);
            this.gclPrincipal.TabIndex = 14;
            this.gclPrincipal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwAcesso});
            // 
            // gvwAcesso
            // 
            this.gvwAcesso.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn5,
            this.gridColumn4,
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
            this.gvwAcesso.OptionsMenu.EnableColumnMenu = false;
            this.gvwAcesso.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvwAcesso.OptionsView.ColumnAutoWidth = false;
            this.gvwAcesso.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvwAcesso.OptionsView.ShowGroupPanel = false;
            this.gvwAcesso.OptionsView.ShowIndicator = false;
            this.gvwAcesso.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn2, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvwAcesso.DoubleClick += new System.EventHandler(this.gvwAcesso_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Identificação";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 90;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Login";
            this.gridColumn2.FieldName = "Login";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 120;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Nome";
            this.gridColumn5.FieldName = "Nome";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 300;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "Master?";
            this.gridColumn4.FieldName = "Master";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 70;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Bloqueado?";
            this.gridColumn3.FieldName = "Bloqueado";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 80;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(66, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Login";
            // 
            // ckeMaster
            // 
            this.ckeMaster.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.principalBindingSource, "Master", true));
            this.ckeMaster.Location = new System.Drawing.Point(97, 99);
            this.ckeMaster.Name = "ckeMaster";
            this.ckeMaster.Properties.Caption = "Master?";
            this.ckeMaster.Size = new System.Drawing.Size(75, 20);
            this.ckeMaster.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(64, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Nome";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(61, 76);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Senha";
            // 
            // ckeBloqueado
            // 
            this.ckeBloqueado.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.principalBindingSource, "Bloqueado", true));
            this.ckeBloqueado.Location = new System.Drawing.Point(97, 124);
            this.ckeBloqueado.Name = "ckeBloqueado";
            this.ckeBloqueado.Properties.Caption = "Bloqueado?";
            this.ckeBloqueado.Size = new System.Drawing.Size(75, 20);
            this.ckeBloqueado.TabIndex = 4;
            // 
            // ckeAdministrador
            // 
            this.ckeAdministrador.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.principalBindingSource, "Administrador", true));
            this.ckeAdministrador.Location = new System.Drawing.Point(97, 149);
            this.ckeAdministrador.Name = "ckeAdministrador";
            this.ckeAdministrador.Properties.Caption = "Administrador?";
            this.ckeAdministrador.Size = new System.Drawing.Size(100, 20);
            this.ckeAdministrador.TabIndex = 5;
            // 
            // ckeAlterarSenha
            // 
            this.ckeAlterarSenha.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.principalBindingSource, "AlterarSenha", true));
            this.ckeAlterarSenha.Location = new System.Drawing.Point(97, 174);
            this.ckeAlterarSenha.Name = "ckeAlterarSenha";
            this.ckeAlterarSenha.Properties.Caption = "Alterar senha no próximo login?";
            this.ckeAlterarSenha.Size = new System.Drawing.Size(175, 20);
            this.ckeAlterarSenha.TabIndex = 6;
            // 
            // ckeNuncaExpira
            // 
            this.ckeNuncaExpira.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.principalBindingSource, "NuncaExpira", true));
            this.ckeNuncaExpira.Location = new System.Drawing.Point(97, 199);
            this.ckeNuncaExpira.Name = "ckeNuncaExpira";
            this.ckeNuncaExpira.Properties.Caption = "Senha nunca expira?";
            this.ckeNuncaExpira.Size = new System.Drawing.Size(122, 20);
            this.ckeNuncaExpira.TabIndex = 7;
            this.ckeNuncaExpira.CheckedChanged += new System.EventHandler(this.ckeNuncaExpira_CheckedChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(9, 228);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(82, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Tempo Expiração";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(162, 228);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(27, 13);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "dia(s)";
            // 
            // cetDias
            // 
            this.cetDias.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.principalBindingSource, "DiasExpirar", true));
            this.cetDias.Location = new System.Drawing.Point(97, 225);
            this.cetDias.Name = "cetDias";
            this.cetDias.Properties.Appearance.Options.UseTextOptions = true;
            this.cetDias.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.cetDias.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cetDias.Properties.Mask.EditMask = "n0";
            this.cetDias.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.cetDias.Properties.MaxLength = 13;
            this.cetDias.Size = new System.Drawing.Size(59, 20);
            this.cetDias.TabIndex = 8;
            // 
            // txtLogin
            // 
            this.txtLogin.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.principalBindingSource, "Login", true));
            this.txtLogin.Location = new System.Drawing.Point(97, 21);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLogin.Properties.MaxLength = 25;
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.principalBindingSource, "Nome", true));
            this.txtNome.Location = new System.Drawing.Point(97, 47);
            this.txtNome.Name = "txtNome";
            this.txtNome.Properties.MaxLength = 40;
            this.txtNome.Size = new System.Drawing.Size(332, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.principalBindingSource, "Senha", true));
            this.txtSenha.Location = new System.Drawing.Point(97, 73);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Properties.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(332, 20);
            this.txtSenha.TabIndex = 2;
            // 
            // UsuarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(886, 531);
            this.FirstControl = this.txtLogin;
            this.Name = "UsuarioView";
            this.Text = "Usuários";
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
            ((System.ComponentModel.ISupportInitialize)(this.pclBotoesAcesso)).EndInit();
            this.pclBotoesAcesso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gclPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwAcesso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeMaster.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeBloqueado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeAdministrador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeAlterarSenha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeNuncaExpira.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cetDias.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gclPrincipal;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwAcesso;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.CheckEdit ckeAdministrador;
        private DevExpress.XtraEditors.CheckEdit ckeBloqueado;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit ckeMaster;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CheckEdit ckeAlterarSenha;
        private DevExpress.XtraEditors.TextEdit txtSenha;
        private DevExpress.XtraEditors.TextEdit txtNome;
        private DevExpress.XtraEditors.TextEdit txtLogin;
        public DevExpress.XtraEditors.CheckEdit ckeNuncaExpira;
        public DevExpress.XtraEditors.CalcEdit cetDias;
    }
}
