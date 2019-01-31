using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_eveline
{
    public partial class telaPrincipalForm : Form
    {
        public telaPrincipalForm()
        {
            InitializeComponent();
        }

        private void livrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarExcluirLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaLivrosForm livros = new telaLivrosForm();
            livros.ShowDialog();
        }

        private void emprestarLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaEmprestimoForm emprestimo = new telaEmprestimoForm();
            emprestimo.Show();
        }

        private void incluirExcluirLocatariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaClientesForm clientes = new telaClientesForm();
            clientes.Show();
        }

        private void configurarBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configurarBancoForm form = new configurarBancoForm();
            form.ShowDialog();
        }

        private void telaPrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Você realmente deseja fechar ?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.OK)
            {
                System.Diagnostics.Process.GetCurrentProcess().Close();
            }
            else
            {
                
            }
        }
    }
}
