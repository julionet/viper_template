namespace VIPER.Service.Webapi_References
{
    public class SequencialService
    {
        private string _uri;

        public SequencialService(string uri)
        {
            _uri = uri;
        }

        public int Buscar(string nome)
        {
            return WebapiSerializer.HttpPost<string, int>(nome, _uri, "buscar");
        }

        public int Consultar(string nome)
        {
            return WebapiSerializer.HttpPost<string, int>(nome, _uri, "consultar");
        }
    }
}
