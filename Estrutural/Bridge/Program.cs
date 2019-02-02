using System;

namespace Bridge {
    class Program {
        
        
        static void Main (string[] args) {
            SmartTV minhaTv = new SmartTV ();
            Console.WriteLine ("Selecione um Canal");
            Console.WriteLine ("1 - Filmes ; \n2 - Documentários; \n3 - Culinária\n");

            ConsoleKeyInfo input = Console.ReadKey ();

            switch (input.KeyChar) {
                case '1':
                    minhaTv.canalAtual = new Filme ();
                    break;
                case '2':
                    minhaTv.canalAtual = new Documentario ();
                    break;
                case '3':
                    minhaTv.canalAtual = new Culnaria ();
                    break;
            }
            Console.WriteLine();
            minhaTv.ExibCanalSintonizado();
            minhaTv.PlayTV();
            Console.ReadKey();
        }
    }

}