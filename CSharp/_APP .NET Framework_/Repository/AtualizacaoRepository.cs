using VIPER.Entity;
using VIPER.Infrastructure;
using VIPER.Repository.Interface;
using System;
using System.Linq;

namespace VIPER.Repository
{
    public class AtualizacaoRepository : IPadraoRepository<Atualizacao>, IDisposable
    {
        private _VIPER_Context _db = new _VIPER_Context();
        private IRepository<Atualizacao> _repository;

        public AtualizacaoRepository(_VIPER_Context context = null)
        {
            _repository = new Repository<Atualizacao>(context ?? new _VIPER_Context());
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public string Incluir(Atualizacao entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(Atualizacao entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(Atualizacao entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Delete(entity.Id);
            }
            return mensagem;
        }

        public Atualizacao Selecionar(int id)
        {
            return _repository.GetById(id);
        }

        public IQueryable<Atualizacao> SelecionarTodos()
        {
            return _repository.GetAll();
        }

        public IQueryable<Atualizacao> Filtrar(string condicao)
        {
            return _repository.Filter(condicao);
        }

        public string ValidarDados(Atualizacao entity)
        {
            return "";
        }

        public string ValidarExclusao(Atualizacao entity)
        {
            return "";
        }

        public bool ExisteAtualizacao(int numero)
        {
            return SelecionarTodos().Where(p => p.Numero == numero).Count() != 0;
        }

        public int Contar()
        {
            return SelecionarTodos().Count();
        }

        public int ContarPendente()
        {
            return SelecionarTodosPendente().Count();
        }

        public IQueryable<Atualizacao> SelecionarTodosPendente()
        {
            return SelecionarTodos().Where(p => (p.Banco == "S" || p.Banco == "T" || p.Banco == "Q") && (p.Status == "P" || p.Status == "E"));
        }

        public string AtualizarVersao(Atualizacao atualizacao)
        {
            string mensagem = new DatabaseRepository().ExecutarComandoSQL(atualizacao.Sql);
            if (mensagem == "")
            {
                atualizacao.Status = "O";
                atualizacao.Mensagem = "Atualização realizada com sucesso!";
            }
            else
            {
                atualizacao.Status = "E";
                atualizacao.Mensagem = mensagem;
            }
            Alterar(atualizacao);
            return mensagem;
        }

        public string FinalizarAtualizacoes()
        {
            string mensagem = "";
            foreach (Atualizacao atualizacao in SelecionarTodosPendente().ToArray())
            {
                atualizacao.Status = "O";
                atualizacao.Mensagem = "Não necessário executar atualização";
                mensagem = Alterar(atualizacao);
                if (mensagem != "")
                    break;
            }
            return mensagem;
        }
    }
}
