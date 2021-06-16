using DevExpress.XtraVerticalGrid;

namespace Chronus.DXperience
{
    public class VerticalGridHelper
    {
        private VGridControl vGridControlComponente = null;

        public VerticalGridHelper(VGridControl vGrid)
        {
            vGridControlComponente = vGrid;
        }

        public void AtualizarVerticalGrid(ComponentType type)
        {
            this.Atualizar();

            switch (type)
            {
                case ComponentType.TFormularioDX:
                    this.AtualizarFormulario();
                    break;
                case ComponentType.TShapeDX:
                    this.AtualizarPanelControl();
                    break;
                case ComponentType.TLabelDX:
                    this.AtualizarLabelControl();
                    break;
                case ComponentType.TGroupBoxDX:
                    this.AtualizarGroupControl();
                    break;
                case ComponentType.TTextEditDX:
                    this.AtualizarTextEdit();
                    break;
                case ComponentType.TDateEditDX:
                    this.AtualizarDateEdit();
                    break;
                case ComponentType.TTimeEditDX:
                    this.AtualizarTimeEdit();
                    break;
                case ComponentType.TSpinEditDX:
                    this.AtualizarSpinEdit();
                    break;
                case ComponentType.TCheckBoxDX:
                    this.AtualizarCheckBox();
                    break;
                case ComponentType.TRadioButtonDX:
                    this.AtualizarRadioButton();
                    break;
                case ComponentType.TComboBoxDX:
                    this.AtualizarCombokBox(false);
                    break;
                case ComponentType.TRadioGroupDX:
                    this.AtualizarRadioGroup(false);
                    break;
                case ComponentType.TCheckListBoxDX:
                    this.AtualizarCheckListBox(false);
                    break;
                case ComponentType.TDBComboBoxDX:
                    this.AtualizarCombokBox(true);
                    break;
                case ComponentType.TDBRadioGroupDX:
                    this.AtualizarRadioGroup(true);
                    break;
                case ComponentType.TDBCheckListBoxDX:
                    this.AtualizarCheckListBox(true);
                    break;
            }
        }

        private void Atualizar()
        {
            vGridControlComponente.Rows["rowComponentType"].Visible = false;
            vGridControlComponente.Rows["rowName"].Visible = false;
            vGridControlComponente.Rows["rowTop"].Visible = false;
            vGridControlComponente.Rows["rowLeft"].Visible = false;
            vGridControlComponente.Rows["rowHeight"].Visible = false;
            vGridControlComponente.Rows["rowWidth"].Visible = false;
            vGridControlComponente.Rows["rowLeave"].Visible = false;
            vGridControlComponente.Rows["rowEnter"].Visible = false;
            vGridControlComponente.Rows["rowChange"].Visible = false;
            vGridControlComponente.Rows["rowCheckAll"].Visible = false;
            vGridControlComponente.Rows["rowSQL"].Visible = false;
            vGridControlComponente.Rows["rowShowField"].Visible = false;
            vGridControlComponente.Rows["rowKeyField"].Visible = false;
            vGridControlComponente.Rows["rowColumns"].Visible = false;
            vGridControlComponente.Rows["rowValues"].Visible = false;
            vGridControlComponente.Rows["rowDescriptions"].Visible = false;
            vGridControlComponente.Rows["rowGroupIndex"].Visible = false;
            vGridControlComponente.Rows["rowValueChecked"].Visible = false;
            vGridControlComponente.Rows["rowValueUnchecked"].Visible = false;
            vGridControlComponente.Rows["rowMinValue"].Visible = false;
            vGridControlComponente.Rows["rowMaxValue"].Visible = false;
            vGridControlComponente.Rows["rowComponents"].Visible = false;
            vGridControlComponente.Rows["rowAligment"].Visible = false;
            vGridControlComponente.Rows["rowGroupIndex"].Visible = false;
            vGridControlComponente.Rows["rowRequired"].Visible = false;
            vGridControlComponente.Rows["rowRequiredMessage"].Visible = false;
            vGridControlComponente.Rows["rowDefaultValue"].Visible = false;
            vGridControlComponente.Rows["rowParameter"].Visible = false;
            vGridControlComponente.Rows["rowNullText"].Visible = false;
            vGridControlComponente.Rows["rowMask"].Visible = false;
            vGridControlComponente.Rows["rowHint"].Visible = false;
            vGridControlComponente.Rows["rowTabIndex"].Visible = false;
            vGridControlComponente.Rows["rowCaption"].Visible = false;
            vGridControlComponente.Rows["rowLoad"].Visible = false;
            vGridControlComponente.Rows["rowClose"].Visible = false;
            vGridControlComponente.Rows["rowBeforePrint"].Visible = false;
            vGridControlComponente.Rows["rowAfterPrint"].Visible = false;
            vGridControlComponente.Rows["categoryEventos"].Visible = false;
            vGridControlComponente.Rows["categoryLayout"].Visible = false;
            vGridControlComponente.Rows["categoryDatabase"].Visible = false;
            vGridControlComponente.Rows["categoryParameter"].Visible = false;
            vGridControlComponente.Rows["categoryAppearance"].Visible = false;
            vGridControlComponente.Rows["categoryBehavior"].Visible = false;
            vGridControlComponente.Rows["categoryMisc"].Visible = false;
        }

