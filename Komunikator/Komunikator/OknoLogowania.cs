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
    public partial class OknoLogowania : Form
    {
        public OknoLogowania()
        {
            InitializeComponent();
            //Wartości wpisane tymczasow - żeby nie trzeba było wpisywać ręcznie.
            //W dalszej wersji projektu dane będą przetrzymywane w DB
            LoginBox.Text = "admin";
            PasswordBox.Text = "admin";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text == "admin" && PasswordBox.Text == "admin")
            {
                this.Hide();
                //OknoRozmowy oknoRozmowy = new OknoRozmowy();
                //oknoRozmowy.Show();
                OknoProgramu oknoProgramu = new OknoProgramu();
                oknoProgramu.Show();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
