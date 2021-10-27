using Caliburn.Micro;
using QueroBolhete.Wpf.ViewModels.Dashboard;
using QueroBolhete.Wpf.ViewModels.Usuario;

namespace QueroBolhete.Wpf.ViewModels
{
    public class HomeViewModel : Conductor<object>
    {
        public HomeViewModel()
        {
            ActivateItem(new DashboardViewModel());
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
