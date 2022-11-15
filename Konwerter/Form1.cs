using System;
using System.Windows.Forms;
namespace Konwerter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void przycisk_Click(object sender, EventArgs e)
        {
            this.wynik.Text += "Wpisz wartoœci do przekonwertowania";
        }
     

        private void przyciskDodawanie_Click(object sender, EventArgs e)
        {
            jednostka1.Items.Add(nowaJednostka1.Text);
            jednostka2.Items.Add(nowaJednostka2.Text);
            przelicznik1.Items.Add(przelicznik.Text);
            nowaJednostka1.Clear();
            nowaJednostka2.Clear();
            przelicznik.Value = przelicznik.Minimum;
        }
    }
}