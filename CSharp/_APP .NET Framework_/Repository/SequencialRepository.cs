using VIPER.Infrastructure;
using System;
using System.Linq;

namespace VIPER.Repository
{
    public class SequencialRepository : IDisposable
    {
        private _VIPER_Context _db = new _VIPER_Context();

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

        public int Buscar(string nome)
        {
            var sequencial = (from q in _db.Sequencials where q.Nome == nome select q).FirstOrDefault();
            if (sequencial == null)
                return 0;

            try
            {
                sequencial.Valor += 1;
                _db.SaveChanges();
            }
            catch
            {
                return 0;
            }

            return sequencial.Valor;
        }

        public int Consultar(string nome)
        {
            var sequencial = (from q in _db.Sequencials where q.Nome == nome select q).FirstOrDefault();
            if (sequencial == null)
                return 0;

            return sequencial.Valor;
        }
    }
}
