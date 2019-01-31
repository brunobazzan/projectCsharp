using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_estoque
{
    class Prod
    {
        private object dataGridView1;

        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public int Quantidade { get; set; }
        public string Preco { get; set; }

        public void GravarDados()
        {
            string strcon = "Data Source=PC-QUARTO\\SQLEXPRESS;Initial Catalog=PRODUTO;Integrated Security=True";
            SqlConnection conexao = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("INSERT INTO PRODUTO( CODIGO,NOME,TIPO,QUANTIDADE,PRECO) VALUES('" + Codigo+"','"+Nome+"','"+Tipo+"','"+Quantidade+"','"+Preco+"')", conexao); 
            /* Insere no banco dentro de tabela nos campos nome e número os valores de textBox1 e 4, é necessário colocar o replace no texBox4, pois se o numero tiver "," não irá inserir no banco de dados, a "," representa o próximo campo nessa sintaxe, experimente deixar sem o replace para ver o que acontece
            Obs. quando estamos inserindo, deletando, ou alterando um valor no banco de dados, é importante notar que o textbox1 está entre ‘””’ pois essa é sintaxe que usamos quando o valor é uma string, note também que o texbox2 está entre ”” apenas, pois o valor é numérico, nesse caso do tipo float            */
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
    }

