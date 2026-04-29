using System;
using System.Collections.Generic;

public abstract class Cercado
{
    string siglaCercado;
    string nomeCercado;
    List<Dinossauro> dinossauros;
    int posX;
    int posY;

    public string SiglaCercado { get { return siglaCercado; } set {  siglaCercado = value;  } }

    public string NomeCercado { get { return nomeCercado; } set { nomeCercado = value; } }

    public List<Dinossauro> Dinossauros { get { return dinossauros; } set { dinossauros = value; } }

    public int PosX { get { return posX; } set { posX = value; } }
    public int PosY { get { return posY; } set { posY = value; } }

    // Construtores
    protected Cercado(string sigla, string nome,List<Dinossauro> dinossauros, int posX, int posY)
    {
        this.SiglaCercado = sigla;
        this.NomeCercado = nome;
        this.Dinossauros = dinossauros;
        this.PosX = posX;
        this.PosY = posY;
    }

    public abstract int CalcularPontuacao();
}


public class Rio : Cercado
{
    public Rio(int posX, int posY) : base("RI", "Rio", new List<Dinossauro>(), posX, posY) { }

    public override int CalcularPontuacao() 
    {
        return Dinossauros.Count;
    }
}

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
