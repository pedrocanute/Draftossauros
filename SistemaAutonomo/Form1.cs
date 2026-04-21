using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Draft;

namespace SistemaAutonomo
{
    public partial class Form1 : Form
    {
        Partida partidaCriada;
        List<Jogador> listaJogadores = new List<Jogador>();
        Dictionary<string, int> qtdDinossaurosCercado = new Dictionary<string, int>();
        Jogador jogadorLocal;
        Tabuleiro tabuleiro = new Tabuleiro();

        public Form1(Partida partida)
        {
            partidaCriada = partida;
            InitializeComponent();

            pnlTabuleiro.BackgroundImage = Properties.Resources.Tabuleiro;
            pnlTabuleiro.BackgroundImageLayout = ImageLayout.Stretch;

            this.BackgroundImage = Properties.Resources.FundoGame;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            lblVersao2.Text = Jogo.versao;
            lblIdPartida.Text = partidaCriada.IdPartida.ToString();
            lblNomePartida.Text = partidaCriada.NomePartida;
            lblDataPartida.Text = partidaCriada.DataPartida;

            jogadorLocal = new Jogador(0);
            partidaCriada.JogadorLocal = jogadorLocal;
            partidaCriada.JogadorComDado = new Jogador(0);
            partidaCriada.Tabuleiro = tabuleiro;

            qtdDinossaurosCercado["FI"] = 0;
            qtdDinossaurosCercado["RS"] = 0;
            qtdDinossaurosCercado["MT"] = 0;
            qtdDinossaurosCercado["CD"] = 0;
            qtdDinossaurosCercado["PA"] = 0;
            qtdDinossaurosCercado["IS"] = 0;
            qtdDinossaurosCercado["RI"] = 0;

        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            ListarJogadores();
        } //feito

        private void ListarJogadores()
        {
            string[] jogadores = partidaCriada.ListarJogadores();
            lstListaJogadores.Items.Clear();

            if (jogadores == null)
            {
                lstListaJogadores.Items.Add("Nao ha jogadores");
                return;
            }

            for (int i = 0; i < partidaCriada.Jogadores.Count; i++)
            {
                Jogador jogador = partidaCriada.Jogadores[i];
                lstListaJogadores.Items.Add($"ID: {jogador.IdJogador} - Jogador: {jogador.NomeJogador} | Pontuação: {jogador.Pontuacao}");
            }
        }

