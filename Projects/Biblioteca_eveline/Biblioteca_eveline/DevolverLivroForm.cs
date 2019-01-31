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
    public partial class DevolverLivroForm : Form
    {
        public DevolverLivroForm()
        {
            InitializeComponent();
        }

        private void dataEntregaTextBox_TextChanged(object sender, EventArgs e)
        {
            dataEntregaTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void DevolverLivroForm_Load(object sender, EventArgs e)
        {
            dataEntregaTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void entregarButton_Click(object sender, EventArgs e)
        {
            DevolverLivroClasse devolver = new DevolverLivroClasse();
            devolver.codigoCliente = codigoLocatarioTextBox.Text;
            devolver.codigoLivro = codigoLivroTextBox.Text;
            devolver.Data = dataEntregaTextBox.Text;
            devolver.GravarDevolucao();
        }
    }
}
