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
    public partial class telaLivrosForm : Form
    {
        public telaLivrosForm()
        {
            InitializeComponent();
        }
        ConfigurarServidorClass servidor = new ConfigurarServidorClass();

        public void AtualizaDataGrid()
        {
            string conecta = servidor.Conecta();
            try
            {
                string query = "SELECT CODIGO AS Codigo,TITULO as Titulo,AUTORES as Autores,GENERO as Genero,EDITORA as Editora,STATUS as Status FROM LIVROS";
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
                MessageBox.Show("Erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void telaLivrosForm_Load(object sender, EventArgs e)
        {
            AtualizaDataGrid();
        }

        private void gravarLivrobutton_Click(object sender, EventArgs e)
        {
            //Chamando a classe livro
            LivroClass livro = new LivroClass();

            //atribuido os campos na variavel
            livro.Codigo = codigoTextBox.Text.Trim();
            livro.Titulo = tituloTextBox.Text.Trim();
            livro.Autores = autoresTextBox.Text.Trim();
            livro.Genero = generoTextBox.Text.Trim();
            livro.Editora = editoraTextBox.Text.Trim();

            //chamando o metodo que gravar o novo regsitro
            livro.GravarLivro();

            //chama o metodo que atualiza o datagridview
            AtualizaDataGrid();       
        }

        private void deletarButton_Click(object sender, EventArgs e)
        {
            //chamando a classe livro
            LivroClass livro = new LivroClass();
            if (codigoTextBox.Text == "" && tituloTextBox.Text == "")
            {
                MessageBox.Show("O campo do documento não pode ser vazio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show("Você deseja realmente deletar esse livro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    //atribuindo os campos na variavel
                    livro.Codigo = codigo2TextBox.Text.Trim();
                    livro.DeletarLivro();

                    //chama o metodo que atualiza o datagrid
                    AtualizaDataGrid();
                }
            }
          }

        private void procurarButton_Click(object sender, EventArgs e)
        {
            string conecta = servidor.Conecta();
            try
            {
                string query = "SELECT * FROM LIVROS WHERE " + campoComboBox.Text + " LIKE '%" + palavraChaveTextBox.Text + "%'";
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
                MessageBox.Show("Erro: " + ex.Message, "Aviso !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void desfazerButton_Click(object sender, EventArgs e)
        {
            AtualizaDataGrid();
        }

        private void alterarButton_Click_1(object sender, EventArgs e)
        {
            LivroClass livro = new LivroClass();
            livro.Valor = valorTextBox.Text.Trim();
            livro.Codigo = codigo3textBox.Text.Trim();
            livro.Campo = campo2ComboBox1.Text.Trim();

            livro.AtualizaLivro();

            AtualizaDataGrid();
        }
    }
 }


