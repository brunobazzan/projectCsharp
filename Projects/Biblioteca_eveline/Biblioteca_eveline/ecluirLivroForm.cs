using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Biblioteca_eveline
{
    public partial class ecluirLivroForm : Form
    {
        public ecluirLivroForm()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void deletarButton_Click(object sender, EventArgs e)
        {
            string servidor = "";
            string baseDados = "";
            //lendo o nome do servidor de banco de dados
            try
            {
                using(StreamReader leitor1 = new StreamReader(Application.StartupPath + @"\Servidor.txt"))
                {
                    servidor = leitor1.ReadLine();
                }

                using (StreamReader leitor2 = new StreamReader(Application.StartupPath + @"\NomeBase.txt"))
                {
                    baseDados = leitor2.ReadLine();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }

            //parte da conexao de banco de dados
            try
            {
                if (codigoLivroTextBox.Text != "")
                {
                    string strcon = "Data Source="+ servidor +";Initial Catalog="+ baseDados +";Integrated Security=True";
                    conn = new SqlConnection(strcon);
                    cmd = new SqlCommand("DELETE FROM LIVROS WHERE CODIGO_LIVRO = '" + codigoLivroTextBox.Text+"'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Coloque o codigo do livro","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
    }
}
