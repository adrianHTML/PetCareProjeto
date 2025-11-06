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
    public partial class frmCadVet : Form
    {
        public frmCadVet()
        {
            InitializeComponent();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_codigo.Clear();
            txt_idade.Clear();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }
    }
}
