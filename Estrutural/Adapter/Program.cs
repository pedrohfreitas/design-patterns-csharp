using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            TanqueInimigo rx2018 = new TanqueInimigo();
            RoboInimigo r2d2 = new RoboInimigo();

            IAtaqueInimigo roboAdapter = new RoboInimigoAdapter(r2d2);

            Console.WriteLine(" ========== Robo ===========");
            r2d2.ReagirContraHumando("Pedro");
            r2d2.AndarFrente();
            r2d2.EsmagarComMaos();

            Console.WriteLine(" ========== Tanque ===========");
            rx2018.Pilotar("João");
            rx2018.Movimenta();
            rx2018.ArmaFogo();

            Console.WriteLine(" ========== Robo Adaptado ===========");
            roboAdapter.Pilotar("João Bera");
            roboAdapter.Movimenta();
            roboAdapter.ArmaFogo();


            Console.ReadKey();
        }
    }
}
