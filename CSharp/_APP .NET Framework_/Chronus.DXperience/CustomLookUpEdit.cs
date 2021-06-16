using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Chronus.DXperience
{
    public class CustomLookUpViewInfo : LookUpEditViewInfo
    {
        public CustomLookUpViewInfo(RepositoryItem item)
            : base(item)
        {
        }

        protected override void CalcContentRect(Rectangle bounds)
        {
            base.CalcContentRect(bounds);
            this.fMaskBoxRect = ContentRect;
        }
    }

    //The attribute that points to the registration method
    [UserRepositoryItem("RegisterCustomEdit")]
    public class RepositoryItemCustomLookUpEdit : RepositoryItemLookUpEdit
    {

        //The static constructor which calls the registration method
        static RepositoryItemCustomLookUpEdit() { RegisterCustomEdit(); }

        //Initialize new properties
        public RepositoryItemCustomLookUpEdit()
        {
        }

        //The unique name for the custom editor
        public const string CustomEditName = "CustomLookUpEdit";

        //Return the unique name
        public override string EditorTypeName { get { return CustomEditName; } }

        //Register the editor
        public static void RegisterCustomEdit()
        {
            //Icon representing the editor within a container editor's Designer
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(CustomLookUpEdit), typeof(RepositoryItemCustomLookUpEdit), typeof(CustomLookUpViewInfo), new ButtonEditPainter(), true, null, typeof(DevExpress.Accessibility.PopupEditAccessible)));
        }

        //Override the Assign method
        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
            }
            finally
            {
                EndUpdate();
            }
        }

        protected override bool NeededKeysContains(Keys key)
        {
            if (key == Keys.Enter)
                return true;
            if (key == Keys.Tab)
                return true;
            if (key == Keys.Up)
                return true;
            if (key == Keys.Down)
                return true;
            return base.NeededKeysContains(key);
        }
        public override bool IsNeededKey(Keys keyData)
        {
            if (keyData == (Keys.Enter | Keys.Control)) return false;
            bool res = base.IsNeededKey(keyData);
            if (res) return true;
            if (keyData == Keys.PageUp || keyData == Keys.PageDown) return true;
            return false;
        }

        protected override bool UseMaskBox { get { return false; } }

    }


    public class CustomLookUpEdit : LookUpEdit
    {

        //The static constructor which calls the registration method
        static CustomLookUpEdit() { RepositoryItemCustomLookUpEdit.RegisterCustomEdit(); }

        //Initialize the new instance
        public CustomLookUpEdit()
        {
            //...
        }
        protected override bool AcceptsReturn { get { return true; } }
        protected override bool AcceptsTab { get { return true; } }

        //Return the unique name
        public override string EditorTypeName { get { return RepositoryItemCustomLookUpEdit.CustomEditName; } }

        //Override the Properties property
        //Simply type-cast the object to the custom repository item type
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCustomLookUpEdit Properties
        {
            get { return base.Properties as RepositoryItemCustomLookUpEdit; }
        }

        protected override void UpdateMaskBoxProperties(bool always)
        {
            base.UpdateMaskBoxProperties(always);
            if (MaskBox == null) return;
            MaskBox.Multiline = true;
            MaskBox.WordWrap = true;
            MaskBox.ScrollBars = ScrollBars.None;
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            return base.ProcessDialogKey(keyData);
        }
        protected override bool IsInputKey(Keys keyData)
        {
            bool result = base.IsInputKey(keyData);
            if (result) return true;
            if (keyData == Keys.Enter) return true;
            if (keyData == Keys.Tab) return true;
            return result;
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
        }
        protected override void OnEditorKeyDown(KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down) return;
            base.OnEditorKeyDown(e);
        }
    }
}
