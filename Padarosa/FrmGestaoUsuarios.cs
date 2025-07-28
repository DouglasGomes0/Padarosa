using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padarosa
{
    public partial class FrmGestaoUsuarios : Form
    {
        Model.Usuario usuario;
        public FrmGestaoUsuarios(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            //puxar os dados da tabela usuario
            AtualizarDgv();
        }
        public void AtualizarDgv()
        {
            dgvUsuarios.DataSource = usuario.Listar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //vetificação
            if(txbCadastroEmail.Text.Length < 6)
            {
                MessageBox.Show("email informado é inválido","error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txbCadastroNome.Text.Length < 7)
            {
                MessageBox.Show("nome informado é inválido", "error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txbCadastroSenha.Text.Length < 6)
            {
                MessageBox.Show("senha deve ter no mínimo 6 caracteres", "error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //iniciar cadastro no banco de dados
                //instanciar usuario
                Model.Usuario usuario = new Model.Usuario();
                usuario.Email = txbCadastroEmail.Text;
                usuario.NomeCompleto = txbCadastroNome.Text;
                usuario.Senha = txbCadastroSenha.Text;

                if(usuario.Cadastrar())
                {
                    MessageBox.Show("usuario cadastrado com sucesso!","sucessful",
                        MessageBoxButtons.OK,MessageBoxIcon.Information);
                    //limpar campos
                    txbCadastroEmail.Clear();
                    txbCadastroNome.Clear();
                    txbCadastroSenha.Clear();
                    //atualizar o dgv(reexecutar o SELECT)
                    AtualizarDgv();
                    
                }
                else
                {
                    MessageBox.Show("falha ao cadastrar usuário!","error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txbEdicaoEmail.Text.Length < 6)
            {
                MessageBox.Show("email informado é inválido", "error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEdicaoNome.Text.Length < 7)
            {
                MessageBox.Show("nome informado é inválido", "error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEdicaoSenha.Text.Length >= 1 && txbEdicaoSenha.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter no mínimo 6 caracteres!", "Erro!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //realisar edição no banco de dados
                this.usuario.NomeCompleto = txbEdicaoNome.Text;
                this.usuario.Email = txbEdicaoEmail.Text;
                this.usuario.Senha = txbEdicaoSenha.Text;

                //executar o .Modificar
                if (this.usuario.Modificar())
                {
                    MessageBox.Show("usuário modificado com sucesso", "sucessful",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarDgv();
                    //limpar os campos
                    grbApagar.Enabled = false;
                    grbEdicao.Enabled = false;
                    txbEdicaoEmail.Clear();
                    txbEdicaoSenha.Clear();
                    txbEdicaoNome.Clear();
                }
                else
                {
                    MessageBox.Show("falha ao modificar o usuário", "error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            

                AtualizarDgv();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            DialogResult apagar = MessageBox.Show("Tem certeza que deseja deletar esse usuário?","warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(apagar == DialogResult.Yes)
            {

                if(this.usuario.Remover())
                {
                    MessageBox.Show("usuário removido com sucesso", "sucessful",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarDgv();
                    //limpar os campos
                    grbApagar.Enabled = false;
                    grbEdicao.Enabled = false;
                    txbEdicaoEmail.Clear();
                    txbEdicaoSenha.Clear();
                    txbEdicaoNome.Clear();
                    lblMensagemApagar.Text = "selecione o usuário que deseja apagar";
                }
                else
                {
                    MessageBox.Show("falha ao remover o usuário", "error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
                
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaselecionada = dgvUsuarios.SelectedCells[0].RowIndex;

            this.usuario.NomeCompleto = dgvUsuarios.Rows[linhaselecionada].Cells[1].Value.ToString();
            this.usuario.Email = dgvUsuarios.Rows[linhaselecionada].Cells[2].Value.ToString();
            this.usuario.Id = (int)dgvUsuarios.Rows[linhaselecionada].Cells[0].Value;
            

            //atribuir os dados da linha selecionada no GrvEditar
            txbEdicaoNome.Text = this.usuario.NomeCompleto;
            txbEdicaoEmail.Text = this.usuario.Email;
            //ativar o editor
            grbEdicao.Enabled = true;

            //ativar o apagar
            grbApagar.Enabled = true;
            lblMensagemApagar.Text = $"{this.usuario.Id} {this.usuario.NomeCompleto}";

        }
    }
}
