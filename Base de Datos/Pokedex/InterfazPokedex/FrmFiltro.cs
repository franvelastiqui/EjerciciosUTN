using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokedexClases;

namespace InterfazPokedex
{
    public partial class FrmFiltro : Form
    {
        string filtro;
        List<Pokemon> pokemons;
        int rangoMenor;
        int rangoMayor;

        public FrmFiltro(string filtro)
        {
            pokemons = new List<Pokemon>();
            this.filtro = filtro;
            InitializeComponent();
        }

        public List<Pokemon> Pokemons { get => pokemons; }
        public int RangoMenor { get => rangoMenor; }
        public int RangoMayor { get => rangoMayor; }

        private void FrmFiltro_Load(object sender, EventArgs e)
        {
            switch (filtro)
            {
                case "entrenador":
                    txtQuery.Hide();
                    nupDesde.Hide();
                    nupHasta.Hide();
                    cmbFiltro.Show();
                    cmbFiltro.DataSource = BuscarEntrenadores();
                    break;
                case "tipo":
                    txtQuery.Hide();
                    nupDesde.Hide();
                    nupHasta.Hide();
                    cmbFiltro.Show();
                    cmbFiltro.DataSource = BuscarTipos();
                    break;
                case "rango":
                    txtQuery.Hide();
                    nupDesde.Show();
                    nupHasta.Show();
                    cmbFiltro.Hide();
                    break;
                case "personalizada":
                    txtQuery.Show();
                    nupDesde.Hide();
                    nupHasta.Hide();
                    cmbFiltro.Hide();
                    break;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            switch (filtro)
            {
                case "entrenador":
                    pokemons = PokemonDAO.LeerPokemonPorEntrenador(cmbFiltro.Text);
                    break;
                case "tipo":
                    pokemons = PokemonDAO.LeerPokemonPorTipo(cmbFiltro.Text);
                    break;
                case "rango":
                    if(nupDesde.Value > nupHasta.Value)
                    {
                        MessageBox.Show("El valor inicial no puede ser mayor que el valor final");
                    }
                    else
                    {
                        rangoMenor = (int)nupDesde.Value;
                        rangoMayor = (int)nupHasta.Value;
                        pokemons = PokemonDAO.LeerPokemonPorRango(rangoMenor, rangoMayor);
                    }
                    break;
                case "personalizada":
                    break;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private List<string> BuscarEntrenadores()
        {
            List<Pokemon> pokemons = PokemonDAO.LeerPokemon();
            List<string> entrenadores = new List<string>();

            foreach (Pokemon pokemon in pokemons)
            {
                if (!entrenadores.Contains(pokemon.Entrenador))
                {
                    entrenadores.Add(pokemon.Entrenador);
                }
            }

            return entrenadores;
        }

        private List<string> BuscarTipos()
        {
            List<Pokemon> pokemons = PokemonDAO.LeerPokemon();
            List<string> tipos = new List<string>();

            foreach (Pokemon pokemon in pokemons)
            {
                if (!tipos.Contains(pokemon.Tipo))
                {
                    tipos.Add(pokemon.Tipo);
                }
            }

            return tipos;
        }
    }
}
