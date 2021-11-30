using dotenv.net;
using QueroBilhete.Data.Database;
using QueroBilhete.Desktop.formularios.Embarcacao;
using QueroBilhete.Desktop.formularios.Empresa;
using QueroBilhete.Desktop.formularios.Login;
using QueroBilhete.Desktop.formularios.Passageiro;
using QueroBilhete.Desktop.formularios.PDV;
using QueroBilhete.Desktop.formularios.Tipo;
using QueroBilhete.Desktop.formularios.Trajeto;
using QueroBilhete.Desktop.formularios.Usuario;
using QueroBilhete.Desktop.Globais;
using System;
using System.Windows.Forms;

namespace QueroBilhete.Desktop
{
    public partial class Home : Form
    {
        #region Métodos Privados
        private void AddJanela(Form form)
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
        private void Sair()
        {
            Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddJanela(new frmUsuario());
        }

        private void pDVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddJanela(new frmPDV());
        }
        #endregion

        #region Construtor
        public Home()
        {
            InitializeComponent();
        }
        #endregion

        private void Home_Load(object sender, EventArgs e)
        {
            DotEnv.Fluent().WithEnvFiles(".env").WithTrimValues().Load();
            DatabaseConfiguration.GerenciarBanco();
            AbreTelaLogin();

            if (!Gerais.Logado)
                Close();
        }

        private void AbreTelaLogin()
        {
            var janela = new frmLogin();
            janela.ShowDialog();
            statusTexto.Text = $"Usuário: {Gerais.Codigo} - {Gerais.Email.Split('@')[0]}";
            statusVersao.Text = "Versão 1.0";
        }

        private void Home_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    break;
                case Keys.F2:
                    break;
                case Keys.F3:
                    break;
                case Keys.F4:
                    break;
                case Keys.F5:
                    break;
                case Keys.F6:
                    break;
                case Keys.F7:
                    break;
                case Keys.F8:
                    break;
                case Keys.F9:
                    break;
                case Keys.F10:
                    break;
                case Keys.F11:
                    break;
                case Keys.F12:
                    break;
                case Keys.Enter:
                    SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                    break;
                default:
                    break;
            }
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddJanela(new frmEmpresa());
        }

        private void embarcaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddJanela(new frmEmbarcacao());
        }

        private void passageiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddJanela(new frmPassageiro());
        }

        private void tipoDaViagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddJanela(new frmTipoViagem());
        }

        private void tipoDoRegimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddJanela(new frmTipoRegimeEmpresa());
        }

        private void tipoDePassagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddJanela(new frmTipoPassagem());
        }

        private void trajetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddJanela(new frmTrajeto());
        }
    }
}