        private void btnCriarJogador_Click(object sender, EventArgs e) // feito
        {
            if (jogadorLocal != null && jogadorLocal.IdJogador > 0)
            {
                MessageBox.Show("Somente um jogador por formulario", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (partidaCriada.Jogadores.Count >= 5)
            {
                MessageBox.Show("Quantidade máxima de jogadores: 5", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNomeJogador.Text == "")
            {
                MessageBox.Show("Informe o nome do jogador.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            jogadorLocal.NomeJogador = txtNomeJogador.Text;

            if (!partidaCriada.CriarJogador(jogadorLocal))
                return;

            lblIdJogador.Text = jogadorLocal.IdJogador.ToString();
            lblSenhaJogador.Text = jogadorLocal.SenhaJogador;
        } 

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (jogadorLocal.IdJogador == 0 || jogadorLocal.SenhaJogador == null)
            {
                MessageBox.Show("O jogador ainda não foi autenticado corretamente na partida.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListarJogadores();

            partidaCriada.IniciarPartida();

            lblDadoSorteado.Text = partidaCriada.Dado.ObterDescricao();
            pbDado.BackgroundImage = partidaCriada.Dado.ObterImagem();
            lblJogadorDado.Text = partidaCriada.JogadorComDado.NomeJogador;

            ExibirMaoJogador(jogadorLocal.IdJogador);
        }

        private void btnRealizarJogada_Click(object sender, EventArgs e)
        {
            if (jogadorLocal.DinossauroSelecionado == null)
            {
                jogadorLocal.DinossauroSelecionado = ObterDinossauroSelecionadoNaLista();
            }

            Cercado cercadoSelecionado = ObterCercadoSelecionado();

            Dinossauro dinossauroJogado = jogadorLocal.DinossauroSelecionado;

            ValidarJogada resultado = jogadorLocal.RealizarJogada(cercadoSelecionado, partidaCriada.Dado, partidaCriada.JogadorComDado );

            if (!resultado.Valido)
            {
                MessageBox.Show(resultado.Mensagem, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int indicePosicaoDinossauro = cercadoSelecionado.Dinossauros.Count - 1;

            DesenharDinossauroNoCercado(dinossauroJogado, cercadoSelecionado, indicePosicaoDinossauro);

            AtualizarInformacoesJogador();
        }

        public void ExibirMaoJogador(int idJogador) //Chat Debugou e fez dois dicionarios
        {
            jogadorLocal.AtualizarMao();

            lblRodada.Text = jogadorLocal.RodadaAtual;
            lstMaoDinossauros.Items.Clear();

            Dictionary<string, int> contagemDinossauros = new Dictionary<string, int>();
            Dictionary<string, string> nomesDinossauros = new Dictionary<string, string>();

            foreach (Dinossauro dinossauro in jogadorLocal.Dinossauros)
            {
                //Se não existir o dinossauro no dicionário, inicia a contagem e armazena o nome
                if (!contagemDinossauros.ContainsKey(dinossauro.Sigla))
                {
                    contagemDinossauros[dinossauro.Sigla] = 0;
                    nomesDinossauros[dinossauro.Sigla] = dinossauro.NomeDinossauro;
                }

                //Se já existir, apenas soma a quantidade
                contagemDinossauros[dinossauro.Sigla]++;
            }

            foreach (KeyValuePair<string, int> item in contagemDinossauros) // !VERIFICAR O QUE SIGNIFICA O KeyValuePair!
            {
                lstMaoDinossauros.Items.Add(nomesDinossauros[item.Key] + " Qtd: " + item.Value);
            }

            AtualizarBotoesDinos(jogadorLocal.Dinossauros);
        }

        private void AtualizarBotoesDinos(List<Dinossauro> listaDinossauros) 
        {
            Button[] botoes = { btnPrimeiroDino, btnSegundoDino, btnTerceiroDino, btnQuartoDino, btnQuintoDino, btnSextoDino };

            //Itera sobre os botões
            for (int i = 0; i < botoes.Length; i++)
            {
                //Atualiza o botão de acordo com os dinossarauros dentro da lista de dinossauros, e conforme os dinossauros forem sendo reduzidos, os botões se tornam invisíveis
                if (i < listaDinossauros.Count)
                {
                    botoes[i].Tag = listaDinossauros[i];
                    botoes[i].BackgroundImage = listaDinossauros[i].ImagemDinossauro;
                    botoes[i].Visible = true;
                    botoes[i].BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                {
                    botoes[i].Tag = null;
                    botoes[i].BackgroundImage = null;
                    botoes[i].Visible = false;
                }
            }
        }

        private void btnVerificarTurno_Click(object sender, EventArgs e)
        {
            partidaCriada.AtualizarJogadoresDoServidor();
            partidaCriada.AtualizarInfoJogador();

            lblDadoSorteado.Text = partidaCriada.Dado.ObterDescricao();
            pbDado.BackgroundImage = partidaCriada.Dado.ObterImagem();

            if (partidaCriada.JogadorComDado != null)
                lblJogadorDado.Text = partidaCriada.JogadorComDado.NomeJogador;
            else
                lblJogadorDado.Text = "Desconhecido";

            jogadorLocal.DinossauroSelecionado = null;

            ExibirMaoJogador(jogadorLocal.IdJogador);
        }

        private void AtualizarInformacoesJogador()
        {
            partidaCriada.AtualizarInfoJogador();

            lblDadoSorteado.Text = partidaCriada.Dado.ObterDescricao();
            pbDado.BackgroundImage = partidaCriada.Dado.ObterImagem();

            if (partidaCriada.JogadorComDado != null)
                lblJogadorDado.Text = partidaCriada.JogadorComDado.NomeJogador;

            jogadorLocal.DinossauroSelecionado = null;

            ExibirMaoJogador(jogadorLocal.IdJogador);
        }

        private void DesenharDinossauroNoCercado(Dinossauro dinossauro, Cercado cercado, int indice)
        {
            PictureBox novoDino = new PictureBox();
            novoDino.Size = new Size(30, 30);
            novoDino.SizeMode = PictureBoxSizeMode.StretchImage;
            novoDino.BackColor = Color.Transparent;
            novoDino.Image = dinossauro.ImagemDinossauro;

            int offsetX = 30 * indice;
            novoDino.Location = new Point(cercado.PosX + offsetX, cercado.PosY);

            pnlTabuleiro.Controls.Add(novoDino);
            novoDino.BringToFront();
        }

        private void btnPrimeiroDino_Click(object sender, EventArgs e)
        {
            jogadorLocal.DinossauroSelecionado = btnPrimeiroDino.Tag as Dinossauro;
        }

        private void btnSegundoDino_Click(object sender, EventArgs e)
        {
            jogadorLocal.DinossauroSelecionado = btnSegundoDino.Tag as Dinossauro;
        }

        private void btnTerceiroDino_Click(object sender, EventArgs e)
        {
            jogadorLocal.DinossauroSelecionado = btnTerceiroDino.Tag as Dinossauro;
        }

        private void btnQuartoDino_Click(object sender, EventArgs e)
        {
            jogadorLocal.DinossauroSelecionado = btnQuartoDino.Tag as Dinossauro;
        }

        private void btnQuintoDino_Click(object sender, EventArgs e)
        {
            jogadorLocal.DinossauroSelecionado = btnQuintoDino.Tag as Dinossauro;
        }

        private void btnSextoDino_Click(object sender, EventArgs e)
        {
            jogadorLocal.DinossauroSelecionado = btnSextoDino.Tag as Dinossauro;
        }

        public Dinossauro ObterDinossauroSelecionadoNaLista()
        {
            if (lstMaoDinossauros.SelectedItem == null)
                return null;

            string textoSelecionado = lstMaoDinossauros.SelectedItem.ToString();

            foreach (Dinossauro dinossauro in jogadorLocal.Dinossauros)
            {
                if (textoSelecionado.StartsWith(dinossauro.NomeDinossauro))
                    return dinossauro;
            }

            return null;
        }

        public Cercado ObterCercadoSelecionado()
        {
            if (lstCercados.SelectedItem == null)
                return null;

            string nomeCercado = lstCercados.SelectedItem.ToString().Trim();

            foreach (Cercado cercado in tabuleiro.Cercados)
            {
                if (nomeCercado == "Igualdade" && cercado is CercadoIgualdade)
                    return cercado;

                if (nomeCercado == "Rei da Selva" && cercado is CercadoReiFloresta)
                    return cercado;

                if (nomeCercado == "Mata Tripla" && cercado is CercadoMataTripla)
                    return cercado;

                if (nomeCercado == "Diferença" && cercado is CercadoDiferenca)
                    return cercado;

                if (nomeCercado == "Amor" && cercado is CercadoAmor)
                    return cercado;

                if (nomeCercado == "Solitária" && cercado is CercadoSolitario)
                    return cercado;

                if (nomeCercado == "Rio" && cercado is Rio)
                    return cercado;
            }

            return null;
        }
    }
}