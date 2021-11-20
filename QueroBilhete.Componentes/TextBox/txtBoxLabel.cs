using QueroBilhete.Componentes.Enumeradores;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace QueroBilhete.Componentes.TextBox
{
    public partial class txtBoxLabel : UserControl
    {
        private string _textoEsquerda;
        public string TextoEsquerda
        {
            get { return _textoEsquerda; }
            set { _textoEsquerda = value; labelEsquerda.Text = TextoEsquerda; }
        }

        private string _texto;
        public string Texto
        {
            get { return _texto; }
            set { _texto = value; txtBox.Text = Texto; }
        }

        private int _textoLargura;

        public int TextoLargura
        {
            get { return _textoLargura; }
            set { _textoLargura = value; txtBox.Width = TextoLargura; }
        }

        private EAlinhamento _textoAlinhamento;

        public EAlinhamento TextoAlinhamento
        {
            get { return _textoAlinhamento; }
            set
            {
                _textoAlinhamento = value;
                switch (TextoAlinhamento)
                {
                    case EAlinhamento.Esquerda:
                        txtBox.TextAlign = HorizontalAlignment.Left;
                        break;
                    case EAlinhamento.Centro:
                        txtBox.TextAlign = HorizontalAlignment.Center;
                        break;
                    case EAlinhamento.Direita:
                        txtBox.TextAlign = HorizontalAlignment.Right;
                        break;
                    default:
                        break;
                }
            }
        }

        private bool _enableAll;
        public bool EnableAll
        {
            get { return _enableAll; }
            set
            {
                _enableAll = value;
                panel1.Enabled = _enableAll;
            }
        }

        private bool _visibleAll;
        public bool VisibleAll
        {
            get { return _visibleAll; }
            set
            {
                _visibleAll = value;
                panel1.Visible = _visibleAll;
            }
        }

        private bool _textoMaiuculo;
        public bool TextoMaiusculo
        {
            get { return _textoMaiuculo; }
            set
            {
                _textoMaiuculo = value;
                txtBox.CharacterCasing = TextoMaiusculo ? CharacterCasing.Upper : CharacterCasing.Lower;
            }
        }

        private bool _textoSenha;
        public bool TextoSenha
        {
            get { return _textoSenha; }
            set
            {
                _textoSenha = value;
                txtBox.UseSystemPasswordChar = TextoSenha;
            }
        }

        private string _textoStatus;
        public string TextoStatus
        {
            get { return _textoStatus; }
            set { _textoStatus = value; }
        }

        private ToolStripStatusLabel _statusBarComponent;
        public ToolStripStatusLabel StatuBarComponent
        {
            get { return _statusBarComponent; }
            set { _statusBarComponent = value; }
        }

        private void txtBoxValidating(object sender, CancelEventArgs e)
        {
            TextBoxValidate?.Invoke(this, e);
            this.OnValidating(e);
        }

        private void txtBoxEnter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextoStatus) && StatuBarComponent != null)
                StatuBarComponent.Text = TextoStatus;
            _texto = txtBox.Text;
            this.OnEnter(e);
        }   

        private void txtBoxLeave(object sender, EventArgs e)
        {
            if (StatuBarComponent != null)
                StatuBarComponent.Text = "";
            _texto = txtBox.Text;
            this.OnLeave(e);
        }

        private void txtBoxKeyDown(object sender, KeyEventArgs e)
        {
            this.OnKeyDown(e);
        }

        public txtBoxLabel()
        {
            InitializeComponent();
            labelEsquerda.Text = "";
            Texto = "";
            TextoLargura = 53;
            TextoAlinhamento = EAlinhamento.Esquerda;
            EnableAll = true;
            VisibleAll = true;
            TextoStatus = "";
            StatuBarComponent = new ToolStripStatusLabel();
            TextoMaiusculo = false;
            TextoSenha = false;
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user exit textbox")]
        public event EventHandler TextBoxValidate;
        protected void txtBox_Validating(object sender, CancelEventArgs e)
        {
            txtBoxValidating(sender, e);
        }

        private void txtBox_Enter(object sender, EventArgs e)
        {
            txtBoxEnter(sender, e);
        }

        private void txtBox_Leave(object sender, EventArgs e)
        {
            txtBoxLeave(sender, e);
        }

        private void txtBox_KeyDown(object sender, KeyEventArgs e)
        {
            txtBoxKeyDown(sender, e);
        }
    }
}
