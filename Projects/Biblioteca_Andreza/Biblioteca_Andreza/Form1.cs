using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Biblioteca_Andreza
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            telaPrincipalForm principal = new telaPrincipalForm();

            bool resultado = false;
            LoginClass login = new LoginClass();
           
            login.Usuario = nomeTextBox.Text;
            login.Senha = senhaTextBox.Text;
            resultado = login.VerificaLogin();
            if (resultado)
            {
                MessageBox.Show("Bem Vindo!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuario ou senha estão invalidos","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void configuraButton_Click(object sender, EventArgs e)
        {
            telaConfiguracao configuracao = new telaConfiguracao();
            configuracao.ShowDialog();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            if(File.Exists(Application.StartupPath + @"\servidor.txt") == false)
            {
                if (MessageBox.Show("O banco de dados ainda não foi configurado. \nVocê deseja configurar uma nova base?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    telaConfiguracao configuracao = new telaConfiguracao();
                    configuracao.ShowDialog();
                }
            }
        }
    }
}
