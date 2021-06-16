using VIPER.Entity;
using System.Collections.Generic;

namespace VIPER.Service.Webapi_References
{
    public class AtualizacaoService : BaseClassService<Atualizacao>
    {
        public AtualizacaoService(string uri) : base(uri)
        {

        }

        public string Importar(Atualizacao[] entity)
        {
            return WebapiSerializer.HttpPost<Atualizacao[], string>(entity, _uri, "importar");
        }

        public int Contar()
        {
            return WebapiSerializer.HttpGet<int>(_uri, "contar");
        }

        public int ContarPendente()
        {
            return WebapiSerializer.HttpGet<int>(_uri, "contarpendente");
        }

        public bool ExisteAtualizacao(int numero)
        {
            return WebapiSerializer.HttpGet<bool>(_uri, "existeatualizacao");
        }

        public List<Atualizacao> SelecionarTodosPendente()
        {
            return WebapiSerializer.HttpGet<List<Atualizacao>>(_uri, "selecionartodospendente");
        }

        public string AtualizarVersao(Atualizacao atualizacao)
        {
            return WebapiSerializer.HttpPost<Atualizacao, string>(atualizacao, _uri, "atualizarversao");
        }

        public string FinalizarAtualizacoes()
        {
            return WebapiSerializer.HttpGet<string>(_uri, "finalizaratualizacoes");
        }
    }
}
