using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetCare
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            string usuario;
            int senha;

            usuario = txt_nome.Text; 
            senha = Convert.ToInt32(txt_senha.Text);

            if(usuario == "admin" & senha == 123)
            {
               frmMenuPrincipal abrir = new frmMenuPrincipal();
                abrir.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Usuário ou Senha errados.");
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_senha.Clear();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}