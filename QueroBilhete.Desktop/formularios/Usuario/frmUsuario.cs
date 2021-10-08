using QueroBilhete.Desktop.Enumeradores;
using QueroBilhete.Desktop.Globais;
using System;
using System.Windows.Forms;

namespace QueroBilhete.Desktop.formularios.Usuario
{
    public partial class frmUsuario : Form
    {
        #region Propriedades Privadas

        #endregion

        #region Metodos Privadas
        private void Sair()
        {
            Close();
        }
        private void AtivaConfiguracaoPadrao()
        {
            Configuracao.LimparCampos(grpCadastro.Controls);
            AtivaBotoes(EBotoes.Novo);
        }
        private void AtivaBotoes(EBotoes eBotoes)
        {
            switch (eBotoes)
            {
                case EBotoes.Novo:
                    btnNovo.Enabled = false;
                    btnEditar.Enabled = false;
                    btnRemover.Enabled = false;
                    btnLocalizar.Enabled = true;
                    btnImprimir.Enabled = false;
                    btnSalvar.Enabled = true;
                    btnCancelar.Enabled = true;
                    break;
                case EBotoes.Editar:
                    btnNovo.Enabled = true;
                    btnEditar.Enabled = false;
                    btnRemover.Enabled = true;
                    btnLocalizar.Enabled = true;
                    btnImprimir.Enabled = true;
                    btnSalvar.Enabled = true;
                    btnCancelar.Enabled = true;
                    break;
                case EBotoes.Apagar:
                    break;
                case EBotoes.Pesquisar:
                    break;
                case EBotoes.Salvar:
                    btnNovo.Enabled = false;
                    btnEditar.Enabled = true;
                    btnRemover.Enabled = true;
                    btnLocalizar.Enabled = true;
                    btnImprimir.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnCancelar.Enabled = false;
                    break;
                case EBotoes.Cancelar:
                    btnNovo.Enabled = true;
                    btnEditar.Enabled = false;
                    btnRemover.Enabled = false;
                    btnLocalizar.Enabled = true;
                    btnImprimir.Enabled = false;
                    btnSalvar.Enabled = false;
                    btnCancelar.Enabled = false;
                    break;
                default:
                    break;
            }
        }
        private void Cancelar()
        {
            AtivaBotoes(EBotoes.Cancelar);
        }
        private void Novo()
        {
            AtivaBotoes(EBotoes.Novo);
        }
        private void Salvar()
        {
            AtivaBotoes(EBotoes.Salvar);
        }
        #endregion

        #region Construtor
        public frmUsuario()
        {
            InitializeComponent();
            AtivaConfiguracaoPadrao();
        }



        #endregion

        private void btnSair_Click(object sender, System.EventArgs e)
        {
            Sair();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
