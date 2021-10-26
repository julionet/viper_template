using NAMESPACE.Modules.__MODULENAME__.Interfaces;
using NAMESPACE.Service;
using System.Linq;

namespace NAMESPACE.Modules.__MODULENAME__.Interactors
{
    public class VIPERInteractor : IPresenterToInteractorVIPER
    {
        public IInteractorToPresenterVIPER presenter;

        public void Excluir(Entity.VIPER entity)
        {
            var mensagem = Servicos.VIPERService.Excluir(entity);
            if (mensagem != "")
                presenter.ExcluirFalha(mensagem);
            else
                presenter.ExcluirSucesso();
        }

        public void Gravar(Entity.VIPER entity)
        {
            var mensagem = Servicos.VIPERService.Salvar(entity);
            if (mensagem != "")
                presenter.GravarFalha(mensagem);
            else
                presenter.GravarSucesso();
        }

        public void ObterDadosPrincipal(string condicao)
        {
            var dados = Servicos.VIPERService.Filtrar(condicao);
            if (dados.Count != 0)
                presenter.ObterDadosPrincipalSucesso(dados);
            else
                presenter.ObterDadosPrincipalFalha();
        }
		
		public void SelecionarAcessoPorUsuario(int usuario, int funcao, int modulo, int sistema)
        {
            var acesso = Servicos.usuarioFuncaoService.SelecionarAcessoPorUsuarioModulo(usuario, modulo, sistema).Where(p => p.FuncaoId == funcao).FirstOrDefault();
            if (acesso != null)
                presenter.SelecionarAcessoPorUsuarioSucesso(acesso);
        }
    }
}
