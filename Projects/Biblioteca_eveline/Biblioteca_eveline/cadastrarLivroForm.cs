using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;

namespace Biblioteca_eveline
{
    public partial class cadastrarLivroForm : Form
    {
        public cadastrarLivroForm()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            
            //combobox de GENERALIDADE0
            if(comboBox1.Text == "GENERALIDADE")
            {
                comboBox2.Items.Add("REFERENCIA");
                comboBox2.Items.Add("COLEÇÃO");
            }

            //combobox de RELIGIÃO
            else if (comboBox1.Text == "RELIGIÃO")
            {
                comboBox2.Items.Add("Vidas de Jesus");
                comboBox2.Items.Add("Jesus e os Apostolos");
                comboBox2.Items.Add("Estudo dos Evangelhos");
                comboBox2.Items.Add("CRISTIANISMO");
            }

            //combobox de CIENCIA
            else if(comboBox1.Text == "CIÊNCIA")
            {
                comboBox2.Items.Add("Sobrevivencia, natureza do mundo espiritual e vida apos a morte");
                comboBox2.Items.Add("Reencarnação");
                comboBox2.Items.Add("Mediunidade");
                comboBox2.Items.Add("Projeção Astral(experiencia fora do corpo)");
                comboBox2.Items.Add("Sonhos e misterios");
                comboBox2.Items.Add("Metapsiquica");
                comboBox2.Items.Add("Parapsicologia");
                comboBox2.Items.Add("Hipnotismo");
            }

            //combobox EVENTOS
            else if(comboBox1.Text == "EVENTO")
            {
                comboBox2.Items.Add("Congresso");
                comboBox2.Items.Add("Encontro");
                comboBox2.Items.Add("Seminario");
                comboBox2.Items.Add("Curso");
            }

            //combobox MOVIMENTO ESPIRITA
            else if (comboBox1.Text == "MOVIMENTO ESPÍRITA")
            {
                comboBox2.Items.Add("Orientação Manual");
                comboBox2.Items.Add("Campanha");
            }

            //combobox ATIVIDADES INSTITUCIONAIS
            else if(comboBox1.Text == "ATIVIDADES INSTITUCIONAIS")
            {
                comboBox2.Items.Add("Estatuto");
                comboBox2.Items.Add("Relatorio");
                comboBox2.Items.Add("Plano de Ação. Plano de Trabalho. Planejamento");
                comboBox2.Items.Add("Projeto");
            }

            //combobox EDUCAÇÃO
            else if(comboBox1.Text == "EDUCAÇÃO")
            {
                comboBox2.Items.Add("Evagelização Espirita Infanto Juvenil");
                comboBox2.Items.Add("Estudo sistematizado da doutrina espirita");
                comboBox2.Items.Add("Estudo e educação da Mediunidade");
                comboBox2.Items.Add("Estudo e aprofundado do espiritismo");
                comboBox2.Items.Add("Material de apoio");
            }

            //combobox ARTE. COMUNICAÇÃO
            else if(comboBox1.Text == "ARTE. COMUNICAÇÃO")
            {
                comboBox2.Items.Add("Musica");
                comboBox2.Items.Add("Teatro");
                comboBox2.Items.Add("Cinema");
                comboBox2.Items.Add("Televisão");
                comboBox2.Items.Add("Radio");
                comboBox2.Items.Add("Imprensa");
                comboBox2.Items.Add("Internet");
            }

            //combobox LITERATURA
            else if(comboBox1.Text == "LITERATURA")
            {
                comboBox2.Items.Add("Conto. Cronica");
                comboBox2.Items.Add("Romance");
                comboBox2.Items.Add("Mensagem");
                comboBox2.Items.Add("Poema");
            }

            //combobox LITERATURA EM OUTROS IDIOMAS
            else if(comboBox1.Text == "LITERATURA EM OUTROS IDIOMAS")
            {
                comboBox2.Items.Add("Esperanto");
                comboBox2.Items.Add("Espanhol");
                comboBox2.Items.Add("Frances");
                comboBox2.Items.Add("Ingles");
                comboBox2.Items.Add("Alemão");
                comboBox2.Items.Add("Italiano");
                comboBox2.Items.Add("Russo");
                comboBox2.Items.Add("Hungaro");
            }

