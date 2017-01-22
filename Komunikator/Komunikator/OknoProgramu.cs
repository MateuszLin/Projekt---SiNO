using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Komunikator
{
    public partial class OknoProgramu : Form
    {

        public OknoProgramu()
        {
            InitializeComponent();
            label1.Text = String.Format("Zalogowano: {0}", GlobalVariables.login);
            
            loadContacts();
            DataBase.setStatus(GlobalVariables.login, 1);

            //---------------ROZPOCZECIE TESTÓW-----------------
            Testy.StartTest();
        }


        // Poniższa metoda nie działa poprawnie ponieważ w metodzie wyloguj używamy this.Close() 
        // Więc po nadpisaniu metody Close() opcja wyloguj kończy aplikację.
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void wylogujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBase.setStatus(GlobalVariables.login, 0);
            this.Hide();
            OknoLogowania oknoLogowania = new OknoLogowania();
            oknoLogowania.Show();
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBase.setStatus(GlobalVariables.login, 0);
            Application.Exit();
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Komuikator internetowy działąjący za pomocą bazy danych.
                            Tworzony przez Michała i Mateusza", "O programie");
        }

        private void szukajUżytkownikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OknoSzukajKontaktu szukaj = new OknoSzukajKontaktu(this);
            szukaj.Show();
        }


        private void loadContacts()
        {
            listContact.Items.Clear();
            List<string> contactsList = DataBase.getContacts(GlobalVariables.login);
            foreach (string name in contactsList)
            {
                listContact.Items.Add(name);

            }
            //Dodanie obsługi listContact_MouseDoubleClick
            listContact.MouseDoubleClick += new MouseEventHandler(listContact_MouseDoubleClick);


        }


        /// <summary>
        /// Funkcja która opisuje co się dzieje gdy dwukrotnie naciskamy na obiekt na liście kontaktów.
        /// </summary>
        private void listContact_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listContact.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                OknoRozmowy oknoRozmowy = new OknoRozmowy(listContact.GetItemText(listContact.SelectedItem));
                oknoRozmowy.Show();
            }
        }

        private void zmieńHasłoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OknoZmianyHasla oknoZmianyHasla = new OknoZmianyHasla();
            oknoZmianyHasla.ShowDialog();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OknoProfil profil = new OknoProfil();
            profil.ShowDialog();
        }


        private void OknoProgramu_FormClosed(object sender, FormClosedEventArgs e)
        {

                DataBase.setStatus(GlobalVariables.login, 0);            
        }


        private void OknoProgramu_FormClosing(object sender, FormClosingEventArgs e)
        {
                DataBase.setStatus(GlobalVariables.login, 0);          
        }

        private void OknoProgramu_Load(object sender, EventArgs e)
        {

        }

    }
}
