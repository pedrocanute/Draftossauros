using System.Collections.Generic;

public class Jogador
{

    int id;
    string senha;
    string nome;
    public List<Dinossauros> listaDinossauros = new List<Dinossauros>();


    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Senha
    {
        get { return senha; }
        set { senha = value; }
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public Jogador(int id, string senha)
    {
        this.id = id;
        this.senha = senha;
    }

}