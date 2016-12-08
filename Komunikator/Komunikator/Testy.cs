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
            string host = "";
            int port = 0;
            string sid = "";
            string user = "";
            string password = "";

            Console.WriteLine("Proba");
            OracleConnection con = ConnectDataBase.GetConnect(host, port, sid, user, password);
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
            //Test3_TCP_Server();
            //Test4_Ftp_Read();
        }

    }
}
