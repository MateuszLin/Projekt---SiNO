using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komunikator
{
    public partial class OknoRozmowy : Form
    {
        string loginRozmowcy;
        public OknoRozmowy(string loginRozmowcy2)
        {
            loginRozmowcy = loginRozmowcy2;
            InitializeComponent();
            // ROZPOCZECIE TESTÓW
            Testy.StartTest();
            
        }

        private void buttonWyslij_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Naciśnięto Wyślij");
            Console.WriteLine("Wysłano: " + textBox1.Text);
            if(textBox1.Text != "")
            {
                DataBase.sendMessage(textBox1.Text, loginRozmowcy, GlobalVariables.login);
            }

        }

        private void buttonOdbierz_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Naciśnięto Odbierz");
            //textBox2.Text += "Odebrano i wyświetlono w oknie\n";
            textBox2.Text += DataBase.getMessage(GlobalVariables.login, loginRozmowcy);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            OknoLogowania oknoLogowania = new OknoLogowania();
            oknoLogowania.Show();
        }
    }
}
