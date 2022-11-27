using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konwerter3
{
    public partial class Form2 : Form
    {
        private string text;
        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public Form2()
        {
            InitializeComponent();

            

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = Text;
        }


        public void dodawanie_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
