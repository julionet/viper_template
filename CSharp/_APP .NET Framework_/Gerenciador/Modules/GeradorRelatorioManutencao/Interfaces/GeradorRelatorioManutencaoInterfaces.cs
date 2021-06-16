namespace VIPER.Modules.GeradorRelatorioManutencao.Interfaces
{
    public interface IViewToPresenterGeradorRelatorioManutencao
    {
        void Salvar(Entity.Relatorio entity);
    }

    public interface IPresenterToViewGeradorRelatorioManutencao
    {
        void SalvarSucesso();
        void SalvarFalha(string mensagem);
    }

    public interface IPresenterToInteractorGeradorRelatorioManutencao
    {
        void Salvar(Entity.Relatorio entity);
    }

    public interface IInteractorToPresenterGeradorRelatorioManutencao
    {
        void SalvarSucesso();
        void SalvarFalha(string mensagem);
    }

    public interface IPresenterToRouterGeradorRelatorioManutencao
    {
        
    }
}
