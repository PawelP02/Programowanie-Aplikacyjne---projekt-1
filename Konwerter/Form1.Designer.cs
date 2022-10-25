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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wpisz wartość";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wybierz jednostkę";
            // 
            // przycisk
            // 
            this.przycisk.Location = new System.Drawing.Point(165, 169);
            this.przycisk.Name = "przycisk";
            this.przycisk.Size = new System.Drawing.Size(139, 47);
            this.przycisk.TabIndex = 2;
            this.przycisk.Text = "Przekonwertuj";
            this.przycisk.UseVisualStyleBackColor = true;
            this.przycisk.Click += new System.EventHandler(this.przycisk_Click);
            // 
            // wartosc
            // 
            this.wartosc.Location = new System.Drawing.Point(69, 106);
            this.wartosc.Name = "wartosc";
            this.wartosc.Size = new System.Drawing.Size(100, 23);
            this.wartosc.TabIndex = 3;
            // 
            // jednostki
            // 
            this.jednostki.FormattingEnabled = true;
            this.jednostki.Items.AddRange(new object[] {
            "\"m\" na \"km\"",
            "\"g\" na \"kg\""});
            this.jednostki.Location = new System.Drawing.Point(292, 106);
            this.jednostki.Name = "jednostki";
            this.jednostki.Size = new System.Drawing.Size(121, 23);
            this.jednostki.TabIndex = 4;
            // 
            // wynik
            // 
            this.wynik.Location = new System.Drawing.Point(124, 266);
            this.wynik.Name = "wynik";
            this.wynik.ReadOnly = true;
            this.wynik.Size = new System.Drawing.Size(221, 23);
            this.wynik.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wynik";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
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
    }
}