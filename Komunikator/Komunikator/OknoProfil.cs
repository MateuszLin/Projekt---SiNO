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
    public partial class OknoProfil : Form
    {
        public OknoProfil()
        {
            InitializeComponent();
            List<string> profil = DataBase.getUserInfo(GlobalVariables.login);
            imieBox.Text = profil[1];
            nazwiskoBox.Text = profil[2];
            miastoBox.Text = profil[3];
            emailBox.Text = profil[4];
            telefonBox.Text = profil[5];
            
        }

        private void Zastosuj_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase.updateProfile(GlobalVariables.login, "imie", imieBox.Text);
                DataBase.updateProfile(GlobalVariables.login, "nazwisko", nazwiskoBox.Text);
                DataBase.updateProfile(GlobalVariables.login, "miasto", miastoBox.Text);
                DataBase.updateProfile(GlobalVariables.login, "nrtelefonu", telefonBox.Text);
                DataBase.updateProfile(GlobalVariables.login, "email", emailBox.Text);
                MessageBox.Show("Zmiany zapisano pomyślnie", "Aktualizowanie profilu");
            }
            catch(Exception x)
            {
                MessageBox.Show("Nie można dokonać wszystkich zmian", "Error");
                Console.WriteLine("Blad, przy aktualizacji profilu\n ", x.Message);
            }
            
            
        }

        private void Anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
