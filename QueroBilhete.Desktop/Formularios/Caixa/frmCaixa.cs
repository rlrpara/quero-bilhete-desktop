using QueroBilhete.Desktop.Globais;
using System;
using System.Windows.Forms;

namespace QueroBilhete.Desktop.Formularios.Caixa
{
    public partial class frmCaixa : Form
    {
        #region [Metodos Privados]
        protected void Sair()
        {
            Close();
        }
        protected void AtivaBotoes()
        {
            
        }
        protected void AtivaConfiguracaoPadrao()
        {
            Configuracao.LimparCampos(grpDados.Controls);
        }
        protected void BloquearCampos(bool ativar)
        {
            Configuracao.BloquearCampos(!ativar, grpDados.Controls);
        }

        private void IniciaMovimentacao(DateTime dataMovimento)
        {
            
        }

        #endregion

        #region [Construtor]
        public frmCaixa(DateTime dataMovimento)
        {
            InitializeComponent();
            IniciaMovimentacao(dataMovimento);
        }

        #endregion

        #region [Métodos de Formulário]
        private void frmCaixa_KeyDown(object sender, KeyEventArgs e)
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

        #endregion
    }
}
