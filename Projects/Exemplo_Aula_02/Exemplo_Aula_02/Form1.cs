using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo_Aula_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void produtoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void incluirListaButton_Click(object sender, EventArgs e)
        {
            produtosListBox1.Items.Add(produtoTextBox.Text);
            produtoTextBox.Clear();
            produtoTextBox.Focus();
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            var cli = new Cliente();
            cli.Nome = nomeTextBox.Text;
            cli.Email = emailTextBox.Text;
            foreach(string item in produtosListBox1.Items)
            {
                cli.Produtos.Add(item);
            }

            Dados.Gravar(cli);

            nomeTextBox.Clear();
            emailTextBox.Clear();
            produtosListBox1.Items.Clear();
            nomeTextBox.Focus();
        }
    }
}
