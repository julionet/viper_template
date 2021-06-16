namespace VIPER.Modules.Login.Views
{
    partial class LoginView
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.lblCopyright = new System.Windows.Forms.Label();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.txtSenha = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnIniciar = new DevExpress.XtraEditors.SimpleButton();
            this.pclLogin = new DevExpress.XtraEditors.PanelControl();
            this.lblConfiguracao = new DevExpress.XtraEditors.LabelControl();
            this.lclSistema = new DevExpress.XtraEditors.LabelControl();
            this.pbxLogotipo = new System.Windows.Forms.PictureBox();
            this.letSistema = new DevExpress.XtraEditors.LookUpEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lblFechar = new DevExpress.XtraEditors.LabelControl();
            this.pcbFechar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclLogin)).BeginInit();
            this.pclLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogotipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letSistema.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCopyright.ForeColor = System.Drawing.Color.White;
            this.lblCopyright.Location = new System.Drawing.Point(4, 512);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(942, 40);
            this.lblCopyright.TabIndex = 0;
            this.lblCopyright.Text = "Copyright © __ORGANIZATIONNAME__";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(8, 175);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(329, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(8, 220);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Properties.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(329, 20);
            this.txtSenha.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(8, 156);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Usuário";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(8, 201);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Senha";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(259, 292);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(78, 24);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "&Iniciar";
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // pclLogin
            // 
            this.pclLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pclLogin.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pclLogin.Appearance.Options.UseBackColor = true;
            this.pclLogin.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pclLogin.Controls.Add(this.lblConfiguracao);
            this.pclLogin.Controls.Add(this.btnIniciar);
            this.pclLogin.Controls.Add(this.lclSistema);
            this.pclLogin.Controls.Add(this.pbxLogotipo);
            this.pclLogin.Controls.Add(this.txtUsuario);
            this.pclLogin.Controls.Add(this.labelControl1);
            this.pclLogin.Controls.Add(this.labelControl2);
            this.pclLogin.Controls.Add(this.txtSenha);
            this.pclLogin.Controls.Add(this.letSistema);
            this.pclLogin.Location = new System.Drawing.Point(321, 93);
            this.pclLogin.Name = "pclLogin";
            this.pclLogin.Size = new System.Drawing.Size(345, 388);
            this.pclLogin.TabIndex = 11;
            // 
            // lblConfiguracao
            // 
            this.lblConfiguracao.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.lblConfiguracao.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblConfiguracao.Appearance.Options.UseFont = true;
            this.lblConfiguracao.Appearance.Options.UseForeColor = true;
            this.lblConfiguracao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblConfiguracao.Location = new System.Drawing.Point(8, 303);
            this.lblConfiguracao.Name = "lblConfiguracao";
            this.lblConfiguracao.Size = new System.Drawing.Size(159, 13);
            this.lblConfiguracao.TabIndex = 13;
            this.lblConfiguracao.Text = "Configuração do Banco de Dados";
            this.lblConfiguracao.Click += new System.EventHandler(this.lblConfiguracao_Click);
            // 
            // lclSistema
            // 
            this.lclSistema.Appearance.ForeColor = System.Drawing.Color.White;
            this.lclSistema.Appearance.Options.UseForeColor = true;
            this.lclSistema.Location = new System.Drawing.Point(8, 246);
            this.lclSistema.Name = "lclSistema";
            this.lclSistema.Size = new System.Drawing.Size(37, 13);
            this.lclSistema.TabIndex = 12;
            this.lclSistema.Text = "Sistema";
            // 
            // pbxLogotipo
            // 
            this.pbxLogotipo.ErrorImage = null;
            this.pbxLogotipo.InitialImage = null;
            this.pbxLogotipo.Location = new System.Drawing.Point(3, 3);
            this.pbxLogotipo.Name = "pbxLogotipo";
            this.pbxLogotipo.Size = new System.Drawing.Size(339, 83);
            this.pbxLogotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogotipo.TabIndex = 6;
            this.pbxLogotipo.TabStop = false;
            // 
            // letSistema
            // 
            this.letSistema.Location = new System.Drawing.Point(8, 265);
            this.letSistema.Name = "letSistema";
            this.letSistema.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.letSistema.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", "Descricao")});
            this.letSistema.Properties.DisplayMember = "Descricao";
            this.letSistema.Properties.NullText = "";
            this.letSistema.Properties.ShowFooter = false;
            this.letSistema.Properties.ShowHeader = false;
            this.letSistema.Properties.ShowLines = false;
            this.letSistema.Properties.ValueMember = "Id";
            this.letSistema.Size = new System.Drawing.Size(329, 20);
            this.letSistema.TabIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(4, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(942, 57);
            this.panelControl1.TabIndex = 12;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.lblFechar);
            this.panelControl2.Controls.Add(this.pcbFechar);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(899, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(43, 57);
            this.panelControl2.TabIndex = 0;
            // 
            // lblFechar
            // 
            this.lblFechar.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblFechar.Appearance.Options.UseForeColor = true;
            this.lblFechar.Appearance.Options.UseTextOptions = true;
            this.lblFechar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblFechar.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFechar.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFechar.Location = new System.Drawing.Point(0, 42);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(43, 13);
            this.lblFechar.TabIndex = 1;
            this.lblFechar.Text = "Fechar";
            this.lblFechar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pcbFechar
            // 
            this.pcbFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbFechar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcbFechar.Image = global::VIPER.WFA.Properties.Resources.Sair_Metro;
            this.pcbFechar.Location = new System.Drawing.Point(0, 0);
            this.pcbFechar.Name = "pcbFechar";
            this.pcbFechar.Size = new System.Drawing.Size(43, 42);
            this.pcbFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbFechar.TabIndex = 0;
            this.pcbFechar.TabStop = false;
            this.pcbFechar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LoginView
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(254)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(950, 556);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.pclLogin);
            this.Controls.Add(this.lblCopyright);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("LoginView.IconOptions.Icon")));
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginView";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "__APPNAME__";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclLogin)).EndInit();
            this.pclLogin.ResumeLayout(false);
            this.pclLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogotipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letSistema.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCopyright;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.TextEdit txtSenha;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnIniciar;
        private System.Windows.Forms.PictureBox pbxLogotipo;
        private DevExpress.XtraEditors.PanelControl pclLogin;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.PictureBox pcbFechar;
        private DevExpress.XtraEditors.LabelControl lblFechar;
        private DevExpress.XtraEditors.LabelControl lclSistema;
        private DevExpress.XtraEditors.LookUpEdit letSistema;
        private DevExpress.XtraEditors.LabelControl lblConfiguracao;
    }
}