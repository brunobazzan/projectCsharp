using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_Andreza
{
    public partial class telaConfiguracao : Form
    {
        public telaConfiguracao()
        {
            InitializeComponent();
        }

        private void usuarioSenhaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(usuarioSenhaCheckBox.Checked == true)
            {
                usuarioTextBox.Enabled = true;
                senhaTextBox.Enabled = true;
            }
            if(usuarioSenhaCheckBox.Checked == false)
            {
                usuarioTextBox.Enabled = false;
                senhaTextBox.Enabled = false;
            }
        }

        private void configurarButton_Click(object sender, EventArgs e)
        {
            ConfigurarServidorClass configurar = new ConfigurarServidorClass();
            if(usuarioSenhaCheckBox.Checked == true)
            {
                configurar.Servidor = servidorTextBox.Text.Trim();
                configurar.Banco = dataBaseTextBox.Text.Trim();
                configurar.Usuario = usuarioTextBox.Text.Trim();
                configurar.Senha = senhaTextBox.Text.Trim();

                configurar.GravarServidorComSenha();
                configurar.ConfiguraServidor();
                configurar.ConfiguraTabelas();
            }
            if(usuarioSenhaCheckBox.Checked == false)
            {
                configurar.Servidor = servidorTextBox.Text.Trim();
                configurar.Banco = dataBaseTextBox.Text.Trim();

                configurar.GravarServidorSemSenha();
                configurar.ConfiguraServidor();
                configurar.ConfiguraTabelas();
            }
        }

        private void configuraTabelaButton_Click(object sender, EventArgs e)
        {
            ConfigurarServidorClass configura = new ConfigurarServidorClass();
            configura.ConfiguraTabelas();
        }
    }
}
