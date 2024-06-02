using PokedexClases;

namespace InterfazPokedex
{
    public partial class FrmAlta : Form
    {
        string entrenador;
        OpenFileDialog openFileDialog;
        private string imagen;

        public FrmAlta(string entrenador)
        {
            this.entrenador = entrenador;
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            imagen = string.Empty;
            InitializeComponent();
        }

        private void FrmAlta_Load(object sender, EventArgs e)
        {
            cmbTipos.DataSource = PokemonDAO.LeerTipos();
            txtDireccionImagen.ReadOnly = true;
            txtEntrenador.ReadOnly = true;
            txtEntrenador.Text = entrenador;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imagen = openFileDialog.FileName;

                    txtDireccionImagen.Text = imagen;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) && ValidarNombre(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtDireccionImagen.Text) && nupId.Value > 0 && ValidarId(nupId.Value))
            {
                Pokemon nuevoPokemon = new((int)nupId.Value, txtNombre.Text, cmbTipos.Text, txtEntrenador.Text, txtDireccionImagen.Text);

                PokemonDAO.Guardar(nuevoPokemon);

                DialogResult = DialogResult.OK;

                Close();
            }
            else
            {
                MessageBox.Show("Hubo un error en la validación de datos. Compruebe que todos los datos ingresados son correctos o que ingresó todos los datos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarId(decimal id)
        {
            List<Pokemon> pokemons = PokemonDAO.LeerPokemon();

            foreach (Pokemon pokemon in pokemons)
            {
                if (pokemon.Id == (int)id)
                {
                    return false;
                }
            }

            return true;
        }

        private bool ValidarNombre(string nombre)
        {
            List<Pokemon> pokemons = PokemonDAO.LeerPokemon();

            foreach (Pokemon pokemon in pokemons)
            {
                if (pokemon.Nombre == nombre)
                {
                    return false;
                }
            }

            return true;
        }
    }
}