        private void AtualizarPanelControl()
        {
            vGridControlComponente.Rows["rowComponentType"].Visible = true;
            vGridControlComponente.Rows["rowName"].Visible = true;
            vGridControlComponente.Rows["rowTop"].Visible = true;
            vGridControlComponente.Rows["rowLeft"].Visible = true;
            vGridControlComponente.Rows["rowHeight"].Visible = true;
            vGridControlComponente.Rows["rowWidth"].Visible = true;
            vGridControlComponente.Rows["categoryLayout"].Visible = true;
        }

        private void AtualizarLabelControl()
        {
            vGridControlComponente.Rows["rowComponentType"].Visible = true;
            vGridControlComponente.Rows["rowName"].Visible = true;
            vGridControlComponente.Rows["rowTop"].Visible = true;
            vGridControlComponente.Rows["rowLeft"].Visible = true;
            vGridControlComponente.Rows["rowHeight"].Visible = true;
            vGridControlComponente.Rows["rowWidth"].Visible = true;
            vGridControlComponente.Rows["rowCaption"].Visible = true;
            vGridControlComponente.Rows["categoryLayout"].Visible = true;
            vGridControlComponente.Rows["categoryAppearance"].Visible = true;
        }

        private void AtualizarGroupControl()
        {
            vGridControlComponente.Rows["rowComponentType"].Visible = true;
            vGridControlComponente.Rows["rowName"].Visible = true;
            vGridControlComponente.Rows["rowTop"].Visible = true;
            vGridControlComponente.Rows["rowLeft"].Visible = true;
            vGridControlComponente.Rows["rowHeight"].Visible = true;
            vGridControlComponente.Rows["rowWidth"].Visible = true;
            vGridControlComponente.Rows["rowTabIndex"].Visible = true;
            vGridControlComponente.Rows["rowCaption"].Visible = true;
            vGridControlComponente.Rows["categoryLayout"].Visible = true;
            vGridControlComponente.Rows["categoryAppearance"].Visible = true;
            vGridControlComponente.Rows["categoryBehavior"].Visible = true;
        }

        private void AtualizarFormulario()
        {
            vGridControlComponente.Rows["rowComponentType"].Visible = true;
            vGridControlComponente.Rows["rowHeight"].Visible = true;
            vGridControlComponente.Rows["rowWidth"].Visible = true;
            vGridControlComponente.Rows["rowLoad"].Visible = true;
            vGridControlComponente.Rows["rowClose"].Visible = true;
            vGridControlComponente.Rows["rowBeforePrint"].Visible = true;
            vGridControlComponente.Rows["rowAfterPrint"].Visible = true;
            vGridControlComponente.Rows["categoryEventos"].Visible = true;
            vGridControlComponente.Rows["categoryLayout"].Visible = true;
        }

