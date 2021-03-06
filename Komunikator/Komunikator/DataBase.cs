﻿using System;
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
        /// Metoda zwracajaca dane polaczeniowe do bazy danych Oracle
        /// </summary>
        /// <returns>OracleConnection, polaczenie do bazy danych oracle</returns>
        private static OracleConnection getConnect()
        {
            string host = "";
            int port = 0;
            string sid = "";
            string user = "";
            string password = "";

            string conString = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));Password=" + password + ";User ID=" + user;

            OracleConnection oraConn = new OracleConnection();
            oraConn.ConnectionString = conString;

            return oraConn;
        }


        /// <summary>
        /// Metoda odczytujaca haslo uzytkownika z bazy danych.
        /// </summary>
        /// <param name="loginn">string, login uzytkownika</param>
        /// <returns>string, haslo uzytkownika</returns>
        public static string getPassword(string loginn)
        {
            string pass = null;
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
        /// Metoda aktualizujaca informacje o uzytkownikach
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
       
                con.Close();
                con.Dispose();
            }
            catch (Exception e) { Console.WriteLine("Blad, " + e); }

        }


        /// <summary>
        /// Metoda dodajaca uzytkownika do bazy danych
        /// </summary>
        /// <param name="login">string, login</param>
        /// <param name="password">string haslo</param>
        public static Boolean addUser(string login, string password)
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
            
                con.Close();
                con.Dispose();

                return true;
            }
            catch (Exception e) { Console.WriteLine("Blad, " + e); return false; }

            
        }
        


        /// <summary>
        /// Metoda zwracajaca informacje uzytkownika o podanym loginie
        /// </summary>
        /// <param name="login">string, login od ktorego chcemy uzyskac informacje</param>
        /// <returns></returns>
        public static List<string> getUserInfo(string login)
        {
            string cmd = "Select login, imie, nazwisko, miasto, email, nrtelefonu from sinousers where login = :login";
            
            List<string> userInfo = new List<string>();

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
                                    userInfo.Add("");
                                }
                                else
                                { 
                                    userInfo.Add(reader.GetString(index[x]));
                                }
                            }

                        }
                        con.Close();
                        con.Dispose();
                    }
                }
            }
            catch (Exception e) { Console.WriteLine("Blad, " + e); }

            return userInfo;
        }


        /// <summary>
        /// Metoda wysylajaca wiadomosc
        /// </summary>
        /// <param name="msg">string, wiadomosc</param>
        /// <param name="odbiorca">string, login odbiorcy</param>
        /// <param name="nadawca">string, login nadawcy</param>
        public static void sendMessage(string msg, string odbiorca, string nadawca)
        {
            string cmd = "Insert into sinorozmowy (msg, odbiorca, nadawca, czas, flagaodbioru) values (:msg, :odbiorca, :nadawca, sysdate, 0)";
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
        /// Metoda odbierajaca wiadomosci z bazy danych.
        /// </summary>
        /// <param name="odbiorca">string, login odbiorcy</param>
        /// <param name="nadawca">string, login nadawcy</param>
        /// <returns>List of strings, wiadomosc dla obiorcy</returns>
        public static List<string> getMessage(string odbiorca, string nadawca)
        {
            string cmd = "Select msg from sinorozmowy where nadawca = :nadawca and odbiorca = :odbiorca and flagaodbioru = 0 order by CZAS";
            List<string> messages = new List<string>();
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
                            if (!reader.IsDBNull(msgIndex)) messages.Add(reader.GetString(msgIndex));
                        }
                    }
                }
                

                if (messages.Count > 0)
                {
                    cmd = "update SINOROZMOWY set flagaodbioru = 1 where nadawca = :nadawca and odbiorca = :odbiorca and flagaodbioru = 0";
                    OracleCommand commandUpdate = new OracleCommand(cmd, con);
                    commandUpdate.Parameters.Add(new OracleParameter("nadawca", nadawca));
                    commandUpdate.Parameters.Add(new OracleParameter("odiorca", odbiorca));
                    commandUpdate.ExecuteNonQuery();

                }
                con.Close();
                con.Dispose();
            }
            catch (Exception e) { Console.WriteLine("Blad, " + e); }

            return messages;
        }

        /// <summary>
        /// Metoda ustawiająca status w komunikatorze
        /// </summary>
        /// <param name="login">str, login uzytkownika</param>
        /// <param name="status">int, status do ustawienia 1 - online 0 - offline</param>
        public static void setStatus(string login, int status)
        {
            string cmd = "Update sinousers SET status = :status where login = :login";
            try
            {
                OracleConnection con = getConnect();
                OracleCommand command = new OracleCommand(cmd, con);
                command.Parameters.Add(new OracleParameter("status", status));
                command.Parameters.Add(new OracleParameter("login", login));

                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                con.Dispose();
            }
            catch(Exception e) { Console.WriteLine("Blad " + e); }
        }


        /// <summary>
        /// Metoda sprawdzajaca czy uzytkownik o podanym loginie jest online
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
        /// Metoda wyszukujaca uzytkownikow
        /// </summary>, 
        /// <param name="login">string, login uzytownika ktory wyszukuje</param>
        /// <param name="conditions">string, warunki po where kazdy z AND</param>
        /// <param name="conditionsTable">string[], tablica z parametrami do warunku</param>
        /// <returns></returns>
        public static List<List<string>> searchUsers(string login, string conditions, List<string> conditionsTable)
        {
            List<List<string>> usersTable = new List<List<string>>();
            int counter = 0;
            string cmd = "Select login, imie, nazwisko, miasto, email, nrtelefonu from sinousers" + conditions;
            try
            {
                OracleConnection con = getConnect();
                OracleCommand command = new OracleCommand(cmd, con);

                for (int i = 0; i < conditionsTable.Count; i++)
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
                con.Close();
                con.Dispose();

            }
            catch (Exception e) { Console.WriteLine("Blad, " + e); }

            return usersTable;
        }


        /// <summary>
        /// Metoda zwracajaca kontakty uzytkownika
        /// </summary>
        /// <param name="login">string, login uzytkownika</param>
        /// <returns>string, kontakty uzytkownika</returns>
        public static List<string> getContacts(string login)
        {
            string cmd = "Select contacts from sinousers where login = :login";
            string contacts = "";
            List < String > contactsList = new List<String>();
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
                        while(reader.Read())
                        {
                            int contactsIndex = reader.GetOrdinal("contacts");
                            if (!reader.IsDBNull(contactsIndex)) {contacts = reader.GetString(contactsIndex); }
                            contactsList = contacts.Split(',').ToList();
                        }
                    }
                }
                con.Close();
                con.Dispose();
            }
            catch (Exception e) { Console.WriteLine("Blad, " + e); }
            return contactsList;
        }


        /// <summary>
        /// Metoda dodajaca uzytkownika do listy kontaktow
        /// </summary>
        /// <param name="login">string, login uzytkownika</param>
        /// <param name="addLogin">string, login uzytkownika, ktorego chcemy dodac</param>
        public static Boolean addToContacts(string login, string addLogin)
        {
            List<string> contactsList = getContacts(login);
            foreach(string name in contactsList)
            {
                if (name == addLogin)
                {
                    return false;
                }
            }
            contactsList.Add(addLogin);
            string contactsString = String.Join(",", contactsList.ToArray());
            string cmd = "Update sinousers Set contacts = :contactsString where login = :login";
            try
            {
                OracleConnection con = getConnect();
                OracleCommand command = new OracleCommand(cmd, con);
                command.Parameters.Add(new OracleParameter("contactsString", contactsString));
                command.Parameters.Add(new OracleParameter("login", login));

                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                con.Dispose();

                return true;
            }
            catch(Exception e) { Console.WriteLine("Blad, " + e); return false; }

        }

        /// <summary>
        /// Metoda aktualizujaca haslo uzytkownika
        /// </summary>
        /// <param name="login">string, login uzytkownika</param>
        /// <param name="pass">string, nowe haslo</param>
        public static Boolean updatePass(string login, string pass)
        {
            string cmd = "Update sinousers Set PASS = :pass where login = :login";

            try
            {
                OracleConnection con = getConnect();
                OracleCommand command = new OracleCommand(cmd, con);

                command.Parameters.Add(new OracleParameter("pass", pass));
                command.Parameters.Add(new OracleParameter("login", login));

                con.Open();
                command.ExecuteNonQuery();

                con.Close();
                con.Dispose();
                return true;
            }
            catch(Exception e) { Console.WriteLine("Blad, " + e); return false; }
        }


        /// <summary>
        /// Metoda sprawdzajaca czy podany login istnieje juz w bazie
        /// </summary>
        /// <param name="login">string, login, ktory sprawdzic w bazie</param>
        /// <returns>true - jezeli istnieje, false - jezeli nie istnieje</returns>
        public static Boolean isLoginAvaible(string login)
        {
            string cmd = "Select count(login) counter from sinousers where login = :login";
            try
            {
                OracleConnection con = getConnect();
                OracleCommand command = new OracleCommand(cmd, con);

                command.Parameters.Add(new OracleParameter("login", login));

                con.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    if(reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            int counterIndex = reader.GetOrdinal("counter");
                            int counter = reader.GetInt32(counterIndex);

                            con.Close();
                            con.Dispose();
                            
                            if (counter >= 1)
                            {    
                                return false;
                            }
                            return true;
                        }
                    }
                }
                
            }
            catch(Exception e) { Console.WriteLine("Blad, " + e);}

            return true;
        }

    }
}

