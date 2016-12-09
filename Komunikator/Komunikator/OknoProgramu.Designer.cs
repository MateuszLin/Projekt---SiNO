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
            this.rozmowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontaktyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szukajUżytkownikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oMnieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńHasłoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.rozmowaToolStripMenuItem,
            this.oProgramieToolStripMenuItem,
            this.wylogujToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // rozmowaToolStripMenuItem
            // 
            this.rozmowaToolStripMenuItem.Name = "rozmowaToolStripMenuItem";
            this.rozmowaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rozmowaToolStripMenuItem.Text = "Rozmowa";
            this.rozmowaToolStripMenuItem.Click += new System.EventHandler(this.rozmowaToolStripMenuItem_Click);
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.oProgramieToolStripMenuItem_Click);
            // 
            // wylogujToolStripMenuItem
            // 
            this.wylogujToolStripMenuItem.Name = "wylogujToolStripMenuItem";
            this.wylogujToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.wylogujToolStripMenuItem.Text = "Wyloguj";
            this.wylogujToolStripMenuItem.Click += new System.EventHandler(this.wylogujToolStripMenuItem_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            // 
            // oMnieToolStripMenuItem
            // 
            this.oMnieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilToolStripMenuItem,
            this.zmieńHasłoToolStripMenuItem});
            this.oMnieToolStripMenuItem.Name = "oMnieToolStripMenuItem";
            this.oMnieToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.oMnieToolStripMenuItem.Text = "Moje Konto";
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.profilToolStripMenuItem.Text = "Profil";
            // 
            // zmieńHasłoToolStripMenuItem
            // 
            this.zmieńHasłoToolStripMenuItem.Name = "zmieńHasłoToolStripMenuItem";
            this.zmieńHasłoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.zmieńHasłoToolStripMenuItem.Text = "Zmień hasło";
            // 
            // OknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 427);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OknoProgramu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OknoProgramu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rozmowaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontaktyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szukajUżytkownikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oMnieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmieńHasłoToolStripMenuItem;
    }
}