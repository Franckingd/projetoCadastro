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
    public partial class FormFornecedores : Form
    {
        private void HabilitaEdicao()
        {
            nm_fornecedorTextBox.Enabled = true;
            cd_cnpjMaskedTextBox.Enabled = true;
            cd_ieMaskedTextBox.Enabled = true;
            nm_enderecoTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            sg_estadoComboBox.Enabled = true;
            cd_cepMaskedTextBox.Enabled = true;
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
            nm_fornecedorTextBox.Enabled = false;
            cd_cnpjMaskedTextBox.Enabled = false;
            cd_ieMaskedTextBox.Enabled = false;
            nm_enderecoTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            sg_estadoComboBox.Enabled = false;
            cd_cepMaskedTextBox.Enabled = false;
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
        public FormFornecedores()
        {
            InitializeComponent();
        }

        private void TbfornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void FormFornecedores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbfornecedor'. Você pode movê-la ou removê-la conforme necessário.
            //this.tbfornecedorTableAdapter.Fill(this.cadastroDataSet.tbfornecedor);
            DesabilitaEdicao();

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Validate();
            tbfornecedorBindingSource.EndEdit();
            DesabilitaEdicao();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            tbfornecedorBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            tbfornecedorBindingSource.MoveNext();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            tbfornecedorBindingSource.AddNew();
            HabilitaEdicao();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            HabilitaEdicao();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            tbfornecedorBindingSource.RemoveCurrent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            tbfornecedorBindingSource.CancelEdit();
            DesabilitaEdicao();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void nm_fornecedorTextBox_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.White;
            ((TextBox)sender).BackColor = Color.Blue;
        }

        private void nm_fornecedorTextBox_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.Black;
            ((TextBox)sender).BackColor = Color.White;
        }

        private void cd_ieLabel1_Click(object sender, EventArgs e)
        {

        }

        private void cd_ieMaskedTextBox_Leave(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Leave(object sender, EventArgs e)
        {
           
        }

        private void btnSalvar_Enter(object sender, EventArgs e)
        {
            double dig1 = 0, dig2 = 0, cpf1 = 0;

            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(14, 1)) * 2;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(13, 1)) * 3;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(12, 1)) * 4;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(11, 1)) * 5;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(9, 1)) * 6;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(8, 1)) * 7;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(7, 1)) * 8;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(5, 1)) * 9;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(4, 1)) * 2;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(3, 1)) * 3;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(1, 1)) * 4;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(0, 1)) * 5;
            dig1 = dig1 % 11;
            dig1 = 11 - dig1;


            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(16, 1)) * 2;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(14, 1)) * 3;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(13, 1)) * 4;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(12, 1)) * 5;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(11, 1)) * 6;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(9, 1)) * 7;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(8, 1)) * 8;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(7, 1)) * 9;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(5, 1)) * 2;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(4, 1)) * 3;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(3, 1)) * 4;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(1, 1)) * 5;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(0, 1)) * 6;
            dig2 = dig2 % 11;
            dig2 = 11 - dig2;

            if (cd_cnpjMaskedTextBox.Text.Substring(16, 1) != dig1.ToString() ||
                cd_cnpjMaskedTextBox.Text.Substring(17, 1) != dig2.ToString())
            {
                MessageBox.Show("CNPJ inválido!");
                cd_cnpjMaskedTextBox.Focus();
            }

        }
    }
}
