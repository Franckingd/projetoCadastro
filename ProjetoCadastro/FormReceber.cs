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
    public partial class FormReceber : Form
    {
        public FormReceber()
        {
            InitializeComponent();
        }
        private void FormReceber_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbcontasreceber'. Você pode movê-la ou removê-la conforme necessário.
            //this.tbcontasreceberTableAdapter.Fill(this.cadastroDataSet.tbcontasreceber);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
