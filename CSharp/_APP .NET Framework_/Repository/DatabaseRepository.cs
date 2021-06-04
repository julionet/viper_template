using VIPER.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace VIPER.Repository
{
    public class DatabaseRepository
    {
        public DateTime GetDateTimeServer()
        {
            _VIPER_Context db = new _VIPER_Context();
            return db.Database.SqlQuery<DateTime>("select getdate()").First();
        }

        public string GetSerialNumberHD()
        {
            _VIPER_Context db = new _VIPER_Context();
            if (db.Database.Connection is SqlConnection)
                return db.Database.SqlQuery<string>("declare @hd varchar(1000) " +
                                                    "create table #serialhd(data varchar(1000)) " +
                                                    " " +
                                                    "insert into #serialhd " +
                                                    "exec xp_cmdshell 'vol' " +
                                                    " " +
                                                    "select @hd = substring(data, charindex('-', data, 1) - 4, 4) + substring(data, charindex('-', data, 1) + 1, 4) " +
                                                    "from #serialhd " +
                                                    "where data like '%-%' " +
                                                    " " +
                                                    "drop table #serialhd " +
                                                    "select @hd").FirstOrDefault();
            else
                return "";
        }

        public IEnumerable<T> ExecutarSQL<T>(string sql)
        {
            try
            {
                return new _VIPER_Context().Database.SqlQuery<T>(sql);
            }
            catch
            {
                return null;
            }
        }

        public string ExecutarComandoSQL(string sql)
        {
            try
            {
                int erro = new _VIPER_Context().Database.ExecuteSqlCommand(sql);
                return "";
            }
            catch (Exception erro)
            {
                return erro.InnerException != null ? erro.InnerException.Message : erro.Message;
            }
        }
    }
}
