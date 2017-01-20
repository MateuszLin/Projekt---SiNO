namespace Komunikator
{
    partial class OknoSzukajKontaktu
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
            this.userView = new System.Windows.Forms.ListView();
            this.Login = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Imie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nazwisko = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Miasto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.Zamknij = new System.Windows.Forms.Button();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.nazwiskoBox = new System.Windows.Forms.TextBox();
            this.imieBox = new System.Windows.Forms.TextBox();
            this.miastoBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.telefonBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Szukaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userView
            // 
            this.userView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Login,
            this.Imie,
            this.Nazwisko,
            this.Miasto,
            this.Email,
            this.Telefon});
            this.userView.FullRowSelect = true;
            this.userView.GridLines = true;
            this.userView.Location = new System.Drawing.Point(12, 149);
            this.userView.Name = "userView";
            this.userView.Size = new System.Drawing.Size(503, 144);
            this.userView.TabIndex = 0;
            this.userView.UseCompatibleStateImageBehavior = false;
            this.userView.View = System.Windows.Forms.View.Details;
            
            // 
            // Login
            // 
            this.Login.Text = "Login";
            // 
            // Imie
            // 
            this.Imie.Text = "Imie";
            this.Imie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Imie.Width = 84;
            // 
            // Nazwisko
            // 
            this.Nazwisko.Text = "Nazwisko";
            this.Nazwisko.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nazwisko.Width = 95;
            // 
            // Miasto
            // 
            this.Miasto.Text = "Miasto";
            this.Miasto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Miasto.Width = 88;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email.Width = 95;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            this.Telefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Telefon.Width = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // Zamknij
            // 
            this.Zamknij.Location = new System.Drawing.Point(431, 17);
            this.Zamknij.Name = "Zamknij";
            this.Zamknij.Size = new System.Drawing.Size(75, 23);
            this.Zamknij.TabIndex = 2;
            this.Zamknij.Text = "Zamknij";
            this.Zamknij.UseVisualStyleBackColor = true;
            this.Zamknij.Click += new System.EventHandler(this.Zamknij_Click_1);
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(86, 19);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(100, 20);
            this.loginBox.TabIndex = 3;
            // 
            // nazwiskoBox
            // 
            this.nazwiskoBox.Location = new System.Drawing.Point(86, 114);
            this.nazwiskoBox.Name = "nazwiskoBox";
            this.nazwiskoBox.Size = new System.Drawing.Size(100, 20);
            this.nazwiskoBox.TabIndex = 4;
            // 
            // imieBox
            // 
            this.imieBox.Location = new System.Drawing.Point(86, 66);
            this.imieBox.Name = "imieBox";
            this.imieBox.Size = new System.Drawing.Size(100, 20);
            this.imieBox.TabIndex = 5;
            // 
            // miastoBox
            // 
            this.miastoBox.Location = new System.Drawing.Point(300, 19);
            this.miastoBox.Name = "miastoBox";
            this.miastoBox.Size = new System.Drawing.Size(100, 20);
            this.miastoBox.TabIndex = 6;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(300, 66);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(100, 20);
            this.emailBox.TabIndex = 7;
            // 
            // telefonBox
            // 
            this.telefonBox.Location = new System.Drawing.Point(300, 114);
            this.telefonBox.Name = "telefonBox";
            this.telefonBox.Size = new System.Drawing.Size(100, 20);
            this.telefonBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Imie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nazwisko";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Miasto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nr. telefonu";
            // 
            // Szukaj
            // 
            this.Szukaj.Location = new System.Drawing.Point(431, 94);
            this.Szukaj.Name = "Szukaj";
            this.Szukaj.Size = new System.Drawing.Size(75, 36);
            this.Szukaj.TabIndex = 14;
            this.Szukaj.Text = "Szukaj";
            this.Szukaj.UseVisualStyleBackColor = true;
            this.Szukaj.Click += new System.EventHandler(this.Szukaj_Click_1);
            // 
            // OknoSzukajKontaktu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 305);
            this.Controls.Add(this.Szukaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.telefonBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.miastoBox);
            this.Controls.Add(this.imieBox);
            this.Controls.Add(this.nazwiskoBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.Zamknij);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userView);
            this.Name = "OknoSzukajKontaktu";
            this.Text = "Szukaj kontaktu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView userView;
        private System.Windows.Forms.ColumnHeader Login;
        private System.Windows.Forms.ColumnHeader Imie;
        private System.Windows.Forms.ColumnHeader Nazwisko;
        private System.Windows.Forms.ColumnHeader Miasto;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Zamknij;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox nazwiskoBox;
        private System.Windows.Forms.TextBox imieBox;
        private System.Windows.Forms.TextBox miastoBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox telefonBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Szukaj;
    }
}