using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace ANGELA_PROGRAMA
{
    class GravarContato
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }

        public void GravaContato()
        {
            string strConecta = "Data Source=" + Application.StartupPath + @"\Banco_dados.sdf";
            string comandoSQL = "INSERT INTO CONTATOS(NOME_CONTATO, ENDERECO_CONTATO, TEFEFONE_CONTATO, CELULAR_CONTATO,EMAIL_CONTATO, DATA_INCLUSAO) ";
            comandoSQL = comandoSQL + "VALUES('" + Nome + "','" + Endereco + "','" + Telefone + "','" + Celular + "','" + Email + "',GETDATE())";
            try
            {
                SqlCeConnection conn = new SqlCeConnection(strConecta);
                SqlCeCommand comando = new SqlCeCommand(comandoSQL, conn);

                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
