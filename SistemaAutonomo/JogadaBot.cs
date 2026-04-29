public class JogadaBot
{
    public Dinossauro Dinossauro { get; set; }
    public Cercado Cercado { get; set; }

    public JogadaBot(Dinossauro dinossauro, Cercado cercado)
    {
        Dinossauro = dinossauro;
        Cercado = cercado;
    }
}