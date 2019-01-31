using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_01
{
    public partial class Lab01Form : Form
    {
        public Lab01Form()
        {
            InitializeComponent();
        }

        private void Lab01Form_Load(object sender, EventArgs e)
        {
            combustivelComboBox.DataSource = Enum.GetNames(typeof(Combustiveis));
            combustivelComboBox.SelectedIndex = -1;

            cambioComboBox.DataSource = Enum.GetNames(typeof(Cambios));
            cambioComboBox.SelectedIndex = -1;

            //AQUI É QUE VAMOS LER O NOSSO ARQUIVO
            marcaComboBox.Items.Clear();
            System.IO.StreamReader leitor = new System.IO.StreamReader(@"C:\Users\Bruno\Desktop\Marcas.txt");
            while (!leitor.EndOfStream)
            {
                marcaComboBox.Items.Add(leitor.ReadLine());
            }
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            try
            {
                Veiculo carro = new Veiculo(@"C:\Users\Bruno\Desktop\Cadastro de Veículos.txt");
                carro.Placa = placaTextBox.ValidarVazio().ValidarPlaca();
                carro.Modelo = modeloTextBox.ValidarVazio();
                carro.Cor = corTextBox.ValidarVazio();
                carro.Ano = anoTextBox.ValidarInt16().ValidarAno();
                carro.Marca = marcaComboBox.ValidarCombo();
                carro.Observacao = observacaoTextBox.Text;
                carro.Combustivel = (Combustiveis)combustivelComboBox.ValidarComboEnum();
                carro.Cambio = (Cambios)cambioComboBox.ValidarComboEnum();

                carro.Gravar();

                MessageBox.Show("Veiculo guardado com sucesso !!", "Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

                this.LimparTela();

                placaTextBox.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void observacaoTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                toquesLabel.Text = "Restante: " + (300 - observacaoTextBox.TextLength).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Lab01Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 27)
            {
                this.LimparTela();
            }

            if(e.KeyChar == 13)
            {
                gravarButton.PerformClick();
            }
        }
    }
}