        private void AtualizarTextEdit()
        {
            vGridControlComponente.Rows["rowComponentType"].Visible = true;
            vGridControlComponente.Rows["rowName"].Visible = true;
            vGridControlComponente.Rows["rowTop"].Visible = true;
            vGridControlComponente.Rows["rowLeft"].Visible = true;
            vGridControlComponente.Rows["rowHeight"].Visible = true;
            vGridControlComponente.Rows["rowWidth"].Visible = true;
            vGridControlComponente.Rows["rowLeave"].Visible = true;
            vGridControlComponente.Rows["rowEnter"].Visible = true;
            vGridControlComponente.Rows["rowChange"].Visible = true;
            vGridControlComponente.Rows["rowAligment"].Visible = true;
            vGridControlComponente.Rows["rowRequired"].Visible = true;
            vGridControlComponente.Rows["rowRequiredMessage"].Visible = true;
            vGridControlComponente.Rows["rowDefaultValue"].Visible = true;
            vGridControlComponente.Rows["rowParameter"].Visible = true;
            vGridControlComponente.Rows["rowNullText"].Visible = true;
            vGridControlComponente.Rows["rowMask"].Visible = true;
            vGridControlComponente.Rows["rowHint"].Visible = true;
            vGridControlComponente.Rows["rowTabIndex"].Visible = true;
            vGridControlComponente.Rows["categoryEventos"].Visible = true;
            vGridControlComponente.Rows["categoryLayout"].Visible = true;
            vGridControlComponente.Rows["categoryParameter"].Visible = true;
            vGridControlComponente.Rows["categoryAppearance"].Visible = true;
            vGridControlComponente.Rows["categoryBehavior"].Visible = true;
        }

        private void AtualizarDateEdit()
        {
            vGridControlComponente.Rows["rowComponentType"].Visible = true;
            vGridControlComponente.Rows["rowName"].Visible = true;
            vGridControlComponente.Rows["rowTop"].Visible = true;
            vGridControlComponente.Rows["rowLeft"].Visible = true;
            vGridControlComponente.Rows["rowHeight"].Visible = true;
            vGridControlComponente.Rows["rowWidth"].Visible = true;
            vGridControlComponente.Rows["rowLeave"].Visible = true;
            vGridControlComponente.Rows["rowEnter"].Visible = true;
            vGridControlComponente.Rows["rowChange"].Visible = true;
            vGridControlComponente.Rows["rowRequired"].Visible = true;
            vGridControlComponente.Rows["rowRequiredMessage"].Visible = true;
            vGridControlComponente.Rows["rowDefaultValue"].Visible = true;
            vGridControlComponente.Rows["rowParameter"].Visible = true;
            vGridControlComponente.Rows["rowHint"].Visible = true;
            vGridControlComponente.Rows["rowTabIndex"].Visible = true;
            vGridControlComponente.Rows["categoryEventos"].Visible = true;
            vGridControlComponente.Rows["categoryLayout"].Visible = true;
            vGridControlComponente.Rows["categoryParameter"].Visible = true;
            vGridControlComponente.Rows["categoryAppearance"].Visible = true;
            vGridControlComponente.Rows["categoryBehavior"].Visible = true;
            
        }

