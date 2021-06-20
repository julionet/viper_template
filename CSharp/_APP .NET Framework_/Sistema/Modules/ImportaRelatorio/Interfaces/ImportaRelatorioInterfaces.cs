﻿using VIPER.Entity;

namespace VIPER.Modules.ImportaRelatorio.Interfaces
{
    public interface IViewToPresenterImportaRelatorio
    {
        void Importar(Relatorio[] entity);
    }

    public interface IPresenterToViewImportaRelatorio
    {
        void ImportarSucesso();
        void ImportarFalha(string mensagem);
    }

    public interface IPresenterToInteractorImportaRelatorio
    {
        void Importar(Relatorio[] entity);
    }

    public interface IInteractorToPresenterImportaRelatorio
    {
        void ImportarSucesso();
        void ImportarFalha(string mensagem);
    }

    public interface IPresenterToRouterImportaRelatorio
    {
        
    }
}
