using VIPER.Modules.Modulo.Interfaces;
using Chronus.DXperience;
using Chronus.Library;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VIPER.Modules.Modulo.Views
{
    public partial class ModuloView : FrmModelo, IPresenterToViewModulo
    {
        public IViewToPresenterModulo presenter;

        public ModuloView(BindingSource source, BindingSource funcoes, int id, string descricao)
            : base(source)
        {
            InitializeComponent();

            iKey = id;

            lblSistema.Text = descricao;

            gvwFuncao.ActiveFilterString = "Flag <> 'E'";

            gclFuncao.DataSource = funcoes;
            funcaoBindingSource = funcoes;
        }

        private void btnIncluirFuncao_Click(object sender, EventArgs e)
        {
            funcaoBindingSource.AddNew();
            var registro = (funcaoBindingSource.Current as Entity.Funcao);
            registro.Id = 0;
            registro.Flag = "I";
            registro.ModuloId = (detalheBindingSource.Current as Entity.Modulo).Id;
            registro.Manutencao = false;

            presenter.CarregarFuncao(funcaoBindingSource, registro.Id, tetDescricao.Text, out bool ok);
            if (!ok)
                funcaoBindingSource.CancelEdit();
        }

        private void btnAlterarFuncao_Click(object sender, EventArgs e)
        {
            if (gvwFuncao.DataRowCount != 0)
            {
                var registro = (funcaoBindingSource.Current as Entity.Funcao);
                var itemBackup = Classe.CloneClass<Entity.Funcao>(registro);

                presenter.CarregarFuncao(funcaoBindingSource, registro.Id, tetDescricao.Text, out bool ok);
                if (ok)
                {
                    if (registro.Flag != "I")
                        registro.Flag = "A";
                }
                else
                {
                    int i = funcaoBindingSource.IndexOf(funcaoBindingSource.Current);
                    funcaoBindingSource.RemoveCurrent();
                    funcaoBindingSource.Insert(i, itemBackup);
                }
            }
        }

        private void btnExcluirFuncao_Click(object sender, EventArgs e)
        {
            if (gvwFuncao.DataRowCount != 0)
            {
                if (XtraMessageBox.Show("Deseja realmente excluir registro?", "Confirmação", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    var registro = (funcaoBindingSource.Current as Entity.Funcao);
                    if (registro.Flag == "I")
                        funcaoBindingSource.RemoveCurrent();
                    else
                        registro.Flag = "E";
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            (detalheBindingSource.Current as Entity.Modulo).QuantidadeFuncao = (funcaoBindingSource.List as IList<Entity.Funcao>).Where(p => p.Flag != "E").Count();
            presenter.Validar(detalheBindingSource.Current as Entity.Modulo);
        }

        private void petImagem_EditValueChanged(object sender, EventArgs e)
        {
            if (!petImagem.IsNullOrDbnull())
            {
                byte[] b = Conversion.ObjectToByteArray(petImagem.EditValue);
                if (b.Count() > 500000)
                {
                    petImagem.EditValue = DBNull.Value;
                    XtraMessageBox.Show("A imagem selecionada não pode ter mais que 500 Kb!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void ValidarSucesso()
        {
            DialogResult = DialogResult.OK;
        }

        public void ValidarFalha(string mensagem)
        {
            XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DialogResult = DialogResult.None;
        }

        private void cpeCor_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                (detalheBindingSource.Current as Entity.Modulo).Cor = 0;
                detalheBindingSource.ResetCurrentItem();
            }
        }
    }
}
