using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data.Common;
using System.Data;

namespace Komunikator
{
    class DataBase
    {
        

        /// <summary>
        /// Funkcja zwracajaca dane do polaczenie sie z baza danych 
        /// </summary>
        /// <returns>string dane do polaczenia sie z baza danych</returns>
        private static string GetConnectionString()
        {

            string host = "";
            int port = 0;
            string sid = "";
            string user = "";
            string password = "";


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


        /// <summary>
        /// Funkcja odczytujaca haslo uzytkownika z bazy danych.
        /// </summary>
        /// <param name="loginn">string, login uzytkownika</param>
        /// <returns>string, haslo uzytkownika</returns>
        public static string getPassword(string loginn)
        {
            string pass = "NULL";
            string cmd = "Select pass from sinousers where login = :login";
            try
            {
                OracleConnection con = getConnect();
                OracleCommand command = new OracleCommand(cmd, con);
                command.Parameters.Add(new OracleParameter("login", loginn));
                con.Open();

                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int passIndex = reader.GetOrdinal("pass");
                            pass = reader.GetString(passIndex);
                        }
                    }
                }
            }
            catch(Exception e) { Console.WriteLine("Blad, " + e); }

                return pass;
        }


        /// <summary>
        /// Funkcja aktualizujaca informacje o uzytkownikach
        /// </summary>
        /// <param name="login"> string, login uzytkownika</param>
        /// <param name="upThing">string, co chcemy zaktualizowac (imie, nazwisko, miejscowosc, email, nrtelefonu)</param>
        /// <param name="update"> string, wartosc na jaka chcemy zaktualizowac</param>
        public static void updateProfile(string login, string upThing, string update)  
        {
            string cmd = "Update sinoUsers Set " + upThing + " = :" +  upThing + " where login = :login";

            try
            {
                OracleConnection con = getConnect();
                OracleCommand command = new OracleCommand(cmd, con);
                    
                command.Parameters.Add(new OracleParameter(upThing, update));
                command.Parameters.Add(new OracleParameter("login", login));

                con.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Zaktualizowano informacje o uzytkowniku");
                con.Close();
                con.Dispose();
            }
            catch (Exception e) { Console.WriteLine("Blad, " + e); }
            
        }


        /// <summary>
        /// Funkcja dodajaca uzytkownika do bazy danych
        /// </summary>
        /// <param name="login">string, login</param>
        /// <param name="password">string haslo</param>
        public static void addUser(string login, string password)
        {
            string cmd = "Insert into sinousers(login, pass) values(:login, :password)";

            try
            {
                OracleConnection con = getConnect();
                OracleCommand command = new OracleCommand(cmd, con);

                command.Parameters.Add(new OracleParameter("login", login));
                command.Parameters.Add(new OracleParameter("password", password));

                con.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Dodano uzytkownika");
                con.Close();
                con.Dispose();
            }
            catch(Exception e) { Console.WriteLine("Blad, " + e); }
            
        }


        /// <summary>
        /// Funkcja zwracajaca informacje uzytkownika o podanym loginie
        /// </summary>
        /// <param name="login">string, login od ktorego chcemy uzyskac informacje</param>
        /// <returns></returns>
        public static string[] getUserInfo(string login)
        {
            string cmd = "Select login, imie, nazwisko, miejscowosc, email, nrtelefonu from sinousers where login = :login";
            string[] ret = new string[6];

            try
            {
                OracleConnection con = getConnect();
                OracleCommand command = new OracleCommand(cmd, con);
                command.Parameters.Add("login", login);

                con.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int[] index =
                                {
                                reader.GetOrdinal("login"),
                                reader.GetOrdinal("imie"),
                                reader.GetOrdinal("nazwisko"),
                                reader.GetOrdinal("miejscowosc"),
                                reader.GetOrdinal("email"),
                                reader.GetOrdinal("nrtelefonu")
                                };

                            for (int x = 0; x < index.Length; x++)
                            {
                                if (reader.IsDBNull(index[x]))
                                {
                                    ret[x] = " ";
                                }
                                else
                                {
                                    ret[x] = reader.GetString(index[x]);
                                }
                            }
                        
                        }
                        con.Close();
                        con.Dispose();
                    }
                }
            }
            catch(Exception e) { Console.WriteLine("Blad, " + e); }

            return ret;
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
