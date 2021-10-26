using Caliburn.Micro;
using QueroBolhete.Wpf.ViewModels.Dashboard;
using QueroBolhete.Wpf.ViewModels.Usuario;

namespace QueroBolhete.Wpf.ViewModels
{
    public class HomeViewModel : Conductor<object>
    {
        private string _teste;

        public string Teste
        {
            get { return _teste; }
            set { _teste = value; }
        }

        public HomeViewModel()
        {
            Teste = "Rodrigo";
        }


        public void LoadPageOne()
        {
            ActivateItem(new DashboardViewModel());
        }

        public void LoadPageTwo()
        {
            ActivateItem(new UsuarioViewModel());
        }
    }
}
