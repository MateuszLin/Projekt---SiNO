﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace Komunikator
{
    public class Testy
    {
        static void Test1_Ftp_Upload()
        {
            FTP_Communication test = new FTP_Communication();
            //test.UploadFileToFtp("ftp://sino.prv.pl/", "sciezka do pliku", "login", "password");
            test.UploadFileToFtp("ftp://sino.cba.pl/sino.cba.pl/", "sciezka do pliku", "login", "password");
        }
        static bool Test_DB_connect()
        {
            //Console.WriteLine("Proba");
            OracleConnection con = DataBase.getConnect();
            //Console.WriteLine("Lacze sie z: " + con);
            try
            {
                con.Open();
                //Console.WriteLine("Polaczono");
                return true;
            }
            catch (Exception)
            {
                //Console.WriteLine("Blad, ", msg);
                return false;
            }
    
        }
      


        static void Test_DB_updateProfile()
        {
            DataBase.updateProfile("Matek", "imie", "Mateusz");
        }

        static void Test_DB_addUser()
        {
            DataBase.addUser("TEST", "haslo");
        }

        static void Test_DB_getinfo()
        {
            foreach (string x in DataBase.getUserInfo("Matek"))
            {
                Console.WriteLine(x);
            }
        }

        static void Test_DB_getpass()
        {
            string login = "admin";
            Console.WriteLine("Odebralem " + DataBase.getPassword(login));
        }


        static void Test3_TCP_Server()
        {
            TCP_Communication test = new TCP_Communication();
            test.Server();
        }

        static void Test4_Ftp_Read()
        {
            FTP_Communication test = new FTP_Communication();
            test.ReadFileFromFTP("ftp://......", "login", "password");
        }

        static void Test_DB_odbieranie()
        {
            Console.WriteLine(DataBase.getMessage("Matek", "admin"));
        }

        static void Test_DB_isOnline()
        {
            Console.WriteLine(DataBase.isOnline("Matek"));
            Console.WriteLine(DataBase.isOnline("Michal"));
        }
        public static void StartTest()
        {
            //Test1_Ftp_Upload();

            //Test_DB_connect();

            //Test_DB_getpass();
            //Test_DB_updateProfile();
            //Test_DB_addUser();
            // Test_DB_getinfo();
            //Test3_TCP_Server();
            //Test4_Ftp_Read();
           // Test_DB_odbieranie();
            //Test_DB_isOnline();
        }

    }
}
