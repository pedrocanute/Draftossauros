using System.Collections.Generic;

public class CercadoMataTripla : Cercado
{
    public CercadoMataTripla(int posX, int posY) : base("MT", "Mata Tripla", new List<Dinossauro>(), posX, posY) { }
    public override int CalcularPontuacao()
    {
        if (Dinossauros.Count == 3)
            return 7;
        return 0;
    }
}