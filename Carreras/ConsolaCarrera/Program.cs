using Entidades;

namespace ConsolaCarrera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random azar  = new Random();

            Competencia<AutoF1> formulaUno = new(10, 5, TipoCompetencia.F1);
            AutoF1[] autos = new AutoF1[10];


            //AutoF1 a1 = new AutoF1(1, "escu1");
            //AutoF1 a2 = new AutoF1(4, "escu2");
            //AutoF1 a3 = new AutoF1(5, "escu3");
            //AutoF1 a4 = new AutoF1(1, "escu1");
            //AutoF1 a5 = new AutoF1(2, "escu4");
            //Competencia competencia = new Competencia(5, 10);

            for (int i = 0; i < autos.Length - 2; i++)
            {
                autos[i] = new AutoF1((short)i, azar.Next(1, 5).ToString());
                try
                {
                    if (formulaUno + autos[i])
                    {
                        Console.WriteLine("Se agregó el siguiente auto a la competencia: {0}", autos[i].MostrarDatos());
                    }
                }
                catch(CompetenciaNoDisponibleException e)
                {
                    Console.WriteLine(e.Message);
                }

            }

            autos[8] = autos[7];
            try
            {
                if (formulaUno + autos[8])
                {
                    Console.WriteLine("Se agregó el siguiente auto a la competencia: {0}", autos[8].MostrarDatos());
                }
            }
            catch (CompetenciaNoDisponibleException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e);
            }

            Console.WriteLine();
            Console.WriteLine("<----------------------------------------------------------->");
            Console.WriteLine(formulaUno.MostrarDatos());
        }
    }
}