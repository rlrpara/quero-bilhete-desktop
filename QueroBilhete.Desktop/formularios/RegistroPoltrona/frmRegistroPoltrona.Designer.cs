namespace QueroBilhete.Desktop.formularios.Embarcacao
{
    partial class frmRegistroPoltrona
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAlinhamento = new QueroBilhete.Componentes.TextBox.txtBoxBtnLabel();
            this.txtTotalColunas = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtEixoY = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtEixoX = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtFim = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtInicio = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtLetra = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtEmbarcacao = new QueroBilhete.Componentes.TextBox.txtBoxBtnLabel();
            this.txtCodigo = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.panelDados.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDados
            // 
            this.panelDados.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelDados.Size = new System.Drawing.Size(813, 131);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.FlatAppearance.BorderSize = 0;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // panelDados
            // 
            this.panelDados.Controls.Add(this.panelStatus);
            this.panelDados.Controls.Add(this.txtAlinhamento);
            this.panelDados.Controls.Add(this.txtTotalColunas);
            this.panelDados.Controls.Add(this.txtEixoY);
            this.panelDados.Controls.Add(this.txtEixoX);
            this.panelDados.Controls.Add(this.txtFim);
            this.panelDados.Controls.Add(this.txtInicio);
            this.panelDados.Controls.Add(this.txtLetra);
            this.panelDados.Controls.Add(this.txtEmbarcacao);
            this.panelDados.Controls.Add(this.txtCodigo);
            this.panelDados.Location = new System.Drawing.Point(0, 46);
            this.panelDados.Size = new System.Drawing.Size(813, 595);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(9);
            this.panel1.Size = new System.Drawing.Size(813, 595);
            this.panel1.TabIndex = 0;
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.chkStatus);
            this.panelStatus.Controls.Add(this.label14);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatus.Location = new System.Drawing.Point(0, 216);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(813, 25);
            this.panelStatus.TabIndex = 29;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(149, 5);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(52, 17);
            this.chkStatus.TabIndex = 3;
            this.chkStatus.Text = "Ativo";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(94, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Status";
            // 
            // txtAlinhamento
            // 
            this.txtAlinhamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAlinhamento.EnableAll = true;
            this.txtAlinhamento.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAlinhamento.Location = new System.Drawing.Point(0, 192);
            this.txtAlinhamento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAlinhamento.Name = "txtAlinhamento";
            this.txtAlinhamento.Size = new System.Drawing.Size(813, 24);
            this.txtAlinhamento.StatuBarComponent = null;
            this.txtAlinhamento.TabIndex = 28;
            this.txtAlinhamento.TextoCentro = null;
            this.txtAlinhamento.TextoDireita = "";
            this.txtAlinhamento.TextoEsquerda = "Alinhamento";
            this.txtAlinhamento.TextoStatus = null;
            // 
            // txtTotalColunas
            // 
            this.txtTotalColunas.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTotalColunas.EnableAll = true;
            this.txtTotalColunas.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalColunas.Location = new System.Drawing.Point(0, 168);
            this.txtTotalColunas.Name = "txtTotalColunas";
            this.txtTotalColunas.Size = new System.Drawing.Size(813, 24);
            this.txtTotalColunas.TabIndex = 27;
            this.txtTotalColunas.Texto = "";
            this.txtTotalColunas.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Centro;
            this.txtTotalColunas.TextoEsquerda = "Total Colunas";
            this.txtTotalColunas.TextoLargura = 90;
            this.txtTotalColunas.TextoMaiusculo = true;
            this.txtTotalColunas.TextoSenha = false;
            this.txtTotalColunas.TextoStatus = "Total Colunas";
            this.txtTotalColunas.VisibleAll = true;
            // 
            // txtEixoY
            // 
            this.txtEixoY.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEixoY.EnableAll = true;
            this.txtEixoY.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEixoY.Location = new System.Drawing.Point(0, 144);
            this.txtEixoY.Name = "txtEixoY";
            this.txtEixoY.Size = new System.Drawing.Size(813, 24);
            this.txtEixoY.TabIndex = 26;
            this.txtEixoY.Texto = "";
            this.txtEixoY.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Centro;
            this.txtEixoY.TextoEsquerda = "Eixo Y";
            this.txtEixoY.TextoLargura = 60;
            this.txtEixoY.TextoMaiusculo = true;
            this.txtEixoY.TextoSenha = false;
            this.txtEixoY.TextoStatus = "Eixo Y";
            this.txtEixoY.VisibleAll = true;
            // 
            // txtEixoX
            // 
            this.txtEixoX.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEixoX.EnableAll = true;
            this.txtEixoX.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEixoX.Location = new System.Drawing.Point(0, 120);
            this.txtEixoX.Name = "txtEixoX";
            this.txtEixoX.Size = new System.Drawing.Size(813, 24);
            this.txtEixoX.TabIndex = 25;
            this.txtEixoX.Texto = "";
            this.txtEixoX.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Centro;
            this.txtEixoX.TextoEsquerda = "Eixo X";
            this.txtEixoX.TextoLargura = 60;
            this.txtEixoX.TextoMaiusculo = true;
            this.txtEixoX.TextoSenha = false;
            this.txtEixoX.TextoStatus = "Eixo X";
            this.txtEixoX.VisibleAll = true;
            // 
            // txtFim
            // 
            this.txtFim.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFim.EnableAll = true;
            this.txtFim.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFim.Location = new System.Drawing.Point(0, 96);
            this.txtFim.Name = "txtFim";
            this.txtFim.Size = new System.Drawing.Size(813, 24);
            this.txtFim.TabIndex = 24;
            this.txtFim.Texto = "";
            this.txtFim.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Centro;
            this.txtFim.TextoEsquerda = "Fim";
            this.txtFim.TextoLargura = 60;
            this.txtFim.TextoMaiusculo = true;
            this.txtFim.TextoSenha = false;
            this.txtFim.TextoStatus = "Fim";
            this.txtFim.VisibleAll = true;
            // 
            // txtInicio
            // 
            this.txtInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtInicio.EnableAll = true;
            this.txtInicio.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInicio.Location = new System.Drawing.Point(0, 72);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(813, 24);
            this.txtInicio.TabIndex = 23;
            this.txtInicio.Texto = "";
            this.txtInicio.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Centro;
            this.txtInicio.TextoEsquerda = "Início";
            this.txtInicio.TextoLargura = 60;
            this.txtInicio.TextoMaiusculo = true;
            this.txtInicio.TextoSenha = false;
            this.txtInicio.TextoStatus = "Início";
            this.txtInicio.VisibleAll = true;
            // 
            // txtLetra
            // 
            this.txtLetra.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLetra.EnableAll = true;
            this.txtLetra.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLetra.Location = new System.Drawing.Point(0, 48);
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(813, 24);
            this.txtLetra.TabIndex = 22;
            this.txtLetra.Texto = "";
            this.txtLetra.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Centro;
            this.txtLetra.TextoEsquerda = "Letra";
            this.txtLetra.TextoLargura = 40;
            this.txtLetra.TextoMaiusculo = true;
            this.txtLetra.TextoSenha = false;
            this.txtLetra.TextoStatus = "Letra";
            this.txtLetra.VisibleAll = true;
            // 
            // txtEmbarcacao
            // 
            this.txtEmbarcacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEmbarcacao.EnableAll = true;
            this.txtEmbarcacao.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmbarcacao.Location = new System.Drawing.Point(0, 24);
            this.txtEmbarcacao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmbarcacao.Name = "txtEmbarcacao";
            this.txtEmbarcacao.Size = new System.Drawing.Size(813, 24);
            this.txtEmbarcacao.StatuBarComponent = null;
            this.txtEmbarcacao.TabIndex = 21;
            this.txtEmbarcacao.TextoCentro = null;
            this.txtEmbarcacao.TextoDireita = "";
            this.txtEmbarcacao.TextoEsquerda = "Embarcação";
            this.txtEmbarcacao.TextoStatus = null;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCodigo.EnableAll = true;
            this.txtCodigo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigo.Location = new System.Drawing.Point(0, 0);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(813, 24);
            this.txtCodigo.TabIndex = 20;
            this.txtCodigo.Texto = "";
            this.txtCodigo.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Centro;
            this.txtCodigo.TextoEsquerda = "Código";
            this.txtCodigo.TextoLargura = 90;
            this.txtCodigo.TextoMaiusculo = false;
            this.txtCodigo.TextoSenha = false;
            this.txtCodigo.TextoStatus = "Código";
            this.txtCodigo.VisibleAll = true;
            // 
            // frmRegistroPoltrona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 663);
            this.Controls.Add(this.panel1);
            this.Name = "frmRegistroPoltrona";
            this.Text = "Registro de Poltronas";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panelDados, 0);
            this.Controls.SetChildIndex(this.panelDados, 0);
            this.panelDados.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.Label label14;
        private Componentes.TextBox.txtBoxBtnLabel txtAlinhamento;
        private Componentes.TextBox.txtBoxLabel txtTotalColunas;
        private Componentes.TextBox.txtBoxLabel txtEixoY;
        private Componentes.TextBox.txtBoxLabel txtEixoX;
        private Componentes.TextBox.txtBoxLabel txtFim;
        private Componentes.TextBox.txtBoxLabel txtInicio;
        private Componentes.TextBox.txtBoxLabel txtLetra;
        private Componentes.TextBox.txtBoxBtnLabel txtEmbarcacao;
        private Componentes.TextBox.txtBoxLabel txtCodigo;
    }
}