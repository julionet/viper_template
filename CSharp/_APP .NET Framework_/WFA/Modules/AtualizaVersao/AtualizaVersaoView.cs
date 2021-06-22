using Chronus.DXperience;
using DevExpress.XtraEditors;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VIPER.Entity;
using VIPER.Modules.AtualizaVersao.Interfaces;

namespace VIPER.Modules.AtualizaVersao.Views
{
    public partial class AtualizaVersaoView : FrmModelo, IPresenterToViewAtualizaVersao
    {
        public IViewToPresenterAtualizaVersao presenter;

        public AtualizaVersaoView()
        {
            InitializeComponent();
        }

        public void AtualizarConcluido()
        {
            XtraMessageBox.Show("Atualizações realizadas com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        public void AtualizarFalha(string mensagem)
        {
            var array = new ArrayList(memAtualizacao.Lines);
            array.Add(mensagem);
            memAtualizacao.Lines = array.ToArray(typeof(string)) as string[];

            detalheBindingSource.ResetBindings(false);
            XtraMessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void AtualizarSucesso(string mensagem)
        {
            var array = new ArrayList(memAtualizacao.Lines);
            array.Add(mensagem);
            memAtualizacao.Lines = array.ToArray(typeof(string)) as string[];
            detalheBindingSource.ResetBindings(false);
        }

        public void SelecionarPendentesFalha()
        {
            
        }

        public void SelecionarPendentesSucesso(List<Atualizacao> dados)
        {
            detalheBindingSource.DataSource = dados;
            gvwAcesso.ExpandAllGroups();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
             if (((IList<Atualizacao>)detalheBindingSource.List).Where(p => p.Status == "E").Count() != 0)
                XtraMessageBox.Show("Não é possível atualizar o sistema com atualizações com erro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                presenter.Atualizar(((IList<Atualizacao>)detalheBindingSource.List).OrderBy(p => p.Id).ToList());
            }
        }

        private void gvwAcesso_DoubleClick(object sender, EventArgs e)
        {
            if ((detalheBindingSource.Current as Atualizacao).Status != "P")
                XtraMessageBox.Show((detalheBindingSource.Current as Atualizacao).Mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AtualizaVersaoView_Load(object sender, EventArgs e)
        {
            presenter.SelecionarPendentes();
        }
    }
}
