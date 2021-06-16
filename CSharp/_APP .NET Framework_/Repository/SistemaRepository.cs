using VIPER.Entity;
using VIPER.Infrastructure;
using VIPER.Repository.Interface;
using System;
using System.Linq;

namespace VIPER.Repository
{
    public class SistemaRepository : IPadraoRepository<Sistema>, IDisposable
    {
        private _VIPER_Context _db = new _VIPER_Context();
        private IRepository<Sistema> _repository;

        public SistemaRepository(_VIPER_Context context = null)
        {
            _repository = new Repository<Sistema>(context ?? new _VIPER_Context());
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

        public string Incluir(Sistema entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(Sistema entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(Sistema entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = this.ExcluirCascata(entity);
                if (mensagem == "")
                    mensagem = _repository.Delete(entity.Id);
            }
            return mensagem;
        }

        public Sistema Selecionar(int id)
        {
            return _repository.GetById(id);
        }

        public IQueryable<Sistema> SelecionarTodos()
        {
            return _repository.GetAll();
        }

        public IQueryable<Sistema> Filtrar(string condicao)
        {
            return _repository.Filter(condicao);
        }

        public string ExcluirCascata(Sistema entity)
        {
            var mensagem = "";
            var repository = new ModuloRepository(_repository.GetContext() as _VIPER_Context);
            foreach (var registro in repository.SelecionarPorSistema(entity.Id).ToArray())
            {
                mensagem = repository.Excluir(registro);
                if (mensagem != "")
                    break;
            }
            return mensagem;
        }

        public IQueryable<Sistema> SelecionarAtivos()
        {
            return SelecionarTodos().Where(p => p.Ativo && !p.Gerenciador);
        }

        public IQueryable<Sistema> SelecionarAtivosPorTipo(string tipo)
        {
            return SelecionarAtivos().Where(p => p.Tipo == tipo);
        }

        public string ValidarDados(Sistema entity)
        {
            if (string.IsNullOrWhiteSpace(entity.Descricao))
                return "Descrição não informada!";
            else if (string.IsNullOrWhiteSpace(entity.Codigo))
                return "Código não informado!";
            else if (this.SelecionarTodos().Where(p => p.Codigo == entity.Codigo && p.Id != entity.Id).Count() != 0)
                return "Código é uma informação exclusiva!";
            else if (string.IsNullOrWhiteSpace(entity.Tipo))
                return "Tipo não informado!";
            else if (string.IsNullOrWhiteSpace(entity.Interface))
                return "Interface não informada!";
            else if (entity.Tipo == "M" && entity.Linha == 0)
                return "Número de linhas não informado!";
            else if (entity.Tipo == "M" && entity.Tamanho == 0)
                return "Tamanho não informado!";
            else if (entity.QuantidadeModulo == 0)
                return "Nenhum módulo associado ao sistema!";
            else
                return "";
        }

        public string ValidarExclusao(Sistema entity)
        {
            if (new UsuarioFuncaoRepository().SelecionarTodos().Where(p => p.Funcao.Modulo.SistemaId == entity.Id).Count() != 0)
                return "Não é permitido excluir uma função associada a um ou mais usuários!";
            else if (new PerfilFuncaoRepository().SelecionarTodos().Where(p => p.Funcao.Modulo.SistemaId == entity.Id).Count() != 0)
                return "Não é permitido excluir uma função associada a um ou mais perfis!";
            else
                return "";
        }
    }
}
