using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Padarosa.Model;

namespace Padarosa
{
    public partial class FrmGestaoProdutos : Form
    {
        Model.Usuario usuario;
        Model.Produto produto = new Model.Produto();
        public FrmGestaoProdutos(Model.Usuario usuario)
        {
            InitializeComponent();
            
        
            this.usuario = usuario;
            AtualizarDgv();
            Listarcategoria();
            
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //vetificação
            if (txbCadastroNome.Text.Length < 2)
            {
                MessageBox.Show("nome do produto é inválido", "error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbCadastroPreco.Text.Length < 1)
            {
                MessageBox.Show("este preço é inválido", "error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbmAdicionarCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("deve selecionar uma categoria", "error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.produto.Nome = txbCadastroNome.Text;
                this.produto.Preco = double.Parse(txbCadastroPreco.Text);
                this.produto.IdCategoria = int.Parse(cbmAdicionarCategoria.Text);
                this.produto.IdRespCadastro = usuario.Id;

                if(produto.CadastrarProduto())
                {
                    MessageBox.Show("item cadastrado!","sucessful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarDgv();
                    //limpar os campos
                    grbApagar.Enabled = false;
                    grbEditarProduto.Enabled = false;
                    txbCadastroNome.Clear();
                    txbCadastroPreco.Clear();
                    cbmAdicionarCategoria.SelectedIndex = -1;
                }
            }

    }
        public void AtualizarDgv()
        {
            dgvProdutos.DataSource = produto.ListarProdutos();
        }
        public void Listarcategoria()
        {
            cbmAdicionarCategoria.DataSource = produto.ListarCategoria();
            cbmAdicionarCategoria.DisplayMember = "id";
            cmbEditarCategoria.DataSource = produto.ListarCategoria();
            cmbEditarCategoria.DisplayMember= "id";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txbEditarNome.Text.Length < 2)
            {
                MessageBox.Show("nome do produto é inválido", "error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEditarPreco.Text.Length < 1)
            {
                MessageBox.Show("preço do produto é inválido", "error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbEditarCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("deve selecionar uma categoria", "Erro!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.produto.Nome = txbEditarNome.Text;
                this.produto.Preco = double.Parse(txbEditarPreco.Text);
                this.produto.IdCategoria = int.Parse(cmbEditarCategoria.Text);
                this.produto.IdRespCadastro = usuario.Id;

                //executar o .Modificar
                if (this.produto.EditarProduto())
                {
                    MessageBox.Show("item editado!", "sucessful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarDgv();
                    //limpar os campos
                    grbApagar.Enabled = false;
                    grbEditarProduto.Enabled = false;
                    txbEditarNome.Clear();
                    txbEditarPreco.Clear();
                    cmbEditarCategoria.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("falha ao modificar o produto", "error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                AtualizarDgv();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {

            DialogResult apagar = MessageBox.Show("Tem certeza que deseja deletar esse produto?", "warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (apagar == DialogResult.Yes)
            {

                if (this.produto.RemoverProduto())
                {
                    MessageBox.Show("produtos removido com sucesso", "sucessful",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarDgv();
                    //limpar os campos
                    grbApagar.Enabled = false;
                    grbEditarProduto.Enabled = false;
                    txbEditarNome.Clear();
                    txbEditarPreco.Clear();
                    cmbEditarCategoria.SelectedIndex = -1;
                    lblMensagemApagar.Text = "selecione o produto que deseja apagar";
                }
                else
                {
                    MessageBox.Show("falha ao remover o produto", "error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int linhaselecionada = dgvProdutos.SelectedCells[0].RowIndex;
            this.produto.Id = (int)dgvProdutos.Rows[linhaselecionada].Cells[0].Value;
            this.produto.Nome = dgvProdutos.Rows[linhaselecionada].Cells[1].Value.ToString();
            this.produto.Preco = (double)dgvProdutos.Rows[linhaselecionada].Cells[2].Value;
            this.produto.IdCategoria = (int)dgvProdutos.Rows[linhaselecionada].Cells[3].Value;


            //atribuir os dados da linha selecionada no GrvEditar
            txbEditarNome.Text = this.produto.Nome;
            txbEditarPreco.Text = this.produto.Preco.ToString();
           
            //ativar o editor
            grbEditarProduto.Enabled = true;

            //ativar o apagar
            grbApagar.Enabled = true;
            lblMensagemApagar.Text = $"{this.produto.Id} {this.produto.Nome}";

        }
    }
}

