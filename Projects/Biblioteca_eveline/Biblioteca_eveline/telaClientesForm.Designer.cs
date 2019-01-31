namespace Biblioteca_eveline
{
    partial class telaClientesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaClientesForm));
            this.mostraDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarLocatarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirLocatarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procurarLocatariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mostraDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mostraDataGridView
            // 
            this.mostraDataGridView.AllowUserToAddRows = false;
            this.mostraDataGridView.AllowUserToDeleteRows = false;
            this.mostraDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.mostraDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mostraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostraDataGridView.Location = new System.Drawing.Point(8, 55);
            this.mostraDataGridView.Name = "mostraDataGridView";
            this.mostraDataGridView.Size = new System.Drawing.Size(683, 386);
            this.mostraDataGridView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.procurarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(697, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarLocatarioToolStripMenuItem,
            this.excluirLocatarioToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.clienteToolStripMenuItem.Text = "Locatarios";
            // 
            // cadastrarLocatarioToolStripMenuItem
            // 
            this.cadastrarLocatarioToolStripMenuItem.Name = "cadastrarLocatarioToolStripMenuItem";
            this.cadastrarLocatarioToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.cadastrarLocatarioToolStripMenuItem.Text = "Cadastrar Locatario";
            this.cadastrarLocatarioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarLocatarioToolStripMenuItem_Click);
            // 
            // excluirLocatarioToolStripMenuItem
            // 
            this.excluirLocatarioToolStripMenuItem.Name = "excluirLocatarioToolStripMenuItem";
            this.excluirLocatarioToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.excluirLocatarioToolStripMenuItem.Text = "Excluir Locatario";
            this.excluirLocatarioToolStripMenuItem.Click += new System.EventHandler(this.excluirLocatarioToolStripMenuItem_Click);
            // 
            // procurarToolStripMenuItem
            // 
            this.procurarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procurarLocatariosToolStripMenuItem});
            this.procurarToolStripMenuItem.Name = "procurarToolStripMenuItem";
            this.procurarToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.procurarToolStripMenuItem.Text = "Procurar";
            // 
            // procurarLocatariosToolStripMenuItem
            // 
            this.procurarLocatariosToolStripMenuItem.Name = "procurarLocatariosToolStripMenuItem";
            this.procurarLocatariosToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.procurarLocatariosToolStripMenuItem.Text = "Procurar Locatarios";
            this.procurarLocatariosToolStripMenuItem.Click += new System.EventHandler(this.procurarLocatariosToolStripMenuItem_Click);
            // 
            // atualizarButton
            // 
            this.atualizarButton.Location = new System.Drawing.Point(12, 26);
            this.atualizarButton.Name = "atualizarButton";
            this.atualizarButton.Size = new System.Drawing.Size(75, 23);
            this.atualizarButton.TabIndex = 2;
            this.atualizarButton.Text = "Atualizar";
            this.atualizarButton.UseVisualStyleBackColor = true;
            this.atualizarButton.Click += new System.EventHandler(this.atualizarButton_Click);
            // 
            // telaClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 453);
            this.Controls.Add(this.atualizarButton);
            this.Controls.Add(this.mostraDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "telaClientesForm";
            this.Text = "Locatarios";
            this.Load += new System.EventHandler(this.telaClientesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mostraDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mostraDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarLocatarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirLocatarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procurarLocatariosToolStripMenuItem;
        private System.Windows.Forms.Button atualizarButton;
    }
}