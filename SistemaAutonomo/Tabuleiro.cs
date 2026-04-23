using System;
using System.Collections.Generic;
using Draft;


public class Tabuleiro
{
    List<Cercado> cercados;
    List<Dinossauro> dinossauros;

    public List<Cercado> Cercados { get { return cercados; } set { cercados = value; } }

    public Tabuleiro()
    {
        cercados = new List<Cercado>
           {
               new CercadoIgualdade(30, 49),
               new CercadoReiFloresta(412, 43),
               new CercadoMataTripla(60, 190),
               new CercadoDiferenca(352, 228),
               new CercadoAmor(86, 331),
               new CercadoSolitario(475, 309),
               new Rio(243, 345)
           };

        dinossauros = new List<Dinossauro>
        {
            new Braquiossauro(),
            new Espinossauro(),
            new Estegossauro(),
            new Parasaurolofo(),
            new TiranossauroRex(),
            new Triceratops()
        };
    }

    public string ExibirTabuleiroJogador(Jogador jogador)
    {
        string tabuleiro = Jogo.ExibirTabuleiro(jogador.IdJogador, jogador.SenhaJogador);
        if (TratarErro.Verificar(tabuleiro))
            return "";

        // Normaliza quebras de linha e espaços antes de fazer o split
        tabuleiro = tabuleiro.Replace("\r", "").Trim();
        string[] splitTabuleiro = tabuleiro.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

        string siglaCercado = splitTabuleiro[0].Trim();
        string siglaDinossauro = splitTabuleiro[1].Trim();
        string quantidade = splitTabuleiro[2].Trim();

        if (quantidade.Contains("\n")) quantidade = quantidade.Split('\n')[0].Trim();

        string nomeDinossauro = "";
        foreach (Dinossauro d in dinossauros)
        {
            if (d.Sigla == siglaDinossauro)
            {
                nomeDinossauro = d.NomeDinossauro;
                break;
            }
        }
        string dinossauro = "Tem " + quantidade + " de " + nomeDinossauro + " no ";

        string cercado = "";
        foreach (Cercado c in cercados)
        {
            if (c.SiglaCercado == siglaCercado)
            {
                cercado = c.NomeCercado;
                break;
            }
        }

        return dinossauro + cercado;
    }
}

