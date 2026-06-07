using System;
using System.Collections.Generic;
using System.Linq;

public class Bot : Jogador
{

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
                {
                    int prioridade = CalcularPrioridadeJogada(cercado, dinossauro, partida);
                    jogadasValidas.Add(new JogadaBot(dinossauro, cercado, prioridade));
                }
            }
        }

        jogadasValidas = jogadasValidas.OrderByDescending(j => ((JogadaBot)j).Prioridade).ToList();

        return jogadasValidas;
    }


    private int CalcularPrioridadeJogada(Cercado cercado, Dinossauro dinossauro, Partida partida)
    {
        int prioridade = 0;

        if (cercado is CercadoDiferenca)
        {
            bool especieJaExiste = false;
            foreach (var dino in cercado.Dinossauros)
            {
                if (dino.Sigla == dinossauro.Sigla)
                {
                    especieJaExiste = true;
                    break;
                }
            }

            if (especieJaExiste)
            {
                return -99999;
            }

            int qtdAtual = cercado.Dinossauros.Count;
            int pontosAtuais = CalcularPontosDiferenca(qtdAtual);
            int pontosFuturos = CalcularPontosDiferenca(qtdAtual + 1);
            int ganhoImediato = pontosFuturos - pontosAtuais;

            prioridade += ganhoImediato * 100; 
            if (qtdAtual < 3)
                prioridade += 50;
        }

        if (cercado is CercadoIgualdade)
        {
            bool especieCompravel = true;
            foreach (var dino in cercado.Dinossauros)
            {
                if (dino.Sigla != dinossauro.Sigla)
                {
                    especieCompravel = false;
                    break;
                }
            }

            if (!especieCompravel)
                return -99999;

            int qtdAtual = cercado.Dinossauros.Count;

            if (qtdAtual >= 6)
                return -99999; 

            int pontosAtuais = CalcularPontosIgualdade(qtdAtual);
            int pontosFuturos = CalcularPontosIgualdade(qtdAtual + 1);
            int ganhoImediato = pontosFuturos - pontosAtuais;

            prioridade += ganhoImediato * 80;

     
            if (qtdAtual >= 4)
                prioridade += 200;
        }

        
        if (cercado is CercadoMataTripla)
        {
            int qtdAtual = cercado.Dinossauros.Count;

            if (qtdAtual >= 3)
                return -99999;

            if (qtdAtual == 2)
                prioridade += 800;
            else if (qtdAtual == 1)
                prioridade += 150; 
            else if (qtdAtual == 0)
                prioridade += 30;
        }



        if (cercado is CercadoAmor)
        {
            int qtdAtual = cercado.Dinossauros.Count;

            if (qtdAtual >= 6)
                return -99999; 
            int quantidadeEspecieNoCercado = 0;

            foreach (var dino in cercado.Dinossauros)
            {
                if (dino.Sigla == dinossauro.Sigla)
                {
                    quantidadeEspecieNoCercado++;
                }
            }

            int paresAtuais = quantidadeEspecieNoCercado / 2;
            int paresFuturos = (quantidadeEspecieNoCercado + 1) / 2;
            int ganhoImediato = (paresFuturos - paresAtuais) * 5;


            switch(quantidadeEspecieNoCercado)
            {
                case 0:
                    int quantidadeNaMao = 0;
                    foreach (var dino in this.Dinossauros)
                    {
                        if (dino.Sigla == dinossauro.Sigla)
                            quantidadeNaMao++;
                    }
                    if (quantidadeNaMao >= 2)
                    {
                        prioridade += 80;
                    }
                    else
                    {
                        prioridade += 20;
                    }
                    break;
                case 1:
                    prioridade += 400;
                    break;
                case 2:
                    prioridade += 150;
                    break;
                case 3:
                    prioridade += 350;
                    break;
                case 4:
                    prioridade += 120;
                    break;
                case 5:
                    prioridade += 300;
                    break;
                default:
                    break;
            }


            if (partida.JogadorComDado != null &&
                partida.JogadorComDado.IdJogador == this.IdJogador)
            {
                prioridade += 50;
            }

            if (dinossauro is TiranossauroRex)
            {
                prioridade -= 2000;
            }
        }

        if (cercado is CercadoReiFloresta)
        {
            if (cercado.Dinossauros.Count >= 1)
                return -99999; 

       
            bool colocarEmOutrosLugares = VerificarSeDinoUtilEmOutrosCercados(dinossauro, partida);

            if (colocarEmOutrosLugares)
            {
                prioridade += 5; 
            }
            else
            {
               
                prioridade += 40;
            }
        }

        if (cercado is CercadoSolitario)
        {
            if (cercado.Dinossauros.Count >= 1)
            {
                return -99999;
            }
            if (dinossauro is TiranossauroRex)
            {
                return -99999; 
            }

            bool especieJaExiste = false;
            string lugaresOndeExiste = "";

            foreach (Cercado outroCercado in partida.Tabuleiro.Cercados)
            {
                if (outroCercado == cercado) continue;

                foreach (var dinoExistente in outroCercado.Dinossauros)
                {
                    if (dinoExistente.Sigla == dinossauro.Sigla)
                    {
                        especieJaExiste = true;
                        lugaresOndeExiste += $"{outroCercado.NomeCercado} ({outroCercado.SiglaCercado}), ";
                        break;
                    }
                }
            }

            if (especieJaExiste)
            {
                return -99999;
            }

            int quantidadeNaMao = 0;
            foreach (var dino in this.Dinossauros)
            {
                if (dino.Sigla == dinossauro.Sigla)
                    quantidadeNaMao++;
            }

            if (quantidadeNaMao > 1)
            {
                return -99999;
            }

            prioridade += 150;

            return prioridade;
        }

        if (cercado is Rio)
        {
            
            bool temOutraOpcao = false;
            foreach (Cercado outroCercado in partida.Tabuleiro.Cercados)
            {
                if (outroCercado is Rio) continue;

                ValidarJogada teste = RegraJogada.Validar(
                    partida.Dado, outroCercado, dinossauro,
                    this, partida.JogadorComDado
                );

                if (teste.Valido)
                {
                    temOutraOpcao = true;
                    break;
                }
            }

            if (temOutraOpcao)
                return -10000; 
            else
                prioridade = -5000; 
        }

        if (partida.JogadorComDado != null &&
            partida.JogadorComDado.IdJogador == this.IdJogador)
        {
            prioridade += 150;
        }

        if (dinossauro is TiranossauroRex)
        {
            if (cercado is CercadoIgualdade || cercado is CercadoSolitario)
            {
                prioridade -= 5000;
            }


        }

        return prioridade;
    }


    private int CalcularPontosDiferenca(int quantidade)
    {
        int[] tabelaPontuacao = { 0, 1, 3, 6, 10, 15, 21 };
        if (quantidade < 0 || quantidade >= tabelaPontuacao.Length)
            return 0;
        return tabelaPontuacao[quantidade];
    }

    private int CalcularPontosIgualdade(int quantidade)
    {
        int[] tabelaPontuacao = { 0, 2, 4, 8, 12, 18, 24 };
        if (quantidade < 0 || quantidade >= tabelaPontuacao.Length)
            return 0;
        return tabelaPontuacao[quantidade];
    }

    private bool VerificarSeDinoUtilEmOutrosCercados(Dinossauro dinossauro, Partida partida)
    {
        foreach (Cercado cercado in partida.Tabuleiro.Cercados)
        {
            if (cercado is CercadoMataTripla && cercado.Dinossauros.Count == 2)
            {
                return true;
            }
        }
        foreach (Cercado cercado in partida.Tabuleiro.Cercados)
        {
            if (cercado is CercadoAmor)
            {
                foreach (var dino in cercado.Dinossauros)
                {
                    if (dino.Sigla == dinossauro.Sigla)
                        return true;
                }
            }
        }
        int quantidadeNaMao = 0;
        foreach (var dino in this.Dinossauros)
        {
            if (dino.Sigla == dinossauro.Sigla)
                quantidadeNaMao++;
        }

        if (quantidadeNaMao >= 2)
            return true;

        foreach (Cercado cercado in partida.Tabuleiro.Cercados)
        {
            if (cercado is CercadoDiferenca && cercado.Dinossauros.Count < 6)
            {
                bool especieJaExiste = false;
                foreach (var dino in cercado.Dinossauros)
                {
                    if (dino.Sigla == dinossauro.Sigla)
                    {
                        especieJaExiste = true;
                        break;
                    }
                }
                if (!especieJaExiste)
                    return true;
            }
        }

        return false;
    }

}