﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOCERIACAT
{
    public partial class Tela_cardapio : Form
    {
        public Tela_cardapio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Tela_pedido tela_Pedido = new Tela_pedido();
            this.Visible = false;
            tela_Pedido.ShowDialog();
            this.Visible = true;
        }
    }
}


