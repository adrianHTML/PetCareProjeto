namespace PetCare
{
    partial class frmCadAnimal
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
            this.lbl_dados = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.lbl_cor = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_detalhe = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_detalhe = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.cbb_cor = new System.Windows.Forms.ComboBox();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_dados
            // 
            this.lbl_dados.AutoSize = true;
            this.lbl_dados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dados.Location = new System.Drawing.Point(33, 27);
            this.lbl_dados.Name = "lbl_dados";
            this.lbl_dados.Size = new System.Drawing.Size(136, 18);
            this.lbl_dados.TabIndex = 0;
            this.lbl_dados.Text = "Dados do Animal";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(57, 111);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(24, 18);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "ID";
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_peso.Location = new System.Drawing.Point(57, 145);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(47, 18);
            this.lbl_peso.TabIndex = 2;
            this.lbl_peso.Text = "Peso";
            // 
            // lbl_cor
            // 
            this.lbl_cor.AutoSize = true;
            this.lbl_cor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cor.Location = new System.Drawing.Point(57, 182);
            this.lbl_cor.Name = "lbl_cor";
            this.lbl_cor.Size = new System.Drawing.Size(36, 18);
            this.lbl_cor.TabIndex = 3;
            this.lbl_cor.Text = "Cor";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(57, 220);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(53, 18);
            this.lbl_nome.TabIndex = 4;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_detalhe
            // 
            this.lbl_detalhe.AutoSize = true;
            this.lbl_detalhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_detalhe.Location = new System.Drawing.Point(57, 262);
            this.lbl_detalhe.Name = "lbl_detalhe";
            this.lbl_detalhe.Size = new System.Drawing.Size(65, 18);
            this.lbl_detalhe.TabIndex = 5;
            this.lbl_detalhe.Text = "Detalhe";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(147, 109);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 1;
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(147, 143);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(100, 20);
            this.txt_peso.TabIndex = 6;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(147, 221);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 8;
            // 
            // txt_detalhe
            // 
            this.txt_detalhe.Location = new System.Drawing.Point(147, 260);
            this.txt_detalhe.Name = "txt_detalhe";
            this.txt_detalhe.Size = new System.Drawing.Size(100, 20);
            this.txt_detalhe.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PetCare.Properties.Resources.dog;
            this.pictureBox1.Location = new System.Drawing.Point(394, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(192, 371);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(160, 47);
            this.btn_limpar.TabIndex = 11;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(568, 371);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(160, 47);
            this.btn_sair.TabIndex = 12;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            // 
            // cbb_cor
            // 
            this.cbb_cor.FormattingEnabled = true;
            this.cbb_cor.Items.AddRange(new object[] {
            "Laranja (Orange)",
            "Verde (Green)",
            "Azul (Blue)",
            "Roxo (Purple)",
            "Ciano (Cyan)",
            "Vermelho (Red)",
            "Amarelo (Yellow)",
            "Cinza (Gray)",
            "Preto (Nigga)",
            "Branco (Good)",
            "Judeu (Jew)",
            "Chinês (Chinese)"});
            this.cbb_cor.Location = new System.Drawing.Point(147, 179);
            this.cbb_cor.Name = "cbb_cor";
            this.cbb_cor.Size = new System.Drawing.Size(100, 21);
            this.cbb_cor.TabIndex = 13;
            // 
            // btn_novo
            // 
            this.btn_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.Location = new System.Drawing.Point(12, 371);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(160, 47);
            this.btn_novo.TabIndex = 14;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(379, 371);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(160, 47);
            this.btn_voltar.TabIndex = 15;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // frmCadAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.cbb_cor);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_detalhe);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_detalhe);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_cor);
            this.Controls.Add(this.lbl_peso);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_dados);
            this.Name = "frmCadAnimal";
            this.Text = "Cadastro Animal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dados;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.Label lbl_cor;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_detalhe;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_detalhe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.ComboBox cbb_cor;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_voltar;
    }
}