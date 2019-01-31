namespace Biblioteca_eveline
{
    partial class configurarBancoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(configurarBancoForm));
            this.label1 = new System.Windows.Forms.Label();
            this.servidorTextBox = new System.Windows.Forms.TextBox();
            this.configurarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.baseTextBox = new System.Windows.Forms.TextBox();
            this.bancoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do servidor de dados:";
            // 
            // servidorTextBox
            // 
            this.servidorTextBox.Location = new System.Drawing.Point(159, 10);
            this.servidorTextBox.Name = "servidorTextBox";
            this.servidorTextBox.Size = new System.Drawing.Size(140, 20);
            this.servidorTextBox.TabIndex = 1;
            // 
            // configurarButton
            // 
            this.configurarButton.Location = new System.Drawing.Point(12, 61);
            this.configurarButton.Name = "configurarButton";
            this.configurarButton.Size = new System.Drawing.Size(75, 23);
            this.configurarButton.TabIndex = 2;
            this.configurarButton.Text = "Configurar";
            this.configurarButton.UseVisualStyleBackColor = true;
            this.configurarButton.Click += new System.EventHandler(this.configurarButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome da database:";
            // 
            // baseTextBox
            // 
            this.baseTextBox.Location = new System.Drawing.Point(117, 35);
            this.baseTextBox.Name = "baseTextBox";
            this.baseTextBox.Size = new System.Drawing.Size(182, 20);
            this.baseTextBox.TabIndex = 4;
            // 
            // bancoButton
            // 
            this.bancoButton.Location = new System.Drawing.Point(117, 61);
            this.bancoButton.Name = "bancoButton";
            this.bancoButton.Size = new System.Drawing.Size(141, 23);
            this.bancoButton.TabIndex = 5;
            this.bancoButton.Text = "Configurar As Tabelas";
            this.bancoButton.UseVisualStyleBackColor = true;
            this.bancoButton.Click += new System.EventHandler(this.bancoButton_Click);
            // 
            // configurarBancoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 99);
            this.Controls.Add(this.bancoButton);
            this.Controls.Add(this.baseTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.configurarButton);
            this.Controls.Add(this.servidorTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "configurarBancoForm";
            this.Text = "Configurar Banco";
            this.Load += new System.EventHandler(this.configurarBancoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox servidorTextBox;
        private System.Windows.Forms.Button configurarButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox baseTextBox;
        private System.Windows.Forms.Button bancoButton;
    }
}