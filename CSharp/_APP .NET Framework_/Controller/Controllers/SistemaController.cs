using VIPER.Controller.App_Start;
using VIPER.DTO;
using VIPER.Entity;
using VIPER.Infrastructure;
using VIPER.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace VIPER.Controller.Controllers
{
    [RoutePrefix("api/sistema")]
    [BasicAuthentication]
    public class SistemaController : ApiController
    {
        private string _mensagem = "";

        [HttpPost]
        [Route("salvar")]
        public string Salvar(SistemaModuloFuncaoDTO entity)
        {
            using (var _db = new _VIPER_Context())
            {
                using (var transacao = _VIPER_Transaction.CreateDbContextTransaction(_db))
                {
                    if (entity.Sistema.Id == 0)
                        _mensagem = new SistemaRepository(_db).Incluir(entity.Sistema);
                    else
                        _mensagem = new SistemaRepository(_db).Alterar(entity.Sistema);

                    if (_mensagem == "")
                    {
                        foreach (Modulo itemModulo in entity.Modulos)
                        {
                            if (itemModulo.Flag == "I")
                            {
                                int iModulo = itemModulo.Id;
                                itemModulo.SistemaId = entity.Sistema.Id;
                                _mensagem = new ModuloRepository(_db).Incluir(itemModulo);

                                if (string.IsNullOrWhiteSpace(_mensagem))
                                {
                                    foreach (Funcao itemFuncao in entity.Funcoes.Where(p => p.ModuloId == iModulo))
                                    {
                                        itemFuncao.ModuloId = itemModulo.Id;
                                        _mensagem = new FuncaoRepository(_db).Incluir(itemFuncao);
                                    }
                                }
                            }
                            else if (itemModulo.Flag == "A")
                            {
                                _mensagem = new ModuloRepository(_db).Alterar(itemModulo);

                                if (string.IsNullOrWhiteSpace(_mensagem))
                                {
                                    foreach (Funcao itemFuncao in entity.Funcoes.Where(p => p.ModuloId == itemModulo.Id))
                                    {
                                        if (itemFuncao.Flag == "I")
                                        {
                                            itemFuncao.ModuloId = itemModulo.Id;
                                            _mensagem = new FuncaoRepository(_db).Incluir(itemFuncao);
                                        }
                                        else if (itemFuncao.Flag == "A")
                                            _mensagem = new FuncaoRepository(_db).Alterar(itemFuncao);
                                        else if (itemFuncao.Flag == "E")
                                            _mensagem = new FuncaoRepository(_db).Excluir(itemFuncao);
                                    }
                                }
                            }
                            else if (itemModulo.Flag == "E")
                                _mensagem = new ModuloRepository(_db).Excluir(itemModulo);
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
        public string Excluir(Sistema entity)
        {
            using (var _db = new _VIPER_Context())
            {
                using (var transacao = _VIPER_Transaction.CreateDbContextTransaction(_db))
                {
                    _mensagem = new SistemaRepository(_db).Excluir(entity);

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
        public Sistema Selecionar(int id)
        {
            return new SistemaRepository().Selecionar(id);
        }

        [HttpGet]
        [Route("selecionartodos")]
        public List<Sistema> SelecionarTodos()
        {
            return new SistemaRepository().SelecionarTodos().ToList();
        }

        [HttpGet]
        [Route("selecionarativos")]
        public List<Sistema> SelecionarAtivos()
        {
            return new SistemaRepository().SelecionarAtivos().ToList();
        }

        [HttpGet]
        [Route("selecionarativosportipo/{tipo}")]
        public List<Sistema> SelecionarAtivosPorTipo(string tipo)
        {
            return new SistemaRepository().SelecionarAtivosPorTipo(tipo).ToList();
        }

        [HttpGet]
        [Route("filtrar")]
        public List<Sistema> Filtrar(string condicao)
        {
            return new SistemaRepository().Filtrar(condicao).ToList();
        }
    }
}