using Caliburn.Micro;
using QueroBolhete.Wpf.ViewModels.Cadastros;
using QueroBolhete.Wpf.ViewModels.Dashboard;
using QueroBolhete.Wpf.ViewModels.Usuario;

namespace QueroBolhete.Wpf.ViewModels
{
    public class HomeViewModel : Conductor<IScreen>.Collection.OneActive
    {
        public HomeViewModel()
        {
            ActiveItem = new DashboardViewModel();
        }


        public void pageDashboard()
        {
            ActiveItem = new DashboardViewModel();
        }

        public void pageUsuario()
        {
            ActiveItem = new UsuarioViewModel();
        }

        public void pageCadastros()
        {
            ActiveItem = new CadastrosViewModel();
        }
    }
}
