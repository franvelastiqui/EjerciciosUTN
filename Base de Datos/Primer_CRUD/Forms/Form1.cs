using Entidades;

namespace Forms
{
    public partial class frmPersona : Form
    {
        public frmPersona()
        {
            InitializeComponent();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            lstPersonas.DataSource = PersonaDAO.Leer();
        }

        private void lstPersonas_DoubleClick(object sender, EventArgs e)
        {
            if (lstPersonas.SelectedItem is not null)
            {
                txtNombre.Text = ((Persona)lstPersonas.SelectedItem).Nombre;
                txtApellido.Text = ((Persona)lstPersonas.SelectedItem).Apellido;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstPersonas.SelectedItem is not null)
            {
                string nuevoNombre = "";
                string nuevoApellido = "";

                ChequearTextBox(ref nuevoNombre, ref nuevoApellido);

                int idAModificar = ((Persona)lstPersonas.SelectedItem).Id;
                Persona nuevaPersona = new(idAModificar, nuevoNombre, nuevoApellido);
                PersonaDAO.Modificar(nuevaPersona);

                lstPersonas.DataSource = PersonaDAO.Leer();
            }
        }

        private void ChequearTextBox(ref string nombre, ref string apellido)
        {
            if (String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                nombre = ((Persona)lstPersonas.SelectedItem).Nombre;
            }
            else
            {
                nombre = txtNombre.Text;
            }

            if (String.IsNullOrWhiteSpace(txtApellido.Text))
            {
                apellido = ((Persona)lstPersonas.SelectedItem).Apellido;
            }
            else
            {
                apellido = txtApellido.Text;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtNombre.Text) && !String.IsNullOrWhiteSpace(txtApellido.Text))
            {
                Persona persona = new(txtNombre.Text, txtApellido.Text);

                PersonaDAO.Guardar(persona);

                lstPersonas.DataSource = PersonaDAO.Leer();
            }
        }

        private void bntEliminar_Click(object sender, EventArgs e)
        {
            if (lstPersonas.SelectedItem is not null)
            {
                int idAEliminar = ((Persona)lstPersonas.SelectedItem).Id;
                PersonaDAO.Borrar(idAEliminar);

                lstPersonas.DataSource = PersonaDAO.Leer();
            }
        }
    }
}