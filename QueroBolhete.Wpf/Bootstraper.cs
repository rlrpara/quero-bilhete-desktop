using Caliburn.Micro;
using dotenv.net;
using QueroBolhete.Wpf.ViewModels;
using System.Windows;

namespace QueroBolhete.Wpf
{
    public class Bootstraper : BootstrapperBase
    {
        public Bootstraper()
        {
            Initialize();
            DotEnv.Fluent().WithEnvFiles(".env").WithTrimValues().Load();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<HomeViewModel>();
        }
    }
}
