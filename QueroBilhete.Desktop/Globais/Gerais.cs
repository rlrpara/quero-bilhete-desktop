using QueroBilhete.Componentes.TextBox;
using QueroBilhete.Desktop.Enumeradores;
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

                if (item is CheckBox)
                    ((CheckBox)item).Checked = false;

                if (item is Label && ((Label)item).Name.Substring(0, 3).Contains("lbl"))
                    ((Label)item).Text = "";

                if (item is txtBoxLabel && ((txtBoxLabel)item).Name.Substring(0, 3).Contains("txt"))
                    ((txtBoxLabel)item).Texto = "";

                if (item is txtBoxBtnLabel && !string.IsNullOrEmpty(((txtBoxBtnLabel)item).TextoDireita) && ((txtBoxLabel)item).Name.Substring(0, 3).Contains("txt"))
                    ((txtBoxBtnLabel)item).TextoDireita = "";

                if (item is txtBoxBtnLabel && !string.IsNullOrEmpty(((txtBoxBtnLabel)item).TextoCentro) && ((txtBoxBtnLabel)item).Name.Substring(0, 3).Contains("txt"))
                    ((txtBoxBtnLabel)item).TextoCentro = "";
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
                    novo.Enabled = true;
                    editar.Enabled = false;
                    excluir.Enabled = false;
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

                if (item is txtBoxBtnLabel && ((txtBoxBtnLabel)item).Name.Substring(0, 3).Contains("txt"))
                    ((txtBoxBtnLabel)item).EnableAll = ativar;

                if (item is txtBoxLabel && ((txtBoxLabel)item).Name.Substring(0, 3).Contains("txt"))
                    ((txtBoxLabel)item).EnableAll = ativar;

                if (item is CheckBox)
                    ((CheckBox)item).Enabled = ativar;
            }
        }

        public static void ConfiguraGrid(DataGridView grid)
        {
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToOrderColumns = true;
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            grid.AllowUserToResizeColumns = false;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grid.AllowUserToResizeRows = false;
            grid.RowHeadersVisible = false;
            grid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            //grid.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12);
        }

        public static void GridDados(DataGridView grid, string coluna, string titulo_coluna, int alinhamento, int tamanho, bool visivel, bool moeda = false, int ordem = 0)
        {
            grid.Columns[coluna].HeaderText = titulo_coluna;
            grid.Columns[coluna].Width = tamanho;
            grid.Columns[coluna].Visible = visivel;
            grid.Columns[coluna].DisplayIndex = ordem;

            switch (alinhamento)
            {
                case 1:
                    grid.Columns[coluna].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    grid.Columns[coluna].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    break;
                case 2:
                    grid.Columns[coluna].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    grid.Columns[coluna].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    break;
                case 3:
                    grid.Columns[coluna].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    grid.Columns[coluna].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    break;
            }
            if (moeda)
                grid.Columns[coluna].DefaultCellStyle.Format = "N2";
        }
    }
}
