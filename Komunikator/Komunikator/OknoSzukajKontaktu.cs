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
    public partial class OknoSzukajKontaktu : Form
    {
        public OknoSzukajKontaktu()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Szukaj_Click_1(object sender, EventArgs e)
        {
            string conditions = " Where login != :login";
            string[] conditionsTable = new string[] {GlobalVariables.login };
            if (loginBox.Text.Length != 0)
            {
                conditions += " And login = :login";
                conditionsTable[conditionsTable.Length] = loginBox.Text;
            }

            if (imieBox.Text.Length != 0)
            {
                conditions += " And imie = :imie";

                conditionsTable[conditionsTable.Length] = imieBox.Text;
            }

            if (nazwiskoBox.Text.Length != 0)
            {
                conditions += " And nazwisko = :naziwsko";

                conditionsTable[conditionsTable.Length] = nazwiskoBox.Text;
            }

            if (miastoBox.Text.Length != 0)
            {
                conditions += " And miasto = :miasto";

                conditionsTable[conditionsTable.Length] = miastoBox.Text;
            }

            if (emailBox.Text.Length != 0)
            {
                conditions += " And email = :email";

                conditionsTable[conditionsTable.Length] = emailBox.Text;
            }

            if (telefonBox.Text.Length != 0)
            {
                conditions += " And nrtelefonu = :nrtelefonu";

                conditionsTable[conditionsTable.Length] = telefonBox.Text;
            }

            

            List<List<string>> usersTable = DataBase.searchUsers(GlobalVariables.login, conditions, conditionsTable);

            for (int i = 0; i < usersTable.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(usersTable[i][0]);
                for (int j = 0; j < usersTable[i].Count; j++)
                {
                    if (j != 0) lvi.SubItems.Add(usersTable[i][j]);
                }
                userView.Items.Add(lvi);
            }


        }

        private void Zamknij_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
