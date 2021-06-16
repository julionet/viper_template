using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace Chronus.DXperience
{
    public partial class FrmParametroRelatorioDX : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int _quantidade = 0;
        private List<ComponenteRelatorio> _componentes = new List<ComponenteRelatorio>();

        public string XmlParameter
        {
            get { return ComponenteHelper.ObterXml(_componentes.ToArray()); }
        }

        public FrmParametroRelatorioDX(string descricao, string xml)
        {
            InitializeComponent();
            ribbonControl.ApplicationDocumentCaption = descricao;

            if (!string.IsNullOrWhiteSpace(xml))
            {
                this.CarregarComponentes(xml);
            }
            else
            {
                _componentes.Add(new ComponenteRelatorio
                {
                    ComponentType = ComponentType.TFormularioDX,
                    Height = panelControlComponente.Height,
                    Width = panelControlComponente.Width,
                    Name = panelControlComponente.Name
                });                
            }
            this.AtualizarLabelComponente(null);
        }
          
        private void AtualizarLabelComponente(Control control)
        {
            if (control == null)
            {
                labelControlComponente.Text = "FormularioDX: TFormularioDX";
                labelControlComponente.Tag = null;
                bindingSourceComponente.DataSource = _componentes.Where(p => p.Name == panelControlComponente.Name);
                new VerticalGridHelper(vGridControlComponente).AtualizarVerticalGrid(ComponentType.TFormularioDX);
            }
            else
            {
                labelControlComponente.Text = $"{control.Name}: {control.Tag.ToString()}";
                labelControlComponente.Tag = control;
                bindingSourceComponente.DataSource = _componentes.Where(p => p.Name == control.Name);
                new VerticalGridHelper(vGridControlComponente).AtualizarVerticalGrid(ComponenteHelper.GetComponentType(control));
            }
        }

        private ComponentType ObterComponenteSelecionado()
        {
            if (barButtonItemShape.Down) return ComponentType.TShapeDX;
            else if (barButtonItemGroupBox.Down) return ComponentType.TGroupBoxDX;
            else if (barButtonItemLabel.Down) return ComponentType.TLabelDX;
            else if (barButtonItemTextEdit.Down) return ComponentType.TTextEditDX;
            else if (barButtonItemDateEdit.Down) return ComponentType.TDateEditDX;
            else if (barButtonItemTimeEdit.Down) return ComponentType.TTimeEditDX;
            else if (barButtonItemSpinEdit.Down) return ComponentType.TSpinEditDX;
            else if (barButtonItemCheckEdit.Down) return ComponentType.TCheckBoxDX;
            else if (barButtonItemRadioButton.Down) return ComponentType.TRadioButtonDX;
            else if (barButtonItemComboBox.Down) return ComponentType.TComboBoxDX;
            else if (barButtonItemRadioGroup.Down) return ComponentType.TRadioGroupDX;
            else if (barButtonItemCheckListBox.Down) return ComponentType.TCheckListBoxDX;
            else if (barButtonItemComboBoxDb.Down) return ComponentType.TDBComboBoxDX;
            else if (barButtonItemRadioGroupDb.Down) return ComponentType.TDBRadioGroupDX;
            else if (barButtonItemCheckListBoxDb.Down) return ComponentType.TDBCheckListBoxDX;
            else
                return default(ComponentType);
        }

        private void DeleteObject(string name, Control controles)
        {
            foreach (Control control in controles.Controls)
            {
                if (control.Name == name)
                    controles.Controls.Remove(control);
            }
        }

        private Control GetObject(string name, Control controles)
        {
            foreach (Control control in controles.Controls)
            {
                if (control.Name == name)
                    return control;

                if (control is PanelControl || control is GroupControl)
                {
                    if (GetObject(name, control) is Control c && c.Name == name)
                        return c;
                }
            }
            return null;
        }

        private void CarregarComponentes(string xml)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(XmlReader.Create(new StringReader(xml)));

            panelControlComponente.Height = Convert.ToInt32(ds.Tables[0].Rows[0]["Height"]);
            panelControlComponente.Width = Convert.ToInt32(ds.Tables[0].Rows[0]["Width"]);

            ComponenteHelper helper = new ComponenteHelper(panelControlComponente);
            helper.BindingSource = bindingSourceComponente;
            helper.VerticalGrid = vGridControlComponente;
            helper.Componentes = _componentes;
            helper.ContextMenuStrip = contextMenuStrip;
            helper.EventoClick = Componente_Click;
            helper.EventoMouseUp = SalvarComponente_MouseUp;
            foreach (DataRow dr in ds.Tables[1].Rows)
            {
                helper.XmlComponente = dr;
                switch (ComponenteHelper.GetComponentType(dr["Type"].ToString()))
                {
                    case ComponentType.TFormularioDX:
                        helper.CriarFormulario();
                        break;
                    case ComponentType.TShapeDX:
                        helper.CriarPanelControl();
                        break;
                    case ComponentType.TGroupBoxDX:
                        helper.CriarGroupControl();
                        break;
                    case ComponentType.TLabelDX:
                        helper.CriarLabelControl();
                        break;
                    case ComponentType.TTextEditDX:
                        helper.CriarTextEdit();
                        break;
                    case ComponentType.TDateEditDX:
                        helper.CriarDateEdit();
                        break;
                    case ComponentType.TTimeEditDX:
                        helper.CriarTimeEdit();
                        break;
                    case ComponentType.TSpinEditDX:
                        helper.CriarSpinEdit();
                        break;
                    case ComponentType.TCheckBoxDX:
                        helper.CriarCheckEdit();
                        break;
                    case ComponentType.TRadioButtonDX:
                        helper.CriarRadioButton();
                        break;
                    case ComponentType.TComboBoxDX:
                        helper.CriarComboBox();
                        break;
                    case ComponentType.TDBComboBoxDX:
                        helper.CriarComboBox();
                        break;
                    case ComponentType.TRadioGroupDX:
                        helper.CriarRadioGroup();
                        break;
                    case ComponentType.TDBRadioGroupDX:
                        helper.CriarRadioGroup();
                        break;
                    case ComponentType.TCheckListBoxDX:
                        helper.CriarCheckedListBoxControl();
                        break;
                    case ComponentType.TDBCheckListBoxDX:
                        helper.CriarCheckedListBoxControl();
                        break;
                }
            }

            if (_componentes.Where(p => p.ComponentType == ComponentType.TFormularioDX).Count() == 0)
            {
                _componentes.Insert(0, new ComponenteRelatorio
                {
                    ComponentType = ComponentType.TFormularioDX,
                    Height = panelControlComponente.Height,
                    Width = panelControlComponente.Width,
                    Name = panelControlComponente.Name
                });
            }
        }

        private void panelControlComponente_MouseUp(object sender, MouseEventArgs e)
        {
            if (!barButtonItemCursor.Down)
                _quantidade++;
            else
            {
                if ((sender is PanelControl) && (sender as PanelControl).Name == "panelControlComponente")
                {
                    this.AtualizarLabelComponente(null);
                    return;
                }
                else
                    return;
            }

            Control componente = null;

            ComponenteHelper helper = new ComponenteHelper(panelControlComponente)
            {
                BindingSource = bindingSourceComponente,
                VerticalGrid = vGridControlComponente,
                Componentes = _componentes,
                ContextMenuStrip = contextMenuStrip,
                EventoClick = Componente_Click,
                EventoMouseUp = SalvarComponente_MouseUp
            };

            ComponentType type = this.ObterComponenteSelecionado();
            switch (type)
            {
                case ComponentType.TShapeDX:
                    helper.NewComponente = new Tuple<int, int, int, int, string, int> (e.Y, e.X, 100, 100, "ShapeDX", _quantidade);
                    componente = helper.CriarPanelControl();
                    break;
                case ComponentType.TGroupBoxDX:
                    helper.NewComponente = new Tuple<int, int, int, int, string, int>(e.Y, e.X, 100, 100, "GroupBoxDX", _quantidade);
                    componente = helper.CriarGroupControl();
                    break;
                case ComponentType.TLabelDX:
                    helper.NewComponente = new Tuple<int, int, int, int, string, int>(e.Y, e.X, 0, 0, "LabelDX", _quantidade);
                    componente = helper.CriarLabelControl();
                    break;
                case ComponentType.TTextEditDX:
                    helper.NewComponente = new Tuple<int, int, int, int, string, int>(e.Y, e.X, 20, 100, "TextEditDX", _quantidade);
                    componente = helper.CriarTextEdit();
                    break;
                case ComponentType.TDateEditDX:
                    helper.NewComponente = new Tuple<int, int, int, int, string, int>(e.Y, e.X, 20, 100, "DateEditDX", _quantidade);
                    componente = helper.CriarDateEdit();
                    break;
                case ComponentType.TTimeEditDX:
                    helper.NewComponente = new Tuple<int, int, int, int, string, int>(e.Y, e.X, 20, 100, "TimeEditDX", _quantidade);
                    componente = helper.CriarTimeEdit();
                    break;
                case ComponentType.TSpinEditDX:
                    helper.NewComponente = new Tuple<int, int, int, int, string, int>(e.Y, e.X, 20, 100, "SpinEditDX", _quantidade);
                    componente = helper.CriarSpinEdit();
                    break;
                case ComponentType.TCheckBoxDX:
                    helper.NewComponente = new Tuple<int, int, int, int, string, int>(e.Y, e.X, 20, 100, "CheckBoxDX", _quantidade);
                    componente = helper.CriarCheckEdit();
                    break;
                case ComponentType.TRadioButtonDX:
                    helper.NewComponente = new Tuple<int, int, int, int, string, int>(e.Y, e.X, 20, 100, "RadioButtonDX", _quantidade);
                    componente = helper.CriarCheckEdit();
                    break;
                case ComponentType.TComboBoxDX:
                    helper.NewComponente = new Tuple<int, int, int, int, string, int>(e.Y, e.X, 20, 100, "ComboBoxDX", _quantidade);
                    componente = helper.CriarComboBox();
                    break;
                case ComponentType.TDBComboBoxDX:
                    helper.NewComponente = new Tuple<int, int, int, int, string, int>(e.Y, e.X, 20, 100, "DBComboBoxDX", _quantidade);
                    componente = helper.CriarComboBox();
                    break;
                case ComponentType.TRadioGroupDX:
                    helper.NewComponente = new Tuple<int, int, int, int, string, int>(e.Y, e.X, 100, 100, "RadioGroupDX", _quantidade);
                    componente = helper.CriarRadioGroup();
                    break;
                case ComponentType.TDBRadioGroupDX:
                    helper.NewComponente = new Tuple<int, int, int, int, string, int>(e.Y, e.X, 100, 100, "DBRadioGroupDX", _quantidade);
                    componente = helper.CriarRadioGroup();
                    break;
                case ComponentType.TCheckListBoxDX:
                    helper.NewComponente = new Tuple<int, int, int, int, string, int>(e.Y, e.X, 100, 100, "CheckListBoxDX", _quantidade);
                    componente = helper.CriarCheckedListBoxControl();
                    break;
                case ComponentType.TDBCheckListBoxDX:
                    helper.NewComponente = new Tuple<int, int, int, int, string, int>(e.Y, e.X, 100, 100, "DBCheckListBoxDX", _quantidade);
                    componente = helper.CriarCheckedListBoxControl();
                    break;
            }

            this.AtualizarLabelComponente(componente);
            barButtonItemCursor.Down = true;
        }

        private void SalvarComponente_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                (bindingSourceComponente.Current as ComponenteRelatorio).Top = (sender as Control).Top;
                (bindingSourceComponente.Current as ComponenteRelatorio).Left = (sender as Control).Left;
                (bindingSourceComponente.Current as ComponenteRelatorio).Height = (sender as Control).Height;
                (bindingSourceComponente.Current as ComponenteRelatorio).Width = (sender as Control).Width;
                bindingSourceComponente.ResetCurrentItem();
            }
        }

        private void Componente_Click(object sender, EventArgs e)
        {
            this.AtualizarLabelComponente(sender as Control);
        }

        private void vGridControlComponente_CellValueChanged(object sender, DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs e)
        {
            if ((bindingSourceComponente.Current as ComponenteRelatorio).ComponentType == ComponentType.TFormularioDX)
            {
                panelControlComponente.Height = (bindingSourceComponente.Current as ComponenteRelatorio).Height;
                panelControlComponente.Width = (bindingSourceComponente.Current as ComponenteRelatorio).Width;
            }
            else if ((bindingSourceComponente.Current as ComponenteRelatorio).ComponentType == ComponentType.TGroupBoxDX ||
                (bindingSourceComponente.Current as ComponenteRelatorio).ComponentType == ComponentType.TLabelDX ||
                (bindingSourceComponente.Current as ComponenteRelatorio).ComponentType == ComponentType.TCheckBoxDX ||
                (bindingSourceComponente.Current as ComponenteRelatorio).ComponentType == ComponentType.TRadioButtonDX)
            {
                Control control = GetObject((bindingSourceComponente.Current as ComponenteRelatorio).Name, panelControlComponente);
                control.Top = (bindingSourceComponente.Current as ComponenteRelatorio).Top;
                control.Left = (bindingSourceComponente.Current as ComponenteRelatorio).Left;
                control.Height = (bindingSourceComponente.Current as ComponenteRelatorio).Height;
                control.Width = (bindingSourceComponente.Current as ComponenteRelatorio).Width;
                control.Text = (bindingSourceComponente.Current as ComponenteRelatorio).Caption;
            }
            else if ((bindingSourceComponente.Current as ComponenteRelatorio).ComponentType == ComponentType.TRadioGroupDX ||
                (bindingSourceComponente.Current as ComponenteRelatorio).ComponentType == ComponentType.TDBRadioGroupDX)
            {
                RadioGroup radioGroup = GetObject((bindingSourceComponente.Current as ComponenteRelatorio).Name, panelControlComponente) as RadioGroup;
                radioGroup.Top = (bindingSourceComponente.Current as ComponenteRelatorio).Top;
                radioGroup.Left = (bindingSourceComponente.Current as ComponenteRelatorio).Left;
                radioGroup.Height = (bindingSourceComponente.Current as ComponenteRelatorio).Height;
                radioGroup.Width = (bindingSourceComponente.Current as ComponenteRelatorio).Width;
                radioGroup.Properties.Columns = (bindingSourceComponente.Current as ComponenteRelatorio).Columns;
                radioGroup.Properties.Items.Clear();
                string[] values = (bindingSourceComponente.Current as ComponenteRelatorio).Values != null ?
                    (bindingSourceComponente.Current as ComponenteRelatorio).Values.Split(new char[] { '\r', '\n' }) : null;
                string[] descriptions = (bindingSourceComponente.Current as ComponenteRelatorio).Descriptions != null ?
                    (bindingSourceComponente.Current as ComponenteRelatorio).Descriptions.Split(new char[] { '\r', '\n' }) : null;
                if (values != null && descriptions != null && values.Count()  == descriptions.Count())
                {
                    for (int i = 0; i < values.Count(); i++)
                    {
                        if (values[i] != "")
                            radioGroup.Properties.Items.Add(new RadioGroupItem(values[i], descriptions[i]));
                    }
                }
            }
            else if ((bindingSourceComponente.Current as ComponenteRelatorio).ComponentType == ComponentType.TCheckListBoxDX ||
                (bindingSourceComponente.Current as ComponenteRelatorio).ComponentType == ComponentType.TDBCheckListBoxDX)
            {
                CheckedListBoxControl checkListBox = GetObject((bindingSourceComponente.Current as ComponenteRelatorio).Name, panelControlComponente) as CheckedListBoxControl;
                checkListBox.Top = (bindingSourceComponente.Current as ComponenteRelatorio).Top;
                checkListBox.Left = (bindingSourceComponente.Current as ComponenteRelatorio).Left;
                checkListBox.Height = (bindingSourceComponente.Current as ComponenteRelatorio).Height;
                checkListBox.Width = (bindingSourceComponente.Current as ComponenteRelatorio).Width;
                //checkListBox.Columns = (bindingSourceComponente.Current as ComponenteDX).Columns;
                checkListBox.Items.Clear();
                string[] values = (bindingSourceComponente.Current as ComponenteRelatorio).Values != null ?
                    (bindingSourceComponente.Current as ComponenteRelatorio).Values.Split(new char[] { '\r', '\n' }) : null;
                string[] descriptions = (bindingSourceComponente.Current as ComponenteRelatorio).Descriptions != null ?
                    (bindingSourceComponente.Current as ComponenteRelatorio).Descriptions.Split(new char[] { '\r', '\n' }) : null;
                if (values != null && descriptions != null && values.Count() == descriptions.Count())
                {
                    for (int i = 0; i < values.Count(); i++)
                    {
                        if (values[i] != "")
                            checkListBox.Items.Add(values[i], descriptions[i], CheckState.Unchecked, true);
                    }
                }
            }
            else 
            {
                Control control = GetObject((bindingSourceComponente.Current as ComponenteRelatorio).Name, panelControlComponente) as Control;
                control.Top = (bindingSourceComponente.Current as ComponenteRelatorio).Top;
                control.Left = (bindingSourceComponente.Current as ComponenteRelatorio).Left;
                control.Height = (bindingSourceComponente.Current as ComponenteRelatorio).Height;
                control.Width = (bindingSourceComponente.Current as ComponenteRelatorio).Width;
            }
        }

        private void trazerParaFrenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripItem menuItem)
            {
                if (menuItem.Owner is ContextMenuStrip owner)
                {
                    Control sourceControl = owner.SourceControl;
                    sourceControl.BringToFront();
                }
            }
        }

        private void enivarParaTrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripItem menuItem)
            {
                if (menuItem.Owner is ContextMenuStrip owner)
                {
                    Control sourceControl = owner.SourceControl;
                    sourceControl.SendToBack();
                }
            }
        }
               
        private void barButtonItemRemover_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ((bindingSourceComponente.Current as ComponenteRelatorio).ComponentType != ComponentType.TFormularioDX)
            {
                if (XtraMessageBox.Show("Deseja realmente excluir componente selecionado?", "Confirmação", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    _componentes.Remove(_componentes.Where(p => p.Name == (bindingSourceComponente.Current as ComponenteRelatorio).Name).FirstOrDefault());
                    this.DeleteObject((bindingSourceComponente.Current as ComponenteRelatorio).Name, panelControlComponente);
                    bindingSourceComponente.DataSource = _componentes.Where(p => p.Name == panelControlComponente.Name);
                    new VerticalGridHelper(vGridControlComponente).AtualizarVerticalGrid(ComponentType.TFormularioDX);
                }
            }
        }

        private void barButtonItemSalvar_ItemClick(object sender, ItemClickEventArgs e)
        {
            bindingSourceComponente.ResetCurrentItem();
            this.DialogResult = DialogResult.OK;
        }

        private void barButtonItemCancelar_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
