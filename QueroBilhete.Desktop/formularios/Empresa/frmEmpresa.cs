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
        private EmpresaService empresaService;
        #endregion


        #region [Métodos Privados]
        private void Novo()
        {
            AtivaBotoes(EBotoes.Novo);
            BloquearCampos(false);

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
                empresaService.RemoverEmpresa(Convert.ToInt32(txtCodigo.Texto));
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
            _empresaViewModel = codigoSelecionado > 0 ? empresaService.CarregaEmpresa(codigoSelecionado) : new EmpresaViewModel();
            if (_empresaViewModel != null)
            {
                txtCodigo.Texto = _empresaViewModel.Codigo.ToString();
                txtUid.Texto = _empresaViewModel.UId;
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
                    empresaService.AdicionarEmpresa(_empresaViewModel);
                else
                    empresaService.AtualizarEmpresa(_empresaViewModel);
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
            empresaService = new EmpresaService(_baseRepository);
            lblLog.Text = "Cadastrado em:  por:  Atualizado em:  por: ";
            Novo();
        }
        #endregion

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
            chkStatus.Text = chkStatus.Checked ? "Ativo" : "Inativo";
        }
    }
}
