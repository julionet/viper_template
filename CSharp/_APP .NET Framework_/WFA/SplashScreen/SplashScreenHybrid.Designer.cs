namespace VIPER.WFA
{
    partial class SplashScreenHybrid
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.panelControlTopo = new DevExpress.XtraEditors.PanelControl();
            this.panelControlBottom = new DevExpress.XtraEditors.PanelControl();
            this.progressPanel = new DevExpress.XtraWaitForm.ProgressPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTopo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBottom)).BeginInit();
            this.panelControlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl2.Location = new System.Drawing.Point(0, 371);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(1366, 82);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Label";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureEdit2.Location = new System.Drawing.Point(0, 212);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.AllowFocused = false;
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowMenu = false;
            this.pictureEdit2.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit2.Size = new System.Drawing.Size(1366, 159);
            this.pictureEdit2.TabIndex = 9;
            // 
            // panelControlTopo
            // 
            this.panelControlTopo.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControlTopo.Appearance.Options.UseBackColor = true;
            this.panelControlTopo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlTopo.Location = new System.Drawing.Point(0, 0);
            this.panelControlTopo.Name = "panelControlTopo";
            this.panelControlTopo.Size = new System.Drawing.Size(1366, 212);
            this.panelControlTopo.TabIndex = 10;
            // 
            // panelControlBottom
            // 
            this.panelControlBottom.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControlBottom.Appearance.Options.UseBackColor = true;
            this.panelControlBottom.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControlBottom.Controls.Add(this.progressPanel);
            this.panelControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlBottom.Location = new System.Drawing.Point(0, 535);
            this.panelControlBottom.Name = "panelControlBottom";
            this.panelControlBottom.Size = new System.Drawing.Size(1366, 233);
            this.panelControlBottom.TabIndex = 12;
            // 
            // progressPanel
            // 
            this.progressPanel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressPanel.Appearance.Options.UseBackColor = true;
            this.progressPanel.Appearance.Options.UseFont = true;
            this.progressPanel.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressPanel.AppearanceCaption.Options.UseFont = true;
            this.progressPanel.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progressPanel.AppearanceDescription.Options.UseFont = true;
            this.progressPanel.Caption = "Carregando...";
            this.progressPanel.Description = "";
            this.progressPanel.Location = new System.Drawing.Point(613, 3);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.ShowDescription = false;
            this.progressPanel.Size = new System.Drawing.Size(159, 66);
            this.progressPanel.TabIndex = 0;
            // 
            // SplashScreenHybrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.panelControlBottom);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.panelControlTopo);
            this.Name = "SplashScreenHybrid";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SplashScreenHybrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTopo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBottom)).EndInit();
            this.panelControlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PanelControl panelControlTopo;
        private DevExpress.XtraEditors.PanelControl panelControlBottom;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel;
    }
}
