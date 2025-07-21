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
    public partial class FormMenuPrincipal : Form
    {
        //variaveis globais
        Model.Usuario Usuario;
        public FormMenuPrincipal(Model.Usuario usuario)
        {
            InitializeComponent();
            this.Usuario = usuario;
            lblLogado.Text = $"você está logado como: {usuario.NomeCompleto}";
        }

        private void btnGestaoProdutos_Click(object sender, EventArgs e)
        {
            FrmGestaoProdutos frmGestaoProdutos = new FrmGestaoProdutos(Usuario);
            frmGestaoProdutos.ShowDialog();
        }

        private void btnLancarComandas_Click(object sender, EventArgs e)
        {
            FrmComandas frmComandas = new FrmComandas(Usuario);
            frmComandas.ShowDialog();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            FrmCaixa frmcaixa = new FrmCaixa(Usuario);
            frmcaixa.ShowDialog();
        }

        private void btnGestaoUsuarios_Click(object sender, EventArgs e)
        {
            FrmGestaoUsuarios frmGestaoUsuarios = new FrmGestaoUsuarios(Usuario);
            frmGestaoUsuarios.ShowDialog();
        }
    }
}
