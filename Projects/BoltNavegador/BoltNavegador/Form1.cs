using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoltNavegador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void exibirwebBrowser_Navigating(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
            //quais conteudos estão sendo carregados
            statusLabel.Text = e.Url.ToString();

            //colocando o endereço na textbox1
            barraEnderecoTextBox1.Clear();
            barraEnderecoTextBox1.Text = exibirwebBrowser.Url.ToString();
            
            //para gravar o endereço no combobox
         
                comboBox1.Items.Add(exibirwebBrowser.Url.ToString());
        }

        private void barraEnderecoTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //captando o evento quando o botão enter é apertado(13)
            if (e.KeyChar == 13)
            {
                irButton.PerformClick();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            exibirwebBrowser.Navigate("www.msn.com.br");
        }

        private void irButton_Click(object sender, EventArgs e)
        {
            
            //colocando o caminho para que se navegue 
            try
            {
                exibirwebBrowser.Navigate( barraEnderecoTextBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            exibirwebBrowser.GoBack();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void adianteButton_Click(object sender, EventArgs e)
        {
            exibirwebBrowser.GoForward();
        }
    }
}
