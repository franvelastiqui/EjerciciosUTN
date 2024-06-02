using Centralita;

namespace Test
{
    internal class Test
    {
        static void Main(string[] args)
        {
            // Mi central
            Centralita.Centralita c = new Centralita.Centralita("Fede Center");

            // Mis 4 llamadas
            Local l1 = new Local(30, "Bernal", "Rosario", 2.65f);
            Provincial l2 = new Provincial(21, "Morón", "Bernal", Provincial.Franja.Franja_1);
            Local l3 = new Local(45, "Lanús", "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);

            // Las llamadas se irán registrando en la Centralita.
            try
            {
                _ = c + l1;

                _ = c + l2;

                _ = c + l3;

                _ = c + l4;
            }
            catch(CentralitaException e)
            {
                Console.WriteLine(e.Message);
            }

            //c.OrdenarLlamadas();
            //Console.WriteLine(c.ToString());

            Console.WriteLine(c.Leer());

            Console.ReadKey();
        }
    }
  
}