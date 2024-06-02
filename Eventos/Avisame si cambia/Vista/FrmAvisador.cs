using Entidades;

namespace Vista
{
    public partial class FrmAvisador : Form
    {
        Persona persona;
        public FrmAvisador()
        {
            InitializeComponent();
        }

        public static void NotificarCambio(string cambio)
        {
            MessageBox.Show(cambio);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (persona is null)
            {
                persona = new Persona();

                persona.EventoString += NotificarCambio;

                persona.Nombre = txtNombre.Text;
                persona.Apellido = txtApellido.Text;

                btnCrear.Text = "Actualizar";

            }
            else
            {
                persona.Nombre = txtNombre.Text;
                persona.Apellido = txtApellido.Text;
            }

            lblNombreCompleto.Text = persona.Mostrar();
        }
    }
}