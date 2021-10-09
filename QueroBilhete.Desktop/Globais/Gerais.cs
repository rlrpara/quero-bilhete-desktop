using QueroBilhete.Desktop.Enumeradores;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QueroBilhete.Desktop.Globais
{
    public static class Gerais
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

        public static void AtivaBotoes(EBotoes eBotoes, Button novo, Button editar, Button excluir, Button pesquisar, Button imprimir, Button salvar, Button cancelar)
        {
            switch (eBotoes)
            {
                case EBotoes.Novo:
                    novo.Enabled = false;
                    editar.Enabled = false;
                    excluir.Enabled = false;
                    pesquisar.Enabled = true;
                    imprimir.Enabled = false;
                    salvar.Enabled = true;
                    cancelar.Enabled = true;
                    break;
                case EBotoes.Editar:
                    novo.Enabled = true;
                    editar.Enabled = false;
                    excluir.Enabled = true;
                    pesquisar.Enabled = true;
                    imprimir.Enabled = true;
                    salvar.Enabled = true;
                    cancelar.Enabled = true;
                    break;
                case EBotoes.Apagar:
                    novo.Enabled = true;
                    editar.Enabled = false;
                    excluir.Enabled = false;
                    pesquisar.Enabled = true;
                    imprimir.Enabled = false;
                    salvar.Enabled = false;
                    cancelar.Enabled = false;
                    break;
                case EBotoes.Pesquisar:
                    novo.Enabled = true;
                    editar.Enabled = true;
                    excluir.Enabled = true;
                    pesquisar.Enabled = true;
                    imprimir.Enabled = true;
                    salvar.Enabled = false;
                    cancelar.Enabled = false;
                    break;
                case EBotoes.Salvar:
                    novo.Enabled = false;
                    editar.Enabled = true;
                    excluir.Enabled = true;
                    pesquisar.Enabled = true;
                    imprimir.Enabled = true;
                    salvar.Enabled = false;
                    cancelar.Enabled = false;
                    break;
                case EBotoes.Cancelar:
                    novo.Enabled = true;
                    editar.Enabled = false;
                    excluir.Enabled = false;
                    pesquisar.Enabled = true;
                    imprimir.Enabled = false;
                    salvar.Enabled = false;
                    cancelar.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        public static void BloquearCampos(bool ativar, Control.ControlCollection controle)
        {
            foreach (Control item in controle)
            {
                if (item is Panel)
                    BloquearCampos(ativar, ((Panel)item).Controls);

                if (item is TextBox && ((TextBox)item).Name.Contains("txt"))
                    ((TextBox)item).Enabled = ativar;

                if (item is Label && ((Label)item).Name.Contains("txt"))
                    ((Label)item).Enabled = ativar;
            }
        }
    }
}
