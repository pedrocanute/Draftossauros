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
