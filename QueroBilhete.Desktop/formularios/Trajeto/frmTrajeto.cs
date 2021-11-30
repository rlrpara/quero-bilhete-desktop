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

namespace QueroBilhete.Desktop.formularios.Trajeto
{
    public partial class frmTrajeto : frmModelo
    {
        #region [Propriedades Privadas]
        private TrajetoViewModel _trajetoViewModel;
        private readonly BaseRepository _baseRepository;
        private TrajetoService _trajetoService;
        private GenericService _genericService;
        #endregion

        #region [Métodos Privados]
        private void Novo()
        {
            AtivaBotoes(EBotoes.Novo);
            BloquearCampos(true);
            Configuracao.LimparCampos(grpCadastro.Controls);

            _trajetoViewModel = new TrajetoViewModel();
            txtEmbarcacao.Focus();
            txtEmbarcacao.Select();
        }

        private void Editar()
        {
            AtivaBotoes(EBotoes.Editar);
            BloquearCampos(false);
            txtCodigo.Enabled = false;
            txtEmbarcacao.Select();
            txtEmbarcacao.Focus();
        }

        private void Excluir()
        {
            if (MessageBox.Show("Deseja remover este registro?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _trajetoService.RemoverTrajeto(Convert.ToInt32(txtCodigo.Texto));
                Configuracao.LimparCampos(grpCadastro.Controls);
                AtivaBotoes(EBotoes.Apagar);
                BloquearCampos(true);
            }
        }

        private void Localizar()
        {
            var janela = new frmPesquisaGenerica();
            janela.CarregaDados<Domain.Entities.Trajeto>("AND ATIVO = 1");
            janela.ShowDialog();

            PesquisarDados(janela.CodigoSelecionado);

            AtivaBotoes(EBotoes.Pesquisar);
            BloquearCampos(true);
        }

        private void PesquisarDados(int codigoSelecionado)
        {
            _trajetoViewModel = codigoSelecionado > 0 ? _trajetoService.CarregaTrajeto(codigoSelecionado) : new TrajetoViewModel();
            if (_trajetoViewModel != null)
            {
                txtCodigo.Texto = _trajetoViewModel.Codigo.ToString();
                txtEmbarcacao.TextoCentro = _trajetoViewModel.CodigoEmbarcacao.ToString();
                txtEmbarcacao.TextoDireita = _trajetoViewModel.CodigoEmbarcacao.ToString();
                txtOrigem.Texto = _trajetoViewModel.Origem;
                txtDestino.Texto = _trajetoViewModel.Destino;
                chkStatus.Checked = _trajetoViewModel.Ativo;
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
            _trajetoViewModel = ObterDadosTrajeto();

            _trajetoViewModel.Validate();

            if (_trajetoViewModel.Valido)
            {
                AtivaBotoes(EBotoes.Salvar);
                BloquearCampos(true);
                if (_trajetoViewModel.Codigo == 0)
                    _trajetoService.AdicionarTrajeto(_trajetoViewModel);
                else
                    _trajetoService.AtualizarTrajeto(_trajetoViewModel);
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

        private TrajetoViewModel ObterDadosTrajeto() => new TrajetoViewModel()
        {
            Codigo = !txtCodigo.Texto.IsNumeric() ? 0 : Convert.ToInt32(txtCodigo.Texto),
            CodigoEmbarcacao = Convert.ToInt32(txtEmbarcacao.TextoCentro),
            Origem = txtOrigem.Texto,
            Destino = txtDestino.Texto,
            Ativo = chkStatus.Checked
        };

        private void AlertaInconsistencias()
        {
            var alerta = new StringBuilder();
            alerta.AppendLine("Foram encontrados os serguintes erros:");

            foreach (var item in _trajetoViewModel.Mensagens)
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
        public frmTrajeto()
        {
            InitializeComponent();
            _baseRepository = new BaseRepository();
            _trajetoViewModel = new TrajetoViewModel();
            _trajetoService = new TrajetoService(_baseRepository);
            _genericService = new GenericService(_baseRepository);
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

        private void txtEmbarcacao_ButtonClick(object sender, EventArgs e)
        {
            var janela = new frmPesquisaGenerica();
            janela.CarregaDados<Domain.Entities.Embarcacao>("AND ATIVO = 1");
            janela.ShowDialog();

            if (janela.CodigoSelecionado > 0)
            {
                txtEmbarcacao.TextoCentro = janela.CodigoSelecionado.ToString();
                txtEmbarcacao.TextoDireita = _genericService.ObterDescricao<Domain.Entities.Embarcacao>(janela.CodigoSelecionado, "NOME");
            }
        }

        #endregion
    }
}
