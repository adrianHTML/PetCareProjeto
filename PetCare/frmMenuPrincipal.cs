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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btn_cadAnimal_Click(object sender, EventArgs e)
        {
            frmCadAnimal abrir = new frmCadAnimal();
            abrir.Show();
            this.Hide();
        }

        private void btn_cadVet_Click(object sender, EventArgs e)
        {
            frmCadVet abrir = new frmCadVet();
            abrir.Show();
            this.Hide();
        }

        private void btn_cadCliente_Click(object sender, EventArgs e)
        {
            frmCadCliente abrir = new frmCadCliente();
            abrir.Show();
            this.Hide();
        }
    }
}
