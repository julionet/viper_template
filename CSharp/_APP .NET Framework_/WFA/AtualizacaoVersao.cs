using VIPER.Entity;
using VIPER.Service;
using Chronus.DXperience;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace VIPER.WFA
{
    public class AtualizacaoVersao
    {
        private string _nomearquivo = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "VIPER.exe.update");
        private DataSet ds;

        public AtualizacaoVersao()
        {
            ds = new DataSet();
            if (File.Exists(_nomearquivo))
                ds.ReadXml(_nomearquivo);
        }

        private bool VerificarNovaAtualizacao()
        {
            if (ds.Tables.Count != 0)
                return ds.Tables[0].Rows.Count != Servicos.atualizacaoService.Contar();
            else
                return false;
        }

        private bool VerificarAtualizacaoPendente()
        {
            var precisaatualizar = Servicos.atualizacaoService.ContarPendente() != 0;
            if (precisaatualizar)
            {
                if (!Parametros.Instance.PrecisaAtualizarBanco)
                {
                    Servicos.atualizacaoService.FinalizarAtualizacoes();
                    precisaatualizar = false;
                }
            }
            return precisaatualizar;
        }

        private string ImportarAtualizacao()
        {
            var atualizacoes = new List<Atualizacao>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                atualizacoes.Add(new Atualizacao()
                {
                    Banco = dr["Banco"].ToString(),
                    Data = Convert.ToDateTime(dr["Data"]),
                    Descricao = dr["Descricao"].ToString(),
                    Id = Convert.ToInt32(dr["Id"]),
                    Numero = Convert.ToInt32(dr["Numero"]),
                    Sql = Encoding.GetEncoding("ISO-8859-1").GetString(Convert.FromBase64String(dr["Sql"].ToString())),
                    SqlProcedimento = Convert.ToBoolean(dr["SqlProcedimento"]),
                    Status = "P",
                    Versao = dr["Versao"].ToString()
                });
            }
            return Servicos.atualizacaoService.Importar(atualizacoes.ToArray());
        }

        public string Atualizar()
        {
            if (ds.Tables.Count != 0)
            {
                if (VerificarNovaAtualizacao())
                {
                    var splash = new SplashScreen("Importanto atualizações ...");
                    string mensagem = ImportarAtualizacao();
                    splash.FinalizarSplashScreen();
                    if (mensagem != "")
                        return mensagem;
                }

                if (VerificarAtualizacaoPendente())
                {
                    using (var form = Modules.AtualizaVersao.Routers.AtualizaVersaoRouter.New())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                            return "";
                        else
                            return "Atualização cancelada pelo usuário!";
                    }
                }
                else
                    return "";
            }
            else
                return "";
        }
    }
}