            //combobox HISTÓRIA. BIOGRAFIA
            else if(comboBox1.Text == "HISTÓRIA. BIOGRAFIA")
            {
                comboBox2.Items.Add("Historia");
                comboBox2.Items.Add("Biografia");
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cadastrarLivroForm_Load(object sender, EventArgs e)
        {
            comboBox4.Items.Add("Escolha o autor");
            #region combobox4
            //Vamos puxar as informações a partir do combobox
            // string de conexao
            string server = "";
            string baseBanco = "";
            try
            {
                using (StreamReader leitor1 = new StreamReader(Application.StartupPath + @"\Servidor.txt"))
                {
                    server = leitor1.ReadToEnd();
                }

                using (StreamReader leitor2 = new StreamReader(Application.StartupPath + @"\NomeBase.txt"))
                {
                    baseBanco = leitor2.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            try
            {

                // sua consulta
                string strcon = "Data Source=" + server + ";Initial Catalog=" + baseBanco + ";Integrated Security=True";
                SqlConnection conexao = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("SELECT NOME_AUTOR FROM AUTORES", conexao);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                da.Fill(ds);

                BindingSource bs = new BindingSource();
                bs.DataSource = ds;


                comboBox4.DisplayMember= "nome_autor";
                comboBox4.DataSource = ds;

                comboBox4.Refresh();

                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            #endregion
            //--------------------------------------------------------------------
            #region combobox5
            //Vamos puxar as informações a partir do combobox
            // string de conexao
            try
            {
                using (StreamReader leitor1 = new StreamReader(Application.StartupPath + @"\Servidor.txt"))
                {
                    server = leitor1.ReadToEnd();
                }

                using (StreamReader leitor2 = new StreamReader(Application.StartupPath + @"\NomeBase.txt"))
                {
                    baseBanco = leitor2.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            try
            {
                
                // sua consulta
                string strcon = "Data Source=" + server + ";Initial Catalog=" + baseBanco + ";Integrated Security=True";
                SqlConnection conexao = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("SELECT NOME_AUTOR_ESPIRITAL FROM AUTOR_ESPIRITUAL", conexao);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                da.Fill(ds);

                BindingSource bs = new BindingSource();
                bs.DataSource = ds;

                comboBox5.Items.Add("Escolha o autor espiritual");
                comboBox5.DisplayMember = "NOME_AUTOR_ESPIRITAL";
                comboBox5.DataSource = ds;

                comboBox5.Refresh();

                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            #endregion
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            //GENERALIDADE
            if (comboBox2.Text == "REFERENCIA")
            {
                comboBox3.Items.Add("Almanaque");
                comboBox3.Items.Add("Atlas");
                comboBox3.Items.Add("Bibliografia");
                comboBox3.Items.Add("Catalogo");
                comboBox3.Items.Add("Dicionario/Grossario");
                comboBox3.Items.Add("Enciclopedia");
                comboBox3.Items.Add("Guia/Manual");
                comboBox3.Items.Add("Repertorio/Inventario/Diretorio");
                comboBox3.Items.Add("Indice/Vocabulario/Tesauro");
            }

            //GENERALIDADE
            else if (comboBox2.Text == "COLEÇÃO")
            {
                comboBox3.Items.Add("Obras de Allan Kardec");
                comboBox3.Items.Add("Coleção Andre Luiz");
                comboBox3.Items.Add("Serie Psicologica Joanna de Angelis");
            }

            //RELIGIÃO
            else if(comboBox2.Text == "Estudo dos Evangelhos")
            {
                comboBox3.Items.Add("Parabolas Evangelicas");
            }

            //MEDIUNIDADE
            else if(comboBox2.Text == "Mediunidade")
            {
                comboBox3.Items.Add("Fenomenos Mediunicos Especifico");
                comboBox3.Items.Add("Animismo");
                comboBox3.Items.Add("FluidoTerapia/Tratamento");
                comboBox3.Items.Add("Reunião Mediunica");
            }
            //EVENTOS
            else if(comboBox2.Text == "Congresso"|| comboBox2.Text == "Encontro" || comboBox2.Text == "Seminario" || comboBox2.Text == "Curso")
            {
                comboBox3.Items.Add("Anais");
            }

            //MOVIMENTO ESPIRITA
            else if (comboBox2.Text == "Orientação Manual")
            {
                comboBox3.Items.Add("Centro Espirita");
                comboBox3.Items.Add("Serviço de Assistência e Promoção Social");
                comboBox3.Items.Add("Biblioteca espirita");
            }
             else if(comboBox2.Text == "Campanha")
            {
                comboBox3.Items.Add("Campanha de defesa da vida");
                comboBox3.Items.Add("Campanha viver em Familia");
                comboBox3.Items.Add("Campanha construamos a Paz, Promovendo o bem");

            }
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void editoraTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            //chamando a classe do codigoLivro
            livrosClasse codigoLivro = new livrosClasse();

            if (comboBox1.Text == "")
            {
                MessageBox.Show("O campo inicial esta faltando","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else {
                //construindo uma string para GENERALIDADE
                #region GENERALIDADE 
                if (comboBox1.Text == "GENERALIDADE" && comboBox2.Text == "" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "00.00.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "GENERALIDADE" && comboBox2.Text == "REFERENCIA" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "00.05.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "GENERALIDADE" && comboBox2.Text == "REFERENCIA" && comboBox3.Text == "Almanaque")
                {
                    codigoLivro.Codigo = "00.05.01." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "GENERALIDADE" && comboBox2.Text == "REFERENCIA" && comboBox3.Text == "Atlas")
                {
                    codigoLivro.Codigo = "00.05.02." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "GENERALIDADE" && comboBox2.Text == "REFERENCIA" && comboBox3.Text == "Bibliografia")
                {
                    codigoLivro.Codigo = "00.05.03." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "GENERALIDADE" && comboBox2.Text == "REFERENCIA" && comboBox3.Text == "Catalogo")
                {
                    codigoLivro.Codigo = "00.05.04." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "GENERALIDADE" && comboBox2.Text == "REFERENCIA" && comboBox3.Text == "Dicionario/Grossario")
                {
                    codigoLivro.Codigo = "00.05.05." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "GENERALIDADE" && comboBox2.Text == "REFERENCIA" && comboBox3.Text == "Enciclopedia")
                {
                    codigoLivro.Codigo = "00.05.06." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "GENERALIDADE" && comboBox2.Text == "REFERENCIA" && comboBox3.Text == "Guia/Manual")
                {
                    codigoLivro.Codigo = "00.05.07." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "GENERALIDADE" && comboBox2.Text == "REFERENCIA" && comboBox3.Text == "Repertorio/Inventario/Diretorio")
                {
                    codigoLivro.Codigo = "00.05.08." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "GENERALIDADE" && comboBox2.Text == "REFERENCIA" && comboBox3.Text == "Indice/Vocabulario/Tesauro")
                {
                    codigoLivro.Codigo = "00.05.09." + numeroTextBox.Text;
                }


                // CONSTRUINDO UMA STRING PARA O ITEM COLEÇÃO

                else if (comboBox1.Text == "GENERALIDADE" && comboBox2.Text == "COLEÇÃO" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "00.06.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "GENERALIDADE" && comboBox2.Text == "COLEÇÃO" && comboBox3.Text == "Obras de Allan Kardec")
                {
                    codigoLivro.Codigo = "00.06.01." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "GENERALIDADE" && comboBox2.Text == "COLEÇÃO" && comboBox3.Text == "Coleção Andre Luiz")
                {
                    codigoLivro.Codigo = "00.06.02." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "GENERALIDADE" && comboBox2.Text == "COLEÇÃO" && comboBox3.Text == "Serie Psicologica Joanna de Angelis")
                {
                    codigoLivro.Codigo = "00.06.03." + numeroTextBox.Text;
                }
                #endregion

                //contruindo uma string para FILOSOFIA
                #region FILOSOFIA
                else if (comboBox1.Text == "FILOSOFIA")
                {
                    codigoLivro.Codigo = "10.00.00." + numeroTextBox.Text;
                }
                #endregion

                // contruindo uma string para RELIGIÃO
                #region RELIGIÃO
                else if (comboBox1.Text == "RELIGIÃO" && comboBox2.Text == "" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "20.00.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "RELIGIÃO" && comboBox2.Text == "Vida de Jesus" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "20.01.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "RELIGIÃO" && comboBox2.Text == "Jesus e os Apostolos" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "20.02.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "RELIGIÃO" && comboBox2.Text == "Estudo dos Evangelhos" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "20.03.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "RELIGIÃO" && comboBox2.Text == "Estudo dos Evangelhos" && comboBox3.Text == "Parabolas Evangelicas")
                {
                    codigoLivro.Codigo = "20.03.01." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "RELIGIÃO" && comboBox2.Text == "CRISTIANISMO" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "20.04.00." + numeroTextBox.Text;
                }
                #endregion

                // construindo uma string para CIENCIA
                #region CIÊNCIA
                else if (comboBox1.Text == "CIÊNCIA" && comboBox2.Text == "" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "30.00.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "CIÊNCIA" && comboBox2.Text == "Sobrevivencia, natureza do mundo espiritual e vida apos a morte" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "30.01.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "CIÊNCIA" && comboBox2.Text == "Reencarnação" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "30.02.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "CIÊNCIA" && comboBox2.Text == "Mediunidade" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "30.03.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "CIÊNCIA" && comboBox2.Text == "Mediunidade" && comboBox3.Text == "Fenomenos Mediunicos Especifico")
                {
                    codigoLivro.Codigo = "30.03.01." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "CIÊNCIA" && comboBox2.Text == "Mediunidade" && comboBox3.Text == "Animismo")
                {
                    codigoLivro.Codigo = "30.03.02." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "CIÊNCIA" && comboBox2.Text == "Mediunidade" && comboBox3.Text == "FluidoTerapia/Tratamento")
                {
                    codigoLivro.Codigo = "30.03.03." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "CIÊNCIA" && comboBox2.Text == "Mediunidade" && comboBox3.Text == "Reunião Mediunica")
                {
                    codigoLivro.Codigo = "30.03.05." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "CIÊNCIA" && comboBox2.Text == "Projeção Astral(experiencia fora do corpo)" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "30.04.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "CIÊNCIA" && comboBox2.Text == "Sonhos e misterios" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "30.05.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "CIÊNCIA" && comboBox2.Text == "Metapsiquica" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "30.06.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "CIÊNCIA" && comboBox2.Text == "Parapsicologia" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "30.07.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "CIÊNCIA" && comboBox2.Text == "Hipnotismo" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "30.08.00." + numeroTextBox.Text;
                }
                #endregion

                //consturindo uma string para EVENTO
                #region EVENTO
                else if (comboBox1.Text == "EVENTO" && comboBox2.Text == "" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "40.00.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "EVENTO" && comboBox2.Text == "Congresso" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "40.01.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "EVENTO" && comboBox2.Text == "Congresso" && comboBox3.Text == "Anais")
                {
                    codigoLivro.Codigo = "40.01.01." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "EVENTO" && comboBox2.Text == "Encontro" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "40.02.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "EVENTO" && comboBox2.Text == "Encontro" && comboBox3.Text == "Anais")
                {
                    codigoLivro.Codigo = "40.02.01." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "EVENTO" && comboBox2.Text == "Seminario" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "40.03.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "EVENTO" && comboBox2.Text == "Seminario" && comboBox3.Text == "Anais")
                {
                    codigoLivro.Codigo = "40.03.01." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "EVENTO" && comboBox2.Text == "Curso" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "40.04.00." + numeroTextBox.Text;
                }
                #endregion

                //construindo uma string para MOVIMENTO ESPIRITA
                #region MOVIMENTO ESPIRITA
                else if (comboBox1.Text == "MOVIMENTO ESPÍRITA" && comboBox2.Text == "" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "50.00.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "MOVIMENTO ESPÍRITA" && comboBox2.Text == "Orientação Manual" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "50.01.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "MOVIMENTO ESPÍRITA" && comboBox2.Text == "Orientação Manual" && comboBox3.Text == "Centro Espirita")
                {
                    codigoLivro.Codigo = "50.01.01." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "MOVIMENTO ESPÍRITA" && comboBox2.Text == "Orientação Manual" && comboBox3.Text == "Serviço de Assistência e Promoção Social")
                {
                    codigoLivro.Codigo = "50.01.02." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "MOVIMENTO ESPÍRITA" && comboBox2.Text == "Orientação Manual" && comboBox3.Text == "Biblioteca espirita")
                {
                    codigoLivro.Codigo = "50.01.03." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "MOVIMENTO ESPÍRITA" && comboBox2.Text == "Campanha" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "50.02.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "MOVIMENTO ESPÍRITA" && comboBox2.Text == "Campanha" && comboBox3.Text == "Campanha de defesa da vida")
                {
                    codigoLivro.Codigo = "50.02.01." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "MOVIMENTO ESPÍRITA" && comboBox2.Text == "Campanha" && comboBox3.Text == "Campanha viver em Familia")
                {
                    codigoLivro.Codigo = "50.02.02." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "MOVIMENTO ESPÍRITA" && comboBox2.Text == "Campanha" && comboBox3.Text == "Campanha construamos a Paz, Promovendo o bem")
                {
                    codigoLivro.Codigo = "50.02.03." + numeroTextBox.Text;
                }
                #endregion
                
                //construindo uma string para ATIVIDADES INSTITUCIONAIS
                #region ATIVIDADES INSTITUCIONAIS
                else if (comboBox1.Text == "ATIVIDADES INSTITUCIONAIS" && comboBox2.Text == "" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "51.00.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "ATIVIDADES INSTITUCIONAIS" && comboBox2.Text == "Estatuto" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "51.01.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "ATIVIDADES INSTITUCIONAIS" && comboBox2.Text == "Relatorio" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "51.02.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "ATIVIDADES INSTITUCIONAIS" && comboBox2.Text == "Plano de Ação. Plano de Trabalho. Planejamento" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "51.03.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "ATIVIDADES INSTITUCIONAIS" && comboBox2.Text == "Projeto" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "51.04.00." + numeroTextBox.Text;
                }
                #endregion

                //construindo uma string para MOVIMENTO ESPÍRITA NO EXTERIOR
                #region MOVIMENTO ESPÍRITA NO EXTERIOR
                else if (comboBox1.Text == "MOVIMENTO ESPÍRITA NO EXTERIOR" && comboBox2.Text == "" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "52.00.00." + numeroTextBox.Text;
                }
                #endregion

                //construinodo uma string para EDUCAÇÃO
                #region EDUCAÇÃO
                else if (comboBox1.Text == "EDUCAÇÃO" && comboBox2.Text == "" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "60.00.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "EDUCAÇÃO" && comboBox2.Text == "Evagelização Espirita Infanto Juvenil" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "60.01.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "EDUCAÇÃO" && comboBox2.Text == "Estudo sistematizado da doutrina espirita" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "60.02.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "EDUCAÇÃO" && comboBox2.Text == "Estudo e educação da Mediunidade" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "60.03.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "EDUCAÇÃO" && comboBox2.Text == "Estudo e aprofundado do espiritismo" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "60.04.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "EDUCAÇÃO" && comboBox2.Text == "Material de apoio" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "60.05.00." + numeroTextBox.Text;
                }
                #endregion

                //construindo uma string para ARTE. COMUNICAÇÃO
                #region ARTE. COMUNICAÇÃO
                else if (comboBox1.Text == "ARTE. COMUNICAÇÃO" && comboBox2.Text == "" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "70.00.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "ARTE. COMUNICAÇÃO" && comboBox2.Text == "Musica" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "70.01.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "ARTE. COMUNICAÇÃO" && comboBox2.Text == "Teatro" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "70.02.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "ARTE. COMUNICAÇÃO" && comboBox2.Text == "Cinema" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "70.03.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "ARTE. COMUNICAÇÃO" && comboBox2.Text == "Televisão" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "70.04.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "ARTE. COMUNICAÇÃO" && comboBox2.Text == "Radio" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "70.05.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "ARTE. COMUNICAÇÃO" && comboBox2.Text == "Imprensa" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "70.06.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "ARTE. COMUNICAÇÃO" && comboBox2.Text == "Internet" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "70.07.00." + numeroTextBox.Text;
                }
                #endregion

                //criando uma string para LITERATURA
                #region LITERATURA
                else if (comboBox1.Text == "LITERATURA" && comboBox2.Text == "" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "80.00.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "LITERATURA" && comboBox2.Text == "Conto. Cronica" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "80.01.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "LITERATURA" && comboBox2.Text == "Romance" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "80.02.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "LITERATURA" && comboBox2.Text == "Mensagem" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "80.03.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "LITERATURA" && comboBox2.Text == "Poema" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "80.04.00." + numeroTextBox.Text;
                }
                #endregion

                //criando uma string para LITERATURA INFANTIL
                #region LITERATURA INFANTIL
                else if (comboBox1.Text == "LITERATURA INFANTIL" && comboBox2.Text == "" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "81.00.00." + numeroTextBox.Text;
                }
                #endregion

                //criando uma string para LITERATURA JUVENIL
                #region LITERATURA JUVENIL
                else if (comboBox1.Text == "LITERATURA JUVENIL" && comboBox2.Text == "" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "82.00.00." + numeroTextBox.Text;
                }
                #endregion

                //criando uma string para LITERATURA EM OUTROS IDIOMAS
                #region LITERATURA EM OUTROS IDIOMAS
                else if (comboBox1.Text == "LITERATURA EM OUTROS IDIOMAS" && comboBox2.Text == "" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "85.00.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "LITERATURA EM OUTROS IDIOMAS" && comboBox2.Text == "Esperanto" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "85.01.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "LITERATURA EM OUTROS IDIOMAS" && comboBox2.Text == "Espanhol" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "85.02.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "LITERATURA EM OUTROS IDIOMAS" && comboBox2.Text == "Frances" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "85.03.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "LITERATURA EM OUTROS IDIOMAS" && comboBox2.Text == "Ingles" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "85.04.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "LITERATURA EM OUTROS IDIOMAS" && comboBox2.Text == "Alemão" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "85.05.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "LITERATURA EM OUTROS IDIOMAS" && comboBox2.Text == "Italiano" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "85.06.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "LITERATURA EM OUTROS IDIOMAS" && comboBox2.Text == "Russo" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "85.07.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "LITERATURA EM OUTROS IDIOMAS" && comboBox2.Text == "Hungaro" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "85.08.00." + numeroTextBox.Text;
                }
                #endregion

                //criando uma string para HISTÓRIA. BIOGRAFIA
                #region HISTÓRIA. BIOGRAFIA
                else if (comboBox1.Text == "HISTÓRIA. BIOGRAFIA" && comboBox2.Text == "" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "90.00.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "HISTÓRIA. BIOGRAFIA" && comboBox2.Text == "Historia" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "90.01.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "HISTÓRIA. BIOGRAFIA" && comboBox2.Text == "Biografia" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "90.02.00." + numeroTextBox.Text;
                }
                #endregion

                //ciando uma string para ENTREVISTA
                #region ENTREVISTA
                else if (comboBox1.Text == "ENTREVISTA" && comboBox2.Text == "" && comboBox3.Text == "")
                {
                    codigoLivro.Codigo = "91.00.00." + numeroTextBox.Text;
                }
                #endregion

                if (numeroTextBox.Text == "")
                {
                    MessageBox.Show("Por favor digite um numero do codigoLivro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    codigoLivro.Titulo = nomeTextBox.Text;
                    codigoLivro.Editora = editoraTextBox.Text;
                    codigoLivro.Genero = comboBox1.Text;
                    codigoLivro.SubGenero = comboBox2.Text;
                    codigoLivro.SubGenero2 = comboBox3.Text;
                    codigoLivro.Autor = comboBox4.Text;
                    codigoLivro.Autor_Espiritual = comboBox5.Text;
                    codigoLivro.GravarLivro();
                }
            }//fim do bloco if
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numeroTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textBox so aceitar numeros
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void consultarButton_Click(object sender, EventArgs e)
        {

            //captando a configuração
            string server = "";
            string baseDados = "";
            string codigoLivro = "";
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

            string strcon = "Data Source=" + server + ";Initial Catalog=" + baseDados + ";Integrated Security=True";


            if (comboBox1.Text == "")
            {
                MessageBox.Show("O campo inicial esta faltando", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //construindo uma string para GENERALIDADE
                #region GENERALIDADE 
                if (comboBox1.Text == "GENERALIDADE" && comboBox2.Text == "" && comboBox3.Text == "")
                {
                    codigoLivro = "00.00.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "GENERALIDADE" && comboBox2.Text == "REFERENCIA" && comboBox3.Text == "")
                {
                    codigoLivro = "00.05.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "GENERALIDADE" && comboBox2.Text == "REFERENCIA" && comboBox3.Text == "Almanaque")
                {
                    codigoLivro = "00.05.01." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "GENERALIDADE" && comboBox2.Text == "REFERENCIA" && comboBox3.Text == "Atlas")
                {
                    codigoLivro = "00.05.02." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "GENERALIDADE" && comboBox2.Text == "REFERENCIA" && comboBox3.Text == "Bibliografia")
                {
                    codigoLivro = "00.05.03." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "GENERALIDADE" && comboBox2.Text == "REFERENCIA" && comboBox3.Text == "Catalogo")
                {
                    codigoLivro = "00.05.04." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "GENERALIDADE" && comboBox2.Text == "REFERENCIA" && comboBox3.Text == "Dicionario/Grossario")
                {
                    codigoLivro = "00.05.05." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "GENERALIDADE" && comboBox2.Text == "REFERENCIA" && comboBox3.Text == "Enciclopedia")
                {
                    codigoLivro = "00.05.06." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "GENERALIDADE" && comboBox2.Text == "REFERENCIA" && comboBox3.Text == "Guia/Manual")
                {
                    codigoLivro = "00.05.07." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "GENERALIDADE" && comboBox2.Text == "REFERENCIA" && comboBox3.Text == "Repertorio/Inventario/Diretorio")
                {
                    codigoLivro = "00.05.08." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "GENERALIDADE" && comboBox2.Text == "REFERENCIA" && comboBox3.Text == "Indice/Vocabulario/Tesauro")
                {
                    codigoLivro = "00.05.09." + numeroTextBox.Text;
                }


                // CONSTRUINDO UMA STRING PARA O ITEM COLEÇÃO

                else if (comboBox1.Text == "GENERALIDADE" && comboBox2.Text == "COLEÇÃO" && comboBox3.Text == "")
                {
                    codigoLivro = "00.06.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "GENERALIDADE" && comboBox2.Text == "COLEÇÃO" && comboBox3.Text == "Obras de Allan Kardec")
                {
                    codigoLivro = "00.06.01." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "GENERALIDADE" && comboBox2.Text == "COLEÇÃO" && comboBox3.Text == "Coleção Andre Luiz")
                {
                    codigoLivro = "00.06.02." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "GENERALIDADE" && comboBox2.Text == "COLEÇÃO" && comboBox3.Text == "Serie Psicologica Joanna de Angelis")
                {
                    codigoLivro = "00.06.03." + numeroTextBox.Text;
                }
                #endregion

                //contruindo uma string para FILOSOFIA
                #region FILOSOFIA
                else if (comboBox1.Text == "FILOSOFIA")
                {
                    codigoLivro = "10.00.00." + numeroTextBox.Text;
                }
                #endregion

                // contruindo uma string para RELIGIÃO
                #region RELIGIÃO
                else if (comboBox1.Text == "RELIGIÃO" && comboBox2.Text == "" && comboBox3.Text == "")
                {
                    codigoLivro = "20.00.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "RELIGIÃO" && comboBox2.Text == "Vida de Jesus" && comboBox3.Text == "")
                {
                    codigoLivro = "20.01.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "RELIGIÃO" && comboBox2.Text == "Jesus e os Apostolos" && comboBox3.Text == "")
                {
                    codigoLivro = "20.02.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "RELIGIÃO" && comboBox2.Text == "Estudo dos Evangelhos" && comboBox3.Text == "")
                {
                    codigoLivro = "20.03.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "RELIGIÃO" && comboBox2.Text == "Estudo dos Evangelhos" && comboBox3.Text == "Parabolas Evangelicas")
                {
                    codigoLivro = "20.03.01." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "RELIGIÃO" && comboBox2.Text == "CRISTIANISMO" && comboBox3.Text == "")
                {
                    codigoLivro = "20.04.00." + numeroTextBox.Text;
                }
                #endregion

                // construindo uma string para CIENCIA
                #region CIÊNCIA
                else if (comboBox1.Text == "CIÊNCIA" && comboBox2.Text == "" && comboBox3.Text == "")
                {
                    codigoLivro = "30.00.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "CIÊNCIA" && comboBox2.Text == "Sobrevivencia, natureza do mundo espiritual e vida apos a morte" && comboBox3.Text == "")
                {
                    codigoLivro = "30.01.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "CIÊNCIA" && comboBox2.Text == "Reencarnação" && comboBox3.Text == "")
                {
                    codigoLivro = "30.02.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "CIÊNCIA" && comboBox2.Text == "Mediunidade" && comboBox3.Text == "")
                {
                    codigoLivro = "30.03.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "CIÊNCIA" && comboBox2.Text == "Mediunidade" && comboBox3.Text == "Fenomenos Mediunicos Especifico")
                {
                    codigoLivro = "30.03.01." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "CIÊNCIA" && comboBox2.Text == "Mediunidade" && comboBox3.Text == "Animismo")
                {
                    codigoLivro = "30.03.02." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "CIÊNCIA" && comboBox2.Text == "Mediunidade" && comboBox3.Text == "FluidoTerapia/Tratamento")
                {
                    codigoLivro = "30.03.03." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "CIÊNCIA" && comboBox2.Text == "Mediunidade" && comboBox3.Text == "Reunião Mediunica")
                {
                    codigoLivro = "30.03.05." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "CIÊNCIA" && comboBox2.Text == "Projeção Astral(experiencia fora do corpo)" && comboBox3.Text == "")
                {
                    codigoLivro = "30.04.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "CIÊNCIA" && comboBox2.Text == "Sonhos e misterios" && comboBox3.Text == "")
                {
                    codigoLivro = "30.05.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "CIÊNCIA" && comboBox2.Text == "Metapsiquica" && comboBox3.Text == "")
                {
                    codigoLivro = "30.06.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "CIÊNCIA" && comboBox2.Text == "Parapsicologia" && comboBox3.Text == "")
                {
                    codigoLivro = "30.07.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "CIÊNCIA" && comboBox2.Text == "Hipnotismo" && comboBox3.Text == "")
                {
                    codigoLivro = "30.08.00." + numeroTextBox.Text;
                }
                #endregion

                //consturindo uma string para EVENTO
                #region EVENTO
                else if (comboBox1.Text == "EVENTO" && comboBox2.Text == "" && comboBox3.Text == "")
                {
                    codigoLivro = "40.00.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "EVENTO" && comboBox2.Text == "Congresso" && comboBox3.Text == "")
                {
                    codigoLivro = "40.01.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "EVENTO" && comboBox2.Text == "Congresso" && comboBox3.Text == "Anais")
                {
                    codigoLivro = "40.01.01." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "EVENTO" && comboBox2.Text == "Encontro" && comboBox3.Text == "")
                {
                    codigoLivro = "40.02.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "EVENTO" && comboBox2.Text == "Encontro" && comboBox3.Text == "Anais")
                {
                    codigoLivro = "40.02.01." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "EVENTO" && comboBox2.Text == "Seminario" && comboBox3.Text == "")
                {
                    codigoLivro = "40.03.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "EVENTO" && comboBox2.Text == "Seminario" && comboBox3.Text == "Anais")
                {
                    codigoLivro = "40.03.01." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "EVENTO" && comboBox2.Text == "Curso" && comboBox3.Text == "")
                {
                    codigoLivro = "40.04.00." + numeroTextBox.Text;
                }
                #endregion

                //construindo uma string para MOVIMENTO ESPIRITA
                #region MOVIMENTO ESPIRITA
                else if (comboBox1.Text == "MOVIMENTO ESPÍRITA" && comboBox2.Text == "" && comboBox3.Text == "")
                {
                    codigoLivro = "50.00.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "MOVIMENTO ESPÍRITA" && comboBox2.Text == "Orientação Manual" && comboBox3.Text == "")
                {
                    codigoLivro = "50.01.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "MOVIMENTO ESPÍRITA" && comboBox2.Text == "Orientação Manual" && comboBox3.Text == "Centro Espirita")
                {
                    codigoLivro = "50.01.01." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "MOVIMENTO ESPÍRITA" && comboBox2.Text == "Orientação Manual" && comboBox3.Text == "Serviço de Assistência e Promoção Social")
                {
                    codigoLivro = "50.01.02." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "MOVIMENTO ESPÍRITA" && comboBox2.Text == "Orientação Manual" && comboBox3.Text == "Biblioteca espirita")
                {
                    codigoLivro = "50.01.03." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "MOVIMENTO ESPÍRITA" && comboBox2.Text == "Campanha" && comboBox3.Text == "")
                {
                    codigoLivro = "50.02.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "MOVIMENTO ESPÍRITA" && comboBox2.Text == "Campanha" && comboBox3.Text == "Campanha de defesa da vida")
                {
                    codigoLivro = "50.02.01." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "MOVIMENTO ESPÍRITA" && comboBox2.Text == "Campanha" && comboBox3.Text == "Campanha viver em Familia")
                {
                    codigoLivro = "50.02.02." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "MOVIMENTO ESPÍRITA" && comboBox2.Text == "Campanha" && comboBox3.Text == "Campanha construamos a Paz, Promovendo o bem")
                {
                    codigoLivro = "50.02.03." + numeroTextBox.Text;
                }
                #endregion

                //construindo uma string para ATIVIDADES INSTITUCIONAIS
                #region ATIVIDADES INSTITUCIONAIS
                else if (comboBox1.Text == "ATIVIDADES INSTITUCIONAIS" && comboBox2.Text == "" && comboBox3.Text == "")
                {
                    codigoLivro = "51.00.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "ATIVIDADES INSTITUCIONAIS" && comboBox2.Text == "Estatuto" && comboBox3.Text == "")
                {
                    codigoLivro = "51.01.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "ATIVIDADES INSTITUCIONAIS" && comboBox2.Text == "Relatorio" && comboBox3.Text == "")
                {
                    codigoLivro = "51.02.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "ATIVIDADES INSTITUCIONAIS" && comboBox2.Text == "Plano de Ação. Plano de Trabalho. Planejamento" && comboBox3.Text == "")
                {
                    codigoLivro = "51.03.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "ATIVIDADES INSTITUCIONAIS" && comboBox2.Text == "Projeto" && comboBox3.Text == "")
                {
                    codigoLivro = "51.04.00." + numeroTextBox.Text;
                }
                #endregion

                //construindo uma string para MOVIMENTO ESPÍRITA NO EXTERIOR
                #region MOVIMENTO ESPÍRITA NO EXTERIOR
                else if (comboBox1.Text == "MOVIMENTO ESPÍRITA NO EXTERIOR" && comboBox2.Text == "" && comboBox3.Text == "")
                {
                    codigoLivro = "52.00.00." + numeroTextBox.Text;
                }
                #endregion

                //construinodo uma string para EDUCAÇÃO
                #region EDUCAÇÃO
                else if (comboBox1.Text == "EDUCAÇÃO" && comboBox2.Text == "" && comboBox3.Text == "")
                {
                    codigoLivro = "60.00.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "EDUCAÇÃO" && comboBox2.Text == "Evagelização Espirita Infanto Juvenil" && comboBox3.Text == "")
                {
                    codigoLivro = "60.01.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "EDUCAÇÃO" && comboBox2.Text == "Estudo sistematizado da doutrina espirita" && comboBox3.Text == "")
                {
                    codigoLivro = "60.02.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "EDUCAÇÃO" && comboBox2.Text == "Estudo e educação da Mediunidade" && comboBox3.Text == "")
                {
                    codigoLivro = "60.03.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "EDUCAÇÃO" && comboBox2.Text == "Estudo e aprofundado do espiritismo" && comboBox3.Text == "")
                {
                    codigoLivro = "60.04.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "EDUCAÇÃO" && comboBox2.Text == "Material de apoio" && comboBox3.Text == "")
                {
                    codigoLivro = "60.05.00." + numeroTextBox.Text;
                }
                #endregion

                //construindo uma string para ARTE. COMUNICAÇÃO
                #region ARTE. COMUNICAÇÃO
                else if (comboBox1.Text == "ARTE. COMUNICAÇÃO" && comboBox2.Text == "" && comboBox3.Text == "")
                {
                    codigoLivro = "70.00.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "ARTE. COMUNICAÇÃO" && comboBox2.Text == "Musica" && comboBox3.Text == "")
                {
                    codigoLivro = "70.01.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "ARTE. COMUNICAÇÃO" && comboBox2.Text == "Teatro" && comboBox3.Text == "")
                {
                    codigoLivro = "70.02.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "ARTE. COMUNICAÇÃO" && comboBox2.Text == "Cinema" && comboBox3.Text == "")
                {
                    codigoLivro = "70.03.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "ARTE. COMUNICAÇÃO" && comboBox2.Text == "Televisão" && comboBox3.Text == "")
                {
                    codigoLivro = "70.04.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "ARTE. COMUNICAÇÃO" && comboBox2.Text == "Radio" && comboBox3.Text == "")
                {
                    codigoLivro = "70.05.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "ARTE. COMUNICAÇÃO" && comboBox2.Text == "Imprensa" && comboBox3.Text == "")
                {
                    codigoLivro = "70.06.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "ARTE. COMUNICAÇÃO" && comboBox2.Text == "Internet" && comboBox3.Text == "")
                {
                    codigoLivro = "70.07.00." + numeroTextBox.Text;
                }
                #endregion

                //criando uma string para LITERATURA
                #region LITERATURA
                else if (comboBox1.Text == "LITERATURA" && comboBox2.Text == "" && comboBox3.Text == "")
                {
                    codigoLivro = "80.00.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "LITERATURA" && comboBox2.Text == "Conto. Cronica" && comboBox3.Text == "")
                {
                    codigoLivro = "80.01.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "LITERATURA" && comboBox2.Text == "Romance" && comboBox3.Text == "")
                {
                    codigoLivro = "80.02.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "LITERATURA" && comboBox2.Text == "Mensagem" && comboBox3.Text == "")
                {
                    codigoLivro = "80.03.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "LITERATURA" && comboBox2.Text == "Poema" && comboBox3.Text == "")
                {
                    codigoLivro = "80.04.00." + numeroTextBox.Text;
                }
                #endregion

                //criando uma string para LITERATURA INFANTIL
                #region LITERATURA INFANTIL
                else if (comboBox1.Text == "LITERATURA INFANTIL" && comboBox2.Text == "" && comboBox3.Text == "")
                {
                    codigoLivro = "81.00.00." + numeroTextBox.Text;
                }
                #endregion

                //criando uma string para LITERATURA JUVENIL
                #region LITERATURA JUVENIL
                else if (comboBox1.Text == "LITERATURA JUVENIL" && comboBox2.Text == "" && comboBox3.Text == "")
                {
                    codigoLivro = "82.00.00." + numeroTextBox.Text;
                }
                #endregion

                //criando uma string para LITERATURA EM OUTROS IDIOMAS
                #region LITERATURA EM OUTROS IDIOMAS
                else if (comboBox1.Text == "LITERATURA EM OUTROS IDIOMAS" && comboBox2.Text == "" && comboBox3.Text == "")
                {
                    codigoLivro = "85.00.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "LITERATURA EM OUTROS IDIOMAS" && comboBox2.Text == "Esperanto" && comboBox3.Text == "")
                {
                    codigoLivro = "85.01.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "LITERATURA EM OUTROS IDIOMAS" && comboBox2.Text == "Espanhol" && comboBox3.Text == "")
                {
                    codigoLivro = "85.02.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "LITERATURA EM OUTROS IDIOMAS" && comboBox2.Text == "Frances" && comboBox3.Text == "")
                {
                    codigoLivro = "85.03.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "LITERATURA EM OUTROS IDIOMAS" && comboBox2.Text == "Ingles" && comboBox3.Text == "")
                {
                    codigoLivro = "85.04.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "LITERATURA EM OUTROS IDIOMAS" && comboBox2.Text == "Alemão" && comboBox3.Text == "")
                {
                    codigoLivro = "85.05.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "LITERATURA EM OUTROS IDIOMAS" && comboBox2.Text == "Italiano" && comboBox3.Text == "")
                {
                    codigoLivro = "85.06.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "LITERATURA EM OUTROS IDIOMAS" && comboBox2.Text == "Russo" && comboBox3.Text == "")
                {
                    codigoLivro = "85.07.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "LITERATURA EM OUTROS IDIOMAS" && comboBox2.Text == "Hungaro" && comboBox3.Text == "")
                {
                    codigoLivro = "85.08.00." + numeroTextBox.Text;
                }
                #endregion

                //criando uma string para HISTÓRIA. BIOGRAFIA
                #region HISTÓRIA. BIOGRAFIA
                else if (comboBox1.Text == "HISTÓRIA. BIOGRAFIA" && comboBox2.Text == "" && comboBox3.Text == "")
                {
                    codigoLivro = "90.00.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "HISTÓRIA. BIOGRAFIA" && comboBox2.Text == "Historia" && comboBox3.Text == "")
                {
                    codigoLivro = "90.01.00." + numeroTextBox.Text;
                }
                else if (comboBox1.Text == "HISTÓRIA. BIOGRAFIA" && comboBox2.Text == "Biografia" && comboBox3.Text == "")
                {
                    codigoLivro = "90.02.00." + numeroTextBox.Text;
                }
                #endregion

                //ciando uma string para ENTREVISTA
                #region ENTREVISTA
                else if (comboBox1.Text == "ENTREVISTA" && comboBox2.Text == "" && comboBox3.Text == "")
                {
                    codigoLivro = "91.00.00." + numeroTextBox.Text;
                }
                #endregion

                try
                {
                    SqlConnection conn = new SqlConnection(strcon);
                    SqlCommand comando = new SqlCommand("SELECT * FROM LIVROS WHERE CODIGO_LIVRO LIKE '" + codigoLivro + "%' ORDER BY CODIGO_LIVRO ", conn);
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    conn.Open();
                    comando.ExecuteNonQuery();
                    conn.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro:" + ex.Message);
                }
            }//fim do bloco if

        }
        public void configuraDatagrid()
        {
            try
            {
                dataGridView1.Columns[0].HeaderText = "Codigo";
                dataGridView1.Columns[1].HeaderText = "Nome do Livro";
                dataGridView1.Columns[2].HeaderText = "Genero";
                dataGridView1.Columns[3].HeaderText = "SubGenero";
                dataGridView1.Columns[4].HeaderText = "SubGenero 2";
                dataGridView1.Columns[5].HeaderText = "Autor";
                dataGridView1.Columns[6].HeaderText = "Autor Espirital";
                dataGridView1.Columns[7].HeaderText = "Editora";
                dataGridView1.Columns[8].HeaderText = "Status";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }

    }
}

