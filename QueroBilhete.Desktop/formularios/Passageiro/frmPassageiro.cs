using Newtonsoft.Json;
using QueroBilhete.Data.Repositories;
using QueroBilhete.Desktop.Enumeradores;
using QueroBilhete.Desktop.formularios.Modelo;
using QueroBilhete.Desktop.formularios.Pesquisa;
using QueroBilhete.Desktop.Globais;
using QueroBilhete.Infra.Utilities.ExtensionMethods;
using QueroBilhete.Infra.Utilities.Utilitarios;
using QueroBilhete.Service.Service;
using QueroBilhete.Service.ViewModels;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace QueroBilhete.Desktop.formularios.Passageiro
{
    public partial class frmPassageiro : frmModelo
    {
        #region [Propriedades Privadas]
        private PassageiroViewModel _passageiroViewModel;
        private readonly BaseRepository _baseRepository;
        private PassageiroService _passageiroService;
        #endregion

        #region [Metodos Privados]
        private void Sair()
        {
            Close();
        }
        private void BloquearCampos(bool ativar)
        {
            Configuracao.BloquearCampos(!ativar, grpCadastro.Controls);
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
            _passageiroViewModel = new PassageiroViewModel();
            PesquisarDados(0);
            txtCodigo.EnableAll = false;
            txtNome.Focus();
            txtNome.Select();
        }

        private void Editar()
        {
            AtivaBotoes(EBotoes.Editar);
            BloquearCampos(false);
            txtCodigo.EnableAll = false;
            txtNome.Select();
            txtNome.Focus();
        }

        private void Excluir()
        {
            if (MessageBox.Show("Deseja remover este registro?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _passageiroService.RemoverPassageiro(Convert.ToInt32(txtCodigo.Texto));
                Configuracao.LimparCampos(grpCadastro.Controls);
                AtivaBotoes(EBotoes.Apagar);
                BloquearCampos(true);
            }
        }

        private void Localizar()
        {
            var janela = new frmPesquisaGenerica();
            janela.CarregaDados<Domain.Entities.Passageiro>("AND ATIVO = 1");
            janela.ShowDialog();

            PesquisarDados(janela.CodigoSelecionado);

            AtivaBotoes(EBotoes.Pesquisar);
            BloquearCampos(true);
        }

        private void PesquisarDados(int codigoSelecionado)
        {
            _passageiroViewModel = codigoSelecionado > 0 ? _passageiroService.CarregaPassageiro(codigoSelecionado) : new PassageiroViewModel();
            if (_passageiroViewModel != null)
            {
                txtCodigo.Texto = _passageiroViewModel.Codigo.ToString();
                txtNome.Texto = _passageiroViewModel.Nome;
                txtRG.Texto = _passageiroViewModel.RG;
                txtCPF.Texto = _passageiroViewModel.CPF;
                txtTelefone.Texto = _passageiroViewModel.Telefone;
                txtCelular.Texto = _passageiroViewModel.Celular;
                txtEmail.Texto = _passageiroViewModel.Email;
                txtCep.Texto = _passageiroViewModel.Cep;
                txtEstado.Texto = _passageiroViewModel.Estado;
                txtCidade.Texto = _passageiroViewModel.Cidade;
                txtBairro.Texto = _passageiroViewModel.Bairro;
                txtRua.Texto = _passageiroViewModel.Rua;
                txtNumero.Texto = _passageiroViewModel.Numero.ToString();
                chkStatus.Checked = _passageiroViewModel.Ativo;
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

            _passageiroViewModel = ObterDados();

            _passageiroViewModel.Validate();

            if (_passageiroViewModel.Valido)
            {
                AtivaBotoes(EBotoes.Salvar);
                BloquearCampos(true);
                if (_passageiroViewModel.Codigo == 0)
                    _passageiroService.AdicionarPassageiro(_passageiroViewModel);
                else
                    _passageiroService.AtualizarPassageiro(_passageiroViewModel);
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

            foreach (var item in _passageiroViewModel.Mensagens)
                alerta.AppendLine(item.ToString());

            MessageBox.Show(alerta.ToString());
        }

        private PassageiroViewModel ObterDados() => new PassageiroViewModel()
        {
            Codigo = !txtCodigo.Texto.IsNumeric() ? 0 : Convert.ToInt32(txtCodigo.Texto),
            Nome = txtNome.Texto,
            RG = txtRG.Texto,
            CPF = txtCPF.Texto,
            Telefone = txtTelefone.Texto,
            Celular = txtCelular.Texto,
            Email = txtEmail.Texto,
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
        public frmPassageiro()
        {
            InitializeComponent();
            AtivaConfiguracaoPadrao();
            _baseRepository = new BaseRepository();
            _passageiroViewModel = new PassageiroViewModel();
            _passageiroService = new PassageiroService(_baseRepository);
            lblLog.Text = "Cadastrado em:  por:  Atualizado em:  por: ";
            Novo();
        }

        #endregion

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

        private void chkStatus_Click(object sender, EventArgs e)
        {
            AlteraStatusCheckBox(ref chkStatus);
        }

        private async void txtCep_Validated(object sender, EventArgs e)
        {
            if (txtCep.Texto.ApenasNumeros().IsNumeric())
            {
                var retornoConsulta = await _passageiroService.ConsultaGenericaApi<ConsultaCepViewModel>($"https://ws.apicep.com/cep.json?code={txtCep.Texto.Trim().ApenasNumeros()}");
                if (retornoConsulta != null && retornoConsulta.Ok)
                {
                    txtEstado.Texto = retornoConsulta?.State;
                    txtCidade.Texto = retornoConsulta?.City;
                    txtBairro.Texto = retornoConsulta?.District;
                    txtRua.Texto = retornoConsulta?.Address;
                }
            }
        }
    }
}
