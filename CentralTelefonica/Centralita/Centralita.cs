using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Centralita : IGuardar<string>
    {
        private List<Llamada> listaLlamada;
        private string razonSocial;
        private string ruta;

        public Centralita(string razonSocial)
        {
            this.razonSocial = razonSocial;
            listaLlamada = new List<Llamada>();
            ruta = Path.Combine(Directory.GetCurrentDirectory(), $"Bitácora.txt");
        }

        public Centralita() : this("Franco Center")
        {

        }

        public float GananciaPorLocal { get { return CalcularGanancia(Llamada.TipoLlamada.Local); } }
        public float GananciaPorProvincial { get { return CalcularGanancia(Llamada.TipoLlamada.Provincial); } }
        public float GananciaPorTotal { get { return CalcularGanancia(Llamada.TipoLlamada.Todas); } }
        public List<Llamada> ListaLlamada { get => listaLlamada; }
        public string RutaDeArchivo
        {
            get
            {
                return ruta;
            }
            set
            {
                ruta = value;
            }
        }

        public void OrdenarLlamadas()
        {
            listaLlamada.Sort(Llamada.OrdenarPorDuracion);
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            if(nuevaLlamada is not null)
            {
                listaLlamada.Add(nuevaLlamada);
            }
        }

        private string Mostrar()
        {
            StringBuilder sb = new();

            sb.AppendLine($"Razon Social: {razonSocial}");
            foreach (var item in listaLlamada)
            {
                if (item is Local l)
                {
                    sb.AppendLine(l.ToString());
                }
                else if (item is Provincial p)
                {
                    sb.AppendLine(p.ToString());
                }
            }
            return sb.ToString();
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float gananciaLocal = 0;
            float gananciaProvincial = 0;
            float retorno = 0;

            foreach (var item in listaLlamada)
            {
                if (item is Local l)
                {
                    gananciaLocal += l.CostoLlamada;
                }
                else if (item is Provincial p)
                {
                    gananciaProvincial += p.CostoLlamada;
                }
            }

            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    retorno = gananciaLocal;
                    break;
                case Llamada.TipoLlamada.Provincial:
                    retorno = gananciaProvincial;
                    break;
                case Llamada.TipoLlamada.Todas:
                    retorno = gananciaLocal + gananciaProvincial;
                    break;
                default:
                    break;
            }

            return retorno;
        }

        public override string ToString()
        {
            return Mostrar();
        }

        public bool Guardar()
        {
            try
            {
                using(StreamWriter sw = new(RutaDeArchivo,true))
                {
                    sw.WriteLine($"{DateTime.Now.ToString("dddd dd/MMMM/yyyy HH:mm")} - Se realizó una llamada");
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string Leer()
        {
            string retorno;

            using (StreamReader sw = new(RutaDeArchivo))
            {
                retorno = sw.ReadToEnd();
            }
            return retorno;
        }

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            if(c is not null && llamada is not null)
            {
                foreach (Llamada l in c.listaLlamada)
                {
                    if(l == llamada)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }
        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            if(c is not null && nuevaLlamada is not null)
            {
                if(c == nuevaLlamada)
                {
                    throw new CentralitaException("Esta llamada ya se realizó", "Centralita", "Operador +");
                }
                c.AgregarLlamada(nuevaLlamada);

                if(nuevaLlamada is Local)
                {
                    _ = (nuevaLlamada as Local).Guardar();
                }
                else
                {
                    _ = (nuevaLlamada as Provincial).Guardar();
                }

                c.Guardar();
            }
            return c;
        }
    }
}
