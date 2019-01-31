using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Biblioteca_eveline
{
    public class livrosClasse
    {
        //Campos que fazem parte do livros 
        public string Codigo { get; set; }
        public string Genero { get; set; }
        public string SubGenero { get; set; }
        public string SubGenero2 { get; set; }
        public string Autor { get; set; }
        public string Autor_Espiritual { get; set; }
        public string Titulo { get; set; }
        public string Editora { get; set; }
        public string Numero { get; set; }

        //Campo que pertence ao form autores 
        public string Nome_autor { get; set; } 

        //Campo que pertence ao form autores espirituais  
        public string Nome_autor_espiritual { get; set; }

        public void GravarLivro()
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
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            try
            {

            string strcon = "Data Source="+server+";Initial Catalog="+baseBanco+";Integrated Security=True";
            SqlConnection conexao = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("INSERT INTO LIVROS(CODIGO_LIVRO,NOME_LIVRO,GENERO,SUBGENERO,SUBGENERO_2,AUTOR,AUTOR_ESPIRITUAL,EDITORA) VALUES('" + Codigo + "','" + Titulo + "','" + Genero + "','" + SubGenero + "','" + SubGenero2 + "','"+ Autor +"','"+ Autor_Espiritual +"','" + Editora + "')", conexao); /* Insere no banco dentro de tabela nos campos nome e número os valores de textBox1 e 4, é necessário colocar o replace no texBox4, pois se o numero tiver "," não irá inserir no banco de dados, a "," representa o próximo campo nessa sintaxe, experimente deixar sem o replace para ver o que acontece
Obs. quando estamos inserindo, deletando, ou alterando um valor no banco de dados, é importante notar que o textbox1 está entre ‘””’ pois essa é sintaxe que usamos quando o valor é uma string, note também que o texbox2 está entre ”” apenas, pois o valor é numérico, nesse caso do tipo float            */
            
                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Gravado com Sucesso!");
            }
            catch (SqlException sql)
            {
                MessageBox.Show("Não pode inserir codigos iguais no banco de dados" + sql);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }       
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------
        public void Gravar_Autor()
        {
            //Essa metodo vai gravar o autor na tabela de AUTORES
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
                SqlCommand cmd = new SqlCommand("INSERT INTO AUTORES(NOME_AUTOR) VALUES('" + Nome_autor + "')", conexao); /* Insere no banco dentro de tabela nos campos nome e número os valores de textBox1 e 4, é necessário colocar o replace no texBox4, pois se o numero tiver "," não irá inserir no banco de dados, a "," representa o próximo campo nessa sintaxe, experimente deixar sem o replace para ver o que acontece
Obs. quando estamos inserindo, deletando, ou alterando um valor no banco de dados, é importante notar que o textbox1 está entre ‘””’ pois essa é sintaxe que usamos quando o valor é uma string, note também que o texbox2 está entre ”” apenas, pois o valor é numérico, nesse caso do tipo float            */

                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Gravado com Sucesso!");
            }
            catch (SqlException sql)
            {
                MessageBox.Show("Não pode inserir codigos iguais no banco de dados" + sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        public void Gravar_Autor_Espiritual()
        {
            //Essa metodo vai gravar o autor na tabela de AUTORES ESPIRITUAIS
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
                SqlCommand cmd = new SqlCommand("INSERT INTO AUTOR_ESPIRITUAL(NOME_AUTOR_ESPIRITUAL) VALUES('" + Nome_autor_espiritual + "')", conexao); /* Insere no banco dentro de tabela nos campos nome e número os valores de textBox1 e 4, é necessário colocar o replace no texBox4, pois se o numero tiver "," não irá inserir no banco de dados, a "," representa o próximo campo nessa sintaxe, experimente deixar sem o replace para ver o que acontece
Obs. quando estamos inserindo, deletando, ou alterando um valor no banco de dados, é importante notar que o textbox1 está entre ‘””’ pois essa é sintaxe que usamos quando o valor é uma string, note também que o texbox2 está entre ”” apenas, pois o valor é numérico, nesse caso do tipo float            */

                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Gravado com Sucesso!");
            }
            catch (SqlException sql)
            {
                MessageBox.Show("Não pode inserir codigos iguais no banco de dados" + sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
    }
}