        private void AtualizarTimeEdit()
        {
            vGridControlComponente.Rows["rowComponentType"].Visible = true;
            vGridControlComponente.Rows["rowName"].Visible = true;
            vGridControlComponente.Rows["rowTop"].Visible = true;
            vGridControlComponente.Rows["rowLeft"].Visible = true;
            vGridControlComponente.Rows["rowHeight"].Visible = true;
            vGridControlComponente.Rows["rowWidth"].Visible = true;
            vGridControlComponente.Rows["rowLeave"].Visible = true;
            vGridControlComponente.Rows["rowEnter"].Visible = true;
            vGridControlComponente.Rows["rowChange"].Visible = true;
            vGridControlComponente.Rows["rowRequired"].Visible = true;
            vGridControlComponente.Rows["rowRequiredMessage"].Visible = true;
            vGridControlComponente.Rows["rowDefaultValue"].Visible = true;
            vGridControlComponente.Rows["rowParameter"].Visible = true;
            vGridControlComponente.Rows["rowHint"].Visible = true;
            vGridControlComponente.Rows["rowTabIndex"].Visible = true;
            vGridControlComponente.Rows["categoryEventos"].Visible = true;
            vGridControlComponente.Rows["categoryLayout"].Visible = true;
            vGridControlComponente.Rows["categoryParameter"].Visible = true;
            vGridControlComponente.Rows["categoryAppearance"].Visible = true;
            vGridControlComponente.Rows["categoryBehavior"].Visible = true;
        }

        private void AtualizarSpinEdit()
        {
            vGridControlComponente.Rows["rowComponentType"].Visible = true;
            vGridControlComponente.Rows["rowName"].Visible = true;
            vGridControlComponente.Rows["rowTop"].Visible = true;
            vGridControlComponente.Rows["rowLeft"].Visible = true;
            vGridControlComponente.Rows["rowHeight"].Visible = true;
            vGridControlComponente.Rows["rowWidth"].Visible = true;
            vGridControlComponente.Rows["rowLeave"].Visible = true;
            vGridControlComponente.Rows["rowEnter"].Visible = true;
            vGridControlComponente.Rows["rowChange"].Visible = true;
            vGridControlComponente.Rows["rowMinValue"].Visible = true;
            vGridControlComponente.Rows["rowMaxValue"].Visible = true;
            vGridControlComponente.Rows["rowRequired"].Visible = true;
            vGridControlComponente.Rows["rowRequiredMessage"].Visible = true;
            vGridControlComponente.Rows["rowDefaultValue"].Visible = true;
            vGridControlComponente.Rows["rowParameter"].Visible = true;
            vGridControlComponente.Rows["rowHint"].Visible = true;
            vGridControlComponente.Rows["rowTabIndex"].Visible = true;
            vGridControlComponente.Rows["categoryEventos"].Visible = true;
            vGridControlComponente.Rows["categoryLayout"].Visible = true;
            vGridControlComponente.Rows["categoryParameter"].Visible = true;
            vGridControlComponente.Rows["categoryAppearance"].Visible = true;
            vGridControlComponente.Rows["categoryBehavior"].Visible = true;
        }

        private void AtualizarCheckBox()
        {
            vGridControlComponente.Rows["rowComponentType"].Visible = true;
            vGridControlComponente.Rows["rowName"].Visible = true;
            vGridControlComponente.Rows["rowTop"].Visible = true;
            vGridControlComponente.Rows["rowLeft"].Visible = true;
            vGridControlComponente.Rows["rowHeight"].Visible = true;
            vGridControlComponente.Rows["rowWidth"].Visible = true;
            vGridControlComponente.Rows["rowLeave"].Visible = true;
            vGridControlComponente.Rows["rowEnter"].Visible = true;
            vGridControlComponente.Rows["rowChange"].Visible = true;
            vGridControlComponente.Rows["rowComponents"].Visible = true;
            vGridControlComponente.Rows["rowDefaultValue"].Visible = true;
            vGridControlComponente.Rows["rowParameter"].Visible = true;
            vGridControlComponente.Rows["rowHint"].Visible = true;
            vGridControlComponente.Rows["rowTabIndex"].Visible = true;
            vGridControlComponente.Rows["rowCaption"].Visible = true;
            vGridControlComponente.Rows["categoryEventos"].Visible = true;
            vGridControlComponente.Rows["categoryLayout"].Visible = true;
            vGridControlComponente.Rows["categoryParameter"].Visible = true;
            vGridControlComponente.Rows["categoryAppearance"].Visible = true;
            vGridControlComponente.Rows["categoryBehavior"].Visible = true;
            vGridControlComponente.Rows["categoryMisc"].Visible = true;
        }

