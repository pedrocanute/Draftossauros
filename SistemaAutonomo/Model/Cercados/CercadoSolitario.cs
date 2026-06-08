using System.Collections.Generic;

public class CercadoSolitario : Cercado
{
    public CercadoSolitario(int posX, int posY) : base("IS", "Ilha Solitária", new List<Dinossauro>(), posX, posY) { }
    public override int CalcularPontuacao()
    {
        if (Dinossauros.Count == 1)
            return 7;

        return 0;
    }
}