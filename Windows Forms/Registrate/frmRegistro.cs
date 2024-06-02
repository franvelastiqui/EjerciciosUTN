using Entidades;

namespace Registrate
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            lstbPaises.Items.Add("Argentina");
            lstbPaises.Items.Add("Chile");
            lstbPaises.Items.Add("Uruguay");
            lstbPaises.SelectedIndex = 0;
            rbMasc.Checked = true;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Ingresante alumno;
            DialogResult resultado;

            if (Validar())
            {
                string nombre = txtNombre.Text;
                string direccion = txtDireccion.Text;
                int edad = (int)nupEdad.Value;
                string pais = lstbPaises.SelectedItem.ToString();

                string genero = "";
                foreach (Control c in gbGenero.Controls)
                {
                    if (c is RadioButton && ((RadioButton)c).Checked)
                    {
                        genero = ((RadioButton)c).Text;
                    }
                }

                string[] cursos = new string[0];
                foreach (Control c in gbCursos.Controls)
                {
                    if (c is CheckBox && ((CheckBox)c).Checked)
                    {
                        Array.Resize<string>(ref cursos, cursos.Length + 1);
                        cursos[cursos.Length - 1] = ((CheckBox)c).Text;
                    }
                }

                alumno = new(nombre, direccion, genero, pais, cursos, edad);

                Hide();

                resultado = MessageBox.Show(alumno.Mostrar());

                if (resultado == DialogResult.OK)
                {
                    Show();
                }
            }

        }

        private bool Validar()
        {
            bool esValido = true;

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) || nupEdad.Value == 0)
            {
                esValido = false;
            }

            if (!esValido)
            {
                MessageBox.Show("Ingrese todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;
        }
    }
}