using System;
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
    public partial class Tela_pedido : Form
    {
        public Tela_pedido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tela_final tela_Final = new Tela_final();
            this.Visible = false;
            tela_Final.ShowDialog();
            this.Visible = true;

        }
    }
}
