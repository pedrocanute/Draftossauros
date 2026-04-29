namespace SistemaAutonomo
{
    partial class Lobby
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbStatusPartidas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.lstListaPartidas = new System.Windows.Forms.ListBox();
            this.btnListarPartida = new System.Windows.Forms.Button();
            this.lblIdGerado = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblNomeGrupo = new System.Windows.Forms.Label();
            this.txtListaPartida = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVersaoDll = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlLobby = new System.Windows.Forms.Panel();
            this.pnlLobby.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbStatusPartidas
            // 
            this.cmbStatusPartidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusPartidas.FormattingEnabled = true;
            this.cmbStatusPartidas.Location = new System.Drawing.Point(158, 134);
            this.cmbStatusPartidas.Name = "cmbStatusPartidas";
            this.cmbStatusPartidas.Size = new System.Drawing.Size(121, 21);
            this.cmbStatusPartidas.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(163, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "ID Criado:";
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(204, 41);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(75, 59);
            this.btnCriarPartida.TabIndex = 25;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(47, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(50, 80);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(148, 20);
            this.txtSenha.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(47, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nome da Partida:";
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(50, 41);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(148, 20);
            this.txtNomePartida.TabIndex = 21;
            // 
            // lstListaPartidas
            // 
            this.lstListaPartidas.FormattingEnabled = true;
            this.lstListaPartidas.Location = new System.Drawing.Point(50, 163);
            this.lstListaPartidas.Name = "lstListaPartidas";
            this.lstListaPartidas.Size = new System.Drawing.Size(229, 134);
            this.lstListaPartidas.TabIndex = 20;
            // 
            // btnListarPartida
            // 
            this.btnListarPartida.Location = new System.Drawing.Point(50, 134);
            this.btnListarPartida.Name = "btnListarPartida";
            this.btnListarPartida.Size = new System.Drawing.Size(86, 23);
            this.btnListarPartida.TabIndex = 19;
            this.btnListarPartida.Text = "Listar Partidas";
            this.btnListarPartida.UseVisualStyleBackColor = true;
            this.btnListarPartida.Click += new System.EventHandler(this.btnListarPartida_Click);
            // 
            // lblIdGerado
            // 
            this.lblIdGerado.AutoSize = true;
            this.lblIdGerado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdGerado.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblIdGerado.Location = new System.Drawing.Point(227, 118);
            this.lblIdGerado.Name = "lblIdGerado";
            this.lblIdGerado.Size = new System.Drawing.Size(0, 13);
            this.lblIdGerado.TabIndex = 28;
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(319, 358);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(0, 13);
            this.lblVersao.TabIndex = 29;
            // 
            // lblNomeGrupo
            // 
            this.lblNomeGrupo.AutoSize = true;
            this.lblNomeGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeGrupo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblNomeGrupo.Location = new System.Drawing.Point(267, 365);
            this.lblNomeGrupo.Name = "lblNomeGrupo";
            this.lblNomeGrupo.Size = new System.Drawing.Size(68, 13);
            this.lblNomeGrupo.TabIndex = 30;
            this.lblNomeGrupo.Text = "Primordiais";
            // 
            // txtListaPartida
            // 
            this.txtListaPartida.Location = new System.Drawing.Point(50, 161);
            this.txtListaPartida.Multiline = true;
            this.txtListaPartida.Name = "txtListaPartida";
            this.txtListaPartida.Size = new System.Drawing.Size(229, 138);
            this.txtListaPartida.TabIndex = 31;
            this.txtListaPartida.Visible = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(94, 311);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(123, 23);
            this.btnEntrar.TabIndex = 32;
            this.btnEntrar.Text = "Entrar na Partida";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(204, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Versão:";
            // 
            // lblVersaoDll
            // 
            this.lblVersaoDll.AutoSize = true;
            this.lblVersaoDll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersaoDll.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblVersaoDll.Location = new System.Drawing.Point(267, 383);
            this.lblVersaoDll.Name = "lblVersaoDll";
            this.lblVersaoDll.Size = new System.Drawing.Size(50, 13);
            this.lblVersaoDll.TabIndex = 34;
            this.lblVersaoDll.Text = "Versão:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(204, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Grupo:";
            // 
            // pnlLobby
            // 
            this.pnlLobby.BackColor = System.Drawing.Color.Transparent;
            this.pnlLobby.BackgroundImage = global::SistemaAutonomo.Properties.Resources.FundoPanel;
            this.pnlLobby.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLobby.Controls.Add(this.lstListaPartidas);
            this.pnlLobby.Controls.Add(this.cmbStatusPartidas);
            this.pnlLobby.Controls.Add(this.txtListaPartida);
            this.pnlLobby.Controls.Add(this.btnListarPartida);
            this.pnlLobby.Controls.Add(this.btnEntrar);
            this.pnlLobby.Controls.Add(this.lblIdGerado);
            this.pnlLobby.Controls.Add(this.btnCriarPartida);
            this.pnlLobby.Controls.Add(this.label4);
            this.pnlLobby.Controls.Add(this.txtNomePartida);
            this.pnlLobby.Controls.Add(this.txtSenha);
            this.pnlLobby.Controls.Add(this.label5);
            this.pnlLobby.Controls.Add(this.label3);
            this.pnlLobby.Location = new System.Drawing.Point(12, 12);
            this.pnlLobby.Name = "pnlLobby";
            this.pnlLobby.Size = new System.Drawing.Size(323, 350);
            this.pnlLobby.TabIndex = 37;
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(346, 398);
            this.Controls.Add(this.pnlLobby);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVersaoDll);
            this.Controls.Add(this.lblNomeGrupo);
            this.Controls.Add(this.lblVersao);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Lobby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Draftosauros-Lobby";
            this.pnlLobby.ResumeLayout(false);
            this.pnlLobby.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStatusPartidas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.ListBox lstListaPartidas;
        private System.Windows.Forms.Button btnListarPartida;
        private System.Windows.Forms.Label lblIdGerado;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label lblNomeGrupo;
        private System.Windows.Forms.TextBox txtListaPartida;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVersaoDll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlLobby;
    }
}