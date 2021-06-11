using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraVerticalGrid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Chronus.DXperience
{
    public class ComponenteHelper
    {
        private PanelControl _panelbackground = null;

        private int _top, _left, _width, _height;
        private string _name, _type, _caption;

        private VGridControl _verticalgrid = null;
        public VGridControl VerticalGrid
        {
            set => _verticalgrid = value;
        }

        private BindingSource _bindingsource = null;
        public BindingSource BindingSource
        {
            set => _bindingsource = value;
        }

        private List<ComponenteRelatorio> _componentes;
        public List<ComponenteRelatorio> Componentes
        {
            set => _componentes = value;
        }

        private ContextMenuStrip _contextmenustrip;
        public ContextMenuStrip ContextMenuStrip
        {
            set => _contextmenustrip = value;
        }

        private EventHandler _eventoclick;
        public EventHandler EventoClick
        {
            set => _eventoclick = value;
        }

        private MouseEventHandler _eventomouseup;
        public MouseEventHandler EventoMouseUp
        {
            set => _eventomouseup = value;
        }

        private DataRow _xmlcomponente = null;
        public DataRow XmlComponente
        {
            set
            {
                _xmlcomponente = value;
                _top = Convert.ToInt32(value["Top"]);
                _left = Convert.ToInt32(value["Left"]);
                _width = Convert.ToInt32(value["Width"]);
                _height = Convert.ToInt32(value["Height"]);
                _name = value["Name"].ToString();
                _type = value["Type"].ToString();
                if (value.Table.Columns.Contains("Caption"))
                    _caption = value["Caption"].ToString();
            }
        }
        
        public Tuple<int, int, int, int, string, int> NewComponente
        {
            set
            {
                _top = value.Item1;
                _left = value.Item2;
                _height = value.Item3;
                _width = value.Item4;
                _caption = value.Item5;
                _name = value.Item5 + value.Item6.ToString();
                _type = "T" + value.Item5;
            }
        }

        public ComponenteHelper(PanelControl panelbackground)
        {
            _panelbackground = panelbackground;
        }

        public static ComponentType GetComponentType(String type)
        {
            switch (type)
            {
                case "TShapeDX":
                    return ComponentType.TShapeDX;
                case "TGroupBoxDX":
                    return ComponentType.TGroupBoxDX;
                case "TLabelDX":
                    return ComponentType.TLabelDX;
                case "TTextEditDX":
                    return ComponentType.TTextEditDX;
                case "TDateEditDX":
                    return ComponentType.TDateEditDX;
                case "TTimeEditDX":
                    return ComponentType.TTimeEditDX;
                case "TSpinEditDX":
                    return ComponentType.TSpinEditDX;
                case "TCheckBoxDX":
                    return ComponentType.TCheckBoxDX;
                case "TRadioButtonDX":
                    return ComponentType.TRadioButtonDX;
                case "TComboBoxDX":
                    return ComponentType.TComboBoxDX;
                case "TDBComboBoxDX":
                    return ComponentType.TDBComboBoxDX;
                case "TRadioGroupDX":
                    return ComponentType.TRadioGroupDX;
                case "TDBRadioGroupDX":
                    return ComponentType.TDBRadioGroupDX;
                case "TCheckListBoxDX":
                    return ComponentType.TCheckListBoxDX;
                case "TDBCheckListBoxDX":
                    return ComponentType.TDBCheckListBoxDX;
                default:
                    return default(ComponentType);
            }
        }

        public static ComponentType GetComponentType(Control control)
        {
            switch (control.GetType().Name)
            {
                case "PanelControl":
                    return ComponentType.TShapeDX;
                case "GroupControl":
                    return ComponentType.TGroupBoxDX;
                case "LabelControl":
                    return ComponentType.TLabelDX;
                case "ButtonEdit":
                    return ComponentType.TTextEditDX;
                case "DateEdit":
                    return ComponentType.TDateEditDX;
                case "TimeEdit":
                    return ComponentType.TTimeEditDX;
                case "SpinEdit":
                    return ComponentType.TSpinEditDX;
                case "CheckEdit":
                    if (control.Tag.ToString() == "TCheckBoxDX")
                        return ComponentType.TCheckBoxDX;
                    else
                        return ComponentType.TRadioButtonDX;
                case "ComboBoxEdit":
                    if (control.Tag.ToString() == "TComboBoxDX")
                        return ComponentType.TComboBoxDX;
                    else
                        return ComponentType.TDBComboBoxDX;
                case "RadioGroup":
                    if (control.Tag.ToString() == "TRadioGroupDX")
                        return ComponentType.TRadioGroupDX;
                    else
                        return ComponentType.TDBRadioGroupDX;
                case "CheckedListBoxControl":
                    if (control.Tag.ToString() == "TCheckListBoxDX")
                        return ComponentType.TCheckListBoxDX;
                    else
                        return ComponentType.TDBCheckListBoxDX;
                default:
                    return default(ComponentType);                        
            }
        }

        private DefaultValue StringToDefaultValue(string dv)
        {
            switch (dv)
            {
                case "[DATA_ATUAL]":
                    return DefaultValue.dvDataAtual;
                case "[HORA_ATUAL]":
                    return DefaultValue.dvHoraAtual;
                case "[HORA_0000]":
                    return DefaultValue.dvHora0000;
                case "[HORA_2359]":
                    return DefaultValue.dvHora2359;
                case "[ANO]":
                    return DefaultValue.dvAno;
                case "[MES]":
                    return DefaultValue.dvMes;
                case "[TRUE]":
                    return DefaultValue.dvTrue;
                case "[FALSE]":
                    return DefaultValue.dvFalse;
                case "[USUARIO_LOGADO]":
                    return DefaultValue.dvUsuarioLogado;
                default:
                    return default(DefaultValue);
            }
        }

        public void CriarFormulario()
        {
            _componentes.Add(new ComponenteRelatorio
            {
                ComponentType = ComponentType.TFormularioDX,
                Height = _panelbackground.Height,
                Width = _panelbackground.Width,
                Name = _panelbackground.Name,
                Load = _xmlcomponente != null ? _xmlcomponente["Load"].ToString().Replace("\n", "\r\n") : null,
                Close = _xmlcomponente != null ? _xmlcomponente["Close"].ToString().Replace("\n", "\r\n") : null,
                AfterPrint = _xmlcomponente != null ? _xmlcomponente["AfterPrint"].ToString().Replace("\n", "\r\n") : null,
                BeforePrint = _xmlcomponente != null ? _xmlcomponente["BeforePrint"].ToString().Replace("\n", "\r\n") : null,
            });

            _bindingsource.DataSource = _componentes.Where(p => p.Name == _panelbackground.Name);
            new VerticalGridHelper(_verticalgrid).AtualizarVerticalGrid(ComponentType.TFormularioDX);
        }

        public Control CriarPanelControl()
        {
            PanelControl panelControl = new PanelControl
            {
                Location = new Point(_left, _top),
                Size = new Size(_width, _height),
                Name = _name,
                Tag = _type,
                Visible = true,
                ContextMenuStrip = _contextmenustrip
            };
            panelControl.Click += _eventoclick;
            panelControl.MouseUp += _eventomouseup;
            _panelbackground.Controls.Add(panelControl);
            panelControl.SendToBack();

            ControlMoverOrResizer.Init(panelControl);

            _componentes.Add(new ComponenteRelatorio
            {
                ComponentType = GetComponentType(panelControl),
                Name = panelControl.Name,
                Top = panelControl.Top,
                Left = panelControl.Left,
                Height = panelControl.Height,
                Width = panelControl.Width
            });

            _bindingsource.DataSource = _componentes.Where(p => p.Name == panelControl.Name);
            new VerticalGridHelper(_verticalgrid).AtualizarVerticalGrid(GetComponentType(panelControl));

            return panelControl;
        }

        public Control CriarGroupControl()
        {
            GroupControl groupControl = new GroupControl
            {
                Location = new Point(_left, _top),
                Size = new Size(_width, _height),
                Text = _caption,
                Name = _name,
                Tag = _type,
                ContextMenuStrip = _contextmenustrip,
            };
            groupControl.Click += _eventoclick;
            groupControl.MouseUp += _eventomouseup;
            _panelbackground.Controls.Add(groupControl);
            groupControl.SendToBack();

            ControlMoverOrResizer.Init(groupControl);

            _componentes.Add(new ComponenteRelatorio
            {
                ComponentType = GetComponentType(groupControl),
                Name = groupControl.Name,
                Top = groupControl.Top,
                Left = groupControl.Left,
                Height = groupControl.Height,
                Width = groupControl.Width,
                Caption = groupControl.Text,
                TabIndex = _xmlcomponente != null ? Convert.ToInt32(_xmlcomponente["TabIndex"]) : 0
            });

            _bindingsource.DataSource = _componentes.Where(p => p.Name == groupControl.Name);
            new VerticalGridHelper(_verticalgrid).AtualizarVerticalGrid(GetComponentType(groupControl));

            return groupControl;
        }

        public Control CriarLabelControl()
        {
            LabelControl labelControl = new LabelControl
            {
                Location = new Point(_left, _top),
                Size = new Size(_width, _height),
                Text = _caption,
                Name = _name,
                Tag = _type,
                ContextMenuStrip = _contextmenustrip,
            };
            labelControl.Click += _eventoclick;
            labelControl.MouseUp += _eventomouseup;
            _panelbackground.Controls.Add(labelControl);
            labelControl.BringToFront();

            ControlMoverOrResizer.Init(labelControl);

            _componentes.Add(new ComponenteRelatorio
            {
                ComponentType = GetComponentType(labelControl),
                Name = labelControl.Name,
                Top = labelControl.Top,
                Left = labelControl.Left,
                Height = labelControl.Height,
                Width = labelControl.Width,
                Caption = labelControl.Text
            });

            _bindingsource.DataSource = _componentes.Where(p => p.Name == labelControl.Name);
            new VerticalGridHelper(_verticalgrid).AtualizarVerticalGrid(GetComponentType(labelControl));

            return labelControl;
        }

        public Control CriarTextEdit()
        {
            ButtonEdit textEdit = new ButtonEdit
            {
                Location = new Point(_left, _top),
                Size = new Size(_width, _height),
                TabStop = false,
                ReadOnly = true,
                Name = _name,
                Tag = _type,
                ContextMenuStrip = _contextmenustrip
            };
            textEdit.Click += _eventoclick;
            textEdit.MouseUp += _eventomouseup;
            textEdit.Properties.Buttons.Clear();
            textEdit.Properties.AllowFocused = false;
            textEdit.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            _panelbackground.Controls.Add(textEdit);
            textEdit.BringToFront();

            ControlMoverOrResizer.Init(textEdit);

            _componentes.Add(new ComponenteRelatorio
            {
                ComponentType = GetComponentType(textEdit),
                Name = textEdit.Name,
                Top = textEdit.Top,
                Left = textEdit.Left,
                Height = textEdit.Height,
                Width = textEdit.Width,
                TabIndex = _xmlcomponente != null ? Convert.ToInt32(_xmlcomponente["TabIndex"]) : 0,
                Hint = _xmlcomponente != null ? _xmlcomponente["Hint"].ToString() : "",
                Mask = _xmlcomponente != null ? _xmlcomponente["Mask"].ToString() : "",
                NullText = _xmlcomponente != null ? _xmlcomponente["NullText"].ToString() : "",
                Parameter = _xmlcomponente != null ? _xmlcomponente["Parameter"].ToString() : "",
                DefaultValue = _xmlcomponente != null ? this.StringToDefaultValue(_xmlcomponente["DefaultValue"].ToString()) : default(DefaultValue),
                Required = _xmlcomponente != null ? Convert.ToInt16(_xmlcomponente["Required"]) == 1 : false,
                RequiredMessage = _xmlcomponente != null ? _xmlcomponente["RequiredMessage"].ToString() : "",
                Alignment = _xmlcomponente != null ? (Alignment)Convert.ToInt16(_xmlcomponente["Alignment"]) : Alignment.taLeftAlignment,
                Leave = _xmlcomponente != null ? _xmlcomponente["Leave"].ToString().Replace("\n", "\r\n") : "",
                Enter = _xmlcomponente != null ? _xmlcomponente["Enter"].ToString().Replace("\n", "\r\n") : "",
                Change = _xmlcomponente != null ? _xmlcomponente["Change"].ToString().Replace("\n", "\r\n") : ""
            });

            _bindingsource.DataSource = _componentes.Where(p => p.Name == textEdit.Name);
            new VerticalGridHelper(_verticalgrid).AtualizarVerticalGrid(GetComponentType(textEdit));

            return textEdit;
        }

        public Control CriarDateEdit()
        {
            DateEdit dateEdit = new DateEdit
            {
                Location = new Point(_left, _top),
                Size = new Size(_width, _height),
                TabStop = false,
                ReadOnly = true,
                Name = _name,
                Tag = _type,
                ContextMenuStrip = _contextmenustrip
            };
            dateEdit.Click += _eventoclick;
            dateEdit.MouseUp += _eventomouseup;
            dateEdit.Properties.AllowDropDownWhenReadOnly = DefaultBoolean.False;
            dateEdit.Properties.AllowFocused = false;
            dateEdit.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            _panelbackground.Controls.Add(dateEdit);
            dateEdit.BringToFront();

            ControlMoverOrResizer.Init(dateEdit);

            _componentes.Add(new ComponenteRelatorio
            {
                ComponentType = GetComponentType(dateEdit),
                Name = dateEdit.Name,
                Top = dateEdit.Top,
                Left = dateEdit.Left,
                Height = dateEdit.Height,
                Width = dateEdit.Width,
                TabIndex = _xmlcomponente != null ? Convert.ToInt32(_xmlcomponente["TabIndex"]) : 0,
                Hint = _xmlcomponente != null ? _xmlcomponente["Hint"].ToString() : "",
                Parameter = _xmlcomponente != null ? _xmlcomponente["Parameter"].ToString() : "",
                DefaultValue = _xmlcomponente != null ? this.StringToDefaultValue(_xmlcomponente["DefaultValue"].ToString()) : default(DefaultValue),
                Required = _xmlcomponente != null ? Convert.ToInt16(_xmlcomponente["Required"]) == 1 : false,
                RequiredMessage = _xmlcomponente != null ? _xmlcomponente["RequiredMessage"].ToString() : "",
                Leave = _xmlcomponente != null ? _xmlcomponente["Leave"].ToString().Replace("\n", "\r\n") : "",
                Enter = _xmlcomponente != null ? _xmlcomponente["Enter"].ToString().Replace("\n", "\r\n") : "",
                Change = _xmlcomponente != null ? _xmlcomponente["Change"].ToString().Replace("\n", "\r\n") : ""
            });

            _bindingsource.DataSource = _componentes.Where(p => p.Name == dateEdit.Name);
            new VerticalGridHelper(_verticalgrid).AtualizarVerticalGrid(GetComponentType(dateEdit));

            return dateEdit;
        }

        public Control CriarTimeEdit()
        {
            TimeEdit timeEdit = new TimeEdit
            {
                Location = new Point(_left, _top),
                Size = new Size(_width, _height),
                TabStop = false,
                ReadOnly = true,
                Name = _name,
                Tag = _type,
                ContextMenuStrip = _contextmenustrip
            };
            timeEdit.Click += _eventoclick;
            timeEdit.MouseUp += _eventomouseup;
            timeEdit.Properties.AllowDropDownWhenReadOnly = DefaultBoolean.False;
            timeEdit.Properties.AllowFocused = false;
            timeEdit.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            _panelbackground.Controls.Add(timeEdit);
            timeEdit.BringToFront();

            ControlMoverOrResizer.Init(timeEdit);

            _componentes.Add(new ComponenteRelatorio
            {
                ComponentType = GetComponentType(timeEdit),
                Name = timeEdit.Name,
                Top = timeEdit.Top,
                Left = timeEdit.Left,
                Height = timeEdit.Height,
                Width = timeEdit.Width,
                TabIndex = _xmlcomponente != null ? Convert.ToInt32(_xmlcomponente["TabIndex"]) : 0,
                Hint = _xmlcomponente != null ? _xmlcomponente["Hint"].ToString() : "",
                Parameter = _xmlcomponente != null ? _xmlcomponente["Parameter"].ToString() : "",
                DefaultValue = _xmlcomponente != null ? this.StringToDefaultValue(_xmlcomponente["DefaultValue"].ToString()) : default(DefaultValue),
                Required = _xmlcomponente != null ? Convert.ToInt16(_xmlcomponente["Required"]) == 1 : false,
                RequiredMessage = _xmlcomponente != null ? _xmlcomponente["RequiredMessage"].ToString() : "",
                Leave = _xmlcomponente != null ? _xmlcomponente["Leave"].ToString().Replace("\n", "\r\n") : "",
                Enter = _xmlcomponente != null ? _xmlcomponente["Enter"].ToString().Replace("\n", "\r\n") : "",
                Change = _xmlcomponente != null ? _xmlcomponente["Change"].ToString().Replace("\n", "\r\n") : ""
            });

            _bindingsource.DataSource = _componentes.Where(p => p.Name == timeEdit.Name);
            new VerticalGridHelper(_verticalgrid).AtualizarVerticalGrid(GetComponentType(timeEdit));

            return timeEdit;
        }

        public Control CriarSpinEdit()
        {
            SpinEdit spinEdit = new SpinEdit
            {
                Location = new Point(_left, _top),
                Size = new Size(_width, _height),
                TabStop = false,
                ReadOnly = true,
                Name = _name,
                Tag = _type,
                ContextMenuStrip = _contextmenustrip
            };
            spinEdit.Click += _eventoclick;
            spinEdit.MouseUp += _eventomouseup;
            spinEdit.Properties.AllowDropDownWhenReadOnly = DefaultBoolean.False;
            spinEdit.Properties.AllowFocused = false;
            spinEdit.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            _panelbackground.Controls.Add(spinEdit);
            spinEdit.BringToFront();

            ControlMoverOrResizer.Init(spinEdit);

            _componentes.Add(new ComponenteRelatorio
            {
                ComponentType = GetComponentType(spinEdit),
                Name = spinEdit.Name,
                Top = spinEdit.Top,
                Left = spinEdit.Left,
                Height = spinEdit.Height,
                Width = spinEdit.Width,
                TabIndex = _xmlcomponente != null ? Convert.ToInt32(_xmlcomponente["TabIndex"]) : 0,
                Hint = _xmlcomponente != null ? _xmlcomponente["Hint"].ToString() : "",
                Parameter = _xmlcomponente != null ? _xmlcomponente["Parameter"].ToString() : "",
                DefaultValue = _xmlcomponente != null ? this.StringToDefaultValue(_xmlcomponente["DefaultValue"].ToString()) : default(DefaultValue),
                Required = _xmlcomponente != null ? Convert.ToInt16(_xmlcomponente["Required"]) == 1 : false,
                RequiredMessage = _xmlcomponente != null ? _xmlcomponente["RequiredMessage"].ToString() : "",
                MinValue = _xmlcomponente != null ? Convert.ToInt32(_xmlcomponente["MinValue"]) : 0,
                MaxValue = _xmlcomponente != null ? Convert.ToInt32(_xmlcomponente["MaxValue"]) : 0,
                Leave = _xmlcomponente != null ? _xmlcomponente["Leave"].ToString().Replace("\n", "\r\n") : "",
                Enter = _xmlcomponente != null ? _xmlcomponente["Enter"].ToString().Replace("\n", "\r\n") : "",
                Change = _xmlcomponente != null ? _xmlcomponente["Change"].ToString().Replace("\n", "\r\n") : ""
            });

            _bindingsource.DataSource = _componentes.Where(p => p.Name == spinEdit.Name);
            new VerticalGridHelper(_verticalgrid).AtualizarVerticalGrid(GetComponentType(spinEdit));

            return spinEdit;
        }

        public Control CriarCheckEdit()
        {
            CheckEdit checkEdit = new CheckEdit
            {
                Location = new Point(_left, _top),
                Size = new Size(_width, _height),
                TabStop = false,
                ReadOnly = true,
                Name = _name,
                Tag = _type,
                Text = _caption,
                ContextMenuStrip = _contextmenustrip
            };
            checkEdit.Click += _eventoclick;
            checkEdit.MouseUp += _eventomouseup;
            _panelbackground.Controls.Add(checkEdit);
            checkEdit.BringToFront();

            ControlMoverOrResizer.Init(checkEdit);

            _componentes.Add(new ComponenteRelatorio
            {
                ComponentType = GetComponentType(checkEdit),
                Name = checkEdit.Name,
                Top = checkEdit.Top,
                Left = checkEdit.Left,
                Height = checkEdit.Height,
                Width = checkEdit.Width,
                Caption = checkEdit.Text,
                TabIndex = _xmlcomponente != null ? Convert.ToInt32(_xmlcomponente["TabIndex"]) : 0,
                Hint = _xmlcomponente != null ? _xmlcomponente["Hint"].ToString() : "",
                Parameter = _xmlcomponente != null ? _xmlcomponente["Parameter"].ToString() : "",
                DefaultValue = _xmlcomponente != null ? this.StringToDefaultValue(_xmlcomponente["DefaultValue"].ToString()) : default(DefaultValue),
                Components = _xmlcomponente != null ? _xmlcomponente["Components"].ToString().Replace("\n", "\r\n") : "",
                Leave = _xmlcomponente != null ? _xmlcomponente["Leave"].ToString().Replace("\n", "\r\n") : "",
                Enter = _xmlcomponente != null ? _xmlcomponente["Enter"].ToString().Replace("\n", "\r\n") : "",
                Change = _xmlcomponente != null ? _xmlcomponente["Change"].ToString().Replace("\n", "\r\n") : ""
            });

            _bindingsource.DataSource = _componentes.Where(p => p.Name == checkEdit.Name);
            new VerticalGridHelper(_verticalgrid).AtualizarVerticalGrid(GetComponentType(checkEdit));

            return checkEdit;
        }

        public Control CriarRadioButton()
        {
            CheckEdit radioButton = new CheckEdit
            {
                Location = new Point(_left, _top),
                Size = new Size(_width, _height),
                TabStop = false,
                ReadOnly = true,
                Name = _name,
                Tag = _type,
                Text = _caption,
                ContextMenuStrip = _contextmenustrip
            };
            radioButton.Click += _eventoclick;
            radioButton.MouseUp += _eventomouseup;
            radioButton.Properties.CheckStyle = CheckStyles.Radio;
            _panelbackground.Controls.Add(radioButton);
            radioButton.BringToFront();

            ControlMoverOrResizer.Init(radioButton);

            _componentes.Add(new ComponenteRelatorio
            {
                ComponentType = GetComponentType(radioButton),
                Name = radioButton.Name,
                Top = radioButton.Top,
                Left = radioButton.Left,
                Height = radioButton.Height,
                Width = radioButton.Width,
                Caption = radioButton.Text,
                TabIndex = _xmlcomponente != null ? Convert.ToInt32(_xmlcomponente["TabIndex"]) : 0,
                Hint = _xmlcomponente != null ? _xmlcomponente["Hint"].ToString() : "",
                Parameter = _xmlcomponente != null ? _xmlcomponente["Parameter"].ToString() : "",
                DefaultValue = _xmlcomponente != null ? this.StringToDefaultValue(_xmlcomponente["DefaultValue"].ToString()) : default(DefaultValue),
                GroupIndex = _xmlcomponente != null ? Convert.ToInt32(_xmlcomponente["GroupIndex"]) : 0,
                ValueChecked = _xmlcomponente != null ? _xmlcomponente["ValueChecked"].ToString() : "",
                ValueUnchecked = _xmlcomponente != null ? _xmlcomponente["ValueUnchecked"].ToString() : "",
                Leave = _xmlcomponente != null ? _xmlcomponente["Leave"].ToString().Replace("\n", "\r\n") : "",
                Enter = _xmlcomponente != null ? _xmlcomponente["Enter"].ToString().Replace("\n", "\r\n") : "",
                Change = _xmlcomponente != null ? _xmlcomponente["Change"].ToString().Replace("\n", "\r\n") : ""
            });

            _bindingsource.DataSource = _componentes.Where(p => p.Name == radioButton.Name);
            new VerticalGridHelper(_verticalgrid).AtualizarVerticalGrid(GetComponentType(radioButton));

            return radioButton;
        }

        public Control CriarComboBox()
        {
            ComboBoxEdit comboBox = new ComboBoxEdit
            {
                Location = new Point(_left, _top),
                Size = new Size(_width, _height),
                TabStop = false,
                ReadOnly = true,
                Name = _name,
                Tag = _type,
                ContextMenuStrip = _contextmenustrip
            };
            comboBox.Click += _eventoclick;
            comboBox.MouseUp += _eventomouseup;
            comboBox.Properties.AllowDropDownWhenReadOnly = DefaultBoolean.False;
            comboBox.Properties.AllowFocused = false;
            comboBox.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            _panelbackground.Controls.Add(comboBox);
            comboBox.BringToFront();

            ControlMoverOrResizer.Init(comboBox);

            _componentes.Add(new ComponenteRelatorio
            {
                ComponentType = GetComponentType(comboBox),
                Name = comboBox.Name,
                Top = comboBox.Top,
                Left = comboBox.Left,
                Height = comboBox.Height,
                Width = comboBox.Width,
                TabIndex = _xmlcomponente != null ? Convert.ToInt32(_xmlcomponente["TabIndex"]) : 0,
                Hint = _xmlcomponente != null ? _xmlcomponente["Hint"].ToString() : "",
                NullText = _xmlcomponente != null ? _xmlcomponente["NullText"].ToString() : "",
                Parameter = _xmlcomponente != null ? _xmlcomponente["Parameter"].ToString() : "",
                DefaultValue = _xmlcomponente != null ? this.StringToDefaultValue(_xmlcomponente["DefaultValue"].ToString()) : default(DefaultValue),
                Required = _xmlcomponente != null ? Convert.ToInt16(_xmlcomponente["Required"]) == 1 : false,
                RequiredMessage = _xmlcomponente != null ? _xmlcomponente["RequiredMessage"].ToString() : "",
                Descriptions = GetComponentType(comboBox) == ComponentType.TComboBoxDX && _xmlcomponente != null ? _xmlcomponente["Descriptions"].ToString().Replace("\n", "\r\n") : "",
                Values = GetComponentType(comboBox) == ComponentType.TComboBoxDX && _xmlcomponente != null ? _xmlcomponente["Values"].ToString().Replace("\n", "\r\n") : "",
                SQL = GetComponentType(comboBox) == ComponentType.TDBComboBoxDX && _xmlcomponente != null ? _xmlcomponente["SQL"].ToString().Replace("\n", "\r\n") : "",
                KeyField = GetComponentType(comboBox) == ComponentType.TDBComboBoxDX && _xmlcomponente != null ? _xmlcomponente["KeyField"].ToString() : "",
                ShowField = GetComponentType(comboBox) == ComponentType.TDBComboBoxDX && _xmlcomponente != null ? _xmlcomponente["ShowField"].ToString() : "",
                Leave = _xmlcomponente != null ? _xmlcomponente["Leave"].ToString().Replace("\n", "\r\n") : "",
                Enter = _xmlcomponente != null ? _xmlcomponente["Enter"].ToString().Replace("\n", "\r\n") : "",
                Change = _xmlcomponente != null ? _xmlcomponente["Change"].ToString().Replace("\n", "\r\n") : ""
            });

            _bindingsource.DataSource = _componentes.Where(p => p.Name == comboBox.Name);
            new VerticalGridHelper(_verticalgrid).AtualizarVerticalGrid(GetComponentType(comboBox));

            return comboBox;
        }

        public Control CriarRadioGroup()
        {
            RadioGroup radioGroup = new RadioGroup
            {
                Location = new Point(_left, _top),
                Size = new Size(_width, _height),
                TabStop = false,
                ReadOnly = true,
                Name = _name,
                Tag = _type,
                Text = _caption,
                ContextMenuStrip = _contextmenustrip
            };
            radioGroup.Click += _eventoclick;
            radioGroup.MouseUp += _eventomouseup;
            _panelbackground.Controls.Add(radioGroup);
            radioGroup.BringToFront();

            ControlMoverOrResizer.Init(radioGroup);

            _componentes.Add(new ComponenteRelatorio
            {
                ComponentType = GetComponentType(radioGroup),
                Name = radioGroup.Name,
                Top = radioGroup.Top,
                Left = radioGroup.Left,
                Height = radioGroup.Height,
                Width = radioGroup.Width,
                Caption = radioGroup.Text,
                TabIndex = _xmlcomponente != null ? Convert.ToInt32(_xmlcomponente["TabIndex"]) : 0,
                Hint = _xmlcomponente != null ? _xmlcomponente["Hint"].ToString() : "",
                Parameter = _xmlcomponente != null ? _xmlcomponente["Parameter"].ToString() : "",
                DefaultValue = _xmlcomponente != null ? this.StringToDefaultValue(_xmlcomponente["DefaultValue"].ToString()) : default(DefaultValue),
                Columns = _xmlcomponente != null ? Convert.ToInt16(_xmlcomponente["Columns"]) : 0,
                Descriptions = GetComponentType(radioGroup) == ComponentType.TRadioGroupDX && _xmlcomponente != null ? _xmlcomponente["Descriptions"].ToString().Replace("\n", "\r\n") : "",
                Values = GetComponentType(radioGroup) == ComponentType.TRadioGroupDX && _xmlcomponente != null ? _xmlcomponente["Values"].ToString().Replace("\n", "\r\n") : "",
                SQL = GetComponentType(radioGroup) == ComponentType.TDBRadioGroupDX && _xmlcomponente != null ? _xmlcomponente["SQL"].ToString().Replace("\n", "\r\n") : "",
                KeyField = GetComponentType(radioGroup) == ComponentType.TDBRadioGroupDX && _xmlcomponente != null ? _xmlcomponente["KeyField"].ToString() : "",
                ShowField = GetComponentType(radioGroup) == ComponentType.TDBRadioGroupDX && _xmlcomponente != null ? _xmlcomponente["ShowField"].ToString() : "",
                Leave = _xmlcomponente != null ? _xmlcomponente["Leave"].ToString().Replace("\n", "\r\n") : "",
                Enter = _xmlcomponente != null ? _xmlcomponente["Enter"].ToString().Replace("\n", "\r\n") : "",
                Change = _xmlcomponente != null ? _xmlcomponente["Change"].ToString().Replace("\n", "\r\n") : ""
            });

            _bindingsource.DataSource = _componentes.Where(p => p.Name == radioGroup.Name);
            new VerticalGridHelper(_verticalgrid).AtualizarVerticalGrid(GetComponentType(radioGroup));

            return radioGroup;
        }

        public Control CriarCheckedListBoxControl()
        {
            CheckedListBoxControl checkedListBox = new CheckedListBoxControl
            {
                Location = new Point(_left, _top),
                Size = new Size(_width, _height),
                TabStop = false,
                Name = _name,
                Tag = _type,
                ContextMenuStrip = _contextmenustrip
            };
            checkedListBox.Click += _eventoclick;
            checkedListBox.MouseUp += _eventomouseup;
            _panelbackground.Controls.Add(checkedListBox);
            checkedListBox.BringToFront();

            ControlMoverOrResizer.Init(checkedListBox);

            _componentes.Add(new ComponenteRelatorio
            {
                ComponentType = GetComponentType(checkedListBox),
                Name = checkedListBox.Name,
                Top = checkedListBox.Top,
                Left = checkedListBox.Left,
                Height = checkedListBox.Height,
                Width = checkedListBox.Width,
                TabIndex = _xmlcomponente != null ? Convert.ToInt32(_xmlcomponente["TabIndex"]) : 0,
                Hint = _xmlcomponente != null ? _xmlcomponente["Hint"].ToString() : "",
                Parameter = _xmlcomponente != null ? _xmlcomponente["Parameter"].ToString() : "",
                DefaultValue = _xmlcomponente != null ? this.StringToDefaultValue(_xmlcomponente["DefaultValue"].ToString()) : default(DefaultValue),
                Columns = _xmlcomponente != null ? Convert.ToInt16(_xmlcomponente["Columns"]) : 0,
                CheckAll = _xmlcomponente != null ? Convert.ToInt16(_xmlcomponente["CheckAll"]) == 1 : false,
                Required = _xmlcomponente != null ? Convert.ToInt16(_xmlcomponente["Required"]) == 1 : false,
                RequiredMessage = _xmlcomponente != null ? _xmlcomponente["RequiredMessage"].ToString() : "",
                Descriptions = GetComponentType(checkedListBox) == ComponentType.TCheckListBoxDX && _xmlcomponente != null ? _xmlcomponente["Descriptions"].ToString().Replace("\n", "\r\n") : "",
                Values = GetComponentType(checkedListBox) == ComponentType.TCheckListBoxDX && _xmlcomponente != null ? _xmlcomponente["Values"].ToString().Replace("\n", "\r\n") : "",
                SQL = GetComponentType(checkedListBox) == ComponentType.TDBCheckListBoxDX && _xmlcomponente != null ? _xmlcomponente["SQL"].ToString().Replace("\n", "\r\n") : "",
                KeyField = GetComponentType(checkedListBox) == ComponentType.TDBCheckListBoxDX && _xmlcomponente != null ? _xmlcomponente["KeyField"].ToString() : "",
                ShowField = GetComponentType(checkedListBox) == ComponentType.TDBCheckListBoxDX && _xmlcomponente != null ? _xmlcomponente["ShowField"].ToString() : "",
                Leave = _xmlcomponente != null ? _xmlcomponente["Leave"].ToString().Replace("\n", "\r\n") : "",
                Enter = _xmlcomponente != null ? _xmlcomponente["Enter"].ToString().Replace("\n", "\r\n") : "",
                Change = _xmlcomponente != null ? _xmlcomponente["Change"].ToString().Replace("\n", "\r\n") : ""
            });

            _bindingsource.DataSource = _componentes.Where(p => p.Name == checkedListBox.Name);
            new VerticalGridHelper(_verticalgrid).AtualizarVerticalGrid(GetComponentType(checkedListBox));

            return checkedListBox;
        }

        public static string ObterXml(ComponenteRelatorio[] componentes)
        {
            ComponenteRelatorio formulario = componentes.Where(p => p.Name == "panelControlComponente").FirstOrDefault();

            string xml = "<?xml version=\"1.0\" standalone=\"yes\"?>" + Environment.NewLine;
            xml += "<Parametros>" + Environment.NewLine;
            xml += "  <Interface>" + Environment.NewLine;
            xml += $"  <Width>{formulario.Width}</Width>" + Environment.NewLine;
            xml += $"  <Height>{formulario.Height}</Height>" + Environment.NewLine;
            xml += "  </Interface>" + Environment.NewLine;
            foreach (ComponenteRelatorio componente in componentes)
            {
                xml += GerarTagXml(componente);
            }
            xml += "</Parametros>" + Environment.NewLine;

            return xml;
        }

        private static string GerarTagXml(ComponenteRelatorio componente)
        {
            string xml = "";
            xml =   "  <Parametro>" + Environment.NewLine;
            xml += $"    <Type>{componente.ComponentType.ToString()}</Type>" + Environment.NewLine;
            xml += $"    <Name>{componente.Name}</Name>" + Environment.NewLine;
            xml += $"    <Top>{componente.Top}</Top>" + Environment.NewLine;
            xml += $"    <Left>{componente.Left}</Left>" + Environment.NewLine;
            xml += $"    <Height>{componente.Height}</Height>" + Environment.NewLine;
            xml += $"    <Width>{componente.Width}</Width>" + Environment.NewLine;
            if (componente.ComponentType == ComponentType.TFormularioDX)
            {
                xml += $"    <Load><![CDATA[{componente.Load}]]></Load>" + Environment.NewLine;
                xml += $"    <Close><![CDATA[{componente.Close}]]></Close>" + Environment.NewLine;
                xml += $"    <BeforePrint><![CDATA[{componente.BeforePrint}]]></BeforePrint>" + Environment.NewLine;
                xml += $"    <AfterPrint><![CDATA[{componente.AfterPrint}]]></AfterPrint>" + Environment.NewLine;
            }
            else if (componente.ComponentType == ComponentType.TGroupBoxDX)
            {
                xml += $"    <Caption>{componente.Caption}</Caption>" + Environment.NewLine;
                xml += $"    <TabIndex>{componente.TabIndex}</TabIndex>" + Environment.NewLine;
            }
            else if (componente.ComponentType == ComponentType.TLabelDX)
            {
                xml += $"    <Caption>{componente.Caption}</Caption>" + Environment.NewLine;
            }
            else if (componente.ComponentType == ComponentType.TTextEditDX)
            {
                xml += $"    <TabIndex>{componente.TabIndex}</TabIndex>" + Environment.NewLine;
                xml += $"    <Hint>{componente.Hint}</Hint>" + Environment.NewLine;
                xml += $"    <Mask>{componente.Mask}</Mask>" + Environment.NewLine;
                xml += $"    <NullText>{componente.NullText}</NullText>" + Environment.NewLine;
                xml += $"    <DefaultValue>{componente.DefaultValue.ToDescriptionString()}</DefaultValue>" + Environment.NewLine;
                xml += $"    <Parameter>{componente.Parameter}</Parameter>" + Environment.NewLine;
                xml += $"    <Required>{(componente.Required ? 1 : 0)}</Required>" + Environment.NewLine;
                xml += $"    <RequiredMessage>{componente.RequiredMessage}</RequiredMessage>" + Environment.NewLine;
                xml += $"    <Alignment>{(int)componente.Alignment}</Alignment>" + Environment.NewLine;
                xml += $"    <Leave><![CDATA[{componente.Leave}]]></Leave>" + Environment.NewLine;
                xml += $"    <Enter><![CDATA[{componente.Enter}]]></Enter>" + Environment.NewLine;
                xml += $"    <Change><![CDATA[{componente.Change}]]></Change>" + Environment.NewLine;
            }
            else if (componente.ComponentType == ComponentType.TDateEditDX)
            {
                xml += $"    <TabIndex>{componente.TabIndex}</TabIndex>" + Environment.NewLine;
                xml += $"    <Hint>{componente.Hint}</Hint>" + Environment.NewLine;
                xml += $"    <NullText>{componente.NullText}</NullText>" + Environment.NewLine;
                xml += $"    <DefaultValue>{componente.DefaultValue.ToDescriptionString()}</DefaultValue>" + Environment.NewLine;
                xml += $"    <Parameter>{componente.Parameter}</Parameter>" + Environment.NewLine;
                xml += $"    <Required>{(componente.Required ? 1 : 0)}</Required>" + Environment.NewLine;
                xml += $"    <RequiredMessage>{componente.RequiredMessage}</RequiredMessage>" + Environment.NewLine;
                xml += $"    <Leave><![CDATA[{componente.Leave}]]></Leave>" + Environment.NewLine;
                xml += $"    <Enter><![CDATA[{componente.Enter}]]></Enter>" + Environment.NewLine;
                xml += $"    <Change><![CDATA[{componente.Change}]]></Change>" + Environment.NewLine;
            }
            else if (componente.ComponentType == ComponentType.TTimeEditDX)
            {
                xml += $"    <TabIndex>{componente.TabIndex}</TabIndex>" + Environment.NewLine;
                xml += $"    <Hint>{componente.Hint}</Hint>" + Environment.NewLine;
                xml += $"    <NullText>{componente.NullText}</NullText>" + Environment.NewLine;
                xml += $"    <DefaultValue>{componente.DefaultValue.ToDescriptionString()}</DefaultValue>" + Environment.NewLine;
                xml += $"    <Parameter>{componente.Parameter}</Parameter>" + Environment.NewLine;
                xml += $"    <Required>{(componente.Required ? 1 : 0)}</Required>" + Environment.NewLine;
                xml += $"    <RequiredMessage>{componente.RequiredMessage}</RequiredMessage>" + Environment.NewLine;
                xml += $"    <Leave><![CDATA[{componente.Leave}]]></Leave>" + Environment.NewLine;
                xml += $"    <Enter><![CDATA[{componente.Enter}]]></Enter>" + Environment.NewLine;
                xml += $"    <Change><![CDATA[{componente.Change}]]></Change>" + Environment.NewLine;
            }
            else if (componente.ComponentType == ComponentType.TCheckBoxDX)
            {
                xml += $"    <Caption>{componente.Caption}</Caption>" + Environment.NewLine;
                xml += $"    <TabIndex>{componente.TabIndex}</TabIndex>" + Environment.NewLine;
                xml += $"    <Hint>{componente.Hint}</Hint>" + Environment.NewLine;
                xml += $"    <Parameter>{componente.Parameter}</Parameter>" + Environment.NewLine;
                xml += $"    <DefaultValue>{componente.DefaultValue.ToDescriptionString()}</DefaultValue>" + Environment.NewLine;
                xml += $"    <Components>{componente.Components}</Components>" + Environment.NewLine;
                xml += $"    <Leave><![CDATA[{componente.Leave}]]></Leave>" + Environment.NewLine;
                xml += $"    <Enter><![CDATA[{componente.Enter}]]></Enter>" + Environment.NewLine;
                xml += $"    <Change><![CDATA[{componente.Change}]]></Change>" + Environment.NewLine;
            }
            else if (componente.ComponentType == ComponentType.TSpinEditDX)
            {
                xml += $"    <TabIndex>{componente.TabIndex}</TabIndex>" + Environment.NewLine;
                xml += $"    <Hint>{componente.Hint}</Hint>" + Environment.NewLine;
                xml += $"    <Parameter>{componente.Parameter}</Parameter>" + Environment.NewLine;
                xml += $"    <DefaultValue>{componente.DefaultValue.ToDescriptionString()}</DefaultValue>" + Environment.NewLine;
                xml += $"    <Required>{(componente.Required ? 1 : 0)}</Required>" + Environment.NewLine;
                xml += $"    <RequiredMessage>{componente.RequiredMessage}</RequiredMessage>" + Environment.NewLine;
                xml += $"    <MinValue>{componente.MinValue}</MinValue>" + Environment.NewLine;
                xml += $"    <MaxValue>{componente.MaxValue}</MaxValue>" + Environment.NewLine;
                xml += $"    <Leave><![CDATA[{componente.Leave}]]></Leave>" + Environment.NewLine;
                xml += $"    <Enter><![CDATA[{componente.Enter}]]></Enter>" + Environment.NewLine;
                xml += $"    <Change><![CDATA[{componente.Change}]]></Change>" + Environment.NewLine;
            }
            else if (componente.ComponentType == ComponentType.TComboBoxDX)
            {
                xml += $"    <TabIndex>{componente.TabIndex}</TabIndex>" + Environment.NewLine;
                xml += $"    <Hint>{componente.Hint}</Hint>" + Environment.NewLine;
                xml += $"    <NullText>{componente.NullText}</NullText>" + Environment.NewLine;
                xml += $"    <Parameter>{componente.Parameter}</Parameter>" + Environment.NewLine;
                xml += $"    <DefaultValue>{componente.DefaultValue.ToDescriptionString()}</DefaultValue>" + Environment.NewLine;
                xml += $"    <Required>{(componente.Required ? 1 : 0)}</Required>" + Environment.NewLine;
                xml += $"    <RequiredMessage>{componente.RequiredMessage}</RequiredMessage>" + Environment.NewLine;
                xml += $"    <Descriptions><![CDATA[{componente.Descriptions}]]></Descriptions>" + Environment.NewLine;
                xml += $"    <Values><![CDATA[{componente.Values}]]></Values>" + Environment.NewLine;
                xml += $"    <Leave><![CDATA[{componente.Leave}]]></Leave>" + Environment.NewLine;
                xml += $"    <Enter><![CDATA[{componente.Enter}]]></Enter>" + Environment.NewLine;
                xml += $"    <Change><![CDATA[{componente.Change}]]></Change>" + Environment.NewLine;
            }
            else if (componente.ComponentType == ComponentType.TRadioGroupDX)
            {
                xml += $"    <Caption>{componente.Caption}</Caption>" + Environment.NewLine;
                xml += $"    <TabIndex>{componente.TabIndex}</TabIndex>" + Environment.NewLine;
                xml += $"    <Hint>{componente.Hint}</Hint>" + Environment.NewLine;
                xml += $"    <Parameter>{componente.Parameter}</Parameter>" + Environment.NewLine;
                xml += $"    <Columns>{componente.Columns}</Columns>" + Environment.NewLine;
                xml += $"    <DefaultValue>{componente.DefaultValue.ToDescriptionString()}</DefaultValue>" + Environment.NewLine;
                xml += $"    <Descriptions><![CDATA[{componente.Descriptions}]]></Descriptions>" + Environment.NewLine;
                xml += $"    <Values><![CDATA[{componente.Values}]]></Values>" + Environment.NewLine;
                xml += $"    <Leave><![CDATA[{componente.Leave}]]></Leave>" + Environment.NewLine;
                xml += $"    <Enter><![CDATA[{componente.Enter}]]></Enter>" + Environment.NewLine;
                xml += $"    <Change><![CDATA[{componente.Change}]]></Change>" + Environment.NewLine;
            }
            else if (componente.ComponentType == ComponentType.TCheckListBoxDX)
            {
                xml += $"    <TabIndex>{componente.TabIndex}</TabIndex>" + Environment.NewLine;
                xml += $"    <Hint>{componente.Hint}</Hint>" + Environment.NewLine;
                xml += $"    <Parameter>{componente.Parameter}</Parameter>" + Environment.NewLine;
                xml += $"    <Columns>{componente.Columns}</Columns>" + Environment.NewLine;
                xml += $"    <DefaultValue>{componente.DefaultValue.ToDescriptionString()}</DefaultValue>" + Environment.NewLine;
                xml += $"    <CheckAll>{componente.CheckAll}</CheckAll>" + Environment.NewLine;
                xml += $"    <Required>{(componente.Required ? 1 : 0)}</Required>" + Environment.NewLine;
                xml += $"    <RequiredMessage>{componente.RequiredMessage}</RequiredMessage>" + Environment.NewLine;
                xml += $"    <Descriptions><![CDATA[{componente.Descriptions}]]></Descriptions>" + Environment.NewLine;
                xml += $"    <Values><![CDATA[{componente.Values}]]></Values>" + Environment.NewLine;
                xml += $"    <Leave><![CDATA[{componente.Leave}]]></Leave>" + Environment.NewLine;
                xml += $"    <Enter><![CDATA[{componente.Enter}]]></Enter>" + Environment.NewLine;
                xml += $"    <Change><![CDATA[{componente.Change}]]></Change>" + Environment.NewLine;
            }
            else if (componente.ComponentType == ComponentType.TDBComboBoxDX)
            {
                xml += $"    <TabIndex>{componente.TabIndex}</TabIndex>" + Environment.NewLine;
                xml += $"    <Hint>{componente.Hint}</Hint>" + Environment.NewLine;
                xml += $"    <NullText>{componente.NullText}</NullText>" + Environment.NewLine;
                xml += $"    <Parameter>{componente.Parameter}</Parameter>" + Environment.NewLine;
                xml += $"    <DefaultValue>{componente.DefaultValue.ToDescriptionString()}</DefaultValue>" + Environment.NewLine;
                xml += $"    <Required>{(componente.Required ? 1 : 0)}</Required>" + Environment.NewLine;
                xml += $"    <RequiredMessage>{componente.RequiredMessage}</RequiredMessage>" + Environment.NewLine;
                xml += $"    <SQL>{componente.SQL}</SQL>" + Environment.NewLine;
                xml += $"    <KeyField>{componente.KeyField}</KeyField>" + Environment.NewLine;
                xml += $"    <ShowField>{componente.ShowField}</ShowField>" + Environment.NewLine;
                xml += $"    <Leave><![CDATA[{componente.Leave}]]></Leave>" + Environment.NewLine;
                xml += $"    <Enter><![CDATA[{componente.Enter}]]></Enter>" + Environment.NewLine;
                xml += $"    <Change><![CDATA[{componente.Change}]]></Change>" + Environment.NewLine;
            }
            else if (componente.ComponentType == ComponentType.TDBRadioGroupDX)
            {
                xml += $"    <Caption>{componente.Caption}</Caption>" + Environment.NewLine;
                xml += $"    <TabIndex>{componente.TabIndex}</TabIndex>" + Environment.NewLine;
                xml += $"    <Hint>{componente.Hint}</Hint>" + Environment.NewLine;
                xml += $"    <Parameter>{componente.Parameter}</Parameter>" + Environment.NewLine;
                xml += $"    <Columns>{componente.Columns}</Columns>" + Environment.NewLine;
                xml += $"    <DefaultValue>{componente.DefaultValue.ToDescriptionString()}</DefaultValue>" + Environment.NewLine;
                xml += $"    <SQL>{componente.SQL}</SQL>" + Environment.NewLine;
                xml += $"    <KeyField>{componente.KeyField}</KeyField>" + Environment.NewLine;
                xml += $"    <ShowField>{componente.ShowField}</ShowField>" + Environment.NewLine;
                xml += $"    <Leave><![CDATA[{componente.Leave}]]></Leave>" + Environment.NewLine;
                xml += $"    <Enter><![CDATA[{componente.Enter}]]></Enter>" + Environment.NewLine;
                xml += $"    <Change><![CDATA[{componente.Change}]]></Change>" + Environment.NewLine;
            }
            else if (componente.ComponentType == ComponentType.TDBCheckListBoxDX)
            {
                xml += $"    <TabIndex>{componente.TabIndex}</TabIndex>" + Environment.NewLine;
                xml += $"    <Hint>{componente.Hint}</Hint>" + Environment.NewLine;
                xml += $"    <Parameter>{componente.Parameter}</Parameter>" + Environment.NewLine;
                xml += $"    <Columns>{componente.Columns}</Columns>" + Environment.NewLine;
                xml += $"    <DefaultValue>{componente.DefaultValue.ToDescriptionString()}</DefaultValue>" + Environment.NewLine;
                xml += $"    <CheckAll>{(componente.CheckAll ? 1 : 0)}</CheckAll>" + Environment.NewLine;
                xml += $"    <Required>{(componente.Required ? 1 : 0)}</Required>" + Environment.NewLine;
                xml += $"    <RequiredMessage>{componente.RequiredMessage}</RequiredMessage>" + Environment.NewLine;
                xml += $"    <SQL>{componente.SQL}</SQL>" + Environment.NewLine;
                xml += $"    <KeyField>{componente.KeyField}</KeyField>" + Environment.NewLine;
                xml += $"    <ShowField>{componente.ShowField}</ShowField>" + Environment.NewLine;
                xml += $"    <Leave><![CDATA[{componente.Leave}]]></Leave>" + Environment.NewLine;
                xml += $"    <Enter><![CDATA[{componente.Enter}]]></Enter>" + Environment.NewLine;
                xml += $"    <Change><![CDATA[{componente.Change}]]></Change>" + Environment.NewLine;
            }
            xml += "  </Parametro>" + Environment.NewLine;
            return xml;
        }
    }
}
