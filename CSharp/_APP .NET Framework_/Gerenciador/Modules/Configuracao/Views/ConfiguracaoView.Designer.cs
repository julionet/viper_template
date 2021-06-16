namespace VIPER.Modules.Configuracao.Views
{
    partial class ConfiguracaoView
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
            this.ckeEnter = new DevExpress.XtraEditors.CheckEdit();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cetTamanhoFonte = new DevExpress.XtraEditors.CalcEdit();
            this.cbeSkinName = new DevExpress.XtraEditors.ImageComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panBackground)).BeginInit();
            this.panBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panBotoes)).BeginInit();
            this.panBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panBottom)).BeginInit();
            this.panBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckeEnter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cetTamanhoFonte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeSkinName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnOk
            // 
            this.btnOk.TabIndex = 0;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panBackground
            // 
            this.panBackground.Controls.Add(this.cbeSkinName);
            this.panBackground.Controls.Add(this.cetTamanhoFonte);
            this.panBackground.Controls.Add(this.labelControl4);
            this.panBackground.Controls.Add(this.labelControl3);
            this.panBackground.Controls.Add(this.ckeEnter);
            this.panBackground.Controls.Add(this.labelControl1);
            this.panBackground.Size = new System.Drawing.Size(669, 281);
            this.panBackground.TabIndex = 0;
            // 
            // panBottom
            // 
            this.panBottom.Location = new System.Drawing.Point(6, 291);
            this.panBottom.Size = new System.Drawing.Size(669, 33);
            // 
            // panSeparadorBottom
            // 
            this.panSeparadorBottom.Location = new System.Drawing.Point(6, 287);
            this.panSeparadorBottom.Size = new System.Drawing.Size(669, 4);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(89, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(19, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Skin";
            // 
            // ckeEnter
            // 
            this.ckeEnter.Location = new System.Drawing.Point(114, 71);
            this.ckeEnter.Name = "ckeEnter";
            this.ckeEnter.Properties.Caption = "Utilizar ENTER para mudança de campos?";
            this.ckeEnter.Size = new System.Drawing.Size(224, 20);
            this.ckeEnter.TabIndex = 3;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Todos Arquivos|*.*";
            this.openFileDialog.Title = "Selecionar Arquivo de Log";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(114, 112);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(282, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "(para aplicar as alterações é necessário reiniciar o sistema)";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(18, 48);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(90, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Tamanho da Fonte";
            // 
            // cetTamanhoFonte
            // 
            this.cetTamanhoFonte.Location = new System.Drawing.Point(114, 45);
            this.cetTamanhoFonte.Name = "cetTamanhoFonte";
            this.cetTamanhoFonte.Properties.Mask.EditMask = "n2";
            this.cetTamanhoFonte.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.cetTamanhoFonte.Size = new System.Drawing.Size(65, 20);
            this.cetTamanhoFonte.TabIndex = 2;
            // 
            // cbeSkinName
            // 
            this.cbeSkinName.Location = new System.Drawing.Point(114, 19);
            this.cbeSkinName.Name = "cbeSkinName";
            this.cbeSkinName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeSkinName.Properties.DropDownItemHeight = 24;
            this.cbeSkinName.Properties.Sorted = true;
            this.cbeSkinName.Size = new System.Drawing.Size(224, 20);
            this.cbeSkinName.TabIndex = 5;
            this.cbeSkinName.SelectedIndexChanged += new System.EventHandler(this.cbeSkinName_SelectedIndexChanged);
            // 
            // FrmConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(681, 330);
            this.Name = "FrmConfiguracoes";
            this.Text = "Configurações do Sistema";
            ((System.ComponentModel.ISupportInitialize)(this.panBackground)).EndInit();
            this.panBackground.ResumeLayout(false);
            this.panBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panBotoes)).EndInit();
            this.panBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panBottom)).EndInit();
            this.panBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ckeEnter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cetTamanhoFonte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeSkinName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit ckeEnter;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CalcEdit cetTamanhoFonte;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ImageComboBoxEdit cbeSkinName;
    }
}
