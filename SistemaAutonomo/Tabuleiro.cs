using System;
using System.Collections.Generic;
using Draft;

public class Tabuleiro
{
    List<Cercado> cercados;

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

        string dinossauro = "";
        switch (siglaDinossauro)
        {
            case "Br":
                dinossauro = "Tem " + quantidade + " de Braquiossauro no ";
                break;
            case "Ep":
                dinossauro = "Tem " + quantidade + " de Espinossauro no ";
                break;
            case "Et":
                dinossauro = "Tem " + quantidade + " de Estegossauro no ";
                break;
            case "Pa":
                dinossauro = "Tem " + quantidade + " de Parasaurolófo no ";
                break;
            case "Ti":
                dinossauro = "Tem " + quantidade + " de Tiranossauro-Rex no ";
                break;
            case "Tr":
                dinossauro = "Tem " + quantidade + " de Tricerátops no ";
                break;
        }

        string cercado = "";
        switch (siglaCercado)
        {
            case "CD":
                cercado = "cercado da Diferença";
                break;
            case "FI":
                cercado = "cercado da Igualdade";
                break;
            case "IS":
                cercado = "cercado Solitário";
                break;
            case "MT":
                cercado = "cercado Triplo";
                break;
            case "PA":
                cercado = "cercado do Amor";
                break;
            case "RI":
                cercado = "Rio";
                break;
            case "RS":
                cercado = "cercado do Rei da Selva";
                break;
        }
        return dinossauro + cercado;
    }
}

