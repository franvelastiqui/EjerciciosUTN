

using Entidades;

namespace El_tiempo_pasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia;
            int mes;
            int anio;
            bool flagMes = false;
            bool respuesta;
            DateTime fecha;
            int dias;

            Console.Write("Ingrese el año: ");
            respuesta = int.TryParse(Console.ReadLine(), out anio);
            while (!respuesta)
            {
                Console.Write("Error. Reingrese el año: ");
                respuesta = int.TryParse(Console.ReadLine(), out anio);
            }

            Console.Write("Ingrese el mes: ");
            respuesta = int.TryParse(Console.ReadLine(), out mes);
            while (!respuesta || !Validador.Validar(mes, 1, 12))
            {
                Console.Write("Error. Reingrese el mes: ");
                respuesta = int.TryParse(Console.ReadLine(), out mes);
            }

            Console.Write("Ingrese el día: ");
            respuesta = int.TryParse(Console.ReadLine(), out dia);
            if((mes == 1 || mes == 3 || mes == 5 || mes == 8 || mes == 10 || mes == 12) && Validador.Validar(dia, 1, 31))
            {
                flagMes = true;
            }
            else if ((mes == 4 || mes == 6 || mes == 7 || mes == 9 || mes == 11) && Validador.Validar(dia, 1, 30))
            {
                flagMes = true;
            }
            else if(mes == 2 && Validador.Validar(dia, 1, 29))
            {
                if((anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0)
                {
                    flagMes = true;
                }
                else if(dia < 29)
                {
                    flagMes = true;
                }
                else
                {
                    flagMes = false;
                }
            }

            while (!respuesta || !flagMes)
            {
                Console.Write("Error. Reingrese el día: ");
                respuesta = int.TryParse(Console.ReadLine(), out dia);
                if ((mes == 1 || mes == 3 || mes == 5 || mes == 8 || mes == 10 || mes == 12) && Validador.Validar(dia, 1, 31))
                {
                    flagMes = true;
                }
                else if ((mes == 4 || mes == 6 || mes == 7 || mes == 9 || mes == 11) && Validador.Validar(dia, 1, 30))
                {
                    flagMes = true;
                }
                else if (mes == 2 && Validador.Validar(dia, 1, 29))
                {
                    if ((anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0)
                    {
                        flagMes = true;
                    }
                    else if (dia < 29)
                    {
                        flagMes = true;
                    }
                    else
                    {
                        flagMes = false;
                    }
                }
            }

            fecha = new DateTime(anio, mes, dia);

            dias = DateTime.Now.Subtract(fecha).Days;

            Console.WriteLine($"Pasaron {dias} días");
        }
    }
}