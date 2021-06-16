//
//  IAuthenticationService.cs
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

using System.Threading.Tasks;
using VIPER.Repository;

namespace VIPER.Controller.Helpers
{
    public interface IAuthenticationService
    {
        Task<bool> Authenticate(string username, string password);
    }

    internal class AuthenticationService : IAuthenticationService
    {
        public async Task<bool> Authenticate(string username, string password)
        {
            var success = await Task.Run(() => new AutenticacaoRepository().Check(username, password));
            return success;
        }
    }
}
