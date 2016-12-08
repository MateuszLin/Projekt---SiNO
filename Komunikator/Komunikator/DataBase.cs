using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data.Common;

namespace Komunikator
{
    class DataBase
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
        public static void GetSelect(string cmd, OracleConnection con)
        {
            
            OracleCommand comand = new OracleCommand();
            comand.CommandText = cmd;
            comand.Connection = con;
            
            using (DbDataReader reader = comand.ExecuteReader())
            {
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        int nrprac = reader.GetOrdinal("NRPRAC");

                        long idprac = Convert.ToInt64(reader.GetValue(0));

                        int imieIndex = reader.GetOrdinal("IMIE");
                        string imie = reader.GetString(1);

                        int nazwiIndex = reader.GetOrdinal("NAZWISKO");
                        string nazwi = reader.GetString(nazwiIndex);

                        Console.WriteLine("Nrprac, "+ idprac);
                        Console.WriteLine("Imie, "+ imie);
                        Console.WriteLine("Nazwisko, "+ nazwi);
                    }
                }
            }

            
        }
    }
}
