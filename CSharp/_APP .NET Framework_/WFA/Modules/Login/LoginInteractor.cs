using VIPER.DTO;
using VIPER.Modules.Login.Interfaces;
using VIPER.Service;
using System.Linq;

namespace VIPER.Modules.Login.Interactors
{
    public class LoginInteractor : IPresenterToInteractorLogin
    {
        public IInteractorToPresenterLogin presenter;

        public void DeveAlterarSenha(string login)
        {
            var retorno = Servicos.usuarioService.DeveAlterarSenha(Global.Instance.UsuarioLogado.Login);
            if (retorno)
                presenter.DeveAlterarSenhaSucesso();
            else
                presenter.DeveAlterarSenhaFalha();
        }

        public void SelecionarSistemas()
        {
            var sistemas = Global.Instance.Sistemas.Where(p => p.Ativo && !p.Gerenciador && p.Tipo == "D").OrderBy(p => p.Descricao).ToList();
            if (sistemas.Count == 0)
                presenter.SelecionarSistemasFalha("Não há sistemas cadastrados!");
            else
                presenter.SelecionarSistemasSucesso(sistemas);
        }

        public void ValidarLogin(AutenticacaoDTO autenticacao)
        {
            var mensagem = Servicos.usuarioService.ValidarLogin(autenticacao);
            if (mensagem == "")
                presenter.ValidarLoginSucesso(autenticacao.Login);
            else
                presenter.ValidarLoginFalha(mensagem);
        }
    }
}
