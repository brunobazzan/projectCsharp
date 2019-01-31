namespace BoltNavegador
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
            this.barraEnderecoTextBox1 = new System.Windows.Forms.TextBox();
            this.voltarButton = new System.Windows.Forms.Button();
            this.adianteButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaJanelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaJanelaPrivativaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFavoritosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreOProgramaBoltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licensasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comoUsarOBoltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pesquisarButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.exibirwebBrowser = new System.Windows.Forms.WebBrowser();
            this.irButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraEnderecoTextBox1
            // 
            this.barraEnderecoTextBox1.Location = new System.Drawing.Point(174, 24);
            this.barraEnderecoTextBox1.Name = "barraEnderecoTextBox1";
            this.barraEnderecoTextBox1.Size = new System.Drawing.Size(487, 20);
            this.barraEnderecoTextBox1.TabIndex = 0;
            this.barraEnderecoTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.barraEnderecoTextBox1_KeyPress);
            // 
            // voltarButton
            // 
            this.voltarButton.Location = new System.Drawing.Point(12, 23);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(75, 23);
            this.voltarButton.TabIndex = 1;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // adianteButton
            // 
            this.adianteButton.Location = new System.Drawing.Point(93, 23);
            this.adianteButton.Name = "adianteButton";
            this.adianteButton.Size = new System.Drawing.Size(75, 23);
            this.adianteButton.TabIndex = 2;
            this.adianteButton.Text = "Adiante";
            this.adianteButton.UseVisualStyleBackColor = true;
            this.adianteButton.Click += new System.EventHandler(this.adianteButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.opçõesToolStripMenuItem,
            this.favoritosToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1128, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaJanelaToolStripMenuItem,
            this.novaJanelaPrivativaToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.fecharToolStripMenuItem,
            this.fecharToolStripMenuItem1});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novaJanelaToolStripMenuItem
            // 
            this.novaJanelaToolStripMenuItem.Name = "novaJanelaToolStripMenuItem";
            this.novaJanelaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.novaJanelaToolStripMenuItem.Text = "Nova Janela";
            // 
            // novaJanelaPrivativaToolStripMenuItem
            // 
            this.novaJanelaPrivativaToolStripMenuItem.Name = "novaJanelaPrivativaToolStripMenuItem";
            this.novaJanelaPrivativaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.novaJanelaPrivativaToolStripMenuItem.Text = "Nova Janela Privativa";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.fecharToolStripMenuItem.Text = "Salvar Pagina";
            // 
            // fecharToolStripMenuItem1
            // 
            this.fecharToolStripMenuItem1.Name = "fecharToolStripMenuItem1";
            this.fecharToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.fecharToolStripMenuItem1.Text = "Fechar";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // favoritosToolStripMenuItem
            // 
            this.favoritosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirFavoritosToolStripMenuItem,
            this.historicoToolStripMenuItem,
            this.localizarToolStripMenuItem});
            this.favoritosToolStripMenuItem.Name = "favoritosToolStripMenuItem";
            this.favoritosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.favoritosToolStripMenuItem.Text = "Favoritos";
            // 
            // exibirFavoritosToolStripMenuItem
            // 
            this.exibirFavoritosToolStripMenuItem.Name = "exibirFavoritosToolStripMenuItem";
            this.exibirFavoritosToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exibirFavoritosToolStripMenuItem.Text = "Exibir Favoritos";
            // 
            // historicoToolStripMenuItem
            // 
            this.historicoToolStripMenuItem.Name = "historicoToolStripMenuItem";
            this.historicoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.historicoToolStripMenuItem.Text = "Historico";
            // 
            // localizarToolStripMenuItem
            // 
            this.localizarToolStripMenuItem.Name = "localizarToolStripMenuItem";
            this.localizarToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.localizarToolStripMenuItem.Text = "Localizar";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreOProgramaBoltToolStripMenuItem,
            this.licensasToolStripMenuItem,
            this.comoUsarOBoltToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // sobreOProgramaBoltToolStripMenuItem
            // 
            this.sobreOProgramaBoltToolStripMenuItem.Name = "sobreOProgramaBoltToolStripMenuItem";
            this.sobreOProgramaBoltToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.sobreOProgramaBoltToolStripMenuItem.Text = "Sobre o programa Bolt";
            // 
            // licensasToolStripMenuItem
            // 
            this.licensasToolStripMenuItem.Name = "licensasToolStripMenuItem";
            this.licensasToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.licensasToolStripMenuItem.Text = "Licensas";
            // 
            // comoUsarOBoltToolStripMenuItem
            // 
            this.comoUsarOBoltToolStripMenuItem.Name = "comoUsarOBoltToolStripMenuItem";
            this.comoUsarOBoltToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.comoUsarOBoltToolStripMenuItem.Text = "Como Usar o Bolt";
            // 
            // atualizarButton
            // 
            this.atualizarButton.Location = new System.Drawing.Point(725, 23);
            this.atualizarButton.Name = "atualizarButton";
            this.atualizarButton.Size = new System.Drawing.Size(75, 23);
            this.atualizarButton.TabIndex = 5;
            this.atualizarButton.Text = "Atualizar";
            this.atualizarButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(806, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pesquisarButton
            // 
            this.pesquisarButton.Location = new System.Drawing.Point(1016, 24);
            this.pesquisarButton.Name = "pesquisarButton";
            this.pesquisarButton.Size = new System.Drawing.Size(75, 23);
            this.pesquisarButton.TabIndex = 7;
            this.pesquisarButton.Text = "Pesquisar";
            this.pesquisarButton.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1106, 461);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.exibirwebBrowser);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1098, 435);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // exibirwebBrowser
            // 
            this.exibirwebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exibirwebBrowser.Location = new System.Drawing.Point(3, 3);
            this.exibirwebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.exibirwebBrowser.Name = "exibirwebBrowser";
            this.exibirwebBrowser.Size = new System.Drawing.Size(1092, 429);
            this.exibirwebBrowser.TabIndex = 0;
            this.exibirwebBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.exibirwebBrowser_Navigating);
            // 
            // irButton
            // 
            this.irButton.Location = new System.Drawing.Point(678, 23);
            this.irButton.Name = "irButton";
            this.irButton.Size = new System.Drawing.Size(30, 23);
            this.irButton.TabIndex = 9;
            this.irButton.Text = "Ir";
            this.irButton.UseVisualStyleBackColor = true;
            this.irButton.Click += new System.EventHandler(this.irButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.statusLabel.Location = new System.Drawing.Point(631, 510);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(480, 23);
            this.statusLabel.TabIndex = 10;
            this.statusLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(19, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 536);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.irButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pesquisarButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.atualizarButton);
            this.Controls.Add(this.adianteButton);
            this.Controls.Add(this.voltarButton);
            this.Controls.Add(this.barraEnderecoTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Navegador Bolt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox barraEnderecoTextBox1;
        private System.Windows.Forms.Button voltarButton;
        private System.Windows.Forms.Button adianteButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaJanelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaJanelaPrivativaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirFavoritosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreOProgramaBoltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licensasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comoUsarOBoltToolStripMenuItem;
        private System.Windows.Forms.Button atualizarButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button pesquisarButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser exibirwebBrowser;
        private System.Windows.Forms.Button irButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

