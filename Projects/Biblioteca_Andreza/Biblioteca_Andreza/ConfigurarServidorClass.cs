using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Biblioteca_Andreza
{
    class ConfigurarServidorClass
    {
        public string Servidor { get; set; }
        public string Banco { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }


        public void GravarServidorSemSenha()
        {
            if(File.Exists(Application.StartupPath+ @"\servidor.txt") == true)
            {
                File.Delete(Application.StartupPath + @"\servidor.txt");
            }

            using (StreamWriter escritor1 = new StreamWriter(Application.StartupPath + @"\servidor.txt",true))
            {
                escritor1.WriteLine("Data Source= "+Servidor+";DataBase= "+Banco+"; Integrated Security= True");
                escritor1.Close();
            }
        }

        public void GravarServidorComSenha()
        {
            if (File.Exists(Application.StartupPath + @"\servidor.txt") == true)
            {
                File.Delete(Application.StartupPath + @"\servidor.txt");
            }

            using (StreamWriter escritor2 = new StreamWriter(Application.StartupPath + @"\servidor.txt", true))
            {
                escritor2.WriteLine("Data Source = " + Servidor + ";DataBase= " + Banco + ";User ID="+Usuario+"; Password="+Senha);
                escritor2.Close();
            }
        }

        public void ConfiguraServidor()
        {
            try
            {
                string conecta = "Data Source= " + Servidor + ";Integrated Security= True";
                string query = " CREATE DATABASE " + Banco + " ";
                SqlConnection conn = new SqlConnection(conecta);
                SqlCommand comando = new SqlCommand(query, conn);

                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //METODO QUE CONFIGURA  AS TABELAS NO SQL SERVER
        public void ConfiguraTabelas()
        {
            //CLIENTE
            string query = " CREATE TABLE CLIENTES( ";
            query = query + " DOCUMENTO  VARCHAR(500) NOT NULL PRIMARY KEY,";
            query = query + " NOME VARCHAR(500), ";
            query = query + " ENDERECO VARCHAR(500), ";
            query = query + " BAIRRO VARCHAR(300), ";
            query = query + " TELEFONE VARCHAR(200), ";
            query = query + " EMAIL VARCHAR(400) )";

            //LIVROS
            query = query + " CREATE TABLE LIVROS( ";
            query = query + " CODIGO VARCHAR(50) NOT NULL PRIMARY KEY, ";
            query = query + " TITULO VARCHAR(500), ";
            query = query + " AUTORES VARCHAR(500), ";
            query = query + " GENERO VARCHAR(200), ";
            query = query + " EDITORA VARCHAR(200), ";
            query = query + " STATUS VARCHAR(200) ) ";

            //EMPRESTIMO
            query = query + " CREATE TABLE EMPRESTIMO( ";
            query = query + " CODIGO VARCHAR(50) NOT NULL, ";
            query = query + " DOCUMENTO VARCHAR(50) NOT NULL, ";
            query = query + " DATA_EMPRESTIMO DATETIME, ";
            query = query + " DATA_DEVOLUCAO DATETIME) ";

            //LOGIN
            query = query + " CREATE TABLE LOGIN( ";
            query = query + " NOME VARCHAR(20), ";
            query = query + " SENHA VARCHAR(20)) ";

            query = query + " INSERT INTO LOGIN(NOME,SENHA) VALUES ('USUARIO','USUARIO')";


            try
            {
                SqlConnection conn = new SqlConnection(Conecta());
                SqlCommand comando = new SqlCommand(query, conn);

                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Servidor e banco de dados configurados com sucesso!", "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: "+ ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //METODO QUE PEGA A STRING DE CONEXAO 
        public string Conecta()
        {
            string conexaoBanco;
            using(StreamReader leitor = new StreamReader(Application.StartupPath + @"\servidor.txt"))
            {
                conexaoBanco = leitor.ReadToEnd();
            }
            return conexaoBanco;
        }

    }
}
