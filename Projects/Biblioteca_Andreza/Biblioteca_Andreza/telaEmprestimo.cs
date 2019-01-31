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
    public partial class telaEmprestimo : Form
    {
        public telaEmprestimo()
        {
            InitializeComponent();
        }
        ConfigurarServidorClass servidor = new ConfigurarServidorClass();

        public void AtualizaDatagrid()
        {
            string conecta = servidor.Conecta();
            try
            {
                string query = "SELECT * FROM EMPRESTIMO";
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

        private void telaEmprestimo_Load(object sender, EventArgs e)
        {
            AtualizaDatagrid();
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            //instanciando a classe livro
            LivroClass livro = new LivroClass();

            livro.Documento = documentoTextBox.Text.Trim();
            livro.Codigo = codigoTextBox.Text.Trim();

            //chama o metodo de gravar transação
            livro.GravarTransacaoEmprestimo();

            //chama o metodo de atualizar o datagrid
            AtualizaDatagrid();
        }

        private void gravarDevolucaoButton_Click(object sender, EventArgs e)
        {
            //instanciando a classe livro
            LivroClass livro = new LivroClass();

            livro.Codigo = codigoLivro2TextBox.Text.Trim();

            //chamando o metodo que devolve o livro na base
            livro.GravarTransacaoDevolucao();

            //chama o metodo de atualizar o datagrid
            AtualizaDatagrid();
        }
    }
}
