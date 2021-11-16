using QueroBolhete.Wpf.Views.Usuario;
using System.Windows.Controls;
using System.Windows;

namespace QueroBolhete.Wpf.Views.Cadastros
{
    /// <summary>
    /// Interaction logic for CadastrosView.xaml
    /// </summary>
    public partial class CadastrosView : UserControl
    {
        public CadastrosView()
        {
            InitializeComponent();
        }

        private void btnClickCadastroUsuario(object sender, RoutedEventArgs e)
        {
            stpBotoes.Visibility = Visibility.Collapsed;
            Main.Content = new UsuarioView();
        }
    }
}
