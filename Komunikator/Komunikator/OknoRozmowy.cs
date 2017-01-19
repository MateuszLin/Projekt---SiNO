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
        //Thread odbieranieThread;
        public OknoRozmowy(string loginRozmowcy2)
        {
            loginRozmowcy = loginRozmowcy2;
            InitializeComponent();
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
                //textBox2.Text += "\r\n" + "[" + GlobalVariables.login + "] " + textBox1.Text;
                AppendTextBox("\r\n" + "[" + GlobalVariables.login + "] " + textBox1.Text);
                textBox1.Clear();
            }

        }
        
        
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonWyslij_Click((object)sender, (EventArgs)e);
            }
        }

        private void buttonOdbierz_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Naciśnięto Odbierz");

            foreach(string msg in DataBase.getMessage(GlobalVariables.login, loginRozmowcy))
            {
                textBox2.Text += "\r\n" + "[" + loginRozmowcy + "]" + msg;
            }
        }

        void Odbierz()
        {
            while (threadStatusOdbieranie)
            {
                Console.WriteLine("Odbieranie....");
                //AppendTextBox("\r\n" + "[" + loginRozmowcy + "] " + DataBase.getMessage(GlobalVariables.login, loginRozmowcy));
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


        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            textBox2.Text += value;
        }


    }
}
