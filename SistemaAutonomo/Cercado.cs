using System.Collections.Generic;

public abstract class Cercado
{
    List<Dinossauro> dinossauros;
    int posX;
    int posY;

    public List<Dinossauro> Dinossauros
    {
        get { return dinossauros; }
        set { dinossauros = value; }
    }

    public int PosX
    {
        get { return posX; }
        set { posX = value; }
    }
    public int PosY
    {
        get { return posY; }
        set { posY = value; }
    }

    protected Cercado(List<Dinossauro> dinossauros, int posX, int posY)
    {
        this.Dinossauros = dinossauros;
        this.PosX = posX;
        this.PosY = posY;
    }

    public abstract int CalcularPontuacao();
}


public class Rio : Cercado
{
    public Rio(int posX, int posY) : base(new List<Dinossauro>(), posX, posY)
    {
    }

    public override int CalcularPontuacao() 
    {
        return Dinossauros.Count;
    }
}

public class CercadoIgualdade : Cercado
{
    public CercadoIgualdade(int posX, int posY) : base(new List<Dinossauro>(), posX, posY)
    {
    }
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
    public CercadoReiFloresta(int posX, int posY) : base(new List<Dinossauro>(), posX, posY)
    {
    }
    public override int CalcularPontuacao()
    {
        //Adicionar condicao do dinossauro Rei
        return 7;
    }
}

public class CercadoMataTripla : Cercado
{
    public CercadoMataTripla(int posX, int posY) : base(new List<Dinossauro>(), posX, posY)
    {
    }
    public override int CalcularPontuacao()
    {
        if (Dinossauros.Count == 3)
            return 7;
        return 0;
    }
}

public class CercadoDiferenca : Cercado
{
    public CercadoDiferenca(int posX, int posY) : base(new List<Dinossauro>(), posX, posY)
    {
    }
    public override int CalcularPontuacao()
    {
        int[] tabelaPontuacao = { 1, 3, 6, 10, 15, 21 };
        int quantidade = Dinossauros.Count;

        if (quantidade < 0 || quantidade >= tabelaPontuacao.Length) // Adicionar condicao de dinossauros diferentes
        {
            return 0;
        }

        return tabelaPontuacao[quantidade];
    }
}

public class CercadoAmor : Cercado
{
    public CercadoAmor(int posX, int posY) : base(new List<Dinossauro>(), posX, posY)
    {
    }
    public override int CalcularPontuacao()
    {
        int pontos = 0;
        for (int i = 0; i < Dinossauros.Count; i++)
        {
            if (i % 2 == 0) //Adicionar condicao de especie igual de dinossauros
                pontos += 5;
        }
        return pontos;
    }
}

public class CercadoSolitario : Cercado
{
    public CercadoSolitario(int posX, int posY) : base(new List<Dinossauro>(), posX, posY)
    {
    }
    public override int CalcularPontuacao()
    {
        //Adicionar condicao do dinossauro Solitario
        return 7;
    }
}
