namespace Jogo_Da_Velha
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
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.btn_reiniciar = new System.Windows.Forms.Button();
            this.lbl_jogador = new System.Windows.Forms.Label();
            this.txt_coluna = new System.Windows.Forms.TextBox();
            this.txt_linha = new System.Windows.Forms.TextBox();
            this.btn_jogar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_jogo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.ForeColor = System.Drawing.Color.Red;
            this.lbl_resultado.Location = new System.Drawing.Point(128, 546);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(0, 20);
            this.lbl_resultado.TabIndex = 20;
            // 
            // btn_reiniciar
            // 
            this.btn_reiniciar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_reiniciar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_reiniciar.Location = new System.Drawing.Point(118, 614);
            this.btn_reiniciar.Name = "btn_reiniciar";
            this.btn_reiniciar.Size = new System.Drawing.Size(127, 25);
            this.btn_reiniciar.TabIndex = 19;
            this.btn_reiniciar.Text = "Reiniciar";
            this.btn_reiniciar.UseVisualStyleBackColor = false;
            this.btn_reiniciar.Click += new System.EventHandler(this.btn_reiniciar_Click);
            // 
            // lbl_jogador
            // 
            this.lbl_jogador.AutoSize = true;
            this.lbl_jogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jogador.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_jogador.Location = new System.Drawing.Point(191, 425);
            this.lbl_jogador.Name = "lbl_jogador";
            this.lbl_jogador.Size = new System.Drawing.Size(0, 24);
            this.lbl_jogador.TabIndex = 18;
            // 
            // txt_coluna
            // 
            this.txt_coluna.Location = new System.Drawing.Point(295, 500);
            this.txt_coluna.Name = "txt_coluna";
            this.txt_coluna.Size = new System.Drawing.Size(54, 20);
            this.txt_coluna.TabIndex = 17;
            // 
            // txt_linha
            // 
            this.txt_linha.Location = new System.Drawing.Point(277, 464);
            this.txt_linha.Name = "txt_linha";
            this.txt_linha.Size = new System.Drawing.Size(54, 20);
            this.txt_linha.TabIndex = 16;
            // 
            // btn_jogar
            // 
            this.btn_jogar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_jogar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_jogar.Location = new System.Drawing.Point(118, 583);
            this.btn_jogar.Name = "btn_jogar";
            this.btn_jogar.Size = new System.Drawing.Size(127, 25);
            this.btn_jogar.TabIndex = 15;
            this.btn_jogar.Text = "Jogar";
            this.btn_jogar.UseVisualStyleBackColor = false;
            this.btn_jogar.Click += new System.EventHandler(this.btn_jogar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(26, 496);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Digite o número da coluna:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(26, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Digite o número da linha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(26, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Jogador da vez:";
            // 
            // lbl_jogo
            // 
            this.lbl_jogo.AutoSize = true;
            this.lbl_jogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jogo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_jogo.Location = new System.Drawing.Point(67, 43);
            this.lbl_jogo.Name = "lbl_jogo";
            this.lbl_jogo.Size = new System.Drawing.Size(0, 55);
            this.lbl_jogo.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(368, 677);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.btn_reiniciar);
            this.Controls.Add(this.lbl_jogador);
            this.Controls.Add(this.txt_coluna);
            this.Controls.Add(this.txt_linha);
            this.Controls.Add(this.btn_jogar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_jogo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Button btn_reiniciar;
        private System.Windows.Forms.Label lbl_jogador;
        private System.Windows.Forms.TextBox txt_coluna;
        private System.Windows.Forms.TextBox txt_linha;
        private System.Windows.Forms.Button btn_jogar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_jogo;
    }
}

