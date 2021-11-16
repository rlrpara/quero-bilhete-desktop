using System.Windows;
using System.Windows.Controls;

namespace QueroBolhete.Wpf.Views.Usuario
{
    /// <summary>
    /// Interaction logic for UsuarioView.xaml
    /// </summary>
    public partial class UsuarioView : Page
    {
        public UsuarioView()
        {
            InitializeComponent();
            ControleDadosLista.Visibility = Visibility.Collapsed;
            ControleDadosCadastro.Visibility = Visibility.Collapsed;
        }

        private void MudarAba(int value)
        {
            ControleDados.SelectedIndex = value;
        }

        private void Button_Novo(object sender, RoutedEventArgs e)
        {
            MudarAba(1);
        }

        private void Button_Salvar(object sender, RoutedEventArgs e)
        {
            MudarAba(0);
        }

        private void Button_Cancelar(object sender, RoutedEventArgs e)
        {
            MudarAba(0);
        }
    }
}
