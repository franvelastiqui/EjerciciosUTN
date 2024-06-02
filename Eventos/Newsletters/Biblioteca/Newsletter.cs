namespace Biblioteca
{
    public class Newsletter
    {
        public delegate void NovedadHandler (Newsletter sender, NewsletterEventArgs novedades);
        public event NovedadHandler NovedadEnviada;

        private string tema;

        public Newsletter(string tema)
        {
            this.tema = tema.ToLower();
        }

        public string Tema { get => tema; }

        //Lanzo el evento
        public void EnviarNovedades()
        {
            if(NovedadEnviada is not null)
            {
                NovedadEnviada(this, DefinirContenido());
            }
        }

        private NewsletterEventArgs DefinirContenido()
        {
            string contenido = string.Empty;

            switch(tema)
            {
                case "finanzas":
                    contenido = "Contenido financiero";
                    break;
                case "tecnología":
                    contenido = "Contenido tecnológico";
                    break;
            }

            NewsletterEventArgs argumentos = new NewsletterEventArgs();
            argumentos.Contenido = contenido;

            return argumentos;
        }
    }
}