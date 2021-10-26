namespace NAMESPACE.Modules.__MODULENAME__.Views
{
    partial class VIPERView
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
            this.gclPrincipal = new DevExpress.XtraGrid.GridControl();
            this.gvwAcesso = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.pclAcesso)).BeginInit();
            this.pclAcesso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pclAcessoBottom)).BeginInit();
            this.xtpManutencao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pclManutencao)).BeginInit();
            this.pclManutencao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.principalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtcPaginas)).BeginInit();
            this.xtcPaginas.SuspendLayout();
            this.xtpAcesso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pclBotoesManutencao)).BeginInit();
            this.pclBotoesManutencao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pclPesquisar)).BeginInit();
            this.pclPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pclSeparadorAcesso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclBotoesAcesso)).BeginInit();
            this.pclBotoesAcesso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gclPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwAcesso)).BeginInit();
            this.SuspendLayout();
            // 
            // pclAcesso
            // 
            this.pclAcesso.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pclAcesso.Appearance.Options.UseBackColor = true;
            this.pclAcesso.Controls.Add(this.gclPrincipal);
            this.pclAcesso.Size = new System.Drawing.Size(788, 365);
            // 
            // pclAcessoBottom
            // 
            this.pclAcessoBottom.Size = new System.Drawing.Size(788, 0);
            // 
            // pclManutencao
            // 
            this.pclManutencao.Size = new System.Drawing.Size(547, 248);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Size = new System.Drawing.Size(413, 20);
            // 
            // xtcPaginas
            // 
            this.xtcPaginas.Size = new System.Drawing.Size(788, 438);
            // 
            // xtpAcesso
            // 
            this.xtpAcesso.Size = new System.Drawing.Size(788, 438);
            // 
            // pclPesquisar
            // 
            this.pclPesquisar.Size = new System.Drawing.Size(788, 35);
            // 
            // pclSeparadorAcesso
            // 
            this.pclSeparadorAcesso.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pclSeparadorAcesso.Appearance.Options.UseBackColor = true;
            this.pclSeparadorAcesso.Size = new System.Drawing.Size(788, 4);
            // 
            // pclBotoesAcesso
            // 
            this.pclBotoesAcesso.Size = new System.Drawing.Size(788, 34);
            // 
            // gclPrincipal
            // 
            this.gclPrincipal.DataSource = this.principalBindingSource;
            this.gclPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gclPrincipal.Location = new System.Drawing.Point(0, 3);
            this.gclPrincipal.MainView = this.gvwAcesso;
            this.gclPrincipal.Name = "gclPrincipal";
            this.gclPrincipal.Size = new System.Drawing.Size(788, 362);
            this.gclPrincipal.TabIndex = 0;
            this.gclPrincipal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwAcesso});
            // 
            // gvwAcesso
            // 
            this.gvwAcesso.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvwAcesso.GridControl = this.gclPrincipal;
            this.gvwAcesso.Name = "gvwAcesso";
            this.gvwAcesso.OptionsBehavior.Editable = false;
            this.gvwAcesso.OptionsCustomization.AllowColumnMoving = false;
            this.gvwAcesso.OptionsCustomization.AllowColumnResizing = false;
            this.gvwAcesso.OptionsCustomization.AllowFilter = false;
            this.gvwAcesso.OptionsCustomization.AllowGroup = false;
            this.gvwAcesso.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvwAcesso.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvwAcesso.OptionsSelection.InvertSelection = true;
            this.gvwAcesso.OptionsView.ColumnAutoWidth = false;
            this.gvwAcesso.OptionsView.ShowGroupPanel = false;
            this.gvwAcesso.OptionsView.ShowIndicator = false;
            this.gvwAcesso.DoubleClick += new System.EventHandler(this.gvwAcesso_DoubleClick);
            // 
            // ClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "VIPERView";
            this.Text = "VIPERView";
			this.Load += new System.EventHandler(this.VIPERView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pclAcesso)).EndInit();
            this.pclAcesso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pclAcessoBottom)).EndInit();
            this.xtpManutencao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pclManutencao)).EndInit();
            this.pclManutencao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.principalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtcPaginas)).EndInit();
            this.xtcPaginas.ResumeLayout(false);
            this.xtpAcesso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pclBotoesManutencao)).EndInit();
            this.pclBotoesManutencao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pclPesquisar)).EndInit();
            this.pclPesquisar.ResumeLayout(false);
            this.pclPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pclSeparadorAcesso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclBotoesAcesso)).EndInit();
            this.pclBotoesAcesso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gclPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwAcesso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gclPrincipal;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwAcesso;
    }
}