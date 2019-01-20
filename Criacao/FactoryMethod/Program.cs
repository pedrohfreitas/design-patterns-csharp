﻿using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod fm = new FactoryMethod();

            Console.WriteLine("Liu Kang | SubZero | Scorpion");
            Console.WriteLine();

            Console.WriteLine("Escolha o seu Personagem: ");
            string escolha = Console.ReadLine();

            IPersonagem personagem = fm.Escolher_Personagem(escolha);
            Console.WriteLine();
            Console.WriteLine("Você vai jogar com:");
            personagem.Escolhido();

            Console.WriteLine();
            Console.WriteLine("Tipo de Objeto: {0}", personagem.GetType());

            Console.ReadKey();
        }
    }
}
