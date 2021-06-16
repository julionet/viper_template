using VIPER.DTO;
using VIPER.Modules.Sistema.Interfaces;
using Chronus.DXperience;
using Chronus.Library;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VIPER.Modules.Sistema.Views
{
    public partial class SistemaView : FrmManutencao, IPresenterToViewSistema
    {
        public IViewToPresenterSistema presenter;

        private Dictionary<int, BindingSource> dicFuncao;
        private int _modulo = 999999;

        public SistemaView(int funcao)
        {
            InitializeComponent();

            FuncaoId = funcao;
            dicFuncao = new Dictionary<int, BindingSource>();

            PermiteIncluir = true;
            PermiteAlterar = true;
            PermiteExcluir = true;

            gvwModulo.ActiveFilterString = "Flag <> 'E'";
        }

        private SistemaModuloFuncaoDTO JoinBindingSources()
        {
            var registro = new SistemaModuloFuncaoDTO();
            registro.Sistema = principalBindingSource.Current as Entity.Sistema;
            registro.Sistema.QuantidadeModulo = moduloBindingSource.Count;

            registro.Modulos = ((IList<Entity.Modulo>)moduloBindingSource.List).ToArray();

            var listaFuncao = new List<Entity.Funcao>();
            foreach (BindingSource bs in dicFuncao.Values)
                listaFuncao.AddRange((IList<Entity.Funcao>)bs.List);
            registro.Funcoes = listaFuncao.ToArray();

            return registro;
        }

        protected override void IncluirRegistro()
        {
            moduloBindingSource.Clear();
            dicFuncao.Clear();

            (principalBindingSource.Current as Entity.Sistema).Id = iKey = 0;
            (principalBindingSource.Current as Entity.Sistema).Ativo = true;
            principalBindingSource.ResetCurrentItem();
        }

        protected override void AlterarRegistro()
        {
            iKey = (principalBindingSource.Current as Entity.Sistema).Id;

            moduloBindingSource.Clear();
            dicFuncao.Clear();

            ObterDetalhes();
        }

        protected override void ObterDetalhes()
        {
            presenter.ObterModulos(iKey);
        }

        protected override void ObterDadosPrincipal()
        {
            principalBindingSource.Clear();
            if (!string.IsNullOrWhiteSpace(sCondicao))
                presenter.ObterDadosPrincipal(sCondicao);
        }

        protected override void GravarRegistro()
        {
            presenter.Gravar(JoinBindingSources());
        }

        protected override void ExcluirRegistro()
        {
            presenter.Excluir(principalBindingSource.Current as Entity.Sistema);
        }

        private void gvwAcesso_DoubleClick(object sender, EventArgs e)
        {
            btnEditar_Click(null, null);
        }

        private void btnIncluirModulo_Click(object sender, EventArgs e)
        {
            moduloBindingSource.AddNew();
            var registro = (moduloBindingSource.Current as Entity.Modulo);
            registro.Id = _modulo;
            registro.Flag = "I";
            registro.SistemaId = (principalBindingSource.Current as Entity.Sistema).Id;

            var bs = new BindingSource();
            bs.DataSource = typeof(Entity.Funcao);
            dicFuncao.Add(_modulo, bs);

            presenter.CarregarModulo(moduloBindingSource, dicFuncao[_modulo], registro.Id, tetDescricao.Text, out bool ok);
            if (!ok)
            {
                dicFuncao.Remove(registro.Id);
                moduloBindingSource.CancelEdit();
            }
            _modulo--;
        }

        private void btnAlterarModulo_Click(object sender, EventArgs e)
        {
            if (gvwModulo.DataRowCount != 0)
            {
                var registro = (moduloBindingSource.Current as Entity.Modulo);
                var itemBackup = Classe.CloneClass<Entity.Modulo>(registro);

                presenter.CarregarModulo(moduloBindingSource, dicFuncao[registro.Id], registro.Id, tetDescricao.Text, out bool ok);
                if (ok)
                {
                    if (registro.Flag != "I")
                        registro.Flag = "A";
                }
                else
                {
                    int i = moduloBindingSource.IndexOf(moduloBindingSource.Current);
                    moduloBindingSource.RemoveCurrent();
                    moduloBindingSource.Insert(i, itemBackup);
                    gvwModulo.RefreshData();
                }
            }
        }

        private void btnExcluirModulo_Click(object sender, EventArgs e)
        {
            if (gvwModulo.DataRowCount != 0)
            {
                if (XtraMessageBox.Show("Deseja realmente excluir registro?", "Confirmação", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    var registro = moduloBindingSource.Current as Entity.Modulo;
                    if (registro.Flag == "I")
                    {
                        dicFuncao.Remove((moduloBindingSource.Current as Entity.Modulo).Id);
                        moduloBindingSource.RemoveCurrent();
                    }
                    else
                    {
                        registro.Flag = "E";
                        foreach (Entity.Funcao itemFuncao in dicFuncao[registro.Id].List)
                            itemFuncao.Flag = "E";
                    }
                    gvwModulo.RefreshData();
                }
            }
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

        public void ObterDadosPrincipalSucesso(List<Entity.Sistema> dados)
        {
            principalBindingSource.DataSource = dados;
        }

        public void ObterDadosPrincipalFalha()
        {
            
        }

        public void ObterModulosSucesso(List<Entity.Modulo> dados)
        {
            foreach (var item in dados)
            {
                moduloBindingSource.Add(item);
                presenter.ObterFuncaos(item.Id);
            }
        }

        public void ObterModulosFalha()
        {
            
        }

        public void ObterFuncaosSucesso(List<Entity.Funcao> dados, int moduloid)
        {
            var bsFuncao = new BindingSource();
            bsFuncao.DataSource = typeof(Entity.Funcao);
            foreach (var itemFuncao in dados)
                bsFuncao.Add(itemFuncao);
            dicFuncao.Add(moduloid, bsFuncao);
        }

        public void ObterFuncaosFalha()
        {
            
        }
    }
}
