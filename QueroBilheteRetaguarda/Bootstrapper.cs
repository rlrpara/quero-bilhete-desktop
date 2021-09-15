using Caliburn.Micro;
using QueroBilheteRetaguarda.ViewModels;
using System.Windows;

namespace QueroBilheteRetaguarda
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
