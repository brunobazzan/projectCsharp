namespace Biblioteca_Andreza
{
    partial class telaLivrosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaLivrosForm));
            this.resultadoDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gravarLivrobutton = new System.Windows.Forms.Button();
            this.editoraTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.generoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.autoresTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deletarButton = new System.Windows.Forms.Button();
            this.codigo2TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.desfazerButton = new System.Windows.Forms.Button();
            this.procurarButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.campoComboBox = new System.Windows.Forms.ComboBox();
            this.palavraChaveTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.alterarButton = new System.Windows.Forms.Button();
            this.campo2ComboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.codigo3textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultadoDataGridView
            // 
            this.resultadoDataGridView.AllowUserToAddRows = false;
            this.resultadoDataGridView.AllowUserToDeleteRows = false;
            this.resultadoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultadoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.resultadoDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.resultadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultadoDataGridView.Location = new System.Drawing.Point(13, 244);
            this.resultadoDataGridView.Name = "resultadoDataGridView";
            this.resultadoDataGridView.ReadOnly = true;
            this.resultadoDataGridView.Size = new System.Drawing.Size(766, 282);
            this.resultadoDataGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gravarLivrobutton);
            this.groupBox1.Controls.Add(this.editoraTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.generoTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.autoresTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tituloTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.codigoTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 225);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Livros";
            // 
            // gravarLivrobutton
            // 
            this.gravarLivrobutton.Location = new System.Drawing.Point(6, 196);
            this.gravarLivrobutton.Name = "gravarLivrobutton";
            this.gravarLivrobutton.Size = new System.Drawing.Size(75, 23);
            this.gravarLivrobutton.TabIndex = 10;
            this.gravarLivrobutton.Text = "Gravar Livro";
            this.gravarLivrobutton.UseVisualStyleBackColor = true;
            this.gravarLivrobutton.Click += new System.EventHandler(this.gravarLivrobutton_Click);
            // 
            // editoraTextBox
            // 
            this.editoraTextBox.Location = new System.Drawing.Point(63, 133);
            this.editoraTextBox.Name = "editoraTextBox";
            this.editoraTextBox.Size = new System.Drawing.Size(98, 20);
            this.editoraTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Editora:";
            // 
            // generoTextBox
            // 
            this.generoTextBox.Location = new System.Drawing.Point(63, 107);
            this.generoTextBox.Name = "generoTextBox";
            this.generoTextBox.Size = new System.Drawing.Size(98, 20);
            this.generoTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Genero:";
            // 
            // autoresTextBox
            // 
            this.autoresTextBox.Location = new System.Drawing.Point(63, 81);
            this.autoresTextBox.Name = "autoresTextBox";
            this.autoresTextBox.Size = new System.Drawing.Size(312, 20);
            this.autoresTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Autores:";
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.Location = new System.Drawing.Point(63, 55);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(312, 20);
            this.tituloTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Titulo:";
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Location = new System.Drawing.Point(63, 29);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(58, 20);
            this.codigoTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deletarButton);
            this.groupBox2.Controls.Add(this.codigo2TextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(650, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 104);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deletar Livro";
            // 
            // deletarButton
            // 
            this.deletarButton.Location = new System.Drawing.Point(6, 47);
            this.deletarButton.Name = "deletarButton";
            this.deletarButton.Size = new System.Drawing.Size(75, 23);
            this.deletarButton.TabIndex = 2;
            this.deletarButton.Text = "Deletar Livro";
            this.deletarButton.UseVisualStyleBackColor = true;
            this.deletarButton.Click += new System.EventHandler(this.deletarButton_Click);
            // 
            // codigo2TextBox
            // 
            this.codigo2TextBox.Location = new System.Drawing.Point(56, 17);
            this.codigo2TextBox.Name = "codigo2TextBox";
            this.codigo2TextBox.Size = new System.Drawing.Size(68, 20);
            this.codigo2TextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Codigo:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.desfazerButton);
            this.groupBox3.Controls.Add(this.procurarButton);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.campoComboBox);
            this.groupBox3.Controls.Add(this.palavraChaveTextBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(415, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 104);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Procurar Livro";
            // 
            // desfazerButton
            // 
            this.desfazerButton.Location = new System.Drawing.Point(90, 69);
            this.desfazerButton.Name = "desfazerButton";
            this.desfazerButton.Size = new System.Drawing.Size(105, 23);
            this.desfazerButton.TabIndex = 5;
            this.desfazerButton.Text = "Desfazer Pesquisa";
            this.desfazerButton.UseVisualStyleBackColor = true;
            this.desfazerButton.Click += new System.EventHandler(this.desfazerButton_Click);
            // 
            // procurarButton
            // 
            this.procurarButton.Location = new System.Drawing.Point(9, 69);
            this.procurarButton.Name = "procurarButton";
            this.procurarButton.Size = new System.Drawing.Size(75, 23);
            this.procurarButton.TabIndex = 4;
            this.procurarButton.Text = "Procurar";
            this.procurarButton.UseVisualStyleBackColor = true;
            this.procurarButton.Click += new System.EventHandler(this.procurarButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Campo:";
            // 
            // campoComboBox
            // 
            this.campoComboBox.FormattingEnabled = true;
            this.campoComboBox.Items.AddRange(new object[] {
            "CODIGO",
            "TITULO",
            "AUTORES",
            "GENERO",
            "EDITORA"});
            this.campoComboBox.Location = new System.Drawing.Point(58, 44);
            this.campoComboBox.Name = "campoComboBox";
            this.campoComboBox.Size = new System.Drawing.Size(165, 21);
            this.campoComboBox.TabIndex = 2;
            // 
            // palavraChaveTextBox
            // 
            this.palavraChaveTextBox.Location = new System.Drawing.Point(94, 17);
            this.palavraChaveTextBox.Name = "palavraChaveTextBox";
            this.palavraChaveTextBox.Size = new System.Drawing.Size(129, 20);
            this.palavraChaveTextBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Palavra chave:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.alterarButton);
            this.groupBox4.Controls.Add(this.campo2ComboBox1);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.valorTextBox);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.codigo3textBox);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(415, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(364, 115);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Alterar Livro";
            // 
            // alterarButton
            // 
            this.alterarButton.Location = new System.Drawing.Point(203, 68);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(75, 23);
            this.alterarButton.TabIndex = 6;
            this.alterarButton.Text = "Atualizar";
            this.alterarButton.UseVisualStyleBackColor = true;
            this.alterarButton.Click += new System.EventHandler(this.alterarButton_Click_1);
            // 
            // campo2ComboBox1
            // 
            this.campo2ComboBox1.FormattingEnabled = true;
            this.campo2ComboBox1.Items.AddRange(new object[] {
            "TITULO",
            "AUTORES",
            "GENERO",
            "EDITORA"});
            this.campo2ComboBox1.Location = new System.Drawing.Point(61, 70);
            this.campo2ComboBox1.Name = "campo2ComboBox1";
            this.campo2ComboBox1.Size = new System.Drawing.Size(121, 21);
            this.campo2ComboBox1.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Campo:";
            // 
            // valorTextBox
            // 
            this.valorTextBox.Location = new System.Drawing.Point(50, 44);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(113, 20);
            this.valorTextBox.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Valor:";
            // 
            // codigo3textBox
            // 
            this.codigo3textBox.Location = new System.Drawing.Point(50, 17);
            this.codigo3textBox.Name = "codigo3textBox";
            this.codigo3textBox.Size = new System.Drawing.Size(113, 20);
            this.codigo3textBox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Codigo:";
            // 
            // telaLivrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 538);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resultadoDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "telaLivrosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Gerenciar Livros";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.telaLivrosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultadoDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView resultadoDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox editoraTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox generoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox autoresTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gravarLivrobutton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button deletarButton;
        private System.Windows.Forms.TextBox codigo2TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox campoComboBox;
        private System.Windows.Forms.TextBox palavraChaveTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button procurarButton;
        private System.Windows.Forms.Button desfazerButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button alterarButton;
        private System.Windows.Forms.ComboBox campo2ComboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox codigo3textBox;
        private System.Windows.Forms.Label label9;
    }
}