namespace Biblioteca
{
    public class Temporizador
    {
        public delegate void DelegadoTemporizador();
        public event DelegadoTemporizador TiempoCumplido;

        private CancellationToken cancellationToken;
        private CancellationTokenSource cancellationTokenSource;
        private Task hilo;
        private int intervalo;

        public Temporizador(int intervalo)
        {
            this.intervalo = intervalo;
        }

        public bool EstaActivo
        {
            get
            {
                if(hilo is not null && (hilo.Status == TaskStatus.Running || hilo.Status == TaskStatus.WaitingForActivation || hilo.Status == TaskStatus.WaitingToRun || hilo.Status == TaskStatus.Created))
                {
                    return true;
                }
                return false;
            }
        }
        public int Intervalo
        {
            get
            {
                return intervalo;
            }
        }

        public void IniciarTemporizador()
        {
            if(!EstaActivo)
            {
                cancellationTokenSource = new CancellationTokenSource();
                cancellationToken = cancellationTokenSource.Token;

                hilo = new Task(CorrerTiempo);
                hilo.Start();
            }
        }

        public void DetenerTemporizador()
        {
            if(EstaActivo)
            {
                cancellationTokenSource.Cancel();
            }
        }

        private void CorrerTiempo()
        {
            if(TiempoCumplido is not null)
            {
                while(!cancellationToken.IsCancellationRequested)
                {
                    TiempoCumplido();

                    Thread.Sleep(Intervalo);
                }
            }
        }
    }
}