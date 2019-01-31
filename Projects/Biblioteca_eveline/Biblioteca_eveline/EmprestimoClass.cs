using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;
using System.Windows.Forms;

namespace Biblioteca_eveline
{
    public class EmprestimoClass
    {
        //---------------------------------------------------
        public string codigoLocatario { get; set; }
        public string codigoLivro { get; set; }
        public string dataEnvio { get; set; }

        bool VerificaLivro()
        {
            //ESSE METODO VERIFICA A EXISTENCIA DO CODIGO DO LIVRO
            bool resultadoLivro = false;
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM LIVROS WHERE CODIGO_LIVRO = '"+ codigoLivro + "'", conexao); /* Insere no banco dentro de tabela nos campos nome e número os valores de textBox1 e 4, é necessário colocar o replace no texBox4, pois se o numero tiver "," não irá inserir no banco de dados, a "," representa o próximo campo nessa sintaxe, experimente deixar sem o replace para ver o que acontece
Obs. quando estamos inserindo, deletando, ou alterando um valor no banco de dados, é importante notar que o textbox1 está entre ‘””’ pois essa é sintaxe que usamos quando o valor é uma string, note também que o texbox2 está entre ”” apenas, pois o valor é numérico, nesse caso do tipo float            */

                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                resultadoLivro = dados.HasRows;
                conexao.Close();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
            return resultadoLivro;
        }

        bool ValidaDocumento()
        {
            //ESSE METODO VERIFICA A EXISTENCIA DO CODIGO DO LIVRO
            bool resultadoLocatario = false;
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM LOCATARIOS WHERE CODIGO_LOCATARIO = '" + codigoLocatario + "'", conexao); /* Insere no banco dentro de tabela nos campos nome e número os valores de textBox1 e 4, é necessário colocar o replace no texBox4, pois se o numero tiver "," não irá inserir no banco de dados, a "," representa o próximo campo nessa sintaxe, experimente deixar sem o replace para ver o que acontece
Obs. quando estamos inserindo, deletando, ou alterando um valor no banco de dados, é importante notar que o textbox1 está entre ‘””’ pois essa é sintaxe que usamos quando o valor é uma string, note também que o texbox2 está entre ”” apenas, pois o valor é numérico, nesse caso do tipo float            */

                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                resultadoLocatario = dados.HasRows;
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
            return resultadoLocatario;
        }
//-----------------------------------------------------------------------------------------------------------------------------------------------
        public void CadastrarTransacao()
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
                bool resultadoLivro = VerificaLivro();
                bool resultadoLocatario = ValidaDocumento();
                if (resultadoLivro && resultadoLocatario)
                {
                        string strcon = "Data Source=" + server + ";Initial Catalog=" + baseBanco + ";Integrated Security=True";
                        SqlConnection conexao = new SqlConnection(strcon);
                        SqlCommand cmd = new SqlCommand("INSERT INTO TRANSACAO (CODIGO_LIVRO, CODIGO_LOCATARIO, DATA_ENVIO) VALUES('" + codigoLivro + "','" + codigoLocatario + "','" + dataEnvio + "')", conexao); /* Insere no banco dentro de tabela nos campos nome e número os valores de textBox1 e 4, é necessário colocar o replace no texBox4, pois se o numero tiver "," não irá inserir no banco de dados, a "," representa o próximo campo nessa sintaxe, experimente deixar sem o replace para ver o que acontece
Obs. quando estamos inserindo, deletando, ou alterando um valor no banco de dados, é importante notar que o textbox1 está entre ‘””’ pois essa é sintaxe que usamos quando o valor é uma string, note também que o texbox2 está entre ”” apenas, pois o valor é numérico, nesse caso do tipo float            */

                        conexao.Open();
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                        MessageBox.Show("Cadastrado com sucesso!");
        
                }
                else
                {
                    MessageBox.Show("Livro ou Locatario não existe na base de dados","Aviso !",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public void AtualizaStatus()
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
                SqlCommand cmd = new SqlCommand("UPDATE LIVROS SET STATUS = 'LOCADO' WHERE CODIGO_LIVRO = '"+codigoLivro+"'", conexao); /* Insere no banco dentro de tabela nos campos nome e número os valores de textBox1 e 4, é necessário colocar o replace no texBox4, pois se o numero tiver "," não irá inserir no banco de dados, a "," representa o próximo campo nessa sintaxe, experimente deixar sem o replace para ver o que acontece
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
