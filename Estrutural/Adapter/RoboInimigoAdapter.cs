namespace Adapter
{
    /// <summary>
    /// é o nosso adapter - o adaptor do objeto Robo com o Tanque
    /// </summary>
    public class RoboInimigoAdapter : IAtaqueInimigo
    {
        RoboInimigo robo;

        public RoboInimigoAdapter(RoboInimigo novoRobo)
        {
            this.robo = novoRobo;
        }

        public void ArmaFogo()
        {
            this.robo.EsmagarComMaos();
        }

        public void Movimenta()
        {
            this.robo.AndarFrente();
        }

        public void Pilotar(string piloto)
        {
            this.robo.ReagirContraHumando(piloto);
        }
    }
}