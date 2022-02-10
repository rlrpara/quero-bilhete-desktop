using QueroBilhete.Data.Repositories;
using QueroBilhete.Desktop.Enumeradores;
using QueroBilhete.Desktop.formularios.Pesquisa;
using QueroBilhete.Desktop.Globais;
using QueroBilhete.Infra.Utilities.ExtensionMethods;
using QueroBilhete.Service.Service;
using QueroBilhete.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QueroBilhete.Desktop.formularios.PDV
{
    public partial class frmPDV : Form
    {
        #region Propriedades Privadas
        private readonly BaseRepository _baseRepository;
        private readonly EmpresaService _empresaService;
        private readonly EmbarcacaoService _embarcacaoService;
        private readonly EmbarcacaoPoltronaService _embarcacaoPoltronaService;
        private readonly TrajetoService _trajetoService;
        private readonly PassagemService _passagemService;
        private readonly PassageiroService _passageiroService;
        private readonly TipoPassagemService _tipoPassagemService;
        private readonly GenericService _genericService;
        
        private string _assentosSelecionados;
        #endregion

        #region Métodos Privados
        private void LimpaCampos()
        {
            Configuracao.LimparCampos(panelDados.Controls);
        }
        private void AbreCaixa()
        {

        }
        private void FecharCaixa()
        {
            LimpaCampos();
        }
        private void btnNovaVenda_Click(object sender, System.EventArgs e)
        {
            NovaVenda();
        }
        private void NovaVenda()
        {
        }

        private void Sair()
        {
            Close();
        }
        #endregion

        #region Construtor
        public frmPDV()
        {
            InitializeComponent();
            _baseRepository = new BaseRepository();
            _empresaService = new EmpresaService(_baseRepository);
            _embarcacaoService = new EmbarcacaoService(_baseRepository);
            _trajetoService = new TrajetoService(_baseRepository);
            _passagemService = new PassagemService(_baseRepository);
            _passageiroService = new PassageiroService(_baseRepository);
            _embarcacaoPoltronaService = new EmbarcacaoPoltronaService(_baseRepository);
            _tipoPassagemService = new TipoPassagemService(_baseRepository);
            _genericService = new GenericService(_baseRepository);
            _assentosSelecionados = string.Empty;
            LimpaCampos();
        }

        #endregion

        #region [Métodos Formulário]

        #endregion
    }
}
