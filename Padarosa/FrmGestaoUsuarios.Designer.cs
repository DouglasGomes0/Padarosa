namespace Padarosa
{
    partial class FrmGestaoUsuarios
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCadastroNome = new System.Windows.Forms.Label();
            this.lblCadastroEmail = new System.Windows.Forms.Label();
            this.lblCadastroSenha = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grbEdicao = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblEdicaoSenha = new System.Windows.Forms.Label();
            this.lblEdicaoEmail = new System.Windows.Forms.Label();
            this.lblEdicaoNome = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.lblMensagemApagar = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.txbCadastroNome = new System.Windows.Forms.TextBox();
            this.txbCadastroEmail = new System.Windows.Forms.TextBox();
            this.txbCadastroSenha = new System.Windows.Forms.TextBox();
            this.txbEdicaoNome = new System.Windows.Forms.TextBox();
            this.txbEdicaoEmail = new System.Windows.Forms.TextBox();
            this.txbEdicaoSenha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grbCadastro.SuspendLayout();
            this.grbEdicao.SuspendLayout();
            this.grbApagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(17, 58);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(642, 271);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // grbCadastro
            // 
            this.grbCadastro.Controls.Add(this.txbCadastroSenha);
            this.grbCadastro.Controls.Add(this.txbCadastroEmail);
            this.grbCadastro.Controls.Add(this.txbCadastroNome);
            this.grbCadastro.Controls.Add(this.btnCadastrar);
            this.grbCadastro.Controls.Add(this.lblCadastroSenha);
            this.grbCadastro.Controls.Add(this.lblCadastroEmail);
            this.grbCadastro.Controls.Add(this.lblCadastroNome);
            this.grbCadastro.Location = new System.Drawing.Point(25, 337);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(314, 187);
            this.grbCadastro.TabIndex = 1;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "cadastro";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(240, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(232, 29);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Gestão de usuários";
            // 
            // lblCadastroNome
            // 
            this.lblCadastroNome.AutoSize = true;
            this.lblCadastroNome.Location = new System.Drawing.Point(11, 35);
            this.lblCadastroNome.Name = "lblCadastroNome";
            this.lblCadastroNome.Size = new System.Drawing.Size(85, 13);
            this.lblCadastroNome.TabIndex = 0;
            this.lblCadastroNome.Text = "Nome Completo:";
            // 
            // lblCadastroEmail
            // 
            this.lblCadastroEmail.AutoSize = true;
            this.lblCadastroEmail.Location = new System.Drawing.Point(12, 62);
            this.lblCadastroEmail.Name = "lblCadastroEmail";
            this.lblCadastroEmail.Size = new System.Drawing.Size(35, 13);
            this.lblCadastroEmail.TabIndex = 1;
            this.lblCadastroEmail.Text = "Email:";
            // 
            // lblCadastroSenha
            // 
            this.lblCadastroSenha.AutoSize = true;
            this.lblCadastroSenha.Location = new System.Drawing.Point(13, 89);
            this.lblCadastroSenha.Name = "lblCadastroSenha";
            this.lblCadastroSenha.Size = new System.Drawing.Size(39, 13);
            this.lblCadastroSenha.TabIndex = 2;
            this.lblCadastroSenha.Text = "senha:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCadastrar.Location = new System.Drawing.Point(27, 128);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(260, 44);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // grbEdicao
            // 
            this.grbEdicao.Controls.Add(this.txbEdicaoSenha);
            this.grbEdicao.Controls.Add(this.txbEdicaoEmail);
            this.grbEdicao.Controls.Add(this.txbEdicaoNome);
            this.grbEdicao.Controls.Add(this.btnEditar);
            this.grbEdicao.Controls.Add(this.lblEdicaoSenha);
            this.grbEdicao.Controls.Add(this.lblEdicaoEmail);
            this.grbEdicao.Controls.Add(this.lblEdicaoNome);
            this.grbEdicao.Enabled = false;
            this.grbEdicao.Location = new System.Drawing.Point(345, 337);
            this.grbEdicao.Name = "grbEdicao";
            this.grbEdicao.Size = new System.Drawing.Size(314, 187);
            this.grbEdicao.TabIndex = 5;
            this.grbEdicao.TabStop = false;
            this.grbEdicao.Text = "Edição";
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEditar.Location = new System.Drawing.Point(27, 128);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(260, 44);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblEdicaoSenha
            // 
            this.lblEdicaoSenha.AutoSize = true;
            this.lblEdicaoSenha.Location = new System.Drawing.Point(13, 89);
            this.lblEdicaoSenha.Name = "lblEdicaoSenha";
            this.lblEdicaoSenha.Size = new System.Drawing.Size(39, 13);
            this.lblEdicaoSenha.TabIndex = 2;
            this.lblEdicaoSenha.Text = "senha:";
            // 
            // lblEdicaoEmail
            // 
            this.lblEdicaoEmail.AutoSize = true;
            this.lblEdicaoEmail.Location = new System.Drawing.Point(12, 62);
            this.lblEdicaoEmail.Name = "lblEdicaoEmail";
            this.lblEdicaoEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEdicaoEmail.TabIndex = 1;
            this.lblEdicaoEmail.Text = "Email:";
            // 
            // lblEdicaoNome
            // 
            this.lblEdicaoNome.AutoSize = true;
            this.lblEdicaoNome.Location = new System.Drawing.Point(11, 35);
            this.lblEdicaoNome.Name = "lblEdicaoNome";
            this.lblEdicaoNome.Size = new System.Drawing.Size(85, 13);
            this.lblEdicaoNome.TabIndex = 0;
            this.lblEdicaoNome.Text = "Nome Completo:";
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.lblMensagemApagar);
            this.grbApagar.Enabled = false;
            this.grbApagar.Location = new System.Drawing.Point(25, 537);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(634, 75);
            this.grbApagar.TabIndex = 6;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // lblMensagemApagar
            // 
            this.lblMensagemApagar.AutoSize = true;
            this.lblMensagemApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagemApagar.Location = new System.Drawing.Point(201, 12);
            this.lblMensagemApagar.Name = "lblMensagemApagar";
            this.lblMensagemApagar.Size = new System.Drawing.Size(234, 18);
            this.lblMensagemApagar.TabIndex = 0;
            this.lblMensagemApagar.Text = "Selecione o campo a ser apagado";
            // 
            // btnApagar
            // 
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.Color.Red;
            this.btnApagar.Location = new System.Drawing.Point(220, 33);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(196, 36);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.Text = "APAGAR";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // txbCadastroNome
            // 
            this.txbCadastroNome.Location = new System.Drawing.Point(101, 34);
            this.txbCadastroNome.Name = "txbCadastroNome";
            this.txbCadastroNome.Size = new System.Drawing.Size(206, 20);
            this.txbCadastroNome.TabIndex = 4;
            // 
            // txbCadastroEmail
            // 
            this.txbCadastroEmail.Location = new System.Drawing.Point(101, 63);
            this.txbCadastroEmail.Name = "txbCadastroEmail";
            this.txbCadastroEmail.Size = new System.Drawing.Size(206, 20);
            this.txbCadastroEmail.TabIndex = 5;
            // 
            // txbCadastroSenha
            // 
            this.txbCadastroSenha.Location = new System.Drawing.Point(101, 90);
            this.txbCadastroSenha.Name = "txbCadastroSenha";
            this.txbCadastroSenha.Size = new System.Drawing.Size(206, 20);
            this.txbCadastroSenha.TabIndex = 6;
            // 
            // txbEdicaoNome
            // 
            this.txbEdicaoNome.Location = new System.Drawing.Point(102, 35);
            this.txbEdicaoNome.Name = "txbEdicaoNome";
            this.txbEdicaoNome.Size = new System.Drawing.Size(206, 20);
            this.txbEdicaoNome.TabIndex = 5;
            // 
            // txbEdicaoEmail
            // 
            this.txbEdicaoEmail.Location = new System.Drawing.Point(102, 62);
            this.txbEdicaoEmail.Name = "txbEdicaoEmail";
            this.txbEdicaoEmail.Size = new System.Drawing.Size(206, 20);
            this.txbEdicaoEmail.TabIndex = 6;
            // 
            // txbEdicaoSenha
            // 
            this.txbEdicaoSenha.Location = new System.Drawing.Point(102, 90);
            this.txbEdicaoSenha.Name = "txbEdicaoSenha";
            this.txbEdicaoSenha.Size = new System.Drawing.Size(206, 20);
            this.txbEdicaoSenha.TabIndex = 7;
            // 
            // FrmGestaoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 628);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEdicao);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "FrmGestaoUsuarios";
            this.Text = "FrmGestaoUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.grbEdicao.ResumeLayout(false);
            this.grbEdicao.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCadastroEmail;
        private System.Windows.Forms.Label lblCadastroNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblCadastroSenha;
        private System.Windows.Forms.GroupBox grbEdicao;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblEdicaoSenha;
        private System.Windows.Forms.Label lblEdicaoEmail;
        private System.Windows.Forms.Label lblEdicaoNome;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblMensagemApagar;
        private System.Windows.Forms.TextBox txbCadastroSenha;
        private System.Windows.Forms.TextBox txbCadastroEmail;
        private System.Windows.Forms.TextBox txbCadastroNome;
        private System.Windows.Forms.TextBox txbEdicaoSenha;
        private System.Windows.Forms.TextBox txbEdicaoEmail;
        private System.Windows.Forms.TextBox txbEdicaoNome;
    }
}