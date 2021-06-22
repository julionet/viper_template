using VIPER.DTO;
using System.Collections.Generic;

namespace VIPER.Modules.ParametroEdicao.Interfaces
{
    public interface IViewToPresenterParametroEdicao
    {
        void ExecutarSQL(string sql);
    }

    public interface IPresenterToViewParametroEdicao
    {
        void ExecutarSQLSucesso(List<LookupDataSourceDTO> dados);
        void ExecutarSQLFalha();
    }

    public interface IPresenterToInteractorParametroEdicao
    {
        void ExecutarSQL(string sql);
    }

    public interface IInteractorToPresenterParametroEdicao
    {
        void ExecutarSQLSucesso(List<LookupDataSourceDTO> dados);
        void ExecutarSQLFalha();
    }

    public interface IPresenterToRouterParametroEdicao
    {
        
    }
}
