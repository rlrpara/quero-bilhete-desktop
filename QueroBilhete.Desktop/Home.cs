using dotenv.net;
using QueroBilhete.Data.Database;
using QueroBilhete.Desktop.formularios.Login;
using QueroBilhete.Desktop.formularios.PDV;
using QueroBilhete.Desktop.formularios.Usuario;
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
        }

        private void AbreTelaLogin()
        {
            var janela = new frmLogin();
            janela.ShowDialog();
        }
    }
}
