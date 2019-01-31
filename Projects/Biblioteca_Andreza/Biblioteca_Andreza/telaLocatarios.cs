using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Biblioteca_Andreza
{
    public partial class telaLocatarios : Form
    {
        //instanciando uma classe
        ConfigurarServidorClass servidor = new ConfigurarServidorClass();
        //
        public telaLocatarios()
        {
            InitializeComponent();
        }
        
        //METODO DO BOTAO INCLUIR
        private void incluirButton_Click(object sender, EventArgs e)
        {
            

            string conecta = servidor.Conecta();
            if (documentoTextBox.Text == "" && nomeTextBox.Text == "")
            {
                MessageBox.Show("O campo documento e nome são obrigatorios","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            else
            {
                //chamando a classe do locatario
                LocatarioClass Locatario = new LocatarioClass();
                //atribuido os campos 
                Locatario.Documento = documentoTextBox.Text.Trim();
                Locatario.Nome = nomeTextBox.Text.Trim();
                Locatario.Endereco = enderecoTextBox.Text.Trim();
                Locatario.Bairro = bairroTextBox.Text.Trim();
                Locatario.Telefone = telefoneTextBox.Text.Trim();
                Locatario.Email = emailTextBox.Text.Trim();
                Locatario.Gravarlocatario();
                //chamando o atualiza o datagridview
                AtualizaDataGrid();
            }
        }

        //METODO QUE ATUALIZA O DATAGRIDVIEW
        public void AtualizaDataGrid()
        {
            string conecta = servidor.Conecta();
            string comando = "SELECT * FROM CLIENTES";
            try
            {
                SqlConnection conn = new SqlConnection(conecta);
                SqlCommand comand = new SqlCommand(comando, conn);
                SqlDataAdapter da = new SqlDataAdapter(comand);
                DataTable dt = new DataTable();
                da.Fill(dt);
                resultadoDataGridView.DataSource = dt;

                conn.Open();
                comand.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message, "Aviso !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //METODO QUANDO FOR CARREGAR O FORM
        private void telaLocatarios_Load(object sender, EventArgs e)
        {
            AtualizaDataGrid();
        }

        //METODO PARA EXCLUIR LOCATARIO DA BASE
        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (documenot2TextBox.Text=="")
            {
                MessageBox.Show("Por favor digite o documento que deseja excluir", "Aviso !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (MessageBox.Show("Você realmente deseja excluir esse locatario ?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                LocatarioClass locatario = new LocatarioClass();
                locatario.Documento = documenot2TextBox.Text.Trim();
                locatario.ExcluirLocatario();
                AtualizaDataGrid();
            }

        }

        private void procurarLocatarioButton_Click(object sender, EventArgs e)
        {
            string conecta = servidor.Conecta();

            try
            {
                string query = "SELECT * FROM CLIENTES WHERE " + campoComboBox.Text + " LIKE '%" + palavraChaveTextBox.Text + "%'";
                SqlConnection conn = new SqlConnection(conecta);
                SqlCommand comando = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                resultadoDataGridView.DataSource = dt;

                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

       }

        private void contatosButton_Click(object sender, EventArgs e)
        {
            AtualizaDataGrid();
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            LocatarioClass locatario = new LocatarioClass();
            locatario.Documento = documento3TextBox.Text.Trim();
            locatario.Valor = valorTextBox.Text.Trim();
            locatario.Campo = campo2ComboBox.Text.Trim();

            locatario.AtualizaLocatario();
            AtualizaDataGrid();
        }
    }
}
