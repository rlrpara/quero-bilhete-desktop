using QueroBilhete.Data.Repositories;
using QueroBilhete.Desktop.Enumeradores;
using QueroBilhete.Desktop.formularios.Modelo;
using QueroBilhete.Desktop.formularios.Pesquisa;
using QueroBilhete.Desktop.Globais;
using QueroBilhete.Infra.Utilities.ExtensionMethods;
using QueroBilhete.Service.Service;
using QueroBilhete.Service.ViewModels;
using System;
using System.Text;
using System.Windows.Forms;

namespace QueroBilhete.Desktop.formularios.Tipo
{
    public partial class frmTipoPassagem : frmModelo
    {
        #region [Propriedades Privadas]
        private TipoPassagemViewModel _tipoPassagemViewModel;
        private readonly BaseRepository _baseRepository;
        private TipoPassagemService _tipoPassagemService;
        #endregion

        #region [Métodos Privados]
        private void Novo()
        {
            AtivaBotoes(EBotoes.Novo);
            BloquearCampos(true);
            Configuracao.LimparCampos(grpCadastro.Controls);

            _tipoPassagemViewModel = new TipoPassagemViewModel();
            txtDescricao.Focus();
            txtDescricao.Select();
        }

        private void Editar()
        {
            AtivaBotoes(EBotoes.Editar);
            BloquearCampos(false);
            txtCodigo.Enabled = false;
            txtDescricao.Select();
            txtDescricao.Focus();
        }

        private void Excluir()
        {
            if (MessageBox.Show("Deseja remover este registro?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _tipoPassagemService.RemoverTipoPassagem(Convert.ToInt32(txtCodigo.Texto));
                Configuracao.LimparCampos(grpCadastro.Controls);
                AtivaBotoes(EBotoes.Apagar);
                BloquearCampos(true);
            }
        }

        private void Localizar()
        {
            var janela = new frmPesquisaGenerica();
            janela.CarregaDados<Domain.Entities.TipoPassagem>("AND ATIVO = 1");
            janela.ShowDialog();

            PesquisarDados(janela.CodigoSelecionado);

            AtivaBotoes(EBotoes.Pesquisar);
            BloquearCampos(true);
        }

        private void PesquisarDados(int codigoSelecionado)
        {
            _tipoPassagemViewModel = codigoSelecionado > 0 ? _tipoPassagemService.CarregaTipoPassagem(codigoSelecionado) : new TipoPassagemViewModel();
            if (_tipoPassagemViewModel != null)
            {
                txtCodigo.Texto = _tipoPassagemViewModel.Codigo.ToString();
                txtDescricao.Texto = _tipoPassagemViewModel.Descricao;
                chkStatus.Checked = _tipoPassagemViewModel.Ativo;
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
            _tipoPassagemViewModel = ObterDadosTipoPassagem();

            _tipoPassagemViewModel.Validate();

            if (_tipoPassagemViewModel.Valido)
            {
                AtivaBotoes(EBotoes.Salvar);
                BloquearCampos(true);
                if (_tipoPassagemViewModel.Codigo == 0)
                    _tipoPassagemService.AdicionarTipoPassagem(_tipoPassagemViewModel);
                else
                    _tipoPassagemService.AtualizarTipoPassagem(_tipoPassagemViewModel);
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

        private TipoPassagemViewModel ObterDadosTipoPassagem() => new TipoPassagemViewModel()
        {
            Codigo = !txtCodigo.Texto.IsNumeric() ? 0 : Convert.ToInt32(txtCodigo.Texto),
            Descricao = txtDescricao.Texto,
            Ativo = chkStatus.Checked
        };

        private void AlertaInconsistencias()
        {
            var alerta = new StringBuilder();
            alerta.AppendLine("Foram encontrados os serguintes erros:");

            foreach (var item in _tipoPassagemViewModel.Mensagens)
                alerta.AppendLine(item.ToString());

            MessageBox.Show(alerta.ToString());
        }

        private void Cancelar()
        {
            Configuracao.LimparCampos(grpCadastro.Controls);
            AtivaBotoes(EBotoes.Cancelar);
            BloquearCampos(true);
        }
        #endregion

        #region [Construtor]
        public frmTipoPassagem()
        {
            InitializeComponent();
            _baseRepository = new BaseRepository();
            _tipoPassagemViewModel = new TipoPassagemViewModel();
            _tipoPassagemService = new TipoPassagemService(_baseRepository);
            lblLog.Text = "Cadastrado em:  por:  Atualizado em:  por: ";
            Novo();
        }

        #endregion

        #region [Métodos Formulário]
        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Sair();
        }
        #endregion
    }
}
