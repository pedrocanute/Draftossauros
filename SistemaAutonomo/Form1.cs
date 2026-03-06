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
        Partida partidaSelecionada = new Partida(); //Instanciando a partida
        public Form1()
        {
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
            string status = cmbStatusPartidas.SelectedItem.ToString().Substring(0,1);
            string retorno = Jogo.ListarPartidas(status);

            txtListaPartida.Text = retorno;

            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] partidas = retorno.Split('\n');

            lstListaPartidas.Items.Clear();
            for (int i = 0; i < partidas.Length; i++ )
            {
                lstListaPartidas.Items.Add(partidas[i]);
            }

        }

        private void lstListaPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string partida = lstListaPartidas.SelectedItem.ToString();
            string[] dadosPartida = partida.Split(',');
            partidaSelecionada.idPartidaSelecionada = Convert.ToInt32(dadosPartida[0]);
            string nomePartida = dadosPartida[1];
            string data = dadosPartida[2];

            lblIdPartida.Text = partidaSelecionada.idPartidaSelecionada.ToString();
            lblNomePartida.Text = nomePartida;
            lblDataPartida.Text = data;
            lstListaJogadores.Items.Clear();

        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarJogadores(partidaSelecionada.idPartidaSelecionada);
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
                MessageBox.Show("O nome da partida é obrigatório!","NOME INVÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            if (txtSenha.Text == "")
            {
                MessageBox.Show("A senha da partida é obrigatória!", "SENHA INVÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string idGerado = Jogo.CriarPartida(txtNomePartida.Text, txtSenha.Text,lblNomeGrupo.Text);
            lblIdGerado.Text = idGerado;
        }
    }
}
