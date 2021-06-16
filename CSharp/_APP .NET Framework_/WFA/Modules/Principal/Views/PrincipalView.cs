using VIPER.DTO;
using VIPER.Entity;
using VIPER.Modules.Principal.Interfaces;
using VIPER.Service;
using VIPER.WFA;
using Chronus.DXperience;
using DevExpress.Utils;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace VIPER.Modules.Principal.Views
{
    public partial class PrincipalView : XtraForm, IPresenterToViewPrincipal
    {
        public IViewToPresenterPrincipal presenter;

        private bool bForcarSaida = false;

        public PrincipalView()
        {
            InitializeComponent();
        }

        private void UpdateSearchFuncao()
        {
            presenter.SelecionarAcessoPorUsuarioSistema(Global.Instance.UsuarioLogado.Id, Global.Instance.Sistema.Id);
        }

        private void PrepareUI()
        {
            if (Screen.PrimaryScreen.WorkingArea.Height > 970)
                ClientSize = new Size(ClientSize.Width, 945);
        }

        private void UpdateIconsNavPane()
        {
            searchLookUpEditFuncao.Visible = !Global.Instance.GerenciadorSistema;
            navButtonAlterarSenha.Visible = !Global.Instance.GerenciadorSistema;
            navButtonTrocarSistema.Visible = !Global.Instance.GerenciadorSistema && Global.Instance.TemVariosSistema;
            navButtonTrocarUsuario.Visible = !Global.Instance.GerenciadorSistema;
        }

        private void CreateTileBarPrincipal(int sistema, int usuario)
        {
            xtcModulo.TabPages.Clear();

            foreach (TileGroup group in tileBarPrincipal.Groups)
                group.Items.Clear();
            tileBarPrincipal.Groups.Clear();

            if (Global.Instance.Sistema != null)
            {
                navButtonTitulo.Caption = Global.Instance.Sistema.Descricao;
                tileBarPrincipal.Text = Global.Instance.Sistema.Descricao;
                tileBarPrincipal.DropDownOptions.AutoHeight = DefaultBoolean.True;
                tileBarPrincipal.Groups.Add(new TileGroup());
                navButtonTitulo.Glyph = Global.Instance.Sistema.Imagem != null ? Image.FromStream(new MemoryStream(Global.Instance.Sistema.Imagem)) : null;

                if (Global.Instance.GerenciadorSistema)
                    presenter.SelecionarModulosPorSistema(sistema);
                else
                    presenter.SelecionarModulosPorSistemaUsuario(sistema, usuario);
            }
        }

        protected int CalcBestSizeTileBarItem(string text)
        {
            using (var button = new SimpleButton())
            {
                button.Text = text;
                Size size = button.CalcBestSize();
                return size.Width;
            }
        }

        protected void CreateFormTabPage(XtraTabControl paginas, int funcaoid)
        {
            var funcao = Global.Instance.Funcaos.Where(p => p.Id == funcaoid).FirstOrDefault();
            var form = CreateXtraForm(funcao.NomeAssembly, funcao.NomeFormulario, funcao.Id, funcao.Tipo);

            if (form == null)
                XtraMessageBox.Show("Módulo não liberado para o usuário!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                form.Text = funcao.Descricao;
                var bAchou = false;
                XtraTabPage newPag;
                foreach (XtraTabPage pag in paginas.TabPages)
                {
                    if (pag.Text == form.Text)
                    {
                        newPag = pag;
                        paginas.SelectedTabPage = newPag;
                        bAchou = true;
                    }
                }

                if (!bAchou)
                {
                    newPag = new XtraTabPage();
                    newPag.Text = form.Text;

                    form.TopLevel = false;
                    form.FormBorderStyle = FormBorderStyle.None;
                    form.Size = new Size(paginas.Size.Width, paginas.Size.Height - 24);

                    if (form is FrmManutencao)
                    {
                        (form as FrmManutencao).ParentControl = paginas;
                        (form as FrmManutencao).ParentPage = newPag;
                    }
                    else if (form is FrmModelo)
                    {
                        (form as FrmModelo).ParentControl = paginas;
                        (form as FrmModelo).ParentPage = newPag;
                    }

                    newPag.Controls.Add(form);
                    form.Show();

                    paginas.TabPages.Add(newPag);
                    paginas.SelectedTabPage = newPag;
                }
            }
        }

        protected XtraForm CreateXtraForm(string assembly, string formulario, int funcao, string tipo)
        {
            if (tipo.Equals("F"))
            {
                var splash = new Chronus.DXperience.SplashScreen("Carregando formulário...");
                var xform = FormularioMEF.formularioMEF.Formularios.Where(p => p.ToString() == assembly).FirstOrDefault();
                XtraForm form = null;
                if (xform != null)
                    form = xform.Carregar(formulario, funcao);
                splash.FinalizarSplashScreen();

                return xform != null ? form : null;
            }
            else if (tipo.Equals("R"))
            {
                //var splash = new Chronus.DXperience.SplashScreen("Carregando relatório...");
                //var frm = new FrmParametroRelatorio(funcao);
                //splash.FinalizarSplashScreen();
                //return frm;
                return null;
            }
            else
                return null;
        }

        private void Item_ItemClick(object sender, TileItemEventArgs e)
        {
            (sender as TileBarItem).ShowDropDown();
        }

        private void ItemMenu_ItemClick(object sender, TileItemEventArgs e)
        {
            CreateFormTabPage(xtcModulo, (int)(sender as TileBarItem).Tag);
            tileBarPrincipal.HideDropDownWindow();
        }

        private void xtcModulo_CloseButtonClick(object sender, EventArgs e)
        {
            if ((((e as ClosePageButtonEventArgs).Page as XtraTabPage).Controls[0] is FrmManutencao) &&
                (((e as ClosePageButtonEventArgs).Page as XtraTabPage).Controls[0] as FrmManutencao).InsertOrEdit)
            {
                if (XtraMessageBox.Show("Esta operação irá cancelar todas as alterações feitas no registro.\r\nConfirma essa operação?",
                    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    return;
            }

            (((e as ClosePageButtonEventArgs).Page as XtraTabPage).Controls[0] as XtraForm).Close();
            (sender as XtraTabControl).TabPages.Remove(((e as ClosePageButtonEventArgs).Page as XtraTabPage));
        }

        private void navButtonTrocarUsuario_ElementClick(object sender, NavElementEventArgs e)
        {
            presenter.CarregarLogin(out bool confirmado);
            if (confirmado)
            {
                CreateTileBarPrincipal(Global.Instance.Sistema.Id, Global.Instance.UsuarioLogado.Id);
				UpdateIconsNavPane();
                UpdateSearchFuncao();
            }
        }

        private void navButtonAlterarSenha_ElementClick(object sender, NavElementEventArgs e)
        {
            presenter.CarregarAlteraSenha();
        }

        private void navButtonTrocarSistema_ElementClick(object sender, NavElementEventArgs e)
        {
            presenter.CarregarTrocaSistema(out bool confirmado);
            if (confirmado)
            {
                this.CreateTileBarPrincipal(Global.Instance.Sistema.Id, Global.Instance.UsuarioLogado.Id);
            }
        }

        private void navButtonFechar_ElementClick(object sender, NavElementEventArgs e)
        {
            Close();
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);

            if (bForcarSaida)
                e.Cancel = false;
            else
            {
                var closeAction = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction();
                closeAction.Caption = navButtonTitulo.Caption;
                closeAction.Description = "Deseja realmente finalizar o sistema?";
                closeAction.Commands.Add(DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand.Yes);
                closeAction.Commands.Add(DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand.No);
                if (DevExpress.XtraBars.Docking2010.Customization.FlyoutDialog.Show(this, closeAction) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }

        private void FrmPrincipalHybrid_Load(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(global::VIPER.WFA.SplashScreenHybrid));
            FormularioMEF.formularioMEF.CarregarAssembly();
            PrepareUI();
            CreateTileBarPrincipal(Global.Instance.Sistema.Id, Global.Instance.UsuarioLogado.Id);
            UpdateIconsNavPane();
            UpdateSearchFuncao();
            SplashScreenManager.CloseDefaultSplashScreen();

            Width = SystemInformation.WorkingArea.Width;
            Height = SystemInformation.WorkingArea.Height;
            Location = new Point(0, 0);

            var skinname = new Gerenciador.SettingsDefault().SkinName;
            navButtonTitulo.AppearanceDisabled.BackColor = ConversionDX.SkinNameToColor(skinname);
            navButtonTitulo.AppearanceHovered.BackColor = ConversionDX.SkinNameToColor(skinname);
            navButtonTitulo.AppearanceSelected.BackColor = ConversionDX.SkinNameToColor(skinname);
        }

        private void navButtonMinimizar_ElementClick(object sender, NavElementEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void gridLookUpEditFuncao_Popup(object sender, EventArgs e)
        {
            gridLookUpEditFuncao.Properties.View.ExpandAllGroups();
        }

        private void gridLookUpEditFuncao_Validated(object sender, EventArgs e)
        {
            gridLookUpEditFuncao.EditValue = null;
        }

        private void gridLookUpEditFuncao_Closed(object sender, ClosedEventArgs e)
        {
            if (!gridLookUpEditFuncao.IsNullOrDbnull())
                CreateFormTabPage(xtcModulo, (Convert.ToInt32(gridLookUpEditFuncao.EditValue)));
        }

        private void searchLookUpEditFuncao_Popup(object sender, EventArgs e)
        {
            searchLookUpEditFuncao.Properties.View.ExpandAllGroups();
        }

        private void searchLookUpEditFuncao_Validated(object sender, EventArgs e)
        {
            searchLookUpEditFuncao.EditValue = null;
        }

        private void searchLookUpEditFuncao_Closed(object sender, ClosedEventArgs e)
        {
            if (!searchLookUpEditFuncao.IsNullOrDbnull())
                CreateFormTabPage(xtcModulo, (Convert.ToInt32(searchLookUpEditFuncao.EditValue)));
        }

        public void SelecionarModulosSucesso(List<Entity.Modulo> modulos)
        {
            foreach (var modulo in modulos)
            {
                var item = new TileBarItem();
                var container = new TileBarDropDownContainer();
                var tileBarModulo = new TileBar();

                container.Location = new Point(0, 0);
                container.Size = new Size(120, 120);
                if (modulo.Cor != 0)
                    container.BackColor = Color.FromArgb(modulo.Cor);
                else
                    container.BackColor = tileNavPanePrincipal.Appearance.BackColor;
                container.Name = "container" + modulo.Descricao;
                container.Controls.Add(tileBarModulo);
                this.Controls.Add(container);

                tileBarModulo.AllowDrag = false;
                tileBarModulo.AllowSelectedItem = false;
                tileBarModulo.Location = new Point(0, 0);
                tileBarModulo.Dock = DockStyle.Fill;
                tileBarModulo.BackColor = Color.Transparent;
                tileBarModulo.Padding = new Padding(20, 6, 20, 6);
                tileBarModulo.Name = "tileBar" + modulo.Descricao;
                tileBarModulo.Groups.Add(new TileGroup());
                tileBarModulo.ItemSize = tileBarPrincipal.ItemSize;
                tileBarModulo.Padding = tileBarPrincipal.Padding;

                item.Text = modulo.Descricao;
                item.Tag = modulo.Id;
                if (modulo.Cor != 0)
                    item.AppearanceItem.Normal.BackColor = Color.FromArgb(modulo.Cor);
                else
                    item.AppearanceItem.Normal.BackColor = tileNavPanePrincipal.Appearance.BackColor;
                item.AppearanceItem.Normal.Font = new Font("Segoe UI", 10f);
                item.Image = modulo.Imagem != null ? Image.FromStream(new MemoryStream(modulo.Imagem)) : null;
                item.DropDownOptions.AutoHeight = DefaultBoolean.True;
                item.DropDownOptions.BackColorMode = BackColorMode.UseTileBackColor;
                item.DropDownControl = container;
                tileBarPrincipal.Groups[0].Items.Add(item);
                item.ItemClick += Item_ItemClick;

                if (Global.Instance.GerenciadorSistema)
                    presenter.SelecionarFuncaoPorModulo(modulo.Id, tileBarModulo, item, container);
                else
                    presenter.SelecionarAcessoPorUsuarioModulo(Global.Instance.UsuarioLogado.Id, modulo.Id, Global.Instance.Sistema.Id, tileBarModulo, item, container);
            }
        }

        public void SelecionarModulosFalha()
        {
            
        }

        public void SelecionarFuncaoPorModuloSucesso(List<Entity.Funcao> funcaos, TileBar tilebarmodulo, TileBarItem tilebaritem, TileBarDropDownContainer container)
        {
            var contador = 0;
            var sizeTileBarItem = 0;
            foreach (var funcao in funcaos)
            {
                TileBarItem itemMenu = new TileBarItem();
                itemMenu.Text = funcao.Descricao;
                itemMenu.Tag = funcao.Id;
                itemMenu.AppearanceItem.Normal.BackColor = tilebaritem.AppearanceItem.Normal.BackColor;
                itemMenu.AppearanceItem.Normal.Font = new Font("Segoe UI", 8f);
                itemMenu.TextAlignment = TileItemContentAlignment.MiddleLeft;
                itemMenu.AllowGlyphSkinning = DefaultBoolean.True;
                itemMenu.ItemSize = TileBarItemSize.Wide;
                itemMenu.ItemClick += ItemMenu_ItemClick;
                tilebarmodulo.Groups[0].Items.Add(itemMenu);
                contador++;
                int bestSize = CalcBestSizeTileBarItem(funcao.Descricao);
                sizeTileBarItem = sizeTileBarItem < bestSize ? bestSize : sizeTileBarItem;
            }

            tilebarmodulo.Orientation = Orientation.Vertical;
            tilebarmodulo.ItemSize = 24;
            tilebarmodulo.IndentBetweenItems = 2;
            tilebarmodulo.ScrollMode = TileControlScrollMode.ScrollButtons;
            tilebarmodulo.WideTileWidth = sizeTileBarItem + 40;

            container.Height = 64 + (26 * (contador - 1));
            if (container.Height > (this.Height - tileBarPrincipal.Height - tileNavPanePrincipal.Height))
                container.Height = this.Height - tileBarPrincipal.Height - tileNavPanePrincipal.Height;
        }

        public void SelecionarFuncaoPorModuloFalha()
        {
            
        }

        public void SelecionarAcessoPorUsuarioModuloSucesso(List<UsuarioFuncaoDTO> acesso, TileBar tilebarmodulo, TileBarItem tilebaritem, TileBarDropDownContainer container)
        {
            var contador = 0;
            var sizeTileBarItem = 0;
            foreach (var funcao in acesso)
            {
                TileBarItem itemMenu = new TileBarItem();
                itemMenu.Text = funcao.FuncaoDescricao;
                itemMenu.Tag = funcao.FuncaoId;
                itemMenu.AppearanceItem.Normal.BackColor = tilebaritem.AppearanceItem.Normal.BackColor;
                itemMenu.AppearanceItem.Normal.Font = new Font("Segoe UI", 8f);
                itemMenu.TextAlignment = TileItemContentAlignment.MiddleLeft;
                itemMenu.AllowGlyphSkinning = DefaultBoolean.True;
                itemMenu.ItemSize = TileBarItemSize.Wide;
                itemMenu.ItemClick += ItemMenu_ItemClick;
                tilebarmodulo.Groups[0].Items.Add(itemMenu);
                contador++;
                int bestSize = CalcBestSizeTileBarItem(funcao.FuncaoDescricao);
                sizeTileBarItem = sizeTileBarItem < bestSize ? bestSize : sizeTileBarItem;
            }

            tilebarmodulo.Orientation = Orientation.Vertical;
            tilebarmodulo.ItemSize = 24;
            tilebarmodulo.IndentBetweenItems = 2;
            tilebarmodulo.ScrollMode = TileControlScrollMode.ScrollButtons;
            tilebarmodulo.WideTileWidth = sizeTileBarItem + 40;

            container.Height = 64 + (26 * (contador - 1));
            if (container.Height > (this.Height - tileBarPrincipal.Height - tileNavPanePrincipal.Height))
                container.Height = this.Height - tileBarPrincipal.Height - tileNavPanePrincipal.Height;
        }

        public void SelecionarAcessoPorUsuarioModuloFalha()
        {
			searchLookUpEditFuncao.Properties.DataSource = null;           
        }

        public void SelecionarAcessoPorUsuarioSistemaSucesso(List<UsuarioFuncaoDTO> acesso)
        {
            searchLookUpEditFuncao.Properties.DataSource = acesso;
        }

        public void SelecionarAcessoPorUsuarioSistemaFalha()
        {
            
        }
    }
}