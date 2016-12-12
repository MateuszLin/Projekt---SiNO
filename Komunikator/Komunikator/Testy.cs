using System;
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
        static void Test_DB_connect()
        {
            

            
            OracleConnection con = DataBase.getConnect();
            
            try
            {
                con.Open();
            
            }
            catch (Exception msg)
            {
                Console.WriteLine("Blad, ", msg);
            }
    
        }
        static void Test_DB_select()
        {
            OracleConnection con = DataBase.getConnect();
            con.Open();
            string cmd = "Select Nrprac, imie, nazwisko from pracownik where nrprac = 2";
           
            DataBase.querySelect(cmd, con);
            con.Close();
            con.Dispose();
        }


        static void Test_DB_update()
        {
            OracleConnection con = DataBase.getConnect();
            con.Open();
            string cmd = "UPDATE pracownik set email = :email where nrprac = :nrprac";
            DataBase.doUpdate(cmd, con);
            con.Close();
            con.Dispose();
        }

        static void Test_DB_insert()
        {
            OracleConnection con = DataBase.getConnect();
            con.Open();
            string cmd = "Insert into pracownik (nrprac, imie, nazwisko) values (:nrprac, :imie, :nazwisko)";
            DataBase.doInsert(cmd, con);
            con.Close();
            con.Dispose();

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
            //string[] info = DataBase.getUserInfo("Matek");
            foreach (string x in DataBase.getUserInfo("Matek"))
            {
                Console.WriteLine(x);
            }
        }

        static void Test_DB_getpass()
        {
            string login = "admin";
            //DataBase pass = new DataBase();
            //----------ZMIANA TESTU Z POWODU ZMIANY METODY NA STAYCZNĄ----------
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

        public static void StartTest()
        {
            //Test1_Ftp_Upload();

            //Test_DB_connect();
            //Test_DB_select();
            //Test_DB_update();
            // Test_DB_insert();
            //Test_DB_getpass();
            //Test_DB_updateProfile();
            //Test_DB_addUser();
            Test_DB_getinfo();
            //Test3_TCP_Server();
            //Test4_Ftp_Read();
        }

    }
}
