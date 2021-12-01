using QueroBilhete.Data.Repositories;
using QueroBilhete.Desktop.Enumeradores;
using QueroBilhete.Service.Service;
using QueroBilhete.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QueroBilhete.Desktop.formularios.PDV
{
    public partial class frmPDV : Form
    {
        #region Propriedades Privadas
        private readonly BaseRepository _baseRepository;
        private readonly EmpresaService _empresaService;
        private readonly EmbarcacaoService _embarcacaoService;
        private readonly EmbarcacaoPoltronaService _embarcacaoPoltronaService;
        private readonly TrajetoService _trajetoService;
        private readonly PassagemService _passagemService;
        private readonly PassageiroService _passageiroService;
        private string _assentosSelecionados;
        #endregion

        #region Métodos Privados
        private void AtivaTab(int numero)
        {
            tabPdv.SelectedTab = tabPdv.TabPages[numero];
            tabPdv.Appearance = TabAppearance.FlatButtons;
            tabPdv.ItemSize = new Size(0, 1);
            tabPdv.SizeMode = TabSizeMode.Fixed;
        }
        private void LimpaCampos()
        {
            foreach (Control c in grpFormaPagto.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Text = "";

                if (c is Label)
                    ((Label)c).Text = "";
            }
        }
        private void ValoresPadrao()
        {
            txtNacionalidade.Text = "BRASILEIRA";
            txtTipoPassagem.Text = "1";
            lblTipoPassagem.Text = "INTEIRA";
            txtCarteira.Text = "1";
            lblCarteira.Text = "DINHEIRO";
            txtValorPago.Text = "0.00";
            txtTroco.Text = "0.00";
            txtTotal.Text = "0.00";
            cmbTrajeto.SelectedIndex = 1;
        }
        private void AbreCaixa()
        {
            MessageBox.Show("Abre o caixa quando estiver fechado para o dia");
        }
        private void FecharCaixa()
        {
            panelSelecaoAcentos.Enabled = false;
            LimpaCampos();
            ValoresPadrao();
            AtivaTab(0);
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
                        DesenhaBotao(letra, i, eixoX, eixoY, ref panelSelecaoAcentos);
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
        private void DesenhaBotao(string letra, int numero, int eixoX, int eixoY, ref Panel painelDesenho)
        {
            var nomeBotao = $"{letra}{numero.ToString().PadLeft(3, '0')}";
            Button button = new Button();
            button.Left = eixoY;
            button.Top = eixoX;
            button.Click += botaoAcento;
            button.Name = nomeBotao;
            button.Text = nomeBotao;
            button.Tag = nomeBotao;
            button.BackColor = Color.White;
            button.Width = 45;
            button.Height = 25;
            button.Font = new Font(button.Font.FontFamily, (float)(8.26));
            painelDesenho.Controls.Add(button);
        }
        private void botaoAcento(object sender, System.EventArgs e)
        {
            var botaoClicado = ((Button)sender).Text.ToString();
            var listaAssentos = new StringBuilder();

            foreach (Control c in panelSelecaoAcentos.Controls)
            {
                if (c is Button button && button.Tag != null && button.Text == botaoClicado)
                {
                    ((Button)sender).BackColor = (((Button)sender).BackColor == Color.LimeGreen ? Color.White : Color.LimeGreen);

                    if (((Button)sender).BackColor == Color.LimeGreen)
                        txtAssento.Text = ((Button)sender).Tag.ToString();

                    InformaPassageiroAssento(((Button)sender).Tag.ToString());
                }
            }
            _assentosSelecionados = listaAssentos.ToString().Replace($"\r\n", ",");
        }
        private void btnNovaVenda_Click(object sender, System.EventArgs e)
        {
            NovaVenda();
        }
        private void NovaVenda()
        {
            if (layoutSelecionado())
            {
                AbreCaixa();
                MessageBox.Show ($"Inicia nova venda com a data({DateTime.Now:dd/MM/yyyy}) e hora ({DateTime.Now:HH:mm:ss}).");
                panelSelecaoAcentos.Enabled = true;
            }
            else
            {
                MessageBox.Show($"Selecione o layout");
                cmbEmbarcacao.Focus();
                cmbEmbarcacao.DroppedDown = true;
            }
        }
        private bool layoutSelecionado()
        {
            return !string.IsNullOrEmpty(cmbEmbarcacao.Text);
        }
        private void FechaVenda()
        {
            MessageBox.Show($"Fecha venda, imprime cupons, salva no banco.");
            panelSelecaoAcentos.Enabled = false;
            panelInformaPessoa.Enabled = false;
            panelInformaPessoa.Visible = false;
            LimpaCampos();
        }

        private void InformaPassageiroAssento(string tag)
        {
            panelInformaPessoa.Visible = true;
            panelInformaPessoa.Enabled = true;
            txtTipoPassagem.Focus();
        }
        private void txtEmbarcacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveControles(panelSelecaoAcentos);

            CarregarLayout(Convert.ToInt32(cmbEmbarcacao.Text.Split('-')[0]));
        }

        private void CarregarLayout(int codigoEmbarcacao)
        {
            var poltronas = _embarcacaoPoltronaService.ObterTodos($"ID_EMBARCACAO = {codigoEmbarcacao}");

            foreach (var item in poltronas)
            {
                //posicao          letra|          de|      ate|       topo|   esquerda|          colunas|                 orientacao
                GerarAssentos(item.Letra, item.Inicio, item.Fim, item.EixoX, item.EixoY, item.TotalColuna, (EDirecao)item.Alinhamento);
            }
        }

        private void RemoveControles(Panel controles)
        {
            controles.Controls.Clear();
        }

        private void CarregarDadosPadroes()
        {
            var empresa = _empresaService.CarregaEmpresa(1);
            var embarcacoes = _embarcacaoService.ObterTodos($"ID_EMPRESA = {empresa.Codigo}");
            ObterDadosComboEmbarcacao(embarcacoes);
            ObterDadosComboTrajeto(cmbEmbarcacao.Text.Split('-')[0]);
        }

        private void ObterDadosComboTrajeto(string codigoEmbarcacao)
        {
            var trajeto = _trajetoService.ObterTodos($"ID_EMBARCACAO = {codigoEmbarcacao}");
            cmbTrajeto.Items.Clear();
            foreach (var item in trajeto)
            {
                cmbTrajeto.Items.Add($"{item.Codigo} - {item.Origem}/{item.Destino}");
            }
            if(cmbTrajeto.Items.Count > 0)
                cmbTrajeto.SelectedIndex = 0;
        }

        private void ObterDadosComboEmbarcacao(List<EmbarcacaoViewModel> embarcacaoViewModel)
        {
            cmbEmbarcacao.Items.Clear();
            foreach (var item in embarcacaoViewModel)
                cmbEmbarcacao.Items.Add($"{item.Codigo} - {item.Nome}");
            cmbEmbarcacao.SelectedIndex = 0;
        }

        private void Sair()
        {
            Close();
        }
        #endregion

        #region Construtor
        public frmPDV()
        {
            InitializeComponent();
            _baseRepository = new BaseRepository();
            _empresaService = new EmpresaService(_baseRepository);
            _embarcacaoService = new EmbarcacaoService(_baseRepository);
            _trajetoService = new TrajetoService(_baseRepository);
            _passagemService = new PassagemService(_baseRepository);
            _passageiroService = new PassageiroService(_baseRepository);
            _embarcacaoPoltronaService = new EmbarcacaoPoltronaService(_baseRepository);
            _assentosSelecionados = string.Empty;
            LimpaCampos();
            ValoresPadrao();
            AtivaTab(0);
            CarregarDadosPadroes();
        }

        #endregion

        #region [Métodos Formulário]
        private void frmPDV_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    break;
                case Keys.F2:
                    NovaVenda();
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
                case Keys.Escape:
                    Sair();
                    break;
                default:
                    break;
            }
        }

        private void btnFecharCaixa_Click(object sender, System.EventArgs e)
        {
            FecharCaixa();
        }
        private void txtTotal_Validated(object sender, System.EventArgs e)
        {
            MessageBox.Show("Encerrando a venda. Iniciando nova.");
            FecharCaixa();
            AbreCaixa();
        }
        private void btnF4_Click(object sender, EventArgs e)
        {
            FechaVenda();
        }
        private void txtTroco_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show("Valida todos os campos. Exibe tela informando a impressão de todas as passagens.");
            FechaVenda();
        }

        #endregion
    }
}
