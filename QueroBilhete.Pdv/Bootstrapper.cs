using Caliburn.Micro;
using QueroBilhete.Pdv.ViewModels;
using System.Windows;

namespace QueroBilhete.Pdv
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<HomeViewModel>();
        }
    }
}
