using System.Collections.Generic;

public class Rio : Cercado
{
    public Rio(int posX, int posY) : base("RI", "Rio", new List<Dinossauro>(), posX, posY) { }

    public override int CalcularPontuacao()
    {
        return Dinossauros.Count;
    }
}