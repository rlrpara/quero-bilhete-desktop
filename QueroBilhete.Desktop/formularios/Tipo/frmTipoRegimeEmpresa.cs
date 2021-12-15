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
    public partial class frmTipoRegimeEmpresa : frmModelo
    {
        #region [Propriedades Privadas]
        private TipoRegimeEmpresaViewModel _tipoRegimeEmpresaViewModel;
        private readonly BaseRepository _baseRepository;
        private TipoRegimeEmpresaervice _tipoRegimeEmpresaService;
        #endregion

        #region [Métodos Privados]
        private void Novo()
        {
            AtivaBotoes(EBotoes.Novo);
            BloquearCampos(true);
            Configuracao.LimparCampos(panelDados.Controls);

            _tipoRegimeEmpresaViewModel = new TipoRegimeEmpresaViewModel();
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
                _tipoRegimeEmpresaService.RemoverTipoRegimeEmpresa(Convert.ToInt32(txtCodigo.Texto));
                Configuracao.LimparCampos(panelDados.Controls);
                AtivaBotoes(EBotoes.Apagar);
                BloquearCampos(true);
            }
        }

        private void Localizar()
        {
            var janela = new frmPesquisaGenerica();
            janela.CarregaDados<Domain.Entities.TipoRegimeEmpresa>("AND ATIVO = 1");
            janela.ShowDialog();

            PesquisarDados(janela.CodigoSelecionado);

            AtivaBotoes(EBotoes.Pesquisar);
            BloquearCampos(true);
        }

        private void PesquisarDados(int codigoSelecionado)
        {
            _tipoRegimeEmpresaViewModel = codigoSelecionado > 0 ? _tipoRegimeEmpresaService.CarregaTipoRegimeEmpresa(codigoSelecionado) : new TipoRegimeEmpresaViewModel();
            if (_tipoRegimeEmpresaViewModel != null)
            {
                txtCodigo.Texto = _tipoRegimeEmpresaViewModel.Codigo.ToString();
                txtDescricao.Texto = _tipoRegimeEmpresaViewModel.Descricao;
                chkStatus.Checked = _tipoRegimeEmpresaViewModel.Ativo;
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
            _tipoRegimeEmpresaViewModel = ObterDadosTipoRegimeEmpresa();

            _tipoRegimeEmpresaViewModel.Validate();

            if (_tipoRegimeEmpresaViewModel.Valido)
            {
                AtivaBotoes(EBotoes.Salvar);
                BloquearCampos(true);
                if (_tipoRegimeEmpresaViewModel.Codigo == 0)
                    _tipoRegimeEmpresaService.AdicionarTipoRegimeEmpresa(_tipoRegimeEmpresaViewModel);
                else
                    _tipoRegimeEmpresaService.AtualizarTipoRegimeEmpresa(_tipoRegimeEmpresaViewModel);
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

        private TipoRegimeEmpresaViewModel ObterDadosTipoRegimeEmpresa() => new TipoRegimeEmpresaViewModel()
        {
            Codigo = !txtCodigo.Texto.IsNumeric() ? 0 : Convert.ToInt32(txtCodigo.Texto),
            Descricao = txtDescricao.Texto,
            Ativo = chkStatus.Checked
        };

        private void AlertaInconsistencias()
        {
            var alerta = new StringBuilder();
            alerta.AppendLine("Foram encontrados os serguintes erros:");

            foreach (var item in _tipoRegimeEmpresaViewModel.Mensagens)
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
        public frmTipoRegimeEmpresa()
        {
            InitializeComponent();
            _baseRepository = new BaseRepository();
            _tipoRegimeEmpresaViewModel = new TipoRegimeEmpresaViewModel();
            _tipoRegimeEmpresaService = new TipoRegimeEmpresaervice(_baseRepository);
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
