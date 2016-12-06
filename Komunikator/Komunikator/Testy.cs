using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



        public static void StartTest()
        {
            Test1_Ftp_Upload();

        }

    }
}
