using System;

namespace Chronus.DXperience
{
    public static class ExtensionDX
    {
        public static bool IsNullOrDbnull(this DevExpress.XtraEditors.BaseEdit objeto)
        {
            return objeto.EditValue == null || objeto.EditValue == DBNull.Value;
        }
    }
}
