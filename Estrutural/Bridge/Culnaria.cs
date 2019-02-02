namespace Bridge
{
    public class Culnaria : ICanal
    {
        public string Canal()
        {
            return string.Format("Sintonizado no canal de colunária ");
        }

        public string Status()
        {
            return "Você está assistindo a receita de bolo de chocolate";
        }
    }
}