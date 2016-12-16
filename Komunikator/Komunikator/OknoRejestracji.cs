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
                DataBase.addUser(LoginBox.Text, passwordBox.Text);
            }
            else if (passwordBox.Text != repasswordBox.Text)
            {
                MessageBox.Show("Podane hasła nie są takie same!", "Error");
            }
        }
    }
}
