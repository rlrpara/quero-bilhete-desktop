using QueroBilhete.Data.Repositories;
using QueroBilhete.Domain.Entities;
using QueroBilhete.Service.Service;
using QueroBilhete.Service.ViewModels;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace QueroBilhete.Desktop.formularios.Pesquisa
{
    public partial class frmPesquisaGenerica : Form
    {
        private BaseRepository baseRepository = new BaseRepository();

        private void ConfiguracaoInicial()
        {
            cmbFiltro.SelectedIndex = 0;
            cmbCondicao.SelectedIndex = 0;
            txtPesquisa.Select();
            txtPesquisa.Focus();

            var genericService = new GenericService<UsuarioViewModel>(baseRepository);
            ConfiguraListView(genericService.ObterTodos(""));
        }

        private void ConfiguraListView(List<object> dados)
        {
            listVDados.View = View.Details;
            listVDados.FullRowSelect = true;
            listVDados.GridLines = true;
            listVDados.LabelEdit = false;

            PropertyInfo[] props = typeof(Domain.Entities.Usuario).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var item in props)
            {
                var coluna = new ColumnHeader
                {
                    Text = item.Name
                };
                OpcoesBase? opcoesBase = item.GetCustomAttribute(typeof(OpcoesBase)) as OpcoesBase;
                if (opcoesBase != null && (opcoesBase.UsarParaBuscar || opcoesBase.ChavePrimaria))
                { 
                    listVDados.Columns.Add(coluna);                
                }
            }

            foreach (UsuarioViewModel dado in dados)
            {
                var lista = listVDados.Items.Add("");
                var usuarioConvertido = new Domain.Entities.Usuario() {
                    Codigo = dado.Codigo,
                    Uid = dado.Uid,
                    Nome = dado.Nome,
                    Email = dado.Email,
                    Senha = dado.Senha,
                    Cep = dado.Cep,
                    Estado = dado.Estado,
                    Cidade = dado.Cidade,
                    Bairro = dado.Bairro,
                    Rua = dado.Rua,
                    Numero = dado.Numero,
                    Ativo = dado.Ativo,
                    DataCadastro = dado.DataCadastro,
                    DataAtualizacao = dado.DataAtualizacao
                };

                foreach (var item in props)
                {

                    OpcoesBase? opcoesBase = item.GetCustomAttribute(typeof(OpcoesBase)) as OpcoesBase;
                    if (opcoesBase != null && (opcoesBase.UsarParaBuscar || opcoesBase.ChavePrimaria) && item.GetValue(usuarioConvertido) != null)
                    { 
                        if (item == props[0])
                            lista.Text = item.GetValue(usuarioConvertido).ToString();
                        else
                            lista.SubItems.Add(item.GetValue(usuarioConvertido).ToString());
                    }
                }
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

            listVDados.Clear();
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
    }
}
