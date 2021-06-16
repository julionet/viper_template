namespace VIPER.Modules.GeradorRelatorioManutencao.Views
{
    partial class GeradorRelatorioManutencaoView
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.calcEditEscalaY = new DevExpress.XtraEditors.CalcEdit();
            this.calcEditEscalaX = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.checkEditVisualizar = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditLinhaBranco = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditGraficoTexto = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditQuebraPagina = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditMatricial = new DevExpress.XtraEditors.CheckEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonImportar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonExportar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panBackground)).BeginInit();
            this.panBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panBotoes)).BeginInit();
            this.panBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panBottom)).BeginInit();
            this.panBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calcEditEscalaY.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEditEscalaX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditVisualizar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditLinhaBranco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditGraficoTexto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditQuebraPagina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditMatricial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panBackground
            // 
            this.panBackground.Controls.Add(this.textEdit2);
            this.panBackground.Controls.Add(this.textEdit1);
            this.panBackground.Controls.Add(this.groupControl1);
            this.panBackground.Controls.Add(this.labelControl2);
            this.panBackground.Controls.Add(this.labelControl1);
            this.panBackground.Size = new System.Drawing.Size(488, 285);
            // 
            // detalheBindingSource
            // 
            this.detalheBindingSource.DataSource = typeof(Entity.Relatorio);
            // 
            // panBotoes
            // 
            this.panBotoes.Size = new System.Drawing.Size(165, 29);
            // 
            // panBottom
            // 
            this.panBottom.Controls.Add(this.simpleButtonExportar);
            this.panBottom.Controls.Add(this.simpleButtonImportar);
            this.panBottom.Location = new System.Drawing.Point(6, 295);
            this.panBottom.Size = new System.Drawing.Size(488, 33);
            this.panBottom.Controls.SetChildIndex(this.panBotoes, 0);
            this.panBottom.Controls.SetChildIndex(this.simpleButtonImportar, 0);
            this.panBottom.Controls.SetChildIndex(this.simpleButtonExportar, 0);
            // 
            // panSeparadorBottom
            // 
            this.panSeparadorBottom.Location = new System.Drawing.Point(6, 291);
            this.panSeparadorBottom.Size = new System.Drawing.Size(488, 4);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(28, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nome";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 48);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Código";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.calcEditEscalaY);
            this.groupControl1.Controls.Add(this.calcEditEscalaX);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.checkEditVisualizar);
            this.groupControl1.Controls.Add(this.checkEditLinhaBranco);
            this.groupControl1.Controls.Add(this.checkEditGraficoTexto);
            this.groupControl1.Controls.Add(this.checkEditQuebraPagina);
            this.groupControl1.Controls.Add(this.checkEditMatricial);
            this.groupControl1.Location = new System.Drawing.Point(61, 71);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(395, 192);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Informações para Matricial";
            // 
            // calcEditEscalaY
            // 
            this.calcEditEscalaY.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detalheBindingSource, "EscalaY", true));
            this.calcEditEscalaY.Location = new System.Drawing.Point(219, 159);
            this.calcEditEscalaY.Name = "calcEditEscalaY";
            this.calcEditEscalaY.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcEditEscalaY.Properties.Mask.EditMask = "n2";
            this.calcEditEscalaY.Size = new System.Drawing.Size(75, 20);
            this.calcEditEscalaY.TabIndex = 6;
            // 
            // calcEditEscalaX
            // 
            this.calcEditEscalaX.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detalheBindingSource, "EscalaX", true));
            this.calcEditEscalaX.Location = new System.Drawing.Point(82, 159);
            this.calcEditEscalaX.Name = "calcEditEscalaX";
            this.calcEditEscalaX.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcEditEscalaX.Properties.Mask.EditMask = "n2";
            this.calcEditEscalaX.Size = new System.Drawing.Size(75, 20);
            this.calcEditEscalaX.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(174, 162);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(39, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Escala Y";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(37, 162);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Escala X";
            // 
            // checkEditVisualizar
            // 
            this.checkEditVisualizar.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detalheBindingSource, "Visualizar", true));
            this.checkEditVisualizar.Location = new System.Drawing.Point(19, 133);
            this.checkEditVisualizar.Name = "checkEditVisualizar";
            this.checkEditVisualizar.Properties.Caption = "Visualizar antes de imprimir?";
            this.checkEditVisualizar.Size = new System.Drawing.Size(165, 19);
            this.checkEditVisualizar.TabIndex = 4;
            // 
            // checkEditLinhaBranco
            // 
            this.checkEditLinhaBranco.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detalheBindingSource, "LinhaBranco", true));
            this.checkEditLinhaBranco.Location = new System.Drawing.Point(19, 108);
            this.checkEditLinhaBranco.Name = "checkEditLinhaBranco";
            this.checkEditLinhaBranco.Properties.Caption = "Inserir linha em branco?";
            this.checkEditLinhaBranco.Size = new System.Drawing.Size(138, 19);
            this.checkEditLinhaBranco.TabIndex = 3;
            // 
            // checkEditGraficoTexto
            // 
            this.checkEditGraficoTexto.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detalheBindingSource, "GraficoTexto", true));
            this.checkEditGraficoTexto.Location = new System.Drawing.Point(19, 83);
            this.checkEditGraficoTexto.Name = "checkEditGraficoTexto";
            this.checkEditGraficoTexto.Properties.Caption = "Converter gráfico para texto?";
            this.checkEditGraficoTexto.Size = new System.Drawing.Size(165, 19);
            this.checkEditGraficoTexto.TabIndex = 2;
            // 
            // checkEditQuebraPagina
            // 
            this.checkEditQuebraPagina.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detalheBindingSource, "QuebraPagina", true));
            this.checkEditQuebraPagina.Location = new System.Drawing.Point(19, 58);
            this.checkEditQuebraPagina.Name = "checkEditQuebraPagina";
            this.checkEditQuebraPagina.Properties.Caption = "Quebrar página?";
            this.checkEditQuebraPagina.Size = new System.Drawing.Size(103, 19);
            this.checkEditQuebraPagina.TabIndex = 1;
            // 
            // checkEditMatricial
            // 
            this.checkEditMatricial.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detalheBindingSource, "Matricial", true));
            this.checkEditMatricial.Location = new System.Drawing.Point(19, 33);
            this.checkEditMatricial.Name = "checkEditMatricial";
            this.checkEditMatricial.Properties.Caption = "Matricial?";
            this.checkEditMatricial.Size = new System.Drawing.Size(66, 19);
            this.checkEditMatricial.TabIndex = 0;
            this.checkEditMatricial.CheckedChanged += new System.EventHandler(this.checkEditMatricial_CheckedChanged);
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detalheBindingSource, "Nome", true));
            this.textEdit1.Location = new System.Drawing.Point(61, 19);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.MaxLength = 80;
            this.textEdit1.Size = new System.Drawing.Size(395, 20);
            this.textEdit1.TabIndex = 0;
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.detalheBindingSource, "Codigo", true));
            this.textEdit2.Location = new System.Drawing.Point(61, 45);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textEdit2.Properties.MaxLength = 20;
            this.textEdit2.Size = new System.Drawing.Size(142, 20);
            this.textEdit2.TabIndex = 1;
            // 
            // simpleButtonImportar
            // 
            this.simpleButtonImportar.Location = new System.Drawing.Point(327, 5);
            this.simpleButtonImportar.Name = "simpleButtonImportar";
            this.simpleButtonImportar.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonImportar.TabIndex = 1;
            this.simpleButtonImportar.Text = "&Importar";
            this.simpleButtonImportar.Click += new System.EventHandler(this.simpleButtonImportar_Click);
            // 
            // simpleButtonExportar
            // 
            this.simpleButtonExportar.Location = new System.Drawing.Point(408, 5);
            this.simpleButtonExportar.Name = "simpleButtonExportar";
            this.simpleButtonExportar.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonExportar.TabIndex = 2;
            this.simpleButtonExportar.Text = "&Exportar";
            this.simpleButtonExportar.Click += new System.EventHandler(this.simpleButtonExportar_Click);
            // 
            // FrmGeradorRelatorioManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 334);
            this.Name = "FrmGeradorRelatorioManutencao";
            this.Text = "Informações do Relatório";
            ((System.ComponentModel.ISupportInitialize)(this.panBackground)).EndInit();
            this.panBackground.ResumeLayout(false);
            this.panBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panBotoes)).EndInit();
            this.panBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panBottom)).EndInit();
            this.panBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calcEditEscalaY.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEditEscalaX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditVisualizar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditLinhaBranco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditGraficoTexto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditQuebraPagina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditMatricial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CalcEdit calcEditEscalaY;
        private DevExpress.XtraEditors.CalcEdit calcEditEscalaX;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CheckEdit checkEditVisualizar;
        private DevExpress.XtraEditors.CheckEdit checkEditLinhaBranco;
        private DevExpress.XtraEditors.CheckEdit checkEditGraficoTexto;
        private DevExpress.XtraEditors.CheckEdit checkEditQuebraPagina;
        private DevExpress.XtraEditors.CheckEdit checkEditMatricial;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonExportar;
        private DevExpress.XtraEditors.SimpleButton simpleButtonImportar;
    }
}