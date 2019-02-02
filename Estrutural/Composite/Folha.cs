using System;

namespace Composite
{
    public class Folha : Componente
    {
        public Folha(string nome) : base(nome)
        {
        }

        public override void Adicionar(Componente componente)
        {
            Console.WriteLine("Não é possivel adicionar a folha");
        }

        public override void Monstrar(int profundidade)
        {
             Console.WriteLine(new String('-', profundidade) + nome);
        }

        public override void Remover(Componente componente)
        {
            Console.WriteLine("Não é possivel remover a folha");
        }
    }
}