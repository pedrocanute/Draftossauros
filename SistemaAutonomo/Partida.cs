using System.Collections.Generic;

public class Partida
{
    string nomePartida;
    string senha;
    string data;
    int idPartida;
    List<Jogador> jogadores = new List<Jogador>();
    Jogador jogador;

    public int IdPartida{ get; set; }

    public string Senha
    {
        get { return senha; }
        set { senha = value; }
    }

    public string NomePartida
    {
        get { return nomePartida; }
        set { nomePartida = value; }
    }

    public string DataPartida
    {
        get { return data; }
        set { data = value; }
    }
}