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
    [RoutePrefix("api/perfil")]
    [BasicAuthentication]
    public class PerfilController : ApiController
    {
        private string _mensagem = "";

        [HttpPost]
        [Route("salvar")]
        public string Salvar(PerfilPerfilFuncaoDTO entity)
        {
            using (var _db = new _VIPER_Context())
            {
                using (var transacao = _VIPER_Transaction.CreateDbContextTransaction(_db))
                {
                    if (entity.Perfil.Id == 0)
                        _mensagem = new PerfilRepository(_db).Incluir(entity.Perfil);
                    else
                        _mensagem = new PerfilRepository(_db).Alterar(entity.Perfil);

                    if (_mensagem == "")
                    {
                        foreach (var item in entity.PerfilFuncoes)
                        {
                            var perfilfuncao = new PerfilFuncao();
                            perfilfuncao.Id = item.Id;
                            perfilfuncao.PerfilId = entity.Perfil.Id;
                            perfilfuncao.FuncaoId = item.FuncaoId;
                            perfilfuncao.PermiteIncluir = item.PermiteIncluir;
                            perfilfuncao.PermiteAlterar = item.PermiteAlterar;
                            perfilfuncao.PermiteExcluir = item.PermiteExcluir;
                            if (perfilfuncao.Id == 0)
                            {
                                _mensagem = new PerfilFuncaoRepository(_db).Incluir(perfilfuncao);
                                if (_mensagem != "")
                                {
                                    transacao.Rollback();
                                    return _mensagem;
                                }
                            }
                            else
                            {
                                _mensagem = new PerfilFuncaoRepository(_db).Alterar(perfilfuncao);
                                if (_mensagem != "")
                                {
                                    transacao.Rollback();
                                    return _mensagem;
                                }
                            }
                        }

                        foreach (var pf in new PerfilFuncaoRepository().SelecionarPorPerfil(entity.Perfil.Id, entity.SistemaId))
                        {
                            var bExclui = true;
                            var perfilfuncao = new PerfilFuncaoRepository().Selecionar(pf.Id);
                            if (entity.PerfilFuncoes.Where(p => p.FuncaoId == perfilfuncao.FuncaoId).Count() > 0)
                                bExclui = false;
                            if (bExclui)
                            {
                                _mensagem = new PerfilFuncaoRepository(_db).Excluir(perfilfuncao);
                                if (_mensagem != "")
                                {
                                    transacao.Rollback();
                                    return _mensagem;
                                }
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
        public string Excluir(Perfil entity)
        {
            using (var _db = new _VIPER_Context())
            {
                using (var transacao = _VIPER_Transaction.CreateDbContextTransaction(_db))
                {
                    _mensagem = new PerfilRepository(_db).Excluir(entity);

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
        public Perfil Selecionar(int id)
        {
            return new PerfilRepository().Selecionar(id);
        }

        [HttpGet]
        [Route("selecionartodos")]
        public List<Perfil> SelecionarTodos()
        {
            return new PerfilRepository().SelecionarTodos().ToList();
        }

        [HttpGet]
        [Route("filtrar")]
        public List<Perfil> Filtrar(string condicao)
        {
            return new PerfilRepository().Filtrar(condicao).ToList();
        }

        [HttpGet]
        [Route("selecionarporperfil/{usuario}/{sistema}")]
        public List<PerfilFuncaoDTO> SelecionarPorPerfil(int usuario, int sistema)
        {
            return new PerfilFuncaoRepository().SelecionarPorPerfil(usuario, sistema).ToList();
        }
    }
}