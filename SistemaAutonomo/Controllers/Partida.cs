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

    public string StatusPartida { get; set; }
    public int TurnoAtual { get; set; }
    public string StatusTurno { get; set; }

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

        jogadores.Clear();

        string[] listaJogadores = TratarRetorno.SepararLinha(retorno);

        for(int i = 0; i < listaJogadores.Length - 1; i++) 
        {
            string[] dados = listaJogadores[i].Split(',');

            Jogador jogador = new Jogador(Convert.ToInt32(dados[0]));
            jogador.IdJogador = Convert.ToInt32(dados[0]);
            jogador.NomeJogador = dados[1];
            jogador.Pontuacao = Convert.ToInt32(dados[2]);

            jogadores.Add(jogador);
        }

        return listaJogadores;
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

    public bool IniciarPartida()
    {
        string retorno = Jogo.Iniciar(jogadorLocal.IdJogador, jogadorLocal.SenhaJogador);

        if (TratarErro.Verificar(retorno))
            return false;

        string[] infoPrimeiroDado = TratarRetorno.SepararVirgula(retorno);

        if (infoPrimeiroDado.Length < 2)
            return false;

        int idJogadorComDado = Convert.ToInt32(infoPrimeiroDado[0].Trim());
        string faceDado = infoPrimeiroDado[1].Trim();

        JogadorComDado = BuscarJogador(idJogadorComDado);

        if (JogadorComDado == null)
        {
            JogadorComDado = new Jogador(idJogadorComDado);
            Jogadores.Add(JogadorComDado);
        }

        Dado.DefinirFace(faceDado);

        return true;
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

    public bool AtualizarInfoJogador()
    {
        string retorno = Jogo.VerificarPartida(IdPartida);

        if (TratarErro.Verificar(retorno))
            return false;

        if (string.IsNullOrWhiteSpace(retorno))
            return false;

        string[] dados = TratarRetorno.SepararVirgula(retorno);

        if (dados.Length < 5)
            return false;

        StatusPartida = dados[0].Trim().ToUpper();
        TurnoAtual = Convert.ToInt32(dados[1].Trim());
        StatusTurno = dados[2].Trim().ToUpper();

        int idJogadorComDado = Convert.ToInt32(dados[3].Trim());
        string faceDado = dados[4].Trim().ToUpper();

        JogadorComDado = BuscarJogador(idJogadorComDado);

        if (JogadorComDado == null)
        {
            JogadorComDado = new Jogador(idJogadorComDado);
            Jogadores.Add(JogadorComDado);
        }

        Dado.DefinirFace(faceDado);

        return true;
    }

    public void AtualizarJogadoresDoServidor()
    {
        string retorno = Jogo.ListarJogadores(IdPartida);

        if (TratarErro.Verificar(retorno))
            return;

        string[] linhas = TratarRetorno.SepararLinha(retorno);

        List<Jogador> jogadoresAtualizados = new List<Jogador>();

        foreach (string linha in linhas)
        {
            if (string.IsNullOrWhiteSpace(linha))
                continue;

            string[] dados = linha.Split(',');

            int id = Convert.ToInt32(dados[0]);
            string nome = dados[1].Trim();
            int pontuacao = Convert.ToInt32(dados[2]);

            Jogador jogador;

            if (JogadorLocal != null && JogadorLocal.IdJogador == id)
            {
                jogador = JogadorLocal;
            }
            else
            {
                jogador = BuscarJogador(id);

                if (jogador == null)
                    jogador = new Jogador(id);
            }

            jogador.IdJogador = id;
            jogador.NomeJogador = nome;
            jogador.Pontuacao = pontuacao;

            jogadoresAtualizados.Add(jogador);
        }

        Jogadores = jogadoresAtualizados;
    }
}