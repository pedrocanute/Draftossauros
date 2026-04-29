using System;
using System.Collections.Generic;

public class Bot : Jogador
{
    private static Random random = new Random();

    public JogadaBot UltimaJogada { get; private set; }

    public Bot(int id) : base(id)
    {
    }

    public Bot(string nome) : base(0)
    {
        NomeJogador = nome;
    }

    public ValidarJogada JogarAutomaticamente(Partida partida)
    {
        if (partida == null)
            return new ValidarJogada(false, "Partida inválida.");

        if (partida.Dado == null)
            return new ValidarJogada(false, "Dado inválido.");

        if (partida.JogadorComDado == null)
            return new ValidarJogada(false, "Jogador com dado inválido.");

        if (partida.Tabuleiro == null)
            return new ValidarJogada(false, "Tabuleiro inválido.");

        AtualizarMao();

        if (Dinossauros == null || Dinossauros.Count == 0)
            return new ValidarJogada(false, "Bot não possui dinossauros na mão.");

        List<JogadaBot> jogadasValidas = BuscarJogadasValidas(partida);

        if (jogadasValidas.Count == 0)
            return new ValidarJogada(false, "Bot não encontrou jogada possível.");

        EmbaralharJogadas(jogadasValidas);

        foreach (JogadaBot jogada in jogadasValidas)
        {
            DinossauroSelecionado = jogada.Dinossauro;

            ValidarJogada resultado = RealizarJogada(
                jogada.Cercado,
                partida.Dado,
                partida.JogadorComDado
            );

            if (resultado.Valido)
            {
                UltimaJogada = jogada;
                return resultado;
            }
        }

        DinossauroSelecionado = null;
        UltimaJogada = null;

        return new ValidarJogada(false, "Bot tentou jogar, mas nenhuma jogada foi aceita.");
    }

    private List<JogadaBot> BuscarJogadasValidas(Partida partida)
    {
        List<JogadaBot> jogadasValidas = new List<JogadaBot>();

        foreach (Dinossauro dinossauro in Dinossauros)
        {
            foreach (Cercado cercado in partida.Tabuleiro.Cercados)
            {
                ValidarJogada resultado = RegraJogada.Validar(
                    partida.Dado,
                    cercado,
                    dinossauro,
                    this,
                    partida.JogadorComDado
                );

                if (resultado.Valido)
                    jogadasValidas.Add(new JogadaBot(dinossauro, cercado));
            }
        }

        jogadasValidas.Sort((jogadaA, jogadaB) =>
        {
            int ganhoA = CalcularGanhoDaJogada(jogadaA);
            int ganhoB = CalcularGanhoDaJogada(jogadaB);

            return ganhoB.CompareTo(ganhoA);
        });

        return jogadasValidas;
    }

    private int CalcularGanhoDaJogada(JogadaBot jogada)
    {
        int pontuacaoAntes = jogada.Cercado.CalcularPontuacao();

        jogada.Cercado.Dinossauros.Add(jogada.Dinossauro);
        int pontuacaoDepois = jogada.Cercado.CalcularPontuacao();
        jogada.Cercado.Dinossauros.Remove(jogada.Dinossauro);

        return pontuacaoDepois - pontuacaoAntes;
    }

    private void EmbaralharJogadas(List<JogadaBot> jogadas)
    {
        for (int i = 0; i < jogadas.Count; i++)
        {
            int indiceSorteado = random.Next(i, jogadas.Count);

            JogadaBot temp = jogadas[i];
            jogadas[i] = jogadas[indiceSorteado];
            jogadas[indiceSorteado] = temp;
        }
    }
}