using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;

namespace Biblioteca_eveline
{
    public partial class ExcluirLocatarioForm : Form
    {
        public ExcluirLocatarioForm()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand comando;

        private void excluirButton_Click(object sender, EventArgs e)
        {
            string servidor = "";
            string baseDados = "";
            try
            {
                using (StreamReader leitor1 = new StreamReader(Application.StartupPath + @"\Servidor.txt"))
                {
                    servidor = leitor1.ReadLine();
                }

                using (StreamReader leitor2 = new StreamReader(Application.StartupPath + @"\NomeBase.txt"))
                {
                    baseDados = leitor2.ReadLine();
                }
                //---------------------------------------------------------------------------------------------------------
                try
                {
                    if (documentoTextBox.Text != "")
                    {
                        string strcon = "Data Source=" + servidor + ";Initial Catalog=" + baseDados + ";Integrated Security=True";
                        conn = new SqlConnection(strcon);
                        comando = new SqlCommand("DELETE FROM LOCATARIOS WHERE CODIGO_LOCATARIO = '" + documentoTextBox.Text + "'", conn);
                        conn.Open();
                        comando.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Procedimento executado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("O campo documento não deve ser vazio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
