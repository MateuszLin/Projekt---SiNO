using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;


namespace Komunikator
{
    class ConnectDataBase
    {
        private static string GetConnectionString(string host, int port, string sid, string user, string password)
        {
            string conString = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));Password=" + password + ";User ID=" + user;
            return conString;
        }
        public static OracleConnection GetConnect(string host, int port, string sid, string user, string password)
        {
            OracleConnection oraConn = new OracleConnection();
            oraConn.ConnectionString = GetConnectionString(host, port, sid, user, password);

            return oraConn;
        }
    }
}
