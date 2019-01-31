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
    public partial class telaClientesForm : Form
    {
        public telaClientesForm()
        {
            InitializeComponent();
        }
        SqlCommand comando;
        SqlConnection conexao;
        SqlDataAdapter da;
        DataTable dt;
        private void cadastrarLocatarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarClientesForm form = new CadastrarClientesForm();
            form.ShowDialog();
        }

        public void AtualizaDatagrid()
        {
            string server = "";
            string baseDados = "";
            try
            {
                using (StreamReader leito1 = new StreamReader(Application.StartupPath + @"\Servidor.txt"))
                {
                    server = leito1.ReadLine();
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
            //-------------------------------------------------------------------------------------------------------

            try
            {

                string strcon = "Data Source=" + server + ";Initial Catalog=" + baseDados + ";Integrated Security=True";
                conexao = new SqlConnection(strcon);
                comando = new SqlCommand("SELECT * FROM LOCATARIOS", conexao);
                da = new SqlDataAdapter(comando);
                dt = new DataTable();

                da.Fill(dt);
                mostraDataGridView.DataSource = dt;
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        private void telaClientesForm_Load(object sender, EventArgs e)
        {
            AtualizaDatagrid();

            ConfiguraGrid();
        }

        public void ConfiguraGrid()
        {
            try
            {
                mostraDataGridView.Columns[0].HeaderText = "Codigo do locatario";
                mostraDataGridView.Columns[1].HeaderText = "Nome do locatario";
                mostraDataGridView.Columns[2].HeaderText = "Telefone de contato";
                mostraDataGridView.Columns[3].HeaderText = "Endereço";
                mostraDataGridView.Columns[4].HeaderText = "E-mail";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        private void atualizarButton_Click(object sender, EventArgs e)
        {
            AtualizaDatagrid();
        }

        private void procurarLocatariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcurarLocatarioForm form = new ProcurarLocatarioForm();
            form.Show();
        }

        private void excluirLocatarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcluirLocatarioForm form = new ExcluirLocatarioForm();
            form.Show();
        }
    }
}
