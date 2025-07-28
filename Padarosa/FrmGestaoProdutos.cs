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
        Model.Produto produto;
        public FrmGestaoProdutos(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            AtualizarDgv();
            
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //vetificação
            if (txbCadastroNome.Text.Length < 2)
            {
                MessageBox.Show("nome do produto é inválido", "error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbCadastroPreco.Text.Length < 2)
            {
                MessageBox.Show("este preço é inválido", "error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbEditarCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("deve selecionar uma categoria", "error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }
            
        

        



    }
        public void AtualizarDgv()
        {
            dgvProdutos.DataSource = produto.ListarProdutos();
        }
    }
}

