namespace Bridge
{
    public class Documentario : ICanal
    {
        public string Canal()
        {
            return string.Format("Sintonizado no Documentário ");
        }

        public string Status()
        {
            return "Você está assistindo os a origem de tudo";
        }
    }
}