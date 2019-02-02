using System;

namespace Bridge
{
    /// <summary>
    /// Aqui temos a ponte (Brigde). No program chama essa classe passando o canal 
    /// </summary>
    public class SmartTV
    {
        public ICanal canalAtual { get; set; }

        public void ExibCanalSintonizado(){

            if(this.canalAtual != null)
                Console.WriteLine(this.canalAtual.Canal());
            else
                Console.WriteLine("Por favor, selecione um canal!");
        }

        public void PlayTV(){
            if(this.canalAtual != null)
                Console.WriteLine(this.canalAtual.Status());
            else
                Console.WriteLine("Por favor, selecione um canal!");
        }
    }
}