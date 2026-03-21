using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Draft;

namespace SistemaAutonomo
{
    public partial class Lobby : Form
    {
        Partida partidaCriada = new Partida(); //Instanciando a partida
        public Lobby()
        {
            InitializeComponent();
            lblVersaoDll.Text = Jogo.versao;
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

            if (idGerado.StartsWith("ERRO:"))
            {
                MessageBox.Show(idGerado, "ERRO AO CRIAR PARTIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            partidaCriada.idPartida = Convert.ToInt32(idGerado);
            partidaCriada.Senha = txtSenha.Text;
            partidaCriada.NomePartida = txtNomePartida.Text;
            partidaCriada.DataPartida = DateTime.Now.ToString("dd/MM/yyyy");

            lblIdGerado.Text = idGerado;
            Form1 janelaPrincipal = new Form1(partidaCriada);
            janelaPrincipal.Show();
            
        }

        private void lstListaPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListaPartidas.SelectedItem == null) return;

            string partida = lstListaPartidas.SelectedItem.ToString();
            string[] dadosPartida = partida.Split(',');

            if (dadosPartida.Length < 3) return; //verifica se o split dividou partida em 3 partes

            partidaCriada.idPartida = Convert.ToInt32(dadosPartida[0]);
            partidaCriada.Senha = txtSenha.Text;
            partidaCriada.NomePartida = dadosPartida[1];
            partidaCriada.DataPartida = dadosPartida[2];
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)

        {
            if (lstListaPartidas.SelectedItem == null) return;
            
            string partida = lstListaPartidas.SelectedItem.ToString();
            string[] dadosPartida = partida.Split(',');

            if (dadosPartida.Length < 3) return;

            partidaCriada.idPartida = Convert.ToInt32(dadosPartida[0]);
            partidaCriada.NomePartida = dadosPartida[1];
            partidaCriada.Senha = txtSenha.Text;

            Form1 janelaPrincipal = new Form1(partidaCriada);
            janelaPrincipal.Show();
        }
    }
}
