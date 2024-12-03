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
    public partial class Tela_Cadastro : Form
    {
        
        
            private int Id = -1;
            public Tela_Cadastro()
            {
                InitializeComponent();
            }

            private void ClearFields()
            {
                txbnome.Clear();
                txbemail.Clear();
                txbtelefone.Clear();
                txbcpf.Clear();
               
            }


            private void btnINSERIR_Click(object sender, EventArgs e)
            {
                if (ValidateFields())
                {
                    try
                    {
                        //Capture inputed text from fields.
                        if (new ClienteDAO().Insert(new Cliente(
                            txbnome.Text, txbemail.Text,  
                            txbtelefone.Text, txbcpf.Text)))
                            MessageBox.Show("Corretor cadastrado!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    UpdateListView();
                    ClearFields();
                }
            }

            private void FrmBroker_Load(object sender, EventArgs e)
            {
                UpdateListView();
            }

                

            private void btnEXCLUIR_Click(object sender, EventArgs e)
            {
                ClienteDAO ClienteDao = new ClienteDAO();

                DialogResult resultado = MessageBox.Show("Tem certeza" +
                " que deseja excluir?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        ClienteDao.Delete(Id);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ListView();
                    ClearFields();
                }
            }

            private void btnClear_Click(object sender, EventArgs e)
            {
                ClearFields();

            }

            private void btnEDITAR_Click(object sender, EventArgs e)
            {
                if (ValidateFields())
                {
                    try
                    {
                        //Capture inputed text from fields.
                        new ClienteDAO().Update(new Cliente(
                            Id, txbnome.Text, txbemail.Text, 
                            txbtelefone.Text, txbcpf.Text));
                        MessageBox.Show("Corretor atualizado!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    UpdateListView();
                    ClearFields();
                }
            }

            private void ltvBroker_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void panelBackBroker_Paint(object sender, PaintEventArgs e)
            {

            }
        }
    }

}
