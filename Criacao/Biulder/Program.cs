using System;

namespace Biulder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criar Fabricante
            Fabricante fabricante = new Fabricante();

            //Permite que a classe Builder esteja pronta
            ICelular celularBuilder = null;

            //Agora vamos criar um telefone Android
            celularBuilder = new AndroidBuilder();
            fabricante.Construtor(celularBuilder);
            Console.WriteLine("Um novo Celular from construido: \n\n{0}\n\n", celularBuilder.Celular.nome.ToString());
            Console.WriteLine("Camera: {0}", celularBuilder.Celular.camera.ToString());
            Console.WriteLine("Bateria: {0}", celularBuilder.Celular.bateria.ToString());
            Console.WriteLine("Sistema Operacional: {0}", celularBuilder.Celular.sistema.ToString());
            Console.WriteLine("Tela: {0}", celularBuilder.Celular.tela.ToString());

            //Agora vamos criar um telefone Iphone
            celularBuilder = new IphoneBuilder();
            fabricante.Construtor(celularBuilder);
            Console.WriteLine("Um novo Celular from construido: \n\n{0}", celularBuilder.Celular.nome.ToString());
            Console.WriteLine("Camera: {0}", celularBuilder.Celular.camera.ToString());
            Console.WriteLine("Bateria: {0}", celularBuilder.Celular.bateria.ToString());
            Console.WriteLine("Sistema Operacional: {0}", celularBuilder.Celular.sistema.ToString());
            Console.WriteLine("Tela: {0}", celularBuilder.Celular.tela.ToString());
             Console.ReadKey();
        }
    }
}
