namespace Biblioteca_eveline
{
    partial class telaPrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaPrincipalForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.locatariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locatariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.incluirExcluirLocatariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarExcluirLivrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emprestarLivrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarBancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locatariosToolStripMenuItem,
            this.livrosToolStripMenuItem,
            this.configurarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // locatariosToolStripMenuItem
            // 
            this.locatariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locatariosToolStripMenuItem1});
            this.locatariosToolStripMenuItem.Name = "locatariosToolStripMenuItem";
            this.locatariosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.locatariosToolStripMenuItem.Text = "Locatarios";
            // 
            // locatariosToolStripMenuItem1
            // 
            this.locatariosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incluirExcluirLocatariosToolStripMenuItem});
            this.locatariosToolStripMenuItem1.Name = "locatariosToolStripMenuItem1";
            this.locatariosToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.locatariosToolStripMenuItem1.Text = "Locatarios";
            // 
            // incluirExcluirLocatariosToolStripMenuItem
            // 
            this.incluirExcluirLocatariosToolStripMenuItem.Name = "incluirExcluirLocatariosToolStripMenuItem";
            this.incluirExcluirLocatariosToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.incluirExcluirLocatariosToolStripMenuItem.Text = "Incluir/Excluir Locatarios";
            this.incluirExcluirLocatariosToolStripMenuItem.Click += new System.EventHandler(this.incluirExcluirLocatariosToolStripMenuItem_Click);
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livrosToolStripMenuItem1});
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.livrosToolStripMenuItem.Text = "Livros";
            this.livrosToolStripMenuItem.Click += new System.EventHandler(this.livrosToolStripMenuItem_Click);
            // 
            // livrosToolStripMenuItem1
            // 
            this.livrosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarExcluirLivrosToolStripMenuItem,
            this.emprestarLivrosToolStripMenuItem});
            this.livrosToolStripMenuItem1.Name = "livrosToolStripMenuItem1";
            this.livrosToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.livrosToolStripMenuItem1.Text = "Livros";
            this.livrosToolStripMenuItem1.Click += new System.EventHandler(this.livrosToolStripMenuItem1_Click);
            // 
            // cadastrarExcluirLivrosToolStripMenuItem
            // 
            this.cadastrarExcluirLivrosToolStripMenuItem.Name = "cadastrarExcluirLivrosToolStripMenuItem";
            this.cadastrarExcluirLivrosToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.cadastrarExcluirLivrosToolStripMenuItem.Text = "Cadastrar/Excluir Livros";
            this.cadastrarExcluirLivrosToolStripMenuItem.Click += new System.EventHandler(this.cadastrarExcluirLivrosToolStripMenuItem_Click);
            // 
            // emprestarLivrosToolStripMenuItem
            // 
            this.emprestarLivrosToolStripMenuItem.Name = "emprestarLivrosToolStripMenuItem";
            this.emprestarLivrosToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.emprestarLivrosToolStripMenuItem.Text = "Emprestar Livros";
            this.emprestarLivrosToolStripMenuItem.Click += new System.EventHandler(this.emprestarLivrosToolStripMenuItem_Click);
            // 
            // configurarToolStripMenuItem
            // 
            this.configurarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarBancoToolStripMenuItem});
            this.configurarToolStripMenuItem.Name = "configurarToolStripMenuItem";
            this.configurarToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.configurarToolStripMenuItem.Text = "Configurar";
            // 
            // configurarBancoToolStripMenuItem
            // 
            this.configurarBancoToolStripMenuItem.Name = "configurarBancoToolStripMenuItem";
            this.configurarBancoToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.configurarBancoToolStripMenuItem.Text = "Configurar Banco de Dados";
            this.configurarBancoToolStripMenuItem.Click += new System.EventHandler(this.configurarBancoToolStripMenuItem_Click);
            // 
            // telaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 454);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "telaPrincipalForm";
            this.Text = "Bem vindo ao software bilioteca ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaPrincipalForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem locatariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locatariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem incluirExcluirLocatariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarExcluirLivrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emprestarLivrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarBancoToolStripMenuItem;
    }
}