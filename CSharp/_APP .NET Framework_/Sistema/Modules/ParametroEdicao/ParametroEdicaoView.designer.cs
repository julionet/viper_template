namespace VIPER.Modules.ParametroEdicao.Views
{
    partial class ParametroEdicaoView
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
            this.lbParametro = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtValorPadrao = new DevExpress.XtraEditors.TextEdit();
            this.lclPersonalizado = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
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
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorPadrao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panBackground
            // 
            this.panBackground.Controls.Add(this.panelControl1);
            this.panBackground.Controls.Add(this.panelControl2);
            this.panBackground.Padding = new System.Windows.Forms.Padding(6);
            this.panBackground.Size = new System.Drawing.Size(460, 131);
            // 
            // panBottom
            // 
            this.panBottom.Location = new System.Drawing.Point(6, 141);
            this.panBottom.Size = new System.Drawing.Size(460, 33);
            // 
            // panSeparadorBottom
            // 
            this.panSeparadorBottom.Location = new System.Drawing.Point(6, 137);
            this.panSeparadorBottom.Size = new System.Drawing.Size(460, 4);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lbParametro);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(8, 8);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(444, 34);
            this.panelControl1.TabIndex = 14;
            // 
            // lbParametro
            // 
            this.lbParametro.Location = new System.Drawing.Point(14, 10);
            this.lbParametro.Name = "lbParametro";
            this.lbParametro.Size = new System.Drawing.Size(63, 13);
            this.lbParametro.TabIndex = 2;
            this.lbParametro.Text = "labelControl1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtValorPadrao);
            this.panelControl2.Controls.Add(this.lclPersonalizado);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(8, 44);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(444, 79);
            this.panelControl2.TabIndex = 15;
            // 
            // txtValorPadrao
            // 
            this.txtValorPadrao.Enabled = false;
            this.txtValorPadrao.Location = new System.Drawing.Point(120, 11);
            this.txtValorPadrao.Name = "txtValorPadrao";
            this.txtValorPadrao.Size = new System.Drawing.Size(314, 20);
            this.txtValorPadrao.TabIndex = 2;
            // 
            // lclPersonalizado
            // 
            this.lclPersonalizado.Location = new System.Drawing.Point(20, 44);
            this.lclPersonalizado.Name = "lclPersonalizado";
            this.lclPersonalizado.Size = new System.Drawing.Size(93, 13);
            this.lclPersonalizado.TabIndex = 1;
            this.lclPersonalizado.Text = "Valor Personalizado";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(53, 14);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Valor Padrão";
            // 
            // FrmParametroEdicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(472, 180);
            this.Name = "FrmParametroEdicao";
            this.Text = "Alterar Parâmetro";
            this.Load += new System.EventHandler(this.FrmAlteraDiretiva_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorPadrao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl lclPersonalizado;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtValorPadrao;
        private DevExpress.XtraEditors.LabelControl lbParametro;

    }
}
