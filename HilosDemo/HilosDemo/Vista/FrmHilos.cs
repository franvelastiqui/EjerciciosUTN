using System.Text;

namespace Vista
{
    public partial class FrmHilos : Form
    {
        private static Random random;
        CancellationTokenSource cancellationTokenSource;
        List<Task> hilos;

        static FrmHilos()
        {
            random = new Random();
        }

        public FrmHilos()
        {
            hilos = new List<Task>();
            InitializeComponent();
        }

        private void FrmHilos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmHilos_Load(object sender, EventArgs e)
        {
            IniciarHilos();
        }

        private void IniciarHilos()
        {
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;
            progressBar4.Value = 0;

            cancellationTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellationTokenSource.Token;

            Task hiloPrimerBarra = new(() => IniciarProceso(progressBar1, label1), cancellationToken);

            hiloPrimerBarra.Start();

            hilos.Add(hiloPrimerBarra);

            hilos.Add(Task.Run(() => IniciarProceso(progressBar2, label2), cancellationToken));

            hilos.Add(Task.Run(() => IniciarProceso(progressBar3, label3), cancellationToken));

            hilos.Add(Task.Run(() => IniciarProceso(progressBar4, label4), cancellationToken));
        }

        private void IniciarProceso(ProgressBar barra, Label label)
        {
            while (barra.Value < barra.Maximum && !cancellationTokenSource.IsCancellationRequested)
            {
                Thread.Sleep(random.Next(100, 1000));
                IncrementarBarraProgreso(barra, label, Task.CurrentId.Value);
            }

            FinalizarProceso(barra, label);
        }

        private void IncrementarBarraProgreso(ProgressBar barra, Label label, int idHilo)
        {
            if (InvokeRequired)
            {
                Invoke(IncrementarBarraProgreso, barra, label, idHilo);
            }
            else
            {
                barra.Increment(random.Next(1, 5));
                label.Text = $"Hilo N°{idHilo} - {barra.Value}%";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();
        }

        private void FinalizarProceso(ProgressBar barra, Label label)
        {
            if (InvokeRequired)
            {
                Invoke(FinalizarProceso, barra, label);
            }
            else
            {
                if (barra.Value == barra.Maximum)
                {
                    label.Text = "Finalizado";
                }
                else
                {
                    label.Text = "Cancelado";
                }
            }
        }

        private void btnVerInfo_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Task hilo in hilos)
            {
                sb.Append($"Hilo {hilo.Id} ");
                string mensaje = hilo.IsCompleted ? "está completado." : $"en estado {hilo.Status}";
                sb.Append(mensaje);
                sb.AppendLine();
            }

            MessageBox.Show(sb.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmHilos_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancellationTokenSource.Cancel();
        }

        private async void btnReiniciar_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();

            while(!hilos.All(h => h.IsCompleted))
            {
                await Task.Delay(500);
            }

            IniciarHilos();
        }
    }
}