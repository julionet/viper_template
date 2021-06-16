namespace VIPER.Modules.ImportaRelatorio.Views
{
    partial class ImportaRelatorioView
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
            this.betArquivo = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.clbcRelatorios = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.panBackground)).BeginInit();
            this.panBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panBotoes)).BeginInit();
            this.panBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panBottom)).BeginInit();
            this.panBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betArquivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clbcRelatorios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Visible = false;
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Text = "&Importar";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panBackground
            // 
            this.panBackground.Controls.Add(this.panelControl2);
            this.panBackground.Controls.Add(this.panelControl1);
            this.panBackground.Padding = new System.Windows.Forms.Padding(3);
            this.panBackground.Size = new System.Drawing.Size(655, 309);
            // 
            // panBottom
            // 
            this.panBottom.Location = new System.Drawing.Point(6, 319);
            this.panBottom.Size = new System.Drawing.Size(655, 33);
            // 
            // panSeparadorBottom
            // 
            this.panSeparadorBottom.Location = new System.Drawing.Point(6, 315);
            this.panSeparadorBottom.Size = new System.Drawing.Size(655, 4);
            // 
            // betArquivo
            // 
            this.betArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.betArquivo.Location = new System.Drawing.Point(0, 25);
            this.betArquivo.Name = "betArquivo";
            this.betArquivo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.betArquivo.Properties.ReadOnly = true;
            this.betArquivo.Size = new System.Drawing.Size(645, 20);
            this.betArquivo.TabIndex = 0;
            this.betArquivo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.betArquivo_ButtonClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(0, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(233, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Selecione arquivo para importação dos relatórios";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.betArquivo);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(5, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(645, 53);
            this.panelControl1.TabIndex = 2;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.clbcRelatorios);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(5, 58);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(645, 246);
            this.panelControl2.TabIndex = 3;
            // 
            // clbcRelatorios
            // 
            this.clbcRelatorios.CheckOnClick = true;
            this.clbcRelatorios.Cursor = System.Windows.Forms.Cursors.Default;
            this.clbcRelatorios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbcRelatorios.Location = new System.Drawing.Point(0, 0);
            this.clbcRelatorios.Name = "clbcRelatorios";
            this.clbcRelatorios.Size = new System.Drawing.Size(645, 246);
            this.clbcRelatorios.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "report";
            this.openFileDialog.Filter = "Relatórios|*.xml";
            this.openFileDialog.Title = "Carregar Relatórios";
            // 
            // FrmImportarRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(667, 358);
            this.Name = "FrmImportarRelatorio";
            this.Text = "Importar Relatórios";
            ((System.ComponentModel.ISupportInitialize)(this.panBackground)).EndInit();
            this.panBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detalheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panBotoes)).EndInit();
            this.panBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panBottom)).EndInit();
            this.panBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.betArquivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clbcRelatorios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.CheckedListBoxControl clbcRelatorios;
        public DevExpress.XtraEditors.ButtonEdit betArquivo;
        public System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
