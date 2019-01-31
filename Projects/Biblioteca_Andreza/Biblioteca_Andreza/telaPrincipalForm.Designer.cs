namespace Biblioteca_Andreza
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.locatariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarLocatariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarLivrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emprestarDevolverLivrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarBancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreOSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locatariosToolStripMenuItem,
            this.livrosToolStripMenuItem,
            this.configuraçãoToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(666, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // locatariosToolStripMenuItem
            // 
            this.locatariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarLocatariosToolStripMenuItem});
            this.locatariosToolStripMenuItem.Name = "locatariosToolStripMenuItem";
            this.locatariosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.locatariosToolStripMenuItem.Text = "Locatarios";
            // 
            // gerenciarLocatariosToolStripMenuItem
            // 
            this.gerenciarLocatariosToolStripMenuItem.Name = "gerenciarLocatariosToolStripMenuItem";
            this.gerenciarLocatariosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.gerenciarLocatariosToolStripMenuItem.Text = "Gerenciar Locatarios";
            this.gerenciarLocatariosToolStripMenuItem.Click += new System.EventHandler(this.gerenciarLocatariosToolStripMenuItem_Click);
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarLivrosToolStripMenuItem,
            this.emprestarDevolverLivrosToolStripMenuItem});
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.livrosToolStripMenuItem.Text = "Livros";
            // 
            // gerenciarLivrosToolStripMenuItem
            // 
            this.gerenciarLivrosToolStripMenuItem.Name = "gerenciarLivrosToolStripMenuItem";
            this.gerenciarLivrosToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.gerenciarLivrosToolStripMenuItem.Text = "Gerenciar Livros ";
            this.gerenciarLivrosToolStripMenuItem.Click += new System.EventHandler(this.gerenciarLivrosToolStripMenuItem_Click);
            // 
            // emprestarDevolverLivrosToolStripMenuItem
            // 
            this.emprestarDevolverLivrosToolStripMenuItem.Name = "emprestarDevolverLivrosToolStripMenuItem";
            this.emprestarDevolverLivrosToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.emprestarDevolverLivrosToolStripMenuItem.Text = "Emprestar / Devolver Livros";
            this.emprestarDevolverLivrosToolStripMenuItem.Click += new System.EventHandler(this.emprestarDevolverLivrosToolStripMenuItem_Click);
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
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreOSoftwareToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.sobreToolStripMenuItem.Text = "Sobre ";
            // 
            // sobreOSoftwareToolStripMenuItem
            // 
            this.sobreOSoftwareToolStripMenuItem.Name = "sobreOSoftwareToolStripMenuItem";
            this.sobreOSoftwareToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.sobreOSoftwareToolStripMenuItem.Text = "Sobre o Software";
            // 
            // telaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 548);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "telaPrincipalForm";
            this.Text = "Bem Vindo a Biblioteca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaPrincipalForm_FormClosing);
            this.Load += new System.EventHandler(this.telaPrincipalForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem locatariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarLocatariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarLivrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emprestarDevolverLivrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarBancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreOSoftwareToolStripMenuItem;
    }
}