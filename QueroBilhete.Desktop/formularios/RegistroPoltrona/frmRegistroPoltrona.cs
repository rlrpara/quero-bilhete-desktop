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
    public partial class frmRegistroPoltrona : frmModelo
    {
        #region [Propriedades Privadas]
        private EmbarcacaoPoltronaViewModel _embarcacaoPoltronaViewModel;
        private readonly BaseRepository _baseRepository;
        private EmbarcacaoPoltronaService _embarcacaoPoltronaService;
        private GenericService _genericService;
        #endregion

        #region [Métodos Privados]
        private void Novo()
        {
            AtivaBotoes(EBotoes.Novo);
            BloquearCampos(false);
            Configuracao.LimparCampos(panelDados.Controls);

            _embarcacaoPoltronaViewModel = new EmbarcacaoPoltronaViewModel();
            txtCodigo.EnableAll = false;
            txtLetra.Focus();
            txtLetra.Select();
            chkStatus.Checked = true;
        }

        private void Editar()
        {
            AtivaBotoes(EBotoes.Editar);
            BloquearCampos(false);
            txtCodigo.EnableAll = false;
            txtLetra.Focus();
            txtLetra.Select();
        }

        private void Excluir()
        {
            if (MessageBox.Show("Deseja remover este registro?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _embarcacaoPoltronaService.RemoverEmbarcacaoPoltrona(Convert.ToInt32(txtCodigo.Texto));
                Configuracao.LimparCampos(panelDados.Controls);
                AtivaBotoes(EBotoes.Apagar);
                BloquearCampos(true);
            }
        }

        private void Localizar()
        {
            var janela = new frmPesquisaGenerica();
            janela.CarregaDados<Domain.Entities.EmbarcacaoPoltrona>("AND ATIVO = 1");
            janela.ShowDialog();

            if (janela.CodigoSelecionado > 0)
                PesquisarDados(janela.CodigoSelecionado);

            AtivaBotoes(EBotoes.Pesquisar);
            BloquearCampos(true);
        }

        private void PesquisarDados(int codigoSelecionado)
        {
            _embarcacaoPoltronaViewModel = codigoSelecionado > 0 ? _embarcacaoPoltronaService.CarregaEmbarcacaoPoltrona(codigoSelecionado) : new EmbarcacaoPoltronaViewModel();
            if (_embarcacaoPoltronaViewModel != null)
            {
                txtCodigo.Texto = _embarcacaoPoltronaViewModel.Codigo.ToString();
                txtEmbarcacao.TextoCentro = _embarcacaoPoltronaViewModel.CodigoEmbarcacao.ToString();
                txtEmbarcacao.TextoDireita = _genericService.ObterDescricao<Domain.Entities.Embarcacao>(_embarcacaoPoltronaViewModel.CodigoEmbarcacao, "NOME");
                txtLetra.Texto = _embarcacaoPoltronaViewModel.Letra;
                txtInicio.Texto = _embarcacaoPoltronaViewModel.Inicio.ToString();
                txtFim.Texto = _embarcacaoPoltronaViewModel.Fim.ToString();
                txtEixoX.TextoCentro = _embarcacaoPoltronaViewModel.EixoX.ToString();
                txtEixoY.Texto = _embarcacaoPoltronaViewModel.EixoY.ToString();
                txtTotalColunas.Texto = _embarcacaoPoltronaViewModel.TotalColuna.ToString();
                txtAlinhamento.TextoCentro = _embarcacaoPoltronaViewModel.Alinhamento.ToString();
                txtTotalColunas.Texto = _embarcacaoPoltronaViewModel.TotalColuna.ToString();
                chkStatus.Checked = _embarcacaoPoltronaViewModel.Ativo;
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
            _embarcacaoPoltronaViewModel = ObterDados();

            _embarcacaoPoltronaViewModel.Validate();

            if (_embarcacaoPoltronaViewModel.Valido)
            {
                AtivaBotoes(EBotoes.Salvar);
                BloquearCampos(true);
                if (_embarcacaoPoltronaViewModel.Codigo == 0)
                {
                    _embarcacaoPoltronaService.AdicionarEmbarcacaoPoltrona(_embarcacaoPoltronaViewModel);
                    txtCodigo.Texto = _embarcacaoPoltronaService.ObterUltimoRegistro<Domain.Entities.EmbarcacaoPoltrona>().ToString();
                }
                else
                    _embarcacaoPoltronaService.AtualizarEmbarcacaoPoltrona(_embarcacaoPoltronaViewModel);
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

        private EmbarcacaoPoltronaViewModel ObterDados() => new EmbarcacaoPoltronaViewModel()
        {
            Codigo = !txtCodigo.Texto.IsNumeric() ? 0 : Convert.ToInt32(txtCodigo.Texto),
            CodigoEmbarcacao = Convert.ToInt32(txtEmbarcacao.TextoCentro),
            Letra = txtLetra.Texto,
            Inicio = txtInicio.Texto.IsNumeric() ? Convert.ToInt32(txtInicio.Texto) : 0,
            Fim = txtFim.Texto.IsNumeric() ? Convert.ToInt32(txtFim.Texto) : 0,
            EixoX = txtEixoX.TextoCentro.IsNumeric() ? Convert.ToInt32(txtEixoX.TextoCentro) : 0,
            EixoY = txtEixoY.Texto.IsNumeric() ? Convert.ToInt32(txtEixoY.Texto) : 0,
            TotalColuna = txtTotalColunas.Texto.IsNumeric() ? Convert.ToInt32(txtTotalColunas.Texto) : 0,
            Alinhamento = txtAlinhamento.TextoCentro.IsNumeric() ? Convert.ToInt32(txtAlinhamento.TextoCentro) : 0,
            Ativo = chkStatus.Checked
        };

        private void AlertaInconsistencias()
        {
            var alerta = new StringBuilder();
            alerta.AppendLine("Foram encontrados os serguintes erros:");

            foreach (var item in _embarcacaoPoltronaViewModel.Mensagens)
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
        public frmRegistroPoltrona(int codigoEmbarcacao = 0, int codigoPoltrona = 0)
        {
            InitializeComponent();
            _baseRepository = new BaseRepository();
            _genericService = new GenericService(_baseRepository);
            _embarcacaoPoltronaService = new EmbarcacaoPoltronaService(_baseRepository);
            _embarcacaoPoltronaViewModel= new EmbarcacaoPoltronaViewModel();
            lblLog.Text = "Cadastrado em:  por:  Atualizado em:  por: ";
            Novo();

            if (codigoEmbarcacao > 0 && codigoPoltrona == 0)
                txtEmbarcacao.TextoCentro = codigoEmbarcacao.ToString();
            else if(codigoEmbarcacao > 0 && codigoPoltrona > 0)
                PesquisarDados(codigoPoltrona);
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

        private void txtAlinhamento_ButtonClick(object sender, EventArgs e)
        {
            var janela = new frmPesquisaGenerica();
            janela.CarregaDados<Domain.Entities.Alinhamento>("AND ATIVO = 1");
            janela.ShowDialog();

            if (janela.CodigoSelecionado > 0)
            {
                txtAlinhamento.TextoCentro = janela.CodigoSelecionado.ToString();
                txtAlinhamento.TextoDireita = _genericService.ObterDescricao<Domain.Entities.Alinhamento>(janela.CodigoSelecionado, "NOME");
            }
        }

        private void txtEixoX_ButtonClick(object sender, EventArgs e)
        {
            if (txtEmbarcacao.TextoCentro.IsNumeric() && (txtInicio.Texto.IsNumeric() && txtFim.Texto.IsNumeric() && !string.IsNullOrWhiteSpace(txtLetra.Texto)))
            {
                var janela = new frmPreviewLayoutEmbarcacao(Convert.ToInt32(txtEmbarcacao.TextoCentro));
                janela.ShowDialog();
                int eixox = janela.eixoX;
                int eixoy = janela.eixoY;

                if (eixox > 0)
                {
                    txtEixoX.TextoCentro = eixox.ToString();
                    txtEixoY.Texto = eixoy.ToString();
                }
            }
            else
                MessageBox.Show("Campos Letra/Inicio/Fim devem ser informados");
        }

        private void txtEixoX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                txtEixoX_ButtonClick(sender, e);
            }
        }

        #endregion

        private void txtAlinhamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                txtAlinhamento_ButtonClick(sender, e);
            }
        }

        private void txtAlinhamento_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            txtAlinhamento.TextoDireita = (!txtAlinhamento.TextoCentro.IsNumeric())
                ? "" : _genericService.ObterDescricao<Domain.Entities.Alinhamento>(Convert.ToInt32(txtAlinhamento.TextoCentro), "NOME");
        }
    }
}
