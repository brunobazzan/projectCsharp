using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace Biblioteca_eveline
{
    class DevolverLivroClasse
    {
        public string codigoCliente { get; set; }
        public string codigoLivro { get; set; }
        public string Data { get; set; }

        public void GravarDevolucao()
        {
            string server = "";
            string baseBanco = "";
            try
            {
                using (StreamReader leitor1 = new StreamReader(Application.StartupPath + @"\Servidor.txt"))
                {
                    server = leitor1.ReadToEnd();
                }

                using (StreamReader leitor2 = new StreamReader(Application.StartupPath + @"\NomeBase.txt"))
                {
                    baseBanco = leitor2.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            try
            {

                string strcon = "Data Source=" + server + ";Initial Catalog=" + baseBanco + ";Integrated Security=True";
                SqlConnection conexao = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("UPDATE TRANSACAO SET DATA_ENTREGA = '"+Data+"' WHERE CODIGO_LIVRO = '"+codigoLivro+"' AND CODIGO_LOCATARIO = '"+codigoCliente+"'AND DATA_ENTREGA IS NULL OR DATA_ENTREGA = ''", conexao); /* Insere no banco dentro de tabela nos campos nome e número os valores de textBox1 e 4, é necessário colocar o replace no texBox4, pois se o numero tiver "," não irá inserir no banco de dados, a "," representa o próximo campo nessa sintaxe, experimente deixar sem o replace para ver o que acontece
Obs. quando estamos inserindo, deletando, ou alterando um valor no banco de dados, é importante notar que o textbox1 está entre ‘””’ pois essa é sintaxe que usamos quando o valor é uma string, note também que o texbox2 está entre ”” apenas, pois o valor é numérico, nesse caso do tipo float            */

                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Devolvido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
            AtualizaTabelaLivro();
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void AtualizaTabelaLivro()
        {
            string server = "";
            string baseBanco = "";
            try
            {
                using (StreamReader leitor1 = new StreamReader(Application.StartupPath + @"\Servidor.txt"))
                {
                    server = leitor1.ReadToEnd();
                }

                using (StreamReader leitor2 = new StreamReader(Application.StartupPath + @"\NomeBase.txt"))
                {
                    baseBanco = leitor2.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            try
            {

                string strcon = "Data Source=" + server + ";Initial Catalog=" + baseBanco + ";Integrated Security=True";
                SqlConnection conexao = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("UPDATE LIVROS SET STATUS = '' WHERE CODIGO_LIVRO = '" + codigoLivro + "'", conexao); /* Insere no banco dentro de tabela nos campos nome e número os valores de textBox1 e 4, é necessário colocar o replace no texBox4, pois se o numero tiver "," não irá inserir no banco de dados, a "," representa o próximo campo nessa sintaxe, experimente deixar sem o replace para ver o que acontece
                Obs. quando estamos inserindo, deletando, ou alterando um valor no banco de dados, é importante notar que o textbox1 está entre ‘””’ pois essa é sintaxe que usamos quando o valor é uma string, note também que o texbox2 está entre ”” apenas, pois o valor é numérico, nesse caso do tipo float            */

                conexao.Open();
                cmd.ExecuteNonQuery();


                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
        }
    }
}
