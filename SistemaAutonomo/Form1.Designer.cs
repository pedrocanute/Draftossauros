namespace SistemaAutonomo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.grpDadosPartida = new System.Windows.Forms.GroupBox();
            this.btnListarJogadores = new System.Windows.Forms.Button();
            this.lstListaJogadores = new System.Windows.Forms.ListBox();
            this.lblDataPartida = new System.Windows.Forms.Label();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.lblIdPartida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblNomeGrupo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnCriarJogador = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIdJogador = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSenhaJogador = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.lstMaoDinossauros = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTeste = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gprPartida = new System.Windows.Forms.GroupBox();
            this.lblRodada = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblVersao2 = new System.Windows.Forms.Label();
            this.lblDadoSorteado = new System.Windows.Forms.Label();
            this.grpDadosPartida.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gprPartida.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(23, 31);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(23, 16);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "ID:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(23, 58);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(47, 16);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Nome:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(23, 85);
            this.lbl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(39, 16);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Data:";
            // 
            // grpDadosPartida
            // 
            this.grpDadosPartida.Controls.Add(this.btnListarJogadores);
            this.grpDadosPartida.Controls.Add(this.lstListaJogadores);
            this.grpDadosPartida.Controls.Add(this.lblDataPartida);
            this.grpDadosPartida.Controls.Add(this.lblNomePartida);
            this.grpDadosPartida.Controls.Add(this.lblIdPartida);
            this.grpDadosPartida.Controls.Add(this.lbl1);
            this.grpDadosPartida.Controls.Add(this.lbl3);
            this.grpDadosPartida.Controls.Add(this.lbl2);
            this.grpDadosPartida.Location = new System.Drawing.Point(16, 15);
            this.grpDadosPartida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDadosPartida.Name = "grpDadosPartida";
            this.grpDadosPartida.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDadosPartida.Size = new System.Drawing.Size(345, 295);
            this.grpDadosPartida.TabIndex = 6;
            this.grpDadosPartida.TabStop = false;
            this.grpDadosPartida.Text = "Dados da Partida:";
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.Location = new System.Drawing.Point(27, 119);
            this.btnListarJogadores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(128, 28);
            this.btnListarJogadores.TabIndex = 9;
            this.btnListarJogadores.Text = "Listar Jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = true;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // lstListaJogadores
            // 
            this.lstListaJogadores.FormattingEnabled = true;
            this.lstListaJogadores.ItemHeight = 16;
            this.lstListaJogadores.Location = new System.Drawing.Point(27, 169);
            this.lstListaJogadores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstListaJogadores.Name = "lstListaJogadores";
            this.lstListaJogadores.Size = new System.Drawing.Size(284, 84);
            this.lstListaJogadores.TabIndex = 7;
            // 
            // lblDataPartida
            // 
            this.lblDataPartida.AutoSize = true;
            this.lblDataPartida.Location = new System.Drawing.Point(91, 85);
            this.lblDataPartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataPartida.Name = "lblDataPartida";
            this.lblDataPartida.Size = new System.Drawing.Size(0, 16);
            this.lblDataPartida.TabIndex = 8;
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Location = new System.Drawing.Point(91, 58);
            this.lblNomePartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(0, 16);
            this.lblNomePartida.TabIndex = 7;
            // 
            // lblIdPartida
            // 
            this.lblIdPartida.AutoSize = true;
            this.lblIdPartida.Location = new System.Drawing.Point(91, 31);
            this.lblIdPartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdPartida.Name = "lblIdPartida";
            this.lblIdPartida.Size = new System.Drawing.Size(0, 16);
            this.lblIdPartida.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1548, 1109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Versão:";
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(1317, 741);
            this.lblVersao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(0, 16);
            this.lblVersao.TabIndex = 8;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(1548, 1084);
            this.lblGrupo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(47, 16);
            this.lblGrupo.TabIndex = 9;
            this.lblGrupo.Text = "Grupo:";
            // 
            // lblNomeGrupo
            // 
            this.lblNomeGrupo.AutoSize = true;
            this.lblNomeGrupo.Location = new System.Drawing.Point(1613, 1084);
            this.lblNomeGrupo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeGrupo.Name = "lblNomeGrupo";
            this.lblNomeGrupo.Size = new System.Drawing.Size(75, 16);
            this.lblNomeGrupo.TabIndex = 10;
            this.lblNomeGrupo.Text = "Primordiais";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.BackgroundImage = global::SistemaAutonomo.Properties.Resources.Tabuleiro;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(413, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 774);
            this.panel1.TabIndex = 19;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIniciar.Location = new System.Drawing.Point(95, 162);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(152, 28);
            this.btnIniciar.TabIndex = 20;
            this.btnIniciar.Text = "Iniciar Partida";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnCriarJogador
            // 
            this.btnCriarJogador.Location = new System.Drawing.Point(237, 55);
            this.btnCriarJogador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCriarJogador.Name = "btnCriarJogador";
            this.btnCriarJogador.Size = new System.Drawing.Size(100, 28);
            this.btnCriarJogador.TabIndex = 21;
            this.btnCriarJogador.Text = "Criar";
            this.btnCriarJogador.UseVisualStyleBackColor = true;
            this.btnCriarJogador.Click += new System.EventHandler(this.btnCriarJogador_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "ID Jogador:";
            // 
            // lblIdJogador
            // 
            this.lblIdJogador.AutoSize = true;
            this.lblIdJogador.Location = new System.Drawing.Point(141, 97);
            this.lblIdJogador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdJogador.Name = "lblIdJogador";
            this.lblIdJogador.Size = new System.Drawing.Size(0, 16);
            this.lblIdJogador.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Senha Jogador:";
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.Location = new System.Drawing.Point(141, 122);
            this.lblSenhaJogador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(133, 16);
            this.lblSenhaJogador.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtNomeJogador);
            this.groupBox1.Controls.Add(this.btnIniciar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblSenhaJogador);
            this.groupBox1.Controls.Add(this.btnCriarJogador);
            this.groupBox1.Controls.Add(this.lblIdJogador);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(16, 340);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(347, 198);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Jogador:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Nome do Jogador:";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(13, 57);
            this.txtNomeJogador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(216, 22);
            this.txtNomeJogador.TabIndex = 29;
            // 
            // lstMaoDinossauros
            // 
            this.lstMaoDinossauros.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lstMaoDinossauros.FormattingEnabled = true;
            this.lstMaoDinossauros.ItemHeight = 16;
            this.lstMaoDinossauros.Location = new System.Drawing.Point(8, 98);
            this.lstMaoDinossauros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstMaoDinossauros.Name = "lstMaoDinossauros";
            this.lstMaoDinossauros.Size = new System.Drawing.Size(200, 84);
            this.lstMaoDinossauros.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 79);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Mão do Jogador:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 31);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Dado Sorteado:";
            // 
            // lblTeste
            // 
            this.lblTeste.AutoSize = true;
            this.lblTeste.Location = new System.Drawing.Point(505, 1029);
            this.lblTeste.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeste.Name = "lblTeste";
            this.lblTeste.Size = new System.Drawing.Size(51, 16);
            this.lblTeste.TabIndex = 31;
            this.lblTeste.Text = "label11";
            this.lblTeste.Visible = false;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 52);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 16);
            this.label11.TabIndex = 32;
            this.label11.Text = "Rodada:";
            // 
            // gprPartida
            // 
            this.gprPartida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gprPartida.Controls.Add(this.lblDadoSorteado);
            this.gprPartida.Controls.Add(this.lblRodada);
            this.gprPartida.Controls.Add(this.lstMaoDinossauros);
            this.gprPartida.Controls.Add(this.label8);
            this.gprPartida.Controls.Add(this.label11);
            this.gprPartida.Controls.Add(this.label10);
            this.gprPartida.Location = new System.Drawing.Point(16, 545);
            this.gprPartida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gprPartida.Name = "gprPartida";
            this.gprPartida.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gprPartida.Size = new System.Drawing.Size(347, 209);
            this.gprPartida.TabIndex = 34;
            this.gprPartida.TabStop = false;
            this.gprPartida.Text = "Partida";
            // 
            // lblRodada
            // 
            this.lblRodada.AutoSize = true;
            this.lblRodada.Location = new System.Drawing.Point(80, 52);
            this.lblRodada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRodada.Name = "lblRodada";
            this.lblRodada.Size = new System.Drawing.Size(0, 16);
            this.lblRodada.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 786);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Versão:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 764);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Grupo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 764);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "PRIMORDIAIS";
            // 
            // lblVersao2
            // 
            this.lblVersao2.AutoSize = true;
            this.lblVersao2.Location = new System.Drawing.Point(83, 786);
            this.lblVersao2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersao2.Name = "lblVersao2";
            this.lblVersao2.Size = new System.Drawing.Size(54, 16);
            this.lblVersao2.TabIndex = 38;
            this.lblVersao2.Text = "Versão:";
            // 
            // lblDadoSorteado
            // 
            this.lblDadoSorteado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDadoSorteado.AutoSize = true;
            this.lblDadoSorteado.Location = new System.Drawing.Point(119, 31);
            this.lblDadoSorteado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDadoSorteado.Name = "lblDadoSorteado";
            this.lblDadoSorteado.Size = new System.Drawing.Size(0, 16);
            this.lblDadoSorteado.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1309, 804);
            this.Controls.Add(this.lblVersao2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gprPartida);
            this.Controls.Add(this.lblTeste);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNomeGrupo);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpDadosPartida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1327, 851);
            this.MinimumSize = new System.Drawing.Size(1327, 851);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Draftossauros";
            this.grpDadosPartida.ResumeLayout(false);
            this.grpDadosPartida.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gprPartida.ResumeLayout(false);
            this.gprPartida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.GroupBox grpDadosPartida;
        private System.Windows.Forms.Label lblDataPartida;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.Label lblIdPartida;
        private System.Windows.Forms.ListBox lstListaJogadores;
        private System.Windows.Forms.Button btnListarJogadores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblNomeGrupo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnCriarJogador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIdJogador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSenhaJogador;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstMaoDinossauros;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTeste;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gprPartida;
        private System.Windows.Forms.Label lblRodada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblVersao2;
        private System.Windows.Forms.Label lblDadoSorteado;
    }
}

