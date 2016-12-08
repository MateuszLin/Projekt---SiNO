using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text;
using System.Net.Sockets;

namespace Komunikator
{
    class TCP_Communication
    {
        public void Server()
        {
            try
            {
                //IPAddress ipAd = IPAddress.Parse("Wpisz IP");  //działał na porcie 5442
                IPAddress ipAd = IPAddress.Parse("Wpisz IP");

                TcpListener myList = new TcpListener(ipAd, 5442);
                //TcpListener myList = new TcpListener(IPAddress.Any, 5442);

                myList.Start();

                Console.WriteLine("Serwer uruchominy na porcie 8001");
                Console.WriteLine("Local end point: " + myList.LocalEndpoint);
                Console.WriteLine("Czekam na połączenie...");

                Socket s = myList.AcceptSocket();
                Console.WriteLine("Połączenie przychodzące: " + s.RemoteEndPoint);

                byte[] b = new byte[100];
                int k = s.Receive(b);

                Console.WriteLine("Odebrano...:");
                for (int i = 0; i < k; i++)
                {
                    Console.Write(Convert.ToChar(b[i]));
                }

                ASCIIEncoding asen = new ASCIIEncoding();
                s.Send(asen.GetBytes("To jest odpowiedź"));
                Console.WriteLine("\nWysłano odpowiedź");

                s.Close();
                myList.Stop();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Coś poszło nie tak ... " + ex.Message);
            }
        }
    }
}
