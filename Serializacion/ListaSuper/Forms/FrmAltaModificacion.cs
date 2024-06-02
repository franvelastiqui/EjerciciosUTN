namespace Forms
{
    public partial class FrmAltaModificacion : Form
    {

        public FrmAltaModificacion(string titulo, string contenidoTextBox,
            string textoBotonConfirmar)
        {
            InitializeComponent();

            Text = titulo;
            txtObjeto.Text = contenidoTextBox;
            btnConfirmar.Text = textoBotonConfirmar;
        }

        public string Objeto
        {
            get
            {
                return txtObjeto.Text;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Confirmar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void txtObjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Confirmar();
            }
            else if (e.KeyChar == (char)27)
            {
                Cancelar();
            }
        }

        private void Confirmar()
        {
            if (!String.IsNullOrWhiteSpace(txtObjeto.Text))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("El texto no puede estar vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Cancelar()
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}