namespace Bridge
{
    public class Filme : ICanal
    {
        const string canal = "Canal de Filmes";

        public string Canal()
        {
            return string.Format("Sintonizado no {0}", canal);
        }

        public string Status()
        {
            return "Você está assistindo os vingadores";
        }
    }
}