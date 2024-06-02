namespace Recibo_de_sueldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            double valorHora;
            int antiguedadAnios;
            int horasTrabajadas;
            double sueldoBruto;
            double sueldoNeto;
            bool respuesta;

            for(int i = 0; i < 3; i++)
            {
                Console.Write("Ingrese el nombre: ");
                nombre = Console.ReadLine();

                Console.Write("Ingrese un el valor hora: ");
                respuesta = double.TryParse(Console.ReadLine(), out valorHora);
                while (!respuesta)
                {
                    Console.Write("Error. Reingrese un valor válido: ");

                    respuesta = double.TryParse(Console.ReadLine(), out valorHora);
                }

                Console.Write("Ingrese la antiguedad: ");
                respuesta = int.TryParse(Console.ReadLine(), out antiguedadAnios);
                while (!respuesta)
                {
                    Console.Write("Error. Reingrese un valor válido: ");

                    respuesta = int.TryParse(Console.ReadLine(), out antiguedadAnios);
                }

                Console.Write("Ingrese las horas trabajadas: ");
                respuesta = int.TryParse(Console.ReadLine(), out horasTrabajadas);
                while (!respuesta)
                {
                    Console.Write("Error. Reingrese un valor válido: ");

                    respuesta = int.TryParse(Console.ReadLine(), out horasTrabajadas);
                }

                sueldoBruto = (valorHora * horasTrabajadas) + (antiguedadAnios * 150.00);
                sueldoNeto = sueldoBruto - (13.00 * sueldoBruto / 100.00);

                Console.WriteLine($"\nEmpleado: {nombre}\nAntiguedad: {antiguedadAnios} años\nValor por hora: ${valorHora}\nSueldo bruto: ${sueldoBruto}\nSueldo neto: ${sueldoNeto}\n");
            }
        }
    }
}