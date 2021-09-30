using QueroBilhete.Desktop.Enumeradores;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QueroBilhete.Desktop.formularios.PDV
{
    public partial class frmPDV : Form
    {
        private string _assentosSelecionados = string.Empty;
        private void AtivaTab(int numero)
        {
            tabPdv.SelectedTab = tabPdv.TabPages[numero];
            tabPdv.Appearance = TabAppearance.FlatButtons;
            tabPdv.ItemSize = new Size(0, 1);
            tabPdv.SizeMode = TabSizeMode.Fixed;
        }

        private void LimpaCampos()
        {
            txtCpf.Text = "";
            txtRg.Text = "";
            txtNascimento.Text = "";
            lblNomePassageiro.Text = "";
            lblTipoPassagem.Text = "";
            lblQuantidade.Text = "";
            lblCarteira.Text = "";
        }

        private void ValoresPadrao()
        {
            txtNacionalidade.Text = "BRASILEIRA";
            txtTipoPassagem.Text = "1";
            lblTipoPassagem.Text = "INTEIRA";
            txtQuantidade.Text = "1";
            txtCarteira.Text = "1";
            lblCarteira.Text = "DINHEIRO";
            txtValorPago.Text = "0.00";
            txtTroco.Text = "0.00";
            txtTotal.Text = "0.00";
            cmbTrecho.SelectedIndex = 1;
        }

        private void AbreCaixa()
        {
            panelSelecaoAcentos.Enabled = true;
        }

        private void FecharCaixa()
        {
            panelSelecaoAcentos.Enabled = false;
            LimpaCampos();
            ValoresPadrao();
            AtivaTab(0);
        }

        public frmPDV()
        {
            InitializeComponent();
            LimpaCampos();
            ValoresPadrao();
            AtivaTab(0);
            LayoutSalmista();
        }

        private void LayoutSalmista()
        {
            //posicao   letra|de|ate|topo|esquerda|colunas|orientacao
            GerarAssentos("C", 1, 5, 40, 20, 1);
            GerarAssentos("A", 1, 5, 40, 560, 1);

            GerarAssentos("C", 6, 13, 200, 65, 2, EDirecao.DireitaEsquerda);
            GerarAssentos("B", 1, 30, 150, 200, 5);
            GerarAssentos("A", 6, 13, 200, 515, 2);

            GerarAssentos("C", 14, 43, 340, 65, 2, EDirecao.DireitaEsquerda);
            GerarAssentos("B", 31, 105, 340, 200, 5);
            GerarAssentos("A", 14, 43, 340, 515, 2);

            GerarAssentos("D", 1, 2, 750, 20, 2);
            GerarAssentos("D", 3, 7, 750, 200, 5);
            GerarAssentos("D", 8, 9, 750, 515, 2);

            GerarAssentos("D", 10, 11, 777, 20, 2);
            GerarAssentos("D", 12, 16, 777, 200, 5);
            GerarAssentos("D", 17, 18, 777, 515, 2);

            GerarAssentos("D", 19, 30, 815, 47, 12);
        }

        private void frmPDV_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    break;
                case Keys.F2:
                    AbreCaixa();
                    break;
                case Keys.F3:
                    break;
                case Keys.F4:
                    break;
                case Keys.F5:
                    break;
                case Keys.F6:
                    FecharCaixa();
                    break;
                case Keys.F7:
                    break;
                case Keys.F8:
                    break;
                case Keys.F9:
                    break;
                case Keys.F10:
                    break;
                case Keys.F11:
                    break;
                case Keys.F12:
                    break;
                case Keys.Enter:
                    SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                    break;
                default:
                    break;
            }
        }
        private void DesenhaBotao(string letra, int numero, int eixoX, int eixoY)
        {
            var nomeBotao = $"{letra}{numero.ToString().PadLeft(3, '0')}";
            Button button = new Button();
            button.Left = eixoY;
            button.Top = eixoX;
            button.Click += botao_acento;
            button.Name = nomeBotao;
            button.Text = nomeBotao;
            button.Tag = nomeBotao;
            button.BackColor = Color.White;
            button.Width = 45;
            button.Height = 25;
            button.Font = new Font(button.Font.FontFamily, 9);
            panel1.Controls.Add(button); // here
            panelSelecaoAcentos.Controls.Add(button);
        }

        private void GerarAssentos(string letra, int inicaEm, int terminaEm, int eixoX, int eixoY, int totalColunas, EDirecao direcao = EDirecao.EsquerdaDireita)
        {
            var esquerda = eixoY;

            for (int i = inicaEm; i <= terminaEm; i++)
            {
                for (int c = 0; c < totalColunas; c++)
                {
                    if (i <= terminaEm)
                    {
                        DesenhaBotao(letra, i, eixoX, eixoY);
                        if(direcao == EDirecao.EsquerdaDireita) 
                            eixoY += 45;
                        else
                            eixoY += -45;
                        i++;
                    }
                }
                i--;
                eixoY = esquerda;
                eixoX += 25;
            }
        }

        private void btnNovaVenda_Click(object sender, System.EventArgs e)
        {
            AbreCaixa();
        }

        private void btnFecharCaixa_Click(object sender, System.EventArgs e)
        {
            FecharCaixa();
        }

        private void txtCpf_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var cpf = txtCpf.Text.Replace(".", "").Replace(",", "").Replace("-", "");

            if (!string.IsNullOrEmpty(cpf) && cpf.Contains("1234567890"))
            {
                lblNomePassageiro.Text = "MARCELO MALATO";
                txtRg.Text = "242424";
                txtNascimento.Text = "24/12/1990";
            }
        }

        private void txtTotal_Validated(object sender, System.EventArgs e)
        {
            MessageBox.Show("Encerrando a venda. Iniciando nova.");
            FecharCaixa();
            AbreCaixa();
        }


        private void botao_acento(object sender, System.EventArgs e)
        {
            var botaoClicado = ((Button)sender).Text.ToString();
            var listaAssentos = new StringBuilder();

            foreach (Control c in panelSelecaoAcentos.Controls)
            {
                if (c is Button button && button.Tag != null && button.Text == botaoClicado)
                {
                    ((Button)sender).BackColor = (((Button)sender).BackColor == Color.LimeGreen ? Color.White : Color.LimeGreen);
                    if(((Button)sender).BackColor == Color.LimeGreen){
                        //listaAssentos.AppendLine(((Button)sender).Tag.ToString());
                        txtAssentos.Text = string.Join(",", ((Button)sender).Tag.ToString());
                    }
                }
            }

            _assentosSelecionados = listaAssentos.ToString().Replace($"\r\n", ",");

        }

    }
}
