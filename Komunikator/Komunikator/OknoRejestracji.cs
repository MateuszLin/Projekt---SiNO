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
    public partial class OknoRejestracji : Form
    {
        public OknoRejestracji()
        {
            InitializeComponent();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if(passwordBox.Text == "") { label4.Text = "*"; label7.Text = "Uzupełnij brakujące pola"; }
            if(repasswordBox.Text == "") { label5.Text = "*"; label7.Text = "Uzupełnij brakujące pola"; }
            if(LoginBox.Text == "") { label6.Text = "*"; label7.Text = "Uzupełnij brakujące pola"; }

            if ((passwordBox.Text != "") && (repasswordBox.Text != "") && (LoginBox.Text != "") 
                && (passwordBox.Text == repasswordBox.Text))
            {
                
                if (DataBase.isLoginAvaible(LoginBox.Text))
                {
                    bool succesAdd = DataBase.addUser(LoginBox.Text, passwordBox.Text);
                    if (succesAdd)
                    {
                        MessageBox.Show("Konto zostało założone poprawnie.\nMożesz zalogować się na swoje konto.", "SUKCES");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Konto nie zostało założone, spróbuj ponownie później", "ERROR");
                    }
                }
                else
                {
                    MessageBox.Show("Podany login jest już zajęty!", "ERROR");
                }
            }
            else if (passwordBox.Text != repasswordBox.Text)
            {
                MessageBox.Show("Podane hasła nie są takie same!", "Error");
            }
        }
    }
}
