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
        Partida partidaCriada; //= new Partida(); //Instanciando a partida
        List<Jogador> listaJogadores = new List<Jogador>();
        Dictionary<string, int> qtdDinossaurosCercado = new Dictionary<string, int>();
        Jogador jogadorAtual;

        public Form1(Partida partida)
        {
            partidaCriada = partida;
            InitializeComponent();

            pnlTabuleiro.BackgroundImage = Properties.Resources.Tabuleiro;
            pnlTabuleiro.BackgroundImageLayout = ImageLayout.Stretch;

            this.BackgroundImage = Properties.Resources.FundoGame;
            this.BackgroundImageLayout = ImageLayout.Stretch;


            lblVersao2.Text = Jogo.versao;
            lblIdPartida.Text = partidaCriada.idPartida.ToString();
            lblNomePartida.Text = partidaCriada.NomePartida;
            lblDataPartida.Text = partidaCriada.DataPartida;

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
            string retorno = Jogo.ListarJogadores(partidaCriada.idPartida);
            lstListaJogadores.Items.Clear();
            if (string.IsNullOrEmpty(retorno))
            {
                lstListaJogadores.Items.Add("Não há jogadores");
                return;
            }

            retorno = retorno.Replace("\r", "");
            string[] jogadores = retorno.Split('\n');

            lstListaJogadores.Items.Clear();

            for (int i = 0; i < jogadores.Length; i++)
            {
                lstListaJogadores.Items.Add(jogadores[i]);
            }

        }

        private void btnCriarJogador_Click(object sender, EventArgs e)
        {
            if (listaJogadores.Count >= 5)
            {
                MessageBox.Show("Quantidade maxima de jogadores: 5", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string infoJogador = Jogo.Entrar(partidaCriada.idPartida, txtNomeJogador.Text, partidaCriada.Senha);


            if (infoJogador.StartsWith("ERRO"))
            {
                MessageBox.Show(infoJogador, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            infoJogador = infoJogador.Replace("\r", "").Replace("\n", "");
            string[] splitInfoJogador = infoJogador.Split(',');

            int idJogador = Convert.ToInt32(splitInfoJogador[0]);
            string senhaJogador = splitInfoJogador[1];

            lblIdJogador.Text = idJogador.ToString();
            lblSenhaJogador.Text = senhaJogador;

            CriarJogador(idJogador, txtNomeJogador.Text, senhaJogador);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (jogadorAtual == null)
            {
                MessageBox.Show("Crie um jogador!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Atualizarlistarogadores();

            LancarDado(jogadorAtual);

            ExibirMaoJogador(jogadorAtual.Id);

            lblIdJogador.Text = jogadorAtual.Id.ToString();
            lblJogadorDado.Text = jogadorAtual.Nome;
            lblNomeJogador.Text = jogadorAtual.Nome;
        }

        private void btnRealizarJogada_Click(object sender, EventArgs e)
        {
            //Verifica qual dinossauro foi selecionado e atribui a sigla correspondente para realizar a jogada e trata o erro do jogador não ter selecionado um cercado para jogar
            if (jogadorAtual.DinossauroSelecionado == null)
            {
                MessageBox.Show("Selecione um dinossauro para jogar!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dinossauroSelecionado = jogadorAtual.DinossauroSelecionado;

            //Verifica qual cercado foi selecionado e atribui a sigla correspondente para realizar a jogada e trata o erro do jogador não ter selecionado um cercado para jogar
            if (lstCercados.SelectedItem == null)
            {
                MessageBox.Show("Selecione um cercado para jogar!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cercadoSelecionado = lstCercados.SelectedItem.ToString().Trim();
            string siglaCercado = "";

            switch (cercadoSelecionado)
            {
                case "Igualdade":
                    siglaCercado = "FI";
                    break;
                case "Rei da Selva":
                    siglaCercado = "RS";
                    break;
                case "Mata Tripla":
                    siglaCercado = "MT";
                    break;
                case "Diferença":
                    siglaCercado = "CD";
                    break;
                case "Amor":
                    siglaCercado = "PA";
                    break;
                case "Solitária":
                    siglaCercado = "IS";
                    break;
                case "Rio":
                    siglaCercado = "RI";
                    break;
                default:
                    siglaCercado = "";
                    break;
            }

            //Realiza as checagens necessárias para validar a jogada (ignora o jogador que lançou o dado)
            int IdJogadorDoDado = Convert.ToInt32(lblIdJogador.Text);
            if (jogadorAtual.Id != IdJogadorDoDado)
            {
                switch (lblDadoSorteado.Text)
                {
                    case "Floresta":
                        if (lstCercados.SelectedItem.ToString() == "Amor" || lstCercados.SelectedItem.ToString() == "Solitária" || lstCercados.SelectedItem.ToString() == "Diferença")
                        {
                            MessageBox.Show("O dado sorteado é Floresta, você só pode jogar nos cercados Igualdade, Rei da Selva ou Mata Tripla!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        break;
                    case "Pradaria":
                        if (lstCercados.SelectedItem.ToString() == "Igualdade" || lstCercados.SelectedItem.ToString() == "Mata Tripla" || lstCercados.SelectedItem.ToString() == "Rei da Selva")
                        {
                            MessageBox.Show("O dado sorteado é Pradaria, você só pode jogar nos cercados Amor, Solitária ou Diferença!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        break;
                    case "Banheiros":
                        if (lstCercados.SelectedItem.ToString() == "Igualdade" || lstCercados.SelectedItem.ToString() == "Mata Tripla" || lstCercados.SelectedItem.ToString() == "Amor")
                        {
                            MessageBox.Show("O dado sorteado é Banheiros, você só pode jogar nos cercados Rei da Selva, Solitária ou Diferença!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        break;
                    case "Alimentação":
                        if (lstCercados.SelectedItem.ToString() == "Diferença" || lstCercados.SelectedItem.ToString() == "Rei da Selva" || lstCercados.SelectedItem.ToString() == "Solitária")
                        {
                            MessageBox.Show("O dado sorteado é Alimentação, você só pode jogar nos cercados Rei da Selva, Solitária ou Diferença!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        break;
                }

            }


            // Realiza a Jogada
            //Jogo.Jogar(jogadorAtual.Id, jogadorAtual.Senha, siglaDinossauro, siglaCercado);
            // preparar debug: quais siglas estão sendo enviadas
            string enviado = $"Dinossauro={dinossauroSelecionado}, Cercado={siglaCercado}";

            // chamar jogar e checar retorno
            //lblTesteDoThiago.Text = Jogo.VerificarTurno(partidaCriada.idPartida);
            string resultadoJogar = Jogo.Jogar(jogadorAtual.Id, jogadorAtual.Senha, dinossauroSelecionado, siglaCercado);

            // se houver erro, mostrar o que foi enviado e a resposta do servidor para diagnosticar
            if (!string.IsNullOrEmpty(resultadoJogar) && resultadoJogar.StartsWith("ERRO"))
            {
                string msg = $"Erro ao jogar. Enviado: {enviado}\nResposta servidor: {resultadoJogar}";
                MessageBox.Show(msg, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblTeste.Text = msg;
                lblTeste.Visible = true;
                return;
            }

            CriarDinossauroNoCercado(dinossauroSelecionado, siglaCercado); //ADICIONEI A FUNCAO DE COLOCAR O DINOSSAURo

            // Remove o dinossauro jogado da mão do jogador
            var dinossauroParaRemover = jogadorAtual.listaDinossauros.FirstOrDefault(d => d.SiglaNome == dinossauroSelecionado);
            if (dinossauroParaRemover != null)
            {
                jogadorAtual.listaDinossauros.Remove(dinossauroParaRemover);
            }

            AtualizarInformacoesJogador();
        }

        public void CriarJogador(int id, string nome, string senha)
        {
            jogadorAtual = new Jogador(id, senha);
            jogadorAtual.Nome = nome;
        }

        public Jogador BuscarJogador(int id)
        {
            Atualizarlistarogadores();
            foreach (Jogador jogador in listaJogadores)
            {
                if (jogador.Id == id)
                {
                    return jogador;
                }
            }
            MessageBox.Show("Jogador ja existe", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        public void ExibirMaoJogador(int idJogador)
        {
            if (jogadorAtual == null)
            {
                MessageBox.Show("Não temos a senha deste jogador localmente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            jogadorAtual.listaDinossauros.Clear();
            string maoJogador = Jogo.ExibirMao(jogadorAtual.Id, jogadorAtual.Senha);

            if (maoJogador.StartsWith("ERRO"))
            {
                MessageBox.Show(maoJogador, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            maoJogador = maoJogador.Replace("\r", "");
            string[] dinossauros = maoJogador.Split('\n');

            lblRodada.Text = dinossauros[0];

            lstMaoDinossauros.Items.Clear();

            for (int i = 1; i < dinossauros.Length; i++)
            {
                if (dinossauros[i] == "") continue;

                string[] splitDinossauros = dinossauros[i].Split(',');

                if (splitDinossauros.Length < 2) continue;

                string sigla = splitDinossauros[0];
                string quantidade = splitDinossauros[1];

                int quantidadeNumero = Convert.ToInt32(quantidade);

                // Adiciona o dinossauro à mão do jogador
                for (int j = 0; j < quantidadeNumero; j++)
                {
                    Dinossauros dinossauro = new Dinossauros(sigla);
                    jogadorAtual.listaDinossauros.Add(dinossauro);
                }

                switch (sigla)
                {
                    case "Br":
                        lstMaoDinossauros.Items.Add("Braquiossauro Qtd: " + quantidade);
                        break;
                    case "Ep":
                        lstMaoDinossauros.Items.Add("Espinossauro Qtd: " + quantidade);
                        break;
                    case "Et":
                        lstMaoDinossauros.Items.Add("Estegossauro Qtd: " + quantidade);
                        break;
                    case "Pa":
                        lstMaoDinossauros.Items.Add("Parasaurolófo Qtd: " + quantidade);
                        break;
                    case "Ti":
                        lstMaoDinossauros.Items.Add("Tiranossauro-Rex Qtd: " + quantidade);
                        break;
                    case "Tr":
                        lstMaoDinossauros.Items.Add("Tricerátops Qtd: " + quantidade);
                        break;
                }
            }

            AtualizarBotoesDinos(jogadorAtual.listaDinossauros);
        }

        private void AtualizarBotoesDinos(List<Dinossauros> listaDinossauros)
        {
            Button[] botoes = { btnPrimeiroDino, btnSegundoDino, btnTerceiroDino, btnQuartoDino, btnQuintoDino, btnSextoDino };

            for (int i = 0; i < botoes.Length; i++)
            {
                if (i < listaDinossauros.Count)
                {
                    botoes[i].Tag = listaDinossauros[i].SiglaNome;
                    switch (listaDinossauros[i].SiglaNome)
                    {
                        case "Br":
                            botoes[i].BackgroundImage = Properties.Resources.Braquiossauro;
                            break;
                        case "Ep":
                            botoes[i].BackgroundImage = Properties.Resources.Espinossauro;
                            break;
                        case "Et":
                            botoes[i].BackgroundImage = Properties.Resources.Estegossauro;
                            break;
                        case "Pa":
                            botoes[i].BackgroundImage = Properties.Resources.Parasaurolofo;
                            break;
                        case "Ti":
                            botoes[i].BackgroundImage = Properties.Resources.Tiranossauro_Rex;
                            break;
                        case "Tr":
                            botoes[i].BackgroundImage = Properties.Resources.Triceratops;
                            break;
                        default:
                            botoes[i].BackgroundImage = null;
                            botoes[i].Tag = null;
                            break;
                    }
                    botoes[i].Visible = true;
                }
                else
                {
                    botoes[i].BackgroundImage = null;
                    botoes[i].Visible = false;
                }
            }
        }

        public void LancarDado(Jogador jogador)
        {
            string dadoInicial = Jogo.Iniciar(jogador.Id, jogador.Senha);

            if (dadoInicial.StartsWith("ERRO"))
            {
                MessageBox.Show(dadoInicial, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] splitDadoInicial = dadoInicial.Split(',');
            int idJogador = Convert.ToInt32(splitDadoInicial[0]);
            string faceDoDado = splitDadoInicial[1];

            switch (faceDoDado)
            {
                case "AL":
                    lblDadoSorteado.Text = "Alimentação";
                    pbDado.BackgroundImage = Properties.Resources.FaceAlimentacao;
                    break;
                case "FL":
                    lblDadoSorteado.Text = "Floresta";
                    pbDado.BackgroundImage = Properties.Resources.FaceFloresta;
                    break;
                case "PR":
                    lblDadoSorteado.Text = "Pradaria";
                    pbDado.BackgroundImage = Properties.Resources.FacePradaria;
                    break;
                case "TI":
                    lblDadoSorteado.Text = "T-Rex";
                    pbDado.BackgroundImage = Properties.Resources.FaceTRex;
                    break;
                case "VZ":
                    lblDadoSorteado.Text = "Cercado Vazio";
                    pbDado.BackgroundImage = Properties.Resources.FaceCercadoVazio;
                    break;
                case "WC":
                    lblDadoSorteado.Text = "Banheiros";
                    pbDado.BackgroundImage = Properties.Resources.FaceBanheiro;
                    break;
            }
        }

        public void ExibirTabuleiroJogador(Jogador jogador)
        {
            string tabuleiro = Jogo.ExibirTabuleiro(jogador.Id, jogador.Senha);
            if (string.IsNullOrEmpty(tabuleiro) || tabuleiro.StartsWith("ERRO"))
            {
                MessageBox.Show(tabuleiro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Normaliza quebras de linha e espaços antes de fazer o split
            tabuleiro = tabuleiro.Replace("\r", "").Trim();
            string[] splitTabuleiro = tabuleiro.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            if (splitTabuleiro.Length < 3)
            {
                // resposta inesperada
                lblTeste.Text = "Resposta do servidor inesperada: [" + tabuleiro + "]";
                lblTeste.Visible = true;
                return;
            }

            string siglaCercado = splitTabuleiro[0].Trim();
            string siglaDinossauro = splitTabuleiro[1].Trim();
            string quantidade = splitTabuleiro[2].Trim();
            // em alguns casos a quantidade pode trazer uma nova linha com outros registros;
            // pega apenas a primeira linha
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
            lblTeste.Text = dinossauro + cercado;
        }

        private void btnVerificarTurno_Click(object sender, EventArgs e)
        {
            AtualizarInformacoesJogador();
        }

        private void CriarDinossauroNoCercado(string siglaDinossauro, string siglaCercado)
        {
            PictureBox novoDino = new PictureBox();
            novoDino.Size = new Size(30, 30);
            novoDino.SizeMode = PictureBoxSizeMode.StretchImage;
            novoDino.BackColor = Color.Transparent;
            int offsetX;

            switch (siglaDinossauro)
            {
                case "Br":
                    novoDino.Image = Properties.Resources.Braquiossauro;
                    break;
                case "Ep":
                    novoDino.Image = Properties.Resources.Espinossauro;
                    break;
                case "Et":
                    novoDino.Image = Properties.Resources.Estegossauro;
                    break;
                case "Pa":
                    novoDino.Image = Properties.Resources.Parasaurolofo;
                    break;
                case "Ti":
                    novoDino.Image = Properties.Resources.Tiranossauro_Rex;
                    break;
                case "Tr":
                    novoDino.Image = Properties.Resources.Triceratops;
                    break;
                default:
                    return;
            }

            switch (siglaCercado)
            {
                case "FI":
                    offsetX = 30 * qtdDinossaurosCercado["FI"];
                    novoDino.Location = new Point(30+ offsetX, 49);
                    qtdDinossaurosCercado["FI"]++;
                    break;
                case "RS":
                    offsetX = 30 * qtdDinossaurosCercado["RS"];
                    novoDino.Location = new Point(412 + offsetX, 43);
                    qtdDinossaurosCercado["RS"]++;
                    break;
                case "MT":
                    offsetX = 30 * qtdDinossaurosCercado["MT"];
                    novoDino.Location = new Point(60 + offsetX, 190);
                    qtdDinossaurosCercado["MT"]++;
                    break;
                case "CD":
                    offsetX = 30 * qtdDinossaurosCercado["CD"];
                    novoDino.Location = new Point(352 + offsetX, 228);
                    qtdDinossaurosCercado["CD"]++;
                    break;
                case "PA":
                    offsetX = 30 * qtdDinossaurosCercado["PA"];
                    novoDino.Location = new Point(86 + offsetX, 331);
                    qtdDinossaurosCercado["PA"]++;
                    break;
                case "IS":
                    offsetX = 30 * qtdDinossaurosCercado["IS"];
                    novoDino.Location = new Point(475 + offsetX, 309);
                    qtdDinossaurosCercado["IS"]++;
                    break;
                case "RI":
                    offsetX = 30 * qtdDinossaurosCercado["RI"];
                    novoDino.Location = new Point(243 + offsetX, 345);
                    qtdDinossaurosCercado["RI"]++;
                    break;
                default:
                    return;
            }

            pnlTabuleiro.Controls.Add(novoDino);
            novoDino.BringToFront();
        }

        void Atualizarlistarogadores()
        {
            string retornoJogadores = Jogo.ListarJogadores(partidaCriada.idPartida);

            if (retornoJogadores.StartsWith("ERRO"))
            {
                MessageBox.Show(retornoJogadores, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string retorno = retornoJogadores.Replace("\r", "").Trim();
            string[] linhas = retorno.Split('\n');

            foreach (string linha in linhas)
            {
                string[] dados = linha.Split(',');

                int id = Convert.ToInt32(dados[0]);
                string nome = dados[1];
                int pontuacao = Convert.ToInt32(dados[2]);

                Jogador jogador = new Jogador(id);
                jogador.Nome = nome;

                listaJogadores.Add(jogador);
            }

            if (listaJogadores.Count < 2)
            {
                MessageBox.Show(retornoJogadores, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        void AtualizarInformacoesJogador()
        {
            string retornoAtualizar = Jogo.VerificarPartida(partidaCriada.idPartida);

            string[] linhas = retornoAtualizar.Split(',');
            string faceDoDado = linhas[4].Trim();
            Jogador JogadorDado = BuscarJogador(Convert.ToInt32(linhas[3].Trim()));

            switch (faceDoDado)
            {
                case "AL":
                    lblDadoSorteado.Text = "Alimentação";
                    pbDado.BackgroundImage = Properties.Resources.FaceAlimentacao;
                    break;
                case "FL":
                    lblDadoSorteado.Text = "Floresta";
                    pbDado.BackgroundImage = Properties.Resources.FaceFloresta;
                    break;
                case "PR":
                    lblDadoSorteado.Text = "Pradaria";
                    pbDado.BackgroundImage = Properties.Resources.FacePradaria;
                    break;
                case "TI":
                    lblDadoSorteado.Text = "T-Rex";
                    pbDado.BackgroundImage = Properties.Resources.FaceTRex;
                    break;
                case "VZ":
                    lblDadoSorteado.Text = "Cercado Vazio";
                    pbDado.BackgroundImage = Properties.Resources.FaceCercadoVazio;
                    break;
                case "WC":
                    lblDadoSorteado.Text = "Banheiros";
                    pbDado.BackgroundImage = Properties.Resources.FaceBanheiro;
                    break;
            }

            lblJogadorDado.Text = JogadorDado.Nome;

            jogadorAtual.DinossauroSelecionado = null;

            ExibirMaoJogador(jogadorAtual.Id);
        }

        private void btnPrimeiroDino_Click(object sender, EventArgs e)
        {
            jogadorAtual.DinossauroSelecionado = btnPrimeiroDino.Tag.ToString();
        }

        private void btnSegundoDino_Click(object sender, EventArgs e)
        {
            jogadorAtual.DinossauroSelecionado = btnSegundoDino.Tag.ToString();
        }

        private void btnTerceiroDino_Click(object sender, EventArgs e)
        {
            jogadorAtual.DinossauroSelecionado = btnTerceiroDino.Tag.ToString();
        }

        private void btnQuartoDino_Click(object sender, EventArgs e)
        {
            jogadorAtual.DinossauroSelecionado = btnQuartoDino.Tag.ToString();
        }

        private void btnQuintoDino_Click(object sender, EventArgs e)
        {
            jogadorAtual.DinossauroSelecionado = btnQuintoDino.Tag.ToString();
        }

        private void btnSextoDino_Click(object sender, EventArgs e)
        {
            jogadorAtual.DinossauroSelecionado = btnSextoDino.Tag.ToString();
        }
    }
}