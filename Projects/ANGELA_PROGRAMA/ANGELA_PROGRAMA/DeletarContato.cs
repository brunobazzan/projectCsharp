using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANGELA_PROGRAMA
{
    public partial class DeletarContato : Form
    {
        public DeletarContato()
        {
            InitializeComponent();
        }

        private void deletarButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja apagar o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                ApagaContato apaga = new ApagaContato();
                apaga.Nome = nomeTextBox.Text.Trim();
                apaga.ApagaRegistro();
            }
        }
    }
}
