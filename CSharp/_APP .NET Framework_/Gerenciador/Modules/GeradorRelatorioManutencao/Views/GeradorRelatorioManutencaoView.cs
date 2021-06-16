using VIPER.Entity;
using VIPER.Modules.GeradorRelatorioManutencao.Interfaces;
using Chronus.DXperience;
using DevExpress.XtraEditors;
using System;
using System.IO;
using System.Windows.Forms;

namespace VIPER.Modules.GeradorRelatorioManutencao.Views
{
    public partial class GeradorRelatorioManutencaoView : FrmModelo, IPresenterToViewGeradorRelatorioManutencao
    {
        public IViewToPresenterGeradorRelatorioManutencao presenter;

        private SplashScreen _splash;

        public GeradorRelatorioManutencaoView(BindingSource source)
            : base(source)
        {
            InitializeComponent();
            checkEditMatricial_CheckedChanged(null, null);
        }

        private void checkEditMatricial_CheckedChanged(object sender, EventArgs e)
        {
            checkEditQuebraPagina.Enabled = checkEditMatricial.Checked;
            checkEditGraficoTexto.Enabled = checkEditMatricial.Checked;
            checkEditLinhaBranco.Enabled = checkEditMatricial.Checked;
            checkEditVisualizar.Enabled = checkEditMatricial.Checked;
            calcEditEscalaX.Enabled = checkEditMatricial.Checked;
            calcEditEscalaY.Enabled = checkEditMatricial.Checked;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _splash = new SplashScreen("Salvando relatório...");
            presenter.Salvar(detalheBindingSource.Current as Relatorio);
        }

        private void simpleButtonImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = "frx";
            openFileDialog.Filter = "Arquivos FastReport|*.frx";
            openFileDialog.Title = "Importar Modelo";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string nomerelatorio = Path.GetFileName(openFileDialog.FileName);
                string codigo = nomerelatorio.IndexOf(" - ") != -1 ? nomerelatorio.Substring(0, nomerelatorio.IndexOf(" - ")) : "";
                string nome = nomerelatorio.IndexOf(" - ") != -1 ? Path.GetFileNameWithoutExtension(openFileDialog.FileName).Replace(codigo + " - ", "") : Path.GetFileNameWithoutExtension(openFileDialog.FileName);

                if (string.IsNullOrWhiteSpace((detalheBindingSource.Current as Relatorio).Codigo))
                    (detalheBindingSource.Current as Relatorio).Codigo = codigo;
                if (string.IsNullOrWhiteSpace((detalheBindingSource.Current as Relatorio).Nome))
                    (detalheBindingSource.Current as Relatorio).Nome = nome;
                (detalheBindingSource.Current as Relatorio).Origem = "F";
                (detalheBindingSource.Current as Relatorio).Modelo = File.ReadAllText(openFileDialog.FileName);
                (detalheBindingSource.Current as Relatorio).Modificado = DateTime.Now;
                (detalheBindingSource.Current as Relatorio).Tamanho = (detalheBindingSource.Current as Relatorio).Modelo.Length;
                detalheBindingSource.ResetCurrentItem();
                XtraMessageBox.Show("Modelo importado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void simpleButtonExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "frx";
            saveFileDialog.Filter = "Arquivos FastReport|*.frx";
            saveFileDialog.Title = "Exportar Modelo";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, (detalheBindingSource.Current as Relatorio).Modelo);
                XtraMessageBox.Show("Modelo exportado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void SalvarSucesso()
        {
            _splash.FinalizarSplashScreen();
        }

        public void SalvarFalha(string mensagem)
        {
            _splash.FinalizarSplashScreen();
            XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DialogResult = DialogResult.None;
        }
    }
}
