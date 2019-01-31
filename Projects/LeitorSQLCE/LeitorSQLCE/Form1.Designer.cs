namespace LeitorSQLCE
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirABaseDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivoOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.queryTextBox = new System.Windows.Forms.TextBox();
            this.resultadoDataGridView = new System.Windows.Forms.DataGridView();
            this.caminhotextBox1 = new System.Windows.Forms.TextBox();
            this.executarButton = new System.Windows.Forms.Button();
            this.tabelaDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(733, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirABaseDeDadosToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // abrirABaseDeDadosToolStripMenuItem
            // 
            this.abrirABaseDeDadosToolStripMenuItem.Name = "abrirABaseDeDadosToolStripMenuItem";
            this.abrirABaseDeDadosToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.abrirABaseDeDadosToolStripMenuItem.Text = "Abrir a Base de dados";
            this.abrirABaseDeDadosToolStripMenuItem.Click += new System.EventHandler(this.abrirABaseDeDadosToolStripMenuItem_Click);
            // 
            // arquivoOpenFileDialog
            // 
            this.arquivoOpenFileDialog.FileName = "openFileDialog1";
            // 
            // queryTextBox
            // 
            this.queryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryTextBox.Location = new System.Drawing.Point(184, 59);
            this.queryTextBox.Multiline = true;
            this.queryTextBox.Name = "queryTextBox";
            this.queryTextBox.Size = new System.Drawing.Size(537, 247);
            this.queryTextBox.TabIndex = 1;
            this.queryTextBox.TextChanged += new System.EventHandler(this.queryTextBox_TextChanged);
            // 
            // resultadoDataGridView
            // 
            this.resultadoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultadoDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.resultadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultadoDataGridView.Location = new System.Drawing.Point(184, 313);
            this.resultadoDataGridView.Name = "resultadoDataGridView";
            this.resultadoDataGridView.Size = new System.Drawing.Size(537, 258);
            this.resultadoDataGridView.TabIndex = 2;
            this.resultadoDataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resultadoDataGridView_KeyPress);
            // 
            // caminhotextBox1
            // 
            this.caminhotextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.caminhotextBox1.Enabled = false;
            this.caminhotextBox1.Location = new System.Drawing.Point(13, 578);
            this.caminhotextBox1.Name = "caminhotextBox1";
            this.caminhotextBox1.Size = new System.Drawing.Size(708, 20);
            this.caminhotextBox1.TabIndex = 3;
            // 
            // executarButton
            // 
            this.executarButton.Location = new System.Drawing.Point(184, 30);
            this.executarButton.Name = "executarButton";
            this.executarButton.Size = new System.Drawing.Size(75, 23);
            this.executarButton.TabIndex = 4;
            this.executarButton.Text = "Executar";
            this.executarButton.UseVisualStyleBackColor = true;
            this.executarButton.Click += new System.EventHandler(this.executarButton_Click);
            // 
            // tabelaDataGridView
            // 
            this.tabelaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabelaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaDataGridView.Location = new System.Drawing.Point(6, 59);
            this.tabelaDataGridView.Name = "tabelaDataGridView";
            this.tabelaDataGridView.Size = new System.Drawing.Size(172, 512);
            this.tabelaDataGridView.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 610);
            this.Controls.Add(this.tabelaDataGridView);
            this.Controls.Add(this.executarButton);
            this.Controls.Add(this.caminhotextBox1);
            this.Controls.Add(this.resultadoDataGridView);
            this.Controls.Add(this.queryTextBox);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL CE Editor";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirABaseDeDadosToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog arquivoOpenFileDialog;
        private System.Windows.Forms.TextBox queryTextBox;
        private System.Windows.Forms.DataGridView resultadoDataGridView;
        private System.Windows.Forms.TextBox caminhotextBox1;
        private System.Windows.Forms.Button executarButton;
        private System.Windows.Forms.DataGridView tabelaDataGridView;
    }
}

