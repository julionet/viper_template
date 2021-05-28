//
//  IPadraoRepository.cs
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

using System.Linq;

namespace VIPER.Repository.Interface
{
    public interface IPadraoRepository<T> where T : class
    {
        string Incluir(T entity);
        string Alterar(T entity);
        //string Excluir(T entity);
        string Excluir(int id);
        T Selecionar(int id);
        IQueryable<T> SelecionarTodos();
        IQueryable<T> Filtrar(string condicao);
    }
}
