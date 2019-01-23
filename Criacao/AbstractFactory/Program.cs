using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = ExecutaAbstractFactory.montarCarro("luxo");
            Carro c2 = ExecutaAbstractFactory.montarCarro("popular");

            Console.WriteLine("Carro de Luxo: {0} {1} {2} ", c1.GetType(), c1.roda.GetType(), c1.som.GetType());
            Console.WriteLine("Carro de Popular: {0} {1} {2}", c2.GetType(), c2.roda.GetType(), c2.som.GetType());
            Console.ReadKey();

        }
    }
}
