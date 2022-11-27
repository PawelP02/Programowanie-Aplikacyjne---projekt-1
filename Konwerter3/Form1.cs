using System.Windows.Forms;

namespace Konwerter3
{
    public partial class Form1 : Form
    {
       
       


        public Form1()
        {
            InitializeComponent();
           

        }

        private void Przycisk_Click(object sender, EventArgs e)
        {
            if(jednostka1.SelectedItem == "m" && jednostka2.SelectedItem == "km")
            {
                wynik.Text = (double.Parse(wartosc.Text) * 0.001).ToString();
            }         
            if (jednostka1.SelectedItem == "g" && jednostka2.SelectedItem == "kg")
            {
                wynik.Text = (double.Parse(wartosc.Text) * 0.001).ToString();
            }            
            if (jednostka1.SelectedItem == "ml" && jednostka2.SelectedItem == "l")
            {
                wynik.Text = (double.Parse(wartosc.Text) * 0.001).ToString();
            }
            if (jednostka1.SelectedItem == "km" && jednostka2.SelectedItem == "m")
            {
                wynik.Text = (double.Parse(wartosc.Text) * 1000).ToString();
            }
            if (jednostka1.SelectedItem == "kg" && jednostka2.SelectedItem == "g")
            {
                wynik.Text = (double.Parse(wartosc.Text) * 1000).ToString();
            }
            if (jednostka1.SelectedItem == "l" && jednostka2.SelectedItem == "ml")
            {
                wynik.Text = (double.Parse(wartosc.Text) * 1000).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jednostka1.Items.Add(nowa1.Text);
            jednostka2.Items.Add(nowa2.Text);
            
            nowa1.Clear();
            nowa2.Clear();
            
        }
    }
}