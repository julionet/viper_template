using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;
using System;
using DevExpress.XtraEditors.Mask;
using System.Linq;

namespace Chronus.DXperience
{
    public class ComponenteDX
    {
        private Control _controle;

        public ComponenteDX(Control controle)
        {
            _controle = controle;
        }

        public void Configurar()
        {
            if (_controle is DateEdit)
                ConfigurarDateEdit();
            else if (_controle is LookUpEdit)
                ConfigurarLookupEdit();
            else if (_controle is PopupContainerEdit)
                ConfigurarPopupContainerEdit();
            else if (_controle is CalcEdit)
                ConfigurarCalcEdit();
            else if (_controle is MemoEdit)
                ConfigurarMemoEdit();
            else if (_controle is ImageComboBoxEdit)
                ConfigurarImageComboBoxEdit();
            else if (_controle is ComboBoxEdit)
                ConfigurarComboBoxEdit();
            else if (_controle is TextEdit)
                ConfigurarTextEdit();
            else if (_controle is GridControl)
                ConfigurarGridControl();
            else if (_controle is CheckedListBoxControl)
                ConfigurarCheckedListBoxControl();
            else if (_controle is CheckedComboBoxEdit)
                ConfigurarCheckedComboBoxEdit();
            else if (_controle is TimeSpanEdit)
                ConfigurarTimeSpanEdit();
        }

        private void ConfigurarGridControl()
        {
            foreach (GridView view in (_controle as GridControl).Views.Where(p => p.GetType() == typeof(GridViewWithButtons) || p.GetType() == typeof(GridView)))
            {
                /*view.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
                view.OptionsBehavior.AllowIncrementalSearch = true;
                view.OptionsBehavior.Editable = false;
                view.OptionsCustomization.AllowColumnMoving = false;
                view.OptionsCustomization.AllowColumnResizing = false;
                view.OptionsCustomization.AllowFilter = false;
                view.OptionsCustomization.AllowGroup = false;
                view.OptionsMenu.EnableColumnMenu = false;
                view.OptionsSelection.EnableAppearanceFocusedCell = false;
                view.OptionsView.ColumnAutoWidth = false;
                view.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
                view.OptionsView.ShowGroupPanel = false;*/
                view.OptionsView.ShowIndicator = false;
                view.ColumnPanelRowHeight = 28;
                view.RowHeight = 28;
                view.GroupRowHeight = 28;
                view.ViewCaptionHeight = 24;
            }
        }

        private void ConfigurarTextEdit()
        {            
        }

        private void ConfigurarTimeSpanEdit()
        {
            (_controle as TimeSpanEdit).Properties.AllowEditDays = false;
            (_controle as TimeSpanEdit).Properties.AllowEditMilliseconds = false;
            (_controle as TimeSpanEdit).Properties.Mask.UseMaskAsDisplayFormat = true;
            (_controle as TimeSpanEdit).Properties.Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            (_controle as TimeSpanEdit).Properties.Mask.EditMask = string.IsNullOrWhiteSpace((_controle as TimeSpanEdit).Properties.Mask.EditMask) ? "T" : 
                (_controle as TimeSpanEdit).Properties.Mask.EditMask;
        }

        private void ConfigurarDateEdit()
        {
            (_controle as DateEdit).Properties.ShowToday = false;
            (_controle as DateEdit).Properties.Mask.UseMaskAsDisplayFormat = true;
            (_controle as DateEdit).Properties.Mask.MaskType = string.IsNullOrWhiteSpace((_controle as DateEdit).Properties.Mask.EditMask) || (_controle as DateEdit).Properties.Mask.EditMask == "g" ? 
                MaskType.DateTimeAdvancingCaret : MaskType.Simple;
            (_controle as DateEdit).Properties.Mask.EditMask = string.IsNullOrWhiteSpace((_controle as DateEdit).Properties.Mask.EditMask) || (_controle as DateEdit).Properties.Mask.EditMask == "d" ? 
                "99/99/9999" : (_controle as DateEdit).Properties.Mask.EditMask;
            if ((_controle as DateEdit).Properties.ReadOnly)
                (_controle as DateEdit).Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            else
            {
                (_controle as DateEdit).Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick;
            }
        }

        private void ConfigurarLookupEdit()
        {
            (_controle as LookUpEdit).Properties.NullText = "";
            (_controle as LookUpEdit).Properties.ShowFooter = false;
            (_controle as LookUpEdit).Properties.ShowHeader = false;
            (_controle as LookUpEdit).Properties.ShowLines = false;
            if ((_controle as LookUpEdit).Properties.PopupWidth == 0)
                (_controle as LookUpEdit).Properties.PopupWidth = (_controle as LookUpEdit).Width;
            (_controle as LookUpEdit).Properties.PopupFormMinSize = new System.Drawing.Size((_controle as LookUpEdit).Properties.PopupWidth, (_controle as LookUpEdit).Height);
        }

        private void ConfigurarPopupContainerEdit()
        {
            (_controle as PopupContainerEdit).Properties.NullText = "";
            (_controle as PopupContainerEdit).Properties.ShowPopupCloseButton = false;
            (_controle as PopupContainerEdit).Properties.PopupSizeable = false;
        }

        private void ConfigurarCalcEdit()
        {
            (_controle as CalcEdit).Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            (_controle as CalcEdit).Properties.Buttons.Clear();
            (_controle as CalcEdit).Properties.Mask.UseMaskAsDisplayFormat = true;
            (_controle as CalcEdit).Properties.Mask.EditMask = string.IsNullOrWhiteSpace((_controle as CalcEdit).Properties.Mask.EditMask) ? "n2" : (_controle as CalcEdit).Properties.Mask.EditMask;
            (_controle as CalcEdit).Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            (_controle as CalcEdit).Properties.MaxLength = (_controle as CalcEdit).Properties.MaxLength == 0 ? ((_controle as CalcEdit).Properties.Mask.EditMask == "d" ? 7 : 13) : (_controle as CalcEdit).Properties.MaxLength;
        }

        private void ConfigurarMemoEdit()
        {
            if ((_controle as MemoEdit).Properties.WordWrap)
                (_controle as MemoEdit).Properties.ScrollBars = ScrollBars.Vertical;
        }

        private void ConfigurarImageComboBoxEdit()
        {
        }

        private void ConfigurarComboBoxEdit()
        {
            (_controle as ComboBoxEdit).Properties.NullText = "";
            (_controle as ComboBoxEdit).Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }

        private void ConfigurarCheckedListBoxControl()
        {
        }

        private void ConfigurarCheckedComboBoxEdit()
        {
            (_controle as CheckedComboBoxEdit).Properties.PopupSizeable = false;
            (_controle as CheckedComboBoxEdit).Properties.SelectAllItemCaption = "(Selecionar Todos)";
        }
    }
}
