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
    public partial class OknoProgramu : Form
    {
        public OknoProgramu()
        {
            InitializeComponent();
        }

        private void rozmowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OknoRozmowy oknoRozmowy = new OknoRozmowy();
            oknoRozmowy.Show();
        }

        private void wylogujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            OknoLogowania oknoLogowania = new OknoLogowania();
            oknoLogowania.Show();
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
