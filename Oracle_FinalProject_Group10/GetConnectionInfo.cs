using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
namespace Oracle_FinalProject_Group10
{
    internal class GetConnectionInfo
    {
        public static
            OracleConnection GetDBConnection(string host, String user, String password, String sv, int port, bool isDBA) {
            string connString = "Data Source = (DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)" +
                "(HOST = " + host + ")(PORT = " + port + "))(CONNECT_DATA =(SERVER = DEDICATED)" +
                "(SERVICE_NAME = " + sv + "))); User Id = " + user + "; password = " + password + ";";
           
            if (isDBA) { 
                connString = connString + "DBA Privilege=SYSDBA;"; 
            }

            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = connString;
            return conn;
        }
    }
}
