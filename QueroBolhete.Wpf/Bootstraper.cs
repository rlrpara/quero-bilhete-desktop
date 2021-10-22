using Caliburn.Micro;
using QueroBolhete.Wpf.ViewModels;
using System.Windows;

namespace QueroBolhete.Wpf
{
    public class Bootstraper : BootstrapperBase
    {
        public Bootstraper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<HomeViewModel>();
        }
    }
}
