namespace Konwerter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.przycisk = new System.Windows.Forms.Button();
            this.wartosc = new System.Windows.Forms.TextBox();
            this.jednostki = new System.Windows.Forms.ComboBox();
            this.wynik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.przyciskDodawanie = new System.Windows.Forms.Button();
            this.noweJednostki = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wpisz wartość";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wybierz jednostkę";
            // 
            // przycisk
            // 
            this.przycisk.Location = new System.Drawing.Point(51, 108);
            this.przycisk.Name = "przycisk";
            this.przycisk.Size = new System.Drawing.Size(139, 47);
            this.przycisk.TabIndex = 2;
            this.przycisk.Text = "Przekonwertuj";
            this.przycisk.UseVisualStyleBackColor = true;
            this.przycisk.Click += new System.EventHandler(this.przycisk_Click);
            // 
            // wartosc
            // 
            this.wartosc.Location = new System.Drawing.Point(51, 46);
            this.wartosc.Name = "wartosc";
            this.wartosc.Size = new System.Drawing.Size(100, 23);
            this.wartosc.TabIndex = 3;
            // 
            // jednostki
            // 
            this.jednostki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jednostki.FormattingEnabled = true;
            this.jednostki.Items.AddRange(new object[] {
            "\"m\" na \"km\"",
            "\"g\" na \"kg\""});
            this.jednostki.Location = new System.Drawing.Point(274, 46);
            this.jednostki.Name = "jednostki";
            this.jednostki.Size = new System.Drawing.Size(121, 23);
            this.jednostki.TabIndex = 4;
            // 
            // wynik
            // 
            this.wynik.Location = new System.Drawing.Point(51, 191);
            this.wynik.Name = "wynik";
            this.wynik.ReadOnly = true;
            this.wynik.Size = new System.Drawing.Size(206, 23);
            this.wynik.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wynik";
            // 
            // przyciskDodawanie
            // 
            this.przyciskDodawanie.Location = new System.Drawing.Point(51, 353);
            this.przyciskDodawanie.Name = "przyciskDodawanie";
            this.przyciskDodawanie.Size = new System.Drawing.Size(108, 41);
            this.przyciskDodawanie.TabIndex = 7;
            this.przyciskDodawanie.Text = "Dodaj jednostki";
            this.przyciskDodawanie.UseVisualStyleBackColor = true;
            this.przyciskDodawanie.Click += new System.EventHandler(this.przyciskDodawanie_Click);
            // 
            // noweJednostki
            // 
            this.noweJednostki.Location = new System.Drawing.Point(51, 324);
            this.noweJednostki.Name = "noweJednostki";
            this.noweJednostki.Size = new System.Drawing.Size(161, 23);
            this.noweJednostki.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Własne jednostki";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.noweJednostki);
            this.Controls.Add(this.przyciskDodawanie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.jednostki);
            this.Controls.Add(this.wartosc);
            this.Controls.Add(this.przycisk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Konwerter Jednostek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button przycisk;
        private TextBox wartosc;
        private ComboBox jednostki;
        private TextBox wynik;
        private Label label3;
        private Button przyciskDodawanie;
        private TextBox noweJednostki;
        private Label label4;
    }
}