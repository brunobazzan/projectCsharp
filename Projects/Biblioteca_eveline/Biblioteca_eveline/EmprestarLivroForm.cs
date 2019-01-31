using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;


namespace Biblioteca_eveline
{
    public partial class EmprestarLivroForm : Form
    {
        public EmprestarLivroForm()
        {
            InitializeComponent();
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            EmprestimoClass emprestimo = new EmprestimoClass();
            telaEmprestimoForm atualiza = new telaEmprestimoForm();
            emprestimo.codigoLocatario = codigoClienteTextBox.Text;
            emprestimo.codigoLivro = codigoLivroTextBox.Text;
            emprestimo.dataEnvio = dataTextBox.Text;
            emprestimo.CadastrarTransacao();
            emprestimo.AtualizaStatus();
            atualiza.AtualizaDataGrid();
        }

        private void dataTextBox_TextChanged(object sender, EventArgs e)
        {
            dataTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void EmprestarLivroForm_Load(object sender, EventArgs e)
        {
            dataTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
