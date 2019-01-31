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
using System.IO;

namespace Biblioteca_eveline
{
    public partial class autoresForm : Form
    {
        public autoresForm()
        {
            InitializeComponent();
        }

        SqlConnection conexao;
        SqlCommand cmd;  //Insere no banco dentro de tabela nos campos nome e número os valores de textBox1 e 4, é necessário colocar o replace no texBox4, pois se o numero tiver "," não irá inserir no banco de dados, a "," representa o próximo campo nessa sintaxe, experimente deixar sem o replace para ver o que acontece
        SqlDataAdapter da;
        DataTable ds;

        private void cadastrarAutorButton_Click(object sender, EventArgs e)
        {
            livrosClasse livro = new livrosClasse();
            livro.Nome_autor = autorTextBox.Text;
            livro.Gravar_Autor();
            atualizaDataGrid();
        }
        public void atualizaDataGrid()
        { 
            string server = "";
            string baseDados = "";
            try
            {
                using (StreamReader leito1 = new StreamReader(Application.StartupPath + @"\Servidor.txt"))
                {
                    server = leito1.ReadLine();
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
            try
            {
                //populando o dataGridView
                //Obs. quando estamos inserindo, deletando, ou alterando um valor no banco de dados, é importante notar que o textbox1 está entre ‘””’ pois essa é sintaxe que usamos quando o valor é uma string, note também que o texbox2 está entre ”” apenas, pois o valor é numérico, nesse caso do tipo float            */
                string strcon = "Data Source=" + server + ";Initial Catalog=" + baseDados + ";Integrated Security=True";
                conexao = new SqlConnection(strcon);
                cmd = new SqlCommand("SELECT * FROM AUTORES", conexao);
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

        private void autoresForm_Load(object sender, EventArgs e)
        {
            atualizaDataGrid();
        }
    }
}
