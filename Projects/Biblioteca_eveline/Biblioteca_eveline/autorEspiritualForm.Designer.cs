namespace Biblioteca_eveline
{
    partial class autorEspiritualForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(autorEspiritualForm));
            this.mostrarDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.autorEspiritualTextBox = new System.Windows.Forms.TextBox();
            this.gravarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mostrarDataGridView
            // 
            this.mostrarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostrarDataGridView.Location = new System.Drawing.Point(12, 39);
            this.mostrarDataGridView.Name = "mostrarDataGridView";
            this.mostrarDataGridView.Size = new System.Drawing.Size(507, 394);
            this.mostrarDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do autor espiritual:";
            // 
            // autorEspiritualTextBox
            // 
            this.autorEspiritualTextBox.Location = new System.Drawing.Point(139, 12);
            this.autorEspiritualTextBox.Name = "autorEspiritualTextBox";
            this.autorEspiritualTextBox.Size = new System.Drawing.Size(217, 20);
            this.autorEspiritualTextBox.TabIndex = 2;
            // 
            // gravarButton
            // 
            this.gravarButton.Location = new System.Drawing.Point(362, 10);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(75, 23);
            this.gravarButton.TabIndex = 3;
            this.gravarButton.Text = "Gravar";
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.gravarButton_Click);
            // 
            // autorEspiritualForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 451);
            this.Controls.Add(this.gravarButton);
            this.Controls.Add(this.autorEspiritualTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mostrarDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "autorEspiritualForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "autorEspiritualForm";
            this.Load += new System.EventHandler(this.autorEspiritualForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mostrarDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mostrarDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox autorEspiritualTextBox;
        private System.Windows.Forms.Button gravarButton;
    }
}