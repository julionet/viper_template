using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using DevExpress.XtraTreeList;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Chronus.DXperience
{
    public partial class FrmManutencao : XtraForm
    {
        protected int iKey = 0;
        protected bool bInsertOrEdit = false;
        protected bool bInsert = false;
        protected bool bEdit = false;
        protected bool bFiltroEspecifico = false;
        protected string sCondicao = "";
        protected string sCondicaoPersonalizada = "";
        public XtraTabPage ParentPage;
        public XtraTabControl ParentControl;
        public bool PermiteIncluir = true;
        public bool PermiteAlterar = true;
        public bool PermiteExcluir = true;
        public string Mensagem = "";

        public bool ExibirTodosRegistros
        {
            get { return Properties.Settings.Default.ExibirTodosRegistros; }
        }

        private Control _firstcontrol = null;
        public Control FirstControl
        {
            get { return _firstcontrol; }
            set { _firstcontrol = value; }
        }

        private int _funcao;
        public int FuncaoId
        {
            get { return _funcao; }
            set { _funcao = value; }
        }

        private string _entidade;
        public string Entidade
        {
            get { return _entidade; }
            set { _entidade = value; }
        }

        private bool _administrador;
        public bool Administrador
        {
            get { return _administrador; }
            set { _administrador = value; }
        }

        public bool InsertOrEdit
        {
            get { return bInsertOrEdit; }
        }

        public FrmManutencao()
        {
            InitializeComponent();
        }

        protected virtual void IncluirRegistro()
        {
        }

        protected virtual void AlterarRegistro()
        {
        }

        protected virtual bool BloquearRegistro()
        {
            return true;
        }

        protected virtual void DesbloquearRegistro()
        {
            
        }

        protected virtual bool ExisteRegistro()
        {
            return true;
        }

        protected virtual void AtualizarDados()
        {
            PreencherCheckListBox();
        }

        protected virtual void ObterDetalhes()
        {
        }

        protected virtual void ObterDadosPrincipal()
        {
        }

        protected virtual void PreencherCheckListBox()
        {
        }

        protected virtual void AtualizarCheckListBox()
        {
        }
        
        protected virtual void GravarCheckListBox()
        {
        }

        protected virtual bool ValidarRegistro()
        {
            foreach (Control control in xscManutencao.Controls)
                if (control is XtraTabControl)
                {
                    int posicao = (control as XtraTabControl).SelectedTabPageIndex;
                    foreach (XtraTabPage page in (control as XtraTabControl).TabPages)
                        (control as XtraTabControl).SelectedTabPage = page;
                    (control as XtraTabControl).SelectedTabPageIndex = posicao;
                }
            return true;
        }

        protected virtual bool ExecutarAntesGravar()
        {
            return true;
        }

        protected virtual void GravarRegistro()
        {
            
        }

        protected virtual void ExecutarAposGravar()
        {
            bInsert = bEdit = bInsertOrEdit = false;
            ObterDadosPrincipal();

            xtcPaginas.SelectedTabPageIndex = 0;
            txtPesquisa.Focus();
            txtPesquisa.Text = "";
        }

        protected virtual bool CancelarRegistro()
        {
            bInsert = bEdit = bInsertOrEdit = false;
            ObterDadosPrincipal();

            xtcPaginas.SelectedTabPageIndex = 0;
            txtPesquisa.Focus();
            txtPesquisa.Text = "";

            return true;
        }

        protected virtual void ExcluirRegistro()
        {
            
        }

        protected virtual void ExecutarAposExcluir()
        {
            bInsert = bEdit = bInsertOrEdit = false;
            ObterDadosPrincipal();

            xtcPaginas.SelectedTabPageIndex = 0;
            txtPesquisa.Focus();
            txtPesquisa.Text = "";
        }

        protected virtual void CreateGridButtons(GridViewWithButtons gridView)
        {
            if (gridView.ButtonsPanel.Buttons.Count != 0)
            {
                GridColumn gridColumnButtons2 = new GridColumn();
                gridColumnButtons2.Visible = true;
                gridColumnButtons2.VisibleIndex = gridView.Columns.Count - 1;
                gridColumnButtons2.MaxWidth = (gridView.ButtonsPanel.Buttons.Count * 56);
                gridColumnButtons2.MinWidth = (gridView.ButtonsPanel.Buttons.Count * 56);
                gridColumnButtons2.Width = (gridView.ButtonsPanel.Buttons.Count * 56);
                gridView.Columns.Add(gridColumnButtons2);

                gridView.ButtonsColumn = gridColumnButtons2;
                gridView.ShowButtons = true;
            }
        }

        private void FrmManutencao_Load(object sender, EventArgs e)
        {
            xtcPaginas.SelectedTabPageIndex = 0;

            pclSeparadorAcesso.Appearance.BackColor = pclBotoesAcesso.BackColor;
            pclSeparadorManutencao.Appearance.BackColor = pclBotoesAcesso.BackColor;
            pclAcesso.Appearance.BackColor = pclBotoesAcesso.BackColor;

            btnIncluir.Enabled = PermiteIncluir;
            btnEditar.Enabled = PermiteAlterar;

            Interface.SetPropertyDefault(pclManutencao);
            Interface.SetPropertyDefault(pclAcesso);
            Interface.SetPropertyDefault(pclPesquisar);

            if (Properties.Settings.Default.EnterMudaCampo) 
                Interface.EnterMoveNextControl(xscManutencao);

            if (this.Controls.Find("gclPrincipal", true).Count() != 0)
            {
                ((GridView)((GridControl)this.Controls.Find("gclPrincipal", true)[0]).Views[0]).StartSorting += new System.EventHandler(this.gvwAcesso_StartSorting);
                gvwAcesso_StartSorting(null, null);
            }

            if (Properties.Settings.Default.ExibirTodosRegistros)
                ObterDadosPrincipal();
            PreencherCheckListBox();

            txtPesquisa.Focus();
            txtPesquisa.Select();
        }

        private void FrmManutencao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((ActiveControl is GridControl) && ((ActiveControl as GridControl).Name == "gclPrincipal"))
                    btnEditar_Click(btnEditar, null);
                else if ((ActiveControl is TreeList) && ((ActiveControl as TreeList).Name == "xtlAcesso"))
                    btnEditar_Click(btnEditar, null);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                if (sender is Form)
                {
                    if ((sender as Form).ActiveControl is LookUpEdit)
                        ((LookUpEdit)(sender as Form).ActiveControl).EditValue = null;
                    else if ((sender as Form).ActiveControl is ImageComboBoxEdit)
                        ((ImageComboBoxEdit)(sender as Form).ActiveControl).EditValue = null;
                    else if ((sender as Form).ActiveControl is ComboBoxEdit)
                        ((ComboBoxEdit)(sender as Form).ActiveControl).EditValue = null;
                }
            }
        }
        
        public virtual void btnFiltrar_Click(object sender, EventArgs e)
        {
            GridView _grade = ((GridView)((GridControl)this.Controls.Find("gclPrincipal", true)[0]).Views[0]);
            if (!string.IsNullOrWhiteSpace(txtPesquisa.Text))
            {
                if (!bFiltroEspecifico)
                    sCondicao = Pesquisa.GerarCondicaoFiltro(txtPesquisa, _grade);
                else
                {
                    string fieldname = _grade.FocusedColumn.FieldName;
                    sCondicao = Pesquisa.GerarCondicaoFiltroEspecifico(txtPesquisa, _grade, fieldname);
                }
            }
            else
                sCondicao = "";

            if (sCondicao.Equals("#ERRO#"))
                XtraMessageBox.Show("Infomação inválida para filtro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (!string.IsNullOrWhiteSpace(sCondicaoPersonalizada))
                    sCondicao = sCondicao.Insert(0, sCondicaoPersonalizada + (string.IsNullOrWhiteSpace(sCondicao) ? "" : " and "));

                if (sCondicao == "")
                {
                    XtraMessageBox.Show("Para realizar a busca é necessário informar algum filtro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPesquisa.Focus();
                    txtPesquisa.Select();
                }
                else
                {
                    var splash = new SplashScreen("Obtendo informações...");
                    ObterDadosPrincipal();
                    splash.FinalizarSplashScreen();

                    if (principalBindingSource.Count != 0)
                    {
                        _grade.Focus();
                        txtPesquisa.Text = "";
                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(Mensagem))
                            Mensagem = "Nenhum registro encontrado com o critério de busca!";
                        XtraMessageBox.Show(Mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPesquisa.Focus();
                        txtPesquisa.Select();
                    }
                }
            }
        }

        public virtual void btnIncluir_Click(object sender, EventArgs e)
        {
            btnExcluir.Enabled = false;
            btnGravar.Enabled = true;
            
            bInsert = bInsertOrEdit = true;
            bEdit = false;
            
            Interface.ChangeEnableControl(PermiteIncluir, pclManutencao);

            principalBindingSource.AddNew();
            IncluirRegistro();

            xtcPaginas.SelectedTabPageIndex = 1;
            if (_firstcontrol != null) _firstcontrol.Focus();
        }

        public virtual void btnEditar_Click(object sender, EventArgs e)
        {
            if (principalBindingSource.Count == 0)
            {
                XtraMessageBox.Show("Nenhum registro selecionado para ser alterado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ExisteRegistro())
            {
                XtraMessageBox.Show("Registro excluído por outro usuário!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (BloquearRegistro())
            {
                btnExcluir.Enabled = PermiteExcluir;
                btnGravar.Enabled = PermiteAlterar;

                Interface.ChangeEnableControl(PermiteAlterar, pclManutencao);

                bEdit = bInsertOrEdit = true;
                bInsert = false;

                AlterarRegistro();
                AtualizarCheckListBox();

                xtcPaginas.SelectedTabPageIndex = 1;
                if (_firstcontrol != null) _firstcontrol.Focus();
            }
        }

        public void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (xtcPaginas.SelectedTabPage == xtpAcesso) ObterDadosPrincipal();
            AtualizarDados();
        }

        public virtual void btnGravar_Click(object sender, EventArgs e)
        {
            if (ValidarRegistro())
            {
                ExecutarAntesGravar();
                GravarCheckListBox();
                var splash = new SplashScreen("Gravando registro...");
                GravarRegistro();
                splash.FinalizarSplashScreen();
            }
        }

        public virtual void btnCancelar_Click(object sender, EventArgs e)
        {
            CancelarRegistro();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Deseja realmente excluir o registro selecionado?", "Confirmação", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                var splash = new SplashScreen("Excluindo registro...");
                ExcluirRegistro();
                splash.FinalizarSplashScreen();
            }
        }

        private void gvwAcesso_StartSorting(object sender, EventArgs e)
        {
            txtPesquisa.Focus();
            txtPesquisa.Select();

            ((GridView)((GridControl)this.Controls.Find("gclPrincipal", true)[0]).Views[0]).FocusedColumn = ((GridView)((GridControl)this.Controls.Find("gclPrincipal", true)[0]).Views[0]).SortedColumns[0];
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) 
                btnFiltrar_Click(btnFiltrar, null);
        }

        private void tabPaginas_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            bInsertOrEdit = xtcPaginas.SelectedTabPageIndex == 1;
        }

        private void xtcPaginas_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Control && e.KeyCode == Keys.Tab) || (e.Control && e.Shift && e.KeyCode == Keys.Tab))
                e.Handled = true;
        }
    }
}