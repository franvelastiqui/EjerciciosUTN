using Billetes;

namespace FormCotizador
{
    public partial class frmConversor : Form
    {
        public frmConversor()
        {
            InitializeComponent();
        }

        private void frmConversor_Load(object sender, EventArgs e)
        {
            txtCotDolar.Enabled = false;
            txtCotEuro.Enabled = false;
            txtCotPeso.Enabled = false;
            txtCotDolar.Text = "1";
            txtCotEuro.Text = Euro.GetCotizacion().ToString();
            txtCotPeso.Text = Peso.GetCotizacion().ToString();

            txtEuroEuro.ReadOnly = true;
            txtEuroDolar.ReadOnly = true;
            txtEuroPeso.ReadOnly = true;
            txtDolarEuro.ReadOnly = true;
            txtDolarDolar.ReadOnly = true;
            txtDolarPeso.ReadOnly = true;
            txtPesoEuro.ReadOnly = true;
            txtPesoDolar.ReadOnly = true;
            txtPesoPeso.ReadOnly = true;
        }

        private void btnEuroA_Click(object sender, EventArgs e)
        {
            double cantidad = 0;

            _ = double.TryParse(txtEuro.Text, out cantidad);
            Euro euro = cantidad;

            euro.SetCotizacion(double.Parse(txtCotEuro.Text));

            txtEuroEuro.Text = euro.GetCantidad().ToString();
            txtEuroDolar.Text = ((Dolar)euro).GetCantidad().ToString();
            txtEuroPeso.Text = ((Peso)euro).GetCantidad().ToString();
        }

        private void btnDolarA_Click(object sender, EventArgs e)
        {
            double cantidad = 0;

            _ = double.TryParse(txtDolar.Text, out cantidad);
            Dolar dolar = cantidad;

            txtDolarEuro.Text = ((Euro)dolar).GetCantidad().ToString();
            txtDolarDolar.Text = dolar.GetCantidad().ToString();
            txtDolarPeso.Text = ((Peso)dolar).GetCantidad().ToString();
        }

        private void btnPesoA_Click(object sender, EventArgs e)
        {
            double cantidad = 0;

            _ = double.TryParse(txtPeso.Text, out cantidad);
            Peso peso = cantidad;

            peso.SetCotizacion(double.Parse(txtCotPeso.Text));

            txtPesoEuro.Text = ((Euro)peso).GetCantidad().ToString();
            txtPesoDolar.Text = ((Dolar)peso).GetCantidad().ToString();
            txtPesoPeso.Text = peso.GetCantidad().ToString();
        }

        private void btnCotizador_Click(object sender, EventArgs e)
        {
            if (btnCotizador.ImageIndex == 0)
            {
                btnCotizador.ImageIndex = 1;
                txtCotDolar.Enabled = true;
                txtCotEuro.Enabled = true;
                txtCotPeso.Enabled = true;
            }
            else
            {
                btnCotizador.ImageIndex = 0;
                txtCotDolar.Enabled = false;
                txtCotEuro.Enabled = false;
                txtCotPeso.Enabled = false;
            }
        }

        private void txtCotDolar_Leave(object sender, EventArgs e)
        {
            if (txtCotDolar.Text != "1")
            {
                txtCotDolar.Text = "1";
            }
        }

        private void txtCotEuro_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(txtCotEuro.Text, out double d))
            {
                btnCotizador.Enabled = false;
                btnDolarA.Enabled = false;
                btnEuroA.Enabled = false;
                btnPesoA.Enabled = false;
                txtCotEuro.Focus();
            }
            else
            {
                btnCotizador.Enabled = true;
                btnDolarA.Enabled = true;
                btnEuroA.Enabled = true;
                btnPesoA.Enabled = true;
            }
        }

        private void txtCotPeso_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(txtCotEuro.Text, out double d))
            {
                btnCotizador.Enabled = false;
                btnDolarA.Enabled = false;
                btnEuroA.Enabled = false;
                btnPesoA.Enabled = false;
                txtCotEuro.Focus();
            }
            else
            {
                btnCotizador.Enabled = true;
                btnDolarA.Enabled = true;
                btnEuroA.Enabled = true;
                btnPesoA.Enabled = true;
            }
        }
    }
}