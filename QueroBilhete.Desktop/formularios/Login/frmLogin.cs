using QueroBilhete.Data.Repositories;
using QueroBilhete.Desktop.Globais;
using QueroBilhete.Service.Service;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueroBilhete.Desktop.formularios.Login
{
    public partial class frmLogin : Form
    {
        private readonly BaseRepository baseRepository;
        public frmLogin()
        {
            InitializeComponent();
            baseRepository = new BaseRepository();
        }

        private async void btnLogin_Click(object sender, System.EventArgs e)
        {
            Gerais.Logado = ValidaLogin(txtEmail.Text, txtSenha.Text);

            lblAlerta.Text = Gerais.Logado ? "Liberado" : "Email/Senha inválido.";

            if (Gerais.Logado)
            {
                lblAlerta.Text = "Liberado";
                await PausaComTaskDelay();
                Close();
            }
            else
            {
                lblAlerta.Text = "Email/Senha inválido.";
            }
        }

        async Task PausaComTaskDelay()
        {
            await Task.Delay(1000);
        }

        private bool ValidaLogin(string email, string senha)
        {
            var login = new LoginService(baseRepository).logar(email, senha);

            if(!string.IsNullOrEmpty(login.Email) && !string.IsNullOrEmpty(login.Senha))
            {
                Gerais.Email = login.Email;
                Gerais.Senha = login.Senha;

                return true;
            }

            return false;
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                    break;
                default:
                    break;
            }
        }
    }
}
