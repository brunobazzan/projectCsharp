namespace Biblioteca_Andreza
{
    partial class telaConfiguracao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaConfiguracao));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.servidorTextBox = new System.Windows.Forms.TextBox();
            this.dataBaseTextBox = new System.Windows.Forms.TextBox();
            this.usuarioSenhaCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.configurarButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DataBase:";
            // 
            // servidorTextBox
            // 
            this.servidorTextBox.Location = new System.Drawing.Point(63, 16);
            this.servidorTextBox.Name = "servidorTextBox";
            this.servidorTextBox.Size = new System.Drawing.Size(175, 20);
            this.servidorTextBox.TabIndex = 2;
            // 
            // dataBaseTextBox
            // 
            this.dataBaseTextBox.Location = new System.Drawing.Point(71, 42);
            this.dataBaseTextBox.Name = "dataBaseTextBox";
            this.dataBaseTextBox.Size = new System.Drawing.Size(167, 20);
            this.dataBaseTextBox.TabIndex = 3;
            // 
            // usuarioSenhaCheckBox
            // 
            this.usuarioSenhaCheckBox.AutoSize = true;
            this.usuarioSenhaCheckBox.Location = new System.Drawing.Point(13, 93);
            this.usuarioSenhaCheckBox.Name = "usuarioSenhaCheckBox";
            this.usuarioSenhaCheckBox.Size = new System.Drawing.Size(241, 17);
            this.usuarioSenhaCheckBox.TabIndex = 4;
            this.usuarioSenhaCheckBox.Text = "Meu banco de dados possui usuario e senha ";
            this.usuarioSenhaCheckBox.UseVisualStyleBackColor = true;
            this.usuarioSenhaCheckBox.CheckedChanged += new System.EventHandler(this.usuarioSenhaCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataBaseTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.servidorTextBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 74);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servidor e Database";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.senhaTextBox);
            this.groupBox2.Controls.Add(this.usuarioTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 73);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuario e senha";
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Enabled = false;
            this.senhaTextBox.Location = new System.Drawing.Point(55, 43);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(135, 20);
            this.senhaTextBox.TabIndex = 3;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.Enabled = false;
            this.usuarioTextBox.Location = new System.Drawing.Point(59, 17);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(131, 20);
            this.usuarioTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Usuario:";
            // 
            // configurarButton
            // 
            this.configurarButton.Location = new System.Drawing.Point(13, 196);
            this.configurarButton.Name = "configurarButton";
            this.configurarButton.Size = new System.Drawing.Size(107, 23);
            this.configurarButton.TabIndex = 7;
            this.configurarButton.Text = "Configurar Servidor";
            this.configurarButton.UseVisualStyleBackColor = true;
            this.configurarButton.Click += new System.EventHandler(this.configurarButton_Click);
            // 
            // telaConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 235);
            this.Controls.Add(this.configurarButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.usuarioSenhaCheckBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "telaConfiguracao";
            this.Text = "Configurar Banco de Dados";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox servidorTextBox;
        private System.Windows.Forms.TextBox dataBaseTextBox;
        private System.Windows.Forms.CheckBox usuarioSenhaCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button configurarButton;
    }
}