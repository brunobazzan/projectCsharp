using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace Biblioteca_eveline
{
    public partial class telaLivrosForm : Form
    {
        public telaLivrosForm()
        {
            InitializeComponent();
        }
        SqlConnection conexao;
        SqlCommand cmd;  //Insere no banco dentro de tabela nos campos nome e número os valores de textBox1 e 4, é necessário colocar o replace no texBox4, pois se o numero tiver "," não irá inserir no banco de dados, a "," representa o próximo campo nessa sintaxe, experimente deixar sem o replace para ver o que acontece
        SqlDataAdapter da;
        DataTable ds;

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cadastarLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //chamando outro form para cadastro de livros
            cadastrarLivroForm livros = new cadastrarLivroForm();
            livros.ShowDialog();
        }

        public void telaLivrosForm_Load(object sender, EventArgs e)
        {
            //inicializa fazendo a leitura do arquivo
            LeitorDeDados();
            //INICIALIZA O COMPONENTE POPULANDO O DATAGRIDVIEW
            atualizaDataGrid();
            //ALTERA O NOME DAS COLUNAS PARA UMA MELHOR VISUALIZAÇÃO
            alteraColuna();
        }
        public void atualizaDataGrid()
        {
            try
            {
                //populando o dataGridView
                //Obs. quando estamos inserindo, deletando, ou alterando um valor no banco de dados, é importante notar que o textbox1 está entre ‘””’ pois essa é sintaxe que usamos quando o valor é uma string, note também que o texbox2 está entre ”” apenas, pois o valor é numérico, nesse caso do tipo float            */
                string strcon = "Data Source="+servidorLabel.Text+";Initial Catalog="+bandoDadosLabel.Text+";Integrated Security=True";
                conexao = new SqlConnection(strcon);
                cmd = new SqlCommand("SELECT * FROM LIVROS", conexao);
                da = new SqlDataAdapter(cmd);
                ds = new DataTable();
                da.Fill(ds);

                BindingSource bs = new BindingSource();
                bs.DataSource = ds;

                mostrarDataGridView.DataSource = bs;

                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
            
        }

        public void alteraColuna()
        {
            //renomear o nome das colunas para uma melhor visualização.
            try
            {
                mostrarDataGridView.Columns[0].HeaderText = "Codigo";
                mostrarDataGridView.Columns[1].HeaderText = "Nome do Livro";
                mostrarDataGridView.Columns[2].HeaderText = "Genero";
                mostrarDataGridView.Columns[3].HeaderText = "SubGenero";
                mostrarDataGridView.Columns[4].HeaderText = "SubGenero 2";
                mostrarDataGridView.Columns[5].HeaderText = "Autor";
                mostrarDataGridView.Columns[6].HeaderText = "Autor Espiritual";
                mostrarDataGridView.Columns[7].HeaderText = "Editora";
                mostrarDataGridView.Columns[8].HeaderText = "Status";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        private void atualizarButton_Click(object sender, EventArgs e)
        {
            atualizaDataGrid();
        }

        private void procurarLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            procurarLivrosForm form = new procurarLivrosForm();
            form.Show();
        }

        private void mostrarDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LeitorDeDados()
        {
            try
            {
                //colocando o nome do servidor na label
                using (StreamReader leitor1 = new StreamReader(Application.StartupPath + @"\Servidor.txt"))
                {
                    servidorLabel.Text = leitor1.ReadToEnd();
                }

                using (StreamReader leitor2 = new StreamReader(Application.StartupPath + @"\NomeBase.txt"))
                {
                    bandoDadosLabel.Text = leitor2.ReadToEnd();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        private void excluirLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ecluirLivroForm form = new ecluirLivroForm();
            form.ShowDialog();
        }

        private void cadastrarExcluirAutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autoresForm autor = new autoresForm();
            autor.ShowDialog();
        }

        private void cadastrarExcluirAutorEspiritualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autorEspiritualForm autorEspirital = new autorEspiritualForm();
            autorEspirital.ShowDialog();
        }
    }
}