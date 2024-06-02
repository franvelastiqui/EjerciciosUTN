using Entidades;

namespace FormTemperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFahrenheitA_Click(object sender, EventArgs e)
        {
            Fahrenheit f;

            f = double.Parse(txtFahrenheit.Text);

            txtFahAFah.Text = f.GetTemperatura().ToString();
            txtFahACel.Text = ((Celsius)f).GetTemperatura().ToString();
            txtFahAKel.Text = ((Kelvin)f).GetTemperatura().ToString();
        }

        private void btnCelsiusA_Click(object sender, EventArgs e)
        {
            Celsius c;

            c = double.Parse(txtFahrenheit.Text);

            txtCelAFah.Text = ((Fahrenheit)c).GetTemperatura().ToString();
            txtCelACel.Text = c.GetTemperatura().ToString();
            txtCelAKel.Text = ((Kelvin)c).GetTemperatura().ToString();
        }

        private void btnKelvinA_Click(object sender, EventArgs e)
        {
            Kelvin k;

            k = double.Parse(txtFahrenheit.Text);

            txtKelAFah.Text = ((Fahrenheit)k).GetTemperatura().ToString();
            txtKelACel.Text = ((Celsius)k).GetTemperatura().ToString();
            txtKelAKel.Text = k.GetTemperatura().ToString();
        }
    }
}