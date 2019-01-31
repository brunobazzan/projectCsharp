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
    public partial class configurarBancoForm : Form
    {
        public configurarBancoForm()
        {
            InitializeComponent();
        }
        SqlConnection conexao;
        SqlCommand cmd;  //Insere no banco dentro de tabela nos campos nome e número os valores de textBox1 e 4, é necessário colocar o replace no texBox4, pois se o numero tiver "," não irá inserir no banco de dados, a "," representa o próximo campo nessa sintaxe, experimente deixar sem o replace para ver o que acontece
        SqlDataAdapter da;

        private void configurarButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Você deseja fazer uma nova configuração ?","Aviso",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    GravarConfiguracaoClasse gravar = new GravarConfiguracaoClasse();
                    string strcon = "Data Source= " + servidorTextBox.Text + "; Integrated Security = True";
                    string baseNome = baseTextBox.Text;
                    //populando o dataGridView
                    //Obs. quando estamos inserindo, deletando, ou alterando um valor no banco de dados, é importante notar que o textbox1 está entre ‘””’ pois essa é sintaxe que usamos quando o valor é uma string, note também que o texbox2 está entre ”” apenas, pois o valor é numérico, nesse caso do tipo float            */
                    string query = "IF EXISTS(SELECT * FROM SYS.DATABASES WHERE NAME = '"+baseNome+"') DROP DATABASE BASE CREATE DATABASE "+baseNome+"";
                    conexao = new SqlConnection(strcon);
                    cmd = new SqlCommand(query, conexao);
                    da = new SqlDataAdapter(cmd);

                    conexao.Open();
                    cmd.ExecuteNonQuery();
                    conexao.Close();

                    MessageBox.Show("DataBase criada com sucesso !","Sucesso!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    gravar.GravarConfig(servidorTextBox.Text, baseNome);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro " + ex.Message);
                    conexao.Close();
                }
            }
        }

        public void configurarBancoForm_Load(object sender, EventArgs e)
        {
            leitorDados();   
        }
        public void leitorDados()
        {
            try
            {
                //preenchendo o textbox do servidor
                using (StreamReader leitor1 = new StreamReader(Application.StartupPath + @"\Servidor.txt"))
                {
                    servidorTextBox.Text = leitor1.ReadLine();
                    leitor1.Close();
                }

                //preenchendo o textbox do database
                using (StreamReader leitor2 = new StreamReader(Application.StartupPath + @"\NomeBase.txt"))
                {
                    baseTextBox.Text = leitor2.ReadToEnd();
                    leitor2.Close();
                }
            }
            catch
            {
                MessageBox.Show("Tabelas não configuradas");
            }
        }

        private void bancoButton_Click(object sender, EventArgs e)
        {
            try
            {
                string conn = "Data Source = " + servidorTextBox.Text + ";Initial Catalog = " + baseTextBox.Text + ";Integrated Security = True";

                //primeira tabela USUARIOS
                string comando = " CREATE TABLE USUARIOS( ";
                comando = comando + " CODIGO_USUARIO VARCHAR(10) PRIMARY KEY, ";
                comando = comando + " NOME_USUARIO VARCHAR(50), ";
                comando = comando + " SENHA_USUARIO VARCHAR(10) ) ";

                //segunda tabela LOCATARIOS
                comando = comando + " CREATE TABLE LOCATARIOS( ";
                comando = comando + " CODIGO_LOCATARIO VARCHAR(20) PRIMARY KEY, ";
                comando = comando + " NOME_LOCATARIO VARCHAR(50), ";
                comando = comando + " TELEFONE_LOCATARIO VARCHAR(9), ";
                comando = comando + " ENDERECO_LOCATARIO VARCHAR(60), ";
                comando = comando + " EMAIL_LOCATARIO VARCHAR(40) ) ";

                //terceira tabela LIVROS        
                comando = comando + " CREATE TABLE LIVROS( ";
                comando = comando + " CODIGO_LIVRO VARCHAR(12) PRIMARY KEY, ";
                comando = comando + " NOME_LIVRO VARCHAR(50), ";
                comando = comando + " GENERO VARCHAR(20), ";
                comando = comando + " SUBGENERO VARCHAR(30), ";
                comando = comando + " SUBGENERO_2 VARCHAR(50), ";
                comando = comando + " AUTOR VARCHAR(50), ";
                comando = comando + " AUTOR_ESPIRITUAL VARCHAR(50), ";
                comando = comando + " EDITORA VARCHAR(30), ";
                comando = comando + " STATUS VARCHAR(7)) ";

                //quarta tabela TRANSACAO
                comando = comando + " CREATE TABLE TRANSACAO( ";
                comando = comando + " CODIGO_LIVRO VARCHAR(12), ";
                comando = comando + " CODIGO_LOCATARIO VARCHAR(20), ";
                comando = comando + " DATA_ENVIO VARCHAR(10), ";
                comando = comando + " DATA_ENTREGA VARCHAR(10) ) ";

                //TABELA DE AUTORES
                comando = comando + " CREATE TABLE AUTORES ( ";
                comando = comando + " CODIGO_AUTOR INT IDENTITY PRIMARY KEY, ";
                comando = comando + " NOME_AUTOR VARCHAR(50))";

                //TABELA DE AUTORES ESPIRITUAL
                comando = comando + " CREATE TABLE AUTOR_ESPIRITUAL( ";
                comando = comando + " CODIGO_AUTOR INT IDENTITY PRIMARY KEY, ";
                comando = comando + " NOME_AUTOR_ESPIRITAL VARCHAR(50)) ";


                conexao = new SqlConnection(conn);
                cmd = new SqlCommand(comando, conexao);
                da = new SqlDataAdapter(cmd);

                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("As tabelas foram configuradas com sucesso","Sucesso!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro:", ex.Message);
            }
        }
    }
}
