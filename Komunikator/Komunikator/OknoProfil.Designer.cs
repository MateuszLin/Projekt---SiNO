namespace Komunikator
{
    partial class OknoProfil
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Zastosuj = new System.Windows.Forms.Button();
            this.Anuluj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.imieBox = new System.Windows.Forms.TextBox();
            this.nazwiskoBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.telefonBox = new System.Windows.Forms.TextBox();
            this.miastoBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Imie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nazwisko";
            // 
            // Zastosuj
            // 
            this.Zastosuj.Location = new System.Drawing.Point(233, 222);
            this.Zastosuj.Name = "Zastosuj";
            this.Zastosuj.Size = new System.Drawing.Size(87, 30);
            this.Zastosuj.TabIndex = 3;
            this.Zastosuj.Text = "Zastosuj";
            this.Zastosuj.UseVisualStyleBackColor = true;
            this.Zastosuj.Click += new System.EventHandler(this.Zastosuj_Click);
            // 
            // Anuluj
            // 
            this.Anuluj.Location = new System.Drawing.Point(374, 222);
            this.Anuluj.Name = "Anuluj";
            this.Anuluj.Size = new System.Drawing.Size(83, 30);
            this.Anuluj.TabIndex = 4;
            this.Anuluj.Text = "Anuluj";
            this.Anuluj.UseVisualStyleBackColor = true;
            this.Anuluj.Click += new System.EventHandler(this.Anuluj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Miasto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "NrTelefonu";
            // 
            // imieBox
            // 
            this.imieBox.Location = new System.Drawing.Point(67, 39);
            this.imieBox.Name = "imieBox";
            this.imieBox.Size = new System.Drawing.Size(100, 20);
            this.imieBox.TabIndex = 1;
            // 
            // nazwiskoBox
            // 
            this.nazwiskoBox.Location = new System.Drawing.Point(67, 106);
            this.nazwiskoBox.Name = "nazwiskoBox";
            this.nazwiskoBox.Size = new System.Drawing.Size(100, 20);
            this.nazwiskoBox.TabIndex = 2;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(350, 106);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(100, 20);
            this.emailBox.TabIndex = 4;
            // 
            // telefonBox
            // 
            this.telefonBox.Location = new System.Drawing.Point(220, 160);
            this.telefonBox.Name = "telefonBox";
            this.telefonBox.Size = new System.Drawing.Size(100, 20);
            this.telefonBox.TabIndex = 5;
            // 
            // miastoBox
            // 
            this.miastoBox.Location = new System.Drawing.Point(350, 39);
            this.miastoBox.Name = "miastoBox";
            this.miastoBox.Size = new System.Drawing.Size(100, 20);
            this.miastoBox.TabIndex = 3;
            // 
            // OknoProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 269);
            this.Controls.Add(this.miastoBox);
            this.Controls.Add(this.telefonBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.nazwiskoBox);
            this.Controls.Add(this.imieBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Anuluj);
            this.Controls.Add(this.Zastosuj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "OknoProfil";
            this.Text = "Profil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Zastosuj;
        private System.Windows.Forms.Button Anuluj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox imieBox;
        private System.Windows.Forms.TextBox nazwiskoBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox telefonBox;
        private System.Windows.Forms.TextBox miastoBox;
    }
}