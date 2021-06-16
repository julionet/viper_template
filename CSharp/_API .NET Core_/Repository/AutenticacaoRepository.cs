//
//  AutenticacaoRepository.cs
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

using VIPER.Database;
using System;
using System.Linq;

namespace VIPER.Repository
{
    public class AutenticacaoRepository : IDisposable
    {
        private _VIPER_Context _db = new _VIPER_Context();

        public AutenticacaoRepository()
        {

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

        public bool Check(string login, string senha)
        {
            return (from q in _db.Autenticacaos where q.Usuario == login && q.Senha == senha select q).Count() != 0;
        }
    }
}
