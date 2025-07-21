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
    public partial class FrmComandas : Form
    {
        Model.Usuario usuario;
        public FrmComandas(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
    }
}
