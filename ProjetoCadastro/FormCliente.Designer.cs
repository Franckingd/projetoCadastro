namespace ProjetoCadastro
{
    partial class FormCliente
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
            System.Windows.Forms.Label cd_clienteLabel;
            System.Windows.Forms.Label nm_clienteLabel;
            System.Windows.Forms.Label nm_enderecoLabel;
            System.Windows.Forms.Label cd_numeroLabel;
            System.Windows.Forms.Label nm_bairroLabel;
            System.Windows.Forms.Label nm_cidadeLabel;
            System.Windows.Forms.Label sg_estadoLabel1;
            System.Windows.Forms.Label cd_cepLabel1;
            System.Windows.Forms.Label cd_telefoneLabel1;
            System.Windows.Forms.Label cd_cpfLabel1;
            System.Windows.Forms.Label cd_rgLabel1;
            this.cadastroDataSet = new ProjetoCadastro.CadastroDataSet();
            this.tbclienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbclienteTableAdapter = new ProjetoCadastro.CadastroDataSetTableAdapters.tbclienteTableAdapter();
            this.cd_clienteTextBox = new System.Windows.Forms.TextBox();
            this.nm_clienteTextBox = new System.Windows.Forms.TextBox();
            this.nm_enderecoTextBox = new System.Windows.Forms.TextBox();
            this.cd_numeroTextBox = new System.Windows.Forms.TextBox();
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
            this.sg_estadoComboBox = new System.Windows.Forms.ComboBox();
            this.cd_cepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cd_telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cd_cpfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cd_rgMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            cd_clienteLabel = new System.Windows.Forms.Label();
            nm_clienteLabel = new System.Windows.Forms.Label();
            nm_enderecoLabel = new System.Windows.Forms.Label();
            cd_numeroLabel = new System.Windows.Forms.Label();
            nm_bairroLabel = new System.Windows.Forms.Label();
            nm_cidadeLabel = new System.Windows.Forms.Label();
            sg_estadoLabel1 = new System.Windows.Forms.Label();
            cd_cepLabel1 = new System.Windows.Forms.Label();
            cd_telefoneLabel1 = new System.Windows.Forms.Label();
            cd_cpfLabel1 = new System.Windows.Forms.Label();
            cd_rgLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_clienteLabel
            // 
            cd_clienteLabel.AutoSize = true;
            cd_clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_clienteLabel.Location = new System.Drawing.Point(59, 94);
            cd_clienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cd_clienteLabel.Name = "cd_clienteLabel";
            cd_clienteLabel.Size = new System.Drawing.Size(81, 25);
            cd_clienteLabel.TabIndex = 1;
            cd_clienteLabel.Text = "Código:";
            // 
            // nm_clienteLabel
            // 
            nm_clienteLabel.AutoSize = true;
            nm_clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_clienteLabel.Location = new System.Drawing.Point(59, 148);
            nm_clienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nm_clienteLabel.Name = "nm_clienteLabel";
            nm_clienteLabel.Size = new System.Drawing.Size(70, 25);
            nm_clienteLabel.TabIndex = 3;
            nm_clienteLabel.Text = "Nome:";
            // 
            // nm_enderecoLabel
            // 
            nm_enderecoLabel.AutoSize = true;
            nm_enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_enderecoLabel.Location = new System.Drawing.Point(59, 202);
            nm_enderecoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nm_enderecoLabel.Name = "nm_enderecoLabel";
            nm_enderecoLabel.Size = new System.Drawing.Size(102, 25);
            nm_enderecoLabel.TabIndex = 5;
            nm_enderecoLabel.Text = "Endereco:";
            // 
            // cd_numeroLabel
            // 
            cd_numeroLabel.AutoSize = true;
            cd_numeroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_numeroLabel.Location = new System.Drawing.Point(59, 256);
            cd_numeroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cd_numeroLabel.Name = "cd_numeroLabel";
            cd_numeroLabel.Size = new System.Drawing.Size(87, 25);
            cd_numeroLabel.TabIndex = 7;
            cd_numeroLabel.Text = "Número:";
            // 
            // nm_bairroLabel
            // 
            nm_bairroLabel.AutoSize = true;
            nm_bairroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_bairroLabel.Location = new System.Drawing.Point(59, 310);
            nm_bairroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nm_bairroLabel.Name = "nm_bairroLabel";
            nm_bairroLabel.Size = new System.Drawing.Size(69, 25);
            nm_bairroLabel.TabIndex = 9;
            nm_bairroLabel.Text = "Bairro:";
            // 
            // nm_cidadeLabel
            // 
            nm_cidadeLabel.AutoSize = true;
            nm_cidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_cidadeLabel.Location = new System.Drawing.Point(59, 364);
            nm_cidadeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nm_cidadeLabel.Name = "nm_cidadeLabel";
            nm_cidadeLabel.Size = new System.Drawing.Size(81, 25);
            nm_cidadeLabel.TabIndex = 11;
            nm_cidadeLabel.Text = "Cidade:";
            // 
            // cadastroDataSet
            // 
            this.cadastroDataSet.DataSetName = "CadastroDataSet";
            this.cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbclienteBindingSource
            // 
            this.tbclienteBindingSource.DataMember = "tbcliente";
            this.tbclienteBindingSource.DataSource = this.cadastroDataSet;
            // 
            // tbclienteTableAdapter
            // 
            this.tbclienteTableAdapter.ClearBeforeFill = true;
            // 
            // cd_clienteTextBox
            // 
            this.cd_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbclienteBindingSource, "cd_cliente", true));
            this.cd_clienteTextBox.Enabled = false;
            this.cd_clienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_clienteTextBox.Location = new System.Drawing.Point(212, 94);
            this.cd_clienteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cd_clienteTextBox.Name = "cd_clienteTextBox";
            this.cd_clienteTextBox.Size = new System.Drawing.Size(132, 30);
            this.cd_clienteTextBox.TabIndex = 2;
            // 
            // nm_clienteTextBox
            // 
            this.nm_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbclienteBindingSource, "nm_cliente", true));
            this.nm_clienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_clienteTextBox.Location = new System.Drawing.Point(212, 148);
            this.nm_clienteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nm_clienteTextBox.MaxLength = 50;
            this.nm_clienteTextBox.Name = "nm_clienteTextBox";
            this.nm_clienteTextBox.Size = new System.Drawing.Size(636, 30);
            this.nm_clienteTextBox.TabIndex = 4;
            this.nm_clienteTextBox.Enter += new System.EventHandler(this.nm_clienteTextBox_Enter);
            this.nm_clienteTextBox.Leave += new System.EventHandler(this.nm_clienteTextBox_Leave);
            // 
            // nm_enderecoTextBox
            // 
            this.nm_enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbclienteBindingSource, "nm_endereco", true));
            this.nm_enderecoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_enderecoTextBox.Location = new System.Drawing.Point(212, 202);
            this.nm_enderecoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nm_enderecoTextBox.MaxLength = 50;
            this.nm_enderecoTextBox.Name = "nm_enderecoTextBox";
            this.nm_enderecoTextBox.Size = new System.Drawing.Size(636, 30);
            this.nm_enderecoTextBox.TabIndex = 6;
            this.nm_enderecoTextBox.Enter += new System.EventHandler(this.nm_clienteTextBox_Enter);
            this.nm_enderecoTextBox.Leave += new System.EventHandler(this.nm_clienteTextBox_Leave);
            // 
            // cd_numeroTextBox
            // 
            this.cd_numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbclienteBindingSource, "cd_numero", true));
            this.cd_numeroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_numeroTextBox.Location = new System.Drawing.Point(212, 256);
            this.cd_numeroTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cd_numeroTextBox.MaxLength = 10;
            this.cd_numeroTextBox.Name = "cd_numeroTextBox";
            this.cd_numeroTextBox.Size = new System.Drawing.Size(47, 30);
            this.cd_numeroTextBox.TabIndex = 8;
            this.cd_numeroTextBox.TextChanged += new System.EventHandler(this.cd_numeroTextBox_TextChanged);
            this.cd_numeroTextBox.Enter += new System.EventHandler(this.nm_clienteTextBox_Enter);
            this.cd_numeroTextBox.Leave += new System.EventHandler(this.nm_clienteTextBox_Leave);
            // 
            // nm_bairroTextBox
            // 
            this.nm_bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbclienteBindingSource, "nm_bairro", true));
            this.nm_bairroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_bairroTextBox.Location = new System.Drawing.Point(212, 310);
            this.nm_bairroTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nm_bairroTextBox.MaxLength = 30;
            this.nm_bairroTextBox.Name = "nm_bairroTextBox";
            this.nm_bairroTextBox.Size = new System.Drawing.Size(132, 30);
            this.nm_bairroTextBox.TabIndex = 10;
            this.nm_bairroTextBox.Enter += new System.EventHandler(this.nm_clienteTextBox_Enter);
            this.nm_bairroTextBox.Leave += new System.EventHandler(this.nm_clienteTextBox_Leave);
            // 
            // nm_cidadeTextBox
            // 
            this.nm_cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbclienteBindingSource, "nm_cidade", true));
            this.nm_cidadeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_cidadeTextBox.Location = new System.Drawing.Point(212, 364);
            this.nm_cidadeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nm_cidadeTextBox.MaxLength = 30;
            this.nm_cidadeTextBox.Name = "nm_cidadeTextBox";
            this.nm_cidadeTextBox.Size = new System.Drawing.Size(132, 30);
            this.nm_cidadeTextBox.TabIndex = 12;
            this.nm_cidadeTextBox.TextChanged += new System.EventHandler(this.nm_cidadeTextBox_TextChanged);
            this.nm_cidadeTextBox.Enter += new System.EventHandler(this.nm_clienteTextBox_Enter);
            this.nm_cidadeTextBox.Leave += new System.EventHandler(this.nm_clienteTextBox_Leave);
            // 
            // btnAnterior
            // 
            this.btnAnterior.AutoSize = true;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(906, 102);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(109, 47);
            this.btnAnterior.TabIndex = 23;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.AutoSize = true;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(906, 222);
            this.btnProximo.Margin = new System.Windows.Forms.Padding(4);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(109, 47);
            this.btnProximo.TabIndex = 24;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = true;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(906, 341);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(109, 47);
            this.btnNovo.TabIndex = 25;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoSize = true;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(906, 460);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(109, 47);
            this.btnAlterar.TabIndex = 26;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.Button4_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(906, 580);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(109, 47);
            this.btnExcluir.TabIndex = 27;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(1106, 102);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(109, 47);
            this.btnSalvar.TabIndex = 28;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            this.btnSalvar.Enter += new System.EventHandler(this.btnSalvar_Enter);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1106, 222);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 47);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoSize = true;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(1106, 341);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(119, 47);
            this.btnPesquisar.TabIndex = 30;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(1106, 460);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(109, 47);
            this.btnImprimir.TabIndex = 31;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(1106, 580);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(111, 47);
            this.btnSair.TabIndex = 32;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.Button10_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbclienteTableAdapter = this.tbclienteTableAdapter;
            this.tableAdapterManager.tbcontaspagarTableAdapter = null;
            this.tableAdapterManager.tbcontasreceberTableAdapter = null;
            this.tableAdapterManager.tbfornecedorTableAdapter = null;
            this.tableAdapterManager.tbusuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoCadastro.CadastroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sg_estadoLabel1
            // 
            sg_estadoLabel1.AutoSize = true;
            sg_estadoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sg_estadoLabel1.Location = new System.Drawing.Point(59, 418);
            sg_estadoLabel1.Name = "sg_estadoLabel1";
            sg_estadoLabel1.Size = new System.Drawing.Size(103, 25);
            sg_estadoLabel1.TabIndex = 32;
            sg_estadoLabel1.Text = "sg estado:";
            // 
            // sg_estadoComboBox
            // 
            this.sg_estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbclienteBindingSource, "sg_estado", true));
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
            this.sg_estadoComboBox.Location = new System.Drawing.Point(212, 418);
            this.sg_estadoComboBox.Name = "sg_estadoComboBox";
            this.sg_estadoComboBox.Size = new System.Drawing.Size(121, 33);
            this.sg_estadoComboBox.TabIndex = 33;
            // 
            // cd_cepLabel1
            // 
            cd_cepLabel1.AutoSize = true;
            cd_cepLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_cepLabel1.Location = new System.Drawing.Point(59, 472);
            cd_cepLabel1.Name = "cd_cepLabel1";
            cd_cepLabel1.Size = new System.Drawing.Size(76, 25);
            cd_cepLabel1.TabIndex = 34;
            cd_cepLabel1.Text = "cd cep:";
            // 
            // cd_cepMaskedTextBox
            // 
            this.cd_cepMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbclienteBindingSource, "cd_cep", true));
            this.cd_cepMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_cepMaskedTextBox.Location = new System.Drawing.Point(212, 475);
            this.cd_cepMaskedTextBox.Mask = "00000-000";
            this.cd_cepMaskedTextBox.Name = "cd_cepMaskedTextBox";
            this.cd_cepMaskedTextBox.Size = new System.Drawing.Size(132, 30);
            this.cd_cepMaskedTextBox.TabIndex = 35;
            // 
            // cd_telefoneLabel1
            // 
            cd_telefoneLabel1.AutoSize = true;
            cd_telefoneLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_telefoneLabel1.Location = new System.Drawing.Point(59, 526);
            cd_telefoneLabel1.Name = "cd_telefoneLabel1";
            cd_telefoneLabel1.Size = new System.Drawing.Size(113, 25);
            cd_telefoneLabel1.TabIndex = 36;
            cd_telefoneLabel1.Text = "cd telefone:";
            // 
            // cd_telefoneMaskedTextBox
            // 
            this.cd_telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbclienteBindingSource, "cd_telefone", true));
            this.cd_telefoneMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_telefoneMaskedTextBox.Location = new System.Drawing.Point(212, 529);
            this.cd_telefoneMaskedTextBox.Mask = "(00) 00000-0000";
            this.cd_telefoneMaskedTextBox.Name = "cd_telefoneMaskedTextBox";
            this.cd_telefoneMaskedTextBox.Size = new System.Drawing.Size(171, 30);
            this.cd_telefoneMaskedTextBox.TabIndex = 37;
            // 
            // cd_cpfLabel1
            // 
            cd_cpfLabel1.AutoSize = true;
            cd_cpfLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_cpfLabel1.Location = new System.Drawing.Point(59, 580);
            cd_cpfLabel1.Name = "cd_cpfLabel1";
            cd_cpfLabel1.Size = new System.Drawing.Size(70, 25);
            cd_cpfLabel1.TabIndex = 38;
            cd_cpfLabel1.Text = "cd cpf:";
            // 
            // cd_cpfMaskedTextBox
            // 
            this.cd_cpfMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbclienteBindingSource, "cd_cpf", true));
            this.cd_cpfMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_cpfMaskedTextBox.Location = new System.Drawing.Point(212, 583);
            this.cd_cpfMaskedTextBox.Mask = "000,000,000-00";
            this.cd_cpfMaskedTextBox.Name = "cd_cpfMaskedTextBox";
            this.cd_cpfMaskedTextBox.Size = new System.Drawing.Size(171, 30);
            this.cd_cpfMaskedTextBox.TabIndex = 39;
            // 
            // cd_rgLabel1
            // 
            cd_rgLabel1.AutoSize = true;
            cd_rgLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_rgLabel1.Location = new System.Drawing.Point(59, 634);
            cd_rgLabel1.Name = "cd_rgLabel1";
            cd_rgLabel1.Size = new System.Drawing.Size(61, 25);
            cd_rgLabel1.TabIndex = 40;
            cd_rgLabel1.Text = "cd rg:";
            // 
            // cd_rgMaskedTextBox
            // 
            this.cd_rgMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbclienteBindingSource, "cd_rg", true));
            this.cd_rgMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_rgMaskedTextBox.Location = new System.Drawing.Point(212, 637);
            this.cd_rgMaskedTextBox.Mask = "00,000,000-0";
            this.cd_rgMaskedTextBox.Name = "cd_rgMaskedTextBox";
            this.cd_rgMaskedTextBox.Size = new System.Drawing.Size(149, 30);
            this.cd_rgMaskedTextBox.TabIndex = 41;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 697);
            this.ControlBox = false;
            this.Controls.Add(cd_rgLabel1);
            this.Controls.Add(this.cd_rgMaskedTextBox);
            this.Controls.Add(cd_cpfLabel1);
            this.Controls.Add(this.cd_cpfMaskedTextBox);
            this.Controls.Add(cd_telefoneLabel1);
            this.Controls.Add(this.cd_telefoneMaskedTextBox);
            this.Controls.Add(cd_cepLabel1);
            this.Controls.Add(this.cd_cepMaskedTextBox);
            this.Controls.Add(sg_estadoLabel1);
            this.Controls.Add(this.sg_estadoComboBox);
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
            this.Controls.Add(cd_clienteLabel);
            this.Controls.Add(this.cd_clienteTextBox);
            this.Controls.Add(nm_clienteLabel);
            this.Controls.Add(this.nm_clienteTextBox);
            this.Controls.Add(nm_enderecoLabel);
            this.Controls.Add(this.nm_enderecoTextBox);
            this.Controls.Add(cd_numeroLabel);
            this.Controls.Add(this.cd_numeroTextBox);
            this.Controls.Add(nm_bairroLabel);
            this.Controls.Add(this.nm_bairroTextBox);
            this.Controls.Add(nm_cidadeLabel);
            this.Controls.Add(this.nm_cidadeTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CadastroDataSet cadastroDataSet;
        private System.Windows.Forms.BindingSource tbclienteBindingSource;
        private CadastroDataSetTableAdapters.tbclienteTableAdapter tbclienteTableAdapter;
        private System.Windows.Forms.TextBox cd_clienteTextBox;
        private System.Windows.Forms.TextBox nm_clienteTextBox;
        private System.Windows.Forms.TextBox nm_enderecoTextBox;
        private System.Windows.Forms.TextBox cd_numeroTextBox;
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
        private System.Windows.Forms.ComboBox sg_estadoComboBox;
        private System.Windows.Forms.MaskedTextBox cd_cepMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cd_telefoneMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cd_cpfMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cd_rgMaskedTextBox;
    }
}