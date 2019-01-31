using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Biblioteca_Andreza
{
    class LoginClass
    {
         public string Usuario { get; set; }
         public string Senha { get; set; }

        public bool VerificaLogin()
        {
            
            bool resultado = false;
            string query = "SELECT * FROM LOGIN WHERE NOME = '" + Usuario + "' AND SENHA = '" + Senha + "'";
            ConfigurarServidorClass configurar = new ConfigurarServidorClass();
            string conecta = configurar.Conecta();
            try
            {
                SqlConnection conn = new SqlConnection(conecta);
                SqlCommand comando = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader dr = comando.ExecuteReader();
                resultado = dr.HasRows;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: "+ ex.Message,"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return resultado;
        }
    }
}
