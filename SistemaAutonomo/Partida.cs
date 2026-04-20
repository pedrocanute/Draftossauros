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
    Jogador jogadorComDado;
    Tabuleiro tabuleiro;
    string nomeGrupo = "Primordiais";
    Dado dado = new Dado();

    public int IdPartida { get; set; }

    public string Senha { get { return senha; } set { senha = value; } }

    public string NomePartida { get { return nomePartida; } set { nomePartida = value; } }

    public string DataPartida { get { return data; } set { data = value; } }

    public List<Jogador> Jogadores { get { return jogadores; } set { jogadores = value; } }

    public Jogador JogadorLocal { get { return jogadorLocal; } set { jogadorLocal = value; } }

    public Jogador JogadorComDado { get { return jogadorComDado; } set { jogadorComDado = value; } }

    public Tabuleiro Tabuleiro { get { return tabuleiro; } set { tabuleiro = value; } }

    public string NomeGrupo { get { return nomeGrupo; }}

    public Dado Dado { get { return dado; } set { dado = value; } }


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
        string retorno = Jogo.Iniciar(jogadorLocal.Id, jogadorLocal.Senha);

        if (TratarErro.Verificar(retorno))
            return;

        string[] infoPrimeiroDado = TratarRetorno.SepararVirgula(retorno);

        jogadorComDado.Id = Convert.ToInt32(infoPrimeiroDado[0]);

        dado.DefinirFace(infoPrimeiroDado[1]);
    }

    public Jogador BuscarJogador(int id)
    {
        foreach (Jogador jogador in jogadores)
        {
            if (jogador.Id == id)
            {
                return jogador;
            }
        }
        MessageBox.Show("Jogador ja existe", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return null;
    }
    public void AtualizarInfoJogador()
    {
        string retorno = Jogo.VerificarPartida(IdPartida);
        string [] linhas = TratarRetorno.SepararVirgula(retorno);
        JogadorComDado = BuscarJogador(Convert.ToInt32(linhas[3].Trim()));
        dado.DefinirFace(linhas[4].Trim());
        //ExibirMaoJogador
    }
}