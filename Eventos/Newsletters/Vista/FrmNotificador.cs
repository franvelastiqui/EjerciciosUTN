using Biblioteca;
using System.Data.SqlClient;

namespace Vista
{
    public partial class FrmNotificador : Form
    {
        List<Suscriptor> suscriptores;
        Newsletter tecnologia;
        Newsletter finanzas;

        public FrmNotificador()
        {
            suscriptores = new List<Suscriptor>();
            tecnologia = new("Tecnología");
            finanzas = new("Finanzas");
            InitializeComponent();
        }

        private void FrmNotificador_Load(object sender, EventArgs e)
        {
            TraerSuscriptores();

            foreach(Suscriptor suscriptor in suscriptores)
            {
                if(suscriptor.Id % 2 == 0)
                {
                    //El evento, cuando se lance, quiero que se le asocie este método. Este método escucha al evento cuando se lanza
                    finanzas.NovedadEnviada += suscriptor.RecibirNovedad;
                }
                else
                {
                    tecnologia.NovedadEnviada += suscriptor.RecibirNovedad;
                }
            }

            btnTecnologia.Click += btnTecnologia_OnClick;
            btnFinanzas.Click += btnFinanzas_OnClick;
        }

        public void btnTecnologia_OnClick(object sender, EventArgs e)
        {
            //Llamo al método que contiene el evento
            tecnologia.EnviarNovedades();
        }

        public void btnFinanzas_OnClick(object sender, EventArgs e)
        {
            finanzas.EnviarNovedades();
        }

        private void TraerSuscriptores()
        {
            using (SqlConnection connection = new(@"Data Source = .;Database = UTN_DB;Trusted_Connection = True;"))
            {
                string commandText = "SELECT id, nombre FROM Usuarios";
                SqlCommand cmd = new(commandText, connection);

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    suscriptores.Add(new Suscriptor(Convert.ToInt32(reader["id"]), reader["nombre"].ToString()));
                }
            }
        }
    }
}