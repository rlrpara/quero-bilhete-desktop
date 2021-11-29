using QueroBilhete.Data.Repositories;
using QueroBilhete.Desktop.Enumeradores;
using QueroBilhete.Desktop.Globais;
using QueroBilhete.Infra.Data.Contex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QueroBilhete.Desktop.formularios.Modelo
{
    public partial class frmModelo : Form
    {
        #region [Metodos Privados]
        protected void Sair()
        {
            Close();
        }

        protected void AtivaBotoes(EBotoes acao)
        {
            Configuracao.AtivaBotoes(acao, btnNovo, btnEditar, btnExcluir, btnLocalizar, btnImprimir, btnSalvar, btnCancelar);
        }

        protected void AtivaConfiguracaoPadrao()
        {
            AtivaBotoes(EBotoes.Novo);
            Configuracao.LimparCampos(grpCadastro.Controls);
        }

        protected void BloquearCampos(bool ativar)
        {
            Configuracao.BloquearCampos(!ativar, grpCadastro.Controls);
        }
        protected void AlteraStatusCheckBox(ref CheckBox chkStatus)
        {
            chkStatus.Text = chkStatus.Checked ? "Ativo" : "Inativo";
        }
        protected void AddJanela(Form form, EJanela tipoJanela = EJanela.MdiFilho)
        {
            if ((int)tipoJanela == 2)
            {
                foreach (Form formFilho in this.MdiChildren)
                {
                    if (formFilho.GetType() == form.GetType())
                    {
                        formFilho.Focus();
                        return;
                    }
                }
                form.MdiParent = this;
                form.WindowState = FormWindowState.Maximized;
                form.Show();
            }
            else
                form.ShowDialog();
        }

        public void CarregaDados<T>(DataGridView gridDados, BaseRepository baseRepository, string sqlWhere) where T : class
        {
            IEnumerable<T> lista = baseRepository.BuscarTodosPorQuery<T>(GeradorDapper.ObterDadosGrid<T>(sqlWhere)).ToList();
            gridDados.DataSource = lista;

            if (lista.Count() > 0)
                ConfiguraGrid(gridDados, lista);

        }

        private void ConfiguraGrid<T>(DataGridView dgvDados, IEnumerable<T> lista) where T : class
        {
            Configuracao.ConfiguraGrid(dgvDados);
            var contador = 0;
            var colunas = GeradorDapper.ObterColunasGrid(lista);

            foreach (var campos in colunas.Replace($"\r\n", "").Split(';').ToArray())
            {
                var coluna = campos.Replace(@"\r\n", "").Split('|');
                Configuracao.GridDados(dgvDados, coluna[1].ToString(), coluna[1].ToString(), 2, Convert.ToInt32(coluna[2]), Convert.ToBoolean(coluna[3]), false, contador);
                contador += 1;
            }
        }
        #endregion

        #region [Construtor]
        public frmModelo()
        {
            InitializeComponent();
            lblLog.Text = "Cadastrado em:  por:  Atualizado em:  por: ";
        }
        #endregion

        private void frmModelo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                    break;
                case Keys.Escape:
                    Sair();
                    break;
                default:
                    break;
            }
        }
    }
}
