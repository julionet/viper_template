using System.Collections.Generic;

namespace Chronus.DXperience
{
    public class PopupContainerRegistroPesquisa
    {
        public List<RegistroPesquisa> RegistroPesquisaNome()
        {
            List<RegistroPesquisa> pesquisa = new List<RegistroPesquisa>();
            pesquisa.Add(new RegistroPesquisa() { Id = 1, Descricao = "Nome", Campo = "Nome", Padrao = true, Tipo = typeof(string), Tamanho = 100 });
            return pesquisa;
        }

        public List<RegistroPesquisa> RegistroPesquisaDescricao()
        {
            List<RegistroPesquisa> pesquisa = new List<RegistroPesquisa>();
            pesquisa.Add(new RegistroPesquisa() { Id = 1, Descricao = "Descrição", Campo = "Descricao", Padrao = true, Tipo = typeof(string), Tamanho = 100 });
            return pesquisa;
        }
    }
}
