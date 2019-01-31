using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace ANGELA_PROGRAMA
{
    class ApagaContato
    {
        public string Nome { get; set; }
        public void ApagaContatoSql()
        {
            string strConecta = "Data Source=" + Application.StartupPath + @"\Banco_dados.sdf";
            string comandoSQL = "DELETE FROM CONTATOS";
            try
            {
                SqlCeConnection conecta = new SqlCeConnection(strConecta);
                SqlCeCommand comando = new SqlCeCommand(comandoSQL, conecta);
                conecta.Open();
                comando.ExecuteNonQuery();
                conecta.Close();
                MessageBox.Show("Todos os contatos foram apagados com sucesso");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }
        public void ApagaRegistro()
        {
            string strConecta = "Data Source=" + Application.StartupPath + @"\Banco_dados.sdf";
            string comandoSQL = "DELETE FROM CONTATOS WHERE NOME_CONTATO = '"+Nome+"'";
            try
            {
                
                SqlCeConnection conecta = new SqlCeConnection(strConecta);
                SqlCeCommand comando = new SqlCeCommand(comandoSQL, conecta);
                conecta.Open();
                comando.ExecuteNonQuery();
                conecta.Close();
                MessageBox.Show("Registro excluido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }
    }
}
