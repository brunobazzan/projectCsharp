namespace ANGELA_PROGRAMA
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.gravarButton = new System.Windows.Forms.Button();
            this.mostraDataGridView = new System.Windows.Forms.DataGridView();
            this.ConfiguraMenuStrip = new System.Windows.Forms.MenuStrip();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarBancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirContatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirTodosOsContatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            this.atualizarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mostraDataGridView)).BeginInit();
            this.ConfiguraMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(54, 36);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(189, 20);
            this.nomeTextBox.TabIndex = 1;
            // 
            // gravarButton
            // 
            this.gravarButton.Location = new System.Drawing.Point(12, 102);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(79, 23);
            this.gravarButton.TabIndex = 6;
            this.gravarButton.Text = "Gravar";
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.gravarButton_Click);
            // 
            // mostraDataGridView
            // 
            this.mostraDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mostraDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.mostraDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mostraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostraDataGridView.Location = new System.Drawing.Point(12, 141);
            this.mostraDataGridView.Name = "mostraDataGridView";
            this.mostraDataGridView.Size = new System.Drawing.Size(784, 290);
            this.mostraDataGridView.TabIndex = 8;
            this.mostraDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mostraDataGridView_CellContentClick);
            // 
            // ConfiguraMenuStrip
            // 
            this.ConfiguraMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçãoToolStripMenuItem,
            this.contatosToolStripMenuItem});
            this.ConfiguraMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ConfiguraMenuStrip.Name = "ConfiguraMenuStrip";
            this.ConfiguraMenuStrip.Size = new System.Drawing.Size(808, 24);
            this.ConfiguraMenuStrip.TabIndex = 6;
            this.ConfiguraMenuStrip.Text = "menuStrip1";
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarBancoDeDadosToolStripMenuItem});
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.configuraçãoToolStripMenuItem.Text = "Configuração";
            // 
            // configurarBancoDeDadosToolStripMenuItem
            // 
            this.configurarBancoDeDadosToolStripMenuItem.Name = "configurarBancoDeDadosToolStripMenuItem";
            this.configurarBancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.configurarBancoDeDadosToolStripMenuItem.Text = "Configurar Banco de Dados";
            this.configurarBancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.configurarBancoDeDadosToolStripMenuItem_Click);
            // 
            // contatosToolStripMenuItem
            // 
            this.contatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excluirContatosToolStripMenuItem,
            this.excluirTodosOsContatosToolStripMenuItem});
            this.contatosToolStripMenuItem.Name = "contatosToolStripMenuItem";
            this.contatosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.contatosToolStripMenuItem.Text = "Contatos";
            // 
            // excluirContatosToolStripMenuItem
            // 
            this.excluirContatosToolStripMenuItem.Name = "excluirContatosToolStripMenuItem";
            this.excluirContatosToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.excluirContatosToolStripMenuItem.Text = "Excluir Contatos";
            this.excluirContatosToolStripMenuItem.Click += new System.EventHandler(this.excluirContatosToolStripMenuItem_Click);
            // 
            // excluirTodosOsContatosToolStripMenuItem
            // 
            this.excluirTodosOsContatosToolStripMenuItem.Name = "excluirTodosOsContatosToolStripMenuItem";
            this.excluirTodosOsContatosToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.excluirTodosOsContatosToolStripMenuItem.Text = "Excluir Todos os Contatos";
            this.excluirTodosOsContatosToolStripMenuItem.Click += new System.EventHandler(this.excluirTodosOsContatosToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Endereço: ";
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.Location = new System.Drawing.Point(314, 36);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(255, 20);
            this.enderecoTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "E-mail: ";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(54, 72);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(189, 20);
            this.emailTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefone: ";
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.Location = new System.Drawing.Point(314, 72);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefoneTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Celular: ";
            // 
            // celularTextBox
            // 
            this.celularTextBox.Location = new System.Drawing.Point(469, 72);
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(100, 20);
            this.celularTextBox.TabIndex = 5;
            // 
            // atualizarButton
            // 
            this.atualizarButton.Location = new System.Drawing.Point(97, 102);
            this.atualizarButton.Name = "atualizarButton";
            this.atualizarButton.Size = new System.Drawing.Size(132, 23);
            this.atualizarButton.TabIndex = 14;
            this.atualizarButton.Text = "Atualizar Contatos";
            this.atualizarButton.UseVisualStyleBackColor = true;
            this.atualizarButton.Click += new System.EventHandler(this.atualizarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 443);
            this.Controls.Add(this.atualizarButton);
            this.Controls.Add(this.celularTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mostraDataGridView);
            this.Controls.Add(this.gravarButton);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfiguraMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ConfiguraMenuStrip;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Lista de contatos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mostraDataGridView)).EndInit();
            this.ConfiguraMenuStrip.ResumeLayout(false);
            this.ConfiguraMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.DataGridView mostraDataGridView;
        private System.Windows.Forms.MenuStrip ConfiguraMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarBancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox celularTextBox;
        private System.Windows.Forms.ToolStripMenuItem contatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirContatosToolStripMenuItem;
        private System.Windows.Forms.Button atualizarButton;
        private System.Windows.Forms.ToolStripMenuItem excluirTodosOsContatosToolStripMenuItem;
    }
}

