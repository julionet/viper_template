using VIPER.DTO;
using VIPER.Entity;
using System.Collections.Generic;

namespace VIPER.Service.Webapi_References
{
    public class RelatorioService : BaseClassService<Relatorio>
    {
        public RelatorioService(string uri) : base(uri)
        {

        }

        public string Importar(Relatorio[] entity)
        {
            return WebapiSerializer.HttpPost<Relatorio[], string>(entity, _uri, "importar");
        }

        public new RelatorioRetornoDTO Selecionar(int id)
        {
            return WebapiSerializer.HttpGet<RelatorioRetornoDTO>(_uri, string.Format("selecionar/{0}", id));
        }

        public new List<RelatorioRetornoDTO> SelecionarTodos()
        {
            return WebapiSerializer.HttpGet<List<RelatorioRetornoDTO>>(_uri, "selecionartodos");
        }

        public RelatorioRetornoDTO SelecionarPorCodigo(string codigo)
        {
            return WebapiSerializer.HttpGet<RelatorioRetornoDTO>(_uri, string.Format("selecionarporcodigo/{0}", codigo));
        }

        public FastReportDTO GetFastReport(RelatorioDTO relatorio)
        {
            return WebapiSerializer.HttpPost<RelatorioDTO, FastReportDTO>(relatorio, _uri, "getfastreport");
        }
    }
}
