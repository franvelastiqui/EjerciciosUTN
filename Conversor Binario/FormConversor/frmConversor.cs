using Entidades;

namespace FormConversor
{
    public partial class frmConversor : Form
    {
        public frmConversor()
        {
            InitializeComponent();
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            NumeroBinario nb;

            nb = txtBinarioA.Text;

            txtADecimal.Text = (Conversor.ConvertirBinarioADecimal(nb.Numero())).ToString();
        }

        private void btnDecimalA_Click(object sender, EventArgs e)
        {
            NumeroDecimal nd;

            nd = double.Parse(txtDecimalA.Text);

            txtABinario.Text = Conversor.ConvertirDecimalABinario(nd.Numero());
        }
    }
}