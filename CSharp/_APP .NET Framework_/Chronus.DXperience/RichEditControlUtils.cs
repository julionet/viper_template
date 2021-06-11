using DevExpress.XtraRichEdit;


namespace Chronus.DXperience
{
    public class RichEditControlUtils
    {
        RichEditControl editor;

        public RichEditControlUtils()
        {
            editor = new RichEditControl();
            editor.LayoutUnit = DocumentLayoutUnit.Document;
        }

        public int PageCount(string texto)
        {
            editor.RtfText = texto;
            //PageBasedRichEditView currentView = editor.ActiveView as PageBasedRichEditView;           
            //return currentView.PageCount;
            editor.Document.CaretPosition = editor.Document.Range.End;
            editor.ScrollToCaret();
            return editor.Views.PrintLayoutView.PageCount;
        }

        public void Print(string texto)
        {
            editor.RtfText = texto;
            editor.Print();
        }

        public void ShowPrintPreview(string texto)
        {
            editor.RtfText = texto;
            editor.ShowPrintPreview();
        }
    }
}
