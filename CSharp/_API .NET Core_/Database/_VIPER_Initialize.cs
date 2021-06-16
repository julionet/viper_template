//
//  _VIPER_Initialize.cs
//  __APPNAME__
//
//  Created by __USERNAME__ on __DATETIME__.
//  Copyright © __YEAR__ __ORGANIZATIONNAME__. All rights reserved.
//

using VIPER.Entity;

namespace VIPER.Database
{
    public class _VIPER_Initialize
    {
        public static void Seed(_VIPER_Context context)
        {
            if (context.Autenticacaos.Local.Count == 0)
            {
                context.Autenticacaos.Add(new Autenticacao { Usuario = "71e44bd2-bf41-4832-89c0-178b46ba7483", Senha = "2f750282315b57ebbd2866cb888358898645e752" });
                context.SaveChanges();
            }
        }
    }
}
