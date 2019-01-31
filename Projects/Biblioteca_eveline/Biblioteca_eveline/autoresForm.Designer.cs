namespace Biblioteca_eveline
{
    partial class autoresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(autoresForm));
            this.mostrarDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.cadastrarAutorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mostrarDataGridView
            // 
            this.mostrarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostrarDataGridView.Location = new System.Drawing.Point(12, 59);
            this.mostrarDataGridView.Name = "mostrarDataGridView";
            this.mostrarDataGridView.Size = new System.Drawing.Size(535, 376);
            this.mostrarDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Autor: ";
            // 
            // autorTextBox
            // 
            this.autorTextBox.Location = new System.Drawing.Point(91, 21);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(232, 20);
            this.autorTextBox.TabIndex = 2;
            // 
            // cadastrarAutorButton
            // 
            this.cadastrarAutorButton.Location = new System.Drawing.Point(329, 19);
            this.cadastrarAutorButton.Name = "cadastrarAutorButton";
            this.cadastrarAutorButton.Size = new System.Drawing.Size(75, 23);
            this.cadastrarAutorButton.TabIndex = 3;
            this.cadastrarAutorButton.Text = "Cadastrar";
            this.cadastrarAutorButton.UseVisualStyleBackColor = true;
            this.cadastrarAutorButton.Click += new System.EventHandler(this.cadastrarAutorButton_Click);
            // 
            // autoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 456);
            this.Controls.Add(this.cadastrarAutorButton);
            this.Controls.Add(this.autorTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mostrarDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "autoresForm";
            this.Text = "Autores";
            this.Load += new System.EventHandler(this.autoresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mostrarDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mostrarDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.Button cadastrarAutorButton;
    }
}