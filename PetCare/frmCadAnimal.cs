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
    public partial class frmCadAnimal : Form
    {
        public frmCadAnimal()
        {
            InitializeComponent();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_peso.Clear();
            cbb_cor.ResetText();
            txt_nome.Clear();
            txt_detalhe.Clear();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }
    }
}
