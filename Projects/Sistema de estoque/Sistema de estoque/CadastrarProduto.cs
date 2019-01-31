using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_estoque
{
    public partial class CadastrarProduto : Form
    {
        public CadastrarProduto()
        {
            InitializeComponent();
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            //captura os dados dos texts box
            var produto = new Prod();
            produto.Codigo = codigoTextBox.Text;
            produto.Nome = nomeTextBox.Text;
            produto.Tipo = tipoTextBox.Text;
            produto.Quantidade = Convert.ToInt32(quantidadeTextBox.Text);
            produto.Preco = precoTextBox.Text;

            //ativar o metodo salvar no banco de dados
            produto.GravarDados();

            Produto prod = new Produto();
            prod.Atualizar();      
        }
    }
}
