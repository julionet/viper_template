using Chronus.Library;
using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace Chronus.DXperience
{
    public class ComponenteParametro
    {
        private string _tipocomponente;

        private int _posicaox;
        public int PosicaoX
        {
            set { _posicaox = value; }
        }

        private int _posicaoy;
        public int PosicaoY
        {
            set { _posicaoy = value; }
        }

        public ComponenteParametro(string tipocomponente)
        {
            _tipocomponente = tipocomponente;
        }

        private IntPtr _handle;
        public IntPtr Handle
        {
            set { _handle = value; }
        }

        public BaseEdit Criar(string valorpersonalizado = "", string lista = "", dynamic lookupdatasource = null)
        {
            BaseEdit componente;
            if (_tipocomponente == "D")
            {
                componente = new DateEdit();
                (componente as DateEdit).Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
                (componente as DateEdit).Properties.Mask.EditMask = "99/99/9999";
                (componente as DateEdit).Properties.Mask.UseMaskAsDisplayFormat = true;
                this.PosicionarComponente(componente);
                componente.EditValue = valorpersonalizado;
                return componente;
            }
            else if (_tipocomponente == "T")
            {
                componente = new TextEdit();
                (componente as TextEdit).Properties.MaxLength = 255;
                if (!string.IsNullOrWhiteSpace(lista))
                {
                    (componente as TextEdit).Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
                    (componente as TextEdit).Properties.Mask.EditMask = lista;
                    (componente as TextEdit).Properties.Mask.UseMaskAsDisplayFormat = true;
                }
                this.PosicionarComponente(componente);
                componente.Text = valorpersonalizado;
                return componente;
            }
            else if (_tipocomponente == "M")
            {
                componente = new MemoExEdit();
                this.PosicionarComponente(componente);
                componente.Text = valorpersonalizado;
                return componente;
            }
            else if (_tipocomponente == "P")
            {
                componente = new TextEdit();
                (componente as TextEdit).Properties.MaxLength = 255;
                (componente as TextEdit).Properties.PasswordChar = '*';
                this.PosicionarComponente(componente);
                componente.Text = valorpersonalizado;
                return componente;
            }
            else if (_tipocomponente == "E")
            {
                componente = new ButtonEdit();
                (componente as ButtonEdit).Properties.MaxLength = 255;
                (componente as ButtonEdit).Properties.ReadOnly = true;
                (componente as ButtonEdit).ButtonClick += (s, e) =>
                {
                    string certificado = SelecionarCertificado();
                    if (!string.IsNullOrWhiteSpace(certificado))
                        (s as ButtonEdit).Text = certificado;
                };
                this.PosicionarComponente(componente);
                componente.Text = valorpersonalizado;
                return componente;
            }
            else if (_tipocomponente == "N")
            {
                componente = new CalcEdit();
                (componente as CalcEdit).Properties.Buttons.Clear();
                (componente as CalcEdit).Properties.MaxLength = 10;
                (componente as CalcEdit).Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                (componente as CalcEdit).Properties.Mask.UseMaskAsDisplayFormat = true;
                (componente as CalcEdit).Properties.Mask.EditMask = string.IsNullOrWhiteSpace(lista) ? "d" : lista;
                (componente as CalcEdit).Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
                this.PosicionarComponente(componente);
                componente.Text = valorpersonalizado;
                return componente;
            }
            else if (_tipocomponente == "L")
            {
                componente = new ComboBoxEdit();
                (componente as ComboBoxEdit).Properties.Items.Add("");

                foreach (string item in lista.Split('|'))
                    (componente as ComboBoxEdit).Properties.Items.Add(item);

                (componente as ComboBoxEdit).Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                (componente as ComboBoxEdit).Properties.MaxLength = 255;
                this.PosicionarComponente(componente);
                componente.Text = valorpersonalizado;
                return componente;
            }
            else if (_tipocomponente == "S")
            {
                DevExpress.XtraGrid.Columns.GridColumn gridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
                gridColumn.Caption = "Descrição";
                gridColumn.FieldName = "Display";
                gridColumn.Name = "gridColumn";
                gridColumn.Visible = true;
                gridColumn.VisibleIndex = 0;

                DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
                searchLookUpEditView.Columns.Clear();
                searchLookUpEditView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn });
                searchLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
                searchLookUpEditView.Name = "searchLookUpEditView";
                searchLookUpEditView.OptionsBehavior.Editable = false;
                searchLookUpEditView.OptionsCustomization.AllowColumnMoving = false;
                searchLookUpEditView.OptionsCustomization.AllowColumnResizing = false;
                searchLookUpEditView.OptionsCustomization.AllowFilter = false;
                searchLookUpEditView.OptionsMenu.EnableColumnMenu = false;
                searchLookUpEditView.OptionsMenu.EnableFooterMenu = false;
                searchLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
                searchLookUpEditView.OptionsView.ShowGroupPanel = false;
                searchLookUpEditView.OptionsView.ShowIndicator = false;
                searchLookUpEditView.OptionsView.ShowColumnHeaders = false;
                searchLookUpEditView.OptionsView.RowAutoHeight = true;

                componente = new SearchLookUpEdit();
                (componente as SearchLookUpEdit).Properties.DataSource = lookupdatasource;
                (componente as SearchLookUpEdit).Properties.ValueMember = "Value";
                (componente as SearchLookUpEdit).Properties.DisplayMember = "Display";
                (componente as SearchLookUpEdit).Properties.NullText = "";
                (componente as SearchLookUpEdit).Properties.PopupSizeable = false;
                (componente as SearchLookUpEdit).Properties.View = searchLookUpEditView;
                (componente as SearchLookUpEdit).Properties.Buttons.Clear();
                (componente as SearchLookUpEdit).Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
                    new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
                this.PosicionarComponente(componente);
                (componente as SearchLookUpEdit).EditValue = valorpersonalizado;
                return componente;
            }
            else if (_tipocomponente == "C")
            {
                componente = new CheckedComboBoxEdit();
                (componente as CheckedComboBoxEdit).Properties.SelectAllItemCaption = "(Selecionar Todos)";
                (componente as CheckedComboBoxEdit).Properties.IncrementalSearch = true;
                (componente as CheckedComboBoxEdit).Properties.DisplayMember = "Display";
                (componente as CheckedComboBoxEdit).Properties.ValueMember = "Value";
                (componente as CheckedComboBoxEdit).Properties.DataSource = lookupdatasource;
                this.PosicionarComponente(componente);
                (componente as CheckedComboBoxEdit).EditValue = valorpersonalizado;
                return componente;
            }
            else
                return null;
        }

        private void ComponenteParametro_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PosicionarComponente(BaseControl componente)
        {
            componente.Location = new System.Drawing.Point(_posicaox, _posicaoy);
            componente.Name = "Componente2";
            componente.Size = new System.Drawing.Size(314, 20);
            componente.TabIndex = 2;
        }

        private string SelecionarCertificado()
        {
            try
            {
                return new Certificado().SelecionarCertificado(_handle).SerialNumber;
            }
            catch (Exception)
            {
                return "";
            }
        }

        private X509Certificate2 SelecionarCertificado(string SerialNumber)
        {
            return new Certificado().SelecionarCertificado(SerialNumber);
        }
    }
}
