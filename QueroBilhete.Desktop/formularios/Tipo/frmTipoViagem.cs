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
    public partial class frmTipoViagem : frmModelo
    {
        #region [Propriedades Privadas]
        private TipoViagemViewModel _tipoViagemViewModel;
        private readonly BaseRepository _baseRepository;
        private TipoViagemService _tipoViagemService;
        #endregion

        #region [Métodos Privados]
        private void Novo()
        {
            AtivaBotoes(EBotoes.Novo);
            BloquearCampos(true);
            Configuracao.LimparCampos(panelDados.Controls);

            _tipoViagemViewModel = new TipoViagemViewModel();
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
                _tipoViagemService.RemoverTipoViagem(Convert.ToInt32(txtCodigo.Texto));
                Configuracao.LimparCampos(panelDados.Controls);
                AtivaBotoes(EBotoes.Apagar);
                BloquearCampos(true);
            }
        }

        private void Localizar()
        {
            var janela = new frmPesquisaGenerica();
            janela.CarregaDados<Domain.Entities.TipoViagem>("AND ATIVO = 1");
            janela.ShowDialog();

            PesquisarDados(janela.CodigoSelecionado);

            AtivaBotoes(EBotoes.Pesquisar);
            BloquearCampos(true);
        }

        private void PesquisarDados(int codigoSelecionado)
        {
            _tipoViagemViewModel = codigoSelecionado > 0 ? _tipoViagemService.CarregaTipoViagem(codigoSelecionado) : new TipoViagemViewModel();
            if (_tipoViagemViewModel != null)
            {
                txtCodigo.Texto = _tipoViagemViewModel.Codigo.ToString();
                txtDescricao.Texto = _tipoViagemViewModel.Descricao;
                chkStatus.Checked = _tipoViagemViewModel.Ativo;
            }
            else
            {
                Configuracao.LimparCampos(panelDados.Controls);
            }
        }

        private void Imprimir()
        {
            AtivaBotoes(EBotoes.Apagar);
            BloquearCampos(false);
        }

        private void Salvar()
        {
            _tipoViagemViewModel = ObterDadosTipoViagem();

            _tipoViagemViewModel.Validate();

            if (_tipoViagemViewModel.Valido)
            {
                AtivaBotoes(EBotoes.Salvar);
                BloquearCampos(true);
                if (_tipoViagemViewModel.Codigo == 0)
                    _tipoViagemService.AdicionarTipoViagem(_tipoViagemViewModel);
                else
                    _tipoViagemService.AtualizarTipoViagem(_tipoViagemViewModel);
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

        private TipoViagemViewModel ObterDadosTipoViagem() => new TipoViagemViewModel()
        {
            Codigo = !txtCodigo.Texto.IsNumeric() ? 0 : Convert.ToInt32(txtCodigo.Texto),
            Descricao = txtDescricao.Texto,
            Ativo = chkStatus.Checked
        };

        private void AlertaInconsistencias()
        {
            var alerta = new StringBuilder();
            alerta.AppendLine("Foram encontrados os serguintes erros:");

            foreach (var item in _tipoViagemViewModel.Mensagens)
                alerta.AppendLine(item.ToString());

            MessageBox.Show(alerta.ToString());
        }

        private void Cancelar()
        {
            Configuracao.LimparCampos(panelDados.Controls);
            AtivaBotoes(EBotoes.Cancelar);
            BloquearCampos(true);
        }
        #endregion

        #region [Construtor]
        public frmTipoViagem()
        {
            InitializeComponent();
            _baseRepository = new BaseRepository();
            _tipoViagemViewModel = new TipoViagemViewModel();
            _tipoViagemService = new TipoViagemService(_baseRepository);
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
