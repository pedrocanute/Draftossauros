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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbStatusPartidas
            // 
            this.cmbStatusPartidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusPartidas.FormattingEnabled = true;
            this.cmbStatusPartidas.Location = new System.Drawing.Point(161, 124);
            this.cmbStatusPartidas.Name = "cmbStatusPartidas";
            this.cmbStatusPartidas.Size = new System.Drawing.Size(121, 21);
            this.cmbStatusPartidas.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "ID Criado:";
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(171, 34);
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
            this.label4.Location = new System.Drawing.Point(14, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(17, 73);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(148, 20);
            this.txtSenha.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nome da Partida:";
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(17, 34);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(148, 20);
            this.txtNomePartida.TabIndex = 21;
            // 
            // lstListaPartidas
            // 
            this.lstListaPartidas.FormattingEnabled = true;
            this.lstListaPartidas.Location = new System.Drawing.Point(53, 164);
            this.lstListaPartidas.Name = "lstListaPartidas";
            this.lstListaPartidas.Size = new System.Drawing.Size(229, 134);
            this.lstListaPartidas.TabIndex = 20;
            // 
            // btnListarPartida
            // 
            this.btnListarPartida.Location = new System.Drawing.Point(53, 122);
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
            this.lblIdGerado.Location = new System.Drawing.Point(222, 96);
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
            this.lblNomeGrupo.Location = new System.Drawing.Point(237, 358);
            this.lblNomeGrupo.Name = "lblNomeGrupo";
            this.lblNomeGrupo.Size = new System.Drawing.Size(57, 13);
            this.lblNomeGrupo.TabIndex = 30;
            this.lblNomeGrupo.Text = "Primordiais";
            // 
            // txtListaPartida
            // 
            this.txtListaPartida.Location = new System.Drawing.Point(53, 162);
            this.txtListaPartida.Multiline = true;
            this.txtListaPartida.Name = "txtListaPartida";
            this.txtListaPartida.Size = new System.Drawing.Size(229, 138);
            this.txtListaPartida.TabIndex = 31;
            this.txtListaPartida.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEntrar);
            this.groupBox1.Controls.Add(this.btnCriarPartida);
            this.groupBox1.Controls.Add(this.txtNomePartida);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.cmbStatusPartidas);
            this.groupBox1.Controls.Add(this.lblIdGerado);
            this.groupBox1.Controls.Add(this.lstListaPartidas);
            this.groupBox1.Controls.Add(this.btnListarPartida);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtListaPartida);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 343);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(99, 314);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(123, 23);
            this.btnEntrar.TabIndex = 32;
            this.btnEntrar.Text = "Entrar na Partida";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 380);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNomeGrupo);
            this.Controls.Add(this.lblVersao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Lobby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Draftosauros-Lobby";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEntrar;
    }
}