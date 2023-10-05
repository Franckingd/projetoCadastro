namespace ProjetoCadastro
{
    partial class FormReceber
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
            System.Windows.Forms.Label cd_contaLabel;
            System.Windows.Forms.Label ds_contaLabel;
            System.Windows.Forms.Label dt_emissaoLabel;
            System.Windows.Forms.Label vl_contaLabel;
            System.Windows.Forms.Label dt_vencimentoLabel;
            System.Windows.Forms.Label dt_pagamentoLabel;
            System.Windows.Forms.Label vl_pagoLabel;
            System.Windows.Forms.Label cd_clienteLabel;
            this.cadastroDataSet = new ProjetoCadastro.CadastroDataSet();
            this.tbcontasreceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbcontasreceberTableAdapter = new ProjetoCadastro.CadastroDataSetTableAdapters.tbcontasreceberTableAdapter();
            this.cd_contaTextBox = new System.Windows.Forms.TextBox();
            this.ds_contaTextBox = new System.Windows.Forms.TextBox();
            this.dt_emissaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vl_contaTextBox = new System.Windows.Forms.TextBox();
            this.dt_vencimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dt_pagamentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vl_pagoTextBox = new System.Windows.Forms.TextBox();
            this.cd_clienteTextBox = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            cd_contaLabel = new System.Windows.Forms.Label();
            ds_contaLabel = new System.Windows.Forms.Label();
            dt_emissaoLabel = new System.Windows.Forms.Label();
            vl_contaLabel = new System.Windows.Forms.Label();
            dt_vencimentoLabel = new System.Windows.Forms.Label();
            dt_pagamentoLabel = new System.Windows.Forms.Label();
            vl_pagoLabel = new System.Windows.Forms.Label();
            cd_clienteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcontasreceberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cadastroDataSet
            // 
            this.cadastroDataSet.DataSetName = "CadastroDataSet";
            this.cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbcontasreceberBindingSource
            // 
            this.tbcontasreceberBindingSource.DataMember = "tbcontasreceber";
            this.tbcontasreceberBindingSource.DataSource = this.cadastroDataSet;
            // 
            // tbcontasreceberTableAdapter
            // 
            this.tbcontasreceberTableAdapter.ClearBeforeFill = true;
            // 
            // cd_contaLabel
            // 
            cd_contaLabel.AutoSize = true;
            cd_contaLabel.Location = new System.Drawing.Point(90, 67);
            cd_contaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cd_contaLabel.Name = "cd_contaLabel";
            cd_contaLabel.Size = new System.Drawing.Size(121, 25);
            cd_contaLabel.TabIndex = 1;
            cd_contaLabel.Text = "CÓD Conta:";
            // 
            // cd_contaTextBox
            // 
            this.cd_contaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbcontasreceberBindingSource, "cd_conta", true));
            this.cd_contaTextBox.Location = new System.Drawing.Point(235, 67);
            this.cd_contaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cd_contaTextBox.Name = "cd_contaTextBox";
            this.cd_contaTextBox.Size = new System.Drawing.Size(298, 30);
            this.cd_contaTextBox.TabIndex = 2;
            // 
            // ds_contaLabel
            // 
            ds_contaLabel.AutoSize = true;
            ds_contaLabel.Location = new System.Drawing.Point(140, 141);
            ds_contaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ds_contaLabel.Name = "ds_contaLabel";
            ds_contaLabel.Size = new System.Drawing.Size(71, 25);
            ds_contaLabel.TabIndex = 3;
            ds_contaLabel.Text = "Conta:";
            // 
            // ds_contaTextBox
            // 
            this.ds_contaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbcontasreceberBindingSource, "ds_conta", true));
            this.ds_contaTextBox.Location = new System.Drawing.Point(235, 141);
            this.ds_contaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ds_contaTextBox.Name = "ds_contaTextBox";
            this.ds_contaTextBox.Size = new System.Drawing.Size(298, 30);
            this.ds_contaTextBox.TabIndex = 4;
            // 
            // dt_emissaoLabel
            // 
            dt_emissaoLabel.AutoSize = true;
            dt_emissaoLabel.Location = new System.Drawing.Point(86, 215);
            dt_emissaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dt_emissaoLabel.Name = "dt_emissaoLabel";
            dt_emissaoLabel.Size = new System.Drawing.Size(125, 25);
            dt_emissaoLabel.TabIndex = 5;
            dt_emissaoLabel.Text = "DT Emissão:";
            // 
            // dt_emissaoDateTimePicker
            // 
            this.dt_emissaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbcontasreceberBindingSource, "dt_emissao", true));
            this.dt_emissaoDateTimePicker.Location = new System.Drawing.Point(235, 215);
            this.dt_emissaoDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dt_emissaoDateTimePicker.Name = "dt_emissaoDateTimePicker";
            this.dt_emissaoDateTimePicker.Size = new System.Drawing.Size(298, 30);
            this.dt_emissaoDateTimePicker.TabIndex = 6;
            // 
            // vl_contaLabel
            // 
            vl_contaLabel.AutoSize = true;
            vl_contaLabel.Location = new System.Drawing.Point(67, 289);
            vl_contaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            vl_contaLabel.Name = "vl_contaLabel";
            vl_contaLabel.Size = new System.Drawing.Size(144, 25);
            vl_contaLabel.TabIndex = 7;
            vl_contaLabel.Text = "Valor da conta:";
            // 
            // vl_contaTextBox
            // 
            this.vl_contaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbcontasreceberBindingSource, "vl_conta", true));
            this.vl_contaTextBox.Location = new System.Drawing.Point(235, 289);
            this.vl_contaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vl_contaTextBox.Name = "vl_contaTextBox";
            this.vl_contaTextBox.Size = new System.Drawing.Size(298, 30);
            this.vl_contaTextBox.TabIndex = 8;
            // 
            // dt_vencimentoLabel
            // 
            dt_vencimentoLabel.AutoSize = true;
            dt_vencimentoLabel.Location = new System.Drawing.Point(57, 363);
            dt_vencimentoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dt_vencimentoLabel.Name = "dt_vencimentoLabel";
            dt_vencimentoLabel.Size = new System.Drawing.Size(154, 25);
            dt_vencimentoLabel.TabIndex = 9;
            dt_vencimentoLabel.Text = "DT Vencimento:";
            // 
            // dt_vencimentoDateTimePicker
            // 
            this.dt_vencimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbcontasreceberBindingSource, "dt_vencimento", true));
            this.dt_vencimentoDateTimePicker.Location = new System.Drawing.Point(235, 363);
            this.dt_vencimentoDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dt_vencimentoDateTimePicker.Name = "dt_vencimentoDateTimePicker";
            this.dt_vencimentoDateTimePicker.Size = new System.Drawing.Size(298, 30);
            this.dt_vencimentoDateTimePicker.TabIndex = 10;
            // 
            // dt_pagamentoLabel
            // 
            dt_pagamentoLabel.AutoSize = true;
            dt_pagamentoLabel.Location = new System.Drawing.Point(61, 437);
            dt_pagamentoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dt_pagamentoLabel.Name = "dt_pagamentoLabel";
            dt_pagamentoLabel.Size = new System.Drawing.Size(150, 25);
            dt_pagamentoLabel.TabIndex = 11;
            dt_pagamentoLabel.Text = "DT Pagamento:";
            // 
            // dt_pagamentoDateTimePicker
            // 
            this.dt_pagamentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbcontasreceberBindingSource, "dt_pagamento", true));
            this.dt_pagamentoDateTimePicker.Location = new System.Drawing.Point(235, 437);
            this.dt_pagamentoDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dt_pagamentoDateTimePicker.Name = "dt_pagamentoDateTimePicker";
            this.dt_pagamentoDateTimePicker.Size = new System.Drawing.Size(298, 30);
            this.dt_pagamentoDateTimePicker.TabIndex = 12;
            // 
            // vl_pagoLabel
            // 
            vl_pagoLabel.AutoSize = true;
            vl_pagoLabel.Location = new System.Drawing.Point(96, 511);
            vl_pagoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            vl_pagoLabel.Name = "vl_pagoLabel";
            vl_pagoLabel.Size = new System.Drawing.Size(115, 25);
            vl_pagoLabel.TabIndex = 13;
            vl_pagoLabel.Text = "Valor Pago:";
            // 
            // vl_pagoTextBox
            // 
            this.vl_pagoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbcontasreceberBindingSource, "vl_pago", true));
            this.vl_pagoTextBox.Location = new System.Drawing.Point(235, 511);
            this.vl_pagoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vl_pagoTextBox.Name = "vl_pagoTextBox";
            this.vl_pagoTextBox.Size = new System.Drawing.Size(298, 30);
            this.vl_pagoTextBox.TabIndex = 14;
            // 
            // cd_clienteLabel
            // 
            cd_clienteLabel.AutoSize = true;
            cd_clienteLabel.Location = new System.Drawing.Point(82, 585);
            cd_clienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cd_clienteLabel.Name = "cd_clienteLabel";
            cd_clienteLabel.Size = new System.Drawing.Size(129, 25);
            cd_clienteLabel.TabIndex = 15;
            cd_clienteLabel.Text = "CÓD Cliente:";
            // 
            // cd_clienteTextBox
            // 
            this.cd_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbcontasreceberBindingSource, "cd_cliente", true));
            this.cd_clienteTextBox.Location = new System.Drawing.Point(235, 585);
            this.cd_clienteTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cd_clienteTextBox.Name = "cd_clienteTextBox";
            this.cd_clienteTextBox.Size = new System.Drawing.Size(298, 30);
            this.cd_clienteTextBox.TabIndex = 16;
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(629, 63);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 39);
            this.btnSair.TabIndex = 17;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(cd_contaLabel);
            this.Controls.Add(this.cd_contaTextBox);
            this.Controls.Add(ds_contaLabel);
            this.Controls.Add(this.ds_contaTextBox);
            this.Controls.Add(dt_emissaoLabel);
            this.Controls.Add(this.dt_emissaoDateTimePicker);
            this.Controls.Add(vl_contaLabel);
            this.Controls.Add(this.vl_contaTextBox);
            this.Controls.Add(dt_vencimentoLabel);
            this.Controls.Add(this.dt_vencimentoDateTimePicker);
            this.Controls.Add(dt_pagamentoLabel);
            this.Controls.Add(this.dt_pagamentoDateTimePicker);
            this.Controls.Add(vl_pagoLabel);
            this.Controls.Add(this.vl_pagoTextBox);
            this.Controls.Add(cd_clienteLabel);
            this.Controls.Add(this.cd_clienteTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas à Receber";
            this.Load += new System.EventHandler(this.FormReceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcontasreceberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CadastroDataSet cadastroDataSet;
        private System.Windows.Forms.BindingSource tbcontasreceberBindingSource;
        private CadastroDataSetTableAdapters.tbcontasreceberTableAdapter tbcontasreceberTableAdapter;
        private System.Windows.Forms.TextBox cd_contaTextBox;
        private System.Windows.Forms.TextBox ds_contaTextBox;
        private System.Windows.Forms.DateTimePicker dt_emissaoDateTimePicker;
        private System.Windows.Forms.TextBox vl_contaTextBox;
        private System.Windows.Forms.DateTimePicker dt_vencimentoDateTimePicker;
        private System.Windows.Forms.DateTimePicker dt_pagamentoDateTimePicker;
        private System.Windows.Forms.TextBox vl_pagoTextBox;
        private System.Windows.Forms.TextBox cd_clienteTextBox;
        private System.Windows.Forms.Button btnSair;
    }
}