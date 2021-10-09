using QueroBilhete.Desktop.Enumeradores;
using QueroBilhete.Desktop.Globais;
using QueroBilhete.Infra.Utilities.ExtensionMethods;
using QueroBilhete.Service.ViewModels;
using System;
using System.Windows.Forms;

namespace QueroBilhete.Desktop.formularios.Usuario
{
    public partial class frmUsuario : Form
    {
        #region Propriedades Privadas
        private UsuarioViewModel _usuarioViewModel = new UsuarioViewModel();
        #endregion

        #region Metodos Privadas
        private void Sair()
        {
            Close();
        }

        private void BloquearCampos(bool ativar)
        {
            Configuracao.BloquearCampos(!ativar, grpCadastro.Controls);
        }

        private void AtivaBotoes(EBotoes acao)
        {
            Configuracao.AtivaBotoes(acao, btnNovo, btnEditar, btnExcluir, btnLocalizar, btnImprimir, btnSalvar, btnCancelar);
        }

        private void AtivaConfiguracaoPadrao()
        {
            AtivaBotoes(EBotoes.Novo);
            Configuracao.LimparCampos(grpCadastro.Controls);
        }

        private void Novo()
        {
            AtivaBotoes(EBotoes.Novo);
            BloquearCampos(false);
            _usuarioViewModel = new UsuarioViewModel();
        }

        private void Editar()
        {
            AtivaBotoes(EBotoes.Editar);
            BloquearCampos(false);
        }

        private void Excluir()
        {
            AtivaBotoes(EBotoes.Apagar);
            BloquearCampos(true);
        }

        private void Localizar()
        {
            AtivaBotoes(EBotoes.Pesquisar);
            BloquearCampos(true);
        }

        private void Imprimir()
        {
            AtivaBotoes(EBotoes.Apagar);
            BloquearCampos(false);
        }

        private void Salvar()
        {
            AtivaBotoes(EBotoes.Salvar);
            BloquearCampos(true);

            _usuarioViewModel = ObterDadosUsuario();

            if (_usuarioViewModel.Valido())
            {
                //Salvar os dados
            }
            else
            {
                //emite alerta de dados inválidos
            }
        }

        private UsuarioViewModel ObterDadosUsuario() => new UsuarioViewModel()
        {
            Uid = txtUid.Text,
            Nome = txtNome.Text,
            Senha = txtSenha.Text,
            CodigoNivelAcesso = txtNivelAcesso.Text.IsNumeric() ? int.Parse(txtNivelAcesso.Text) : 0,
            Cep = txtCep.Text,
            Estado = txtEstado.Text,
            Cidade = txtCidade.Text,
            Bairro = txtBairro.Text,
            Rua = txtRua.Text,
            Numero = txtNumero.Text.IsNumeric() ? int.Parse(txtNumero.Text) : 0,
            Ativo = chkStatus.Checked,
            DataAtualizacao = DateTime.Now
        };

        private void Cancelar()
        {
            AtivaBotoes(EBotoes.Cancelar);
            BloquearCampos(true);
        }


        
        #endregion

        #region Construtor
        public frmUsuario()
        {
            InitializeComponent();
            AtivaConfiguracaoPadrao();
        }



        #endregion

        #region Métodos Formulario
        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            Localizar();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void btnSair_Click(object sender, System.EventArgs e)
        {
            Sair();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        #endregion
    }
}
