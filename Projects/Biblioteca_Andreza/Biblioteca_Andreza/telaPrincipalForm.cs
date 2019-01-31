using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_Andreza
{
    public partial class telaPrincipalForm : Form
    {
        public telaPrincipalForm()
        {
            InitializeComponent();
        }

        private void gerenciarLocatariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaLocatarios tela = new telaLocatarios();
            tela.ShowDialog();
        }

        private void gerenciarLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaLivrosForm form = new telaLivrosForm();
            form.ShowDialog();       
        }

        private void emprestarDevolverLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaEmprestimo emprestimo = new telaEmprestimo();
            emprestimo.ShowDialog();
        }

        private void configurarBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaConfiguracao configuracao = new telaConfiguracao();
            configuracao.ShowDialog();
        }

        private void telaPrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
 
                Application.Exit();
        }

        private void telaPrincipalForm_Load(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            login.Close();
        }
    }
}
