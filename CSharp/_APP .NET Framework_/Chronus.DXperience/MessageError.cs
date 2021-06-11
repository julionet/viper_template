using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chronus.DXperience
{
    public class MessageError
    {
        private MessageError()
        {
        }

        public static void ShowDialog(string message, string texto, string caption = "Erro")
        {
            XtraForm xform = new XtraForm();
            xform.FormBorderStyle = FormBorderStyle.FixedDialog;
            xform.StartPosition = FormStartPosition.CenterScreen;
            xform.MaximizeBox = false;
            xform.MinimizeBox = false;
            xform.Text = caption;
            xform.Size = new Size(500, 180);

            MemoEdit memo = new MemoEdit();
            memo.Dock = DockStyle.Fill;
            memo.Properties.ReadOnly = true;
            memo.TabStop = false;
            memo.Text = texto;
            xform.Controls.Add(memo);

            PanelControl pclBottom = new PanelControl();
            pclBottom.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            pclBottom.Dock = DockStyle.Top;
            pclBottom.Size = new Size(0, 32);
            xform.Controls.Add(pclBottom);

            PanelControl pclBackground = new PanelControl();
            pclBackground.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            pclBackground.Size = new Size(0, 85);
            pclBackground.Dock = DockStyle.Top;
            pclBackground.Padding = new System.Windows.Forms.Padding(8);
            xform.Controls.Add(pclBackground);

            Label lblTexto = new Label();
            lblTexto.AutoSize = false;
            lblTexto.Dock = DockStyle.Fill;
            lblTexto.TextAlign = ContentAlignment.TopLeft;
            lblTexto.Text = message;
            pclBackground.Controls.Add(lblTexto);

            PictureBox pbxImagem = new PictureBox();
            pbxImagem.Size = new Size(42, 32);
            pbxImagem.Dock = DockStyle.Left;
            pbxImagem.Image = SystemIcons.Error.ToBitmap();
            pclBackground.Controls.Add(pbxImagem);

            SimpleButton btnOk = new SimpleButton();
            btnOk.Location = new Point(pclBottom.Width - btnOk.Width - 6, 4);
            btnOk.Text = "&OK";
            btnOk.DialogResult = DialogResult.OK;
            pclBottom.Controls.Add(btnOk);

            DropDownButton ddbDetalhes = new DropDownButton();
            ddbDetalhes.Location = new Point(6, 4);
            ddbDetalhes.Size = new Size(71, 23);
            ddbDetalhes.Text = "&Detalhes";
            ddbDetalhes.DropDownArrowStyle = DropDownArrowStyle.Show;
            ddbDetalhes.DialogResult = DialogResult.None;
            ddbDetalhes.Click += ddbDetalhes_Click;
            pclBottom.Controls.Add(ddbDetalhes);


            xform.ShowDialog();
        }

        static void ddbDetalhes_Click(object sender, EventArgs e)
        {
            XtraForm xform = (sender as DropDownButton).Parent.Parent as XtraForm;
            if (xform.Size.Height == 180)
                xform.Size = new Size(500, 300);
            else
                xform.Size = new Size(500, 180);
        }
    }
}
