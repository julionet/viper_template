using VIPER.Controller.App_Start;
using VIPER.DTO;
using VIPER.Entity;
using VIPER.Infrastructure;
using VIPER.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Cartsys.Service.Controllers
{
    [RoutePrefix("api/usuario")]
    [BasicAuthentication]
    public class UsuarioController : ApiController
    {
        private string _mensagem = "";

        [HttpPost]
        [Route("salvar")]
        public string Salvar(Usuario entity)
        {
            using (var _db = new _VIPER_Context())
            {
                using (var transacao = _VIPER_Transaction.CreateDbContextTransaction(_db))
                {
                    if (entity.Id == 0)
                        _mensagem = new UsuarioRepository(_db).Incluir(entity);
                    else
                        _mensagem = new UsuarioRepository(_db).Alterar(entity);

                    if (_mensagem == "")
                        transacao.Commit();
                    else
                        transacao.Rollback();
                }
            }
            return _mensagem;
        }

        [HttpPost]
        [Route("excluir")]
        public string Excluir(Usuario entity)
        {
            using (var _db = new _VIPER_Context())
            {
                using (var transacao = _VIPER_Transaction.CreateDbContextTransaction(_db))
                {
                    _mensagem = new UsuarioRepository(_db).Excluir(entity);

                    if (_mensagem == "")
                        transacao.Commit();
                    else
                        transacao.Rollback();
                }
            }
            return _mensagem;
        }

        [HttpGet]
        [Route("selecionar/{id}")]
        public Usuario Selecionar(int id)
        {
            return new UsuarioRepository().Selecionar(id);
        }

        [HttpGet]
        [Route("selecionartodos")]
        public List<Usuario> SelecionarTodos()
        {
            return new UsuarioRepository().SelecionarTodos().ToList();
        }

        [HttpGet]
        [Route("filtrar")]
        public List<UsuarioDTO> Filtrar(string condicao)
        {
            return new UsuarioRepository().FiltrarDTO(condicao).ToList();
        }

        [HttpGet]
        [Route("selecionarlogin/{login}")]
        public UsuarioDTO SelecionarLogin(string login)
        {
            return new UsuarioRepository().SelecionarDTO(login);
        }

        [HttpGet]
        [Route("selecionarnaomaster")]
        public List<Usuario> SelecionarNaoMaster()
        {
            return new UsuarioRepository().SelecionarNaoMaster().ToList();
        }

        [HttpGet]
        [Route("devealterarsenha/{usuario}")]
        public bool DeveAlterarSenha(string usuario)
        {
            return new UsuarioRepository().DeveAlterarSenha(usuario);
        }

        [HttpPost]
        [Route("validarlogin")]
        public string ValidarLogin(AutenticacaoDTO login)
        {
            return new UsuarioRepository().ValidarLogin(login.Login, login.Senha);
        }

        [HttpPost]
        [Route("alterarsenha")]
        public string AlterarSenha(LoginDTO login)
        {
            return new UsuarioRepository().AlterarSenha(login.Usuario, login.Senha, login.NovaSenha, login.Confirmacao);
        }

        [HttpGet]
        [Route("selecionarperfis/{usuario}")]
        public List<Perfil> SelecionarPerfis(int usuario)
        {
            return new UsuarioRepository().SelecionarPerfis(usuario).ToList();
        }
    }
}