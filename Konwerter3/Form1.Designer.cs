namespace Konwerter3
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
            this.Przycisk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.wynik = new System.Windows.Forms.TextBox();
            this.wartosc = new System.Windows.Forms.TextBox();
            this.jednostka1 = new System.Windows.Forms.ComboBox();
            this.jednostka2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nowa1 = new System.Windows.Forms.TextBox();
            this.nowa2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rodzaj = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.licznik = new System.Windows.Forms.NumericUpDown();
            this.rodzaj2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.licznik)).BeginInit();
            this.SuspendLayout();
            // 
            // Przycisk
            // 
            this.Przycisk.Location = new System.Drawing.Point(108, 274);
            this.Przycisk.Name = "Przycisk";
            this.Przycisk.Size = new System.Drawing.Size(124, 37);
            this.Przycisk.TabIndex = 0;
            this.Przycisk.Text = "Konwertuj";
            this.Przycisk.UseVisualStyleBackColor = true;
            this.Przycisk.Click += new System.EventHandler(this.Przycisk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wynik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wybierz 1 jednostkę";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Wybierz 2 jednostkę";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Wpisz wartość";
            // 
            // wynik
            // 
            this.wynik.Enabled = false;
            this.wynik.Location = new System.Drawing.Point(90, 337);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(160, 23);
            this.wynik.TabIndex = 5;
            // 
            // wartosc
            // 
            this.wartosc.Location = new System.Drawing.Point(90, 245);
            this.wartosc.Name = "wartosc";
            this.wartosc.Size = new System.Drawing.Size(160, 23);
            this.wartosc.TabIndex = 6;
            // 
            // jednostka1
            // 
            this.jednostka1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jednostka1.FormattingEnabled = true;
            this.jednostka1.Location = new System.Drawing.Point(12, 102);
            this.jednostka1.Name = "jednostka1";
            this.jednostka1.Size = new System.Drawing.Size(67, 23);
            this.jednostka1.TabIndex = 7;
            // 
            // jednostka2
            // 
            this.jednostka2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jednostka2.FormattingEnabled = true;
            this.jednostka2.Location = new System.Drawing.Point(240, 102);
            this.jednostka2.Name = "jednostka2";
            this.jednostka2.Size = new System.Drawing.Size(67, 23);
            this.jednostka2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nowa1
            // 
            this.nowa1.Location = new System.Drawing.Point(494, 120);
            this.nowa1.Name = "nowa1";
            this.nowa1.Size = new System.Drawing.Size(100, 23);
            this.nowa1.TabIndex = 10;
            // 
            // nowa2
            // 
            this.nowa2.Location = new System.Drawing.Point(494, 190);
            this.nowa2.Name = "nowa2";
            this.nowa2.Size = new System.Drawing.Size(100, 23);
            this.nowa2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Dodawanie jednostek";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nowa jednostka 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(494, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nowa jednostka 2";
            // 
            // rodzaj
            // 
            this.rodzaj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rodzaj.FormattingEnabled = true;
            this.rodzaj.Items.AddRange(new object[] {
            "Odległość",
            "Waga",
            "Objętość"});
            this.rodzaj.Location = new System.Drawing.Point(12, 38);
            this.rodzaj.Name = "rodzaj";
            this.rodzaj.Size = new System.Drawing.Size(85, 23);
            this.rodzaj.TabIndex = 20;
            this.rodzaj.SelectedIndexChanged += new System.EventHandler(this.Rodzaj_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Wybierz rodzaj jednostek";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Wpisz przelicznik dla własnych jednostek";
            // 
            // licznik
            // 
            this.licznik.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.licznik.Location = new System.Drawing.Point(108, 181);
            this.licznik.Name = "licznik";
            this.licznik.Size = new System.Drawing.Size(120, 23);
            this.licznik.TabIndex = 19;
            // 
            // rodzaj2
            // 
            this.rodzaj2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rodzaj2.FormattingEnabled = true;
            this.rodzaj2.Items.AddRange(new object[] {
            "Odległość",
            "Waga",
            "Objętość"});
            this.rodzaj2.Location = new System.Drawing.Point(494, 38);
            this.rodzaj2.Name = "rodzaj2";
            this.rodzaj2.Size = new System.Drawing.Size(86, 23);
            this.rodzaj2.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 408);
            this.Controls.Add(this.rodzaj2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rodzaj);
            this.Controls.Add(this.licznik);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nowa2);
            this.Controls.Add(this.nowa1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.jednostka2);
            this.Controls.Add(this.jednostka1);
            this.Controls.Add(this.wartosc);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Przycisk);
            this.Name = "Form1";
            this.Text = "Konwerter jednostek";
            ((System.ComponentModel.ISupportInitialize)(this.licznik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Przycisk;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox wynik;
        private TextBox wartosc;
        private ComboBox jednostka1;
        private ComboBox jednostka2;
        private Button button1;
        private TextBox nowa1;
        private TextBox nowa2;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox rodzaj;
        private Label label10;
        private Label label9;
        private NumericUpDown licznik;
        private ComboBox rodzaj2;
    }
}