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
using System.Data.Sql;
using System.Data.SqlClient;

namespace Biblioteca_eveline
{
    public partial class ProcurarLocatarioForm : Form
    {
        public ProcurarLocatarioForm()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand comando;
        SqlDataAdapter da;
        DataTable dt;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void procurarButton_Click(object sender, EventArgs e)
        {
            string server = "";
            string baseDados = "";
            try
            {
                using (StreamReader leitor1 = new StreamReader(Application.StartupPath + @"\Servidor.txt"))
                {
                    server = leitor1.ReadLine();
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
            //-------------------------------------------------------------------------------------------------------------
            string strcon = "Data Source=" + server + ";Initial Catalog=" + baseDados + ";Integrated Security=True";
            try
            {
                if(itemTextBox.Text == "" || itensComboBox.Text == "")
                {
                    MessageBox.Show("Falta campos a serem completados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(itensComboBox.Text == "Documento")
                    {
                        conn = new SqlConnection(strcon);
                        comando = new SqlCommand("SELECT * FROM LOCATARIOS WHERE CODIGO_LOCATARIO LIKE '" + itemTextBox.Text + "%'", conn);
                        da = new SqlDataAdapter(comando);
                        dt = new DataTable();

                        da.Fill(dt);
                        dataGridView1.DataSource = dt;

                        conn.Open();
                        comando.ExecuteNonQuery();
                        conn.Close();

                    }

                    else if(itensComboBox.Text == "Nome")
                    {
                        conn = new SqlConnection(strcon);
                        comando = new SqlCommand("SELECT * FROM LOCATARIOS WHERE NOME_LOCATARIO LIKE '" + itemTextBox.Text + "%'", conn);
                        da = new SqlDataAdapter(comando);
                        dt = new DataTable();

                        da.Fill(dt);
                        dataGridView1.DataSource = dt;

                        conn.Open();
                        comando.ExecuteNonQuery();
                        conn.Close();

                    }
                    else if(itensComboBox.Text == "Telefone")
                    {
                        conn = new SqlConnection(strcon);
                        comando = new SqlCommand("SELECT * FROM LOCATARIOS WHERE TELEFONE_LOCATARIO LIKE '" + itemTextBox.Text + "%'", conn);
                        da = new SqlDataAdapter(comando);
                        dt = new DataTable();

                        da.Fill(dt);
                        dataGridView1.DataSource = dt;

                        conn.Open();
                        comando.ExecuteNonQuery();
                        conn.Close();

                    }
                    else if(itensComboBox.Text == "Endereço")
                    {
                        conn = new SqlConnection(strcon);
                        comando = new SqlCommand("SELECT * FROM LOCATARIOS WHERE ENDERECO_LOCATARIO LIKE '" + itemTextBox.Text + "%'", conn);
                        da = new SqlDataAdapter(comando);
                        dt = new DataTable();

                        da.Fill(dt);
                        dataGridView1.DataSource = dt;

                        conn.Open();
                        comando.ExecuteNonQuery();
                        conn.Close();

                    }
                    else if(itensComboBox.Text == "E-mail")
                    {
                        conn = new SqlConnection(strcon);
                        comando = new SqlCommand("SELECT * FROM LOCATARIOS WHERE EMAIL_LOCATARIO LIKE '" + itemTextBox.Text + "%'", conn);
                        da = new SqlDataAdapter(comando);
                        dt = new DataTable();

                        da.Fill(dt);
                        dataGridView1.DataSource = dt;

                        conn.Open();
                        comando.ExecuteNonQuery();
                        conn.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
    }
}
