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
    public partial class FormPagar : Form
    {
        public FormPagar()
        {
            InitializeComponent();
        }

        private void FormPagar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbcontaspagar'. Você pode movê-la ou removê-la conforme necessário.
            //this.tbcontaspagarTableAdapter.Fill(this.cadastroDataSet.tbcontaspagar);

        }

        private void cd_contaLabel_Click(object sender, EventArgs e)
        {

        }

        private void ds_contaLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
