using DapperExtensions.Sql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Text;

namespace CommunitiApp.İnfrastructure
{
    public class DAL
    {
        public static MySqlConnection GetConnection()
        {
            MySqlConnection mySqlConnection = new MySqlConnection();
            DapperExtensions.DapperExtensions.SqlDialect = new MySqlDialect();
            mySqlConnection.ConnectionString = "Server=94.101.95.50;uid=user028312_185;password=123456Aa!;database=db028312_185;sslmode=none;";
            return mySqlConnection;

        }
    }
}