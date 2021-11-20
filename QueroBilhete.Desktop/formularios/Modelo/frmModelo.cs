using QueroBilhete.Desktop.Enumeradores;
using QueroBilhete.Desktop.Globais;
using System.Windows.Forms;

namespace QueroBilhete.Desktop.formularios.Modelo
{
    public partial class frmModelo : Form
    {
        #region [Metodos Privados]
        protected void Sair()
        {
            Close();
        }

        protected void AtivaBotoes(EBotoes acao)
        {
            Configuracao.AtivaBotoes(acao, btnNovo, btnEditar, btnExcluir, btnLocalizar, btnImprimir, btnSalvar, btnCancelar);
        }

        protected void AtivaConfiguracaoPadrao()
        {
            AtivaBotoes(EBotoes.Novo);
            Configuracao.LimparCampos(grpCadastro.Controls);
        }

        protected void BloquearCampos(bool ativar)
        {
            Configuracao.BloquearCampos(!ativar, grpCadastro.Controls);
        }
        protected void AlteraStatusCheckBox(ref CheckBox chkStatus)
        {
            chkStatus.Text = chkStatus.Checked ? "Ativo" : "Inativo";
        }
        #endregion

        #region [Construtor]
        public frmModelo()
        {
            InitializeComponent();
            lblLog.Text = "Cadastrado em:  por:  Atualizado em:  por: ";
        }
        #endregion

        private void frmModelo_KeyDown(object sender, KeyEventArgs e)
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
    }
}
