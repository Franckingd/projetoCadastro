namespace ProjetoCadastro
{
    partial class frmPesquisaUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cadastroDataSet = new ProjetoCadastro.CadastroDataSet();
            this.tbusuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbusuarioTableAdapter = new ProjetoCadastro.CadastroDataSetTableAdapters.tbusuarioTableAdapter();
            this.tbusuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableAdapterManager1 = new ProjetoCadastro.CadastroDataSetTableAdapters.TableAdapterManager();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbusuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbusuarioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(148, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(727, 30);
            this.txtNome.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoSize = true;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(923, 24);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(109, 38);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cadastroDataSet
            // 
            this.cadastroDataSet.DataSetName = "CadastroDataSet";
            this.cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbusuarioBindingSource
            // 
            this.tbusuarioBindingSource.DataMember = "tbusuario";
            this.tbusuarioBindingSource.DataSource = this.cadastroDataSet;
            // 
            // tbusuarioTableAdapter
            // 
            this.tbusuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tbusuarioDataGridView
            // 
            this.tbusuarioDataGridView.AllowUserToAddRows = false;
            this.tbusuarioDataGridView.AllowUserToDeleteRows = false;
            this.tbusuarioDataGridView.AutoGenerateColumns = false;
            this.tbusuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbusuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tbusuarioDataGridView.DataSource = this.tbusuarioBindingSource;
            this.tbusuarioDataGridView.Location = new System.Drawing.Point(129, 133);
            this.tbusuarioDataGridView.Name = "tbusuarioDataGridView";
            this.tbusuarioDataGridView.ReadOnly = true;
            this.tbusuarioDataGridView.RowHeadersWidth = 51;
            this.tbusuarioDataGridView.RowTemplate.Height = 24;
            this.tbusuarioDataGridView.Size = new System.Drawing.Size(765, 220);
            this.tbusuarioDataGridView.TabIndex = 4;
            this.tbusuarioDataGridView.DoubleClick += new System.EventHandler(this.tbusuarioDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cd_usuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nm_usuario";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 600;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tbclienteTableAdapter = null;
            this.tableAdapterManager1.tbcontaspagarTableAdapter = null;
            this.tableAdapterManager1.tbcontasreceberTableAdapter = null;
            this.tableAdapterManager1.tbfornecedorTableAdapter = null;
            this.tableAdapterManager1.tbusuarioTableAdapter = this.tbusuarioTableAdapter;
            this.tableAdapterManager1.UpdateOrder = ProjetoCadastro.CadastroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(475, 436);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(109, 38);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmPesquisaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 541);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.tbusuarioDataGridView);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "frmPesquisaUsuario";
            this.Text = "Pesquisar usuário";
            this.Load += new System.EventHandler(this.frmPesquisaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbusuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbusuarioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnPesquisar;
        private CadastroDataSet cadastroDataSet;
        private System.Windows.Forms.BindingSource tbusuarioBindingSource;
        private CadastroDataSetTableAdapters.tbusuarioTableAdapter tbusuarioTableAdapter;
        private System.Windows.Forms.DataGridView tbusuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private CadastroDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button btnSair;
    }
}