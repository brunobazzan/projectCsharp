namespace Biblioteca_eveline
{
    partial class telaEmprestimoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaEmprestimoForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.emprestimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emprestarLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolverLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarDataGridView = new System.Windows.Forms.DataGridView();
            this.atualizaButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emprestimoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // emprestimoToolStripMenuItem
            // 
            this.emprestimoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emprestarLivroToolStripMenuItem,
            this.devolverLivroToolStripMenuItem});
            this.emprestimoToolStripMenuItem.Name = "emprestimoToolStripMenuItem";
            this.emprestimoToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.emprestimoToolStripMenuItem.Text = "Emprestimo";
            // 
            // emprestarLivroToolStripMenuItem
            // 
            this.emprestarLivroToolStripMenuItem.Name = "emprestarLivroToolStripMenuItem";
            this.emprestarLivroToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.emprestarLivroToolStripMenuItem.Text = "Emprestar Livro";
            this.emprestarLivroToolStripMenuItem.Click += new System.EventHandler(this.emprestarLivroToolStripMenuItem_Click);
            // 
            // devolverLivroToolStripMenuItem
            // 
            this.devolverLivroToolStripMenuItem.Name = "devolverLivroToolStripMenuItem";
            this.devolverLivroToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.devolverLivroToolStripMenuItem.Text = "Devolver Livro";
            this.devolverLivroToolStripMenuItem.Click += new System.EventHandler(this.devolverLivroToolStripMenuItem_Click);
            // 
            // mostrarDataGridView
            // 
            this.mostrarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostrarDataGridView.Location = new System.Drawing.Point(12, 73);
            this.mostrarDataGridView.Name = "mostrarDataGridView";
            this.mostrarDataGridView.Size = new System.Drawing.Size(626, 419);
            this.mostrarDataGridView.TabIndex = 1;
            // 
            // atualizaButton
            // 
            this.atualizaButton.Location = new System.Drawing.Point(12, 37);
            this.atualizaButton.Name = "atualizaButton";
            this.atualizaButton.Size = new System.Drawing.Size(75, 23);
            this.atualizaButton.TabIndex = 2;
            this.atualizaButton.Text = "Atualizar";
            this.atualizaButton.UseVisualStyleBackColor = true;
            this.atualizaButton.Click += new System.EventHandler(this.atualizaButton_Click);
            // 
            // telaEmprestimoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 504);
            this.Controls.Add(this.atualizaButton);
            this.Controls.Add(this.mostrarDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "telaEmprestimoForm";
            this.Text = "telaEmprestimoForm";
            this.Load += new System.EventHandler(this.telaEmprestimoForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView mostrarDataGridView;
        private System.Windows.Forms.ToolStripMenuItem emprestimoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emprestarLivroToolStripMenuItem;
        private System.Windows.Forms.Button atualizaButton;
        private System.Windows.Forms.ToolStripMenuItem devolverLivroToolStripMenuItem;
    }
}