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
    public partial class Produto : Form
    {
        public Produto()
        {
            InitializeComponent();
        }

        private void Produto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRODUTODataSet.PRODUTO' table. You can move, or remove it, as needed.
            this.pRODUTOTableAdapter.Fill(this.pRODUTODataSet.PRODUTO);
            dataGridView1.Refresh();

        }

        private void cadastrarNovoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarProduto cp = new CadastrarProduto();
            cp.Show();
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void Atualizar()
        {
            dataGridView1.Refresh();
        }

    }


}
