using VIPER.DTO;
using VIPER.Entity;
using VIPER.Infrastructure;
using VIPER.Repository.Interface;
using System;
using System.Linq;

namespace VIPER.Repository
{
    public class PerfilFuncaoRepository : IPadraoRepository<PerfilFuncao>, IDisposable
    {
        private _VIPER_Context _db = new _VIPER_Context();
        private IRepository<PerfilFuncao> _repository;

        public PerfilFuncaoRepository(_VIPER_Context context = null)
        {
            _repository = new Repository<PerfilFuncao>(context ?? new _VIPER_Context());
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

        public string Incluir(PerfilFuncao entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                entity.Id = 0;
                mensagem = _repository.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(PerfilFuncao entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(PerfilFuncao entity)
        {
            string mensagem = _repository.Delete(entity.Id);

            return mensagem;
        }

        public PerfilFuncao Selecionar(int id)
        {
            return _repository.GetById(id);
        }

        public IQueryable<PerfilFuncao> SelecionarTodos()
        {
            return _repository.GetAll();
        }

        public IQueryable<PerfilFuncao> Filtrar(string condicao)
        {
            return _repository.Filter(condicao);
        }

        public PerfilFuncao Selecionar(int perfil, int funcao)
        {
            return SelecionarTodos().Where(p => p.PerfilId == perfil && p.FuncaoId == funcao).FirstOrDefault();
        }

        public IQueryable<PerfilFuncao> SelecionarPorPerfil(int id)
        {
            return _repository.GetAll().Where(p => p.PerfilId == id);
        }

        public IQueryable<PerfilFuncaoDTO> SelecionarPorPerfil(int perfil, int sistema)
        {
            return (from q in _db.PerfilFuncaos
                    join f in _db.Funcaos on q.FuncaoId equals f.Id
                    join m in _db.Modulos on f.ModuloId equals m.Id
                    where q.PerfilId == perfil && m.SistemaId == sistema
                    select new PerfilFuncaoDTO
                    {
                        FuncaoDescricao = f.Descricao,
                        FuncaoId = q.FuncaoId,
                        FuncaoManutencao = f.Manutencao,
                        Id = q.Id,
                        ModuloDescricao = m.Descricao,
                        ModuloId = f.ModuloId,
                        PermiteAlterar = q.PermiteAlterar,
                        PermiteExcluir = q.PermiteExcluir,
                        PermiteIncluir = q.PermiteIncluir,
                        PerfilId = q.PerfilId,
                        Selecionado = true
                    });
        }

        public string ValidarDados(PerfilFuncao entity)
        {
            if (entity.PerfilId == 0)
                return "Perfil não informado!";
            else if (entity.FuncaoId == 0)
                return "Funão não informada!";
            else
                return "";
        }
    }
}
