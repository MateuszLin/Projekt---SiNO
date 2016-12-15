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
            LoginBox.Text = "admin";
            PasswordBox.Text = "admin";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (PasswordBox.Text == DataBase.getPassword(LoginBox.Text))
            {
                this.Hide();
                GlobalVariables.login = LoginBox.Text;
                OknoProgramu oknoProgramu = new OknoProgramu();
                oknoProgramu.Show();
            }
            else
            {
                if (GlobalVariables.loginCounter == 0) Application.Exit();
                MessageBox.Show("Logowanie nieudane!\nPozostałe próby: " + GlobalVariables.loginCounter, "Błąd logowania");
                GlobalVariables.loginCounter--;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
