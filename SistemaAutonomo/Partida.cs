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


    public bool CriarPartida()
    {
        string retorno = Jogo.CriarPartida(NomePartida, Senha, NomeGrupo);

        if (TratarErro.Verificar(retorno))
            return false;
        
        this.IdPartida = Convert.ToInt32(retorno);
        return true;
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

        if (retorno == "")
            return null;


        return TratarRetorno.SepararLinha(retorno);
    }

    public bool CriarJogador(Jogador jogador)
    {
        string retorno = Jogo.Entrar(IdPartida, jogador.NomeJogador, Senha);

        if (TratarErro.Verificar(retorno))
            return false;

        string[] infoJogador = TratarRetorno.SepararVirgula(retorno);
        jogador.IdJogador = Convert.ToInt32(infoJogador[0]);
        jogador.SenhaJogador = infoJogador[1];

        if (!Jogadores.Contains(jogador))
            Jogadores.Add(jogador);

        JogadorLocal = jogador;
        return true;

    }

    public void IniciarPartida()
    {
        string retorno = Jogo.Iniciar(jogadorLocal.IdJogador, jogadorLocal.SenhaJogador);

        if (TratarErro.Verificar(retorno))
            return;

        string[] infoPrimeiroDado = TratarRetorno.SepararVirgula(retorno);

        jogadorComDado.IdJogador = Convert.ToInt32(infoPrimeiroDado[0]);

        dado.DefinirFace(infoPrimeiroDado[1]);
    }

    public Jogador BuscarJogador(int id)
    {
        foreach (Jogador jogador in jogadores)
        {
            if (jogador.IdJogador == id)
                return jogador;
        }

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

    public void AtualizarJogadoresDoServidor()
    {
        string retorno = Jogo.ListarJogadores(IdPartida);

        if (TratarErro.Verificar(retorno))
            return;

        string[] linhas = TratarRetorno.SepararLinha(retorno);

        Jogadores.Clear();

        foreach (string linha in linhas)
        {
            if (string.IsNullOrWhiteSpace(linha))
                continue;

            string[] dados = linha.Split(',');

            if (dados.Length < 3)
                continue;

            int id;
            int pontuacao;

            if (!int.TryParse(dados[0].Trim(), out id))
                continue;

            if (!int.TryParse(dados[2].Trim(), out pontuacao))
                pontuacao = 0;

            Jogador jogador = new Jogador(id);
            jogador.NomeJogador = dados[1].Trim();
            jogador.Pontuacao = pontuacao;

            if (JogadorLocal != null && jogador.IdJogador == JogadorLocal.IdJogador)
            {
                jogador.SenhaJogador = JogadorLocal.SenhaJogador;
            }

            Jogadores.Add(jogador);
        }
    }
}