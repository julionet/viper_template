using VIPER.DTO;
using VIPER.Modules.ParametroEdicao.Interfaces;
using Chronus.DXperience;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VIPER.Modules.ParametroEdicao.Views
{
    public partial class ParametroEdicaoView : FrmModelo, IPresenterToViewParametroEdicao
    {
        public IViewToPresenterParametroEdicao presenter;

        private string _tipocomponente, _valorpadrao, _lista, _valorpersonalizado;
        private bool _editavel;
        private BaseEdit componente;

        public string ValorPersonalizado
        {
            get { return _valorpersonalizado; }
        }

        public ParametroEdicaoView(string descricao, string tipocomponente, string valorpadrao, string lista, string valorpersonalizado, bool editavel)
        {
            InitializeComponent();

            lbParametro.Text = descricao;

            _tipocomponente = tipocomponente;
            _valorpadrao = valorpadrao;
            _lista = lista;
            _valorpersonalizado = valorpersonalizado;
            _editavel = editavel;
        }

        private void FrmAlteraDiretiva_Load(object sender, EventArgs e)
        {
            txtValorPadrao.Text = _valorpadrao;
            if (_tipocomponente == "S" || _tipocomponente == "C")
                presenter.ExecutarSQL(_lista);
            else
                presenter.ExecutarSQL("");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string mensagem = Validacao();
            if (mensagem != "")
            {
                XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
            }
            else if (_tipocomponente == "S" || _tipocomponente == "C")
                _valorpersonalizado = !componente.IsNullOrDbnull() ? componente.EditValue.ToString() : null;
            else
                _valorpersonalizado = !componente.IsNullOrDbnull() ? componente.EditValue.ToString() == "" ? null : componente.Text : null;            
        }

        private string Validacao() {
            return "";
        }

        public void ExecutarSQLSucesso(List<LookupDataSourceDTO> dados)
        {
            var componenteparametro = new ComponenteParametro(_tipocomponente);
            componenteparametro.PosicaoX = txtValorPadrao.Left;
            componenteparametro.PosicaoY = lclPersonalizado.Top - 3;
            componenteparametro.Handle = this.Handle;
            componente = componenteparametro.Criar(_valorpersonalizado, _lista, _tipocomponente == "C" || _tipocomponente == "S" ? dados : null);
            componente.ReadOnly = !_editavel;
            panelControl2.Controls.Add(componente);
        }

        public void ExecutarSQLFalha()
        {
            var componenteparametro = new ComponenteParametro(_tipocomponente);
            componenteparametro.PosicaoX = txtValorPadrao.Left;
            componenteparametro.PosicaoY = lclPersonalizado.Top - 3;
            componenteparametro.Handle = this.Handle;
            componente = componenteparametro.Criar(_valorpersonalizado, _lista, null);
            componente.ReadOnly = !_editavel;
            panelControl2.Controls.Add(componente);
        }
    }
}
