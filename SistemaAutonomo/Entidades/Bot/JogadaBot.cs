public class JogadaBot
{
    public Dinossauro Dinossauro { get; set; }
    public Cercado Cercado { get; set; }
    public int Prioridade { get; set; }

    public JogadaBot(Dinossauro dinossauro, Cercado cercado, int prioridade = 0)
    {
        Dinossauro = dinossauro;
        Cercado = cercado;
        Prioridade = prioridade;
    }
}