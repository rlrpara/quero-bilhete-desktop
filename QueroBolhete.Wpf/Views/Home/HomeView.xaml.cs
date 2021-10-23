using QueroBolhete.Wpf.Views.Dashboard;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace QueroBolhete.Wpf.Views
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : Window
    {
        DispatcherTimer timer;
        double panelWidth;
        bool hidden;


        public HomeView()
        {
            InitializeComponent();
            timer = new DispatcherTimer
            {
                Interval = new TimeSpan(0, 0, 0, 0, 10)
            };
            timer.Tick += Timer_Tick;
            panelWidth = 180;
            sidePanel.Width = 50;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                sidePanel.Width -= 10;
                if (sidePanel.Width <= 50)
                {
                    timer.Stop();
                    hidden = false;
                }
            }
            else
            {
                sidePanel.Width += 10;
                if (sidePanel.Width >= panelWidth)
                {
                    timer.Stop();
                    hidden = true;
                }
                
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void panelHeader_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Sair(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Click_Dashboard(object sender, RoutedEventArgs e)
        {
            Conteudo.Content = new DashboardView();
        }

        private void Click_Cadastro(object sender, RoutedEventArgs e)
        {

        }
    }
}
