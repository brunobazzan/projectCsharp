using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_eveline
{
    public partial class telaLoginForm : Form
    {
        public telaLoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            telaPrincipalForm principal = new telaPrincipalForm();
            principal.Show();
            this.Close();     
        }
    }
}
