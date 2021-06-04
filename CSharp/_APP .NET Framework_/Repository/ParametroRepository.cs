using VIPER.Entity;
using VIPER.Infrastructure;
using VIPER.Repository.Interface;
using System;
using System.Linq;

namespace VIPER.Repository
{
    public class ParametroRepository : IPadraoRepository<Parametro>, IDisposable
    {
        private _VIPER_Context _db = new _VIPER_Context();
        private IRepository<Parametro> _repository;

        public ParametroRepository(_VIPER_Context context = null)
        {
            _repository = new Repository<Parametro>(context ?? new _VIPER_Context());
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

        public string Incluir(Parametro entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(Parametro entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(Parametro entity)
        {
            string mensagem = "";
            mensagem = this.ExcluirCascata(entity);
            if (mensagem == "")
                mensagem = _repository.Delete(entity.Id);
            return mensagem;
        }

        public Parametro Selecionar(int id)
        {
            return _repository.GetById(id);
        }

        public IQueryable<Parametro> SelecionarTodos()
        {
            return _repository.GetAll();
        }

        public IQueryable<Parametro> Filtrar(string condicao)
        {
            return _repository.Filter(condicao);
        }

        public string ExcluirCascata(Parametro entity)
        {
            string mensagem = "";
            foreach (ParametroUsuario registro in new ParametroUsuarioRepository().SelecionarPorParametro(entity.Id).ToList())
                mensagem = new ParametroUsuarioRepository().Excluir(registro);
            return mensagem;
        }

        public Parametro SelecionarPorCodigo(string codigo)
        {
            return _repository.GetAll().Where(p => p.Codigo == codigo).FirstOrDefault();
        }

        public string SelecionarValorParametro(string codigo, int usuario = 0)
        {
            var sParametro = "";

            var parametro = this.SelecionarPorCodigo(codigo);
            if (parametro != null)
            {
                if (usuario != 0)
                {
                    var dados = new ParametroUsuarioRepository().SelecionarPorParametroUsuario(parametro.Id, usuario);
                    sParametro = dados != null ? dados.Valor : "";
                }

                if (string.IsNullOrWhiteSpace(sParametro))
                    sParametro = (!string.IsNullOrWhiteSpace(parametro.ValorPersonalizado)) ? parametro.ValorPersonalizado : parametro.ValorPadrao;
            }
            return sParametro;
        }

        public IQueryable<Parametro> SelecionarPorCategoria(string categoria)
        {
            return _repository.GetAll().Where(p => p.Categoria == categoria);
        }

        public string ValidarDados(Parametro entity)
        {
            if (string.IsNullOrWhiteSpace(entity.Codigo))
                return "Código não informado!";
            else if (string.IsNullOrWhiteSpace(entity.Descricao))
                return "Descrição não informada!";
            else if (string.IsNullOrWhiteSpace(entity.Descricao))
                return "Tipo não informado!";
            else if (string.IsNullOrWhiteSpace(entity.Categoria))
                return "Categoria não informada!";
            else
                return "";
        }
    }
}
