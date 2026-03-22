using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        Jogador jogadorAtual;
        public Form1(Partida partida)
        {
            partidaCriada = partida;
            InitializeComponent();
            lblVersao2.Text = Jogo.versao;
            lblIdPartida.Text = partidaCriada.idPartida.ToString();
            lblNomePartida.Text = partidaCriada.NomePartida;
            lblDataPartida.Text = partidaCriada.DataPartida;

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

            jogadorAtual = CriarJogador(idJogador, txtNomeJogador.Text, senhaJogador);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (listaJogadores.Count == 0)
            {
                MessageBox.Show("Crie um jogador!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listaJogadores.Count < 2)
            {
                MessageBox.Show("São necessários, pelo menos, 2 jogadores!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Jogador donoDaPartida = listaJogadores[0];
            //Chama a função de lançar o dado para o jogador que criou a partida e exibe o resultado do dado
            LancarDado(donoDaPartida);

            //Chama a função de exibir a mão do jogador
            ExibirMaoJogador(donoDaPartida.Id);

            //Exibe o id do jogador que lançou o dado
            lblIdJogador.Text = donoDaPartida.Id.ToString();
            txtNomeJogador.Text = donoDaPartida.Nome;

            //Exibe o nome do jogador atual que está realizando a jogada
            lblNomeJogador.Text = jogadorAtual.Nome;
        }

        private void btnRealizarJogada_Click(object sender, EventArgs e)
        {
            //Verifica qual dinossauro foi selecionado e atribui a sigla correspondente para realizar a jogada e trata o erro do jogador não ter selecionado um cercado para jogar
            if (lstMaoDinossauros.SelectedItem == null)
            {
                MessageBox.Show("Selecione um dinossauro para jogar!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dinossauroSelecionado = lstMaoDinossauros.SelectedItem.ToString();
            string[] dinossauroSelecionadoSplit = dinossauroSelecionado.Split(' ');
            string siglaDinossauro = "";


            switch (dinossauroSelecionadoSplit[0])
            {
                case "Braquiossauro":
                    siglaDinossauro = "Br";
                    break;
                case "Espinossauro":
                    siglaDinossauro = "Ep";
                    break;
                case "Estegossauro":
                    siglaDinossauro = "Et";
                    break;
                case "Parasaurolófo":
                    siglaDinossauro = "Pa";
                    break;
                case "Tiranossauro-Rex":
                    siglaDinossauro = "Ti";
                    break;
                case "Tricerátops":
                    siglaDinossauro = "Tr";
                    break;
            }

            //Verifica qual cercado foi selecionado e atribui a sigla correspondente para realizar a jogada e trata o erro do jogador não ter selecionado um cercado para jogar
            if (lstCercados.SelectedItem == null)
            {
                MessageBox.Show("Selecione um cercado para jogar!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cercadoSelecionado = lstCercados.SelectedItem.ToString();
            string[] cercadoSelecionadoSplit = cercadoSelecionado.Split(' ');
            string siglaCercado = "";

            switch (cercadoSelecionadoSplit[0])
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
                        //case "Cercado Vazio":
                        //    if (lstCercados.SelectedItem.ToString() == "Diferença" || lstCercados.SelectedItem.ToString() == "Rei da Selva" || lstCercados.SelectedItem.ToString() == "Solitária")
                        //    {
                        //        MessageBox.Show("O dado sorteado é Pradaria, você só pode jogar nos cercados Rei da Selva, Solitária ou Diferença!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //        return;
                        //    }
                        //    break;
                        //case "T-Rex":
                        //    if (lstCercados.SelectedItem.ToString() == "Diferença" || lstCercados.SelectedItem.ToString() == "Rei da Selva" || lstCercados.SelectedItem.ToString() == "Solitária")
                        //    {
                        //        MessageBox.Show("O dado sorteado é Pradaria, você só pode jogar nos cercados Rei da Selva, Solitária ou Diferença!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //        return;
                        //    }
                        //    break;
                }
            }

            // Realiza a Jogada
            Jogo.Jogar(jogadorAtual.Id, jogadorAtual.Senha, siglaDinossauro, siglaCercado);
            // Remove o dinossauro jogado da mão do jogador
            var dinossauroParaRemover = jogadorAtual.listaDinossauros.FirstOrDefault(d => d.SiglaNome == siglaDinossauro);
            if (dinossauroParaRemover != null)
            {
                jogadorAtual.listaDinossauros.Remove(dinossauroParaRemover);
            }
            //Exibe a mão do jogador após a jogada
            ExibirMaoJogador(jogadorAtual.Id);
            ExibirTabuleiroJogador(jogadorAtual);
        }

        public Jogador CriarJogador(int id, string nome, string senha)
        {
            Jogador jogador = new Jogador(id, senha);
            jogador.Nome = nome;
            listaJogadores.Add(jogador);
            return jogador;
        }

        public Jogador BuscarJogador(int id)
        {
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
            Jogador jogadorDaVez = BuscarJogador(idJogador);

            if (jogadorDaVez == null)
            {
                MessageBox.Show("Não temos a senha deste jogador localmente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            jogadorDaVez.listaDinossauros.Clear();
            string maoJogador = Jogo.ExibirMao(jogadorDaVez.Id, jogadorDaVez.Senha);

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
                    jogadorDaVez.listaDinossauros.Add(dinossauro);
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
                    break;
                case "FL":
                    lblDadoSorteado.Text = "Floresta";
                    break;
                case "PR":
                    lblDadoSorteado.Text = "Pradaria";
                    break;
                case "TI":
                    lblDadoSorteado.Text = "T-Rex";
                    break;
                case "VZ":
                    lblDadoSorteado.Text = "Cercado Vazio";
                    break;
                case "WC":
                    lblDadoSorteado.Text = "Banheiros";
                    break;
            }
        }

        public void ExibirTabuleiroJogador(Jogador jogador)
        {
            string tabuleiro = Jogo.ExibirTabuleiro(jogador.Id, jogador.Senha);
            lblTeste.Text = tabuleiro;
        }
    }
}
