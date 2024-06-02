using PokedexClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazPokedex
{
    public partial class FrmPrincipal : Form
    {
        string entrenador;
        List<Pokemon> pokemonList;
        string tipoLista;
        Pokemon pokemonEnUI;
        int rangoMenor;
        int rangoMayor;

        public FrmPrincipal(string entrenador)
        {
            pokemonList = new List<Pokemon>();
            this.entrenador = entrenador;
            pokemonEnUI = null;

            InitializeComponent();
        }

        public List<Pokemon> PokemonList { get => pokemonList; }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblEntrenador.Text = entrenador;

            imageList1.ImageSize = picEntrenador.Size;

            imageList1.Images.Add(new Bitmap("..\\..\\..\\..\\Media\\AshPerfil.jpg"));
            imageList1.Images.Add(new Bitmap("..\\..\\..\\..\\Media\\BrockPerfil.jpg"));
            imageList1.Images.Add(new Bitmap("..\\..\\..\\..\\Media\\MistyPerfil.jpg"));

            switch (entrenador)
            {
                case "Ash":
                    picEntrenador.Image = imageList1.Images[0];
                    break;
                case "Brock":
                    picEntrenador.Image = imageList1.Images[1];
                    break;
                case "Misty":
                    picEntrenador.Image = imageList1.Images[2];
                    break;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            pokemonEnUI = null;

            if (!string.IsNullOrWhiteSpace(txtBusqueda.Text))
            {

                if(int.TryParse(txtBusqueda.Text, out int n))
                {
                    pokemonEnUI = PokemonDAO.LeerPokemonPorId(n);
                }
                else
                {
                    pokemonEnUI = PokemonDAO.LeerPokemonPorNombre(txtBusqueda.Text);
                }
            }

            if(pokemonEnUI is not null)
            {
                CargarDatosEnUI(pokemonEnUI);

                pokemonList.Clear();
                pokemonList.Add(pokemonEnUI);

                lblNumeroRegistros.Text = "1";

                VerificarFlechas();

                tipoLista = string.Empty;
            }
            else
            {
                MessageBox.Show("No se encontró el pokemon", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnPorEntrenador_Click(object sender, EventArgs e)
        {
            FrmFiltro buscarPorEntrenador = new("entrenador");

            if(buscarPorEntrenador.ShowDialog() == DialogResult.OK)
            {
                pokemonList = buscarPorEntrenador.Pokemons;

                CargarDatosEnUI(pokemonList[0]);

                lblNumeroRegistros.Text = (pokemonList.Count).ToString();

                VerificarFlechas();

                tipoLista = "entrenador";
            }
        }


        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            pokemonEnUI = PokemonDAO.LeerPokemonPorId(Convert.ToInt32(lblId.Text));
            int indiceActual = -1;

            foreach(Pokemon pokemon in pokemonList)
            {
                if(pokemon.Id == pokemonEnUI.Id)
                {
                    indiceActual = pokemonList.IndexOf(pokemon);
                }
            }

            if(pokemonList.Count != indiceActual + 1)
            {
                pokemonEnUI = pokemonList[indiceActual + 1];

                CargarDatosEnUI(pokemonEnUI);
            }

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            pokemonEnUI = PokemonDAO.LeerPokemonPorId(Convert.ToInt32(lblId.Text));
            int indiceActual = -1;

            foreach (Pokemon pokemon in pokemonList)
            {
                if (pokemon.Id == pokemonEnUI.Id)
                {
                    indiceActual = pokemonList.IndexOf(pokemon);
                }
            }

            if (indiceActual > 0)
            {
                pokemonEnUI = pokemonList[indiceActual - 1];

                CargarDatosEnUI(pokemonEnUI);
            }
        }

        private void btnPorTipo_Click(object sender, EventArgs e)
        {
            FrmFiltro buscarPorTipo = new("tipo");

            if (buscarPorTipo.ShowDialog() == DialogResult.OK)
            {
                pokemonList = buscarPorTipo.Pokemons;

                CargarDatosEnUI(pokemonList[0]);

                lblNumeroRegistros.Text = (pokemonList.Count).ToString();

                VerificarFlechas();

                tipoLista = "tipo";
            }
        }

        private void btnPorRango_Click(object sender, EventArgs e)
        {
            FrmFiltro buscarPorRango = new("rango");

            if (buscarPorRango.ShowDialog() == DialogResult.OK)
            {
                pokemonList = buscarPorRango.Pokemons;

                rangoMenor = buscarPorRango.RangoMenor;
                rangoMayor = buscarPorRango.RangoMayor;

                CargarDatosEnUI(pokemonList[0]);

                lblNumeroRegistros.Text = (pokemonList.Count).ToString();

                VerificarFlechas();

                tipoLista = "rango";
            }
        }

        private void btnPersonalizada_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;

            if (!string.IsNullOrWhiteSpace(lblId.Text))
            {
                resultado = MessageBox.Show("¿Desea eliminar este pokemon?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(resultado == DialogResult.Yes)
                {
                    Pokemon pokemonAEliminar = PokemonDAO.LeerPokemonPorId(Convert.ToInt32(lblId.Text));
                    PokemonDAO.Eliminar(pokemonAEliminar);

                    picPokemon.BackgroundImage = null;
                    lblId.Text = string.Empty;
                    lblTipo.Text = "Tipo: ";
                    lblEntrenadorPokemon.Text = "Entrenador: ";
                    lblNombre.Text = "Nombre: ";

                    if(pokemonList.Count > 1)
                    {
                        ActualizarUI(tipoLista);
                    }
                    else
                    {
                        lblNumeroRegistros.Text = "0";
                    }
                }
            }
        }

        private void btnSerializacion_Click(object sender, EventArgs e)
        {
            FrmSerializacion serializacion = new FrmSerializacion(pokemonList);

            if(serializacion.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void FrmPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)43)
            {
                Agregar();
            }
        }

        private void Agregar()
        {
            FrmAlta alta = new(entrenador);

            if (alta.ShowDialog() == DialogResult.OK)
            {
                ActualizarUI(tipoLista);
            }
        }

        private void CargarDatosEnUI(Pokemon pokemon)
        {
            Bitmap imagen = new(pokemon.UrlImagen);
            picPokemon.BackgroundImage = imagen;

            lblId.Text = $"{pokemon.Id}";
            lblTipo.Text = $"Tipo: {pokemon.Tipo}";
            lblNombre.Text = $"Nombre: {pokemon.Nombre}";
            lblEntrenadorPokemon.Text = $"Entrenador: {pokemon.Entrenador}";
        }

        private void VerificarFlechas()
        {
            if (Convert.ToInt32(lblNumeroRegistros.Text) > 1)
            {
                btnSiguiente.Enabled = true;
                btnAnterior.Enabled = true;
            }
            else
            {
                btnSiguiente.Enabled = false;
                btnAnterior.Enabled = false;
            }
        }

        private void ActualizarUI(string tipoLista)
        {
            if(tipoLista == "entrenador")
            {
                pokemonList = PokemonDAO.LeerPokemonPorEntrenador(pokemonEnUI.Entrenador);
            }
            else if(tipoLista == "tipo")
            {
                pokemonList = PokemonDAO.LeerPokemonPorTipo(pokemonEnUI.Tipo);
            }
            else if(tipoLista == "rango")
            {
                pokemonList = PokemonDAO.LeerPokemonPorRango(rangoMenor, rangoMayor);
            }

            pokemonEnUI = pokemonList[0];

            CargarDatosEnUI(pokemonEnUI);

            lblNumeroRegistros.Text = pokemonList.Count.ToString();

            VerificarFlechas();
        }
    }
}
