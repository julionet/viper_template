namespace VIPER.Modules.AlteraSenha.Views
{
    partial class AlteraSenhaView
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
            this.lblConfirmacao = new DevExpress.XtraEditors.LabelControl();
            this.lblNovaSenha = new DevExpress.XtraEditors.LabelControl();
            this.lblSenhaAntiga = new DevExpress.XtraEditors.LabelControl();
            this.lblUsuarioConectado = new DevExpress.XtraEditors.LabelControl();
            this.txtConfirmacao = new DevExpress.XtraEditors.TextEdit();
            this.txtNovaSenha = new DevExpress.XtraEditors.TextEdit();
            this.txtSenhaAntiga = new DevExpress.XtraEditors.TextEdit();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panBackground)).BeginInit();
            this.panBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panBotoes)).BeginInit();
            this.panBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panBottom)).BeginInit();
            this.panBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNovaSenha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenhaAntiga.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.TabIndex = 0;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panBackground
            // 
            this.panBackground.Controls.Add(this.lblConfirmacao);
            this.panBackground.Controls.Add(this.lblNovaSenha);
            this.panBackground.Controls.Add(this.lblSenhaAntiga);
            this.panBackground.Controls.Add(this.lblUsuarioConectado);
            this.panBackground.Controls.Add(this.txtConfirmacao);
            this.panBackground.Controls.Add(this.txtNovaSenha);
            this.panBackground.Controls.Add(this.txtSenhaAntiga);
            this.panBackground.Controls.Add(this.txtUsuario);
            this.panBackground.Size = new System.Drawing.Size(341, 136);
            this.panBackground.TabIndex = 0;
            // 
            // panBottom
            // 
            this.panBottom.Location = new System.Drawing.Point(6, 146);
            this.panBottom.Size = new System.Drawing.Size(341, 33);
            this.panBottom.TabIndex = 1;
            // 
            // panSeparadorBottom
            // 
            this.panSeparadorBottom.Location = new System.Drawing.Point(6, 142);
            this.panSeparadorBottom.Size = new System.Drawing.Size(341, 4);
            // 
            // lblConfirmacao
            // 
            this.lblConfirmacao.Location = new System.Drawing.Point(19, 103);
            this.lblConfirmacao.Name = "lblConfirmacao";
            this.lblConfirmacao.Size = new System.Drawing.Size(60, 13);
            this.lblConfirmacao.TabIndex = 15;
            this.lblConfirmacao.Text = "Confirmação";
            // 
            // lblNovaSenha
            // 
            this.lblNovaSenha.Location = new System.Drawing.Point(21, 76);
            this.lblNovaSenha.Name = "lblNovaSenha";
            this.lblNovaSenha.Size = new System.Drawing.Size(58, 13);
            this.lblNovaSenha.TabIndex = 14;
            this.lblNovaSenha.Text = "Nova Senha";
            // 
            // lblSenhaAntiga
            // 
            this.lblSenhaAntiga.Location = new System.Drawing.Point(15, 49);
            this.lblSenhaAntiga.Name = "lblSenhaAntiga";
            this.lblSenhaAntiga.Size = new System.Drawing.Size(64, 13);
            this.lblSenhaAntiga.TabIndex = 13;
            this.lblSenhaAntiga.Text = "Senha Antiga";
            // 
            // lblUsuarioConectado
            // 
            this.lblUsuarioConectado.Location = new System.Drawing.Point(43, 22);
            this.lblUsuarioConectado.Name = "lblUsuarioConectado";
            this.lblUsuarioConectado.Size = new System.Drawing.Size(36, 13);
            this.lblUsuarioConectado.TabIndex = 12;
            this.lblUsuarioConectado.Text = "Usuário";
            // 
            // txtConfirmacao
            // 
            this.txtConfirmacao.Location = new System.Drawing.Point(85, 100);
            this.txtConfirmacao.Name = "txtConfirmacao";
            this.txtConfirmacao.Properties.MaxLength = 10;
            this.txtConfirmacao.Properties.PasswordChar = '*';
            this.txtConfirmacao.Size = new System.Drawing.Size(214, 20);
            this.txtConfirmacao.TabIndex = 3;
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Location = new System.Drawing.Point(85, 73);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Properties.MaxLength = 10;
            this.txtNovaSenha.Properties.PasswordChar = '*';
            this.txtNovaSenha.Size = new System.Drawing.Size(214, 20);
            this.txtNovaSenha.TabIndex = 2;
            // 
            // txtSenhaAntiga
            // 
            this.txtSenhaAntiga.Location = new System.Drawing.Point(85, 46);
            this.txtSenhaAntiga.Name = "txtSenhaAntiga";
            this.txtSenhaAntiga.Properties.MaxLength = 10;
            this.txtSenhaAntiga.Properties.PasswordChar = '*';
            this.txtSenhaAntiga.Size = new System.Drawing.Size(214, 20);
            this.txtSenhaAntiga.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(85, 19);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.MaxLength = 20;
            this.txtUsuario.Properties.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(214, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // FrmAlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(353, 185);
            this.Name = "FrmAlterarSenha";
            this.Text = "Alterar senha";
            this.Load += new System.EventHandler(this.FrmAlterarSenha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panBackground)).EndInit();
            this.panBackground.ResumeLayout(false);
            this.panBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panBotoes)).EndInit();
            this.panBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panBottom)).EndInit();
            this.panBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNovaSenha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenhaAntiga.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblConfirmacao;
        private DevExpress.XtraEditors.LabelControl lblNovaSenha;
        private DevExpress.XtraEditors.LabelControl lblSenhaAntiga;
        private DevExpress.XtraEditors.LabelControl lblUsuarioConectado;
        private DevExpress.XtraEditors.TextEdit txtConfirmacao;
        private DevExpress.XtraEditors.TextEdit txtNovaSenha;
        private DevExpress.XtraEditors.TextEdit txtSenhaAntiga;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
    }
}
