using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
            get { return _textoDireita; }
            set { _textoDireita = value; lblDireita.Text = TextoDireita; }
        }

        public bool BloquearCampos
        {
            get { return txtBox.Enabled; }
            set
            {
                txtBox.Enabled = value;
                btn1.Enabled = value;
                labelEsquerda.Enabled = value;
                lblDireita.Enabled = value;
            }
        }

        public QTextBox()
        {
            InitializeComponent();
            TextoEsquerda = "";
            TextoDireita = "";
        }
    }
}
