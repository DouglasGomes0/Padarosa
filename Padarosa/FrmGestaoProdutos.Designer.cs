namespace Padarosa
{
    partial class FrmGestaoProdutos
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbAdicionarProduto = new System.Windows.Forms.GroupBox();
            this.cbmAdicionarCategoria = new System.Windows.Forms.ComboBox();
            this.txbCadastroNome = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblCadastroCategoria = new System.Windows.Forms.Label();
            this.lblCadastroPreco = new System.Windows.Forms.Label();
            this.lblCadastroNome = new System.Windows.Forms.Label();
            this.grbEditarProduto = new System.Windows.Forms.GroupBox();
            this.cmbEditarCategoria = new System.Windows.Forms.ComboBox();
            this.txbEditarPreco = new System.Windows.Forms.TextBox();
            this.txbEditarNome = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblEditarCategoria = new System.Windows.Forms.Label();
            this.lblEditarPreco = new System.Windows.Forms.Label();
            this.lblEditarNome = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblMensagemApagar = new System.Windows.Forms.Label();
            this.txbCadastroPreco = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbAdicionarProduto.SuspendLayout();
            this.grbEditarProduto.SuspendLayout();
            this.grbApagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(214, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(237, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestão de Produtos";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(12, 54);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(634, 315);
            this.dgvProdutos.TabIndex = 1;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // grbAdicionarProduto
            // 
            this.grbAdicionarProduto.Controls.Add(this.txbCadastroPreco);
            this.grbAdicionarProduto.Controls.Add(this.cbmAdicionarCategoria);
            this.grbAdicionarProduto.Controls.Add(this.txbCadastroNome);
            this.grbAdicionarProduto.Controls.Add(this.btnAdicionar);
            this.grbAdicionarProduto.Controls.Add(this.lblCadastroCategoria);
            this.grbAdicionarProduto.Controls.Add(this.lblCadastroPreco);
            this.grbAdicionarProduto.Controls.Add(this.lblCadastroNome);
            this.grbAdicionarProduto.Location = new System.Drawing.Point(12, 375);
            this.grbAdicionarProduto.Name = "grbAdicionarProduto";
            this.grbAdicionarProduto.Size = new System.Drawing.Size(314, 187);
            this.grbAdicionarProduto.TabIndex = 2;
            this.grbAdicionarProduto.TabStop = false;
            this.grbAdicionarProduto.Text = "adicionar produtos";
            // 
            // cbmAdicionarCategoria
            // 
            this.cbmAdicionarCategoria.FormattingEnabled = true;
            this.cbmAdicionarCategoria.Location = new System.Drawing.Point(101, 88);
            this.cbmAdicionarCategoria.Name = "cbmAdicionarCategoria";
            this.cbmAdicionarCategoria.Size = new System.Drawing.Size(206, 21);
            this.cbmAdicionarCategoria.TabIndex = 6;
            // 
            // txbCadastroNome
            // 
            this.txbCadastroNome.Location = new System.Drawing.Point(101, 34);
            this.txbCadastroNome.Name = "txbCadastroNome";
            this.txbCadastroNome.Size = new System.Drawing.Size(206, 20);
            this.txbCadastroNome.TabIndex = 4;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdicionar.Location = new System.Drawing.Point(27, 128);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(260, 44);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblCadastroCategoria
            // 
            this.lblCadastroCategoria.AutoSize = true;
            this.lblCadastroCategoria.Location = new System.Drawing.Point(13, 89);
            this.lblCadastroCategoria.Name = "lblCadastroCategoria";
            this.lblCadastroCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCadastroCategoria.TabIndex = 2;
            this.lblCadastroCategoria.Text = "Categoria:";
            // 
            // lblCadastroPreco
            // 
            this.lblCadastroPreco.AutoSize = true;
            this.lblCadastroPreco.Location = new System.Drawing.Point(12, 62);
            this.lblCadastroPreco.Name = "lblCadastroPreco";
            this.lblCadastroPreco.Size = new System.Drawing.Size(38, 13);
            this.lblCadastroPreco.TabIndex = 1;
            this.lblCadastroPreco.Text = "Preço:";
            // 
            // lblCadastroNome
            // 
            this.lblCadastroNome.AutoSize = true;
            this.lblCadastroNome.Location = new System.Drawing.Point(11, 35);
            this.lblCadastroNome.Name = "lblCadastroNome";
            this.lblCadastroNome.Size = new System.Drawing.Size(38, 13);
            this.lblCadastroNome.TabIndex = 0;
            this.lblCadastroNome.Text = "Nome:";
            // 
            // grbEditarProduto
            // 
            this.grbEditarProduto.Controls.Add(this.cmbEditarCategoria);
            this.grbEditarProduto.Controls.Add(this.txbEditarPreco);
            this.grbEditarProduto.Controls.Add(this.txbEditarNome);
            this.grbEditarProduto.Controls.Add(this.btnEditar);
            this.grbEditarProduto.Controls.Add(this.lblEditarCategoria);
            this.grbEditarProduto.Controls.Add(this.lblEditarPreco);
            this.grbEditarProduto.Controls.Add(this.lblEditarNome);
            this.grbEditarProduto.Enabled = false;
            this.grbEditarProduto.Location = new System.Drawing.Point(332, 375);
            this.grbEditarProduto.Name = "grbEditarProduto";
            this.grbEditarProduto.Size = new System.Drawing.Size(314, 187);
            this.grbEditarProduto.TabIndex = 3;
            this.grbEditarProduto.TabStop = false;
            this.grbEditarProduto.Text = "Edição de produtos";
            // 
            // cmbEditarCategoria
            // 
            this.cmbEditarCategoria.FormattingEnabled = true;
            this.cmbEditarCategoria.Location = new System.Drawing.Point(101, 87);
            this.cmbEditarCategoria.Name = "cmbEditarCategoria";
            this.cmbEditarCategoria.Size = new System.Drawing.Size(206, 21);
            this.cmbEditarCategoria.TabIndex = 6;
            // 
            // txbEditarPreco
            // 
            this.txbEditarPreco.Location = new System.Drawing.Point(101, 63);
            this.txbEditarPreco.Name = "txbEditarPreco";
            this.txbEditarPreco.Size = new System.Drawing.Size(206, 20);
            this.txbEditarPreco.TabIndex = 5;
            // 
            // txbEditarNome
            // 
            this.txbEditarNome.Location = new System.Drawing.Point(101, 34);
            this.txbEditarNome.Name = "txbEditarNome";
            this.txbEditarNome.Size = new System.Drawing.Size(206, 20);
            this.txbEditarNome.TabIndex = 4;
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEditar.Location = new System.Drawing.Point(27, 128);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(260, 44);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblEditarCategoria
            // 
            this.lblEditarCategoria.AutoSize = true;
            this.lblEditarCategoria.Location = new System.Drawing.Point(13, 89);
            this.lblEditarCategoria.Name = "lblEditarCategoria";
            this.lblEditarCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblEditarCategoria.TabIndex = 2;
            this.lblEditarCategoria.Text = "Categoria:";
            // 
            // lblEditarPreco
            // 
            this.lblEditarPreco.AutoSize = true;
            this.lblEditarPreco.Location = new System.Drawing.Point(12, 62);
            this.lblEditarPreco.Name = "lblEditarPreco";
            this.lblEditarPreco.Size = new System.Drawing.Size(38, 13);
            this.lblEditarPreco.TabIndex = 1;
            this.lblEditarPreco.Text = "Preço:";
            // 
            // lblEditarNome
            // 
            this.lblEditarNome.AutoSize = true;
            this.lblEditarNome.Location = new System.Drawing.Point(11, 35);
            this.lblEditarNome.Name = "lblEditarNome";
            this.lblEditarNome.Size = new System.Drawing.Size(38, 13);
            this.lblEditarNome.TabIndex = 0;
            this.lblEditarNome.Text = "Nome:";
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.lblMensagemApagar);
            this.grbApagar.Enabled = false;
            this.grbApagar.Location = new System.Drawing.Point(11, 568);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(634, 98);
            this.grbApagar.TabIndex = 7;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar produtos";
            // 
            // btnApagar
            // 
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.Color.Red;
            this.btnApagar.Location = new System.Drawing.Point(412, 31);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(196, 36);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.Text = "APAGAR";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblMensagemApagar
            // 
            this.lblMensagemApagar.AutoSize = true;
            this.lblMensagemApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagemApagar.Location = new System.Drawing.Point(54, 40);
            this.lblMensagemApagar.Name = "lblMensagemApagar";
            this.lblMensagemApagar.Size = new System.Drawing.Size(234, 18);
            this.lblMensagemApagar.TabIndex = 0;
            this.lblMensagemApagar.Text = "Selecione o campo a ser apagado";
            // 
            // txbCadastroPreco
            // 
            this.txbCadastroPreco.Location = new System.Drawing.Point(101, 63);
            this.txbCadastroPreco.Name = "txbCadastroPreco";
            this.txbCadastroPreco.Size = new System.Drawing.Size(206, 20);
            this.txbCadastroPreco.TabIndex = 7;
            // 
            // FrmGestaoProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(657, 678);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEditarProduto);
            this.Controls.Add(this.grbAdicionarProduto);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmGestaoProdutos";
            this.Text = "FrmGestaoProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbAdicionarProduto.ResumeLayout(false);
            this.grbAdicionarProduto.PerformLayout();
            this.grbEditarProduto.ResumeLayout(false);
            this.grbEditarProduto.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox grbAdicionarProduto;
        private System.Windows.Forms.TextBox txbCadastroNome;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblCadastroCategoria;
        private System.Windows.Forms.Label lblCadastroPreco;
        private System.Windows.Forms.Label lblCadastroNome;
        private System.Windows.Forms.GroupBox grbEditarProduto;
        private System.Windows.Forms.TextBox txbEditarPreco;
        private System.Windows.Forms.TextBox txbEditarNome;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblEditarCategoria;
        private System.Windows.Forms.Label lblEditarPreco;
        private System.Windows.Forms.Label lblEditarNome;
        private System.Windows.Forms.ComboBox cbmAdicionarCategoria;
        private System.Windows.Forms.ComboBox cmbEditarCategoria;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblMensagemApagar;
        private System.Windows.Forms.TextBox txbCadastroPreco;
    }
}