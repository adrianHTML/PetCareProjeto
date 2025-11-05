namespace PetCare
{
    partial class frmMenuPrincipal
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
            this.lbl_petcare = new System.Windows.Forms.Label();
            this.btn_cadCliente = new System.Windows.Forms.Button();
            this.btn_cadAnimal = new System.Windows.Forms.Button();
            this.btn_cadVet = new System.Windows.Forms.Button();
            this.btn_produtos = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_petcare
            // 
            this.lbl_petcare.AutoSize = true;
            this.lbl_petcare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_petcare.Location = new System.Drawing.Point(370, 38);
            this.lbl_petcare.Name = "lbl_petcare";
            this.lbl_petcare.Size = new System.Drawing.Size(69, 18);
            this.lbl_petcare.TabIndex = 0;
            this.lbl_petcare.Text = "PetCare";
            // 
            // btn_cadCliente
            // 
            this.btn_cadCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadCliente.Location = new System.Drawing.Point(306, 98);
            this.btn_cadCliente.Name = "btn_cadCliente";
            this.btn_cadCliente.Size = new System.Drawing.Size(191, 40);
            this.btn_cadCliente.TabIndex = 1;
            this.btn_cadCliente.Text = "Cadastro Cliente";
            this.btn_cadCliente.UseVisualStyleBackColor = true;
            this.btn_cadCliente.Click += new System.EventHandler(this.btn_cadCliente_Click);
            // 
            // btn_cadAnimal
            // 
            this.btn_cadAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadAnimal.Location = new System.Drawing.Point(306, 154);
            this.btn_cadAnimal.Name = "btn_cadAnimal";
            this.btn_cadAnimal.Size = new System.Drawing.Size(191, 40);
            this.btn_cadAnimal.TabIndex = 2;
            this.btn_cadAnimal.Text = "Cadastro Animal";
            this.btn_cadAnimal.UseVisualStyleBackColor = true;
            this.btn_cadAnimal.Click += new System.EventHandler(this.btn_cadAnimal_Click);
            // 
            // btn_cadVet
            // 
            this.btn_cadVet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadVet.Location = new System.Drawing.Point(306, 213);
            this.btn_cadVet.Name = "btn_cadVet";
            this.btn_cadVet.Size = new System.Drawing.Size(191, 40);
            this.btn_cadVet.TabIndex = 3;
            this.btn_cadVet.Text = "Cadastro Veterinário";
            this.btn_cadVet.UseVisualStyleBackColor = true;
            this.btn_cadVet.Click += new System.EventHandler(this.btn_cadVet_Click);
            // 
            // btn_produtos
            // 
            this.btn_produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_produtos.Location = new System.Drawing.Point(306, 270);
            this.btn_produtos.Name = "btn_produtos";
            this.btn_produtos.Size = new System.Drawing.Size(191, 40);
            this.btn_produtos.TabIndex = 4;
            this.btn_produtos.Text = "Produtos";
            this.btn_produtos.UseVisualStyleBackColor = true;
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(306, 328);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(191, 40);
            this.btn_sair.TabIndex = 5;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_produtos);
            this.Controls.Add(this.btn_cadVet);
            this.Controls.Add(this.btn_cadAnimal);
            this.Controls.Add(this.btn_cadCliente);
            this.Controls.Add(this.lbl_petcare);
            this.Name = "frmMenuPrincipal";
            this.Text = "Cadastro Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_petcare;
        private System.Windows.Forms.Button btn_cadCliente;
        private System.Windows.Forms.Button btn_cadAnimal;
        private System.Windows.Forms.Button btn_cadVet;
        private System.Windows.Forms.Button btn_produtos;
        private System.Windows.Forms.Button btn_sair;
    }
}