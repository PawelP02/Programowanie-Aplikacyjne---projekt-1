namespace Konwerter3
{
    partial class Form2
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
            this.dodawanie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nowa1 = new System.Windows.Forms.TextBox();
            this.nowa2 = new System.Windows.Forms.TextBox();
            this.przelicznik2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.przelicznik2)).BeginInit();
            this.SuspendLayout();
            // 
            // dodawanie
            // 
            this.dodawanie.Location = new System.Drawing.Point(116, 203);
            this.dodawanie.Name = "dodawanie";
            this.dodawanie.Size = new System.Drawing.Size(118, 43);
            this.dodawanie.TabIndex = 0;
            this.dodawanie.Text = "Dodaj";
            this.dodawanie.UseVisualStyleBackColor = true;
            this.dodawanie.Click += new System.EventHandler(this.dodawanie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jednostka 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jednostka 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Przelicznik";
            // 
            // nowa1
            // 
            this.nowa1.Location = new System.Drawing.Point(23, 90);
            this.nowa1.Name = "nowa1";
            this.nowa1.Size = new System.Drawing.Size(100, 23);
            this.nowa1.TabIndex = 4;
            // 
            // nowa2
            // 
            this.nowa2.Location = new System.Drawing.Point(134, 89);
            this.nowa2.Name = "nowa2";
            this.nowa2.Size = new System.Drawing.Size(100, 23);
            this.nowa2.TabIndex = 5;
            // 
            // przelicznik2
            // 
            this.przelicznik2.Location = new System.Drawing.Point(257, 90);
            this.przelicznik2.Name = "przelicznik2";
            this.przelicznik2.Size = new System.Drawing.Size(89, 23);
            this.przelicznik2.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 345);
            this.Controls.Add(this.przelicznik2);
            this.Controls.Add(this.nowa2);
            this.Controls.Add(this.nowa1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dodawanie);
            this.Name = "Form2";
            this.Text = "Menu dodawania jednostek";
            ((System.ComponentModel.ISupportInitialize)(this.przelicznik2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button dodawanie;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox nowa1;
        private TextBox nowa2;
        private NumericUpDown przelicznik2;
    }
}