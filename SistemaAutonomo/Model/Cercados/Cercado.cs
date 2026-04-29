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















