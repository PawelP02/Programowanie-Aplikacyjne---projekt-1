using System.Windows.Forms;

namespace Konwerter3
{
    public partial class Form1 : Form
    {
       
       


        public Form1()
        {
            InitializeComponent();


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Rodzaj_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rodzaj.SelectedItem == "Odleg³oœæ")
            {
                jednostka1.Items.Clear();
                jednostka2.Items.Clear();
                jednostka1.Items.Add("m");
                jednostka1.Items.Add("km");
                jednostka2.Items.Add("m");
                jednostka2.Items.Add("km");

            }
            if (rodzaj.SelectedItem == "Waga")
            {
                jednostka1.Items.Clear();
                jednostka2.Items.Clear();
                jednostka1.Items.Add("g");
                jednostka1.Items.Add("kg");
                jednostka2.Items.Add("g");
                jednostka2.Items.Add("kg");

            }
            if (rodzaj.SelectedItem == "Objêtoœæ")
            {
                jednostka1.Items.Clear();
                jednostka2.Items.Clear();
                jednostka1.Items.Add("ml");
                jednostka1.Items.Add("l");
                jednostka2.Items.Add("ml");
                jednostka2.Items.Add("l");

            }
        }
    private void Przycisk_Click(object sender, EventArgs e)
        {
            
            if (rodzaj.Text != "")
            {
                if (rodzaj.SelectedItem == "Odleg³oœæ")
                {
                    
                    if (jednostka1.SelectedItem == "m" && jednostka2.SelectedItem == "km")
                    {
                        wynik.Text = (double.Parse(wartosc.Text) * 0.001).ToString();
                    }
                    if (jednostka1.SelectedItem == "km" && jednostka2.SelectedItem == "m")
                    {
                        wynik.Text = (double.Parse(wartosc.Text) * 1000).ToString();
                    }
                    
                }
                if (rodzaj.SelectedItem == "Waga")
                {
                    if (jednostka1.SelectedItem == "g" && jednostka2.SelectedItem == "kg")
                    {
                        wynik.Text = (double.Parse(wartosc.Text) * 0.001).ToString();
                    }
                    if (jednostka1.SelectedItem == "kg" && jednostka2.SelectedItem == "g")
                    {
                        wynik.Text = (double.Parse(wartosc.Text) * 1000).ToString();
                    }
                }
                if (rodzaj.SelectedItem == "Objêtoœæ")
                {
                    if (jednostka1.SelectedItem == "ml" && jednostka2.SelectedItem == "l")
                    {
                        wynik.Text = (double.Parse(wartosc.Text) * 0.001).ToString();
                    }
                    if (jednostka1.SelectedItem == "l" && jednostka2.SelectedItem == "ml")
                    {
                        wynik.Text = (double.Parse(wartosc.Text) * 1000).ToString();
                    }
                }
                wynik.Text = (int.Parse(wartosc.Text) * licznik.Value).ToString();
                licznik.Value = licznik.Minimum;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (rodzaj.SelectedItem == "Odleg³oœæ" && rodzaj2.SelectedItem == "Odleg³oœæ")
            {
                jednostka1.Items.Add(nowa1.Text);
                jednostka2.Items.Add(nowa2.Text);
                nowa1.Clear();
                nowa2.Clear();
            }
            if (rodzaj.SelectedItem == "Waga" && rodzaj2.SelectedItem == "Waga")
            {
                jednostka1.Items.Add(nowa1.Text);
                jednostka2.Items.Add(nowa2.Text);
                nowa1.Clear();
                nowa2.Clear();
            }
            if (rodzaj.SelectedItem == "Objêtoœæ" && rodzaj2.SelectedItem == "Objêtoœæ")
            {
                jednostka1.Items.Add(nowa1.Text);
                jednostka2.Items.Add(nowa2.Text);
                nowa1.Clear();
                nowa2.Clear();
            }
        }
    }
}