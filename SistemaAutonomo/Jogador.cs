using System.Collections.Generic;

public class Jogador
{

    int id;
    string senha;
    string nome;
    int pontuacao;
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

    public int Pontuacao
    {
        get { return pontuacao; }
        set { pontuacao = value; }
    }

    public Jogador(int id, string senha)
    {
        this.Id = id;
        this.Senha = senha;
    }
    public Jogador(int id) : this(id, null) { }

}