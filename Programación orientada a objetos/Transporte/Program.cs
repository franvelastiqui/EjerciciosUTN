using Biblioteca;

namespace Transporte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conductor c1 = new Conductor("juan");
            Conductor c2 = new Conductor("pedro");
            Conductor c3 = new Conductor("maria");

            int[] kmDia1 = { 200, 599, 899, 0, 256, 0, 0 };
            c1.SetKmPorDia(kmDia1);

            int[] kmDia2 = { 300, 400, 900, 0, 0, 0, 100 };
            c2.SetKmPorDia(kmDia2);

            int[] kmDia3 = { 0, 0, 100, 0, 300, 200, 100 };
            c3.SetKmPorDia(kmDia3);

            Empresa transporte = new Empresa("CEC", 3);

            transporte.SetConductor(c1);
            transporte.SetConductor(c2);
            transporte.SetConductor(c3);

            Console.WriteLine(transporte.GetConductorMasKm());
            Console.WriteLine(transporte.GetConductorMasKmEnDia(2));
            Console.WriteLine(transporte.GetConductorMasKmEnDia(4));
        }
    }
}