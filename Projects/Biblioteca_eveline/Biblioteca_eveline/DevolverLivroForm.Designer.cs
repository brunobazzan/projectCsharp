namespace Biblioteca_eveline
{
    partial class DevolverLivroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevolverLivroForm));
            this.label1 = new System.Windows.Forms.Label();
            this.codigoLivroTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codigoLocatarioTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataEntregaTextBox = new System.Windows.Forms.TextBox();
            this.entregarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Do Livro:";
            // 
            // codigoLivroTextBox
            // 
            this.codigoLivroTextBox.Location = new System.Drawing.Point(105, 10);
            this.codigoLivroTextBox.Name = "codigoLivroTextBox";
            this.codigoLivroTextBox.Size = new System.Drawing.Size(167, 20);
            this.codigoLivroTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo do Locatario:";
            // 
            // codigoLocatarioTextBox
            // 
            this.codigoLocatarioTextBox.Location = new System.Drawing.Point(124, 43);
            this.codigoLocatarioTextBox.Name = "codigoLocatarioTextBox";
            this.codigoLocatarioTextBox.Size = new System.Drawing.Size(148, 20);
            this.codigoLocatarioTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data da Entrega:";
            // 
            // dataEntregaTextBox
            // 
            this.dataEntregaTextBox.Location = new System.Drawing.Point(107, 76);
            this.dataEntregaTextBox.Name = "dataEntregaTextBox";
            this.dataEntregaTextBox.Size = new System.Drawing.Size(165, 20);
            this.dataEntregaTextBox.TabIndex = 5;
            this.dataEntregaTextBox.TextChanged += new System.EventHandler(this.dataEntregaTextBox_TextChanged);
            // 
            // entregarButton
            // 
            this.entregarButton.Location = new System.Drawing.Point(16, 118);
            this.entregarButton.Name = "entregarButton";
            this.entregarButton.Size = new System.Drawing.Size(75, 23);
            this.entregarButton.TabIndex = 6;
            this.entregarButton.Text = "Entregar";
            this.entregarButton.UseVisualStyleBackColor = true;
            this.entregarButton.Click += new System.EventHandler(this.entregarButton_Click);
            // 
            // DevolverLivroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 175);
            this.Controls.Add(this.entregarButton);
            this.Controls.Add(this.dataEntregaTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.codigoLocatarioTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codigoLivroTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DevolverLivroForm";
            this.Text = "DevolverLivroForm";
            this.Load += new System.EventHandler(this.DevolverLivroForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codigoLivroTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codigoLocatarioTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dataEntregaTextBox;
        private System.Windows.Forms.Button entregarButton;
    }
}