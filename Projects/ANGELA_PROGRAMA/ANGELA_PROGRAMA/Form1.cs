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


namespace ANGELA_PROGRAMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            //botao usado para gravar os contatos 
            GravarContato grava = new GravarContato();
            grava.Nome = nomeTextBox.Text.Trim();
            grava.Endereco = enderecoTextBox.Text.Trim();
            grava.Email = emailTextBox.Text.Trim();
            grava.Telefone = telefoneTextBox.Text.Trim();
            grava.Celular = celularTextBox.Text.Trim();
            grava.GravaContato();
            AtualizaDataGrid();
            LimpaCampo();
        }

        private void configurarBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voce deseja configurar um novo banco de contatos?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                ConfiguraBanco configurarBanco = new ConfiguraBanco();
                configurarBanco.ConfiguraBancoDados();
            }
        }
        public void AtualizaDataGrid()
        {
            string strConecta = "Data Source=" + Application.StartupPath + @"\Banco_dados.sdf";
            string comandoSQL = "SELECT * FROM CONTATOS";
            try
            {
                SqlCeConnection conecta = new SqlCeConnection(strConecta);
                SqlCeCommand comando = new SqlCeCommand(comandoSQL, conecta);
                SqlCeDataAdapter da = new SqlCeDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                mostraDataGridView.DataSource = dt;

                conecta.Open();
                comando.ExecuteNonQuery();
                conecta.Close();
                CamposDataGridView();

            }catch(Exception ex)
            {
               if(MessageBox.Show("Você deseja configurar um novo banco de contatos?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    ConfiguraBanco configura = new ConfiguraBanco();
                    configura.ConfiguraBancoDados();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizaDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void CamposDataGridView()
        {
            mostraDataGridView.Columns[0].HeaderText = "Nome";
            mostraDataGridView.Columns[1].HeaderText = "Endereço";
            mostraDataGridView.Columns[2].HeaderText = "Telefone";
            mostraDataGridView.Columns[3].HeaderText = "Celular";
            mostraDataGridView.Columns[4].HeaderText = "E-mail";
            mostraDataGridView.Columns[5].HeaderText = "Data de inclusao";
        }

        private void mostraDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void excluirContatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletarContato deletar = new DeletarContato();
            deletar.ShowDialog();
        }

        private void atualizarButton_Click(object sender, EventArgs e)
        {
            AtualizaDataGrid();
        }
        public void LimpaCampo()
        {
            nomeTextBox.Text = "";
            enderecoTextBox.Text = "";
            celularTextBox.Text = "";
            emailTextBox.Text = "";
            telefoneTextBox.Text = "";
        }

        private void excluirTodosOsContatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja apagar todos os contatos dessa base? \nNota: os contatos não serão mais recuperados", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                ApagaContato apaga = new ApagaContato();
                apaga.ApagaContatoSql();
                AtualizaDataGrid();
            }
        }
    }
}
