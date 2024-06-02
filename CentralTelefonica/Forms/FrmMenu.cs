using Centralita;
using Central = Centralita.Centralita;

namespace Forms
{
    public partial class FrmMenu : Form
    {
        protected Central centralita;

        public FrmMenu(Central centralita)
        {
            this.centralita = centralita;
            InitializeComponent();
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador llamador = new FrmLlamador(centralita);

            llamador.ShowDialog();
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar form = new(centralita, Llamada.TipoLlamada.Todas);
            form.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar form = new(centralita, Llamada.TipoLlamada.Local);
            form.ShowDialog();
        }

        private void acturacionProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar form = new(centralita, Llamada.TipoLlamada.Provincial);
            form.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}