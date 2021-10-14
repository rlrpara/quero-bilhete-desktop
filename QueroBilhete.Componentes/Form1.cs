using System;
using System.Windows.Forms;

namespace QueroBilhete.Componentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCodigo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicou no Código");
        }

        private void txtCliente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicou no Cliente");
        }

        private void txtCodigo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Código em foco";
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F5)
            {
                MessageBox.Show("Apertou f5");
            }
        }
    }
}
