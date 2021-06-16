namespace Chronus.DXperience
{
    partial class ucPesquisa
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlInferior = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPesquisa = new DevExpress.XtraEditors.TextEdit();
            this.pnlSuperior = new DevExpress.XtraEditors.PanelControl();
            this.gclPrincipal = new DevExpress.XtraGrid.GridControl();
            this.principalBindingSource = new System.Windows.Forms.BindingSource();
            this.gvwPrincipal = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.pnlInferior)).BeginInit();
            this.pnlInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSuperior)).BeginInit();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gclPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.principalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInferior
            // 
            this.pnlInferior.Controls.Add(this.labelControl1);
            this.pnlInferior.Controls.Add(this.txtPesquisa);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.Location = new System.Drawing.Point(0, 168);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(400, 55);
            this.pnlInferior.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(141, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Digite critério e tecle [ENTER]";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Location = new System.Drawing.Point(5, 8);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(390, 20);
            this.txtPesquisa.TabIndex = 5;
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlSuperior.Controls.Add(this.gclPrincipal);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(400, 168);
            this.pnlSuperior.TabIndex = 2;
            // 
            // gclPrincipal
            // 
            this.gclPrincipal.Cursor = System.Windows.Forms.Cursors.Default;
            this.gclPrincipal.DataSource = this.principalBindingSource;
            this.gclPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gclPrincipal.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gclPrincipal.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gclPrincipal.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gclPrincipal.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gclPrincipal.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gclPrincipal.Location = new System.Drawing.Point(0, 0);
            this.gclPrincipal.MainView = this.gvwPrincipal;
            this.gclPrincipal.Name = "gclPrincipal";
            this.gclPrincipal.Size = new System.Drawing.Size(400, 168);
            this.gclPrincipal.TabIndex = 6;
            this.gclPrincipal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwPrincipal});
            // 
            // gvwPrincipal
            // 
            this.gvwPrincipal.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvwPrincipal.GridControl = this.gclPrincipal;
            this.gvwPrincipal.Name = "gvwPrincipal";
            this.gvwPrincipal.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvwPrincipal.OptionsBehavior.Editable = false;
            this.gvwPrincipal.OptionsCustomization.AllowColumnMoving = false;
            this.gvwPrincipal.OptionsCustomization.AllowColumnResizing = false;
            this.gvwPrincipal.OptionsCustomization.AllowFilter = false;
            this.gvwPrincipal.OptionsCustomization.AllowGroup = false;
            this.gvwPrincipal.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gvwPrincipal.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gvwPrincipal.OptionsMenu.EnableColumnMenu = false;
            this.gvwPrincipal.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvwPrincipal.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvwPrincipal.OptionsView.ShowGroupPanel = false;
            this.gvwPrincipal.OptionsView.ShowIndicator = false;
            this.gvwPrincipal.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvwPrincipal_RowClick);
            this.gvwPrincipal.StartSorting += new System.EventHandler(this.gvwPrincipal_StartSorting);
            this.gvwPrincipal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gvwPrincipal_KeyPress);
            this.gvwPrincipal.DoubleClick += new System.EventHandler(this.gvwPrincipal_DoubleClick);
            // 
            // ucPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.pnlInferior);
            this.Name = "ucPesquisa";
            this.Size = new System.Drawing.Size(400, 223);
            this.Load += new System.EventHandler(this.ucPesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlInferior)).EndInit();
            this.pnlInferior.ResumeLayout(false);
            this.pnlInferior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSuperior)).EndInit();
            this.pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gclPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.principalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlInferior;
        private DevExpress.XtraEditors.PanelControl pnlSuperior;
        private System.Windows.Forms.BindingSource principalBindingSource;
        private DevExpress.XtraEditors.TextEdit txtPesquisa;
        private DevExpress.XtraGrid.GridControl gclPrincipal;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwPrincipal;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
