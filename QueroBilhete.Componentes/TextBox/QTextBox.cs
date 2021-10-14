using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace QueroBilhete.Componentes.TextBox
{
    public partial class QTextBox : UserControl
    {
        private string _textoEsquerda;
        public string TextoEsquerda
        {
            get { return _textoEsquerda; }
            set { _textoEsquerda = value; labelEsquerda.Text = TextoEsquerda; }
        }

        private string _textoDireita;

        public string TextoDireita
        {
            get
            { 
                return !string.IsNullOrEmpty(_textoDireita) ? _textoDireita.ToUpper() : _textoDireita;
            }
            set { _textoDireita = value; lblDireita.Text = TextoDireita; }
        }

        private string _textoCentro;

        public string TextoCentro
        {
            get { return _textoCentro; }
            set { _textoCentro = value; txtBox.Text = TextoCentro; }
        }


        private string _textoStatus;
        public string TextoStatus
        {
            get { return _textoStatus; }
            set {_textoStatus = value; }
        }

        private ToolStripStatusLabel _statusBarComponent;
        public ToolStripStatusLabel StatuBarComponent
        {
            get { return _statusBarComponent; }
            set { _statusBarComponent = value; }
        }

        private bool _enableAll = true;
        public bool EnableAll
        {
            get { return _enableAll; }
            set
            {
                _enableAll = value;
                panel1.Enabled = _enableAll;
            }
        }


        private void QTextBoxOnClick(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void QTextBoxOnValidating(object sender, CancelEventArgs e)
        {
            this.OnValidating(e);
        }

        private void QTextBoxEnter(object sender, EventArgs e)
        {
            this.OnEnter(e);
        }

        private void QTextBoxLeave(object sender, EventArgs e)
        {
            this.OnLeave(e);
        }

        private void QTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            this.OnKeyDown(e);
        }

        public QTextBox()
        {
            InitializeComponent();
            TextoEsquerda = "";
            TextoDireita = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            QTextBoxOnClick(sender, e);
        }

        private void txtBox_Validating(object sender, CancelEventArgs e)
        {
            QTextBoxOnValidating(sender, e);
        }

        private void txtBox_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextoStatus) && StatuBarComponent != null)
                StatuBarComponent.Text = TextoStatus;
            QTextBoxEnter(sender, e);
        }

        private void txtBox_Leave(object sender, EventArgs e)
        {
            if (StatuBarComponent != null)
                StatuBarComponent.Text = "";
            QTextBoxLeave(sender, e);
        }

        private void txtBox_KeyDown(object sender, KeyEventArgs e)
        {
            QTextBoxKeyDown(sender, e);
        }
    }
}
