using System.Collections.Generic;

public class CercadoAmor : Cercado
{
    public CercadoAmor(int posX, int posY) : base("PA", "Pradaria do Amor", new List<Dinossauro>(), posX, posY) { }
    public override int CalcularPontuacao()
    {
        Dictionary<string, int> contagemPorEspecie = new Dictionary<string, int>();

        foreach (Dinossauro dino in Dinossauros)
        {
            if (!contagemPorEspecie.ContainsKey(dino.Sigla))
                contagemPorEspecie[dino.Sigla] = 0;

            contagemPorEspecie[dino.Sigla]++;
        }

        int pontos = 0;

        foreach (KeyValuePair<string, int> item in contagemPorEspecie)
        {
            int quantidadeDePares = item.Value / 2;
            pontos += quantidadeDePares * 5;
        }

        return pontos;
    }
}