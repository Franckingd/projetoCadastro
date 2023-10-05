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
    public partial class FormUsuario : Form
    {
        private void HabilitaEdicao()
        {
            nm_usuarioTextBox.Enabled = true;
            sg_nivelTextBox.Enabled = true;
            nm_loginTextBox.Enabled = true;
            cd_senhaTextBox.Enabled = true;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnPesquisar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSair.Enabled = false;
        }

        private void DesabilitaEdicao()
        {
            nm_usuarioTextBox.Enabled = false;
            sg_nivelTextBox.Enabled = false;
            nm_loginTextBox.Enabled = false;
            cd_senhaTextBox.Enabled = false;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnPesquisar.Enabled = true;
            btnImprimir.Enabled = true;
            btnSair.Enabled = true;
        }
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbusuario'. Você pode movê-la ou removê-la conforme necessário.
            //this.tbusuarioTableAdapter.Fill(this.cadastroDataSet.tbusuario);
            DesabilitaEdicao();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbusuarioBindingSource.MoveNext();
        }


        private void tbusuarioBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
        }

        private void cd_usuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nm_usuarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbusuarioBindingSource.MovePrevious();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbusuarioBindingSource.AddNew();
            HabilitaEdicao();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            HabilitaEdicao();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tbusuarioBindingSource.RemoveCurrent();
            //tbusuarioTableAdapter.Update(cadastroDataSet.tbusuario);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbusuarioBindingSource.EndEdit();
            //tbusuarioTableAdapter.Update(cadastroDataSet.tbusuario);
            DesabilitaEdicao();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbusuarioBindingSource.CancelEdit();
            DesabilitaEdicao();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            int cod, reg;
            frmPesquisaUsuario fpu = new frmPesquisaUsuario();
            fpu.ShowDialog();
            cod = fpu.getCodigo();
            if (cod >= 0)
            {
                reg = tbusuarioBindingSource.Find("cd_usuario", cod);
                tbusuarioBindingSource.Position = reg;
            }
        }

        private void nm_usuarioTextBox_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.White;
            ((TextBox)sender).BackColor = Color.Blue;
        }

        private void nm_usuarioTextBox_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.Black;
            ((TextBox)sender).BackColor = Color.White;
        }
    }
}
