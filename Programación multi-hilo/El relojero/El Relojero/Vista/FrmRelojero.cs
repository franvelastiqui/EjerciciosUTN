using Biblioteca;

namespace Vista
{
    public partial class FrmRelojero : Form
    {
        Temporizador reloj;
        public FrmRelojero()
        {
            InitializeComponent();
        }

        private void FrmRelojero_Load(object sender, EventArgs e)
        {
            reloj = new(100);
            reloj.TiempoCumplido += AsignarHora;
        }

        private void AsignarHora()
        {
            if(lblHora.InvokeRequired)
            {
                lblHora.Invoke(AsignarHora);
            }
            else
            {
                lblHora.Text = DateTime.Now.ToString();
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            reloj.IniciarTemporizador();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            reloj.DetenerTemporizador();
        }
    }
}