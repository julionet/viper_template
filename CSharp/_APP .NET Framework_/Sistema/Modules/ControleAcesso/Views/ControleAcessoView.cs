using VIPER.DTO;
using VIPER.Entity;
using VIPER.Modules.ControleAcesso.Interfaces;
using VIPER.Service;
using Chronus.DXperience;
using Chronus.Library;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace VIPER.Modules.ControleAcesso.Views
{
    public partial class ControleAcessoView : FrmModelo, IPresenterToViewControleAcesso
    {
        public IViewToPresenterControleAcesso presenter;

        private SplashScreen _splash;

        private bool _ehcomum = false;
        private bool _cancelou = false;
        private Entity.Usuario _usuario = null;
        private ucPesquisa ucUsuario;

        public ControleAcessoView(int funcao)
        {
            InitializeComponent();
        }

        private string ObterListaPerfisSelecionado()
        {
            string perfis = "";
            foreach (CheckedListBoxItem item in clbPerfil.CheckedItems)
                perfis += perfis == "" ? item.Value.ToString() : "|" + item.Value.ToString();
            return perfis;
        }

        private UsuarioUsuarioFuncaoDTO JoinBindingSource()
        {
            var listafuncao = new List<UsuarioFuncao>();
            foreach (UsuarioFuncaoDTO item in ((IList<UsuarioFuncaoDTO>)detalheBindingSource.List).Where(p => p.Selecionado))
                listafuncao.Add(Classe.CloneClass<UsuarioFuncao>(item));

            var usuariofuncoes = new UsuarioUsuarioFuncaoDTO();
            usuariofuncoes.SistemaId = Global.Instance.Sistema.Id;
            usuariofuncoes.Usuario = _usuario;
            usuariofuncoes.Usuario.ListaPerfis = ObterListaPerfisSelecionado();
            usuariofuncoes.UsuarioFuncoes = listafuncao.ToArray();
            return usuariofuncoes;
        }

        private void AtualizarListaPerfis(int usuario)
        {
            presenter.SelecionarPerfis(usuario);
        }

        private void AtualizarListaFuncoes(int usuario)
        {
            detalheBindingSource.Clear();
            presenter.SelecionarListaFuncoes(usuario);
        }

        private void FrmUsuarioFuncao_Load(object sender, EventArgs e)
        {
            clbPerfil.Items.Clear();
            btnOk.Enabled = false;
            btnCancelar.Enabled = false;

            pceUsuario.Focus();
            pceUsuario.Select();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (!pceUsuario.IsNullOrDbnull())
            {
                _splash = new SplashScreen("Carregando informações...");
                int usuario = Convert.ToInt32(pceUsuario.Tag);
                presenter.SelecionarUsuario(usuario);
            }
        }

        private new void btnCancelar_Click(object sender, EventArgs e)
        {
            detalheBindingSource.Clear();
            clbPerfil.Items.Clear();
            pceUsuario.Enabled = true;
            pceUsuario.EditValue = null;
            pceUsuario.Tag = null;
            btnSelecionar.Enabled = true;
            btnCancelar.Enabled = false;
            btnOk.Enabled = false;
        }

        private void gvwFuncoes_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (_cancelou)
            {
                _cancelou = false;
                var registro = (gvwFuncoes.GetFocusedRow() as UsuarioFuncaoDTO);
                registro.Selecionado = false;
                detalheBindingSource.ResetCurrentItem();
            }
        }

        private void gvwFuncoes_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e != null && Convert.ToBoolean(e.Value))
            {
                if ((detalheBindingSource.Current as UsuarioFuncaoDTO).FuncaoManutencao)
                {
                    var incluir = true;
                    var alterar = true;
                    var excluir = true;
                    presenter.CarregarPermissaoAcesso((detalheBindingSource.Current as UsuarioFuncaoDTO).FuncaoDescricao,
                        ref incluir, ref alterar, ref excluir, out bool ok);
                    if (ok)
                    {
                        (detalheBindingSource.Current as UsuarioFuncaoDTO).PermiteIncluir = incluir;
                        (detalheBindingSource.Current as UsuarioFuncaoDTO).PermiteAlterar = alterar;
                        (detalheBindingSource.Current as UsuarioFuncaoDTO).PermiteExcluir = excluir;
                    }
                    else
                        _cancelou = true;
                }
                else
                {
                    (detalheBindingSource.Current as UsuarioFuncaoDTO).PermiteIncluir = false;
                    (detalheBindingSource.Current as UsuarioFuncaoDTO).PermiteAlterar = false;
                    (detalheBindingSource.Current as UsuarioFuncaoDTO).PermiteExcluir = false;
                }
            }
            else
            {
                (detalheBindingSource.Current as UsuarioFuncaoDTO).PermiteIncluir = false;
                (detalheBindingSource.Current as UsuarioFuncaoDTO).PermiteAlterar = false;
                (detalheBindingSource.Current as UsuarioFuncaoDTO).PermiteExcluir = false;
            }
            detalheBindingSource.ResetCurrentItem();
        }

        private void gvwFuncoes_DoubleClick(object sender, EventArgs e)
        {
            if (gvwFuncoes.FocusedValue != null)
            {
                if ((detalheBindingSource.Current as UsuarioFuncaoDTO).Selecionado)
                {
                    if ((detalheBindingSource.Current as UsuarioFuncaoDTO).FuncaoManutencao)
                    {
                        var incluir = (detalheBindingSource.Current as UsuarioFuncaoDTO).PermiteIncluir;
                        var alterar = (detalheBindingSource.Current as UsuarioFuncaoDTO).PermiteAlterar;
                        var excluir = (detalheBindingSource.Current as UsuarioFuncaoDTO).PermiteExcluir;
                        presenter.CarregarPermissaoAcesso((detalheBindingSource.Current as UsuarioFuncaoDTO).FuncaoDescricao,
                            ref incluir, ref alterar, ref excluir, out bool ok);
                        if (ok)
                        {
                            (detalheBindingSource.Current as UsuarioFuncaoDTO).PermiteIncluir = incluir;
                            (detalheBindingSource.Current as UsuarioFuncaoDTO).PermiteAlterar = alterar;
                            (detalheBindingSource.Current as UsuarioFuncaoDTO).PermiteExcluir = excluir;
                        }
                    }
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!pceUsuario.Enabled)
            {
                _splash = new SplashScreen("Gravando informações...");
                presenter.Salvar(JoinBindingSource());                
            }
            else
            {
                if (this.ParentControl != null)
                    ParentControl.TabPages.Remove(ParentPage);
            }
        }

        private void pceUsuario_QueryPopUp(object sender, CancelEventArgs e)
        {
            string condicaoinicial = "(Master == false && Bloqueado == false)";
            ucUsuario = new ucPesquisa(pceUsuario, PopupContainerRegistroPesquisa.RegistroPesquisaLogin(), Servicos.usuarioService, condicaoinicial);
            ucUsuario.Dock = DockStyle.Fill;

            PopupContainerControl control = new PopupContainerControl();
            control.Controls.Add(ucUsuario);

            pceUsuario.Properties.PopupFormSize = new System.Drawing.Size(pceUsuario.Width, 200);
            pceUsuario.Properties.PopupControl = control;
        }

        private void pceUsuario_QueryResultValue(object sender, QueryResultValueEventArgs e)
        {
            if (ucUsuario.bConfirmado)
            {
                e.Value = (ucUsuario.oSelecao as Entity.Usuario).Login;
                pceUsuario.Tag = (ucUsuario.oSelecao as Entity.Usuario).Id;
            }
        }

        private void pceUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                pceUsuario.Tag = null;
                pceUsuario.EditValue = null;
            }
            else
            {
                string key = ConversionDX.KeyCodeToString(e.KeyCode, e.Shift);
                if (key != "")
                {
                    (sender as PopupContainerEdit).Properties.Tag = key;
                    (sender as PopupContainerEdit).ShowPopup();
                }
            }
        }

        public void SalvarSucesso()
        {
            _splash.FinalizarSplashScreen();
            btnCancelar_Click(null, null);
        }

        public void SalvarFalha(string mensagem)
        {
            _splash.FinalizarSplashScreen();
            XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void SelecionarUsuarioSucesso(Entity.Usuario usuario)
        {
            _splash.FinalizarSplashScreen();
            _usuario = usuario;
            _ehcomum = !_usuario.Administrador;
            AtualizarListaFuncoes(usuario.Id);
            AtualizarListaPerfis(usuario.Id);
            pceUsuario.Enabled = false;
            btnSelecionar.Enabled = false;
            btnOk.Enabled = true;
            btnCancelar.Enabled = true;
            gclFuncoes.Focus();
        }

        public void SelecionarUsuarioFalha()
        {
            _splash.FinalizarSplashScreen();
        }

        public void SelecionarListaFuncoesSucesso(List<UsuarioFuncaoDTO> usuarioFuncaos, List<FuncaoDTO> funcaos)
        {
            foreach (var registro in usuarioFuncaos)
                detalheBindingSource.Add(registro);

            foreach (var funcao in funcaos)
            {
                if (((IList<UsuarioFuncaoDTO>)detalheBindingSource.List).Where(p => p.FuncaoId == funcao.Id).Count() == 0)
                    detalheBindingSource.Add(new UsuarioFuncaoDTO()
                    {
                        FuncaoDescricao = funcao.Descricao,
                        FuncaoId = funcao.Id,
                        FuncaoManutencao = funcao.Manutencao,
                        Id = 0,
                        ModuloDescricao = funcao.ModuloDescricao,
                        ModuloId = funcao.ModuloId,
                        PermiteAlterar = false,
                        PermiteExcluir = false,
                        PermiteIncluir = false,
                        Selecionado = false,
                        UsuarioId = Convert.ToInt32(pceUsuario.Tag)
                    });
            }
            detalheBindingSource.ResetBindings(true);

            gvwFuncoes.CollapseAllGroups();
            gvwFuncoes.MoveFirst();
            gvwFuncoes.ExpandAllGroups();

        }

        public void SelecionarPerfisSucesso(List<Entity.Perfil> perfilselecionados, List<Entity.Perfil> perfiltodos)
        {
            var listaperfil = perfilselecionados;
            foreach (var perfil in perfiltodos)
            {
                if (listaperfil.Where(p => p.Id == perfil.Id).Count() != 0)
                    clbPerfil.Items.Add(perfil.Id, perfil.Descricao, CheckState.Checked, true);
                else
                    clbPerfil.Items.Add(perfil.Id, perfil.Descricao, CheckState.Unchecked, true);
            }   
        }
    }
}
