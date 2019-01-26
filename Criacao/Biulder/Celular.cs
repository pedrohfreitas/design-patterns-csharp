namespace Biulder {
    public class Celular {

        public Celular (string nome) {
            this.nome = nome;
        }

        public string nome { get; set; }
        public string tela { get; set; }
        public string bateria { get; set; }
        public string sistema { get; set; }
        public string camera {get; set;}
    }
}