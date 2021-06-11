using VIPER.Controller.App_Start;
using VIPER.DTO;
using VIPER.Entity;
using VIPER.Infrastructure;
using VIPER.Repository;
using Chronus.Library;
using FastReport;
using FastReport.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web.Http;

namespace VIPER.Service.Controllers
{
    [RoutePrefix("api/relatorio")]
    [BasicAuthentication]
    public class RelatorioController : ApiController
    {
        private string _mensagem = "";

        [HttpPost]
        [Route("importar")]
        public string Importar(Relatorio[] entity)
        {
            using (var _db = new _VIPER_Context())
            {
                using (var transacao = _VIPER_Transaction.CreateDbContextTransaction(_db))
                {
                    var repository = new RelatorioRepository(_db);
                    foreach (Relatorio relatorio in entity)
                    {
                        Relatorio registro = repository.SelecionarPorCodigo(relatorio.Codigo);
                        if (registro == null)
                            _mensagem = repository.Incluir(relatorio);
                        else
                        {
                            relatorio.Id = registro.Id;
                            _mensagem = repository.Alterar(relatorio);
                        }

                        if (_mensagem != "")
                            break;
                    }
                    repository.Dispose();

                    if (_mensagem == "")
                        transacao.Commit();
                    else
                        transacao.Rollback();
                }
            }
            return _mensagem;
        }

        [HttpGet]
        [Route("selecionar/{id}")]
        public RelatorioRetornoDTO Selecionar(int id)
        {
            return new RelatorioRepository().SelecionarDTO(id);
        }

        [HttpGet]
        [Route("selecionartodos")]
        public List<RelatorioRetornoDTO> SelecionarTodos()
        {
            return new RelatorioRepository().SelecionarTodosDTO().ToList();
        }

        [HttpGet]
        [Route("selecionarporcodigo/{codigo}")]
        public RelatorioRetornoDTO SelecionarPorCodigo(string codigo)
        {
            return new RelatorioRepository().SelecionarPorCodigoDTO(codigo);
        }

        [HttpPost]
        [Route("getfastreport")]
        public FastReportDTO GetFastReport(RelatorioDTO relatorio)
        {
            string sql = "";
            try
            {
                var report = new RelatorioRepository().Selecionar(relatorio.RelatorioId);
                if ((report != null) && (report.Origem == "F"))
                {
                    var fr = new Report();
                    fr.ReportResourceString = report.Modelo;
                    fr.Dictionary.Connections[0].ConnectionString = ConnectionString.GetConnectionStringFastReport(new _VIPER_Context().Database.Connection.ConnectionString);
                    foreach (var ds in fr.Dictionary.AllObjects)
                    {
                        if (ds is TableDataSource)
                        {
                            foreach (string sparam in relatorio.Parametros.Split('|'))
                                (ds as TableDataSource).SelectCommand = (ds as TableDataSource).SelectCommand.Replace(sparam.Split(';')[0], sparam.Split(';')[1]);
                            sql += "-- " + (ds as TableDataSource).Alias + " --\r\n";
                            sql += (ds as TableDataSource).SelectCommand;
                            sql += "\r\n\r\n";
                        }
                    }
                    var ms = new MemoryStream();
                    fr.Prepare();
                    fr.SavePrepared(ms);
                    return new FastReportDTO() { Relatorio = Convert.ToBase64String(ms.ToArray()), Sql = sql };
                }
                else
                    return new FastReportDTO() { Sql = "" };
            }
            catch (Exception erro)
            {
                if (erro.InnerException != null)
                    return new FastReportDTO() { Sql = "#ERRO#" + erro.InnerException.Message + "#" + sql };
                else
                    return new FastReportDTO() { Sql = "#ERRO#" + erro.Message + "#" + sql };
            }
        }        
    }
}