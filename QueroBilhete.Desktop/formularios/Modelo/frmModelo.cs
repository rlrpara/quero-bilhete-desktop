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


        #endregion

        public frmModelo()
        {
            InitializeComponent();
            lblLog.Text = "Cadastrado em:  por:  Atualizado em:  por: ";
        }
    }
}