        private void AtualizarRadioButton()
        {
            vGridControlComponente.Rows["rowComponentType"].Visible = true;
            vGridControlComponente.Rows["rowName"].Visible = true;
            vGridControlComponente.Rows["rowTop"].Visible = true;
            vGridControlComponente.Rows["rowLeft"].Visible = true;
            vGridControlComponente.Rows["rowHeight"].Visible = true;
            vGridControlComponente.Rows["rowWidth"].Visible = true;
            vGridControlComponente.Rows["rowLeave"].Visible = true;
            vGridControlComponente.Rows["rowEnter"].Visible = true;
            vGridControlComponente.Rows["rowChange"].Visible = true;
            vGridControlComponente.Rows["rowGroupIndex"].Visible = true;
            vGridControlComponente.Rows["rowValueChecked"].Visible = true;
            vGridControlComponente.Rows["rowValueUnchecked"].Visible = true;
            vGridControlComponente.Rows["rowGroupIndex"].Visible = true;
            vGridControlComponente.Rows["rowDefaultValue"].Visible = true;
            vGridControlComponente.Rows["rowParameter"].Visible = true;
            vGridControlComponente.Rows["rowHint"].Visible = true;
            vGridControlComponente.Rows["rowTabIndex"].Visible = true;
            vGridControlComponente.Rows["rowCaption"].Visible = true;
            vGridControlComponente.Rows["categoryEventos"].Visible = true;
            vGridControlComponente.Rows["categoryLayout"].Visible = true;
            vGridControlComponente.Rows["categoryParameter"].Visible = true;
            vGridControlComponente.Rows["categoryAppearance"].Visible = true;
            vGridControlComponente.Rows["categoryBehavior"].Visible = true;
            vGridControlComponente.Rows["categoryMisc"].Visible = true;
        }

        private void AtualizarCombokBox(bool db)
        {
            vGridControlComponente.Rows["rowComponentType"].Visible = true;
            vGridControlComponente.Rows["rowName"].Visible = true;
            vGridControlComponente.Rows["rowTop"].Visible = true;
            vGridControlComponente.Rows["rowLeft"].Visible = true;
            vGridControlComponente.Rows["rowHeight"].Visible = true;
            vGridControlComponente.Rows["rowWidth"].Visible = true;
            vGridControlComponente.Rows["rowLeave"].Visible = true;
            vGridControlComponente.Rows["rowEnter"].Visible = true;
            vGridControlComponente.Rows["rowChange"].Visible = true;
            vGridControlComponente.Rows["rowSQL"].Visible = db;
            vGridControlComponente.Rows["rowShowField"].Visible = db;
            vGridControlComponente.Rows["rowKeyField"].Visible = db;
            vGridControlComponente.Rows["rowValues"].Visible = !db;
            vGridControlComponente.Rows["rowDescriptions"].Visible = !db;
            vGridControlComponente.Rows["rowDefaultValue"].Visible = true;
            vGridControlComponente.Rows["rowParameter"].Visible = true;
            vGridControlComponente.Rows["rowHint"].Visible = true;
            vGridControlComponente.Rows["rowTabIndex"].Visible = true;
            vGridControlComponente.Rows["categoryEventos"].Visible = true;
            vGridControlComponente.Rows["categoryLayout"].Visible = true;
            vGridControlComponente.Rows["categoryDatabase"].Visible = db;
            vGridControlComponente.Rows["categoryParameter"].Visible = true;
            vGridControlComponente.Rows["categoryAppearance"].Visible = true;
            vGridControlComponente.Rows["categoryBehavior"].Visible = true;
            vGridControlComponente.Rows["categoryMisc"].Visible = !db;
        }

