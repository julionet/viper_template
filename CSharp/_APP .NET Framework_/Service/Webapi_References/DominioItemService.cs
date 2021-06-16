using VIPER.Entity;
using System.Collections.Generic;

namespace VIPER.Service.Webapi_References
{
    public class DominioItemService : BaseClassService<DominioItem>
    {
        public DominioItemService(string uri) : base(uri)
        {

        }

        public List<DominioItem> SelecionarPorDominio(int id)
        {
            return WebapiSerializer.HttpGet<List<DominioItem>>(_uri, $"selecionarpordominio/{id}");
        }
    }
}
