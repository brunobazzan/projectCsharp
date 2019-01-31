namespace Biblioteca_eveline
{
    partial class ProcurarLocatarioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcurarLocatarioForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.itensComboBox = new System.Windows.Forms.ComboBox();
            this.procurarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(494, 258);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Coloque o item que deseja procurar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // itemTextBox
            // 
            this.itemTextBox.Location = new System.Drawing.Point(13, 37);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.Size = new System.Drawing.Size(174, 20);
            this.itemTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Está em:";
            // 
            // itensComboBox
            // 
            this.itensComboBox.FormattingEnabled = true;
            this.itensComboBox.Items.AddRange(new object[] {
            "Documento",
            "Nome",
            "Telefone",
            "Endereço",
            "E-mail"});
            this.itensComboBox.Location = new System.Drawing.Point(214, 36);
            this.itensComboBox.Name = "itensComboBox";
            this.itensComboBox.Size = new System.Drawing.Size(155, 21);
            this.itensComboBox.TabIndex = 4;
            // 
            // procurarButton
            // 
            this.procurarButton.Location = new System.Drawing.Point(13, 62);
            this.procurarButton.Name = "procurarButton";
            this.procurarButton.Size = new System.Drawing.Size(75, 23);
            this.procurarButton.TabIndex = 5;
            this.procurarButton.Text = "Procurar";
            this.procurarButton.UseVisualStyleBackColor = true;
            this.procurarButton.Click += new System.EventHandler(this.procurarButton_Click);
            // 
            // ProcurarLocatarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 361);
            this.Controls.Add(this.procurarButton);
            this.Controls.Add(this.itensComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProcurarLocatarioForm";
            this.Text = "ProcurarLocatarioForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox itensComboBox;
        private System.Windows.Forms.Button procurarButton;
    }
}