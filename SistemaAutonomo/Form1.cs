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
            lblVersao.Text = Jogo.versao; //Versionando o jogo no label
            cmbStatusPartidas.Items.Add("Todas");
            cmbStatusPartidas.Items.Add("Abertas");
            cmbStatusPartidas.Items.Add("Jogando");
            cmbStatusPartidas.Items.Add("Encerrada");
            cmbStatusPartidas.SelectedIndex = 0;
        }

        private void btnListarPartida_Click(object sender, EventArgs e)
        {
            string status = cmbStatusPartidas.SelectedItem.ToString().Substring(0, 1);
            string retorno = Jogo.ListarPartidas(status);

            txtListaPartida.Text = retorno;

            if (string.IsNullOrEmpty(retorno))
            {
                lstListaPartidas.Items.Clear();
                lstListaPartidas.Items.Add("Não há partidas com este status");
                return;
            }

            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] partidas = retorno.Split('\n');

            lstListaPartidas.Items.Clear();
            for (int i = 0; i < partidas.Length; i++)
            {
                lstListaPartidas.Items.Add(partidas[i]);
            }

        }

        private void lstListaPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListaPartidas.SelectedItem == null) return;

            string partida = lstListaPartidas.SelectedItem.ToString();

            string[] dadosPartida = partida.Split(',');

            if (dadosPartida.Length < 3) return;

            partidaCriada.idPartida = Convert.ToInt32(dadosPartida[0]);
            string nomePartida = dadosPartida[1];
            string data = dadosPartida[2];

            lblIdPartida.Text = partidaCriada.idPartida.ToString();
            lblNomePartida.Text = nomePartida;
            lblDataPartida.Text = data;
            lstListaJogadores.Items.Clear();

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

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            if (txtNomePartida.Text == "")
            {
                MessageBox.Show("O nome da partida é obrigatório!", "NOME INVÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtSenha.Text == "")
            {
                MessageBox.Show("A senha da partida é obrigatória!", "SENHA INVÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string idGerado = Jogo.CriarPartida(txtNomePartida.Text, txtSenha.Text, lblNomeGrupo.Text);
            partidaCriada.idPartida = Convert.ToInt32(idGerado);
            lblIdGerado.Text = idGerado;
        }

        private void btnCriarJogador_Click(object sender, EventArgs e)
        {
            string infoJogador = Jogo.Entrar(partidaCriada.idPartida, txtNomeJogador.Text, partidaCriada.senha/*txtSenha.Text*/);
            
            // Verificar se houve erro
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
                MessageBox.Show("Crie um jogador!","ERRO",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (listaJogadores.Count < 2)
            {
                MessageBox.Show("São necessários, pelo menos, 2 jogadores!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Jogador donoDaPartida = listaJogadores[0];
            string dadoInicial = Jogo.Iniciar(donoDaPartida.Id, donoDaPartida.Senha);

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
            Jogador jogadorDaVez = BuscarJogador(idJogador);

            if(jogadorDaVez == null)
            {
                MessageBox.Show("Não temos a senha deste jogador localmente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maoJogador = Jogo.ExibirMao(idJogador, jogadorDaVez.Senha);
            lblTeste.Text = maoJogador;

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
                        lstMaoDinossauros.Items.Add("Tiranossauro Rex Qtd: " + quantidade);
                        break;
                    case "Tr":
                        lstMaoDinossauros.Items.Add("Tricerátops Qtd: " + quantidade);
                        break;
                }
            }


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
            MessageBox.Show("Jogador ja existe","ERRO",MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
    }
}
