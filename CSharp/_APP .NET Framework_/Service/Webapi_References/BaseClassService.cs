using System.Collections.Generic;

namespace VIPER.Service.Webapi_References
{
    public class BaseClassService<T> where T: class
    {
        protected string _uri;

        public BaseClassService(string uri)
        {
            _uri = uri;
        }

        public virtual string Salvar(T entity)
        {
            return WebapiSerializer.HttpPost<T, string>(entity, _uri, "salvar");
        }

        public virtual string Excluir(T entity)
        {
            return WebapiSerializer.HttpPost<T, string>(entity, _uri, "excluir");
        }

        public virtual T Selecionar(int id)
        {
            return WebapiSerializer.HttpGet<T>(_uri, $"selecionar/{id}");
        }

        public virtual List<T> SelecionarTodos()
        {
            return WebapiSerializer.HttpGet<List<T>>(_uri, "selecionartodos");
        }

        public virtual List<T> Filtrar(string condicao)
        {
            return WebapiSerializer.HttpGet<List<T>>(_uri, $"filtrar?condicao={condicao}");
        }
    }
}
