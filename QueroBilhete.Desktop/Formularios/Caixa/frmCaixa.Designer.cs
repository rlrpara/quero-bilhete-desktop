namespace QueroBilhete.Desktop.Formularios.Caixa
{
    partial class frmCaixa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.txtUsuarioEncerramento = new QueroBilhete.Componentes.TextBox.txtBoxBtnLabel();
            this.toolStatusDescricao = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.txtDataEncerramento = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtValorAbertura = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtUsuarioAbertura = new QueroBilhete.Componentes.TextBox.txtBoxBtnLabel();
            this.txtDataAbertura = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.stDescricao = new System.Windows.Forms.StatusStrip();
            this.txtCodigo = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.grpDados.SuspendLayout();
            this.stDescricao.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.txtUsuarioEncerramento);
            this.grpDados.Controls.Add(this.button1);
            this.grpDados.Controls.Add(this.btnAbrir);
            this.grpDados.Controls.Add(this.txtDataEncerramento);
            this.grpDados.Controls.Add(this.txtValorAbertura);
            this.grpDados.Controls.Add(this.txtUsuarioAbertura);
            this.grpDados.Controls.Add(this.txtDataAbertura);
            this.grpDados.Controls.Add(this.stDescricao);
            this.grpDados.Controls.Add(this.txtCodigo);
            this.grpDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDados.Location = new System.Drawing.Point(0, 0);
            this.grpDados.Name = "grpDados";
            this.grpDados.Padding = new System.Windows.Forms.Padding(5);
            this.grpDados.Size = new System.Drawing.Size(525, 280);
            this.grpDados.TabIndex = 0;
            this.grpDados.TabStop = false;
            // 
            // txtUsuarioEncerramento
            // 
            this.txtUsuarioEncerramento.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUsuarioEncerramento.EnableAll = false;
            this.txtUsuarioEncerramento.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuarioEncerramento.Location = new System.Drawing.Point(5, 141);
            this.txtUsuarioEncerramento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUsuarioEncerramento.Name = "txtUsuarioEncerramento";
            this.txtUsuarioEncerramento.Size = new System.Drawing.Size(515, 24);
            this.txtUsuarioEncerramento.StatuBarComponent = this.toolStatusDescricao;
            this.txtUsuarioEncerramento.TabIndex = 17;
            this.txtUsuarioEncerramento.TextoCentro = null;
            this.txtUsuarioEncerramento.TextoDireita = "";
            this.txtUsuarioEncerramento.TextoEsquerda = "Cód. Usuario Encerram.";
            this.txtUsuarioEncerramento.TextoStatus = "Cód. Usuario Encerramento";
            // 
            // toolStatusDescricao
            // 
            this.toolStatusDescricao.Name = "toolStatusDescricao";
            this.toolStatusDescricao.Size = new System.Drawing.Size(0, 17);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(67, 206);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(111, 23);
            this.btnAbrir.TabIndex = 14;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            // 
            // txtDataEncerramento
            // 
            this.txtDataEncerramento.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDataEncerramento.EnableAll = false;
            this.txtDataEncerramento.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDataEncerramento.Location = new System.Drawing.Point(5, 117);
            this.txtDataEncerramento.Name = "txtDataEncerramento";
            this.txtDataEncerramento.Size = new System.Drawing.Size(515, 24);
            this.txtDataEncerramento.StatuBarComponent = this.toolStatusDescricao;
            this.txtDataEncerramento.TabIndex = 12;
            this.txtDataEncerramento.Texto = "";
            this.txtDataEncerramento.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Centro;
            this.txtDataEncerramento.TextoEsquerda = "Data/Hora Encerramento";
            this.txtDataEncerramento.TextoLargura = 90;
            this.txtDataEncerramento.TextoMaiusculo = true;
            this.txtDataEncerramento.TextoSenha = false;
            this.txtDataEncerramento.TextoStatus = "Data/Hora Encerramento";
            this.txtDataEncerramento.VisibleAll = true;
            // 
            // txtValorAbertura
            // 
            this.txtValorAbertura.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtValorAbertura.EnableAll = true;
            this.txtValorAbertura.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorAbertura.Location = new System.Drawing.Point(5, 93);
            this.txtValorAbertura.Name = "txtValorAbertura";
            this.txtValorAbertura.Size = new System.Drawing.Size(515, 24);
            this.txtValorAbertura.StatuBarComponent = this.toolStatusDescricao;
            this.txtValorAbertura.TabIndex = 11;
            this.txtValorAbertura.Texto = "";
            this.txtValorAbertura.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Direita;
            this.txtValorAbertura.TextoEsquerda = "Valor Abertura";
            this.txtValorAbertura.TextoLargura = 90;
            this.txtValorAbertura.TextoMaiusculo = true;
            this.txtValorAbertura.TextoSenha = false;
            this.txtValorAbertura.TextoStatus = "Valor Abertura";
            this.txtValorAbertura.VisibleAll = true;
            // 
            // txtUsuarioAbertura
            // 
            this.txtUsuarioAbertura.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUsuarioAbertura.EnableAll = false;
            this.txtUsuarioAbertura.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuarioAbertura.Location = new System.Drawing.Point(5, 69);
            this.txtUsuarioAbertura.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUsuarioAbertura.Name = "txtUsuarioAbertura";
            this.txtUsuarioAbertura.Size = new System.Drawing.Size(515, 24);
            this.txtUsuarioAbertura.StatuBarComponent = this.toolStatusDescricao;
            this.txtUsuarioAbertura.TabIndex = 16;
            this.txtUsuarioAbertura.TextoCentro = null;
            this.txtUsuarioAbertura.TextoDireita = "";
            this.txtUsuarioAbertura.TextoEsquerda = "Cód. Usuario Abertura";
            this.txtUsuarioAbertura.TextoStatus = null;
            // 
            // txtDataAbertura
            // 
            this.txtDataAbertura.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDataAbertura.EnableAll = false;
            this.txtDataAbertura.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDataAbertura.Location = new System.Drawing.Point(5, 45);
            this.txtDataAbertura.Name = "txtDataAbertura";
            this.txtDataAbertura.Size = new System.Drawing.Size(515, 24);
            this.txtDataAbertura.StatuBarComponent = this.toolStatusDescricao;
            this.txtDataAbertura.TabIndex = 9;
            this.txtDataAbertura.Texto = "";
            this.txtDataAbertura.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Centro;
            this.txtDataAbertura.TextoEsquerda = "Data/Hora Abertura";
            this.txtDataAbertura.TextoLargura = 140;
            this.txtDataAbertura.TextoMaiusculo = true;
            this.txtDataAbertura.TextoSenha = false;
            this.txtDataAbertura.TextoStatus = "Data/Hora Abertura";
            this.txtDataAbertura.VisibleAll = true;
            // 
            // stDescricao
            // 
            this.stDescricao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStatusDescricao});
            this.stDescricao.Location = new System.Drawing.Point(5, 253);
            this.stDescricao.Name = "stDescricao";
            this.stDescricao.Size = new System.Drawing.Size(515, 22);
            this.stDescricao.TabIndex = 8;
            this.stDescricao.Text = "statusStrip1";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCodigo.EnableAll = false;
            this.txtCodigo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigo.Location = new System.Drawing.Point(5, 21);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(515, 24);
            this.txtCodigo.StatuBarComponent = this.toolStatusDescricao;
            this.txtCodigo.TabIndex = 7;
            this.txtCodigo.Texto = "";
            this.txtCodigo.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Centro;
            this.txtCodigo.TextoEsquerda = "Codigo";
            this.txtCodigo.TextoLargura = 90;
            this.txtCodigo.TextoMaiusculo = true;
            this.txtCodigo.TextoSenha = false;
            this.txtCodigo.TextoStatus = "Codigo";
            this.txtCodigo.VisibleAll = true;
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 280);
            this.Controls.Add(this.grpDados);
            this.Name = "frmCaixa";
            this.Text = "CAIXA";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCaixa_KeyDown);
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            this.stDescricao.ResumeLayout(false);
            this.stDescricao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDados;
        private Componentes.TextBox.txtBoxLabel txtCodigo;
        private System.Windows.Forms.StatusStrip stDescricao;
        private System.Windows.Forms.ToolStripStatusLabel toolStatusDescricao;
        private Componentes.TextBox.txtBoxLabel txtDataEncerramento;
        private Componentes.TextBox.txtBoxLabel txtValorAbertura;
        private Componentes.TextBox.txtBoxLabel txtDataAbertura;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAbrir;
        private Componentes.TextBox.txtBoxBtnLabel txtUsuarioAbertura;
        private Componentes.TextBox.txtBoxBtnLabel txtUsuarioEncerramento;
    }
}