using System.Windows.Forms;

namespace QueroBilhete.Desktop.formularios.Usuario
{
    public partial class frmUsuario : Form
    {
        private void Sair()
        {
            Close();
        }
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, System.EventArgs e)
        {
            Sair();
        }
    }
}
