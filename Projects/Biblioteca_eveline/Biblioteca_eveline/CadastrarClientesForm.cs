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
    public partial class CadastrarClientesForm : Form
    {
        public CadastrarClientesForm()
        {
            InitializeComponent();
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            clienteClasse cliente = new clienteClasse();

            cliente.Codigo = documentoTextBox.Text.Trim();
            cliente.Nome = nomeTextBox.Text;
            cliente.Telefone = telefoneTextBox.Text;
            cliente.Endereco = enderecoTextBox.Text;
            cliente.Email = emailTextBox.Text;
            cliente.gravar();
            
        }
    }
}
