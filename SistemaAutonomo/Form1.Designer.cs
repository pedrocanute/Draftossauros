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
            this.label1 = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblNomeGrupo = new System.Windows.Forms.Label();
            this.lstMaoDinossauros = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gprPartida = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lstCercados = new System.Windows.Forms.ListBox();
            this.btnRealizarJogada = new System.Windows.Forms.Button();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.lblRodada = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblVersao2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnVerificarTurno = new System.Windows.Forms.Button();
            this.pnlTabuleiro = new System.Windows.Forms.Panel();
            this.pnlBotaoInfo = new System.Windows.Forms.Panel();
            this.lblJogadorDado = new System.Windows.Forms.Label();
            this.lblDadoSorteado = new System.Windows.Forms.Label();
            this.lblLancadoPor = new System.Windows.Forms.Label();
            this.lblDadoSorteadoSubtitulo = new System.Windows.Forms.Label();
            this.pbDado = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlMaoJogador = new System.Windows.Forms.Panel();
            this.btnQuintoDino = new System.Windows.Forms.Button();
            this.btnSextoDino = new System.Windows.Forms.Button();
            this.btnQuartoDino = new System.Windows.Forms.Button();
            this.btnSegundoDino = new System.Windows.Forms.Button();
            this.btnTerceiroDino = new System.Windows.Forms.Button();
            this.btnPrimeiroDino = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlDadosJogador = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSenhaJogador = new System.Windows.Forms.Label();
            this.lblIdJogador = new System.Windows.Forms.Label();
            this.lblSenhaJogadorSubtitulo = new System.Windows.Forms.Label();
            this.lblIdJogadorSubtitulo = new System.Windows.Forms.Label();
            this.btnCriarJogador = new System.Windows.Forms.Button();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.lblNomeJogadorSubtitulo = new System.Windows.Forms.Label();
            this.lblDadosJogadorTitulo = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTeste = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lstListaJogadores = new System.Windows.Forms.ListBox();
            this.btnListarJogadores = new System.Windows.Forms.Button();
            this.lblDataPartida = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.lblIdPartida = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gprPartida.SuspendLayout();
            this.pnlBotaoInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDado)).BeginInit();
            this.pnlMaoJogador.SuspendLayout();
            this.pnlDadosJogador.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.gprPartida.Controls.Add(this.lblRodada);
            this.gprPartida.Controls.Add(this.lstMaoDinossauros);
            this.gprPartida.Controls.Add(this.label8);
            this.gprPartida.Controls.Add(this.label11);
            this.gprPartida.Location = new System.Drawing.Point(12, 509);
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
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(9, 713);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Versão:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(9, 695);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Grupo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(54, 695);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "PRIMORDIAIS";
            // 
            // lblVersao2
            // 
            this.lblVersao2.AutoSize = true;
            this.lblVersao2.BackColor = System.Drawing.Color.Transparent;
            this.lblVersao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblVersao2.Location = new System.Drawing.Point(58, 713);
            this.lblVersao2.Name = "lblVersao2";
            this.lblVersao2.Size = new System.Drawing.Size(50, 13);
            this.lblVersao2.TabIndex = 38;
            this.lblVersao2.Text = "Versão:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label13.Location = new System.Drawing.Point(96, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 24);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tabuleiro";
            // 
            // btnVerificarTurno
            // 
            this.btnVerificarTurno.Location = new System.Drawing.Point(311, 708);
            this.btnVerificarTurno.Name = "btnVerificarTurno";
            this.btnVerificarTurno.Size = new System.Drawing.Size(111, 23);
            this.btnVerificarTurno.TabIndex = 41;
            this.btnVerificarTurno.Text = "Atualizar";
            this.btnVerificarTurno.UseVisualStyleBackColor = true;
            this.btnVerificarTurno.Click += new System.EventHandler(this.btnVerificarTurno_Click);
            // 
            // pnlTabuleiro
            // 
            this.pnlTabuleiro.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlTabuleiro.BackgroundImage = global::SistemaAutonomo.Properties.Resources.Tabuleiro;
            this.pnlTabuleiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTabuleiro.Location = new System.Drawing.Point(285, 11);
            this.pnlTabuleiro.Name = "pnlTabuleiro";
            this.pnlTabuleiro.Size = new System.Drawing.Size(592, 464);
            this.pnlTabuleiro.TabIndex = 19;
            // 
            // pnlBotaoInfo
            // 
            this.pnlBotaoInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlBotaoInfo.BackgroundImage = global::SistemaAutonomo.Properties.Resources.FundoPanel;
            this.pnlBotaoInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBotaoInfo.Controls.Add(this.lblJogadorDado);
            this.pnlBotaoInfo.Controls.Add(this.lblDadoSorteado);
            this.pnlBotaoInfo.Controls.Add(this.lblLancadoPor);
            this.pnlBotaoInfo.Controls.Add(this.lblDadoSorteadoSubtitulo);
            this.pnlBotaoInfo.Controls.Add(this.pbDado);
            this.pnlBotaoInfo.Controls.Add(this.label15);
            this.pnlBotaoInfo.Location = new System.Drawing.Point(891, 241);
            this.pnlBotaoInfo.Name = "pnlBotaoInfo";
            this.pnlBotaoInfo.Size = new System.Drawing.Size(281, 299);
            this.pnlBotaoInfo.TabIndex = 45;
            // 
            // lblJogadorDado
            // 
            this.lblJogadorDado.AutoSize = true;
            this.lblJogadorDado.Location = new System.Drawing.Point(150, 259);
            this.lblJogadorDado.Name = "lblJogadorDado";
            this.lblJogadorDado.Size = new System.Drawing.Size(0, 13);
            this.lblJogadorDado.TabIndex = 37;
            // 
            // lblDadoSorteado
            // 
            this.lblDadoSorteado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDadoSorteado.AutoSize = true;
            this.lblDadoSorteado.Location = new System.Drawing.Point(150, 228);
            this.lblDadoSorteado.Name = "lblDadoSorteado";
            this.lblDadoSorteado.Size = new System.Drawing.Size(0, 13);
            this.lblDadoSorteado.TabIndex = 36;
            // 
            // lblLancadoPor
            // 
            this.lblLancadoPor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLancadoPor.AutoSize = true;
            this.lblLancadoPor.Font = new System.Drawing.Font("Arial Black", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLancadoPor.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblLancadoPor.Location = new System.Drawing.Point(31, 259);
            this.lblLancadoPor.Name = "lblLancadoPor";
            this.lblLancadoPor.Size = new System.Drawing.Size(95, 17);
            this.lblLancadoPor.TabIndex = 31;
            this.lblLancadoPor.Text = "Lançado Por:";
            // 
            // lblDadoSorteadoSubtitulo
            // 
            this.lblDadoSorteadoSubtitulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDadoSorteadoSubtitulo.AutoSize = true;
            this.lblDadoSorteadoSubtitulo.Font = new System.Drawing.Font("Arial Black", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadoSorteadoSubtitulo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblDadoSorteadoSubtitulo.Location = new System.Drawing.Point(31, 227);
            this.lblDadoSorteadoSubtitulo.Name = "lblDadoSorteadoSubtitulo";
            this.lblDadoSorteadoSubtitulo.Size = new System.Drawing.Size(109, 17);
            this.lblDadoSorteadoSubtitulo.TabIndex = 30;
            this.lblDadoSorteadoSubtitulo.Text = "Dado Sorteado:";
            // 
            // pbDado
            // 
            this.pbDado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDado.Location = new System.Drawing.Point(83, 66);
            this.pbDado.Name = "pbDado";
            this.pbDado.Size = new System.Drawing.Size(108, 111);
            this.pbDado.TabIndex = 1;
            this.pbDado.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label15.Location = new System.Drawing.Point(106, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 23);
            this.label15.TabIndex = 0;
            this.label15.Text = "DADO";
            // 
            // pnlMaoJogador
            // 
            this.pnlMaoJogador.BackColor = System.Drawing.Color.Transparent;
            this.pnlMaoJogador.BackgroundImage = global::SistemaAutonomo.Properties.Resources.FundoPanelLarge;
            this.pnlMaoJogador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMaoJogador.Controls.Add(this.btnQuintoDino);
            this.pnlMaoJogador.Controls.Add(this.btnSextoDino);
            this.pnlMaoJogador.Controls.Add(this.btnQuartoDino);
            this.pnlMaoJogador.Controls.Add(this.btnSegundoDino);
            this.pnlMaoJogador.Controls.Add(this.btnTerceiroDino);
            this.pnlMaoJogador.Controls.Add(this.btnPrimeiroDino);
            this.pnlMaoJogador.Controls.Add(this.label10);
            this.pnlMaoJogador.Location = new System.Drawing.Point(289, 509);
            this.pnlMaoJogador.Name = "pnlMaoJogador";
            this.pnlMaoJogador.Size = new System.Drawing.Size(592, 178);
            this.pnlMaoJogador.TabIndex = 46;
            // 
            // btnQuintoDino
            // 
            this.btnQuintoDino.BackgroundImage = global::SistemaAutonomo.Properties.Resources.Espinossauro;
            this.btnQuintoDino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuintoDino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuintoDino.FlatAppearance.BorderSize = 0;
            this.btnQuintoDino.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnQuintoDino.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnQuintoDino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuintoDino.Location = new System.Drawing.Point(399, 69);
            this.btnQuintoDino.Name = "btnQuintoDino";
            this.btnQuintoDino.Size = new System.Drawing.Size(78, 82);
            this.btnQuintoDino.TabIndex = 4;
            this.btnQuintoDino.UseVisualStyleBackColor = true;
            this.btnQuintoDino.Visible = false;
            // 
            // btnSextoDino
            // 
            this.btnSextoDino.BackgroundImage = global::SistemaAutonomo.Properties.Resources.Espinossauro;
            this.btnSextoDino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSextoDino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSextoDino.FlatAppearance.BorderSize = 0;
            this.btnSextoDino.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSextoDino.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSextoDino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSextoDino.Location = new System.Drawing.Point(494, 68);
            this.btnSextoDino.Name = "btnSextoDino";
            this.btnSextoDino.Size = new System.Drawing.Size(78, 82);
            this.btnSextoDino.TabIndex = 4;
            this.btnSextoDino.UseVisualStyleBackColor = true;
            this.btnSextoDino.Visible = false;
            // 
            // btnQuartoDino
            // 
            this.btnQuartoDino.BackgroundImage = global::SistemaAutonomo.Properties.Resources.Espinossauro;
            this.btnQuartoDino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuartoDino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuartoDino.FlatAppearance.BorderSize = 0;
            this.btnQuartoDino.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnQuartoDino.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnQuartoDino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuartoDino.Location = new System.Drawing.Point(305, 68);
            this.btnQuartoDino.Name = "btnQuartoDino";
            this.btnQuartoDino.Size = new System.Drawing.Size(78, 82);
            this.btnQuartoDino.TabIndex = 3;
            this.btnQuartoDino.UseVisualStyleBackColor = true;
            this.btnQuartoDino.Visible = false;
            // 
            // btnSegundoDino
            // 
            this.btnSegundoDino.BackgroundImage = global::SistemaAutonomo.Properties.Resources.Espinossauro;
            this.btnSegundoDino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSegundoDino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSegundoDino.FlatAppearance.BorderSize = 0;
            this.btnSegundoDino.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSegundoDino.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSegundoDino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSegundoDino.Location = new System.Drawing.Point(113, 68);
            this.btnSegundoDino.Name = "btnSegundoDino";
            this.btnSegundoDino.Size = new System.Drawing.Size(78, 82);
            this.btnSegundoDino.TabIndex = 2;
            this.btnSegundoDino.UseVisualStyleBackColor = true;
            this.btnSegundoDino.Visible = false;
            // 
            // btnTerceiroDino
            // 
            this.btnTerceiroDino.BackgroundImage = global::SistemaAutonomo.Properties.Resources.Espinossauro;
            this.btnTerceiroDino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTerceiroDino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTerceiroDino.FlatAppearance.BorderSize = 0;
            this.btnTerceiroDino.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTerceiroDino.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTerceiroDino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerceiroDino.Location = new System.Drawing.Point(209, 68);
            this.btnTerceiroDino.Name = "btnTerceiroDino";
            this.btnTerceiroDino.Size = new System.Drawing.Size(78, 82);
            this.btnTerceiroDino.TabIndex = 2;
            this.btnTerceiroDino.UseVisualStyleBackColor = true;
            this.btnTerceiroDino.Visible = false;
            // 
            // btnPrimeiroDino
            // 
            this.btnPrimeiroDino.BackgroundImage = global::SistemaAutonomo.Properties.Resources.Espinossauro;
            this.btnPrimeiroDino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrimeiroDino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrimeiroDino.FlatAppearance.BorderSize = 0;
            this.btnPrimeiroDino.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrimeiroDino.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrimeiroDino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimeiroDino.Location = new System.Drawing.Point(18, 68);
            this.btnPrimeiroDino.Name = "btnPrimeiroDino";
            this.btnPrimeiroDino.Size = new System.Drawing.Size(78, 82);
            this.btnPrimeiroDino.TabIndex = 1;
            this.btnPrimeiroDino.UseVisualStyleBackColor = true;
            this.btnPrimeiroDino.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(98)))), ((int)(((byte)(97)))));
            this.label10.Location = new System.Drawing.Point(36, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mão do Jogador:";
            // 
            // pnlDadosJogador
            // 
            this.pnlDadosJogador.BackColor = System.Drawing.Color.Transparent;
            this.pnlDadosJogador.BackgroundImage = global::SistemaAutonomo.Properties.Resources.FundoPanel;
            this.pnlDadosJogador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDadosJogador.Controls.Add(this.label7);
            this.pnlDadosJogador.Controls.Add(this.lblSenhaJogador);
            this.pnlDadosJogador.Controls.Add(this.lblIdJogador);
            this.pnlDadosJogador.Controls.Add(this.lblSenhaJogadorSubtitulo);
            this.pnlDadosJogador.Controls.Add(this.lblIdJogadorSubtitulo);
            this.pnlDadosJogador.Controls.Add(this.btnCriarJogador);
            this.pnlDadosJogador.Controls.Add(this.txtNomeJogador);
            this.pnlDadosJogador.Controls.Add(this.lblNomeJogadorSubtitulo);
            this.pnlDadosJogador.Controls.Add(this.lblDadosJogadorTitulo);
            this.pnlDadosJogador.Location = new System.Drawing.Point(10, 257);
            this.pnlDadosJogador.Name = "pnlDadosJogador";
            this.pnlDadosJogador.Size = new System.Drawing.Size(257, 218);
            this.pnlDadosJogador.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 36;
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.Location = new System.Drawing.Point(122, 191);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(100, 13);
            this.lblSenhaJogador.TabIndex = 37;
            // 
            // lblIdJogador
            // 
            this.lblIdJogador.AutoSize = true;
            this.lblIdJogador.Location = new System.Drawing.Point(96, 166);
            this.lblIdJogador.Name = "lblIdJogador";
            this.lblIdJogador.Size = new System.Drawing.Size(0, 13);
            this.lblIdJogador.TabIndex = 35;
            // 
            // lblSenhaJogadorSubtitulo
            // 
            this.lblSenhaJogadorSubtitulo.AutoSize = true;
            this.lblSenhaJogadorSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaJogadorSubtitulo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblSenhaJogadorSubtitulo.Location = new System.Drawing.Point(24, 191);
            this.lblSenhaJogadorSubtitulo.Name = "lblSenhaJogadorSubtitulo";
            this.lblSenhaJogadorSubtitulo.Size = new System.Drawing.Size(96, 13);
            this.lblSenhaJogadorSubtitulo.TabIndex = 33;
            this.lblSenhaJogadorSubtitulo.Text = "Senha Jogador:";
            // 
            // lblIdJogadorSubtitulo
            // 
            this.lblIdJogadorSubtitulo.AutoSize = true;
            this.lblIdJogadorSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdJogadorSubtitulo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblIdJogadorSubtitulo.Location = new System.Drawing.Point(25, 164);
            this.lblIdJogadorSubtitulo.Name = "lblIdJogadorSubtitulo";
            this.lblIdJogadorSubtitulo.Size = new System.Drawing.Size(73, 13);
            this.lblIdJogadorSubtitulo.TabIndex = 34;
            this.lblIdJogadorSubtitulo.Text = "ID Jogador:";
            // 
            // btnCriarJogador
            // 
            this.btnCriarJogador.Location = new System.Drawing.Point(93, 132);
            this.btnCriarJogador.Name = "btnCriarJogador";
            this.btnCriarJogador.Size = new System.Drawing.Size(75, 23);
            this.btnCriarJogador.TabIndex = 33;
            this.btnCriarJogador.Text = "Criar";
            this.btnCriarJogador.UseVisualStyleBackColor = true;
            this.btnCriarJogador.Click += new System.EventHandler(this.btnCriarJogador_Click);
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(23, 99);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(209, 20);
            this.txtNomeJogador.TabIndex = 32;
            // 
            // lblNomeJogadorSubtitulo
            // 
            this.lblNomeJogadorSubtitulo.AutoSize = true;
            this.lblNomeJogadorSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogadorSubtitulo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblNomeJogadorSubtitulo.Location = new System.Drawing.Point(20, 76);
            this.lblNomeJogadorSubtitulo.Name = "lblNomeJogadorSubtitulo";
            this.lblNomeJogadorSubtitulo.Size = new System.Drawing.Size(110, 13);
            this.lblNomeJogadorSubtitulo.TabIndex = 31;
            this.lblNomeJogadorSubtitulo.Text = "Nome do Jogador:";
            // 
            // lblDadosJogadorTitulo
            // 
            this.lblDadosJogadorTitulo.AutoSize = true;
            this.lblDadosJogadorTitulo.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosJogadorTitulo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblDadosJogadorTitulo.Location = new System.Drawing.Point(65, 22);
            this.lblDadosJogadorTitulo.Name = "lblDadosJogadorTitulo";
            this.lblDadosJogadorTitulo.Size = new System.Drawing.Size(122, 17);
            this.lblDadosJogadorTitulo.TabIndex = 0;
            this.lblDadosJogadorTitulo.Text = "DADOS JOGADOR";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIniciar.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciar.BackgroundImage = global::SistemaAutonomo.Properties.Resources.IniciarPartidaBtn;
            this.btnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Location = new System.Drawing.Point(925, 589);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(238, 86);
            this.btnIniciar.TabIndex = 48;
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::SistemaAutonomo.Properties.Resources.FundoPanel;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.lblTeste);
            this.panel2.Location = new System.Drawing.Point(891, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 216);
            this.panel2.TabIndex = 0;
            // 
            // lblTeste
            // 
            this.lblTeste.AutoSize = true;
            this.lblTeste.BackColor = System.Drawing.Color.Transparent;
            this.lblTeste.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTeste.Location = new System.Drawing.Point(15, 70);
            this.lblTeste.Name = "lblTeste";
            this.lblTeste.Size = new System.Drawing.Size(0, 13);
            this.lblTeste.TabIndex = 31;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl3.Location = new System.Drawing.Point(13, 70);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(38, 13);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Data:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl2.Location = new System.Drawing.Point(13, 39);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(43, 13);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Nome:";
            // 
            // lstListaJogadores
            // 
            this.lstListaJogadores.FormattingEnabled = true;
            this.lstListaJogadores.Location = new System.Drawing.Point(22, 129);
            this.lstListaJogadores.Name = "lstListaJogadores";
            this.lstListaJogadores.Size = new System.Drawing.Size(214, 69);
            this.lstListaJogadores.TabIndex = 7;
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.Location = new System.Drawing.Point(74, 100);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(96, 23);
            this.btnListarJogadores.TabIndex = 9;
            this.btnListarJogadores.Text = "Listar Jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = true;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // lblDataPartida
            // 
            this.lblDataPartida.AutoSize = true;
            this.lblDataPartida.Location = new System.Drawing.Point(64, 70);
            this.lblDataPartida.Name = "lblDataPartida";
            this.lblDataPartida.Size = new System.Drawing.Size(0, 13);
            this.lblDataPartida.TabIndex = 8;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl1.Location = new System.Drawing.Point(13, 12);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(24, 13);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "ID:";
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Location = new System.Drawing.Point(64, 39);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(0, 13);
            this.lblNomePartida.TabIndex = 7;
            // 
            // lblIdPartida
            // 
            this.lblIdPartida.AutoSize = true;
            this.lblIdPartida.Location = new System.Drawing.Point(64, 12);
            this.lblIdPartida.Name = "lblIdPartida";
            this.lblIdPartida.Size = new System.Drawing.Size(0, 13);
            this.lblIdPartida.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::SistemaAutonomo.Properties.Resources.FundoPanel;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblIdPartida);
            this.panel1.Controls.Add(this.lblNomePartida);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.lblDataPartida);
            this.panel1.Controls.Add(this.btnListarJogadores);
            this.panel1.Controls.Add(this.lstListaJogadores);
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Controls.Add(this.lbl3);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 227);
            this.panel1.TabIndex = 49;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = global::SistemaAutonomo.Properties.Resources.FundoGame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.pnlDadosJogador);
            this.Controls.Add(this.pnlMaoJogador);
            this.Controls.Add(this.pnlBotaoInfo);
            this.Controls.Add(this.btnVerificarTurno);
            this.Controls.Add(this.lblVersao2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gprPartida);
            this.Controls.Add(this.pnlTabuleiro);
            this.Controls.Add(this.lblNomeGrupo);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(1200, 766);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Draftossauros";
            this.gprPartida.ResumeLayout(false);
            this.gprPartida.PerformLayout();
            this.pnlBotaoInfo.ResumeLayout(false);
            this.pnlBotaoInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDado)).EndInit();
            this.pnlMaoJogador.ResumeLayout(false);
            this.pnlMaoJogador.PerformLayout();
            this.pnlDadosJogador.ResumeLayout(false);
            this.pnlDadosJogador.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblNomeGrupo;
        private System.Windows.Forms.Panel pnlTabuleiro;
        private System.Windows.Forms.ListBox lstMaoDinossauros;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gprPartida;
        private System.Windows.Forms.Label lblRodada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblVersao2;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.Button btnRealizarJogada;
        private System.Windows.Forms.ListBox lstCercados;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnVerificarTurno;
        private System.Windows.Forms.Panel pnlBotaoInfo;
        private System.Windows.Forms.PictureBox pbDado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblLancadoPor;
        private System.Windows.Forms.Label lblDadoSorteadoSubtitulo;
        private System.Windows.Forms.Label lblJogadorDado;
        private System.Windows.Forms.Label lblDadoSorteado;
        private System.Windows.Forms.Panel pnlMaoJogador;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnQuintoDino;
        private System.Windows.Forms.Button btnSextoDino;
        private System.Windows.Forms.Button btnQuartoDino;
        private System.Windows.Forms.Button btnSegundoDino;
        private System.Windows.Forms.Button btnTerceiroDino;
        private System.Windows.Forms.Button btnPrimeiroDino;
        private System.Windows.Forms.Panel pnlDadosJogador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSenhaJogador;
        private System.Windows.Forms.Label lblIdJogador;
        private System.Windows.Forms.Label lblSenhaJogadorSubtitulo;
        private System.Windows.Forms.Label lblIdJogadorSubtitulo;
        private System.Windows.Forms.Button btnCriarJogador;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Label lblNomeJogadorSubtitulo;
        private System.Windows.Forms.Label lblDadosJogadorTitulo;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTeste;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.ListBox lstListaJogadores;
        private System.Windows.Forms.Button btnListarJogadores;
        private System.Windows.Forms.Label lblDataPartida;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.Label lblIdPartida;
        private System.Windows.Forms.Panel panel1;
    }
}

