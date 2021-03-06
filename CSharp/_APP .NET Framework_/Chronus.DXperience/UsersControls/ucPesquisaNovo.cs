using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;
using Chronus.Library;
using System.Linq.Dynamic;

namespace Chronus.DXperience
{
    public partial class ucPesquisaNovo<T> : UserControl
    {
        private List<RegistroPesquisa> _listaPesquisa;
        private dynamic _servico;
        private string _condicaoinicial = string.Empty;
        private string _campoordenacao = string.Empty;
        private PopupContainerEdit _popup;
        private string mensagem = null;
        private bool _carregarnacarga = new SettingsDefault().ExibirRegistroPopup;
        private bool _filtroespecial = false;

        public object oSelecao;
        public bool bConfirmado = false;

        public ucPesquisaNovo()
        {
            InitializeComponent();

            txtPesquisa.Focus();
            txtPesquisa.Select();
        }

        public ucPesquisaNovo(PopupContainerEdit popup, List<RegistroPesquisa> lista, dynamic servico) 
        {
            InitializeComponent();

            _popup = popup;
            _listaPesquisa = lista;
            _servico = servico;

            int i = 0;
            gvwPrincipal.Columns.Clear();
            foreach (RegistroPesquisa modelo in _listaPesquisa)
            {
                gvwPrincipal.Columns.Add(new GridColumn()
                { 
                    Visible = true, 
                    VisibleIndex = modelo.Id, 
                    Caption = modelo.Descricao, 
                    FieldName = modelo.Campo,
                    UnboundType = ConversionDX.TypeToColumnType(modelo.Tipo),
                    Width = modelo.Tamanho,
                    SortOrder = modelo.Padrao ? DevExpress.Data.ColumnSortOrder.Ascending : DevExpress.Data.ColumnSortOrder.None
                });

                if (modelo.Tipo == typeof(double))
                {
                    gvwPrincipal.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                    gvwPrincipal.Columns[i].DisplayFormat.FormatString = "n2";
                }

                if (modelo.Padrao) _campoordenacao = modelo.Campo;
                i++;
            }
            txtPesquisa.Text = "";
        }

        public ucPesquisaNovo(PopupContainerEdit popup, List<RegistroPesquisa> lista, dynamic servico, string condicaoinicial)
            :this(popup, lista, (object) servico)
        {
            _condicaoinicial = condicaoinicial;
        }

        public ucPesquisaNovo(PopupContainerEdit popup, List<RegistroPesquisa> lista, dynamic servico, string condicaoinicial, bool carregarnacarga = true, bool filtroespecial = false)
            : this(popup, lista, (object)servico, condicaoinicial)
        {
            _carregarnacarga = carregarnacarga;
            _filtroespecial = filtroespecial;
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mensagem = null;
                string condicao = null;

                if (!txtPesquisa.Text.Equals(""))
                    condicao = Funcoes.ParseObject(_condicaoinicial, _campoordenacao, txtPesquisa.Text,
                        _listaPesquisa.Where(p => p.Campo == _campoordenacao).FirstOrDefault().Tipo);

                if (!string.IsNullOrEmpty(condicao))
                {
                    principalBindingSource.DataSource = new List<T>(_servico).AsQueryable().Where(condicao).ToArray();
                }
                else
                    principalBindingSource.DataSource = null;

                if (principalBindingSource.Count != 0)
                    gclPrincipal.Focus();
                else
                {
                    if (string.IsNullOrWhiteSpace(mensagem))
                        mensagem = "Nenhum registro foi encontrado com o crit??rio informado!";
                    XtraMessageBox.Show(mensagem, "Aten????o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPesquisa.Focus();
                }
            }
        }

        private void gvwPrincipal_StartSorting(object sender, EventArgs e)
        {
            _campoordenacao = gvwPrincipal.SortedColumns[0].FieldName;
            txtPesquisa.Focus();
        }

        private void gvwPrincipal_DoubleClick(object sender, EventArgs e)
        {
            if (pnlInferior.Visible) SelectRow();
        }

        private void gvwPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) SelectRow();
        }

        private void gvwPrincipal_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (!pnlInferior.Visible) SelectRow();
        }

        private void SelectRow()
        {
            if (principalBindingSource.Count == 0)
            {
                XtraMessageBox.Show("Nenhum registro selecionado!", "Aten????o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                oSelecao = principalBindingSource.Current;
                bConfirmado = true;
                this._popup.ClosePopup();
            }
        }

        private void ucPesquisa_Load(object sender, EventArgs e)
        {
            if (_carregarnacarga)
            {
                principalBindingSource.DataSource = new List<T>(_servico).AsQueryable().Where(_condicaoinicial);
                
                gclPrincipal.Focus();
                gclPrincipal.Select();
            }

            if (_popup != null && _popup.Properties.Tag != null)
            {
                txtPesquisa.Text = _popup.Properties.Tag.ToString();
                _popup.Properties.Tag = null;
                txtPesquisa.Select(txtPesquisa.Text.Length + 1, 0);
            }
        }
    }
}