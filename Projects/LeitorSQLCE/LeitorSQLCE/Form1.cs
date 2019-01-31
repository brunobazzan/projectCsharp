using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;

namespace LeitorSQLCE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void queryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void abrirABaseDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arquivoOpenFileDialog.Title = "Abrir arquivo";
            arquivoOpenFileDialog.FileName = "";
            arquivoOpenFileDialog.InitialDirectory = "C:\\";
            arquivoOpenFileDialog.Filter = "Arquivo SDF|*.sdf";
            if(arquivoOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                caminhotextBox1.Text = arquivoOpenFileDialog.FileName;
                AtualizaTabelas();
            }
        }

        private void executarButton_Click(object sender, EventArgs e)
        {
            try
            {
                string strQuery = queryTextBox.Text;
                string strConn = "Data Source= "+caminhotextBox1.Text;
                SqlCeConnection conn = new SqlCeConnection(strConn);
                SqlCeCommand comando = new SqlCeCommand(strQuery, conn);
                SqlCeDataAdapter da = new SqlCeDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                resultadoDataGridView.DataSource = dt;

                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void resultadoDataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.NumPad1)
            {
                executarButton.PerformClick();
            }
        }

        private void AtualizaTabelas()
        {
            try
            {
                string strQuery = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES";
                string strConn = "Data Source= " + caminhotextBox1.Text;
                SqlCeConnection conn = new SqlCeConnection(strConn);
                SqlCeCommand comando = new SqlCeCommand(strQuery, conn);
                SqlCeDataAdapter da = new SqlCeDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tabelaDataGridView.DataSource = dt;

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
