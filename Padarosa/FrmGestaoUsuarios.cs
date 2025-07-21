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
        }
    }
}
