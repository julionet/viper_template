using VIPER.Controller.App_Start;
using VIPER.DTO;
using VIPER.Entity;
using VIPER.Infrastructure;
using VIPER.Repository;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;

namespace Cartsys.Service.Controllers
{
    [RoutePrefix("api/usuariofuncao")]
    [BasicAuthentication]
    public class UsuarioFuncaoController : ApiController
    {
        private string _mensagem = "";

        [HttpPost]
        [Route("salvar")]
        public string Salvar(UsuarioUsuarioFuncaoDTO entity)
        {
            using (var _db = new _VIPER_Context())
            {
                using (var transacao = _VIPER_Transaction.CreateDbContextTransaction(_db))
                {
                    _mensagem = new UsuarioRepository(_db).Alterar(entity.Usuario);

                    foreach (UsuarioFuncao item in entity.UsuarioFuncoes)
                    {
                        var usuariofuncao = new UsuarioFuncao();
                        usuariofuncao.Id = item.Id;
                        usuariofuncao.UsuarioId = entity.Usuario.Id;
                        usuariofuncao.FuncaoId = item.FuncaoId;
                        usuariofuncao.PermiteIncluir = item.PermiteIncluir;
                        usuariofuncao.PermiteAlterar = item.PermiteAlterar;
                        usuariofuncao.PermiteExcluir = item.PermiteExcluir;
                        if (new UsuarioFuncaoRepository().Selecionar(usuariofuncao.UsuarioId, usuariofuncao.FuncaoId) == null)
                        {
                            _mensagem = new UsuarioFuncaoRepository(_db).Incluir(usuariofuncao);
                            if (_mensagem != "")
                            {
                                transacao.Rollback();
                                return _mensagem;
                            }
                        }
                        else
                        {
                            _mensagem = new UsuarioFuncaoRepository(_db).Alterar(usuariofuncao);
                            if (_mensagem != "")
                            {
                                transacao.Rollback();
                                return _mensagem;
                            }
                        }
                    }

                    foreach (var uf in new UsuarioFuncaoRepository().SelecionarPorUsuario(entity.Usuario.Id, entity.SistemaId))
                    {
                        bool bExclui = true;
                        var usuariofuncao = new UsuarioFuncaoRepository().Selecionar(uf.Id);
                        if (entity.UsuarioFuncoes.Where(p => p.FuncaoId == usuariofuncao.FuncaoId).Count() > 0)
                            bExclui = false;
                        if (bExclui)
                        {
                            _mensagem = new UsuarioFuncaoRepository(_db).Excluir(usuariofuncao);
                            if (_mensagem != "")
                            {
                                transacao.Rollback();
                                return _mensagem;
                            }
                        }
                    }

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
        public string Excluir(UsuarioFuncao entity)
        {
            using (var _db = new _VIPER_Context())
            {
                using (var transacao = _VIPER_Transaction.CreateDbContextTransaction(_db))
                {
                    _mensagem = new UsuarioFuncaoRepository(_db).Excluir(entity);

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
        public UsuarioFuncao Selecionar(int id)
        {
            return new UsuarioFuncaoRepository().Selecionar(id);
        }

        [HttpGet]
        [Route("selecionarfuncao/{usuario}/{funcao}")]
        public UsuarioFuncao SelecionarFuncao(int usuario, int funcao)
        {
            return new UsuarioFuncaoRepository().Selecionar(usuario, funcao);
        }

        [HttpGet]
        [Route("selecionartodos")]
        public List<UsuarioFuncao> SelecionarTodos()
        {
            return new UsuarioFuncaoRepository().SelecionarTodos().ToList();
        }

        [HttpGet]
        [Route("filtrar")]
        public List<UsuarioFuncao> Filtrar(string condicao)
        {
            return new UsuarioFuncaoRepository().Filtrar(condicao).ToList();
        }

        [HttpGet]
        [Route("selecionarporusuario/{usuario}/{sistema}")]
        public List<UsuarioFuncaoDTO> SelecionarPorUsuario(int usuario, int sistema)
        {
            return new UsuarioFuncaoRepository().SelecionarPorUsuario(usuario, sistema).ToList();
        }

        [HttpGet]
        [Route("selecionaracessoporusuariomodulo/{usuario}/{modulo}/{sistema}")]
        public List<UsuarioFuncaoDTO> SelecionarAcessoPorUsuarioModulo(int usuario, int modulo, int sistema)
        {
            return new UsuarioFuncaoRepository().SelecionarAcessoPorUsuarioModulo(usuario, modulo, sistema).ToList();
        }
    }
}