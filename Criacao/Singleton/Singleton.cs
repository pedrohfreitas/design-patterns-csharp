using System;

namespace Singleton {
    //Sealed: Não permite ser herdada
    public sealed class Singleton {
        private static Singleton instancia = null;

        public static Singleton GetInsntacia {
            get {
                if (instancia == null){
                    instancia = new Singleton ();
                    Console.WriteLine("Bola em Jogo!!");
                }

                return instancia;
            }
        }

        public void Mensagem(string msg){
            Console.WriteLine(msg);
        }
    }
}