using VIPER.Entity;
using VIPER.Modules.ImportaRelatorio.Interfaces;
using Chronus.DXperience;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace VIPER.Modules.ImportaRelatorio.Views
{
    public partial class ImportaRelatorioView : FrmModelo, IPresenterToViewImportaRelatorio
    {
        public IViewToPresenterImportaRelatorio presenter;

        private DataSet ds = new DataSet();
        private SplashScreen _splash;

        public ImportaRelatorioView(int funcao)
        {
            InitializeComponent();
        }

        public void ImportarFalha(string mensagem)
        {
            _splash.FinalizarSplashScreen();
            XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void ImportarSucesso()
        {
            _splash.FinalizarSplashScreen();
            XtraMessageBox.Show("Relatórios importados com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            betArquivo.EditValue = null;
            clbcRelatorios.Items.Clear();
            btnOk.Enabled = false;
        }

        private void betArquivo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                betArquivo.EditValue = openFileDialog.FileName;

                ds.Tables.Clear();
                ds.ReadXml(openFileDialog.FileName);
                ds.Tables[0].PrimaryKey = new DataColumn[] { ds.Tables[0].Columns["Id"] };

                foreach (DataRow dr in ds.Tables[0].Rows)
                    clbcRelatorios.Items.Add(Convert.ToInt32(dr["Id"]), $"{dr["Codigo"].ToString()}: {dr["Nome"].ToString()}", CheckState.Checked, true);

                btnOk.Enabled = clbcRelatorios.Items.Count != 0;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if ((clbcRelatorios.Items.Count == 0) || (clbcRelatorios.CheckedItems.Count == 0))
                XtraMessageBox.Show("Nenhum relatório selecionado para ser importado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var relatorios = new List<Relatorio>();
                foreach (var item in clbcRelatorios.CheckedItems)
                {
                    DataRow dr = ds.Tables[0].Rows.Find(Convert.ToInt32((item as CheckedListBoxItem).Value));
                    relatorios.Add(new Relatorio()
                    {
                        Codigo = dr["Codigo"].ToString(),
                        EscalaX = Convert.ToDouble(dr["EscalaX"]),
                        EscalaY = Convert.ToDouble(dr["EscalaY"]),
                        GraficoTexto = Convert.ToBoolean(dr["GraficoTexto"]),
                        Id = Convert.ToInt32(dr["Id"]),
                        LinhaBranco = Convert.ToBoolean(dr["LinhaBranco"]),
                        Matricial = Convert.ToBoolean(dr["Matricial"]),
                        Modelo = Encoding.GetEncoding("ISO-8859-1").GetString(Convert.FromBase64String(dr["Modelo"].ToString())),
                        Modificado = Convert.ToDateTime(dr["Modificado"]),
                        Nome = dr["Nome"].ToString(),
                        Origem = dr["Origem"].ToString(),
                        Parametro = Encoding.GetEncoding("ISO-8859-1").GetString(Convert.FromBase64String(dr["Parametro"].ToString())),
                        QuebraPagina = Convert.ToBoolean(dr["QuebraPagina"]),
                        Tamanho = Convert.ToInt32(dr["Tamanho"]),
                        Visualizar = Convert.ToBoolean(dr["Visualizar"])
                    });

                }

                _splash = new SplashScreen("Importando relatórios ...");
                presenter.Importar(relatorios.ToArray());
            }
        }
    }
}
