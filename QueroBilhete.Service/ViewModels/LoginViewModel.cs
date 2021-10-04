namespace QueroBilhete.Service.ViewModels
{
    public class LoginViewModel
    {
        private string _email;
        private string _senha;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }
    }
}
