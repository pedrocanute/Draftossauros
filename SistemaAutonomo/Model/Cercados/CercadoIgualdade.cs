using System.Collections.Generic;

public class CercadoIgualdade : Cercado
{
    public CercadoIgualdade(int posX, int posY) : base("FI", "Floresta da Igualdade", new List<Dinossauro>(), posX, posY) { }

    public override int CalcularPontuacao()
    {
        int[] tabelaPontuacao = { 0, 2, 4, 8, 12, 18, 24 };
        int quantidade = Dinossauros.Count;

        if (quantidade < 0 || quantidade >= tabelaPontuacao.Length) //Adicionar condicao de dinossauros iguais
        {
            return 0;
        }

        return tabelaPontuacao[quantidade];
    }
}