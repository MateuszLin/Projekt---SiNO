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
    public partial class OknoZmianyHasla : Form
    {
        public OknoZmianyHasla()
        {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if(OldPasswdBox.Text == DataBase.getPassword(GlobalVariables.login))
            {
                if(NewPasswdBox.Text == RePasswdBox.Text)
                {
                    DataBase.updatePass(GlobalVariables.login, NewPasswdBox.Text);
                }
                else
                {
                    MessageBox.Show("Podane hasła są różne!", "Error");
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
