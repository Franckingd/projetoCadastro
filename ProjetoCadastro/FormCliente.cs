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
    public partial class FormCliente : Form
    {
        private void HabilitaEdicao()
        {
            nm_clienteTextBox.Enabled = true;
            nm_enderecoTextBox.Enabled = true;
            cd_numeroTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            sg_estadoComboBox.Enabled = true;
            cd_cepMaskedTextBox.Enabled = true;
            cd_telefoneMaskedTextBox.Enabled = true;
            cd_cpfMaskedTextBox.Enabled = true;
            cd_rgMaskedTextBox.Enabled = true;
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
            nm_clienteTextBox.Enabled = false;
            nm_enderecoTextBox.Enabled = false;
            cd_numeroTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            sg_estadoComboBox.Enabled = false;
            cd_cepMaskedTextBox.Enabled = false;
            cd_telefoneMaskedTextBox.Enabled = false;
            cd_cpfMaskedTextBox.Enabled = false;
            cd_rgMaskedTextBox.Enabled = false;
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
        public FormCliente()
        {
            InitializeComponent();
        }

        private void TbclienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbcliente'. Você pode movê-la ou removê-la conforme necessário.
            //this.tbclienteTableAdapter.Fill(this.cadastroDataSet.tbcliente);
            DesabilitaEdicao();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tbclienteBindingSource.MovePrevious();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tbclienteBindingSource.MoveNext();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            tbclienteBindingSource.AddNew();
            HabilitaEdicao();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            HabilitaEdicao();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            tbclienteBindingSource.RemoveCurrent();
            //tbclienteTableAdapter.Update(cadastroDataSet.tbcliente);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbclienteBindingSource.EndEdit();
            //tbclienteTableAdapter.Update(cadastroDataSet.tbcliente);
            DesabilitaEdicao();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            tbclienteBindingSource.CancelEdit();
            DesabilitaEdicao();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void cd_numeroTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nm_cidadeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nm_clienteTextBox_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.White;
            ((TextBox)sender).BackColor = Color.Blue;
        }

        private void nm_clienteTextBox_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.Black;
            ((TextBox)sender).BackColor = Color.White;
        }

        private void btnSalvar_Enter(object sender, EventArgs e)
        {
            double cpf1 = 0, cpf2 = 0;

            cpf1 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(10, 1)) * 2;
            cpf1 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(9, 1)) * 3;
            cpf1 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(8, 1)) * 4;
            cpf1 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(6, 1)) * 5;
            cpf1 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(5, 1)) * 6;
            cpf1 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(4, 1)) * 7;
            cpf1 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(2, 1)) * 8;
            cpf1 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(1, 1)) * 9;
            cpf1 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(0, 1)) * 10;
            cpf1 = cpf1 % 11;
            cpf1 = 11 - cpf1;

            cpf2 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(12, 1)) * 2;
            cpf2 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(10, 1)) * 3;
            cpf2 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(9, 1)) * 4;
            cpf2 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(8, 1)) * 5;
            cpf2 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(6, 1)) * 6;
            cpf2 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(5, 1)) * 7;
            cpf2 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(4, 1)) * 8;
            cpf2 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(2, 1)) * 9;
            cpf2 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(1, 1)) * 10;
            cpf2 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(0, 1)) * 11;
            cpf2 = cpf2 % 11;
            cpf2 = 11 - cpf2;

            if (cd_cpfMaskedTextBox.Text.Substring(12, 1) != cpf1.ToString() ||
                cd_cpfMaskedTextBox.Text.Substring(13, 1) != cpf2.ToString())
            {
                MessageBox.Show("CPF inválido!");
                cd_cpfMaskedTextBox.Focus();
            }

        }
    }
}
