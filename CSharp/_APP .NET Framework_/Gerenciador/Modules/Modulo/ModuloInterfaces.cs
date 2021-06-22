using System.Windows.Forms;

namespace VIPER.Modules.Modulo.Interfaces
{
    public interface IViewToPresenterModulo
    {
        void Validar(Entity.Modulo entity);
        void CarregarFuncao(BindingSource source, int id, string descricao, out bool ok);
    }

    public interface IPresenterToViewModulo
    {
        void ValidarSucesso();
        void ValidarFalha(string mensagem);
    }

    public interface IPresenterToInteractorModulo
    {
        void Validar(Entity.Modulo entity);
    }

    public interface IInteractorToPresenterModulo
    {
        void ValidarSucesso();
        void ValidarFalha(string mensagem);
    }

    public interface IPresenterToRouterModulo
    {
        void CarregarFuncao(BindingSource source, int id, string descricao, out bool ok);
    }
}
