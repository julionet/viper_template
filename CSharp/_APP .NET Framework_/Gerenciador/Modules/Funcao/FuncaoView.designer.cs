namespace VIPER.Modules.Funcao.Views
{
    partial class FuncaoView
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
            this.letRelatorio = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cetAtivo = new DevExpress.XtraEditors.CheckEdit();
            this.tetNomeFormulario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.tetNomeAssembly = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.icbTipo = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tetDescricao = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblModulo = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.tetCodigo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.letDashboard = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panBackground)).BeginInit();
            this.panBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panBotoes)).BeginInit();
            this.panBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panBottom)).BeginInit();
            this.panBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.letRelatorio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cetAtivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetNomeFormulario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetNomeAssembly.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letDashboard.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panBackground
            // 
            this.panBackground.Controls.Add(this.letDashboard);
            this.panBackground.Controls.Add(this.labelControl5);
            this.panBackground.Controls.Add(this.tetCodigo);
            this.panBackground.Controls.Add(this.labelControl10);
            this.panBackground.Controls.Add(this.labelControl6);
            this.panBackground.Controls.Add(this.lblModulo);
            this.panBackground.Controls.Add(this.letRelatorio);
            this.panBackground.Controls.Add(this.labelControl8);
            this.panBackground.Controls.Add(this.cetAtivo);
            this.panBackground.Controls.Add(this.tetNomeFormulario);
            this.panBackground.Controls.Add(this.labelControl7);
            this.panBackground.Controls.Add(this.tetNomeAssembly);
            this.panBackground.Controls.Add(this.labelControl4);
            this.panBackground.Controls.Add(this.icbTipo);
            this.panBackground.Controls.Add(this.labelControl3);
            this.panBackground.Controls.Add(this.textEdit1);
            this.panBackground.Controls.Add(this.labelControl2);
            this.panBackground.Controls.Add(this.tetDescricao);
            this.panBackground.Controls.Add(this.labelControl1);
            this.panBackground.Size = new System.Drawing.Size(514, 301);
            // 
            // detalheBindingSource
            // 
            this.detalheBindingSource.DataSource = typeof(VIPER.Entity.Funcao);
            // 
            // panBottom
            // 
            this.panBottom.Location = new System.Drawing.Point(6, 311);
            this.panBottom.Size = new System.Drawing.Size(514, 33);
            // 
            // panSeparadorBottom
            // 
            this.panSeparadorBottom.Location = new System.Drawing.Point(6, 307);
            this.panSeparadorBottom.Size = new System.Drawing.Size(514, 4);
            // 
            // letRelatorio
            // 
            this.letRelatorio.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detalheBindingSource, "RelatorioId", true));
            this.letRelatorio.Location = new System.Drawing.Point(120, 200);
            this.letRelatorio.Name = "letRelatorio";
            this.letRelatorio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.letRelatorio.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome")});
            this.letRelatorio.Properties.DisplayMember = "Nome";
            this.letRelatorio.Properties.NullText = "";
            this.letRelatorio.Properties.ShowFooter = false;
            this.letRelatorio.Properties.ShowHeader = false;
            this.letRelatorio.Properties.ShowLines = false;
            this.letRelatorio.Properties.ValueMember = "Id";
            this.letRelatorio.Size = new System.Drawing.Size(350, 20);
            this.letRelatorio.TabIndex = 6;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(71, 203);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(43, 13);
            this.labelControl8.TabIndex = 48;
            this.labelControl8.Text = "Relatório";
            // 
            // cetAtivo
            // 
            this.cetAtivo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detalheBindingSource, "Manutencao", true));
            this.cetAtivo.Location = new System.Drawing.Point(120, 252);
            this.cetAtivo.Name = "cetAtivo";
            this.cetAtivo.Properties.Caption = "Controla Manutenção?";
            this.cetAtivo.Size = new System.Drawing.Size(134, 20);
            this.cetAtivo.TabIndex = 8;
            // 
            // tetNomeFormulario
            // 
            this.tetNomeFormulario.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detalheBindingSource, "NomeFormulario", true));
            this.tetNomeFormulario.Location = new System.Drawing.Point(120, 174);
            this.tetNomeFormulario.Name = "tetNomeFormulario";
            this.tetNomeFormulario.Properties.MaxLength = 60;
            this.tetNomeFormulario.Size = new System.Drawing.Size(350, 20);
            this.tetNomeFormulario.TabIndex = 5;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(34, 177);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(80, 13);
            this.labelControl7.TabIndex = 43;
            this.labelControl7.Text = "Nome Formulário";
            // 
            // tetNomeAssembly
            // 
            this.tetNomeAssembly.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detalheBindingSource, "NomeAssembly", true));
            this.tetNomeAssembly.Location = new System.Drawing.Point(120, 148);
            this.tetNomeAssembly.Name = "tetNomeAssembly";
            this.tetNomeAssembly.Properties.MaxLength = 60;
            this.tetNomeAssembly.Size = new System.Drawing.Size(350, 20);
            this.tetNomeAssembly.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(39, 151);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 13);
            this.labelControl4.TabIndex = 41;
            this.labelControl4.Text = "Nome Assembly";
            // 
            // icbTipo
            // 
            this.icbTipo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detalheBindingSource, "Tipo", true));
            this.icbTipo.Location = new System.Drawing.Point(120, 122);
            this.icbTipo.Name = "icbTipo";
            this.icbTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbTipo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Dashboard", "D", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Formulário", "F", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Relatório", "R", -1)});
            this.icbTipo.Size = new System.Drawing.Size(100, 20);
            this.icbTipo.TabIndex = 3;
            this.icbTipo.EditValueChanged += new System.EventHandler(this.icbTipo_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(94, 125);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(20, 13);
            this.labelControl3.TabIndex = 38;
            this.labelControl3.Text = "Tipo";
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detalheBindingSource, "Grupo", true));
            this.textEdit1.Location = new System.Drawing.Point(120, 96);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.MaxLength = 40;
            this.textEdit1.Size = new System.Drawing.Size(350, 20);
            this.textEdit1.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(85, 99);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 37;
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
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "Descrição";
            // 
            // lblModulo
            // 
            this.lblModulo.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblModulo.Appearance.Options.UseFont = true;
            this.lblModulo.Location = new System.Drawing.Point(120, 25);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(238, 13);
            this.lblModulo.TabIndex = 50;
            this.lblModulo.Text = "Xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(80, 25);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(34, 13);
            this.labelControl6.TabIndex = 51;
            this.labelControl6.Text = "Módulo";
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
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(85, 73);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(33, 13);
            this.labelControl10.TabIndex = 60;
            this.labelControl10.Text = "Código";
            // 
            // letDashboard
            // 
            this.letDashboard.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detalheBindingSource, "DashboardId", true));
            this.letDashboard.Location = new System.Drawing.Point(120, 226);
            this.letDashboard.Name = "letDashboard";
            this.letDashboard.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.letDashboard.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome")});
            this.letDashboard.Properties.DisplayMember = "Nome";
            this.letDashboard.Properties.NullText = "";
            this.letDashboard.Properties.ShowFooter = false;
            this.letDashboard.Properties.ShowHeader = false;
            this.letDashboard.Properties.ShowLines = false;
            this.letDashboard.Properties.ValueMember = "Id";
            this.letDashboard.Size = new System.Drawing.Size(350, 20);
            this.letDashboard.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(62, 229);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 13);
            this.labelControl5.TabIndex = 62;
            this.labelControl5.Text = "Dashboard";
            // 
            // FuncaoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(526, 350);
            this.Name = "FuncaoView";
            this.Text = "Função";
            this.Load += new System.EventHandler(this.FuncaoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panBackground)).EndInit();
            this.panBackground.ResumeLayout(false);
            this.panBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panBotoes)).EndInit();
            this.panBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panBottom)).EndInit();
            this.panBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.letRelatorio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cetAtivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetNomeFormulario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetNomeAssembly.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letDashboard.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.CheckEdit cetAtivo;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tetDescricao;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tetCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        public DevExpress.XtraEditors.LookUpEdit letRelatorio;
        public DevExpress.XtraEditors.LabelControl lblModulo;
        public DevExpress.XtraEditors.TextEdit tetNomeFormulario;
        public DevExpress.XtraEditors.TextEdit tetNomeAssembly;
        public DevExpress.XtraEditors.ImageComboBoxEdit icbTipo;
        public DevExpress.XtraEditors.LookUpEdit letDashboard;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}
