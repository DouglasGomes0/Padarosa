﻿using System;
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
    public partial class FrmCaixa : Form
    {
        Model.Usuario Usuario;
        public FrmCaixa(Model.Usuario usuario)
        {
            InitializeComponent();
            this.Usuario = usuario;
        }
    }
}
