﻿using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton jogador_1 = Singleton.GetInsntacia;
            jogador_1.Mensagem("Jogador 1: A Bola está comigo no meio de campo.");

            Singleton jogador_2 = Singleton.GetInsntacia;
            jogador_2.Mensagem("Jogador 2: Recebeu a bola.");

            Singleton jogador_3 = Singleton.GetInsntacia;
            jogador_3.Mensagem("Jogador 3: Recebeu o lançamento na linha de fundo.");

            Console.ReadKey();
        }
    }
}
