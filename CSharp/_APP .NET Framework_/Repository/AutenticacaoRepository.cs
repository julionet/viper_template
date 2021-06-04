using VIPER.Entity;
using VIPER.Infrastructure;
using VIPER.Repository.Interface;
using System;
using System.Linq;

namespace VIPER.Repository
{
    public class AutenticacaoRepository : IPadraoRepository<Autenticacao>, IDisposable
    {
        private _VIPER_Context _db = new _VIPER_Context();
        private readonly IRepository<Autenticacao> _repository;

        public AutenticacaoRepository(_VIPER_Context context = null)
        {
            _repository = new Repository<Autenticacao>(context ?? new _VIPER_Context());
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

        public string Incluir(Autenticacao entity)
        {
            string mensagem = ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(Autenticacao entity)
        {
            string mensagem = ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(Autenticacao entity)
        {
            string mensagem = ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Delete(entity.Id);
            }
            return mensagem;
        }

        public Autenticacao Selecionar(int id)
        {
            return _repository.GetById(id);
        }

        public IQueryable<Autenticacao> SelecionarTodos()
        {
            return _repository.GetAll();
        }

        public IQueryable<Autenticacao> Filtrar(string condicao)
        {
            return _repository.Filter(condicao);
        }

        public string ValidarDados(Autenticacao entity)
        {
            if (string.IsNullOrWhiteSpace(entity.Usuario))
                return "Usuário não informado!";
            else if (string.IsNullOrWhiteSpace(entity.Senha))
                return "Senha não informada!";
            return "";
        }

        public string ValidarExclusao(Autenticacao entity)
        {
            return "";
        }

        public bool ValidarAutenticacao(string usuario, string senha)
        {
            return SelecionarTodos().Where(p => p.Usuario == usuario && p.Senha == senha).Count() != 0;
        }
    }
}
