using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace C__Learning.Class
{
    internal class ConnectionManage
    {
        private static string connectionsring = ("server=192.168.1.184; database=mydatabase; integrated security=true");
        private static SqlConnection connectionSQL;

        public static SqlConnection GetSqlConnection()
        {
            if (connectionSQL == null)
            {
                connectionSQL = new SqlConnection(connectionsring);
            }
            return connectionSQL;
        } 
        public static void OpenConecction()
        {
            if (connectionSQL == null) 
            {
                connectionSQL = new SqlConnection(connectionsring);  
            }
            if (connectionSQL.State == System.Data.ConnectionState.Closed) 
            {
                connectionSQL.Open();
            }
        }
        private static void CloseConecction() 
        {
            if (connectionSQL != null && connectionSQL.State == System.Data.ConnectionState.Open) 
            {
                connectionSQL.Close();
            }
        }
    }
}
