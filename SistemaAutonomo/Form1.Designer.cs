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
            this.btnListarPartida = new System.Windows.Forms.Button();
            this.txtListaPartida = new System.Windows.Forms.TextBox();
            this.lstListaPartidas = new System.Windows.Forms.ListBox();
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
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIdGerado = new System.Windows.Forms.Label();
            this.cmbStatusPartidas = new System.Windows.Forms.ComboBox();
            this.grpDadosPartida.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListarPartida
            // 
            this.btnListarPartida.Location = new System.Drawing.Point(40, 129);
            this.btnListarPartida.Name = "btnListarPartida";
            this.btnListarPartida.Size = new System.Drawing.Size(86, 23);
            this.btnListarPartida.TabIndex = 0;
            this.btnListarPartida.Text = "Listar Partidas";
            this.btnListarPartida.UseVisualStyleBackColor = true;
            this.btnListarPartida.Click += new System.EventHandler(this.btnListarPartida_Click);
            // 
            // txtListaPartida
            // 
            this.txtListaPartida.Location = new System.Drawing.Point(40, 158);
            this.txtListaPartida.Multiline = true;
            this.txtListaPartida.Name = "txtListaPartida";
            this.txtListaPartida.Size = new System.Drawing.Size(236, 188);
            this.txtListaPartida.TabIndex = 1;
            this.txtListaPartida.Visible = false;
            // 
            // lstListaPartidas
            // 
            this.lstListaPartidas.FormattingEnabled = true;
            this.lstListaPartidas.Location = new System.Drawing.Point(40, 160);
            this.lstListaPartidas.Name = "lstListaPartidas";
            this.lstListaPartidas.Size = new System.Drawing.Size(229, 225);
            this.lstListaPartidas.TabIndex = 2;
            this.lstListaPartidas.SelectedIndexChanged += new System.EventHandler(this.lstListaPartidas_SelectedIndexChanged);
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
            this.grpDadosPartida.Location = new System.Drawing.Point(282, 155);
            this.grpDadosPartida.Name = "grpDadosPartida";
            this.grpDadosPartida.Size = new System.Drawing.Size(259, 262);
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
            this.lstListaJogadores.Size = new System.Drawing.Size(214, 95);
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
            this.label1.Location = new System.Drawing.Point(435, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Versão:";
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(484, 457);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(0, 13);
            this.lblVersao.TabIndex = 8;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(435, 437);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(39, 13);
            this.lblGrupo.TabIndex = 9;
            this.lblGrupo.Text = "Grupo:";
            // 
            // lblNomeGrupo
            // 
            this.lblNomeGrupo.AutoSize = true;
            this.lblNomeGrupo.Location = new System.Drawing.Point(484, 437);
            this.lblNomeGrupo.Name = "lblNomeGrupo";
            this.lblNomeGrupo.Size = new System.Drawing.Size(57, 13);
            this.lblNomeGrupo.TabIndex = 10;
            this.lblNomeGrupo.Text = "Primordiais";
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(40, 43);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(148, 20);
            this.txtNomePartida.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nome da Partida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(40, 82);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(148, 20);
            this.txtSenha.TabIndex = 13;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(194, 43);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(75, 59);
            this.btnCriarPartida.TabIndex = 15;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "ID Criado:";
            // 
            // lblIdGerado
            // 
            this.lblIdGerado.AutoSize = true;
            this.lblIdGerado.Location = new System.Drawing.Point(248, 105);
            this.lblIdGerado.Name = "lblIdGerado";
            this.lblIdGerado.Size = new System.Drawing.Size(0, 13);
            this.lblIdGerado.TabIndex = 17;
            // 
            // cmbStatusPartidas
            // 
            this.cmbStatusPartidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusPartidas.FormattingEnabled = true;
            this.cmbStatusPartidas.Location = new System.Drawing.Point(148, 131);
            this.cmbStatusPartidas.Name = "cmbStatusPartidas";
            this.cmbStatusPartidas.Size = new System.Drawing.Size(121, 21);
            this.cmbStatusPartidas.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 483);
            this.Controls.Add(this.cmbStatusPartidas);
            this.Controls.Add(this.lblIdGerado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomePartida);
            this.Controls.Add(this.lblNomeGrupo);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpDadosPartida);
            this.Controls.Add(this.lstListaPartidas);
            this.Controls.Add(this.txtListaPartida);
            this.Controls.Add(this.btnListarPartida);
            this.MaximumSize = new System.Drawing.Size(568, 522);
            this.MinimumSize = new System.Drawing.Size(568, 522);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Draftossauros";
            this.grpDadosPartida.ResumeLayout(false);
            this.grpDadosPartida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarPartida;
        private System.Windows.Forms.TextBox txtListaPartida;
        private System.Windows.Forms.ListBox lstListaPartidas;
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
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIdGerado;
        private System.Windows.Forms.ComboBox cmbStatusPartidas;
    }
}

