namespace Biulder {
    public class AndroidBuilder : ICelular {
        public Celular celular;

        public AndroidBuilder () {
            this.celular = new Celular ("Android");
        }

        public void BuildBateria () {
            this.celular.bateria = "MAH_1500";
        }

        public void BuildCamera () {
            this.celular.camera = "15 MP";
        }

        public void BuildSistema () {
            this.celular.sistema = "ANDROID 8.0";
        }

        public void BuildTela () {
            this.celular.tela = "5.5";
        }

        public Celular Celular {
            get { return this.celular; }
        }
    }
}