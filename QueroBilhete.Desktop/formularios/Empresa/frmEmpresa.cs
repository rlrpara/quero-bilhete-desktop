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

namespace QueroBilhete.Desktop.formularios.Empresa
{
    public partial class frmEmpresa : frmModelo
    {
        #region [Propriedades Privadas]
        private EmpresaViewModel _empresaViewModel;
        private readonly BaseRepository _baseRepository;
        private EmpresaService _empresaService;
        private GenericService _genericService;
        private string ultimoCnpj = "";
        #endregion

        #region [Métodos Privados]
        private void Novo()
        {
            AtivaBotoes(EBotoes.Novo);
            BloquearCampos(true);
            Configuracao.LimparCampos(grpCadastro.Controls);

            _empresaViewModel = new EmpresaViewModel();
            txtRazaoSocial.Focus();
            txtRazaoSocial.Select();
        }

        private void Editar()
        {
            AtivaBotoes(EBotoes.Editar);
            BloquearCampos(false);
            txtCodigo.Enabled = false;
            txtRazaoSocial.Select();
            txtRazaoSocial.Focus();
        }

        private void Excluir()
        {
            if (MessageBox.Show("Deseja remover este registro?", "ATENÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _empresaService.RemoverEmpresa(Convert.ToInt32(txtCodigo.Texto));
                Configuracao.LimparCampos(grpCadastro.Controls);
                AtivaBotoes(EBotoes.Apagar);
                BloquearCampos(true);
            }
        }

        private void Localizar()
        {
            var janela = new frmPesquisaGenerica();
            janela.CarregaDados<Domain.Entities.Empresa>("AND ATIVO = 1");
            janela.ShowDialog();

            PesquisarDados(janela.CodigoSelecionado);

            AtivaBotoes(EBotoes.Pesquisar);
            BloquearCampos(true);
        }

        private void PesquisarDados(int codigoSelecionado)
        {
            _empresaViewModel = codigoSelecionado > 0 ? _empresaService.CarregaEmpresa(codigoSelecionado) : new EmpresaViewModel();
            if (_empresaViewModel != null)
            {
                txtCodigo.Texto = _empresaViewModel.Codigo.ToString();
                txtUid.Texto = _empresaViewModel.UId;
                txtRegime.TextoCentro = _empresaViewModel.CodigoRegimeEmpresa.ToString();
                txtRegime.TextoDireita = _genericService.ObterDescricao<Domain.Entities.TipoRegimeEmpresa>(_empresaViewModel.CodigoRegimeEmpresa, "DESCRICAO");
                txtRazaoSocial.Texto = _empresaViewModel.RazaoSocial;
                txtCnpj.Texto = _empresaViewModel.Cnpj;
                txtIE.Texto = _empresaViewModel.InscricaoEstadual;
                txtIM.Texto = _empresaViewModel.InscricaoMunicipal;
                txtTelefone.Texto = _empresaViewModel.Telefone;
                txtCelular.Texto = _empresaViewModel.Celular;
                txtEmail.Texto = _empresaViewModel.Email;
                txtSite.Texto = _empresaViewModel.Site;
                txtLogo.TextoCentro = _empresaViewModel.Logo;
                txtCep.Texto = _empresaViewModel.Cep;
                txtEstado.Texto = _empresaViewModel.Estado;
                txtCidade.Texto = _empresaViewModel.Cidade;
                txtBairro.Texto = _empresaViewModel.Bairro;
                txtRua.Texto = _empresaViewModel.Rua;
                txtNumero.Texto = _empresaViewModel.Numero.ToString();
                chkStatus.Checked = _empresaViewModel.Ativo;
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
            _empresaViewModel = ObterDadosEmpresa();

            _empresaViewModel.Validate();

            if (_empresaViewModel.Valido)
            {
                AtivaBotoes(EBotoes.Salvar);
                BloquearCampos(true);
                if (_empresaViewModel.Codigo == 0)
                    _empresaService.AdicionarEmpresa(_empresaViewModel);
                else
                    _empresaService.AtualizarEmpresa(_empresaViewModel);
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

        private EmpresaViewModel ObterDadosEmpresa() => new EmpresaViewModel()
        {
            Codigo = !txtCodigo.Texto.IsNumeric() ? 0 : Convert.ToInt32(txtCodigo.Texto),
            UId = txtUid.Texto,
            RazaoSocial = txtRazaoSocial.Texto,
            Cnpj = txtCnpj.Texto,
            CodigoRegimeEmpresa = Convert.ToInt32(string.IsNullOrEmpty(txtRegime.TextoCentro) ? "0" : txtRegime.TextoCentro),
            InscricaoEstadual = txtIE.Texto,
            InscricaoMunicipal = txtIM.Texto,
            Telefone = txtTelefone.Texto,
            Celular = txtCelular.Texto,
            Email = txtEmail.Texto,
            Site = txtSite.Texto,
            Logo = txtLogo.TextoCentro,
            Cep = txtCep.Texto,
            Estado = txtEstado.Texto,
            Cidade = txtCidade.Texto,
            Bairro = txtBairro.Texto,
            Rua = txtRua.Texto,
            Numero = txtNumero.Texto.IsNumeric() ? Convert.ToInt32(txtNumero.Texto) : (int?)null,
            Ativo = chkStatus.Checked
        };

        private void AlertaInconsistencias()
        {
            var alerta = new StringBuilder();
            alerta.AppendLine("Foram encontrados os serguintes erros:");

            foreach (var item in _empresaViewModel.Mensagens)
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
        public frmEmpresa()
        {
            InitializeComponent();
            _baseRepository = new BaseRepository();
            _empresaViewModel = new EmpresaViewModel();
            _empresaService = new EmpresaService(_baseRepository);
            _genericService = new GenericService(_baseRepository);
            lblLog.Text = "Cadastrado em:  por:  Atualizado em:  por: ";
            Novo();
        }
        #endregion

        #region [Métodos Formulário]
        private void btnNovo_Click(object sender, System.EventArgs e)
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

        private async void txtCep_Validated(object sender, EventArgs e)
        {
            if (txtCep.Texto.ApenasNumeros().IsNumeric())
            {
                var retornoConsulta = await _empresaService.ConsultaGenericaApi<ConsultaCepViewModel>($"https://ws.apicep.com/cep.json?code={txtCep.Texto.Trim().ApenasNumeros()}");
                if (retornoConsulta != null && retornoConsulta.Ok)
                {
                    txtEstado.Texto = retornoConsulta?.State;
                    txtCidade.Texto = retornoConsulta?.City;
                    txtBairro.Texto = retornoConsulta?.District;
                    txtRua.Texto = retornoConsulta?.Address;
                }
            }
        }

        private async void txtCnpj_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtCnpj.Texto.Trim().ApenasNumeros().Length == 14 && ultimoCnpj != txtCnpj.Texto.ApenasNumeros())
            {
                var retornoConsulta = await _empresaService.ConsultaGenericaApi<ConsultaCnpjViewModel>($"https://www.receitaws.com.br/v1/cnpj/{txtCnpj.Texto.ApenasNumeros()}");

                if (retornoConsulta != null && retornoConsulta.status.Contains("OK"))
                {
                    txtRazaoSocial.Texto = retornoConsulta.nome;
                    txtCnpj.Texto = retornoConsulta.cnpj.ApenasNumeros();
                    txtCep.Texto = retornoConsulta.cep;
                    txtEstado.Texto = retornoConsulta.uf;
                    txtCidade.Texto = retornoConsulta.municipio;
                }
            }
            ultimoCnpj = txtCnpj.Texto.ApenasNumeros();
        }

        private void txtRegime_ButtonClick(object sender, EventArgs e)
        {
            var janela = new frmPesquisaGenerica();
            janela.CarregaDados<Domain.Entities.TipoRegimeEmpresa>("AND ATIVO = 1");
            janela.ShowDialog();

            if (janela.CodigoSelecionado > 0)
            {
                txtRegime.TextoCentro = janela.CodigoSelecionado.ToString();
                txtRegime.TextoDireita = _genericService.ObterDescricao<Domain.Entities.TipoRegimeEmpresa>(janela.CodigoSelecionado, "DESCRICAO");
            }
        }

        #endregion
    }
}
