using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;

namespace Chronus.DXperience
{
    public partial class FrmModelo : DevExpress.XtraEditors.XtraForm
    {
        protected bool bInsertOrEdit = false;

        public int iKey = 0;
        public DevExpress.XtraTab.XtraTabPage ParentPage;
        public DevExpress.XtraTab.XtraTabControl ParentControl;

        private Control _firstcontrol = null;
        public Control FirstControl
        {
            get { return _firstcontrol; }
            set { _firstcontrol = value; }
        }

        public FrmModelo()
        {
            InitializeComponent();
            bInsertOrEdit = true;
        }

        public FrmModelo(BindingSource detalhe) 
            : this()
        {
            detalheBindingSource = detalhe;
        }

        protected virtual void AtualizarDados()
        {
        }

        protected virtual void CreateGridButtons(GridViewWithButtons gridView)
        {
            if (gridView.ButtonsPanel.Buttons.Count != 0)
            {
                GridColumn gridColumnButtons2 = new GridColumn();
                gridColumnButtons2.Visible = true;
                gridColumnButtons2.VisibleIndex = gridView.Columns.Count - 1;
                gridColumnButtons2.MaxWidth = 120;
                gridColumnButtons2.MinWidth = 120;
                gridColumnButtons2.Width = 120;
                gridView.Columns.Add(gridColumnButtons2);

                gridView.ButtonsColumn = gridColumnButtons2;
                gridView.ShowButtons = true;
            }
        }

        private void FrmModelo_Load(object sender, EventArgs e)
        {
            Interface.SetPropertyDefault(panBackground);
            Interface.SetPropertyDefault(panBotoes);

            if (Properties.Settings.Default.EnterMudaCampo) 
                Interface.EnterMoveNextControl(panBackground);
        }

        private void FrmModelo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (sender is Form)
                {
                    if ((sender as Form).ActiveControl is LookUpEdit)
                        ((sender as Form).ActiveControl as LookUpEdit).EditValue = null;
                    else if (((Form)sender).ActiveControl is ImageComboBoxEdit)
                        ((sender as Form).ActiveControl as ImageComboBoxEdit).EditValue = null;
                    else if (((Form)sender).ActiveControl is ComboBoxEdit)
                        ((sender as Form).ActiveControl as ComboBoxEdit).EditValue = null;
                }
            }
        }

        public virtual void btnCancelar_Click(object sender, EventArgs e)
        {
            bInsertOrEdit = false;

            if (btnCancelar.DialogResult != System.Windows.Forms.DialogResult.None)
                if (ParentControl != null)
                    ParentControl.TabPages.Remove(ParentPage);
        }

        private void FrmModelo_Shown(object sender, EventArgs e)
        {
            if (_firstcontrol != null)
                _firstcontrol.Focus();
        }
    }
}
