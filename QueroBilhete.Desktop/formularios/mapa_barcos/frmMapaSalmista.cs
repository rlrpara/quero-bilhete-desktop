using System;
using System.Windows.Forms;

namespace QueroBilhete.Desktop.formularios.mapa_barcos
{
    public partial class frmMapaSalmista : Form
    {
        public frmMapaSalmista()
        {
            InitializeComponent();
        }

        private void DesenhaBotao()
        {
            int top = 50;
            int left = 100;

            for (int i = 0; i <= 5; i++)
            {
                Button button = new Button();
                button.Left = left;
                button.Top = top;
                button.Click += Button_Click;
                button.Name = $"C0{i}";
                button.Text = $"C0{i}";
                panel1.Controls.Add(button); // here
                top += button.Height + 2;
                left -= 10;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            MessageBox.Show(button.Name);
        }

        private void frmMapaSalmista_Load(object sender, EventArgs e)
        {
            DesenhaBotao();
        }
    }
}
