using Draft;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class Partida
{
    string nomePartida;
    string senha;
    string data;
    int idPartida;
    List<Jogador> jogadores = new List<Jogador>();
    Jogador jogadorLocal;
    Tabuleiro tabuleiro;
    string nomeGrupo = "Primordiais";

    public int IdPartida { get; set; }

    public string Senha { get { return senha; } set { senha = value; } }

    public string NomePartida { get { return nomePartida; } set { nomePartida = value; } }

    public string DataPartida { get { return data; } set { data = value; } }

    public List<Jogador> Jogadores { get { return jogadores; } set { jogadores = value; } }

    public Jogador JogadorLocal { get { return jogadorLocal; } set { jogadorLocal = value; } }

    public Tabuleiro Tabuleiro { get { return tabuleiro; } set { tabuleiro = value; } }

    public string NomeGrupo { get { return nomeGrupo; }}


    public void CriarPartida()
    {
        string retorno = Jogo.CriarPartida(NomePartida, Senha, NomeGrupo);

        if (TratarErro.Verificar(retorno))
            return;
        
        this.IdPartida = Convert.ToInt32(retorno);
    }

    public string[] ListarPartidas(string status)
    {
        string retorno = Jogo.ListarPartidas(status);

        if (TratarErro.Verificar(retorno))
            return null;

        return TratarRetorno.PegarCaracter(retorno);
    }

    public string[] ListarJogadores()
    {
        string retorno = Jogo.ListarJogadores(IdPartida);
        if (TratarErro.Verificar(retorno))
            return null;
       
        return TratarRetorno.SepararLinha(retorno);
    }

    public bool CriarJogador(Jogador jogador)
    {
        string retorno = Jogo.Entrar(IdPartida, jogadorLocal.Nome, Senha);

        if (TratarErro.Verificar(retorno))
            return false;

        string[] infoJogador = TratarRetorno.SepararVirgula(retorno);
        jogadorLocal.Id = Convert.ToInt32(infoJogador[0]);
        jogadorLocal.Senha = infoJogador[1];
        return true;

    }

    public void IniciarPartida()
    {

    }

    public void BuscarJogador(int id)
    {

    }
    public void AtualizarInfoJogador()
    {

    }
}