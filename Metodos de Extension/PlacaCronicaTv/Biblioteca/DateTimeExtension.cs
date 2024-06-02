namespace Biblioteca
{
    public static class DateTimeExtension
    {
        public static string ObtenerPlacaCronicaTV(this DateTime fecha, Estaciones estacion)
        {
            TimeSpan dias;
            DateTime fechaEstacion;
            DateTime fechaEstacionActual;

            fechaEstacion = DefinirFechaEstacion(fecha, estacion);
            fechaEstacionActual = new(DateTime.Now.Year, fechaEstacion.Month, 21);


            if (fecha <= DateTime.Now)
            {
                if (DateTime.Now >= fechaEstacionActual)
                {
                    DateTime fechaAnyoSiguiente = fechaEstacionActual.AddYears(1);
                    dias = fechaAnyoSiguiente - fecha;

                    return $"Faltan {(int)(dias.TotalDays)} para el {estacion}";
                }
                else
                {
                    dias = fechaEstacionActual - fecha;
                    return $"Faltan {(int)(dias.TotalDays)} para el {estacion}";
                }
            }
            else
            {
                if (fecha >= fechaEstacion)
                {
                    DateTime fechaAnyoSiguiente = fechaEstacion.AddYears(1);
                    dias = fechaAnyoSiguiente - fecha;

                    return $"Faltan {(int)(dias.TotalDays)} para el {estacion}";
                }
                else
                {
                    dias = fechaEstacion - fecha;
                    return $"Faltan {(int)(dias.TotalDays)} para el {estacion}";
                }
            }

        }

        private static DateTime DefinirFechaEstacion(DateTime fecha, Estaciones estacion)
        {
            DateTime fechaEstacion;

            switch (estacion)
            {
                case Estaciones.verano:
                    fechaEstacion = new DateTime(fecha.Year, 12, 21);
                    break;
                case Estaciones.otoño:
                    fechaEstacion = new DateTime(fecha.Year, 03, 21);
                    break;
                case Estaciones.invierno:
                    fechaEstacion = new DateTime(fecha.Year, 06, 21);
                    break;
                default:
                    fechaEstacion = new DateTime(fecha.Year, 09, 21);
                    break;
            }

            return fechaEstacion;
        }
    }
}