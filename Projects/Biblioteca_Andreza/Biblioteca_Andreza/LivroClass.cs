using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;

namespace Biblioteca_Andreza
{
    class LivroClass:LocatarioClass
    {
        //Variaveis necessarias
        public string Codigo { get; set; }
        public string Titulo { get; set; }
        public string Autores { get; set; }
        public string Genero { get; set; }
        public string Editora { get; set; }

        public string Valor { get; set; }
        public string Campo { get; set; }

        //string de conexão
        ConfigurarServidorClass servidor = new ConfigurarServidorClass();

        //METODO PARA VERIFICAR EXISTENCIA DO LIVRO
        private bool VerificaCodigo()
        {
            string conecta = servidor.Conecta();
            bool resultado = false;
            try
            {
                string query = "SELECT * FROM LIVROS WHERE CODIGO = '" + Codigo + "'";
                SqlConnection conn = new SqlConnection(conecta);
                SqlCommand comando = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader da = comando.ExecuteReader();
                resultado = da.HasRows;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Aviso !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;
        }

        // METODO QUE VERIFICA SE O LIVRO ESTA LIVRE, CASO O LIVRO ESTEJA LIVRE VAI SER LOCADO
        private bool VerificaLocado()
        {
            string conecta = servidor.Conecta();
            bool resultado = false;
            try
            {
                string query = "SELECT * FROM LIVROS WHERE CODIGO = '" + Codigo + "' AND (STATUS = '' OR STATUS IS NULL)";
                SqlConnection conn = new SqlConnection(conecta);
                SqlCommand comando = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader da = comando.ExecuteReader();
                resultado = da.HasRows;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Aviso !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;
        }

        //METODO PARA GRAVAR NOVO LIVRO
        public void GravarLivro()
        {
            string conecta = servidor.Conecta();
            bool resultado = VerificaCodigo();
            try
            {
                if (resultado)
                {
                    MessageBox.Show("Codigo existente na base","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
                else
                {
                    string query = "INSERT INTO LIVROS(";
                    query = query + " CODIGO, ";
                    query = query + " TITULO, ";
                    query = query + " AUTORES, ";
                    query = query + " GENERO, ";
                    query = query + " EDITORA ) ";

                    query = query + " VALUES( ";
                    query = query + " '" + Codigo + "', ";
                    query = query + " '" + Titulo + "', ";
                    query = query + " '" + Autores + "', ";
                    query = query + " '" + Genero + "', ";
                    query = query + " '" + Editora + "' )";

                    SqlConnection conn = new SqlConnection(conecta);
                    SqlCommand comando = new SqlCommand(query, conn);
                    conn.Open();
                    comando.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Livro gravado com sucesso!", "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //METODO QUE DELETA O LIVRO
        public void DeletarLivro()
        {
            string conecta = servidor.Conecta();
            string query = "DELETE FROM LIVROS WHERE CODIGO = '" + Codigo + "'";
            bool resultado = VerificaCodigo();
            try
            {
                if (resultado)
                {
                    SqlConnection conn = new SqlConnection(conecta);
                    SqlCommand comando = new SqlCommand(query,conn);
                    conn.Open();
                    comando.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Livro deletado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Codigo Inexistente na base", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Aviso !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //METODO QUE GRAVA A TRANSAÇÃO DE EMPRESTIMO
        public void GravarTransacaoEmprestimo()
        {
            string conecta = servidor.Conecta();
            //antes de executar o insert vamos verificar a existencia dos dados
            bool resultado1 = VerificaCodigo();//existencia do livro
            bool resultado2 = VerificaDocumento(); //existencia do cliente
            bool resultado3 = VerificaLocado(); // se o livro foi locado
            try
            {
                    if (resultado1)//vai verificar a existencia do livro
                    {
                    if (resultado2) //verifica a existencia do documento
                    {
                        if (resultado3) //verifica se o livro esta disponivel
                        {

                            string query = " INSERT INTO EMPRESTIMO( ";
                            query = query + " CODIGO, ";
                            query = query + " DOCUMENTO, ";
                            query = query + " DATA_EMPRESTIMO )";

                            query = query + " VALUES( ";
                            query = query + " '" + Codigo + "', ";
                            query = query + " '" + Documento + "', ";
                            query = query + " GETDATE() ) ";

                            SqlConnection conn = new SqlConnection(conecta);
                            SqlCommand comando = new SqlCommand(query, conn);
                            conn.Open();
                            comando.ExecuteNonQuery();
                            conn.Close();

                            //chama o metodo que atualiza o status do livro como locado
                            AtualizaStatusLocado();

                            //mensagem para dizer que o livro foi emprestado com sucesso !
                            MessageBox.Show("Emprestado com sucesso !", "Sucesso !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Livro ja foi emprestado.\n Pesquise os livros disponiveis.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Documento não consta na base de dados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    }
                    else
                    {
                        MessageBox.Show("Livro não consta na base de dados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Aviso !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //METODO QUE GRAVA A DEVOLUCAO DO LIVRO
        public void GravarTransacaoDevolucao()
        {
            string conecta = servidor.Conecta();
            try
            {
                string query = " UPDATE EMPRESTIMO ";
                query = query + " SET DATA_DEVOLUCAO = GETDATE() ";
                query = query + " WHERE CODIGO = '" + Codigo + "' ";
                query = query + " AND DATA_DEVOLUCAO IS NULL ";
                query = query + " OR DATA_DEVOLUCAO = '' ";

                SqlConnection conn = new SqlConnection(conecta);
                SqlCommand comando = new SqlCommand(query, conn);

                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();

                //CHAMA O METODO PARA LIBERAR O LIVRO
                AtualizaStatusLivre();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        //o metoodo que atualiza o status do livro
        private void AtualizaStatusLocado()
        {
            string conecta = servidor.Conecta();
            try
            {
                string query = " UPDATE LIVROS ";
                query = query + " SET STATUS = 'LOCADO' ";
                query = query + " WHERE CODIGO = '" + Codigo + "' ";

                SqlConnection conn = new SqlConnection(conecta);
                SqlCommand comando = new SqlCommand(query, conn);

                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //metodo que atualiza o status como livre pra locar 
        private void AtualizaStatusLivre()
        {
            string conecta = servidor.Conecta();
            try
            {
                string query = " UPDATE LIVROS ";
                query = query + " SET STATUS = NULL ";
                query = query + " WHERE CODIGO = '" + Codigo + "' ";

                SqlConnection conn = new SqlConnection(conecta);
                SqlCommand comando = new SqlCommand(query, conn);

                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void AtualizaLivro()
        {
            string conecta = servidor.Conecta();
            try
            {
                string query = " UPDATE LIVROS ";
                query = query + " SET "+Campo+" = '"+Valor+"' ";
                query = query + " WHERE CODIGO = '" + Codigo + "' ";

                SqlConnection conn = new SqlConnection(conecta);
                SqlCommand comando = new SqlCommand(query, conn);

                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
