using QueroBilhete.Data.Repositories;
using QueroBilhete.Desktop.Globais;
using QueroBilhete.Infra.Data.Contex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QueroBilhete.Desktop.formularios.Pesquisa
{
    public partial class frmPesquisaGenerica : Form
    {
        private BaseRepository baseRepository = new BaseRepository();

        private int _codigoSelecionado;
        public int CodigoSelecionado
        {
            get { return _codigoSelecionado; }
            set { _codigoSelecionado = value; }
        }

        private string _textoSelecionado;

        public string TextoSelecionado
        {
            get { return _textoSelecionado; }
            set { _textoSelecionado = value; }
        }


        private void ConfiguracaoInicial()
        {
            cmbFiltro.SelectedIndex = 0;
            cmbCondicao.SelectedIndex = 0;
            txtPesquisa.Select();
            txtPesquisa.Focus();
            CodigoSelecionado = 0;
            TextoSelecionado = "";
        }

        public void CarregaDados<T>(string sqlWhere) where T : class
        {
            IEnumerable<T> lista = baseRepository.BuscarTodosPorQuery<T>(GeradorDapper.ObterDadosGrid<T>(sqlWhere));
            dgvDados.DataSource = lista;
            
            if(lista.Count() > 0)
                ConfiguraGrid(dgvDados, lista);

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

        public frmPesquisaGenerica()
        {
            InitializeComponent();
            ConfiguracaoInicial();
        }

        private void Limpar()
        {
            txtPesquisa.Text = "";
        }

        private void frmPesquisaGenerica_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                    break;
                case Keys.Escape:
                    Fechar();
                    break;
                default:
                    break;
            }
        }

        private void Fechar()
        {
            Close();
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDados.Rows.Count > 0)
            {
                CodigoSelecionado = Convert.ToInt32(dgvDados.CurrentRow.Cells["Codigo"].Value);
                _textoSelecionado = dgvDados.CurrentRow.Cells["Codigo"].Value.ToString();
            }
            else
            {
                CodigoSelecionado = 0;
                _textoSelecionado = "";
            }
            Close();
        }
    }
}
