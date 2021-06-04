using VIPER.Controller.App_Start;
using VIPER.Entity;
using VIPER.Infrastructure;
using VIPER.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Cartsys.Service.Controllers
{
    [RoutePrefix("api/parametro")]
    [BasicAuthentication]
    public class ParametroController : ApiController
    {
        private string _mensagem = "";

        [HttpPost]
        [Route("salvar")]
        public string Salvar(Parametro entity)
        {
            using (var _db = new _VIPER_Context())
            {
                using (var transacao = _VIPER_Transaction.CreateDbContextTransaction(_db))
                {
                    if (entity.Id == 0)
                        _mensagem = new ParametroRepository(_db).Incluir(entity);
                    else
                        _mensagem = new ParametroRepository(_db).Alterar(entity);

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
        public string Excluir(Parametro entity)
        {
            using (var _db = new _VIPER_Context())
            {
                using (var transacao = _VIPER_Transaction.CreateDbContextTransaction(_db))
                {
                    _mensagem = new ParametroRepository(_db).Excluir(entity);

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
        public Parametro Selecionar(int id)
        {
            return new ParametroRepository().Selecionar(id);
        }

        [HttpGet]
        [Route("selecionartodos")]
        public List<Parametro> SelecionarTodos()
        {
            return new ParametroRepository().SelecionarTodos().ToList();
        }

        [HttpGet]
        [Route("filtrar")]
        public List<Parametro> Filtrar(string condicao)
        {
            return new ParametroRepository().Filtrar(condicao).ToList();
        }

        [HttpGet]
        [Route("selecionarvalorparametro/{codigo}/{usuario}")]
        public string SelecionarValorParametro(string codigo, int usuario)
        {
            return new ParametroRepository().SelecionarValorParametro(codigo, usuario);
        }

        [HttpGet]
        [Route("selecionarporcategoria/{categoria}")]
        public List<Parametro> SelecionarPorCategoria(string categoria)
        {
            return new ParametroRepository().SelecionarPorCategoria(categoria).ToList();
        }

        [HttpPost]
        [Route("gravarparametro")]
        public string GravarParametro(Parametro[] parametros)
        {
            using (var _db = new _VIPER_Context())
            {
                using (var transacao = _VIPER_Transaction.CreateDbContextTransaction(_db))
                {
                    foreach (Parametro item in parametros)
                    {
                        Parametro parametro = new ParametroRepository().SelecionarPorCodigo(item.Codigo);
                        if (parametro != null)
                        {
                            parametro.ValorPersonalizado = string.IsNullOrWhiteSpace(item.ValorPersonalizado) ? null : item.ValorPersonalizado;
                            _mensagem = new ParametroRepository(_db).Alterar(parametro);
                            if (_mensagem != "")
                            {
                                transacao.Rollback();
                                return _mensagem;
                            }
                        }
                    }
                    transacao.Commit();
                }
            }
            return _mensagem;
        }
    }
}