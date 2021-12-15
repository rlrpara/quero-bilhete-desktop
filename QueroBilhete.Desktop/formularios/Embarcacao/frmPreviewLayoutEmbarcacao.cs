using QueroBilhete.Data.Repositories;
using QueroBilhete.Desktop.Enumeradores;
using QueroBilhete.Domain.Interfaces;
using QueroBilhete.Service.Service;
using System.Drawing;
using System.Windows.Forms;

namespace QueroBilhete.Desktop.formularios.Embarcacao
{
    public partial class frmPreviewLayoutEmbarcacao : Form
    {
        #region [Propriedades Privadas]
        private readonly IBaseRepository _baseRepository;
        private readonly EmbarcacaoPoltronaService _embarcacaoPoltronaService;
        #endregion

        #region [Propriedades Públicas]
        public int eixoX;
        public int eixoY;
        #endregion

        #region [Métodos Privados]
        private void GerarAssentos(string letra, int inicaEm, int terminaEm, int eixoX, int eixoY, int totalColunas, EDirecao direcao = EDirecao.EsquerdaDireita)
        {
            var esquerda = eixoY;

            for (int i = inicaEm; i <= terminaEm; i++)
            {
                for (int c = 0; c < totalColunas; c++)
                {
                    if (i <= terminaEm)
                    {
                        DesenhaBotao(letra, i, eixoX, eixoY, panelSelecaoAcentos);
                        if (direcao == EDirecao.EsquerdaDireita)
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
        private void DesenhaBotao(string letra, int numero, int eixoX, int eixoY, Panel painelDesenho)
        {
            var nomeBotao = $"{letra}{numero.ToString().PadLeft(3, '0')}";
            Button button = new Button();
            button.Left = eixoY;
            button.Top = eixoX;
            //button.Click += botaoAcento;
            button.Name = nomeBotao;
            button.Text = nomeBotao;
            button.Tag = nomeBotao;
            button.BackColor = Color.White;
            button.Width = 45;
            button.Height = 25;
            button.Font = new Font(button.Font.FontFamily, 9);
            painelDesenho.Controls.Add(button); // here
            painelDesenho.Controls.Add(button);
        }
        private void CarregarLayout(int codigoEmbarcacao)
        {
            var poltronas = _embarcacaoPoltronaService.ObterTodos($"ID_EMBARCACAO = {codigoEmbarcacao} AND ATIVO = 1");

            foreach (var item in poltronas)
            {
                //posicao   letra|de|ate|topo|esquerda|colunas|orientacao
                GerarAssentos(item.Letra, item.Inicio, item.Fim, item.EixoX, item.EixoY, item.TotalColuna);
            }
        }
        private void Sair()
        {
            Close();
        }

        #endregion

        #region [Construtor]
        public frmPreviewLayoutEmbarcacao(int codigoEmbarcacao)
        {
            InitializeComponent();
            _baseRepository = new BaseRepository();
            _embarcacaoPoltronaService = new EmbarcacaoPoltronaService(_baseRepository);
            CarregarLayout(codigoEmbarcacao);
            eixoX = 0;
            eixoY = 0;
        }
        #endregion

        #region [Métodos Formulário]
        private void frmPreviewLayoutEmbarcacao_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
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

        private void panelSelecaoAcentos_Click(object sender, System.EventArgs e)
        {
            Point coordenadas = panelSelecaoAcentos.PointToClient(Cursor.Position);
            eixoX = coordenadas.X;
            eixoY = coordenadas.Y;
            Close();
        }

        #endregion
    }
}
