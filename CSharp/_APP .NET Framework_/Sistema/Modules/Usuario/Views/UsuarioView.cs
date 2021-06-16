using VIPER.Modules.Usuario.Interfaces;
using Chronus.DXperience;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VIPER.Modules.Usuario.Views
{
    public partial class UsuarioView : FrmManutencao, IPresenterToViewUsuario
    {
        public IViewToPresenterUsuario presenter;

        public UsuarioView(int funcao)
        {
            InitializeComponent();

            FuncaoId = funcao;

            PermiteIncluir = true;
            PermiteAlterar = true;
            PermiteExcluir = true;
        }

        protected override void IncluirRegistro()
        {
            (principalBindingSource.Current as Entity.Usuario).Id = iKey = 0;
            (principalBindingSource.Current as Entity.Usuario).Master = false;
            (principalBindingSource.Current as Entity.Usuario).Bloqueado = false;
            (principalBindingSource.Current as Entity.Usuario).Administrador = false;
            (principalBindingSource.Current as Entity.Usuario).AlterarSenha = true;
            (principalBindingSource.Current as Entity.Usuario).NuncaExpira = false;
            (principalBindingSource.Current as Entity.Usuario).DataAlteracao = DateTime.Today;
            (principalBindingSource.Current as Entity.Usuario).DiasExpirar = 90;
            principalBindingSource.ResetCurrentItem();

            ckeNuncaExpira_CheckedChanged(null, null);
			txtSenha.Enabled = true;
        }

        protected override void AlterarRegistro()
        {
            iKey = (principalBindingSource.Current as Entity.Usuario).Id;
            ckeNuncaExpira_CheckedChanged(null, null);
			txtSenha.Enabled = false;
        }

        protected override void ObterDadosPrincipal()
        {
            principalBindingSource.Clear();
            if (!string.IsNullOrWhiteSpace(sCondicao))
                presenter.ObterDadosPrincipal(sCondicao);
        }
        protected override void GravarRegistro()
        {
            presenter.Gravar(principalBindingSource.Current as Entity.Usuario);
        }

        protected override void ExcluirRegistro()
        {
            presenter.Excluir(principalBindingSource.Current as Entity.Usuario);
        }

        private void gvwAcesso_DoubleClick(object sender, EventArgs e)
        {
            btnEditar_Click(null, null);
        }

        private void ckeNuncaExpira_CheckedChanged(object sender, EventArgs e)
        {
            if (bInsertOrEdit)
                cetDias.Enabled = !ckeNuncaExpira.Checked;
        }

        public void ObterDadosPrincipalSucesso(List<Entity.Usuario> dados)
        {
            principalBindingSource.DataSource = dados;
        }

        public void ObterDadosPrincipalFalha()
        {
            
        }

        public void GravarSucesso()
        {
            ExecutarAposGravar();
        }

        public void GravarFalha(string mensagem)
        {
            XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void ExcluirSucesso()
        {
            ExecutarAposExcluir();
        }

        public void ExcluirFalha(string mensagem)
        {
            XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
