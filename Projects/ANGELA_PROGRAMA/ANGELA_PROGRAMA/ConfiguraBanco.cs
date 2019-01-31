using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using System.IO;

namespace ANGELA_PROGRAMA
{
    class ConfiguraBanco
    {
        public void ConfiguraBancoDados()
        {
            if (File.Exists(Application.StartupPath + @"\Banco_dados.sdf"))
            {
                File.Delete(Application.StartupPath + @"\Banco_dados.sdf");
            }
            try
            {
                string strConecta = "Data Source=" + Application.StartupPath + @"\Banco_dados.sdf";

                string comando = "CREATE TABLE CONTATOS( ";
                comando = comando + " NOME_CONTATO NVARCHAR(500), ";
                comando = comando + " ENDERECO_CONTATO NVARCHAR(500), ";
                comando = comando + " TEFEFONE_CONTATO NVARCHAR(100), ";
                comando = comando + " CELULAR_CONTATO NVARCHAR(100), ";
                comando = comando + " EMAIL_CONTATO NVARCHAR(500), ";
                comando = comando + " DATA_INCLUSAO DATETIME  )";

                //cria o banco de dados da onde esta sendo executado a aplicação
                SqlCeEngine motor = new SqlCeEngine(strConecta);
                motor.CreateDatabase();

                //criando as tabelas
                SqlCeConnection conn = new SqlCeConnection(strConecta);
                conn.Open();
                SqlCeCommand comandoSQL = new SqlCeCommand(comando, conn);
                comandoSQL.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data base configurada com sucesso");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }
    }
}
