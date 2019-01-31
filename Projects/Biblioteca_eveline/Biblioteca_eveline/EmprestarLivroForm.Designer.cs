namespace Biblioteca_eveline
{
    partial class EmprestarLivroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmprestarLivroForm));
            this.label1 = new System.Windows.Forms.Label();
            this.codigoLivroTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codigoClienteTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gravarButton = new System.Windows.Forms.Button();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo do Livro:";
            // 
            // codigoLivroTextBox
            // 
            this.codigoLivroTextBox.Location = new System.Drawing.Point(13, 26);
            this.codigoLivroTextBox.Name = "codigoLivroTextBox";
            this.codigoLivroTextBox.Size = new System.Drawing.Size(158, 20);
            this.codigoLivroTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo Cliente:";
            // 
            // codigoClienteTextBox
            // 
            this.codigoClienteTextBox.Location = new System.Drawing.Point(12, 77);
            this.codigoClienteTextBox.Name = "codigoClienteTextBox";
            this.codigoClienteTextBox.Size = new System.Drawing.Size(159, 20);
            this.codigoClienteTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data do emprestimo:";
            // 
            // gravarButton
            // 
            this.gravarButton.Location = new System.Drawing.Point(12, 196);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(75, 23);
            this.gravarButton.TabIndex = 6;
            this.gravarButton.Text = "Cadastrar";
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.gravarButton_Click);
            // 
            // dataTextBox
            // 
            this.dataTextBox.Location = new System.Drawing.Point(12, 136);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(164, 20);
            this.dataTextBox.TabIndex = 7;
            this.dataTextBox.TextChanged += new System.EventHandler(this.dataTextBox_TextChanged);
            // 
            // EmprestarLivroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.gravarButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.codigoClienteTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codigoLivroTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmprestarLivroForm";
            this.Text = "EmprestarLivroForm";
            this.Load += new System.EventHandler(this.EmprestarLivroForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codigoLivroTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codigoClienteTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.TextBox dataTextBox;
    }
}