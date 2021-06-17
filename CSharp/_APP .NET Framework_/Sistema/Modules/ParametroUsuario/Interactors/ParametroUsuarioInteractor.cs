using VIPER.Modules.ParametroUsuario.Interfaces;
using VIPER.Service;
using System.Linq;

namespace VIPER.Modules.ParametroUsuario.Interactors
{
    public class ParametroUsuarioInteractor : IPresenterToInteractorParametroUsuario
    {
        public IInteractorToPresenterParametroUsuario presenter;

        public void Excluir(Entity.ParametroUsuario entity)
        {
            var mensagem = Servicos.parametroUsuarioService.Excluir(entity);
            if (mensagem != "")
                presenter.ExcluirFalha(mensagem);
            else
                presenter.ExcluirSucesso();
        }

        public void ExecutarSQL(string sql)
        {
            var dados = Servicos.databaseService.ExecutarSQL(sql);
            if (dados.Count != 0)
                presenter.ExecutarSQLSucesso(dados);
            else
                presenter.ExecutarSQLFalha();
        }

        public void Gravar(Entity.ParametroUsuario entity)
        {
            var mensagem = Servicos.parametroUsuarioService.Salvar(entity);
            if (mensagem != "")
                presenter.GravarFalha(mensagem);
            else
                presenter.GravarSucesso();
        }

        public void ObterDadosPrincipal(int parametro)
        {
            var dados = Servicos.parametroUsuarioService.SelecionarPorParametro(parametro);
            if (dados.Count != 0)
                presenter.ObterDadosPrincipalSucesso(dados);
            else
                presenter.ObterDadosPrincipalFalha();
        }

        public void SelecionarUsuarios()
        {
            var usuarios = Servicos.usuarioService.SelecionarTodos().OrderBy(p => p.Login).ToList();
            if (usuarios.Count != 0)
                presenter.SelecionarUsuariosSucesso(usuarios);
            else
                presenter.SelecionarUsuarioFalha();
        }
    }
}
