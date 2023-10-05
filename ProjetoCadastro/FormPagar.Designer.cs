namespace ProjetoCadastro
{
    partial class FormPagar
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
            System.Windows.Forms.Label cd_fornecedorLabel;
            this.cadastroDataSet = new ProjetoCadastro.CadastroDataSet();
            this.tbcontaspagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbcontaspagarTableAdapter = new ProjetoCadastro.CadastroDataSetTableAdapters.tbcontaspagarTableAdapter();
            this.cd_contaTextBox = new System.Windows.Forms.TextBox();
            this.ds_contaTextBox = new System.Windows.Forms.TextBox();
            this.cd_fornecedorTextBox = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            cd_contaLabel = new System.Windows.Forms.Label();
            ds_contaLabel = new System.Windows.Forms.Label();
            cd_fornecedorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcontaspagarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_contaLabel
            // 
            cd_contaLabel.AutoSize = true;
            cd_contaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_contaLabel.Location = new System.Drawing.Point(114, 49);
            cd_contaLabel.Name = "cd_contaLabel";
            cd_contaLabel.Size = new System.Drawing.Size(121, 25);
            cd_contaLabel.TabIndex = 1;
            cd_contaLabel.Text = "CÓD Conta:";
            cd_contaLabel.Click += new System.EventHandler(this.cd_contaLabel_Click);
            // 
            // ds_contaLabel
            // 
            ds_contaLabel.AutoSize = true;
            ds_contaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ds_contaLabel.Location = new System.Drawing.Point(164, 134);
            ds_contaLabel.Name = "ds_contaLabel";
            ds_contaLabel.Size = new System.Drawing.Size(71, 25);
            ds_contaLabel.TabIndex = 3;
            ds_contaLabel.Text = "Conta:";
            ds_contaLabel.Click += new System.EventHandler(this.ds_contaLabel_Click);
            // 
            // cd_fornecedorLabel
            // 
            cd_fornecedorLabel.AutoSize = true;
            cd_fornecedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_fornecedorLabel.Location = new System.Drawing.Point(67, 219);
            cd_fornecedorLabel.Name = "cd_fornecedorLabel";
            cd_fornecedorLabel.Size = new System.Drawing.Size(168, 25);
            cd_fornecedorLabel.TabIndex = 5;
            cd_fornecedorLabel.Text = "CÓD Fornecedor:";
            // 
            // cadastroDataSet
            // 
            this.cadastroDataSet.DataSetName = "CadastroDataSet";
            this.cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbcontaspagarBindingSource
            // 
            this.tbcontaspagarBindingSource.DataMember = "tbcontaspagar";
            this.tbcontaspagarBindingSource.DataSource = this.cadastroDataSet;
            // 
            // tbcontaspagarTableAdapter
            // 
            this.tbcontaspagarTableAdapter.ClearBeforeFill = true;
            // 
            // cd_contaTextBox
            // 
            this.cd_contaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbcontaspagarBindingSource, "cd_conta", true));
            this.cd_contaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_contaTextBox.Location = new System.Drawing.Point(280, 46);
            this.cd_contaTextBox.Name = "cd_contaTextBox";
            this.cd_contaTextBox.Size = new System.Drawing.Size(100, 30);
            this.cd_contaTextBox.TabIndex = 2;
            // 
            // ds_contaTextBox
            // 
            this.ds_contaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbcontaspagarBindingSource, "ds_conta", true));
            this.ds_contaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ds_contaTextBox.Location = new System.Drawing.Point(280, 131);
            this.ds_contaTextBox.Name = "ds_contaTextBox";
            this.ds_contaTextBox.Size = new System.Drawing.Size(100, 30);
            this.ds_contaTextBox.TabIndex = 4;
            // 
            // cd_fornecedorTextBox
            // 
            this.cd_fornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbcontaspagarBindingSource, "cd_fornecedor", true));
            this.cd_fornecedorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_fornecedorTextBox.Location = new System.Drawing.Point(280, 216);
            this.cd_fornecedorTextBox.Name = "cd_fornecedorTextBox";
            this.cd_fornecedorTextBox.Size = new System.Drawing.Size(100, 30);
            this.cd_fornecedorTextBox.TabIndex = 6;
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(486, 49);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 39);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(cd_contaLabel);
            this.Controls.Add(this.cd_contaTextBox);
            this.Controls.Add(ds_contaLabel);
            this.Controls.Add(this.ds_contaTextBox);
            this.Controls.Add(cd_fornecedorLabel);
            this.Controls.Add(this.cd_fornecedorTextBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conta à Pagar";
            this.Load += new System.EventHandler(this.FormPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcontaspagarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CadastroDataSet cadastroDataSet;
        private System.Windows.Forms.BindingSource tbcontaspagarBindingSource;
        private CadastroDataSetTableAdapters.tbcontaspagarTableAdapter tbcontaspagarTableAdapter;
        private System.Windows.Forms.TextBox cd_contaTextBox;
        private System.Windows.Forms.TextBox ds_contaTextBox;
        private System.Windows.Forms.TextBox cd_fornecedorTextBox;
        private System.Windows.Forms.Button btnSair;
    }
}