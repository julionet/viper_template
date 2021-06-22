namespace VIPER.Modules.ConfigBanco.Views
{
    partial class ConfigBancoView
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.icbTipo = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtServidor = new DevExpress.XtraEditors.TextEdit();
            this.betBancoDados = new DevExpress.XtraEditors.ButtonEdit();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.txtSenha = new DevExpress.XtraEditors.TextEdit();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.gclBancoDados = new DevExpress.XtraEditors.GroupControl();
            this.gclServico = new DevExpress.XtraEditors.GroupControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtServico = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panBackground)).BeginInit();
            this.panBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panBotoes)).BeginInit();
            this.panBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panBottom)).BeginInit();
            this.panBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServidor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betBancoDados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gclBancoDados)).BeginInit();
            this.gclBancoDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gclServico)).BeginInit();
            this.gclServico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtServico.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Text = "&OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panBackground
            // 
            this.panBackground.Controls.Add(this.gclServico);
            this.panBackground.Controls.Add(this.gclBancoDados);
            this.panBackground.Padding = new System.Windows.Forms.Padding(6);
            this.panBackground.Size = new System.Drawing.Size(497, 262);
            // 
            // panBottom
            // 
            this.panBottom.Location = new System.Drawing.Point(6, 272);
            this.panBottom.Size = new System.Drawing.Size(497, 33);
            // 
            // panSeparadorBottom
            // 
            this.panSeparadorBottom.Location = new System.Drawing.Point(6, 268);
            this.panSeparadorBottom.Size = new System.Drawing.Size(497, 4);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(69, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(20, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tipo";
            // 
            // icbTipo
            // 
            this.icbTipo.Enabled = false;
            this.icbTipo.Location = new System.Drawing.Point(95, 34);
            this.icbTipo.Name = "icbTipo";
            this.icbTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbTipo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("SQL Server", "S", -1)});
            this.icbTipo.Size = new System.Drawing.Size(171, 20);
            this.icbTipo.TabIndex = 0;
            this.icbTipo.EditValueChanged += new System.EventHandler(this.icbTipo_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(49, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Servidor";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 90);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Banco de Dados";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(53, 116);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Usuário";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(59, 142);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(30, 13);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Senha";
            // 
            // txtServidor
            // 
            this.txtServidor.Enabled = false;
            this.txtServidor.Location = new System.Drawing.Point(95, 61);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(171, 20);
            this.txtServidor.TabIndex = 1;
            // 
            // betBancoDados
            // 
            this.betBancoDados.Enabled = false;
            this.betBancoDados.Location = new System.Drawing.Point(95, 87);
            this.betBancoDados.Name = "betBancoDados";
            this.betBancoDados.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.betBancoDados.Size = new System.Drawing.Size(363, 20);
            this.betBancoDados.TabIndex = 2;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(95, 113);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(171, 20);
            this.txtUsuario.TabIndex = 4;
            // 
            // txtSenha
            // 
            this.txtSenha.Enabled = false;
            this.txtSenha.Location = new System.Drawing.Point(95, 139);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Properties.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(171, 20);
            this.txtSenha.TabIndex = 5;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "fdb";
            this.openFileDialog.Filter = "Firebird|*.fdb";
            this.openFileDialog.Title = "Carregar Banco de Dados";
            // 
            // gclBancoDados
            // 
            this.gclBancoDados.Controls.Add(this.icbTipo);
            this.gclBancoDados.Controls.Add(this.betBancoDados);
            this.gclBancoDados.Controls.Add(this.labelControl1);
            this.gclBancoDados.Controls.Add(this.txtSenha);
            this.gclBancoDados.Controls.Add(this.labelControl2);
            this.gclBancoDados.Controls.Add(this.txtUsuario);
            this.gclBancoDados.Controls.Add(this.labelControl3);
            this.gclBancoDados.Controls.Add(this.txtServidor);
            this.gclBancoDados.Controls.Add(this.labelControl4);
            this.gclBancoDados.Controls.Add(this.labelControl5);
            this.gclBancoDados.Dock = System.Windows.Forms.DockStyle.Top;
            this.gclBancoDados.Location = new System.Drawing.Point(8, 8);
            this.gclBancoDados.Name = "gclBancoDados";
            this.gclBancoDados.Size = new System.Drawing.Size(481, 168);
            this.gclBancoDados.TabIndex = 0;
            this.gclBancoDados.Text = "Configurações do Banco de Dados";
            // 
            // gclServico
            // 
            this.gclServico.Controls.Add(this.labelControl7);
            this.gclServico.Controls.Add(this.txtServico);
            this.gclServico.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gclServico.Location = new System.Drawing.Point(8, 182);
            this.gclServico.Name = "gclServico";
            this.gclServico.Size = new System.Drawing.Size(481, 72);
            this.gclServico.TabIndex = 1;
            this.gclServico.Text = "Configurações do Serviço";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(49, 36);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(40, 13);
            this.labelControl7.TabIndex = 4;
            this.labelControl7.Text = "Servidor";
            // 
            // txtServico
            // 
            this.txtServico.Location = new System.Drawing.Point(95, 33);
            this.txtServico.Name = "txtServico";
            this.txtServico.Size = new System.Drawing.Size(363, 20);
            this.txtServico.TabIndex = 0;
            // 
            // ConfigBancoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(509, 311);
            this.Name = "ConfigBancoView";
            this.Text = "Configurações do Banco de Dados e Serviço";
            this.Load += new System.EventHandler(this.ConfigBancoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panBackground)).EndInit();
            this.panBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detalheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panBotoes)).EndInit();
            this.panBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panBottom)).EndInit();
            this.panBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icbTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServidor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betBancoDados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gclBancoDados)).EndInit();
            this.gclBancoDados.ResumeLayout(false);
            this.gclBancoDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gclServico)).EndInit();
            this.gclServico.ResumeLayout(false);
            this.gclServico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtServico.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtSenha;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.TextEdit txtServidor;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbTipo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit betBancoDados;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private DevExpress.XtraEditors.GroupControl gclServico;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtServico;
        private DevExpress.XtraEditors.GroupControl gclBancoDados;
    }
}
