using System.Windows.Forms;

namespace QueroBilhete.Desktop.Globais
{
    public static class Variaveis
    {
        public static string Email = "";
        public static string Senha = "";
        public static bool Logado = false;
    }

    public static class Configuracao
    {
        public static void LimparCampos(Control.ControlCollection controle)
        {
            foreach (Control item in controle)
            {
                if (item is Panel)
                    LimparCampos(((Panel)item).Controls);

                if (item is TextBox)
                    ((TextBox)item).Clear();

                if (item is Label && ((Label)item).Name.Substring(0, 3).Contains("lbl"))
                    ((Label)item).Text = "";
            }
        }
    }
}
