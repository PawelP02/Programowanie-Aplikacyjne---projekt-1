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
            this.jednostka1 = new System.Windows.Forms.ComboBox();
            this.wynik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.przyciskDodawanie = new System.Windows.Forms.Button();
            this.nowaJednostka1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.jednostka2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nowaJednostka2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.przelicznik1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.przelicznik = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.przelicznik)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wpisz wartość";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wybierz jednostkę 1";
            // 
            // przycisk
            // 
            this.przycisk.Location = new System.Drawing.Point(51, 142);
            this.przycisk.Name = "przycisk";
            this.przycisk.Size = new System.Drawing.Size(139, 47);
            this.przycisk.TabIndex = 2;
            this.przycisk.Text = "Przekonwertuj";
            this.przycisk.UseVisualStyleBackColor = true;
            this.przycisk.Click += new System.EventHandler(this.przycisk_Click);
            // 
            // wartosc
            // 
            this.wartosc.Location = new System.Drawing.Point(51, 93);
            this.wartosc.Name = "wartosc";
            this.wartosc.Size = new System.Drawing.Size(100, 23);
            this.wartosc.TabIndex = 3;
            // 
            // jednostka1
            // 
            this.jednostka1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jednostka1.FormattingEnabled = true;
            this.jednostka1.Items.AddRange(new object[] {
            "m"});
            this.jednostka1.Location = new System.Drawing.Point(51, 36);
            this.jednostka1.Name = "jednostka1";
            this.jednostka1.Size = new System.Drawing.Size(82, 23);
            this.jednostka1.TabIndex = 4;
            // 
            // wynik
            // 
            this.wynik.Location = new System.Drawing.Point(143, 240);
            this.wynik.Name = "wynik";
            this.wynik.ReadOnly = true;
            this.wynik.Size = new System.Drawing.Size(206, 23);
            this.wynik.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wynik";
            // 
            // przyciskDodawanie
            // 
            this.przyciskDodawanie.Location = new System.Drawing.Point(181, 397);
            this.przyciskDodawanie.Name = "przyciskDodawanie";
            this.przyciskDodawanie.Size = new System.Drawing.Size(108, 41);
            this.przyciskDodawanie.TabIndex = 7;
            this.przyciskDodawanie.Text = "Dodaj";
            this.przyciskDodawanie.UseVisualStyleBackColor = true;
            this.przyciskDodawanie.Click += new System.EventHandler(this.przyciskDodawanie_Click);
            // 
            // nowaJednostka1
            // 
            this.nowaJednostka1.Location = new System.Drawing.Point(51, 357);
            this.nowaJednostka1.Name = "nowaJednostka1";
            this.nowaJednostka1.Size = new System.Drawing.Size(82, 23);
            this.nowaJednostka1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Własna jednostka 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Wybierz jednostkę 2";
            // 
            // jednostka2
            // 
            this.jednostka2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jednostka2.FormattingEnabled = true;
            this.jednostka2.Items.AddRange(new object[] {
            "km"});
            this.jednostka2.Location = new System.Drawing.Point(177, 36);
            this.jednostka2.Name = "jednostka2";
            this.jednostka2.Size = new System.Drawing.Size(83, 23);
            this.jednostka2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Własna jednostka 2";
            // 
            // nowaJednostka2
            // 
            this.nowaJednostka2.Location = new System.Drawing.Point(181, 356);
            this.nowaJednostka2.Name = "nowaJednostka2";
            this.nowaJednostka2.Size = new System.Drawing.Size(86, 23);
            this.nowaJednostka2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Wybierz przelicznik";
            // 
            // przelicznik1
            // 
            this.przelicznik1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.przelicznik1.FormattingEnabled = true;
            this.przelicznik1.Items.AddRange(new object[] {
            "1000"});
            this.przelicznik1.Location = new System.Drawing.Point(330, 36);
            this.przelicznik1.Name = "przelicznik1";
            this.przelicznik1.Size = new System.Drawing.Size(82, 23);
            this.przelicznik1.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(337, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Własny przelicznik";
            // 
            // przelicznik
            // 
            this.przelicznik.Location = new System.Drawing.Point(343, 357);
            this.przelicznik.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.przelicznik.Name = "przelicznik";
            this.przelicznik.Size = new System.Drawing.Size(94, 23);
            this.przelicznik.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.przelicznik);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.przelicznik1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nowaJednostka2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.jednostka2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nowaJednostka1);
            this.Controls.Add(this.przyciskDodawanie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.jednostka1);
            this.Controls.Add(this.wartosc);
            this.Controls.Add(this.przycisk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Konwerter Jednostek";
            ((System.ComponentModel.ISupportInitialize)(this.przelicznik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button przycisk;
        private TextBox wartosc;
        private ComboBox jednostka1;
        private TextBox wynik;
        private Label label3;
        private Button przyciskDodawanie;
        private TextBox nowaJednostka1;
        private Label label4;
        private Label label5;
        private ComboBox jednostka2;
        private Label label6;
        private TextBox nowaJednostka2;
        private Label label7;
        private ComboBox przelicznik1;
        private Label label8;
        private NumericUpDown przelicznik;
    }
}