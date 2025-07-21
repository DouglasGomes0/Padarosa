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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txbLogin.Text.Length < 6)
            {
                MessageBox.Show("Email inválido!", "error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenha.Text.Length < 3)
            {
                 MessageBox.Show("Senha incorreta ou invalida","error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //instanciar objeto do tipo usuario
                Model.Usuario usuario = new Model.Usuario();
                usuario.Email = txbLogin.Text;
                usuario.Senha = txbSenha.Text;

                //variavel p/ armazenar o resultado do logar (SELECT)
                DataTable resultado = new DataTable();
                resultado = usuario.Logar();

                //verificar se a tabela tem ao menos 1 linha
                if(resultado.Rows.Count > 0)
                {
                    
                    //armazenar as informações do usuario no objeto:
                    usuario.NomeCompleto = resultado.Rows[0]["nome_completo"].ToString();
                    usuario.Id = (int)resultado.Rows[0]["id"];

                    FormMenuPrincipal formMenuPrincipal = new FormMenuPrincipal(usuario);
                    this.Hide();
                    formMenuPrincipal.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("usuario ou senha incorretos", "error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
