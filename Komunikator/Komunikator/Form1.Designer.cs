namespace Komunikator
{
    partial class Form1
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
            this.buttonWyslij = new System.Windows.Forms.Button();
            this.buttonOdbierz = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonWyslij
            // 
            this.buttonWyslij.Location = new System.Drawing.Point(294, 168);
            this.buttonWyslij.Name = "buttonWyslij";
            this.buttonWyslij.Size = new System.Drawing.Size(75, 23);
            this.buttonWyslij.TabIndex = 0;
            this.buttonWyslij.Text = "Wyślij";
            this.buttonWyslij.UseVisualStyleBackColor = true;
            this.buttonWyslij.Click += new System.EventHandler(this.buttonWyslij_Click);
            // 
            // buttonOdbierz
            // 
            this.buttonOdbierz.Location = new System.Drawing.Point(294, 126);
            this.buttonOdbierz.Name = "buttonOdbierz";
            this.buttonOdbierz.Size = new System.Drawing.Size(75, 23);
            this.buttonOdbierz.TabIndex = 1;
            this.buttonOdbierz.Text = "Odbierz";
            this.buttonOdbierz.UseVisualStyleBackColor = true;
            this.buttonOdbierz.Click += new System.EventHandler(this.buttonOdbierz_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 168);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 75);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(12, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(276, 137);
            this.textBox2.TabIndex = 3;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(303, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 261);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonOdbierz);
            this.Controls.Add(this.buttonWyslij);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWyslij;
        private System.Windows.Forms.Button buttonOdbierz;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonExit;
    }
}

