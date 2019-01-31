namespace lab_01
{
    partial class Lab01Form
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
            this.gravarButton = new System.Windows.Forms.Button();
            this.cambioComboBox = new System.Windows.Forms.ComboBox();
            this.combustivelComboBox = new System.Windows.Forms.ComboBox();
            this.marcaComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toquesLabel = new System.Windows.Forms.Label();
            this.placaTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.corTextBox = new System.Windows.Forms.TextBox();
            this.anoTextBox = new System.Windows.Forms.TextBox();
            this.observacaoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gravarButton
            // 
            this.gravarButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gravarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gravarButton.Location = new System.Drawing.Point(448, 9);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(88, 47);
            this.gravarButton.TabIndex = 0;
            this.gravarButton.Text = "Gravar";
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.gravarButton_Click);
            // 
            // cambioComboBox
            // 
            this.cambioComboBox.AccessibleName = "Câmbio";
            this.cambioComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cambioComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cambioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cambioComboBox.FormattingEnabled = true;
            this.cambioComboBox.Location = new System.Drawing.Point(276, 62);
            this.cambioComboBox.Name = "cambioComboBox";
            this.cambioComboBox.Size = new System.Drawing.Size(121, 21);
            this.cambioComboBox.TabIndex = 1;
            // 
            // combustivelComboBox
            // 
            this.combustivelComboBox.AccessibleName = "Combustivel";
            this.combustivelComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combustivelComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combustivelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combustivelComboBox.FormattingEnabled = true;
            this.combustivelComboBox.Location = new System.Drawing.Point(299, 35);
            this.combustivelComboBox.Name = "combustivelComboBox";
            this.combustivelComboBox.Size = new System.Drawing.Size(121, 21);
            this.combustivelComboBox.TabIndex = 2;
            // 
            // marcaComboBox
            // 
            this.marcaComboBox.AccessibleName = "Marca";
            this.marcaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.marcaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.marcaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marcaComboBox.FormattingEnabled = true;
            this.marcaComboBox.Location = new System.Drawing.Point(266, 8);
            this.marcaComboBox.Name = "marcaComboBox";
            this.marcaComboBox.Size = new System.Drawing.Size(121, 21);
            this.marcaComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "&Placa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "&Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "&Cor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "&Ano:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(214, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Marca:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(214, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Combustivel:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(214, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Câmbio: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Observação:";
            // 
            // toquesLabel
            // 
            this.toquesLabel.Location = new System.Drawing.Point(344, 112);
            this.toquesLabel.Name = "toquesLabel";
            this.toquesLabel.Size = new System.Drawing.Size(76, 13);
            this.toquesLabel.TabIndex = 12;
            this.toquesLabel.Text = "Restante: 300";
            this.toquesLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // placaTextBox
            // 
            this.placaTextBox.AccessibleName = "Placa";
            this.placaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.placaTextBox.Location = new System.Drawing.Point(53, 9);
            this.placaTextBox.MaxLength = 7;
            this.placaTextBox.Name = "placaTextBox";
            this.placaTextBox.Size = new System.Drawing.Size(100, 20);
            this.placaTextBox.TabIndex = 13;
            this.placaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.AccessibleName = "Modelo";
            this.modeloTextBox.Location = new System.Drawing.Point(66, 35);
            this.modeloTextBox.MaxLength = 30;
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(100, 20);
            this.modeloTextBox.TabIndex = 14;
            // 
            // corTextBox
            // 
            this.corTextBox.AccessibleName = "Cor";
            this.corTextBox.Location = new System.Drawing.Point(53, 61);
            this.corTextBox.MaxLength = 30;
            this.corTextBox.Name = "corTextBox";
            this.corTextBox.Size = new System.Drawing.Size(100, 20);
            this.corTextBox.TabIndex = 15;
            // 
            // anoTextBox
            // 
            this.anoTextBox.AccessibleName = "Ano";
            this.anoTextBox.Location = new System.Drawing.Point(53, 87);
            this.anoTextBox.MaxLength = 4;
            this.anoTextBox.Name = "anoTextBox";
            this.anoTextBox.Size = new System.Drawing.Size(100, 20);
            this.anoTextBox.TabIndex = 16;
            // 
            // observacaoTextBox
            // 
            this.observacaoTextBox.AccessibleName = "Observação";
            this.observacaoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.observacaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observacaoTextBox.Location = new System.Drawing.Point(97, 128);
            this.observacaoTextBox.MaxLength = 300;
            this.observacaoTextBox.Multiline = true;
            this.observacaoTextBox.Name = "observacaoTextBox";
            this.observacaoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.observacaoTextBox.Size = new System.Drawing.Size(323, 74);
            this.observacaoTextBox.TabIndex = 17;
            this.observacaoTextBox.TextChanged += new System.EventHandler(this.observacaoTextBox_TextChanged);
            // 
            // Lab01Form
            // 
            this.AcceptButton = this.gravarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 214);
            this.Controls.Add(this.observacaoTextBox);
            this.Controls.Add(this.anoTextBox);
            this.Controls.Add(this.corTextBox);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(this.placaTextBox);
            this.Controls.Add(this.toquesLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.marcaComboBox);
            this.Controls.Add(this.combustivelComboBox);
            this.Controls.Add(this.cambioComboBox);
            this.Controls.Add(this.gravarButton);
            this.KeyPreview = true;
            this.Name = "Lab01Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratorio";
            this.Load += new System.EventHandler(this.Lab01Form_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Lab01Form_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.ComboBox cambioComboBox;
        private System.Windows.Forms.ComboBox combustivelComboBox;
        private System.Windows.Forms.ComboBox marcaComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label toquesLabel;
        private System.Windows.Forms.TextBox placaTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox corTextBox;
        private System.Windows.Forms.TextBox anoTextBox;
        private System.Windows.Forms.TextBox observacaoTextBox;
    }
}

