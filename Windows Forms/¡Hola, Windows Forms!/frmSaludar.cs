using System.Diagnostics.Tracing;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _Hola__Windows_Forms_
{
    public partial class frmSaludar : Form
    {
        public frmSaludar()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;

            if(Validar())
            {
                frmSaludo frmSaludo1 = new frmSaludo("¡Hola, Windows Forms!", $"Soy {txtNombre.Text} {txtApellido.Text} y mi materia favorita es {cmbMateria.Text}.");
                Hide();

                resultado = frmSaludo1.ShowDialog();

                if (resultado == DialogResult.Cancel)
                {
                    Show();
                }
            }
        }

        private void frmSaludar_Load(object sender, EventArgs e)
        {
            cmbMateria.Items.Add("Programación II");
            cmbMateria.Items.Add("Laboratorio II");
            cmbMateria.Items.Add("Arquitectura y Sistemas Operativos");
            cmbMateria.Items.Add("Estadística");
            cmbMateria.Items.Add("Metodología de Investigación");
            cmbMateria.Items.Add("Inglés II");
            cmbMateria.SelectedIndex = 0;
        }

        private bool Validar()
        {
            bool esValido = true;

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Se deben completar los siguientes campos:");

            if (String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                sb.AppendLine("Nombre");
                esValido = false;
            }
            if (String.IsNullOrWhiteSpace(txtApellido.Text))
            {
                sb.AppendLine("Apellido");
                esValido = false;
            }

            if(!esValido)
            {
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;
        }
    }
}