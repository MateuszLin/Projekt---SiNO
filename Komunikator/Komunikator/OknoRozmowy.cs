using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Komunikator
{
    public partial class OknoRozmowy : Form
    {

        Boolean threadStatusOdbieranie;
        string loginRozmowcy;
        public OknoRozmowy(string loginRozmowcy2)
        {
            InitializeComponent();
            loginRozmowcy = loginRozmowcy2;
            
            //rozppoczęcie nowego wątku odpowiedzialnego za odbieranie wiadomości
            threadStatusOdbieranie = true;
            Thread odbieranieThread = new Thread(this.Odbierz);
            odbieranieThread.Start();
        }

        private void buttonWyslij_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Naciśnięto Wyślij");
            Console.WriteLine("Wysłano: " + textBox1.Text);
            if(textBox1.Text != "")
            {
                DataBase.sendMessage(textBox1.Text, loginRozmowcy, GlobalVariables.login);
                AppendTextBox("\r\n" + "[" + GlobalVariables.login + "] " + textBox1.Text);
                textBox1.Clear();
            }

        } 

        /// <summary>
        /// Funkcja odpowiedzialna za automatyczne czasowe odbieranie wiadomości.
        /// Czas odświeżania definiowany w Thread.Sleep.
        /// Funkcja działa na osobnym wątku.
        /// </summary>
        void Odbierz()
        {
            while (threadStatusOdbieranie)
            {
                Console.WriteLine("Odbieranie....");
                foreach (string msg in DataBase.getMessage(GlobalVariables.login, loginRozmowcy))
                {
                    AppendTextBox("\r\n" + "[" + loginRozmowcy + "]" + msg);
                }
                System.Threading.Thread.Sleep(1000);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            threadStatusOdbieranie = false;
            this.Hide();
        }

        /// <summary>
        /// Funkcja odpowiedzialna za przekazywanie tekstu z nowego wątku 
        /// Do elementu textBox utworzonego przez inny wątek.
        /// </summary>
        /// <param name="value">Wiadomość która ma zostać dodana do 
        /// elementu textBox2</param>
        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            textBox2.Text += value;
            textBox2.Select(textBox2.Text.Length, 0);
            textBox2.ScrollToCaret();
        }
    }
}
