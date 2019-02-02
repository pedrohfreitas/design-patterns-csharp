using System;

namespace Adapter
{
    /// <summary>
    /// O Robo Inimigo é de fato o nosso adaptee - ou seja, ele é o objeto que será adaptado
    /// </summary>
    public class RoboInimigo 
    {
        Random gerador = new Random();

        public void EsmagarComMaos(){
            int danoAtaque = this.gerador.Next(10) + 1;
            Console.WriteLine("O Robo inimigo caousou {0} de dadno como arauqe Esmagar com as Mãos", danoAtaque);
        }

        public void AndarFrente(){
            int movimento = this.gerador.Next(10) + 1;
            Console.WriteLine("O robo inimigo andou {0} passos para frente", movimento); 
        }

        public void ReagirContraHumando(string piloto){
            Console.WriteLine("O robo inimigo vai contra o piloto {0}.", piloto);
        }
    }
}