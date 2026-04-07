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
            this.label12 = new System.Windows.Forms.Label();
            this.lstCercados = new System.Windows.Forms.ListBox();
            this.btnRealizarJogada = new System.Windows.Forms.Button();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.lblDadoSorteado = new System.Windows.Forms.Label();
            this.lblRodada = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblVersao2 = new System.Windows.Forms.Label();
            this.gprStatusPartida = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnVerificarTurno = new System.Windows.Forms.Button();
            this.lblTesteVerificarPartida = new System.Windows.Forms.Label();
            this.btnExibirMao = new System.Windows.Forms.Button();
            this.lblTesteAtualizar = new System.Windows.Forms.Label();
            this.pnlTabuleiro = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.grpDadosPartida.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gprPartida.SuspendLayout();
            this.gprStatusPartida.SuspendLayout();
            this.pnlTabuleiro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(17, 25);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(21, 13);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "ID:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(17, 47);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(38, 13);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Nome:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(17, 69);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(33, 13);
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
            this.grpDadosPartida.Location = new System.Drawing.Point(12, 12);
            this.grpDadosPartida.Name = "grpDadosPartida";
            this.grpDadosPartida.Size = new System.Drawing.Size(259, 240);
            this.grpDadosPartida.TabIndex = 6;
            this.grpDadosPartida.TabStop = false;
            this.grpDadosPartida.Text = "Dados da Partida:";
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.Location = new System.Drawing.Point(20, 97);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(96, 23);
            this.btnListarJogadores.TabIndex = 9;
            this.btnListarJogadores.Text = "Listar Jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = true;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // lstListaJogadores
            // 
            this.lstListaJogadores.FormattingEnabled = true;
            this.lstListaJogadores.Location = new System.Drawing.Point(20, 137);
            this.lstListaJogadores.Name = "lstListaJogadores";
            this.lstListaJogadores.Size = new System.Drawing.Size(214, 69);
            this.lstListaJogadores.TabIndex = 7;
            // 
            // lblDataPartida
            // 
            this.lblDataPartida.AutoSize = true;
            this.lblDataPartida.Location = new System.Drawing.Point(68, 69);
            this.lblDataPartida.Name = "lblDataPartida";
            this.lblDataPartida.Size = new System.Drawing.Size(0, 13);
            this.lblDataPartida.TabIndex = 8;
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Location = new System.Drawing.Point(68, 47);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(0, 13);
            this.lblNomePartida.TabIndex = 7;
            // 
            // lblIdPartida
            // 
            this.lblIdPartida.AutoSize = true;
            this.lblIdPartida.Location = new System.Drawing.Point(68, 25);
            this.lblIdPartida.Name = "lblIdPartida";
            this.lblIdPartida.Size = new System.Drawing.Size(0, 13);
            this.lblIdPartida.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1161, 901);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Versão:";
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(988, 602);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(0, 13);
            this.lblVersao.TabIndex = 8;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(1161, 881);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(39, 13);
            this.lblGrupo.TabIndex = 9;
            this.lblGrupo.Text = "Grupo:";
            // 
            // lblNomeGrupo
            // 
            this.lblNomeGrupo.AutoSize = true;
            this.lblNomeGrupo.Location = new System.Drawing.Point(1210, 881);
            this.lblNomeGrupo.Name = "lblNomeGrupo";
            this.lblNomeGrupo.Size = new System.Drawing.Size(57, 13);
            this.lblNomeGrupo.TabIndex = 10;
            this.lblNomeGrupo.Text = "Primordiais";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIniciar.Location = new System.Drawing.Point(71, 132);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(114, 23);
            this.btnIniciar.TabIndex = 20;
            this.btnIniciar.Text = "Iniciar Partida";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnCriarJogador
            // 
            this.btnCriarJogador.Location = new System.Drawing.Point(178, 45);
            this.btnCriarJogador.Name = "btnCriarJogador";
            this.btnCriarJogador.Size = new System.Drawing.Size(75, 23);
            this.btnCriarJogador.TabIndex = 21;
            this.btnCriarJogador.Text = "Criar";
            this.btnCriarJogador.UseVisualStyleBackColor = true;
            this.btnCriarJogador.Click += new System.EventHandler(this.btnCriarJogador_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "ID Jogador:";
            // 
            // lblIdJogador
            // 
            this.lblIdJogador.AutoSize = true;
            this.lblIdJogador.Location = new System.Drawing.Point(106, 79);
            this.lblIdJogador.Name = "lblIdJogador";
            this.lblIdJogador.Size = new System.Drawing.Size(0, 13);
            this.lblIdJogador.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Senha Jogador:";
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.Location = new System.Drawing.Point(95, 99);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(100, 13);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(260, 161);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Jogador:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Nome do Jogador:";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(10, 46);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(163, 20);
            this.txtNomeJogador.TabIndex = 29;
            // 
            // lstMaoDinossauros
            // 
            this.lstMaoDinossauros.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lstMaoDinossauros.FormattingEnabled = true;
            this.lstMaoDinossauros.Location = new System.Drawing.Point(6, 80);
            this.lstMaoDinossauros.Name = "lstMaoDinossauros";
            this.lstMaoDinossauros.Size = new System.Drawing.Size(151, 82);
            this.lstMaoDinossauros.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Mão do Jogador:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Dado Sorteado:";
            // 
            // lblTeste
            // 
            this.lblTeste.AutoSize = true;
            this.lblTeste.Location = new System.Drawing.Point(6, 42);
            this.lblTeste.Name = "lblTeste";
            this.lblTeste.Size = new System.Drawing.Size(0, 13);
            this.lblTeste.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Rodada:";
            // 
            // gprPartida
            // 
            this.gprPartida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gprPartida.Controls.Add(this.label12);
            this.gprPartida.Controls.Add(this.lstCercados);
            this.gprPartida.Controls.Add(this.btnRealizarJogada);
            this.gprPartida.Controls.Add(this.lblNomeJogador);
            this.gprPartida.Controls.Add(this.lblDadoSorteado);
            this.gprPartida.Controls.Add(this.lblRodada);
            this.gprPartida.Controls.Add(this.lstMaoDinossauros);
            this.gprPartida.Controls.Add(this.label8);
            this.gprPartida.Controls.Add(this.label11);
            this.gprPartida.Controls.Add(this.label10);
            this.gprPartida.Location = new System.Drawing.Point(12, 443);
            this.gprPartida.Name = "gprPartida";
            this.gprPartida.Size = new System.Drawing.Size(260, 170);
            this.gprPartida.TabIndex = 34;
            this.gprPartida.TabStop = false;
            this.gprPartida.Text = "Partida";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(157, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Cercado:";
            // 
            // lstCercados
            // 
            this.lstCercados.FormattingEnabled = true;
            this.lstCercados.Items.AddRange(new object[] {
            "Igualdade",
            "Rei da Selva",
            "Mata Tripla",
            "Diferença",
            "Amor",
            "Solitária",
            "Rio"});
            this.lstCercados.Location = new System.Drawing.Point(160, 80);
            this.lstCercados.Name = "lstCercados";
            this.lstCercados.Size = new System.Drawing.Size(95, 82);
            this.lstCercados.TabIndex = 38;
            // 
            // btnRealizarJogada
            // 
            this.btnRealizarJogada.Location = new System.Drawing.Point(158, 19);
            this.btnRealizarJogada.Name = "btnRealizarJogada";
            this.btnRealizarJogada.Size = new System.Drawing.Size(97, 23);
            this.btnRealizarJogada.TabIndex = 37;
            this.btnRealizarJogada.Text = "Realizar Jogada";
            this.btnRealizarJogada.UseVisualStyleBackColor = true;
            this.btnRealizarJogada.Click += new System.EventHandler(this.btnRealizarJogada_Click);
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Location = new System.Drawing.Point(92, 64);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(0, 13);
            this.lblNomeJogador.TabIndex = 36;
            // 
            // lblDadoSorteado
            // 
            this.lblDadoSorteado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDadoSorteado.AutoSize = true;
            this.lblDadoSorteado.Location = new System.Drawing.Point(89, 25);
            this.lblDadoSorteado.Name = "lblDadoSorteado";
            this.lblDadoSorteado.Size = new System.Drawing.Size(0, 13);
            this.lblDadoSorteado.TabIndex = 35;
            // 
            // lblRodada
            // 
            this.lblRodada.AutoSize = true;
            this.lblRodada.Location = new System.Drawing.Point(60, 42);
            this.lblRodada.Name = "lblRodada";
            this.lblRodada.Size = new System.Drawing.Size(0, 13);
            this.lblRodada.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 639);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Versão:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 621);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Grupo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 621);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "PRIMORDIAIS";
            // 
            // lblVersao2
            // 
            this.lblVersao2.AutoSize = true;
            this.lblVersao2.Location = new System.Drawing.Point(62, 639);
            this.lblVersao2.Name = "lblVersao2";
            this.lblVersao2.Size = new System.Drawing.Size(43, 13);
            this.lblVersao2.TabIndex = 38;
            this.lblVersao2.Text = "Versão:";
            // 
            // gprStatusPartida
            // 
            this.gprStatusPartida.Controls.Add(this.label13);
            this.gprStatusPartida.Controls.Add(this.lblTeste);
            this.gprStatusPartida.Location = new System.Drawing.Point(298, 12);
            this.gprStatusPartida.Name = "gprStatusPartida";
            this.gprStatusPartida.Size = new System.Drawing.Size(264, 206);
            this.gprStatusPartida.TabIndex = 39;
            this.gprStatusPartida.TabStop = false;
            this.gprStatusPartida.Text = "Status Partida:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tabuleiro";
            // 
            // btnVerificarTurno
            // 
            this.btnVerificarTurno.Location = new System.Drawing.Point(682, 32);
            this.btnVerificarTurno.Name = "btnVerificarTurno";
            this.btnVerificarTurno.Size = new System.Drawing.Size(111, 23);
            this.btnVerificarTurno.TabIndex = 41;
            this.btnVerificarTurno.Text = "Atualizar";
            this.btnVerificarTurno.UseVisualStyleBackColor = true;
            this.btnVerificarTurno.Click += new System.EventHandler(this.btnVerificarTurno_Click);
            // 
            // lblTesteVerificarPartida
            // 
            this.lblTesteVerificarPartida.AutoSize = true;
            this.lblTesteVerificarPartida.Location = new System.Drawing.Point(692, 80);
            this.lblTesteVerificarPartida.Name = "lblTesteVerificarPartida";
            this.lblTesteVerificarPartida.Size = new System.Drawing.Size(41, 13);
            this.lblTesteVerificarPartida.TabIndex = 42;
            this.lblTesteVerificarPartida.Text = "label14";
            // 
            // btnExibirMao
            // 
            this.btnExibirMao.Location = new System.Drawing.Point(695, 129);
            this.btnExibirMao.Name = "btnExibirMao";
            this.btnExibirMao.Size = new System.Drawing.Size(75, 23);
            this.btnExibirMao.TabIndex = 43;
            this.btnExibirMao.Text = "Exibir Mao";
            this.btnExibirMao.UseVisualStyleBackColor = true;
            this.btnExibirMao.Click += new System.EventHandler(this.btnExibirMao_Click);
            // 
            // lblTesteAtualizar
            // 
            this.lblTesteAtualizar.AutoSize = true;
            this.lblTesteAtualizar.Location = new System.Drawing.Point(853, 81);
            this.lblTesteAtualizar.Name = "lblTesteAtualizar";
            this.lblTesteAtualizar.Size = new System.Drawing.Size(41, 13);
            this.lblTesteAtualizar.TabIndex = 44;
            this.lblTesteAtualizar.Text = "label14";
            // 
            // pnlTabuleiro
            // 
            this.pnlTabuleiro.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlTabuleiro.BackgroundImage = global::SistemaAutonomo.Properties.Resources.Tabuleiro;
            this.pnlTabuleiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTabuleiro.Controls.Add(this.label14);
            this.pnlTabuleiro.Location = new System.Drawing.Point(298, 234);
            this.pnlTabuleiro.Name = "pnlTabuleiro";
            this.pnlTabuleiro.Size = new System.Drawing.Size(432, 414);
            this.pnlTabuleiro.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(223, 345);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "label14";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(983, 660);
            this.Controls.Add(this.lblTesteAtualizar);
            this.Controls.Add(this.btnExibirMao);
            this.Controls.Add(this.lblTesteVerificarPartida);
            this.Controls.Add(this.btnVerificarTurno);
            this.Controls.Add(this.gprStatusPartida);
            this.Controls.Add(this.lblVersao2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gprPartida);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlTabuleiro);
            this.Controls.Add(this.lblNomeGrupo);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpDadosPartida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(999, 699);
            this.MinimumSize = new System.Drawing.Size(999, 699);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Draftossauros";
            this.grpDadosPartida.ResumeLayout(false);
            this.grpDadosPartida.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gprPartida.ResumeLayout(false);
            this.gprPartida.PerformLayout();
            this.gprStatusPartida.ResumeLayout(false);
            this.gprStatusPartida.PerformLayout();
            this.pnlTabuleiro.ResumeLayout(false);
            this.pnlTabuleiro.PerformLayout();
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
        private System.Windows.Forms.Panel pnlTabuleiro;
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
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.Button btnRealizarJogada;
        private System.Windows.Forms.ListBox lstCercados;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gprStatusPartida;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnVerificarTurno;
        private System.Windows.Forms.Label lblTesteVerificarPartida;
        private System.Windows.Forms.Button btnExibirMao;
        private System.Windows.Forms.Label lblTesteAtualizar;
        private System.Windows.Forms.Label label14;
    }
}

