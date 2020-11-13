using System;
using System.Data;
using Microsoft.SqlServer.Dts.Runtime;
using System.Windows.Forms;
using System.IO;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ClasseImportaArquivo.csproj
{
    public partial class ScriptMain : ImportaArquivo 
    {
        public void Main()
        {
            string caminho;
            string conexao;
            int counter = 0;  
            string line;  

            conexao = "string de conexao do seu banco de dados";
            caminho = @"caminho do seu arquivo.csv\.txt";

            SqlConnection conn = new SqlConnection(conexao);
            conn.Open();
            StreamReader file = new System.IO.StreamReader(caminho);
            while ((line = file.ReadLine()) != null)
            {
                SqlCommand comando = new SqlCommand(line, conn);
                comando.ExecuteNonQuery();

                counter++;
            }
            file.Close(); 
            conn.Close();
            Dts.TaskResult = (int)ScriptResults.Success;
        }
    }
}
