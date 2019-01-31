using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Biblioteca_eveline
{
    public class clienteClasse
    {
        //propriedades do metodo Cliente
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        //metodo gravar no banco de dados
        SqlCommand comando;
        SqlConnection conexao;
        SqlDataAdapter da;
        public void gravar()
        {
            //pegando o nome do servidor salvo no computador
            string server = "";
            string baseDados = "";
            try
            {
                using(StreamReader leitor1 = new StreamReader(Application.StartupPath + @"\Servidor.txt"))
                {
                    server = leitor1.ReadLine();
                }
                using(StreamReader leitor2 = new StreamReader(Application.StartupPath + @"\NomeBase.txt"))
                {
                    baseDados = leitor2.ReadLine();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: "+ ex.Message);
              
            }
            //-------------------------------------------------------------------------------------------------------------------------
            //fazendo a query de sql para efetuar um insert
            try
            {
                string strcon = "Data Source = " + server + "; Initial Catalog = " + baseDados + "; Integrated Security = True";
                conexao = new SqlConnection(strcon);
                comando = new SqlCommand("INSERT INTO LOCATARIOS (CODIGO_LOCATARIO,NOME_LOCATARIO,TELEFONE_LOCATARIO,ENDERECO_LOCATARIO,EMAIL_LOCATARIO) VALUES ('"+Codigo+"','"+Nome+"','"+Telefone+"','"+Endereco+"','"+Email+"') ",conexao);
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
    }
}
