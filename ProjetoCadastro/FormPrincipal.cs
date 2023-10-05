using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuario fu = new FormUsuario();
            fu.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente fu = new FormCliente();
            fu.ShowDialog();
        }

        private void CadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFornecedores fu = new FormFornecedores();
            fu.ShowDialog();
        }

        private void contasÀPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPagar fu = new FormPagar();
            fu.ShowDialog();
        }

        private void contasÀReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReceber fu = new FormReceber();
            fu.ShowDialog();
        }
    }
}
