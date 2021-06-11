namespace Chronus.DXperience
{
    partial class FrmManutencao
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
            this.xtcPaginas = new DevExpress.XtraTab.XtraTabControl();
            this.xtpAcesso = new DevExpress.XtraTab.XtraTabPage();
            this.pclAcesso = new DevExpress.XtraEditors.PanelControl();
            this.pclPesquisar = new DevExpress.XtraEditors.PanelControl();
            this.lblPesquisa = new DevExpress.XtraEditors.LabelControl();
            this.btnFiltrar = new DevExpress.XtraEditors.SimpleButton();
            this.txtPesquisa = new DevExpress.XtraEditors.TextEdit();
            this.pclAcessoBottom = new DevExpress.XtraEditors.PanelControl();
            this.pclSeparadorAcesso = new DevExpress.XtraEditors.PanelControl();
            this.pclBotoesAcesso = new DevExpress.XtraEditors.PanelControl();
            this.btnIncluir = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtualizar = new DevExpress.XtraEditors.SimpleButton();
            this.xtpManutencao = new DevExpress.XtraTab.XtraTabPage();
            this.pclManutencao = new DevExpress.XtraEditors.PanelControl();
            this.xscManutencao = new DevExpress.XtraEditors.XtraScrollableControl();
            this.pclSeparadorManutencao = new DevExpress.XtraEditors.PanelControl();
            this.pclBotoesManutencao = new DevExpress.XtraEditors.PanelControl();
            this.btnExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.btnGravar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.principalBindingSource = new System.Windows.Forms.BindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.xtcPaginas)).BeginInit();
            this.xtcPaginas.SuspendLayout();
            this.xtpAcesso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pclAcesso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclPesquisar)).BeginInit();
            this.pclPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclAcessoBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclSeparadorAcesso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclBotoesAcesso)).BeginInit();
            this.pclBotoesAcesso.SuspendLayout();
            this.xtpManutencao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pclManutencao)).BeginInit();
            this.pclManutencao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pclSeparadorManutencao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclBotoesManutencao)).BeginInit();
            this.pclBotoesManutencao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.principalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // xtcPaginas
            // 
            this.xtcPaginas.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtcPaginas.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtcPaginas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtcPaginas.Location = new System.Drawing.Point(6, 6);
            this.xtcPaginas.Name = "xtcPaginas";
            this.xtcPaginas.PaintStyleName = "Flat";
            this.xtcPaginas.SelectedTabPage = this.xtpAcesso;
            this.xtcPaginas.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtcPaginas.Size = new System.Drawing.Size(547, 284);
            this.xtcPaginas.TabIndex = 2;
            this.xtcPaginas.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpAcesso,
            this.xtpManutencao});
            this.xtcPaginas.TabStop = false;
            this.xtcPaginas.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.tabPaginas_SelectedPageChanged);
            this.xtcPaginas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.xtcPaginas_KeyDown);
            // 
            // xtpAcesso
            // 
            this.xtpAcesso.Controls.Add(this.pclAcesso);
            this.xtpAcesso.Controls.Add(this.pclPesquisar);
            this.xtpAcesso.Controls.Add(this.pclAcessoBottom);
            this.xtpAcesso.Controls.Add(this.pclSeparadorAcesso);
            this.xtpAcesso.Controls.Add(this.pclBotoesAcesso);
            this.xtpAcesso.Name = "xtpAcesso";
            this.xtpAcesso.Size = new System.Drawing.Size(547, 284);
            // 
            // pclAcesso
            // 
            this.pclAcesso.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pclAcesso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pclAcesso.Location = new System.Drawing.Point(0, 73);
            this.pclAcesso.Name = "pclAcesso";
            this.pclAcesso.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.pclAcesso.Size = new System.Drawing.Size(547, 211);
            this.pclAcesso.TabIndex = 2;
            // 
            // pclPesquisar
            // 
            this.pclPesquisar.Controls.Add(this.lblPesquisa);
            this.pclPesquisar.Controls.Add(this.btnFiltrar);
            this.pclPesquisar.Controls.Add(this.txtPesquisa);
            this.pclPesquisar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pclPesquisar.Location = new System.Drawing.Point(0, 38);
            this.pclPesquisar.Name = "pclPesquisar";
            this.pclPesquisar.Size = new System.Drawing.Size(547, 35);
            this.pclPesquisar.TabIndex = 1;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.Location = new System.Drawing.Point(14, 10);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(28, 13);
            this.lblPesquisa.TabIndex = 7;
            this.lblPesquisa.Text = "Filtrar";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(467, 5);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 1;
            this.btnFiltrar.Text = "&Filtrar";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(48, 7);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(413, 20);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.Tag = "PESQUISA";
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // pclAcessoBottom
            // 
            this.pclAcessoBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.pclAcessoBottom.Location = new System.Drawing.Point(0, 38);
            this.pclAcessoBottom.Name = "pclAcessoBottom";
            this.pclAcessoBottom.Size = new System.Drawing.Size(547, 0);
            this.pclAcessoBottom.TabIndex = 7;
            // 
            // pclSeparadorAcesso
            // 
            this.pclSeparadorAcesso.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pclSeparadorAcesso.Dock = System.Windows.Forms.DockStyle.Top;
            this.pclSeparadorAcesso.Location = new System.Drawing.Point(0, 34);
            this.pclSeparadorAcesso.Name = "pclSeparadorAcesso";
            this.pclSeparadorAcesso.Size = new System.Drawing.Size(547, 4);
            this.pclSeparadorAcesso.TabIndex = 9;
            // 
            // pclBotoesAcesso
            // 
            this.pclBotoesAcesso.Controls.Add(this.btnIncluir);
            this.pclBotoesAcesso.Controls.Add(this.btnEditar);
            this.pclBotoesAcesso.Controls.Add(this.btnAtualizar);
            this.pclBotoesAcesso.Dock = System.Windows.Forms.DockStyle.Top;
            this.pclBotoesAcesso.Location = new System.Drawing.Point(0, 0);
            this.pclBotoesAcesso.Name = "pclBotoesAcesso";
            this.pclBotoesAcesso.Size = new System.Drawing.Size(547, 34);
            this.pclBotoesAcesso.TabIndex = 0;
            this.pclBotoesAcesso.TabStop = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(5, 5);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(86, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "&Alterar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(167, 5);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 2;
            this.btnAtualizar.Text = "A&tualizar";
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // xtpManutencao
            // 
            this.xtpManutencao.Controls.Add(this.pclManutencao);
            this.xtpManutencao.Controls.Add(this.pclSeparadorManutencao);
            this.xtpManutencao.Controls.Add(this.pclBotoesManutencao);
            this.xtpManutencao.Name = "xtpManutencao";
            this.xtpManutencao.Size = new System.Drawing.Size(547, 284);
            // 
            // pclManutencao
            // 
            this.pclManutencao.Controls.Add(this.xscManutencao);
            this.pclManutencao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pclManutencao.Location = new System.Drawing.Point(0, 0);
            this.pclManutencao.Name = "pclManutencao";
            this.pclManutencao.Size = new System.Drawing.Size(547, 248);
            this.pclManutencao.TabIndex = 2;
            // 
            // xscManutencao
            // 
            this.xscManutencao.AllowTouchScroll = true;
            this.xscManutencao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xscManutencao.Location = new System.Drawing.Point(2, 2);
            this.xscManutencao.Name = "xscManutencao";
            this.xscManutencao.Size = new System.Drawing.Size(543, 244);
            this.xscManutencao.TabIndex = 0;
            // 
            // pclSeparadorManutencao
            // 
            this.pclSeparadorManutencao.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pclSeparadorManutencao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pclSeparadorManutencao.Location = new System.Drawing.Point(0, 248);
            this.pclSeparadorManutencao.Name = "pclSeparadorManutencao";
            this.pclSeparadorManutencao.Size = new System.Drawing.Size(547, 4);
            this.pclSeparadorManutencao.TabIndex = 1;
            // 
            // pclBotoesManutencao
            // 
            this.pclBotoesManutencao.Controls.Add(this.btnExcluir);
            this.pclBotoesManutencao.Controls.Add(this.btnGravar);
            this.pclBotoesManutencao.Controls.Add(this.btnCancelar);
            this.pclBotoesManutencao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pclBotoesManutencao.Location = new System.Drawing.Point(0, 252);
            this.pclBotoesManutencao.Name = "pclBotoesManutencao";
            this.pclBotoesManutencao.Size = new System.Drawing.Size(547, 32);
            this.pclBotoesManutencao.TabIndex = 0;
            this.pclBotoesManutencao.TabStop = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(167, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "E&xcluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(5, 4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 0;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(86, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 296);
            this.Controls.Add(this.xtcPaginas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmManutencao";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modelo de Manutenção";
            this.Load += new System.EventHandler(this.FrmManutencao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmManutencao_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.xtcPaginas)).EndInit();
            this.xtcPaginas.ResumeLayout(false);
            this.xtpAcesso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pclAcesso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclPesquisar)).EndInit();
            this.pclPesquisar.ResumeLayout(false);
            this.pclPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclAcessoBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclSeparadorAcesso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclBotoesAcesso)).EndInit();
            this.pclBotoesAcesso.ResumeLayout(false);
            this.xtpManutencao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pclManutencao)).EndInit();
            this.pclManutencao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pclSeparadorManutencao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclBotoesManutencao)).EndInit();
            this.pclBotoesManutencao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.principalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.PanelControl pclAcesso;
        public DevExpress.XtraEditors.PanelControl pclAcessoBottom;
        public DevExpress.XtraTab.XtraTabPage xtpManutencao;
        public DevExpress.XtraEditors.PanelControl pclManutencao;
        private DevExpress.XtraEditors.PanelControl pclSeparadorManutencao;
        public DevExpress.XtraEditors.SimpleButton btnExcluir;
        public DevExpress.XtraEditors.TextEdit txtPesquisa;
        public System.Windows.Forms.BindingSource principalBindingSource;
        public DevExpress.XtraTab.XtraTabControl xtcPaginas;
        public DevExpress.XtraTab.XtraTabPage xtpAcesso;
        public DevExpress.XtraEditors.PanelControl pclBotoesManutencao;
        public DevExpress.XtraEditors.SimpleButton btnIncluir;
        public DevExpress.XtraEditors.SimpleButton btnGravar;
        public DevExpress.XtraEditors.SimpleButton btnCancelar;
        public DevExpress.XtraEditors.PanelControl pclPesquisar;
        public DevExpress.XtraEditors.XtraScrollableControl xscManutencao;
        public DevExpress.XtraEditors.LabelControl lblPesquisa;
        public DevExpress.XtraEditors.SimpleButton btnFiltrar;
        public DevExpress.XtraEditors.PanelControl pclSeparadorAcesso;
        public DevExpress.XtraEditors.PanelControl pclBotoesAcesso;
        public DevExpress.XtraEditors.SimpleButton btnAtualizar;
        public DevExpress.XtraEditors.SimpleButton btnEditar;
    }
}

