using QueroBilhete.Data.Repositories;
using QueroBilhete.Domain.Interfaces;
using System;
using System.Collections.Generic;
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


        private void ConfiguracaoInicial()
        {
            cmbFiltro.SelectedIndex = 0;
            cmbCondicao.SelectedIndex = 0;
            txtPesquisa.Select();
            txtPesquisa.Focus();
        }

        public void CarregaDados<T>(IList<T> list)
        {
            
            dgvDados.DataSource = list;
        }

        private void ConfiguraListView(IEntity dados)
        {
            dgvDados.DataSource = dados;
        }

        public frmPesquisaGenerica()
        {
            InitializeComponent();
            ConfiguracaoInicial();
            CodigoSelecionado = 0;
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
                CodigoSelecionado = Convert.ToInt32(dgvDados.SelectedRows[e.RowIndex].Cells["Codigo"].Value);
            else
                CodigoSelecionado = 0;
            Close();
        }
    }
}
