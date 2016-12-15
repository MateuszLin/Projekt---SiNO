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
            catch (Exception e) { Console.WriteLine("Blad, " + e); }

            return pass;
        }


        /// <summary>
        /// Funkcja aktualizujaca informacje o uzytkownikach
        /// </summary>
        /// <param name="login"> string, login uzytkownika</param>
        /// <param name="upThing">string, co chcemy zaktualizowac (imie, nazwisko, miasto, email, nrtelefonu)</param>
        /// <param name="update"> string, wartosc na jaka chcemy zaktualizowac</param>
        public static void updateProfile(string login, string upThing, string update)
        {
            string cmd = "Update sinoUsers Set " + upThing + " = :" + upThing + " where login = :login";

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
            catch (Exception e) { Console.WriteLine("Blad, " + e); }

        }


        /// <summary>
        /// Funkcja zwracajaca informacje uzytkownika o podanym loginie
        /// </summary>
        /// <param name="login">string, login od ktorego chcemy uzyskac informacje</param>
        /// <returns></returns>
        public static string[] getUserInfo(string login)
        {
            string cmd = "Select login, imie, nazwisko, miasto, email, nrtelefonu from sinousers where login = :login";
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
                                reader.GetOrdinal("miasto"),
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
            catch (Exception e) { Console.WriteLine("Blad, " + e); }

            return ret;
        }


        /// <summary>
         /// Funckja wysylajaca wiadomosc
         /// </summary>
         /// <param name="msg">string, wiadomosc</param>
         /// <param name="odbiorca">string, login odbiorcy</param>
         /// <param name="nadawca">string, login nadawcy</param>
         public static void sendMessage(string msg, string odbiorca, string nadawca)
         {
             string cmd = "insert into sinorozmowy (msg, odbiorca, nadawca, czas) values (:msg, :odbiorca, :nadawca, sysdate)";
 
             try
             {
                 OracleConnection con = getConnect();
                 OracleCommand command = new OracleCommand(cmd, con);
 
                 command.Parameters.Add(new OracleParameter("msg", msg));
                 command.Parameters.Add(new OracleParameter("odbiorca", odbiorca));
                command.Parameters.Add(new OracleParameter("nadawca", nadawca));
 
                 con.Open();
                 command.ExecuteNonQuery();
 
                 con.Close();
                 con.Dispose();
 
             }
             catch (Exception e)
             { Console.WriteLine("Blad, " + e); }
         }
 
         public static string getMessage(string odbiorca, string nadawca)
         {
             string cmd = "Select msg from sinorozmowy where nadawca = :nadawca and odbiorca = :odbiorca";
             string msg = "";
             try
             {
                 OracleConnection con = getConnect();
                 OracleCommand command = new OracleCommand(cmd, con);
                 
                 command.Parameters.Add(new OracleParameter("nadawca", nadawca));
                 command.Parameters.Add(new OracleParameter("odbiorca", odbiorca));
 
                 con.Open();
                 using (DbDataReader reader = command.ExecuteReader())
                 {
                     if (reader.HasRows)
                     {
                         while(reader.Read())
                         {
                             int msgIndex = reader.GetOrdinal("msg");
                             msg += reader.GetString(msgIndex);
                         }
                     }
                 }
                 con.Close();
                 con.Dispose();
             }
             catch (Exception e) { Console.WriteLine("Blad, " + e); }
 
             return msg;
         }


        public static void doInsert(string cmd, OracleConnection con)
        /// Funckja wysylajaca wiadomosc
        /// </summary>
        /// <param name="msg">string, wiadomosc</param>
        /// <param name="odbiorca">string, login odbiorcy</param>
        /// <param name="nadawca">string, login nadawcy</param>
        public static void sendMessage(string msg, string odbiorca, string nadawca)
        {
            string cmd = "insert into sinorozmowy (msg, odiorca, nadawca, czas) values (:msg, :odbiorca, :nadawca, sysdate)";

            try
            {
                OracleConnection con = getConnect();
                OracleCommand command = new OracleCommand(cmd, con);

                command.Parameters.Add(new OracleParameter("msg", msg));
                command.Parameters.Add(new OracleParameter("odbiorca", odbiorca));
                command.Parameters.Add(new OracleParameter("nadawca", nadawca));

                con.Open();
                command.ExecuteNonQuery();

                con.Close();
                con.Dispose();

            }
            catch (Exception e)
            { Console.WriteLine("Blad, " + e); }
        }


        /// <summary>
        /// Funckja odbierajaca wiadomosci z bazy danych.
        /// </summary>
        /// <param name="odbiorca">string, login odbiorcy</param>
        /// <param name="nadawca">string, login nadawcy</param>
        /// <returns>string, wiadomosc dla obiorcy</returns>
        public static string getMessage(string odbiorca, string nadawca)
        {
            string cmd = "Select msg from sinorozmowy where nadawca = :nadawca and odbiorca = :odbiorca order by CZAS";
            string msg = "";
            try
            {
                OracleConnection con = getConnect();
                OracleCommand command = new OracleCommand(cmd, con);

                command.Parameters.Add(new OracleParameter("nadawca", nadawca));
                command.Parameters.Add(new OracleParameter("odbiorca", odbiorca));

                con.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int msgIndex = reader.GetOrdinal("msg");
                            msg += reader.GetString(msgIndex);
                        }
                    }
                }
                con.Close();
                con.Dispose();
            }
            catch (Exception e) { Console.WriteLine("Blad, " + e); }

            return msg;
        }
        /// <summary>
        /// Funkcja sprawdzajaca czy uzytkownik o podanym loginie jest online
        /// </summary>
        /// <param name="login">string, login uzytkownika</param>
        /// <returns></returns>
        public static Boolean isOnline(string login)
        {
            string cmd = "Select status from sinousers where login = :login";
            Boolean isonline = false;
            try
            {
                OracleConnection con = getConnect();
                OracleCommand command = new OracleCommand(cmd, con);

                command.Parameters.Add(new OracleParameter("login", login));

                con.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int statusIndex = reader.GetOrdinal("status");
                            int status = reader.GetInt32(statusIndex);

                            if (status == 1) { isonline = true; }

                        }
                    }
                }
            }
            catch (Exception e) { Console.WriteLine("Blad, " + e); }

            return isonline;


        }
        /// <summary>
        /// Funkcja wyszukujaca uzytkownikow
        /// </summary>, 
        /// <param name="login">string, login uzytownika ktory wyszukuje</param>
        /// <param name="conditions">string, warunki po where kazdy z AND</param>
        /// <param name="conditionsTable">string[], tablica z parametrami do warunku</param>
        /// <returns></returns>
        public static List<List<string>> searchUsers(string login, string conditions, string[] conditionsTable)
        {
            List<List<string>> usersTable = new List<List<string>>();
            int counter = 0;
            string cmd = "Select login, imie, nazwisko, miasto, email, nrtelefonu from sinousers" + conditions;
            try
            {
                OracleConnection con = getConnect();
                OracleCommand command = new OracleCommand(cmd, con);

                for (int i = 0; i < conditionsTable.Length; i++)
                {
                    command.Parameters.Add(new OracleParameter("", conditionsTable[i]));
                }

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
                                reader.GetOrdinal("miasto"),
                                reader.GetOrdinal("email"),
                                reader.GetOrdinal("nrtelefonu")
                                };
                            usersTable.Add(new List<string>());
                            for (int i = 0; i < index.Length; i++)
                            {
                                if (reader.IsDBNull(index[i])) usersTable[counter].Add(" ");
                                else usersTable[counter].Add(reader.GetString(index[i]));

                            }

                            counter += 1;

                        }

                    }
                }

            }
            catch (Exception e) { Console.WriteLine("Blad, " + e); }

            return usersTable;
        }
    }
}
   
