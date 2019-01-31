using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_Teste
{
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void gravarButton1_Click(object sender, EventArgs e)
        {
            //aqui chamamos a nossa classe ja criada
            var cl = new Cliente();
            //aqui vamos capturar os dados dos textbox
            cl.Documento = documentoTextBox.Text;
            cl.Nome = nomeTextBox.Text;
            cl.Endereço = enderecoTextBox.Text;
            cl.Email = emailTextBox.Text;

            //chamamos a nossa classe gravar o nosso conteudo no nosso banco de dados txt
            Gravar.GravarCliente(cl);

            //limpando o nossos textbox
            documentoTextBox.Clear();
            nomeTextBox.Clear();
            enderecoTextBox.Clear();
            emailTextBox.Clear();
            
            //dando foco para o nosso campo documento
            documentoTextBox.Focus();
        }

        private void documentoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
