using QueroBilhete.Data.Repositories;
using QueroBilhete.Service.Service;
using System.Windows.Forms;

namespace QueroBilhete.Desktop.formularios.Login
{
    public partial class frmLogin : Form
    {
        private bool logado = false;
        private string email = string.Empty;
        private string senha = string.Empty;
        private readonly BaseRepository baseRepository = new BaseRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            logado = ValidaLogin(txtEmail.Text, txtSenha.Text);

            lblAlerta.Text = logado ? "Email encontrado" : "Email não encontrado";
            
        }

        private bool ValidaLogin(string email, string senha)
        {
            var login = new LoginService(baseRepository).logar(email, senha);

            return (!string.IsNullOrEmpty(login.Email) && !string.IsNullOrEmpty(login.Email));
        }
    }
}
