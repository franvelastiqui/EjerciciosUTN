using Entidades;

namespace Forms
{
    public partial class frmAlta : Form
    {
        int codigoJuego;
        public frmAlta(int codigoJuego) : this()
        {
            btnGuardar.Text = "Modificar";
            cmbUsuarios.Hide();
            lblUsuarios.Text = string.Empty;
            nupPrecio.Maximum = 10000;
            this.codigoJuego = codigoJuego;
            PintarForm();
        }

        private void PintarForm()
        {
            Juego juego = JuegoDAO.LeerPorId(codigoJuego);

            txtNombre.Text = juego.Nombre;
            txtGenero.Text = juego.Genero;
            nupPrecio.Value = (decimal)juego.Precio;
        }
        public frmAlta()
        {
            InitializeComponent();
        }

        private void FrmAlta_Load(object sender, EventArgs e)
        {
            try
            {
                cmbUsuarios.DataSource = UsuarioDAO.Leer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected virtual void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            string nombreJuego = txtNombre.Text;
            string genero = txtGenero.Text;
            double precio = (double)nupPrecio.Value;
            int codigoUsuario = ((Usuario)cmbUsuarios.SelectedItem).CodigoUsuario;

            if (btnGuardar.Text != "Modificar")
            {
                Juego juego = new(nombreJuego, precio, genero, codigoUsuario);

                JuegoDAO.Guardar(juego);
            }
            else
            {
                Juego juego = new(nombreJuego, precio, genero, codigoJuego, codigoUsuario);

                JuegoDAO.Modificar(juego);
            }
        }
    }
}