using System.Collections.Generic;

public class Jogador
{

    int idJogador;
    string senhaJogador;
    string nomeJogador;
    int pontuacao;
    public List<Dinossauro> dinossauros = new List<Dinossauro>();
    string dinossauroSelecionado = null;

    public int IdJogador { get { return idJogador; } set { idJogador = value; } }

    public string SenhaJogador { get { return senhaJogador; } set { senhaJogador = value; } }

    public string NomeJogador { get { return nomeJogador; } set { nomeJogador = value; } }

    public int Pontuacao { get { return pontuacao; } set { pontuacao = value; } }

    public List<Dinossauro> Dinossauros { get { return dinossauros; } set {  dinossauros = value; }}

    public string DinossauroSelecionado { get { return dinossauroSelecionado; } set { dinossauroSelecionado = value; } }

    public Jogador(int id, string senha) {
        this.IdJogador = id;
        this.SenhaJogador = senha;
    }
    public Jogador(int id) : this(id, null) { }

    public void RealizaJogada()
    {

    }

    public void ExibirMao()
    {

    }
}