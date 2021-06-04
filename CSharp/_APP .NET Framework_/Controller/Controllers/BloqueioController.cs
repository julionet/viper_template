using VIPER.Controller.App_Start;
using VIPER.Entity;
using VIPER.Infrastructure;
using VIPER.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Cartsys.Service.Controllers
{
    [RoutePrefix("api/bloqueio")]
    [BasicAuthentication]
    public class BloqueioController : ApiController
    {
        private string _mensagem = "";

        [HttpPost]
        [Route("salvar")]
        public string Salvar(Bloqueio entity)
        {
            using (var _db = new _VIPER_Context())
            {
                using (var transacao = _VIPER_Transaction.CreateDbContextTransaction(_db))
                {
                    if (entity.Id == 0)
                        _mensagem = new BloqueioRepository(_db).Incluir(entity);
                    else
                        _mensagem = new BloqueioRepository(_db).Alterar(entity);

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
        public string Excluir(Bloqueio entity)
        {
            using (var _db = new _VIPER_Context())
            {
                using (var transacao = _VIPER_Transaction.CreateDbContextTransaction(_db))
                {
                    _mensagem = new BloqueioRepository(_db).Excluir(entity);
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
        public Bloqueio Selecionar(int id)
        {
            return new BloqueioRepository().Selecionar(id);
        }

        [HttpGet]
        [Route("selecionartodos")]
        public List<Bloqueio> SelecionarTodos()
        {
            return new BloqueioRepository().SelecionarTodos().ToList();
        }

        [HttpPost]
        [Route("filtrar")]
        public List<Bloqueio> Filtrar([FromBody] string condicao)
        {
            return new BloqueioRepository().Filtrar(condicao).ToList();
        }

        [HttpGet]
        [Route("bloquearregistro/{classe}/{usuario}/{referencia}")]
        public string BloquearRegistro(string classe, int usuario, int referencia)
        {
            return new BloqueioRepository().BloquearRegistro(classe, usuario, referencia);
        }

        [HttpGet]
        [Route("excluirbloqueio/{classe}/{referencia}")]
        public void ExcluirBloqueio(string classe, int referencia)
        {
            new BloqueioRepository().ExcluirBloqueio(classe, referencia);
        }

        [HttpGet]
        [Route("excluirbloqueiousuario/{classe}/{usuario}/{referencia}")]
        public void ExcluirBloqueioUsuario(string classe, int usuario, int referencia)
        {
            new BloqueioRepository().ExcluirBloqueio(classe, usuario, referencia);
        }

        [HttpGet]
        [Route("atualizarbloqueio/{classe}/{referencia}")]
        public void AtualizarBloqueio(string classe, int referencia)
        {
            new BloqueioRepository().AtualizarBloqueio(classe, referencia);
        }

        [HttpGet]
        [Route("consultarbloqueio/{classe}/{referencia}")]
        public string ConsultarBloqueio(string classe, int referencia)
        {
            return new BloqueioRepository().ConsultarBloqueio(classe, referencia);
        }
    }
}