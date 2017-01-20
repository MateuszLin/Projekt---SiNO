namespace Komunikator
{
    partial class OknoProgramu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontaktyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szukajUżytkownikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oMnieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmienHasloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listContact = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.kontaktyToolStripMenuItem,
            this.oMnieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(245, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem,
            this.wylogujToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.oProgramieToolStripMenuItem_Click);
            // 
            // wylogujToolStripMenuItem
            // 
            this.wylogujToolStripMenuItem.Name = "wylogujToolStripMenuItem";
            this.wylogujToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.wylogujToolStripMenuItem.Text = "Wyloguj";
            this.wylogujToolStripMenuItem.Click += new System.EventHandler(this.wylogujToolStripMenuItem_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // kontaktyToolStripMenuItem
            // 
            this.kontaktyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szukajUżytkownikaToolStripMenuItem});
            this.kontaktyToolStripMenuItem.Name = "kontaktyToolStripMenuItem";
            this.kontaktyToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.kontaktyToolStripMenuItem.Text = "Kontakty";
            // 
            // szukajUżytkownikaToolStripMenuItem
            // 
            this.szukajUżytkownikaToolStripMenuItem.Name = "szukajUżytkownikaToolStripMenuItem";
            this.szukajUżytkownikaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.szukajUżytkownikaToolStripMenuItem.Text = "Szukaj użytkownika";
            this.szukajUżytkownikaToolStripMenuItem.Click += new System.EventHandler(this.szukajUżytkownikaToolStripMenuItem_Click);
            // 
            // oMnieToolStripMenuItem
            // 
            this.oMnieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilToolStripMenuItem,
            this.zmienHasloToolStripMenuItem});
            this.oMnieToolStripMenuItem.Name = "oMnieToolStripMenuItem";
            this.oMnieToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.oMnieToolStripMenuItem.Text = "Moje Konto";
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.profilToolStripMenuItem.Text = "Profil";
            this.profilToolStripMenuItem.Click += new System.EventHandler(this.profilToolStripMenuItem_Click);
            // 
            // zmienHasloToolStripMenuItem
            // 
            this.zmienHasloToolStripMenuItem.Name = "zmienHasloToolStripMenuItem";
            this.zmienHasloToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.zmienHasloToolStripMenuItem.Text = "Zmień hasło";
            this.zmienHasloToolStripMenuItem.Click += new System.EventHandler(this.zmieńHasłoToolStripMenuItem_Click);
            // 
            // listContact
            // 
            this.listContact.FormattingEnabled = true;
            this.listContact.HorizontalScrollbar = true;
            this.listContact.Location = new System.Drawing.Point(12, 27);
            this.listContact.Name = "listContact";
            this.listContact.Size = new System.Drawing.Size(221, 394);
            this.listContact.TabIndex = 1;
            // 
            // OknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 427);
            this.Controls.Add(this.listContact);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OknoProgramu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OknoProgramu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OknoProgramu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OknoProgramu_FormClosed);
            this.Load += new System.EventHandler(this.OknoProgramu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontaktyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szukajUżytkownikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oMnieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmienHasloToolStripMenuItem;
        private System.Windows.Forms.ListBox listContact;
    }
}