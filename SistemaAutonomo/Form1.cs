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
        TradutorSigla tradutor = new TradutorSigla();

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
            string[] jogadores = partidaCriada.ListarJogadores();
            lstListaJogadores.Items.Clear();

            if (jogadores == null) { 
                lstListaJogadores.Items.Add("Nao ha jogadores");
                return;
            }

            if (jogadores.Length == 0)
            {
                lstListaJogadores.Items.Add("Não há jogadores.");
                return;
            }

            for (int i = 0; i < jogadores.Length; i++)
            {
                lstListaJogadores.Items.Add(jogadores[i]);
            }
        } //feito

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
            if (jogadorLocal == null)
            {
                MessageBox.Show("Crie um jogador!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (jogadorLocal.IdJogador == 0 || jogadorLocal.SenhaJogador == null)
            {
                MessageBox.Show("O jogador ainda não foi autenticado corretamente na partida.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            partidaCriada.IniciarPartida();

            lblDadoSorteado.Text = partidaCriada.Dado.ObterDescricao();
            pbDado.BackgroundImage = partidaCriada.Dado.ObterImagem();

           ExibirMaoJogador(jogadorLocal.IdJogador);

        }

        private void btnRealizarJogada_Click(object sender, EventArgs e)
        {
            if (jogadorLocal.DinossauroSelecionado == null)
            {
                jogadorLocal.DinossauroSelecionado = ObterDinossauroSelecionadoNaLista();
            }

            if (jogadorLocal.DinossauroSelecionado == null)
            {
                MessageBox.Show("Selecione um dinossauro para jogar!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cercado cercadoSelecionado = ObterCercadoSelecionado();

            if (cercadoSelecionado == null)
            {
                MessageBox.Show("Selecione um cercado para jogar!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ValidarJogada resultado = RegraJogada.Validar(partidaCriada.Dado,cercadoSelecionado,jogadorLocal,partidaCriada.JogadorComDado);

            if (!resultado.Valido)
            {
                MessageBox.Show(resultado.Mensagem, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string resultadoJogar = Jogo.Jogar(jogadorLocal.IdJogador,jogadorLocal.SenhaJogador,jogadorLocal.DinossauroSelecionado.Sigla,cercadoSelecionado.SiglaCercado);

            if (!string.IsNullOrEmpty(resultadoJogar) && resultadoJogar.StartsWith("ERRO"))
            {
                MessageBox.Show(resultadoJogar, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int indice = cercadoSelecionado.Dinossauros.Count;

            DesenharDinossauroNoCercado(jogadorLocal.DinossauroSelecionado,cercadoSelecionado,indice);

            cercadoSelecionado.Dinossauros.Add(jogadorLocal.DinossauroSelecionado);
            jogadorLocal.RemoverDinossauroDaMao(jogadorLocal.DinossauroSelecionado);
            jogadorLocal.DinossauroSelecionado = null;

            AtualizarInformacoesJogador();
        }

        public void ExibirMaoJogador(int idJogador)
        {
            jogadorLocal.AtualizarMao();

            lblRodada.Text = jogadorLocal.RodadaAtual;
            lstMaoDinossauros.Items.Clear();

            Dictionary<string, int> contagem = new Dictionary<string, int>();
            Dictionary<string, string> nomes = new Dictionary<string, string>();

            foreach (Dinossauro dinossauro in jogadorLocal.Dinossauros)
            {
                if (!contagem.ContainsKey(dinossauro.Sigla))
                {
                    contagem[dinossauro.Sigla] = 0;
                    nomes[dinossauro.Sigla] = dinossauro.NomeDinossauro;
                }

                contagem[dinossauro.Sigla]++;
            }

            foreach (KeyValuePair<string, int> item in contagem)
            {
                lstMaoDinossauros.Items.Add(nomes[item.Key] + " Qtd: " + item.Value);
            }

            AtualizarBotoesDinos(jogadorLocal.Dinossauros);
        }

        private void AtualizarBotoesDinos(List<Dinossauro> listaDinossauros) 
        {
            Button[] botoes = { btnPrimeiroDino, btnSegundoDino, btnTerceiroDino, btnQuartoDino, btnQuintoDino, btnSextoDino };

            for (int i = 0; i < botoes.Length; i++)
            {
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