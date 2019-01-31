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
    public partial class telaPrincipalForm : Form
    {
        public telaPrincipalForm()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void consultarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();
            p.Show();
        }
    }
}
