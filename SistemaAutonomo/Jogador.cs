using Draft;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class Jogador
{

    int idJogador;
    string senhaJogador;
    string nomeJogador;
    int pontuacao;
    public List<Dinossauro> dinossauros = new List<Dinossauro>();
    Dinossauro dinossauroSelecionado = null;
    string rodadaAtual;

    public int IdJogador { get { return idJogador; } set { idJogador = value; } }

    public string SenhaJogador { get { return senhaJogador; } set { senhaJogador = value; } }

    public string NomeJogador { get { return nomeJogador; } set { nomeJogador = value; } }

    public int Pontuacao { get { return pontuacao; } set { pontuacao = value; } }

    public List<Dinossauro> Dinossauros { get { return dinossauros; } set {  dinossauros = value; }}

    public Dinossauro DinossauroSelecionado { get { return dinossauroSelecionado; } set { dinossauroSelecionado = value; } }

    public string RodadaAtual { get { return rodadaAtual; } set {  rodadaAtual = value; }}

    public Jogador(int id, string senha) {
        this.IdJogador = id;
        this.SenhaJogador = senha;
    }
    public Jogador(int id) : this(id, null) { }

    public void RealizarJogada()
    {
        

    }

    public void AtualizarMao()
    {
        string retorno = Jogo.ExibirMao(IdJogador, SenhaJogador);

        if (TratarErro.Verificar(retorno))
            return;

        string[] linhas = TratarRetorno.SepararLinha(retorno);

        if (linhas == null || linhas.Length == 0)
            return;

        RodadaAtual = linhas[0].Trim();
        Dinossauros.Clear();

        for (int i = 1; i < linhas.Length; i++)
        {
            /*if (string.IsNullOrWhiteSpace(linhas[i]))
                continue;*/

            string[] splitDinossauro = linhas[i].Split(',');

            if (splitDinossauro.Length < 2)
                continue;

            string sigla = splitDinossauro[0].Trim();
            string textoQuantidade = splitDinossauro[1].Trim();

            if (string.IsNullOrWhiteSpace(sigla) || string.IsNullOrWhiteSpace(textoQuantidade))
                continue;

            int quantidade;
            if (!int.TryParse(textoQuantidade, out quantidade))
                continue;

            for (int j = 0; j < quantidade; j++)
            {
                Dinossauro novoDinossauro = CriarDinossauroPelaSigla(sigla);

                if (novoDinossauro != null)
                    Dinossauros.Add(novoDinossauro);
            }
        }
    }

    public Dinossauro CriarDinossauroPelaSigla(string sigla)
    {
        switch (sigla)
        {
            case "Br":
                return new Braquiossauro();
            case "Ep":
                return new Espinossauro();
            case "Et":
                return new Estegossauro();
            case "Pa":
                return new Parasaurolofo();
            case "Ti":
                return new TiranossauroRex();
            case "Tr":
                return new Triceratops();
            default:
                return null;
        }
    }

    public void RemoverDinossauroDaMao(Dinossauro dinossauro)
    {
        if (dinossauro != null)
            Dinossauros.Remove(dinossauro);
    }
}