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

namespace QueroBilhete.Desktop.formularios.Embarcacao
{
    public partial class frmEmbarcacao : frmModelo
    {
        #region [Propriedades Privadas]
        private readonly BaseRepository _baseRepository;
        private EmbarcacaoViewModel _embarcacaoViewModel;
        private EmbarcacaoService _embarcacaoService;
        private EmbarcacaoPoltronaService _embarcacaoPoltronaService;
        private GenericService _genericService;
        #endregion

        #region [Métodos Privados]
        private void Novo()
        {
            AtivaBotoes(EBotoes.Novo);
            BloquearCampos(false);
            Configuracao.LimparCampos(grpCadastro.Controls);

            _embarcacaoViewModel = new EmbarcacaoViewModel();
            txtCodigo.EnableAll = false;
            txtEmpresa.Focus();
            txtEmpresa.Select();
            chkStatus.Checked = true;
            pnlDados.Enabled = false;
        }

        private void Editar()
        {
            AtivaBotoes(EBotoes.Editar);
            BloquearCampos(false);
            txtCodigo.Enabled = false;
            txtEmpresa.Select();
            txtEmpresa.Focus();
            pnlDados.Enabled = true;
        }

        private void Excluir()
        {
            if (MessageBox.Show("Deseja remover este registro?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _embarcacaoService.RemoverEmbarcacao(Convert.ToInt32(txtCodigo.Texto));
                Configuracao.LimparCampos(grpCadastro.Controls);
                AtivaBotoes(EBotoes.Apagar);
                BloquearCampos(true);
            }
        }

        private void Localizar()
        {
            var janela = new frmPesquisaGenerica();
            janela.CarregaDados<Domain.Entities.Embarcacao>("AND ATIVO = 1");
            janela.ShowDialog();

            if(janela.CodigoSelecionado > 0)
            {
                PesquisarDados(janela.CodigoSelecionado);
                CarregarDadosGrid();
            }

            AtivaBotoes(EBotoes.Pesquisar);
            BloquearCampos(true);
        }

        private void PesquisarDados(int codigoSelecionado)
        {
            _embarcacaoViewModel = codigoSelecionado > 0 ? _embarcacaoService.CarregaEmbarcacao(codigoSelecionado) : new EmbarcacaoViewModel();
            if (_embarcacaoViewModel != null)
            {
                txtCodigo.Texto = _embarcacaoViewModel.Codigo.ToString();
                txtEmpresa.TextoCentro = _embarcacaoViewModel.CodigoEmpresa.ToString();
                txtEmpresa.TextoDireita = _genericService.ObterDescricao<Domain.Entities.Empresa>(_embarcacaoViewModel.CodigoEmpresa, "RAZAO_SOCIAL");
                txtNome.Texto = _embarcacaoViewModel.Nome;
                chkStatus.Checked = _embarcacaoViewModel.Ativo;
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
            _embarcacaoViewModel = ObterDadosEmpresa();

            _embarcacaoViewModel.Validate();

            if (_embarcacaoViewModel.Valido)
            {
                AtivaBotoes(EBotoes.Salvar);
                BloquearCampos(true);
                if (_embarcacaoViewModel.Codigo == 0)
                {
                    _embarcacaoService.AdicionarEmbarcacao(_embarcacaoViewModel);
                    txtCodigo.Texto = _embarcacaoService.ObterUltimoRegistro<Domain.Entities.Embarcacao>().ToString();
                }
                else
                    _embarcacaoService.AtualizarEmbarcacao(_embarcacaoViewModel);
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

        private EmbarcacaoViewModel ObterDadosEmpresa() => new EmbarcacaoViewModel()
        {
            Codigo = !txtCodigo.Texto.IsNumeric() ? 0 : Convert.ToInt32(txtCodigo.Texto),
            CodigoEmpresa = Convert.ToInt32(txtEmpresa.TextoCentro),
            Nome = txtNome.Texto,
            Ativo = chkStatus.Checked
        };

        private void AlertaInconsistencias()
        {
            var alerta = new StringBuilder();
            alerta.AppendLine("Foram encontrados os serguintes erros:");

            foreach (var item in _embarcacaoViewModel.Mensagens)
                alerta.AppendLine(item.ToString());

            MessageBox.Show(alerta.ToString());
        }

        private void Cancelar()
        {
            Configuracao.LimparCampos(grpCadastro.Controls);
            AtivaBotoes(EBotoes.Cancelar);
            BloquearCampos(true);
        }

        private void ConfiguraGrid()
        {
            Configuracao.ConfiguraGrid(dgvDados);
        }

        private void CarregarDadosGrid()
        {
            CarregaDados<Domain.Entities.EmbarcacaoPoltrona>(dgvDados, _baseRepository, $"AND ID_EMBARCACAO = {txtCodigo.Texto.ApenasNumeros()}");
        }

        #endregion

        #region [Construtor]
        public frmEmbarcacao()
        {
            InitializeComponent();
            _baseRepository = new BaseRepository();
            _embarcacaoViewModel = new EmbarcacaoViewModel();
            _embarcacaoService = new EmbarcacaoService(_baseRepository);
            _embarcacaoPoltronaService = new EmbarcacaoPoltronaService(_baseRepository);
            _genericService = new GenericService(_baseRepository);
            lblLog.Text = "Cadastrado em:  por:  Atualizado em:  por: ";
            Novo();
            ConfiguraGrid();
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

        private void chkStatus_Enter(object sender, EventArgs e)
        {
            AlteraStatusCheckBox(ref chkStatus);
        }

        private void txtEmpresa_ButtonClick(object sender, EventArgs e)
        {
            var janela = new frmPesquisaGenerica();
            janela.CarregaDados<Domain.Entities.Empresa>("AND ATIVO = 1");
            janela.ShowDialog();

            if(janela.CodigoSelecionado > 0)
            {
                txtEmpresa.TextoCentro = janela.CodigoSelecionado.ToString();
                txtEmpresa.TextoDireita = _genericService.ObterDescricao<Domain.Entities.Empresa>(janela.CodigoSelecionado, "RAZAO_SOCIAL");
            }

        }

        private void btnNovoGrid_Click(object sender, EventArgs e)
        {
            AddJanela(new frmRegistroPoltrona(), EJanela.Modal);
            CarregarDadosGrid();
        }

        #endregion

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Texto.IsNumeric())
                AddJanela(new frmPreviewLayoutEmbarcacao(Convert.ToInt32(txtCodigo.Texto)), EJanela.Modal);
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDados.Rows.Count > 0)
            {
                var codigoSelecionado = Convert.ToInt32(dgvDados.CurrentRow.Cells["Codigo"].Value);
                AddJanela(new frmRegistroPoltrona(codigoSelecionado), EJanela.Modal);
                CarregarDadosGrid();
            }
        }
    }
}
