using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace Komunikator
{
    public class FTP_Communication
    {
        /// <summary>
        /// Funkcja wrzucająca na serwer FTP plik z podanej lokalizacji
        /// </summary>
        /// <param name="url">adres serwera FTP</param>
        /// <param name="filePath">Ścieżka do pliku</param>
        public void UploadFileToFtp(string url, string filePath, string username, string password)
        {
            var fileName = Path.GetFileName(filePath);
            var request = (FtpWebRequest)WebRequest.Create(url + fileName);

            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential(username, password);
            request.UsePassive = true;
            request.UseBinary = true;
            request.KeepAlive = false;

            using (var fileStream = File.OpenRead(filePath))
            {
                using (var requestStream = request.GetRequestStream())
                {
                    fileStream.CopyTo(requestStream);
                    requestStream.Close();
                }
            }

            var response = (FtpWebResponse)request.GetResponse();
            Console.WriteLine("Dodano na FTP: {0}", response.StatusDescription);
            response.Close();
        }


        /// <summary>
        /// Metoda czytajaca plik z serwera FTP, nazwa pliku podana w url.
        /// </summary>
        public void ReadFileFromFTP(string url, string username, string password)
        {
            WebClient request = new WebClient();
            request.Credentials = new NetworkCredential(username, password);

            try
            {
                byte[] newFileData = request.DownloadData(url);
                string fileString = System.Text.Encoding.UTF8.GetString(newFileData);
                Console.WriteLine("--------Odczyt pliku z FTP, TEST-----------");
                Console.WriteLine(fileString);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Nieudane odczytanie pliku z FTP");
                Console.WriteLine(ex);
            }
        }

    }
}
