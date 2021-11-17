using QueroBilhete.Data.Repositories;
using QueroBilhete.Desktop.Enumeradores;
using QueroBilhete.Desktop.formularios.Pesquisa;
using QueroBilhete.Desktop.Globais;
using QueroBilhete.Infra.Utilities.ExtensionMethods;
using QueroBilhete.Service.Service;
using QueroBilhete.Service.ViewModels;
using System;
using System.Text;
using System.Windows.Forms;

namespace QueroBilhete.Desktop.formularios.Usuario
{
    public partial class frmUsuario : Form
    {
        #region [Propriedades Privadas]
        private UsuarioViewModel _usuarioViewModel;
        private readonly BaseRepository _baseRepository;
        private UsuarioService usuarioService;
        #endregion

        #region [Metodos Privados]
        private void Sair()
        {
            Close();
        }

        private void BloquearCampos(bool ativar)
        {
            Configuracao.BloquearCampos(!ativar, grpCadastro.Controls);
            txtCodigo.EnableAll = !ativar;
            txtUid.EnableAll = !ativar;
            txtNome.EnableAll = !ativar;
            txtEmail.EnableAll = !ativar;
            txtSenha.EnableAll = !ativar;
            txtNivelAcesso.EnableAll = !ativar;
            txtCep.EnableAll = !ativar;
            txtEstado.EnableAll = !ativar;
            txtCidade.EnableAll = !ativar;
            txtBairro.EnableAll = !ativar;
            txtRua.EnableAll = !ativar;
            txtNumero.EnableAll = !ativar;
            panelStatus.Enabled = !ativar;

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
            txtNome.Focus();
            txtNome.Select();
        }

        private void Editar()
        {
            AtivaBotoes(EBotoes.Editar);
            BloquearCampos(false);
            txtCodigo.Enabled = false;
            txtUid.Select();
            txtUid.Focus();
        }

        private void Excluir()
        {
            if (MessageBox.Show("Deseja remover este registro?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                usuarioService.RemoverUsuario(Convert.ToInt32(txtCodigo.Texto));
                Configuracao.LimparCampos(grpCadastro.Controls);
                AtivaBotoes(EBotoes.Apagar);
                BloquearCampos(true);
            }
        }

        private void Localizar()
        {
            var janela = new frmPesquisaGenerica();
            janela.CarregaDados<Domain.Entities.Usuario>("AND ATIVO = 1");
            janela.ShowDialog();

            PesquisarDados(janela.CodigoSelecionado);

            AtivaBotoes(EBotoes.Pesquisar);
            BloquearCampos(true);
        }

        private void PesquisarDados(int codigoSelecionado)
        {
            _usuarioViewModel = codigoSelecionado > 0 ? usuarioService.CarregaUsuario(codigoSelecionado) : new UsuarioViewModel();
            if(_usuarioViewModel != null)
            {
                txtCodigo.Texto = _usuarioViewModel.Codigo.ToString();
                txtUid.Texto = _usuarioViewModel.Uid;
                txtNome.Texto = _usuarioViewModel.Nome;
                txtEmail.Texto = _usuarioViewModel.Email;
                txtSenha.Texto = _usuarioViewModel.Senha;
                txtNivelAcesso.TextoCentro = _usuarioViewModel.CodigoNivelAcesso > 0 ? _usuarioViewModel.CodigoNivelAcesso.ToString() : "";
                txtNivelAcesso.TextoDireita = "";
                txtCep.Texto = _usuarioViewModel.Cep;
                txtEstado.Texto = _usuarioViewModel.Estado;
                txtCidade.Texto = _usuarioViewModel.Cidade;
                txtBairro.Texto = _usuarioViewModel.Bairro;
                txtRua.Texto = _usuarioViewModel.Rua;
                txtNumero.Texto = _usuarioViewModel.Numero.ToString();
                chkStatus.Checked = _usuarioViewModel.Ativo;
            }
            else
            {
                Configuracao.LimparCampos(grpCadastro.Controls);
            }
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
                if(_usuarioViewModel.Codigo == 0)
                    usuarioService.AdicionarUsuario(_usuarioViewModel);
                else
                    usuarioService.AtualizarUsuario(_usuarioViewModel);
                PesquisarDados(Convert.ToInt32(!txtCodigo.Texto.IsNumeric() ? "0" : txtCodigo.Texto));
                AtivaBotoes(EBotoes.Pesquisar);
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
            Codigo = !txtCodigo.Texto.IsNumeric() ? 0 : Convert.ToInt32(txtCodigo.Texto),
            Uid = txtUid.Texto,
            Nome = txtNome.Texto,
            Email = txtEmail.Texto,
            Senha = txtSenha.Texto,
            CodigoNivelAcesso = txtNivelAcesso.TextoCentro.IsNumeric() ? int.Parse(txtNivelAcesso.TextoCentro) : 0,
            Cep = txtCep.Texto,
            Estado = txtEstado.Texto,
            Cidade = txtCidade.Texto,
            Bairro = txtBairro.Texto,
            Rua = txtRua.Texto,
            Numero = txtNumero.Texto.IsNumeric() ? int.Parse(txtNumero.Texto) : 0,
            Ativo = chkStatus.Checked,
            DataCadastro = DateTime.Now,
            DataAtualizacao = DateTime.Now
        };

        private void Cancelar()
        {
            Configuracao.LimparCampos(grpCadastro.Controls);
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
            _usuarioViewModel = new UsuarioViewModel();
            usuarioService = new UsuarioService(_baseRepository);
            lblLog.Text = "Cadastrado em:  por:  Atualizado em:  por: ";
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

        private void chkStatus_Enter(object sender, EventArgs e)
        {
            chkStatus.Text = chkStatus.Checked ? "Ativo" : "Inativo";
        }

        #endregion
    }
}
