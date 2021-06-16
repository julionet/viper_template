using System;
using System.Windows.Forms;

namespace Chronus.DXperience
{
    public class Interface
    {
        private Interface()
        {
        }

        public static void EnterMoveNextControl(Control parent)
        {
            if (parent.Controls.Count > 0)
                foreach (Control c in parent.Controls)
                    if ((c is DevExpress.XtraEditors.BaseEdit) && !(c is DevExpress.XtraEditors.MemoEdit))
                        (c as DevExpress.XtraEditors.BaseEdit).EnterMoveNextControl = true;
                    else if (c is DevExpress.XtraTab.XtraTabControl || c is DevExpress.XtraTab.XtraTabPage ||
                        c is DevExpress.XtraEditors.PanelControl || c is DevExpress.XtraEditors.GroupControl ||
                        c is DevExpress.XtraEditors.XtraScrollableControl)
                        EnterMoveNextControl(c);
        }

        public static void ChangeEnableControl(bool Acesso, Control parent)
        {
            if (parent.Controls.Count > 0)
                foreach (Control c in parent.Controls)
                    if (c is DevExpress.XtraEditors.BaseEdit || c is DevExpress.XtraEditors.CheckedListBoxControl ||
                        c is DevExpress.XtraRichEdit.RichEditControl)
                        c.Enabled = Acesso;
                    else if (c is DevExpress.XtraTab.XtraTabControl || c is DevExpress.XtraTab.XtraTabPage ||
                        c is DevExpress.XtraEditors.PanelControl || c is DevExpress.XtraEditors.GroupControl ||
                        c is DevExpress.XtraEditors.XtraScrollableControl)
                        ChangeEnableControl(Acesso, c);
                    else
                        c.Enabled = true;
        }

        public static void SetPropertyDefault(Control controls)
        {
            if (controls.Controls.Count > 0)
                foreach (Control c in controls.Controls)
                {
                    if (c is DevExpress.XtraTab.XtraTabControl || c is DevExpress.XtraTab.XtraTabPage ||
                        c is DevExpress.XtraEditors.PanelControl || c is DevExpress.XtraEditors.GroupControl ||
                        c is DevExpress.XtraEditors.XtraScrollableControl)
                        SetPropertyDefault(c);
                    else
                        new ComponenteDX(c).Configurar();
                }
        }

        public static void ClearDateEdit(DevExpress.XtraEditors.DateEdit dateedit, bool nullable = true)
        {
            if (dateedit == null) return;

            if (dateedit.EditValue == null ||
                dateedit.EditValue.ToString() == "" ||
                dateedit.DateTime < new DateTime(1900, 1, 1))
            {
                if (nullable)
                    dateedit.EditValue = null;
                else
                    dateedit.EditValue = new DateTime(1900, 1, 1);
            }
        }
    }
}
