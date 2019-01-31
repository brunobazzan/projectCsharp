using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;

namespace Biblioteca_eveline
{
    public partial class procurarLivrosForm : Form
    {
        public procurarLivrosForm()
        {
            InitializeComponent();
        }
        //VARIAVEIS DE SQL
        SqlConnection conexao;
        SqlCommand cmd;  //Insere no banco dentro de tabela nos campos nome e número os valores de textBox1 e 4, é necessário colocar o replace no texBox4, pois se o numero tiver "," não irá inserir no banco de dados, a "," representa o próximo campo nessa sintaxe, experimente deixar sem o replace para ver o que acontece
        SqlDataAdapter da;
        DataTable ds;

        public void procurarButton_Click(object sender, EventArgs e)
        {
            string server = "";
            string baseDados = "";
            try
            {
                using (StreamReader leitor1 = new StreamReader(Application.StartupPath + @"\Servidor.txt"))
                {
                    server = leitor1.ReadLine();
                }

                using (StreamReader leitor2 = new StreamReader(Application.StartupPath + @"\NomeBase.txt"))
                {
                    baseDados = leitor2.ReadLine();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
            //---------------------------------------------------------------------------------------------------------------------------
            try
            {
                string strcon = "Data Source=" + server + ";Initial Catalog=" + baseDados + ";Integrated Security=True";
                if (conteudoTextBox.Text == "" || itemComboBox.Text == "")
                {
                    MessageBox.Show("Item faltando por favor selecione", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (itemComboBox.Text == "Codigo")
                    {

                        conexao = new SqlConnection(strcon);
                        cmd = new SqlCommand("SELECT * FROM LIVROS WHERE CODIGO_LIVRO LIKE '" + conteudoTextBox.Text + "%'", conexao);
                        da = new SqlDataAdapter(cmd);
                        ds = new DataTable();

                        da.Fill(ds);
                        dataGridView1.DataSource = ds;

                        conexao.Open();
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                    }

                    else if (itemComboBox.Text == "Nome do Livro")
                    {

                        conexao = new SqlConnection(strcon);
                        cmd = new SqlCommand("SELECT * FROM LIVROS WHERE NOME_LIVRO LIKE '" + conteudoTextBox.Text + "%'", conexao);
                        da = new SqlDataAdapter(cmd);
                        ds = new DataTable();

                        da.Fill(ds);
                        dataGridView1.DataSource = ds;

                        conexao.Open();
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                    }

                    else if (itemComboBox.Text == "Genero")
                    {
                        conexao = new SqlConnection(strcon);
                        cmd = new SqlCommand("SELECT * FROM LIVROS WHERE GENERO LIKE '" + conteudoTextBox.Text + "%'", conexao);
                        da = new SqlDataAdapter(cmd);
                        ds = new DataTable();

                        da.Fill(ds);
                        dataGridView1.DataSource = ds;

                        conexao.Open();
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                    }

                    else if (itemComboBox.Text == "SubGenero")
                    {
                        conexao = new SqlConnection(strcon);
                        cmd = new SqlCommand("SELECT * FROM LIVROS WHERE SUBGENERO LIKE '" + conteudoTextBox.Text + "%'", conexao);
                        da = new SqlDataAdapter(cmd);
                        ds = new DataTable();

                        da.Fill(ds);
                        dataGridView1.DataSource = ds;

                        conexao.Open();
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                    }

                    else if (itemComboBox.Text == "SubGenero 2")
                    {
                        conexao = new SqlConnection(strcon);
                        cmd = new SqlCommand("SELECT * FROM LIVROS WHERE SUBGENERO_2 LIKE '" + conteudoTextBox.Text + "%'", conexao);
                        da = new SqlDataAdapter(cmd);
                        ds = new DataTable();

                        da.Fill(ds);
                        dataGridView1.DataSource = ds;

                        conexao.Open();
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                    }

                    else if (itemComboBox.Text == "Editora")
                    {
                        conexao = new SqlConnection(strcon);
                        cmd = new SqlCommand("SELECT * FROM LIVROS WHERE EDITORA LIKE '" + conteudoTextBox.Text + "%'", conexao);
                        da = new SqlDataAdapter(cmd);
                        ds = new DataTable();

                        da.Fill(ds);
                        dataGridView1.DataSource = ds;

                        conexao.Open();
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                    }
                    configuraDatagrid();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }      
        }
        //-------------------------------------------------------------------------------------------------------------------------
        public void configuraDatagrid()
        {
            try
            {
                dataGridView1.Columns[0].HeaderText = "Codigo";
                dataGridView1.Columns[1].HeaderText = "Nome do Livro";
                dataGridView1.Columns[2].HeaderText = "Genero";
                dataGridView1.Columns[3].HeaderText = "SubGenero";
                dataGridView1.Columns[4].HeaderText = "SubGenero 2";
                dataGridView1.Columns[5].HeaderText = "Autor";
                dataGridView1.Columns[6].HeaderText = "Autor Espiritual";
                dataGridView1.Columns[7].HeaderText = "Editora";
                dataGridView1.Columns[8].HeaderText = "Status ";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
