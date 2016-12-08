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
        private static string GetConnectionString()
        {

            string host = "oracle1.pkif.us.edu.pl";
            int port = 1521;
            string sid = "umain.pkif.us.edu.pl";
            string user = "RT_mlindel";
            string password = "oracle";

            string conString = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));Password=" + password + ";User ID=" + user;
            return conString;
        }
        public static OracleConnection getConnect()
        {
            OracleConnection oraConn = new OracleConnection();
            oraConn.ConnectionString = GetConnectionString();

            return oraConn;
        }
        public static void querySelect(string cmd, OracleConnection con)
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

        public static void doInsert(string cmd, OracleConnection con)
        {
            //"Insert into pracownik (nrprac, imie, nazwisko) values (:nrprac, :imie, :nazwisko)"

            OracleCommand command = new OracleCommand(cmd, con);

            try
            {
                command.Parameters.Add(new OracleParameter("nrprac", 999));
                command.Parameters.Add(new OracleParameter("imie", "Rysiek"));
                command.Parameters.Add(new OracleParameter("nazwisko", "zKlanu"));

                int rowCount = command.ExecuteNonQuery();
                Console.WriteLine("Dodano wierszy: " + rowCount);
            }
            catch(Exception e)
            {
                Console.WriteLine("Blad " + e);
                
            }
        }

        public static void doUpdate(string cmd, OracleConnection con)
        {
            OracleCommand command = new OracleCommand(cmd, con);

            //"UPDATE pracownik set email = :email where nrprac = :nrprac"
            try
            {
                command.Parameters.Add(new OracleParameter("email", "test@mail"));
                command.Parameters.Add(new OracleParameter("nrprac", 41));

                command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                Console.WriteLine("Blad " + e);
            }
        }
    }
}
