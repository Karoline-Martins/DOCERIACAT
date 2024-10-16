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
    public partial class Tela_entrar : Form
    {
        public Tela_entrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbUser.Text == "karol" && txbPass.Text == "1511")
            {
                txbUser.Text = String.Empty;
                txbPass.Text = String.Empty;
                txbUser.Focus();
                Tela_cardapio iniciar_Sessao = new Tela_cardapio();
                this.Visible = false;
                iniciar_Sessao.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha incorretos",
                    "ERRO NO LOGIN",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }
    }
}
