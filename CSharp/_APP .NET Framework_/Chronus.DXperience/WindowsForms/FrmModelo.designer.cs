namespace Chronus.DXperience
{
    partial class FrmModelo
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
            this.panBottom = new DevExpress.XtraEditors.PanelControl();
            this.panBotoes = new DevExpress.XtraEditors.PanelControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.panSeparadorBottom = new System.Windows.Forms.Panel();
            this.panBackground = new DevExpress.XtraEditors.PanelControl();
            this.detalheBindingSource = new System.Windows.Forms.BindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.panBottom)).BeginInit();
            this.panBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panBotoes)).BeginInit();
            this.panBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalheBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panBottom
            // 
            this.panBottom.Controls.Add(this.panBotoes);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(6, 197);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(434, 33);
            this.panBottom.TabIndex = 1;
            // 
            // panBotoes
            // 
            this.panBotoes.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panBotoes.Controls.Add(this.btnCancelar);
            this.panBotoes.Controls.Add(this.btnOk);
            this.panBotoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.panBotoes.Location = new System.Drawing.Point(2, 2);
            this.panBotoes.Name = "panBotoes";
            this.panBotoes.Size = new System.Drawing.Size(164, 29);
            this.panBotoes.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(85, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(4, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "&Gravar";
            // 
            // panSeparadorBottom
            // 
            this.panSeparadorBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panSeparadorBottom.Location = new System.Drawing.Point(6, 193);
            this.panSeparadorBottom.Name = "panSeparadorBottom";
            this.panSeparadorBottom.Size = new System.Drawing.Size(434, 4);
            this.panSeparadorBottom.TabIndex = 1;
            // 
            // panBackground
            // 
            this.panBackground.AllowTouchScroll = true;
            this.panBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panBackground.Location = new System.Drawing.Point(6, 6);
            this.panBackground.Name = "panBackground";
            this.panBackground.Size = new System.Drawing.Size(434, 187);
            this.panBackground.TabIndex = 0;
            // 
            // FrmModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 236);
            this.Controls.Add(this.panBackground);
            this.Controls.Add(this.panSeparadorBottom);
            this.Controls.Add(this.panBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModelo";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modelo";
            this.Load += new System.EventHandler(this.FrmModelo_Load);
            this.Shown += new System.EventHandler(this.FrmModelo_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmModelo_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panBottom)).EndInit();
            this.panBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panBotoes)).EndInit();
            this.panBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalheBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton btnCancelar;
        public DevExpress.XtraEditors.SimpleButton btnOk;
        public DevExpress.XtraEditors.PanelControl panBackground;
        public System.Windows.Forms.BindingSource detalheBindingSource;
        public DevExpress.XtraEditors.PanelControl panBotoes;
        public DevExpress.XtraEditors.PanelControl panBottom;
        public System.Windows.Forms.Panel panSeparadorBottom;
    }
}