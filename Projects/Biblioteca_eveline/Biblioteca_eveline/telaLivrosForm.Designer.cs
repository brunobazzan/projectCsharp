namespace Biblioteca_eveline
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaLivrosForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastarLivrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirLivrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procurarLivrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarExcluirAutoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarExcluirAutorEspiritualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lIVROSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bIBLIOTECA_EVELIONEDataSet = new Biblioteca_eveline.BIBLIOTECA_EVELIONEDataSet();
            this.lIVROSTableAdapter = new Biblioteca_eveline.BIBLIOTECA_EVELIONEDataSetTableAdapters.LIVROSTableAdapter();
            this.mostrarDataGridView = new System.Windows.Forms.DataGridView();
            this.atualizarButton = new System.Windows.Forms.Button();
            this.servidorLabel = new System.Windows.Forms.Label();
            this.bandoDadosLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lIVROSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECA_EVELIONEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livrosToolStripMenuItem,
            this.procurarToolStripMenuItem,
            this.autoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(738, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastarLivrosToolStripMenuItem,
            this.excluirLivrosToolStripMenuItem});
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.livrosToolStripMenuItem.Text = "Livros ";
            // 
            // cadastarLivrosToolStripMenuItem
            // 
            this.cadastarLivrosToolStripMenuItem.Name = "cadastarLivrosToolStripMenuItem";
            this.cadastarLivrosToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.cadastarLivrosToolStripMenuItem.Text = "Cadastar Livros";
            this.cadastarLivrosToolStripMenuItem.Click += new System.EventHandler(this.cadastarLivrosToolStripMenuItem_Click);
            // 
            // excluirLivrosToolStripMenuItem
            // 
            this.excluirLivrosToolStripMenuItem.Name = "excluirLivrosToolStripMenuItem";
            this.excluirLivrosToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.excluirLivrosToolStripMenuItem.Text = "Excluir Livros";
            this.excluirLivrosToolStripMenuItem.Click += new System.EventHandler(this.excluirLivrosToolStripMenuItem_Click);
            // 
            // procurarToolStripMenuItem
            // 
            this.procurarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procurarLivrosToolStripMenuItem});
            this.procurarToolStripMenuItem.Name = "procurarToolStripMenuItem";
            this.procurarToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.procurarToolStripMenuItem.Text = "Procurar";
            // 
            // procurarLivrosToolStripMenuItem
            // 
            this.procurarLivrosToolStripMenuItem.Name = "procurarLivrosToolStripMenuItem";
            this.procurarLivrosToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.procurarLivrosToolStripMenuItem.Text = "Procurar Livros";
            this.procurarLivrosToolStripMenuItem.Click += new System.EventHandler(this.procurarLivrosToolStripMenuItem_Click);
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarExcluirAutoresToolStripMenuItem,
            this.cadastrarExcluirAutorEspiritualToolStripMenuItem});
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.autoresToolStripMenuItem.Text = "Autores";
            // 
            // cadastrarExcluirAutoresToolStripMenuItem
            // 
            this.cadastrarExcluirAutoresToolStripMenuItem.Name = "cadastrarExcluirAutoresToolStripMenuItem";
            this.cadastrarExcluirAutoresToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.cadastrarExcluirAutoresToolStripMenuItem.Text = "Cadastrar/ Excluir Autores";
            this.cadastrarExcluirAutoresToolStripMenuItem.Click += new System.EventHandler(this.cadastrarExcluirAutoresToolStripMenuItem_Click);
            // 
            // cadastrarExcluirAutorEspiritualToolStripMenuItem
            // 
            this.cadastrarExcluirAutorEspiritualToolStripMenuItem.Name = "cadastrarExcluirAutorEspiritualToolStripMenuItem";
            this.cadastrarExcluirAutorEspiritualToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.cadastrarExcluirAutorEspiritualToolStripMenuItem.Text = "Cadastrar/Excluir Autor Espiritual";
            this.cadastrarExcluirAutorEspiritualToolStripMenuItem.Click += new System.EventHandler(this.cadastrarExcluirAutorEspiritualToolStripMenuItem_Click);
            // 
            // lIVROSBindingSource
            // 
            this.lIVROSBindingSource.DataMember = "LIVROS";
            this.lIVROSBindingSource.DataSource = this.bIBLIOTECA_EVELIONEDataSet;
            // 
            // bIBLIOTECA_EVELIONEDataSet
            // 
            this.bIBLIOTECA_EVELIONEDataSet.DataSetName = "BIBLIOTECA_EVELIONEDataSet";
            this.bIBLIOTECA_EVELIONEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lIVROSTableAdapter
            // 
            this.lIVROSTableAdapter.ClearBeforeFill = true;
            // 
            // mostrarDataGridView
            // 
            this.mostrarDataGridView.AllowUserToAddRows = false;
            this.mostrarDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mostrarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostrarDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.mostrarDataGridView.Location = new System.Drawing.Point(12, 52);
            this.mostrarDataGridView.Name = "mostrarDataGridView";
            this.mostrarDataGridView.Size = new System.Drawing.Size(713, 421);
            this.mostrarDataGridView.TabIndex = 1;
            this.mostrarDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mostrarDataGridView_CellContentClick);
            // 
            // atualizarButton
            // 
            this.atualizarButton.Location = new System.Drawing.Point(13, 28);
            this.atualizarButton.Name = "atualizarButton";
            this.atualizarButton.Size = new System.Drawing.Size(75, 23);
            this.atualizarButton.TabIndex = 2;
            this.atualizarButton.Text = "Atualizar";
            this.atualizarButton.UseVisualStyleBackColor = true;
            this.atualizarButton.Click += new System.EventHandler(this.atualizarButton_Click);
            // 
            // servidorLabel
            // 
            this.servidorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.servidorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.servidorLabel.Location = new System.Drawing.Point(9, 483);
            this.servidorLabel.Name = "servidorLabel";
            this.servidorLabel.Size = new System.Drawing.Size(148, 23);
            this.servidorLabel.TabIndex = 3;
            // 
            // bandoDadosLabel
            // 
            this.bandoDadosLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bandoDadosLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bandoDadosLabel.Location = new System.Drawing.Point(163, 483);
            this.bandoDadosLabel.Name = "bandoDadosLabel";
            this.bandoDadosLabel.Size = new System.Drawing.Size(156, 23);
            this.bandoDadosLabel.TabIndex = 4;
            // 
            // telaLivrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 515);
            this.Controls.Add(this.bandoDadosLabel);
            this.Controls.Add(this.servidorLabel);
            this.Controls.Add(this.atualizarButton);
            this.Controls.Add(this.mostrarDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "telaLivrosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar/Consultar Livros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.telaLivrosForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lIVROSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECA_EVELIONEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastarLivrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirLivrosToolStripMenuItem;
        private BIBLIOTECA_EVELIONEDataSet bIBLIOTECA_EVELIONEDataSet;
        private System.Windows.Forms.BindingSource lIVROSBindingSource;
        private BIBLIOTECA_EVELIONEDataSetTableAdapters.LIVROSTableAdapter lIVROSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem procurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procurarLivrosToolStripMenuItem;
        private System.Windows.Forms.DataGridView mostrarDataGridView;
        private System.Windows.Forms.Button atualizarButton;
        private System.Windows.Forms.Label servidorLabel;
        private System.Windows.Forms.Label bandoDadosLabel;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarExcluirAutoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarExcluirAutorEspiritualToolStripMenuItem;
    }
}