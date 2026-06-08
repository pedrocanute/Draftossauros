using System.Collections.Generic;

public class CercadoReiFloresta : Cercado
{
    public CercadoReiFloresta(int posX, int posY) : base("RS", "Rei da Selva", new List<Dinossauro>(), posX, posY) { }
    public override int CalcularPontuacao()
    {
        if (Dinossauros.Count == 1)
            return 7;

        return 0;
    }
}