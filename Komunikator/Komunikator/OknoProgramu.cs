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
            loadContacts();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void rozmowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OknoRozmowy oknoRozmowy = new OknoRozmowy();
            //new Thread(() => new OknoRozmowy().Show()).Start();
            oknoRozmowy.Show();
        }

        private void wylogujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Hide();
            OknoLogowania oknoLogowania = new OknoLogowania();
            oknoLogowania.Show();
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Komuikator internetowy działąjący za pomocą bazy danych.
                            Tworzony przez Michała i Mateusza", "O programie");
        }

        // Poniższa metoda nie działa ponieważ w metodzie wyloguj używamy this.Close() 
        // Więc po nadpisaniu metody Close() opcja wyloguj kończy aplikację.
        /*
        /// <summary>
        /// Metoda nadpisuje przycisk okna X aby on nie zamykał formatki lecz cały program.
        /// </summary>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
        */

        private void loadContacts()
        {
            List<string> testList = new List<string>(new string[] { "Admin", "Mateusz", "Michał", "Bogdan", "Łukasz" });
            foreach (string name in testList)
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
                MessageBox.Show("Tu otworzy się rozmowa", "Rozmowa");
            }
        }
    }
}
