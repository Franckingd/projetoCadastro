namespace ProjetoCadastro
{
    partial class FormFornecedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cd_fornecedorLabel;
            System.Windows.Forms.Label nm_fornecedorLabel;
            System.Windows.Forms.Label nm_bairroLabel;
            System.Windows.Forms.Label nm_cidadeLabel;
            System.Windows.Forms.Label cd_cnpjLabel1;
            System.Windows.Forms.Label cd_ieLabel1;
            System.Windows.Forms.Label sg_estadoLabel1;
            System.Windows.Forms.Label cd_cepLabel1;
            System.Windows.Forms.Label nm_enderecoLabel;
            this.cadastroDataSet = new ProjetoCadastro.CadastroDataSet();
            this.tbfornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbfornecedorTableAdapter = new ProjetoCadastro.CadastroDataSetTableAdapters.tbfornecedorTableAdapter();
            this.cd_fornecedorTextBox = new System.Windows.Forms.TextBox();
            this.nm_fornecedorTextBox = new System.Windows.Forms.TextBox();
            this.nm_bairroTextBox = new System.Windows.Forms.TextBox();
            this.nm_cidadeTextBox = new System.Windows.Forms.TextBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.tableAdapterManager = new ProjetoCadastro.CadastroDataSetTableAdapters.TableAdapterManager();
            this.cd_cnpjMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cd_ieMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.sg_estadoComboBox = new System.Windows.Forms.ComboBox();
            this.cd_cepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nm_enderecoTextBox = new System.Windows.Forms.TextBox();
            cd_fornecedorLabel = new System.Windows.Forms.Label();
            nm_fornecedorLabel = new System.Windows.Forms.Label();
            nm_bairroLabel = new System.Windows.Forms.Label();
            nm_cidadeLabel = new System.Windows.Forms.Label();
            cd_cnpjLabel1 = new System.Windows.Forms.Label();
            cd_ieLabel1 = new System.Windows.Forms.Label();
            sg_estadoLabel1 = new System.Windows.Forms.Label();
            cd_cepLabel1 = new System.Windows.Forms.Label();
            nm_enderecoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfornecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_fornecedorLabel
            // 
            cd_fornecedorLabel.AutoSize = true;
            cd_fornecedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_fornecedorLabel.Location = new System.Drawing.Point(113, 74);
            cd_fornecedorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cd_fornecedorLabel.Name = "cd_fornecedorLabel";
            cd_fornecedorLabel.Size = new System.Drawing.Size(81, 25);
            cd_fornecedorLabel.TabIndex = 1;
            cd_fornecedorLabel.Text = "Código:";
            // 
            // nm_fornecedorLabel
            // 
            nm_fornecedorLabel.AutoSize = true;
            nm_fornecedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_fornecedorLabel.Location = new System.Drawing.Point(113, 124);
            nm_fornecedorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nm_fornecedorLabel.Name = "nm_fornecedorLabel";
            nm_fornecedorLabel.Size = new System.Drawing.Size(70, 25);
            nm_fornecedorLabel.TabIndex = 3;
            nm_fornecedorLabel.Text = "Nome:";
            // 
            // nm_bairroLabel
            // 
            nm_bairroLabel.AutoSize = true;
            nm_bairroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_bairroLabel.Location = new System.Drawing.Point(113, 324);
            nm_bairroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nm_bairroLabel.Name = "nm_bairroLabel";
            nm_bairroLabel.Size = new System.Drawing.Size(69, 25);
            nm_bairroLabel.TabIndex = 11;
            nm_bairroLabel.Text = "Bairro:";
            // 
            // nm_cidadeLabel
            // 
            nm_cidadeLabel.AutoSize = true;
            nm_cidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_cidadeLabel.Location = new System.Drawing.Point(113, 374);
            nm_cidadeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nm_cidadeLabel.Name = "nm_cidadeLabel";
            nm_cidadeLabel.Size = new System.Drawing.Size(81, 25);
            nm_cidadeLabel.TabIndex = 13;
            nm_cidadeLabel.Text = "Cidade:";
            // 
            // cadastroDataSet
            // 
            this.cadastroDataSet.DataSetName = "CadastroDataSet";
            this.cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbfornecedorBindingSource
            // 
            this.tbfornecedorBindingSource.DataMember = "tbfornecedor";
            this.tbfornecedorBindingSource.DataSource = this.cadastroDataSet;
            // 
            // tbfornecedorTableAdapter
            // 
            this.tbfornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // cd_fornecedorTextBox
            // 
            this.cd_fornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbfornecedorBindingSource, "cd_fornecedor", true));
            this.cd_fornecedorTextBox.Enabled = false;
            this.cd_fornecedorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_fornecedorTextBox.Location = new System.Drawing.Point(287, 74);
            this.cd_fornecedorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cd_fornecedorTextBox.Name = "cd_fornecedorTextBox";
            this.cd_fornecedorTextBox.Size = new System.Drawing.Size(132, 30);
            this.cd_fornecedorTextBox.TabIndex = 2;
            // 
            // nm_fornecedorTextBox
            // 
            this.nm_fornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbfornecedorBindingSource, "nm_fornecedor", true));
            this.nm_fornecedorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_fornecedorTextBox.Location = new System.Drawing.Point(287, 123);
            this.nm_fornecedorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nm_fornecedorTextBox.MaxLength = 50;
            this.nm_fornecedorTextBox.Name = "nm_fornecedorTextBox";
            this.nm_fornecedorTextBox.Size = new System.Drawing.Size(488, 30);
            this.nm_fornecedorTextBox.TabIndex = 4;
            this.nm_fornecedorTextBox.Enter += new System.EventHandler(this.nm_fornecedorTextBox_Enter);
            this.nm_fornecedorTextBox.Leave += new System.EventHandler(this.nm_fornecedorTextBox_Leave);
            // 
            // nm_bairroTextBox
            // 
            this.nm_bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbfornecedorBindingSource, "nm_bairro", true));
            this.nm_bairroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_bairroTextBox.Location = new System.Drawing.Point(287, 319);
            this.nm_bairroTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nm_bairroTextBox.MaxLength = 30;
            this.nm_bairroTextBox.Name = "nm_bairroTextBox";
            this.nm_bairroTextBox.Size = new System.Drawing.Size(488, 30);
            this.nm_bairroTextBox.TabIndex = 12;
            this.nm_bairroTextBox.Enter += new System.EventHandler(this.nm_fornecedorTextBox_Enter);
            this.nm_bairroTextBox.Leave += new System.EventHandler(this.nm_fornecedorTextBox_Leave);
            // 
            // nm_cidadeTextBox
            // 
            this.nm_cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbfornecedorBindingSource, "nm_cidade", true));
            this.nm_cidadeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_cidadeTextBox.Location = new System.Drawing.Point(287, 368);
            this.nm_cidadeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nm_cidadeTextBox.MaxLength = 40;
            this.nm_cidadeTextBox.Name = "nm_cidadeTextBox";
            this.nm_cidadeTextBox.Size = new System.Drawing.Size(488, 30);
            this.nm_cidadeTextBox.TabIndex = 14;
            this.nm_cidadeTextBox.Enter += new System.EventHandler(this.nm_fornecedorTextBox_Enter);
            this.nm_cidadeTextBox.Leave += new System.EventHandler(this.nm_fornecedorTextBox_Leave);
            // 
            // btnAnterior
            // 
            this.btnAnterior.AutoSize = true;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(955, 46);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(123, 53);
            this.btnAnterior.TabIndex = 19;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.AutoSize = true;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(955, 148);
            this.btnProximo.Margin = new System.Windows.Forms.Padding(4);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(123, 53);
            this.btnProximo.TabIndex = 20;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.BtnProximo_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = true;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(955, 250);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(123, 53);
            this.btnNovo.TabIndex = 21;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoSize = true;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(955, 352);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(123, 53);
            this.btnAlterar.TabIndex = 22;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(955, 454);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(123, 53);
            this.btnExcluir.TabIndex = 23;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(1164, 46);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(123, 53);
            this.btnSalvar.TabIndex = 24;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.Button6_Click);
            this.btnSalvar.Enter += new System.EventHandler(this.btnSalvar_Enter);
            this.btnSalvar.Leave += new System.EventHandler(this.btnSalvar_Leave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1164, 148);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 53);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoSize = true;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(1164, 250);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(123, 53);
            this.btnPesquisar.TabIndex = 26;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(1164, 352);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(123, 53);
            this.btnImprimir.TabIndex = 27;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(1164, 454);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(123, 53);
            this.btnSair.TabIndex = 28;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbclienteTableAdapter = null;
            this.tableAdapterManager.tbcontaspagarTableAdapter = null;
            this.tableAdapterManager.tbcontasreceberTableAdapter = null;
            this.tableAdapterManager.tbfornecedorTableAdapter = this.tbfornecedorTableAdapter;
            this.tableAdapterManager.tbusuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoCadastro.CadastroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cd_cnpjLabel1
            // 
            cd_cnpjLabel1.AutoSize = true;
            cd_cnpjLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_cnpjLabel1.Location = new System.Drawing.Point(113, 174);
            cd_cnpjLabel1.Name = "cd_cnpjLabel1";
            cd_cnpjLabel1.Size = new System.Drawing.Size(71, 25);
            cd_cnpjLabel1.TabIndex = 28;
            cd_cnpjLabel1.Text = "CNPJ:";
            // 
            // cd_cnpjMaskedTextBox
            // 
            this.cd_cnpjMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbfornecedorBindingSource, "cd_cnpj", true));
            this.cd_cnpjMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_cnpjMaskedTextBox.Location = new System.Drawing.Point(287, 172);
            this.cd_cnpjMaskedTextBox.Mask = "00,000,000/0000-00";
            this.cd_cnpjMaskedTextBox.Name = "cd_cnpjMaskedTextBox";
            this.cd_cnpjMaskedTextBox.Size = new System.Drawing.Size(204, 30);
            this.cd_cnpjMaskedTextBox.TabIndex = 29;
            // 
            // cd_ieLabel1
            // 
            cd_ieLabel1.AutoSize = true;
            cd_ieLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_ieLabel1.Location = new System.Drawing.Point(113, 224);
            cd_ieLabel1.Name = "cd_ieLabel1";
            cd_ieLabel1.Size = new System.Drawing.Size(36, 25);
            cd_ieLabel1.TabIndex = 30;
            cd_ieLabel1.Text = "IE:";
            cd_ieLabel1.Click += new System.EventHandler(this.cd_ieLabel1_Click);
            // 
            // cd_ieMaskedTextBox
            // 
            this.cd_ieMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbfornecedorBindingSource, "cd_ie", true));
            this.cd_ieMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_ieMaskedTextBox.Location = new System.Drawing.Point(287, 221);
            this.cd_ieMaskedTextBox.Mask = "000,000,000,000";
            this.cd_ieMaskedTextBox.Name = "cd_ieMaskedTextBox";
            this.cd_ieMaskedTextBox.Size = new System.Drawing.Size(173, 30);
            this.cd_ieMaskedTextBox.TabIndex = 31;
            this.cd_ieMaskedTextBox.Leave += new System.EventHandler(this.cd_ieMaskedTextBox_Leave);
            // 
            // sg_estadoLabel1
            // 
            sg_estadoLabel1.AutoSize = true;
            sg_estadoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sg_estadoLabel1.Location = new System.Drawing.Point(113, 424);
            sg_estadoLabel1.Name = "sg_estadoLabel1";
            sg_estadoLabel1.Size = new System.Drawing.Size(79, 25);
            sg_estadoLabel1.TabIndex = 32;
            sg_estadoLabel1.Text = "Estado:";
            // 
            // sg_estadoComboBox
            // 
            this.sg_estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbfornecedorBindingSource, "sg_estado", true));
            this.sg_estadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sg_estadoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sg_estadoComboBox.FormattingEnabled = true;
            this.sg_estadoComboBox.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.sg_estadoComboBox.Location = new System.Drawing.Point(287, 417);
            this.sg_estadoComboBox.Name = "sg_estadoComboBox";
            this.sg_estadoComboBox.Size = new System.Drawing.Size(77, 33);
            this.sg_estadoComboBox.TabIndex = 33;
            // 
            // cd_cepLabel1
            // 
            cd_cepLabel1.AutoSize = true;
            cd_cepLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_cepLabel1.Location = new System.Drawing.Point(113, 474);
            cd_cepLabel1.Name = "cd_cepLabel1";
            cd_cepLabel1.Size = new System.Drawing.Size(59, 25);
            cd_cepLabel1.TabIndex = 34;
            cd_cepLabel1.Text = "CEP:";
            // 
            // cd_cepMaskedTextBox
            // 
            this.cd_cepMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbfornecedorBindingSource, "cd_cep", true));
            this.cd_cepMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_cepMaskedTextBox.Location = new System.Drawing.Point(287, 469);
            this.cd_cepMaskedTextBox.Mask = "00000-000";
            this.cd_cepMaskedTextBox.Name = "cd_cepMaskedTextBox";
            this.cd_cepMaskedTextBox.Size = new System.Drawing.Size(118, 30);
            this.cd_cepMaskedTextBox.TabIndex = 35;
            // 
            // nm_enderecoLabel
            // 
            nm_enderecoLabel.AutoSize = true;
            nm_enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_enderecoLabel.Location = new System.Drawing.Point(113, 274);
            nm_enderecoLabel.Name = "nm_enderecoLabel";
            nm_enderecoLabel.Size = new System.Drawing.Size(132, 25);
            nm_enderecoLabel.TabIndex = 35;
            nm_enderecoLabel.Text = "nm endereco:";
            // 
            // nm_enderecoTextBox
            // 
            this.nm_enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbfornecedorBindingSource, "nm_endereco", true));
            this.nm_enderecoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_enderecoTextBox.Location = new System.Drawing.Point(287, 270);
            this.nm_enderecoTextBox.Name = "nm_enderecoTextBox";
            this.nm_enderecoTextBox.Size = new System.Drawing.Size(100, 30);
            this.nm_enderecoTextBox.TabIndex = 36;
            // 
            // FormFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1623, 554);
            this.ControlBox = false;
            this.Controls.Add(nm_enderecoLabel);
            this.Controls.Add(this.nm_enderecoTextBox);
            this.Controls.Add(cd_cepLabel1);
            this.Controls.Add(this.cd_cepMaskedTextBox);
            this.Controls.Add(sg_estadoLabel1);
            this.Controls.Add(this.sg_estadoComboBox);
            this.Controls.Add(cd_ieLabel1);
            this.Controls.Add(this.cd_ieMaskedTextBox);
            this.Controls.Add(cd_cnpjLabel1);
            this.Controls.Add(this.cd_cnpjMaskedTextBox);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(cd_fornecedorLabel);
            this.Controls.Add(this.cd_fornecedorTextBox);
            this.Controls.Add(nm_fornecedorLabel);
            this.Controls.Add(this.nm_fornecedorTextBox);
            this.Controls.Add(nm_bairroLabel);
            this.Controls.Add(this.nm_bairroTextBox);
            this.Controls.Add(nm_cidadeLabel);
            this.Controls.Add(this.nm_cidadeTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormFornecedores";
            this.Text = "Cadastro de Fornecedores";
            this.Load += new System.EventHandler(this.FormFornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfornecedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CadastroDataSet cadastroDataSet;
        private System.Windows.Forms.BindingSource tbfornecedorBindingSource;
        private CadastroDataSetTableAdapters.tbfornecedorTableAdapter tbfornecedorTableAdapter;
        private System.Windows.Forms.TextBox cd_fornecedorTextBox;
        private System.Windows.Forms.TextBox nm_fornecedorTextBox;
        private System.Windows.Forms.TextBox nm_bairroTextBox;
        private System.Windows.Forms.TextBox nm_cidadeTextBox;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSair;
        private CadastroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MaskedTextBox cd_ieMaskedTextBox;
        private System.Windows.Forms.ComboBox sg_estadoComboBox;
        private System.Windows.Forms.MaskedTextBox cd_cepMaskedTextBox;
        private System.Windows.Forms.TextBox nm_enderecoTextBox;
        public System.Windows.Forms.MaskedTextBox cd_cnpjMaskedTextBox;
    }
}