        private void AtualizarRadioGroup(bool db)
        {
            vGridControlComponente.Rows["rowComponentType"].Visible = true;
            vGridControlComponente.Rows["rowName"].Visible = true;
            vGridControlComponente.Rows["rowTop"].Visible = true;
            vGridControlComponente.Rows["rowLeft"].Visible = true;
            vGridControlComponente.Rows["rowHeight"].Visible = true;
            vGridControlComponente.Rows["rowWidth"].Visible = true;
            vGridControlComponente.Rows["rowLeave"].Visible = true;
            vGridControlComponente.Rows["rowEnter"].Visible = true;
            vGridControlComponente.Rows["rowChange"].Visible = true;
            vGridControlComponente.Rows["rowSQL"].Visible = db;
            vGridControlComponente.Rows["rowShowField"].Visible = db;
            vGridControlComponente.Rows["rowKeyField"].Visible = db;
            vGridControlComponente.Rows["rowColumns"].Visible = true;
            vGridControlComponente.Rows["rowValues"].Visible = !db;
            vGridControlComponente.Rows["rowDescriptions"].Visible = !db;
            vGridControlComponente.Rows["rowDefaultValue"].Visible = true;
            vGridControlComponente.Rows["rowParameter"].Visible = true;
            vGridControlComponente.Rows["rowNullText"].Visible = false;
            vGridControlComponente.Rows["rowHint"].Visible = true;
            vGridControlComponente.Rows["rowTabIndex"].Visible = true;
            vGridControlComponente.Rows["categoryEventos"].Visible = true;
            vGridControlComponente.Rows["categoryLayout"].Visible = true;
            vGridControlComponente.Rows["categoryDatabase"].Visible = db;
            vGridControlComponente.Rows["categoryParameter"].Visible = true;
            vGridControlComponente.Rows["categoryAppearance"].Visible = true;
            vGridControlComponente.Rows["categoryBehavior"].Visible = true;
            vGridControlComponente.Rows["categoryMisc"].Visible = !db;
        }

        private void AtualizarCheckListBox(bool db)
        {
            vGridControlComponente.Rows["rowComponentType"].Visible = true;
            vGridControlComponente.Rows["rowName"].Visible = true;
            vGridControlComponente.Rows["rowTop"].Visible = true;
            vGridControlComponente.Rows["rowLeft"].Visible = true;
            vGridControlComponente.Rows["rowHeight"].Visible = true;
            vGridControlComponente.Rows["rowWidth"].Visible = true;
            vGridControlComponente.Rows["rowLeave"].Visible = true;
            vGridControlComponente.Rows["rowEnter"].Visible = true;
            vGridControlComponente.Rows["rowChange"].Visible = true;
            vGridControlComponente.Rows["rowSQL"].Visible = db;
            vGridControlComponente.Rows["rowShowField"].Visible = db;
            vGridControlComponente.Rows["rowKeyField"].Visible = db;
            vGridControlComponente.Rows["rowColumns"].Visible = true;
            vGridControlComponente.Rows["rowValues"].Visible = !db;
            vGridControlComponente.Rows["rowDescriptions"].Visible = !db;
            vGridControlComponente.Rows["rowDefaultValue"].Visible = true;
            vGridControlComponente.Rows["rowParameter"].Visible = true;
            vGridControlComponente.Rows["rowHint"].Visible = true;
            vGridControlComponente.Rows["rowTabIndex"].Visible = true;
            vGridControlComponente.Rows["categoryEventos"].Visible = true;
            vGridControlComponente.Rows["categoryLayout"].Visible = true;
            vGridControlComponente.Rows["categoryDatabase"].Visible = db;
            vGridControlComponente.Rows["categoryParameter"].Visible = true;
            vGridControlComponente.Rows["categoryAppearance"].Visible = true;
            vGridControlComponente.Rows["categoryBehavior"].Visible = true;
            vGridControlComponente.Rows["categoryMisc"].Visible = !db;
        }
    }
}
