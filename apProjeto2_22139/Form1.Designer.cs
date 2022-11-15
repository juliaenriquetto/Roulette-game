namespace apProjeto2_22139
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.btnValidarLetra = new System.Windows.Forms.Button();
            this.btnExibirDica = new System.Windows.Forms.Button();
            this.btnGirarRoleta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumSorteado = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbPontucao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPalavra
            // 
            this.txtPalavra.Enabled = false;
            this.txtPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtPalavra.Location = new System.Drawing.Point(12, 12);
            this.txtPalavra.Multiline = true;
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(463, 79);
            this.txtPalavra.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite a LETRA:";
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(127, 114);
            this.txtLetra.MaximumSize = new System.Drawing.Size(100, 100);
            this.txtLetra.MaxLength = 1;
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(31, 20);
            this.txtLetra.TabIndex = 2;
            // 
            // btnValidarLetra
            // 
            this.btnValidarLetra.Location = new System.Drawing.Point(213, 111);
            this.btnValidarLetra.Name = "btnValidarLetra";
            this.btnValidarLetra.Size = new System.Drawing.Size(124, 23);
            this.btnValidarLetra.TabIndex = 3;
            this.btnValidarLetra.Text = "Validar Letra na Frase";
            this.btnValidarLetra.UseVisualStyleBackColor = true;
            this.btnValidarLetra.Click += new System.EventHandler(this.btnValidarLetra_Click);
            // 
            // btnExibirDica
            // 
            this.btnExibirDica.Location = new System.Drawing.Point(349, 111);
            this.btnExibirDica.Name = "btnExibirDica";
            this.btnExibirDica.Size = new System.Drawing.Size(75, 23);
            this.btnExibirDica.TabIndex = 4;
            this.btnExibirDica.Text = "Exibir Dica";
            this.btnExibirDica.UseVisualStyleBackColor = true;
            this.btnExibirDica.Click += new System.EventHandler(this.btnExibirDica_Click);
            // 
            // btnGirarRoleta
            // 
            this.btnGirarRoleta.Location = new System.Drawing.Point(253, 248);
            this.btnGirarRoleta.Name = "btnGirarRoleta";
            this.btnGirarRoleta.Size = new System.Drawing.Size(84, 23);
            this.btnGirarRoleta.TabIndex = 5;
            this.btnGirarRoleta.Text = "Girar Roleta";
            this.btnGirarRoleta.UseVisualStyleBackColor = true;
            this.btnGirarRoleta.Click += new System.EventHandler(this.btnGirarRoleta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Número Sorteado:";
            // 
            // txtNumSorteado
            // 
            this.txtNumSorteado.Enabled = false;
            this.txtNumSorteado.Location = new System.Drawing.Point(349, 281);
            this.txtNumSorteado.Name = "txtNumSorteado";
            this.txtNumSorteado.Size = new System.Drawing.Size(30, 20);
            this.txtNumSorteado.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lbPontucao
            // 
            this.lbPontucao.AutoSize = true;
            this.lbPontucao.Location = new System.Drawing.Point(250, 169);
            this.lbPontucao.Name = "lbPontucao";
            this.lbPontucao.Size = new System.Drawing.Size(16, 13);
            this.lbPontucao.TabIndex = 9;
            this.lbPontucao.Text = "---";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(491, 393);
            this.Controls.Add(this.lbPontucao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNumSorteado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGirarRoleta);
            this.Controls.Add(this.btnExibirDica);
            this.Controls.Add(this.btnValidarLetra);
            this.Controls.Add(this.txtLetra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPalavra);
            this.Name = "FrmPrincipal";
            this.Text = "2o Trabalho REO TP1 - ROLETANDO";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Button btnValidarLetra;
        private System.Windows.Forms.Button btnExibirDica;
        private System.Windows.Forms.Button btnGirarRoleta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumSorteado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbPontucao;
    }
}

