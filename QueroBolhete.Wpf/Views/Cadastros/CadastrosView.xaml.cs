using QueroBolhete.Wpf.Views.Usuario;
using System.Windows.Controls;

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

        private void Button_Usuarios(object sender, System.Windows.RoutedEventArgs e)
        {
            UsuarioView janela = new UsuarioView();
            janela.Show();
        }
    }
}
