using VIPER.DTO;
using VIPER.Entity;
using VIPER.Modules.Perfil.Interfaces;
using VIPER.Service;
using Chronus.DXperience;
using Chronus.Library;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VIPER.Modules.Perfil.Views
{
    public partial class PerfilView : FrmManutencao, IPresenterToViewPerfil
    {
        public IViewToPresenterPerfil presenter;

        private SplashScreen _splash;
        private bool _cancelou = false;

        public PerfilView(int funcao)
        {
            InitializeComponent();

            FuncaoId = funcao;

            PermiteIncluir = true;
            PermiteAlterar = true;
            PermiteExcluir = true;
        }

        private PerfilPerfilFuncaoDTO JoinBindingSource()
        {
            var listafuncao = new List<PerfilFuncao>();
            foreach (var item in ((IList<PerfilFuncaoDTO>)perfilfuncaoBindingSource.List).Where(p => p.Selecionado))
                listafuncao.Add(Classe.CloneClass<PerfilFuncao>(item));

            PerfilPerfilFuncaoDTO perfilfuncoes = new PerfilPerfilFuncaoDTO();
            perfilfuncoes.SistemaId = Global.Instance.Sistema.Id;
            perfilfuncoes.Perfil = (principalBindingSource.Current as Entity.Perfil);
            perfilfuncoes.Perfil.QuantidadeFuncoes = listafuncao.Count();
            perfilfuncoes.PerfilFuncoes = listafuncao.ToArray();
            return perfilfuncoes;
        }

        protected override void IncluirRegistro()
        {
            (principalBindingSource.Current as Entity.Perfil).Id = iKey = 0;
            principalBindingSource.ResetCurrentItem();

            _splash = new SplashScreen("Carregando perfil...");
            presenter.SelecionarPerfilFuncao(iKey, Global.Instance.Sistema.Id);
        }

        protected override void AlterarRegistro()
        {
            iKey = (principalBindingSource.Current as Entity.Perfil).Id;

            _splash = new SplashScreen("Carregando perfil...");
            presenter.SelecionarPerfilFuncao(iKey, Global.Instance.Sistema.Id);
        }

        protected override void ObterDadosPrincipal()
        {
            principalBindingSource.Clear();
            if (!string.IsNullOrWhiteSpace(sCondicao))
            {
                _splash = new SplashScreen("Buscando informações...");
                presenter.ObterDadosPrincipal(sCondicao);
            }
        }
        protected override void GravarRegistro()
        {
            _splash = new SplashScreen("Gravando registro...");
            presenter.Gravar(JoinBindingSource());
        }

        protected override void ExcluirRegistro()
        {
            _splash = new SplashScreen("Excluindo registro...");
            presenter.Excluir(principalBindingSource.Current as Entity.Perfil);
        }

        private void gvwAcesso_DoubleClick(object sender, EventArgs e)
        {
            btnEditar_Click(null, null);
        }

        private void gvwFuncoes_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (_cancelou)
            {
                _cancelou = false;
                var registro = (gvwFuncoes.GetFocusedRow() as PerfilFuncaoDTO);
                registro.Selecionado = false;
                principalBindingSource.ResetCurrentItem();
            }
        }

        private void gvwFuncoes_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e != null && Convert.ToBoolean(e.Value))
            {
                if ((perfilfuncaoBindingSource.Current as PerfilFuncaoDTO).FuncaoManutencao)
                {
                    var incluir = true;
                    var alterar = true;
                    var excluir = true;
                    presenter.CarregarPermissaoAcesso((perfilfuncaoBindingSource.Current as PerfilFuncaoDTO).FuncaoDescricao,
                        ref incluir, ref alterar, ref excluir, out bool ok);
                    if (ok)
                    {
                        (perfilfuncaoBindingSource.Current as PerfilFuncaoDTO).PermiteIncluir = incluir;
                        (perfilfuncaoBindingSource.Current as PerfilFuncaoDTO).PermiteAlterar = alterar;
                        (perfilfuncaoBindingSource.Current as PerfilFuncaoDTO).PermiteExcluir = excluir;
                    }
                    else
                        _cancelou = true;
                }
                else
                {
                    (perfilfuncaoBindingSource.Current as PerfilFuncaoDTO).PermiteIncluir = false;
                    (perfilfuncaoBindingSource.Current as PerfilFuncaoDTO).PermiteAlterar = false;
                    (perfilfuncaoBindingSource.Current as PerfilFuncaoDTO).PermiteExcluir = false;
                }
            }
            else
            {
                (perfilfuncaoBindingSource.Current as PerfilFuncaoDTO).PermiteIncluir = false;
                (perfilfuncaoBindingSource.Current as PerfilFuncaoDTO).PermiteAlterar = false;
                (perfilfuncaoBindingSource.Current as PerfilFuncaoDTO).PermiteExcluir = false;
            }
            perfilfuncaoBindingSource.ResetCurrentItem();
        }

        private void gvwFuncoes_DoubleClick(object sender, EventArgs e)
        {
            if (gvwFuncoes.FocusedValue != null)
            {
                if ((perfilfuncaoBindingSource.Current as PerfilFuncaoDTO).Selecionado)
                {
                    if ((perfilfuncaoBindingSource.Current as PerfilFuncaoDTO).FuncaoManutencao)
                    {
                        var incluir = (perfilfuncaoBindingSource.Current as PerfilFuncaoDTO).PermiteIncluir;
                        var alterar = (perfilfuncaoBindingSource.Current as PerfilFuncaoDTO).PermiteAlterar;
                        var excluir = (perfilfuncaoBindingSource.Current as PerfilFuncaoDTO).PermiteExcluir;
                        presenter.CarregarPermissaoAcesso((perfilfuncaoBindingSource.Current as PerfilFuncaoDTO).FuncaoDescricao,
                            ref incluir, ref alterar, ref excluir, out bool ok);
                        if (ok)
                        {
                            (perfilfuncaoBindingSource.Current as PerfilFuncaoDTO).PermiteIncluir = incluir;
                            (perfilfuncaoBindingSource.Current as PerfilFuncaoDTO).PermiteAlterar = alterar;
                            (perfilfuncaoBindingSource.Current as PerfilFuncaoDTO).PermiteExcluir = excluir;
                        }
                    }
                }
            }
        }

        public void ObterDadosPrincipalSucesso(List<Entity.Perfil> dados)
        {
            _splash.FinalizarSplashScreen();
            principalBindingSource.DataSource = dados;
        }

        public void ObterDadosPrincipalFalha()
        {
            _splash.FinalizarSplashScreen();
        }

        public void GravarSucesso()
        {
            _splash.FinalizarSplashScreen();
            ExecutarAposGravar();
        }

        public void GravarFalha(string mensagem)
        {
            _splash.FinalizarSplashScreen();
            XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void ExcluirSucesso()
        {
            _splash.FinalizarSplashScreen();
            ExecutarAposExcluir();
        }

        public void ExcluirFalha(string mensagem)
        {
            _splash.FinalizarSplashScreen();
            XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void SelecionarPerfilFuncaoSucesso(List<PerfilFuncaoDTO> perfils, List<FuncaoDTO> funcaos)
        {
            _splash.FinalizarSplashScreen();

            perfilfuncaoBindingSource.Clear();
            foreach (var registro in perfils)
                perfilfuncaoBindingSource.Add(registro);

            foreach (var funcao in funcaos)
            {
                if (((IList<PerfilFuncaoDTO>)perfilfuncaoBindingSource.List).Where(p => p.FuncaoId == funcao.Id).Count() == 0)
                    perfilfuncaoBindingSource.Add(new PerfilFuncaoDTO()
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
                        PerfilId = iKey
                    });
            }
            perfilfuncaoBindingSource.ResetBindings(true);

            gvwFuncoes.CollapseAllGroups();
            gvwFuncoes.MoveFirst();
            gvwFuncoes.ExpandAllGroups();
        }
    }
}
