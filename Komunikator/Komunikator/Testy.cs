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
            string host = "oracle1.pkif.us.edu.pl";
            int port = 1521;
            string sid = "umain.pkif.us.edu.pl";
            string user = "RT_mlindel";
            string password = "oracle";

            Console.WriteLine("Proba");
            OracleConnection con = DataBase.GetConnect(host, port, sid, user, password);
            Console.WriteLine("Lacze sie z: " + con);
            try
            {
                con.Open();
                Console.WriteLine("Polaczono");
            }
            catch (Exception msg)
            {
                Console.WriteLine("Blad, ", msg);
            }
    
        }
        static void Test_DB_select()
        {
            string host = "oracle1.pkif.us.edu.pl";
            int port = 1521;
            string sid = "umain.pkif.us.edu.pl";
            string user = "RT_mlindel";
            string password = "oracle";

            OracleConnection con = DataBase.GetConnect(host, port, sid, user, password);
            con.Open();

            string cmd = "Select Nrprac, imie, nazwisko from pracownik";
            DataBase.GetSelect(cmd, con);
            con.Close();
            con.Dispose();
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
            Test_DB_select();
            //Test3_TCP_Server();
            //Test4_Ftp_Read();
        }

    }
}
