using QueroBilhete.Data.Repositories;
using QueroBilhete.Desktop.Enumeradores;
using QueroBilhete.Desktop.formularios.Pesquisa;
using QueroBilhete.Desktop.Globais;
using QueroBilhete.Infra.Utilities.ExtensionMethods;
using QueroBilhete.Service.Service;
using QueroBilhete.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QueroBilhete.Desktop.formularios.Usuario
{
    public partial class frmUsuario : Form
    {
        #region Propriedades Privadas
        private UsuarioViewModel _usuarioViewModel = new UsuarioViewModel();
        private readonly BaseRepository _baseRepository;
        private UsuarioService usuarioService;
        #endregion

        #region Metodos Privadas
        private void Sair()
        {
            Close();
        }

        private void BloquearCampos(bool ativar)
        {
            Configuracao.BloquearCampos(!ativar, grpCadastro.Controls);
            txtCodigo.Enabled = false;
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
            PesquisarDados(0);
        }

        private void Editar()
        {
            AtivaBotoes(EBotoes.Editar);
            BloquearCampos(false);
            txtUid.Select();
            txtUid.Focus();
        }

        private void Excluir()
        {
            AtivaBotoes(EBotoes.Apagar);
            BloquearCampos(true);
        }

        private void Localizar()
        {
            var janela = new frmPesquisaGenerica();
            janela.CarregaDados(ObterConsultaUsuario());
            janela.ShowDialog();

            PesquisarDados(janela.CodigoSelecionado);

            AtivaBotoes(EBotoes.Pesquisar);
            BloquearCampos(true);
        }

        private void PesquisarDados(int codigoSelecionado)
        {
            _usuarioViewModel = usuarioService.ObterUsuario(codigoSelecionado);
            if(_usuarioViewModel != null)
            {
                txtCodigo.Text = _usuarioViewModel.Codigo.ToString();
                txtUid.Text = _usuarioViewModel.Uid;
                txtNome.Text = _usuarioViewModel.Nome;
                txtEmail.Text = _usuarioViewModel.Email;
                txtSenha.Text = _usuarioViewModel.Senha;
                txtNivelAcesso.TextoCentro = _usuarioViewModel.CodigoNivelAcesso.ToString();
                txtNivelAcesso.TextoDireita = "";
                txtCep.TextoCentro = _usuarioViewModel.Cep;
                txtCep.TextoDireita = "";
                txtEstado.Text = _usuarioViewModel.Estado;
                txtCidade.Text = _usuarioViewModel.Cidade;
                txtBairro.Text = _usuarioViewModel.Bairro;
                txtRua.Text = _usuarioViewModel.Rua;
                txtNumero.Text = _usuarioViewModel.Numero.ToString();
                chkStatus.Checked = _usuarioViewModel.Ativo;
            }
            else
            {
                Configuracao.LimparCampos(grpCadastro.Controls);
            }
        }

        private List<Domain.Entities.Usuario> ObterConsultaUsuario(string nome = "")
        {
            return usuarioService.BuscarTodosPorQueryGerador<Domain.Entities.Usuario>($"NOME LIKE '%{nome}%'").ToList();
        }

        private void Imprimir()
        {
            AtivaBotoes(EBotoes.Apagar);
            BloquearCampos(false);
        }

        private void Salvar()
        {

            _usuarioViewModel = ObterDadosUsuario();

            _usuarioViewModel.Validate();

            if (_usuarioViewModel.Valido)
            {
                AtivaBotoes(EBotoes.Salvar);
                BloquearCampos(true);
            }
            else
            {
                txtCodigo.Focus();
                AlertaInconsistencias();
            }
        }

        private void AlertaInconsistencias()
        {
            var alerta = new StringBuilder();
            alerta.AppendLine("Foram encontrados os serguintes erros:");

            foreach (var item in _usuarioViewModel.Mensagens)
                alerta.AppendLine(item.ToString());

            MessageBox.Show(alerta.ToString());
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
            _baseRepository = new BaseRepository();
            usuarioService = new UsuarioService(_baseRepository);
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
