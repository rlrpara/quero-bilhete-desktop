
namespace QueroBilhete.Componentes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCodigo = new QueroBilhete.Componentes.TextBox.QTextBox();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtCliente = new QueroBilhete.Componentes.TextBox.QTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.qTextBox1 = new QueroBilhete.Componentes.TextBox.QTextBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCodigo.EnableAll = true;
            this.txtCodigo.Location = new System.Drawing.Point(0, 0);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(800, 26);
            this.txtCodigo.StatuBarComponent = this.toolStripStatusLabel1;
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextoDireita = "CÓDIGO";
            this.txtCodigo.TextoEsquerda = "Código";
            this.txtCodigo.TextoStatus = "Código de Registro";
            this.txtCodigo.Click += new System.EventHandler(this.txtCodigo_Click);
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            this.txtCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigo_Validating);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // txtCliente
            // 
            this.txtCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCliente.EnableAll = true;
            this.txtCliente.Location = new System.Drawing.Point(0, 26);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(800, 26);
            this.txtCliente.StatuBarComponent = null;
            this.txtCliente.TabIndex = 1;
            this.txtCliente.TextoDireita = "CLIENTE";
            this.txtCliente.TextoEsquerda = "Cliente";
            this.txtCliente.TextoStatus = null;
            this.txtCliente.Click += new System.EventHandler(this.txtCliente_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.qTextBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // qTextBox1
            // 
            this.qTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.qTextBox1.EnableAll = false;
            this.qTextBox1.Location = new System.Drawing.Point(3, 19);
            this.qTextBox1.Name = "qTextBox1";
            this.qTextBox1.Size = new System.Drawing.Size(794, 26);
            this.qTextBox1.StatuBarComponent = null;
            this.qTextBox1.TabIndex = 0;
            this.qTextBox1.TextoDireita = "";
            this.qTextBox1.TextoEsquerda = "";
            this.qTextBox1.TextoStatus = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtCodigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox.QTextBox txtCodigo;
        private TextBox.QTextBox txtCliente;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private TextBox.QTextBox qTextBox1;
    }
}

