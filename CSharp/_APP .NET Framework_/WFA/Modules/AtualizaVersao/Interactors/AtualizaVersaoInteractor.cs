using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using VIPER.Entity;
using VIPER.Modules.AtualizaVersao.Interfaces;
using VIPER.Service;

namespace VIPER.Modules.AtualizaVersao.Interactors
{
    public class AtualizaVersaoInteractor : IPresenterToInteractorAtualizaVersao
    {
        public IInteractorToPresenterAtualizaVersao presenter;

        public void Atualizar(List<Atualizacao> atualizacoes)
        {
            var mensagem = "";
            foreach (var atualizacao in atualizacoes.OrderBy(p => p.Id))
            {
                if (atualizacao.Status == "P")
                {
                    if (atualizacao.Sql.Substring(0, 8).ToLower().Equals("$report$"))
                    {
                        if (atualizacao.Sql.Contains("{") && atualizacao.Sql.Contains("}"))
                        {
                            var arquivo = atualizacao.Sql.Substring(atualizacao.Sql.IndexOf("{") + 1, atualizacao.Sql.Substring(atualizacao.Sql.IndexOf("{") + 1).IndexOf("}"));
                            if (File.Exists(arquivo))
                            {
                                var ds = new DataSet();
                                ds.ReadXml(arquivo);

                                var relatorios = new List<Relatorio>();
                                foreach (DataRow dr in ds.Tables[0].Rows)
                                {
                                    relatorios.Add(new Relatorio()
                                    {
                                        Id = Convert.ToInt32(dr["Id"]),
                                        Codigo = dr["Codigo"].ToString(),
                                        Nome = dr["Nome"].ToString(),
                                        Origem = dr["Origem"].ToString(),
                                        Tamanho = Convert.ToInt32(dr["Tamanho"]),
                                        Modificado = Convert.ToDateTime(dr["Modificado"]),
                                        Modelo = Encoding.GetEncoding("ISO-8859-1").GetString(Convert.FromBase64String(dr["Modelo"].ToString())),
                                        Parametro = Encoding.GetEncoding("ISO-8859-1").GetString(Convert.FromBase64String(dr["Parametro"].ToString())),
                                        Matricial = Convert.ToBoolean(dr["Matricial"]),
                                        Visualizar = Convert.ToBoolean(dr["Visualizar"]),
                                        QuebraPagina = Convert.ToBoolean(dr["QuebraPagina"]),
                                        GraficoTexto = Convert.ToBoolean(dr["GraficoTexto"]),
                                        LinhaBranco = Convert.ToBoolean(dr["LinhaBranco"]),
                                        EscalaX = Convert.ToInt32(dr["EscalaX"]),
                                        EscalaY = Convert.ToInt32(dr["EscalaY"])
                                    });
                                }

                                mensagem = Servicos.relatorioService.Importar(relatorios.ToArray());
                                if (mensagem != "")
                                {
                                    atualizacao.Status = "E";
                                    atualizacao.Mensagem = mensagem;
                                    Servicos.atualizacaoService.Salvar(atualizacao);

                                    presenter.AtualizarFalha(DateTime.Now.ToLongTimeString() + " - Atualização " + atualizacao.Id.ToString() + " não executada - " + mensagem);
                                    break;
                                }
                                else
                                {
                                    atualizacao.Status = "O";
                                    atualizacao.Mensagem = "Atualização realizada com sucesso!";
                                    Servicos.atualizacaoService.Salvar(atualizacao);

                                    presenter.AtualizarSucesso(DateTime.Now.ToLongTimeString() + " - Atualização " + atualizacao.Id.ToString() + " realizada com sucesso");
                                }
                            }
                            else
                            {
                                atualizacao.Status = "E";
                                atualizacao.Mensagem = mensagem;
                                Servicos.atualizacaoService.Salvar(atualizacao);

                                presenter.AtualizarFalha(DateTime.Now.ToLongTimeString() + " - Atualização " + atualizacao.Id.ToString() + " não executada - " + mensagem);
                                break;
                            }
                        }
                    }
                    else
                    {
                        mensagem = Servicos.atualizacaoService.AtualizarVersao(atualizacao);
                        if (mensagem != "")
                        {
                            atualizacao.Status = "E";
                            atualizacao.Mensagem = mensagem;

                            presenter.AtualizarFalha(DateTime.Now.ToLongTimeString() + " - Atualização " + atualizacao.Id.ToString() + " não executada - " + mensagem);
                            break;
                        }
                        else
                        {
                            atualizacao.Status = "O";
                            atualizacao.Mensagem = "Atualização realizada com sucesso!";

                            presenter.AtualizarSucesso(DateTime.Now.ToLongTimeString() + " - Atualização " + atualizacao.Id.ToString() + " realizada com sucesso");
                        }
                    }
                }
            }

            if (mensagem == "")
                presenter.AtualizarConcluido();
        }

        public void SelecionarPendentes()
        {
            var dados = Servicos.atualizacaoService.SelecionarTodosPendente();
            if (dados.Count != 0)
                presenter.SelecionarPendentesSucesso(dados);
            else
                presenter.SelecionarPendentesFalha();
        }
    }
}
