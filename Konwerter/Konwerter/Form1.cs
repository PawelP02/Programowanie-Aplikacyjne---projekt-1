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
            this.wynik.Text += "Wpisz warto�ci do przekonwertowania";
        }

        private void przyciskDodawanie_Click(object sender, EventArgs e)
        {
            jednostki.Items.Add(noweJednostki.Text);
        }
    }
}