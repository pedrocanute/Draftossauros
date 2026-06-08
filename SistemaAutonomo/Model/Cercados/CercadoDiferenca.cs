using System.Collections.Generic;

public class CercadoDiferenca : Cercado
{
    public CercadoDiferenca(int posX, int posY) : base("CD", "Campina da Diferença", new List<Dinossauro>(), posX, posY) { }
    public override int CalcularPontuacao()
    {
        int[] tabelaPontuacao = { 0, 1, 3, 6, 10, 15, 21 };
        int quantidade = Dinossauros.Count;

        if (quantidade < 0 || quantidade >= tabelaPontuacao.Length)
            return 0;

        return tabelaPontuacao[quantidade];
    }
}