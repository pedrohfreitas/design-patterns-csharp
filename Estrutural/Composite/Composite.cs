using System;
using System.Collections.Generic;

namespace Composite {
    public class Composite : Componente {

        private List<Componente> filhos = new List<Componente>();
        public Composite (string nome) : base(nome) {

        }

        public override void Adicionar (Componente componente) {
            this.filhos.Add(componente);
        }

        public override void Monstrar (int profundidade) {
            Console.WriteLine(new String('-', profundidade) + nome);
            foreach (var componente in this.filhos)
            {
                componente.Monstrar(profundidade + 2);
            }
        }

        public override void Remover (Componente componente) {
            this.filhos.Remove(componente);
        }
    }
}