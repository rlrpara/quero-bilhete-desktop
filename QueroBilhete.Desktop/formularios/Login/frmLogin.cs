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

        private void Sair()
        {
            this.Close();
        }

        public frmLogin()
        {
            InitializeComponent();
            baseRepository = new BaseRepository();
        }

        private async void btnLogin_Click(object sender, System.EventArgs e)
        {
            Gerais.Codigo = ValidaLogin(txtEmail.Text, txtSenha.Text);
            Gerais.Logado = (Gerais.Codigo > 0);

            lblAlerta.Text = Gerais.Logado ? "Liberado" : "Email/Senha inválido.";

            if (Gerais.Logado)
            {
                lblAlerta.Text = "Liberado";
                Gerais.Email = txtEmail.Text;
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

        private int ValidaLogin(string email, string senha)
        {
            var login = new LoginService(baseRepository).Logar(email, senha);

            if(!string.IsNullOrEmpty(login.Email) && !string.IsNullOrEmpty(login.Senha))
            {
                Gerais.Codigo = login.Codigo;
                Gerais.Email = login.Email;
                Gerais.Senha = login.Senha;

                return login.Codigo;
            }

            return 0;
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                    break;
                case Keys.Escape:
                    Sair();
                    break;
                default:
                    break;
            }
        }
    }
}
