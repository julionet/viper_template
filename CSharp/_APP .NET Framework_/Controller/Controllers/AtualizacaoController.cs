using VIPER.Controller.App_Start;
using VIPER.Entity;
using VIPER.Infrastructure;
using VIPER.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace VIPER.Controller.Controllers
{
    [RoutePrefix("api/atualizacao")]
    [BasicAuthentication]
    public class AtualizacaoController : ApiController
    {
        private string _mensagem = "";

        [HttpPost]
        [Route("salvar")]
        public string Salvar(Atualizacao entity)
        {
            using (var _db = new _VIPER_Context())
            {
                using (var transacao = _VIPER_Transaction.CreateDbContextTransaction(_db))
                {
                    if (entity.Id == 0)
                        _mensagem = new AtualizacaoRepository(_db).Incluir(entity);
                    else
                        _mensagem = new AtualizacaoRepository(_db).Alterar(entity);

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
        public string Excluir(Atualizacao entity)
        {
            using (var _db = new _VIPER_Context())
            {
                using (var transacao = _VIPER_Transaction.CreateDbContextTransaction(_db))
                {
                    _mensagem = new AtualizacaoRepository(_db).Excluir(entity);
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
        public Atualizacao Selecionar(int id)
        {
            return new AtualizacaoRepository().Selecionar(id);
        }

        [HttpGet]
        [Route("selecionartodos")]
        public List<Atualizacao> SelecionarTodos()
        {
            return new AtualizacaoRepository().SelecionarTodos().ToList();
        }

        [HttpGet]
        [Route("filtrar")]
        public List<Atualizacao> Filtrar(string condicao)
        {
            return new AtualizacaoRepository().Filtrar(condicao).ToList();
        }

        [HttpGet]
        [Route("contar")]
        public int Contar()
        {
            return new AtualizacaoRepository().Contar();
        }

        [HttpGet]
        [Route("contarpendente")]
        public int ContarPendente()
        {
            return new AtualizacaoRepository().ContarPendente();
        }

        [HttpGet]
        [Route("existeatualizacao")]
        public bool ExisteAtualizacao(int numero)
        {
            return new AtualizacaoRepository().ExisteAtualizacao(numero);
        }

        [HttpPost]
        [Route("importar")]
        public string Importar(Atualizacao[] entity)
        {
            using (var _db = new _VIPER_Context())
            {
                using (var transacao = _VIPER_Transaction.CreateDbContextTransaction(_db))
                {
                    var repository = new AtualizacaoRepository(_db);
                    foreach (Atualizacao atualizacao in entity)
                    {
                        if (repository.SelecionarTodos().Where(p => p.Id == atualizacao.Id).Count() == 0)
                            _mensagem = repository.Incluir(atualizacao);

                        if (_mensagem != "")
                            break;
                    }
                    repository.Dispose();

                    if (_mensagem == "")
                        transacao.Commit();
                    else
                        transacao.Rollback();
                }
            }
            return _mensagem;
        }

        [HttpGet]
        [Route("selecionartodospendente")]
        public List<Atualizacao> SelecionarTodosPendente()
        {
            return new AtualizacaoRepository().SelecionarTodosPendente().ToList();
        }

        [HttpPost]
        [Route("atualizarversao")]
        public string AtualizarVersao(Atualizacao atualizacao)
        {
            return new AtualizacaoRepository().AtualizarVersao(atualizacao);
        }

        [HttpGet]
        [Route("finalizaratualizacoes")]
        public string FinalizarAtualizacoes()
        {
            using (var _db = new _VIPER_Context())
            {
                using (var transacao = _VIPER_Transaction.CreateDbContextTransaction(_db))
                {
                    _mensagem = new AtualizacaoRepository(_db).FinalizarAtualizacoes();
                    if (_mensagem == "")
                        transacao.Commit();
                    else
                        transacao.Rollback();
                }
            }
            return _mensagem;
        }
    }
}