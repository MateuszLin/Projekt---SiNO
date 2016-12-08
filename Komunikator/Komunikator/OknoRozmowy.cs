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
        public OknoRozmowy()
        {
            InitializeComponent();
            // ROZPOCZECIE TESTÓW
            Testy.StartTest();
            
        }

        private void buttonWyslij_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Naciśnięto Wyślij");
            Console.WriteLine("Wysłano: " + textBox1.Text);
        }

        private void buttonOdbierz_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Naciśnięto Odbierz");
            textBox2.Text += "Odebrano i wyświetlono w oknie\n";
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
