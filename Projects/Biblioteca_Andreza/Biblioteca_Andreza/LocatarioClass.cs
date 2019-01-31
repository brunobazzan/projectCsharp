using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Biblioteca_Andreza
{
    class LocatarioClass
    {
        ConfigurarServidorClass servidor = new ConfigurarServidorClass();
        //Variaveis que vão receber 
        public string Documento { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public string Valor { get; set; }//CAMPO DINAMICO
        public string Campo { get; set; }//CAMPO DINAMICO

        //Metodos Necessarios

        //METODO DE GRAVAR LOCATARIOS
        public void Gravarlocatario()
        {
            string conecta = servidor.Conecta();
            string query = " INSERT INTO CLIENTES( ";
            query = query + " DOCUMENTO, ";
            query = query + " NOME, ";
            query = query + " ENDERECO, ";
            query = query + " BAIRRO, ";
            query = query + " TELEFONE, ";
            query = query + " EMAIL) ";

            query = query + " VALUES( ";
            query = query + " '"+Documento+"', ";
            query = query + " '" + Nome + "', ";
            query = query + " '" + Endereco + "', ";
            query = query + " '" + Bairro + "', ";
            query = query + " '" + Telefone + "', ";
            query = query + " '" + Email + "')";

            try
            {
                bool resultado = VerificaDocumento();
                if (resultado)
                {
                    MessageBox.Show("Documento existente na base", "Aviso !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlConnection conn = new SqlConnection(conecta);
                    SqlCommand comando = new SqlCommand(query, conn);
                    conn.Open();
                    comando.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Locatario incluido com suceso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Aviso !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //METODO DE DELETAR LOCATARIOS
        public void ExcluirLocatario()
        {
            bool resultado = VerificaDocumento();
            string conecta = servidor.Conecta();
            string query = "DELETE FROM CLIENTES WHERE DOCUMENTO = '"+Documento+"'";
            try
            {
                if (resultado)
                {
                    SqlConnection conn = new SqlConnection(conecta);
                    SqlCommand comando = new SqlCommand(query, conn);
                    conn.Open();
                    comando.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Locatario excluido com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Documento Inexistente na base", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message,"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        //METODO QUE VERIFICA A EXISTENCIA DE DOCUMENTOS 
        public bool VerificaDocumento()
        {
            string conecta = servidor.Conecta();
            bool resultado = false;
            try
            {
                string query = "SELECT * FROM CLIENTES WHERE DOCUMENTO = '" + Documento + "'";
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

        //MEOTODO QUE ATUALIZA LOCATARIO
        public void AtualizaLocatario()
        {
            string conecta = servidor.Conecta();
            string query = " UPDATE CLIENTES ";
            query = query + " SET "+Campo+" = '"+Valor+"' ";
            query = query + " WHERE DOCUMENTO = '" + Documento + "' ";
            try
            {
                SqlConnection conn = new SqlConnection(conecta);
                SqlCommand comando = new SqlCommand(query, conn);

                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Registro atualizado","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message,"Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
