using VIPER.Entity;
using VIPER.Infrastructure;
using VIPER.Repository.Interface;
using System;
using System.Linq;

namespace VIPER.Repository
{
    public class ParametroUsuarioRepository : IPadraoRepository<ParametroUsuario>, IDisposable
    {
        private _VIPER_Context _db = new _VIPER_Context();
        private IRepository<ParametroUsuario> _repository;

        public ParametroUsuarioRepository(_VIPER_Context context = null)
        {
            _repository = new Repository<ParametroUsuario>(context ?? new _VIPER_Context());
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

        public string Incluir(ParametroUsuario entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(ParametroUsuario entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(ParametroUsuario entity)
        {
            string mensagem = _repository.Delete(entity.Id);

            return mensagem;
        }

        public ParametroUsuario Selecionar(int id)
        {
            return _repository.GetById(id);
        }

        public IQueryable<ParametroUsuario> SelecionarTodos()
        {
            return _repository.GetAll();
        }

        public IQueryable<ParametroUsuario> Filtrar(string condicao)
        {
            return _repository.Filter(condicao);
        }

        public IQueryable<ParametroUsuario> SelecionarPorParametro(int id)
        {
            return this.SelecionarTodos().Where(p => p.ParametroId == id);
        }

        public ParametroUsuario SelecionarPorParametroUsuario(int parametro, int usuario)
        {
            return this.SelecionarTodos().Where(p => p.ParametroId == parametro && p.UsuarioId == usuario).FirstOrDefault();
        }

        public string ValidarDados(ParametroUsuario entity)
        {
            if (entity.ParametroId == 0)
                return "Parâmetro não informado!";
            else if (entity.UsuarioId == 0)
                return "Usuário não informado!";
            else if (string.IsNullOrWhiteSpace(entity.Valor))
                return "Valor não informado!";
            else
                return "";
        }
    }
}
