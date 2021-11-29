﻿namespace QueroBilhete.Desktop.formularios.Embarcacao
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
            this.txtEmbarcacao = new QueroBilhete.Componentes.TextBox.txtBoxBtnLabel();
            this.txtCodigo = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtLetra = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtInicio = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtFim = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtEixoX = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtEixoY = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtTotalColunas = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtAlinhamento = new QueroBilhete.Componentes.TextBox.txtBoxBtnLabel();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.grpCadastro.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCadastro
            // 
            this.grpCadastro.Controls.Add(this.panelStatus);
            this.grpCadastro.Controls.Add(this.txtAlinhamento);
            this.grpCadastro.Controls.Add(this.txtTotalColunas);
            this.grpCadastro.Controls.Add(this.txtEixoY);
            this.grpCadastro.Controls.Add(this.txtEixoX);
            this.grpCadastro.Controls.Add(this.txtFim);
            this.grpCadastro.Controls.Add(this.txtInicio);
            this.grpCadastro.Controls.Add(this.txtLetra);
            this.grpCadastro.Controls.Add(this.txtEmbarcacao);
            this.grpCadastro.Controls.Add(this.txtCodigo);
            this.grpCadastro.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpCadastro.Size = new System.Drawing.Size(813, 485);
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
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(9);
            this.panel1.Size = new System.Drawing.Size(813, 485);
            this.panel1.TabIndex = 0;
            // 
            // txtEmbarcacao
            // 
            this.txtEmbarcacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEmbarcacao.EnableAll = true;
            this.txtEmbarcacao.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmbarcacao.Location = new System.Drawing.Point(3, 41);
            this.txtEmbarcacao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmbarcacao.Name = "txtEmbarcacao";
            this.txtEmbarcacao.Size = new System.Drawing.Size(807, 24);
            this.txtEmbarcacao.StatuBarComponent = null;
            this.txtEmbarcacao.TabIndex = 1;
            this.txtEmbarcacao.TextoCentro = null;
            this.txtEmbarcacao.TextoDireita = "";
            this.txtEmbarcacao.TextoEsquerda = "Embarcação";
            this.txtEmbarcacao.TextoStatus = null;
            this.txtEmbarcacao.ButtonClick += new System.EventHandler(this.txtEmbarcacao_ButtonClick);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCodigo.EnableAll = true;
            this.txtCodigo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigo.Location = new System.Drawing.Point(3, 17);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(807, 24);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Texto = "";
            this.txtCodigo.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Centro;
            this.txtCodigo.TextoEsquerda = "Código";
            this.txtCodigo.TextoLargura = 90;
            this.txtCodigo.TextoMaiusculo = false;
            this.txtCodigo.TextoSenha = false;
            this.txtCodigo.TextoStatus = "Código";
            this.txtCodigo.VisibleAll = true;
            // 
            // txtLetra
            // 
            this.txtLetra.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLetra.EnableAll = true;
            this.txtLetra.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLetra.Location = new System.Drawing.Point(3, 65);
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(807, 24);
            this.txtLetra.TabIndex = 2;
            this.txtLetra.Texto = "";
            this.txtLetra.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Centro;
            this.txtLetra.TextoEsquerda = "Letra";
            this.txtLetra.TextoLargura = 40;
            this.txtLetra.TextoMaiusculo = true;
            this.txtLetra.TextoSenha = false;
            this.txtLetra.TextoStatus = "Letra";
            this.txtLetra.VisibleAll = true;
            // 
            // txtInicio
            // 
            this.txtInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtInicio.EnableAll = true;
            this.txtInicio.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInicio.Location = new System.Drawing.Point(3, 89);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(807, 24);
            this.txtInicio.TabIndex = 3;
            this.txtInicio.Texto = "";
            this.txtInicio.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Centro;
            this.txtInicio.TextoEsquerda = "Início";
            this.txtInicio.TextoLargura = 60;
            this.txtInicio.TextoMaiusculo = true;
            this.txtInicio.TextoSenha = false;
            this.txtInicio.TextoStatus = "Início";
            this.txtInicio.VisibleAll = true;
            // 
            // txtFim
            // 
            this.txtFim.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFim.EnableAll = true;
            this.txtFim.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFim.Location = new System.Drawing.Point(3, 113);
            this.txtFim.Name = "txtFim";
            this.txtFim.Size = new System.Drawing.Size(807, 24);
            this.txtFim.TabIndex = 4;
            this.txtFim.Texto = "";
            this.txtFim.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Centro;
            this.txtFim.TextoEsquerda = "Fim";
            this.txtFim.TextoLargura = 60;
            this.txtFim.TextoMaiusculo = true;
            this.txtFim.TextoSenha = false;
            this.txtFim.TextoStatus = "Fim";
            this.txtFim.VisibleAll = true;
            // 
            // txtEixoX
            // 
            this.txtEixoX.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEixoX.EnableAll = true;
            this.txtEixoX.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEixoX.Location = new System.Drawing.Point(3, 137);
            this.txtEixoX.Name = "txtEixoX";
            this.txtEixoX.Size = new System.Drawing.Size(807, 24);
            this.txtEixoX.TabIndex = 5;
            this.txtEixoX.Texto = "";
            this.txtEixoX.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Centro;
            this.txtEixoX.TextoEsquerda = "Eixo X";
            this.txtEixoX.TextoLargura = 60;
            this.txtEixoX.TextoMaiusculo = true;
            this.txtEixoX.TextoSenha = false;
            this.txtEixoX.TextoStatus = "Eixo X";
            this.txtEixoX.VisibleAll = true;
            // 
            // txtEixoY
            // 
            this.txtEixoY.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEixoY.EnableAll = true;
            this.txtEixoY.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEixoY.Location = new System.Drawing.Point(3, 161);
            this.txtEixoY.Name = "txtEixoY";
            this.txtEixoY.Size = new System.Drawing.Size(807, 24);
            this.txtEixoY.TabIndex = 6;
            this.txtEixoY.Texto = "";
            this.txtEixoY.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Centro;
            this.txtEixoY.TextoEsquerda = "Eixo Y";
            this.txtEixoY.TextoLargura = 60;
            this.txtEixoY.TextoMaiusculo = true;
            this.txtEixoY.TextoSenha = false;
            this.txtEixoY.TextoStatus = "Eixo Y";
            this.txtEixoY.VisibleAll = true;
            // 
            // txtTotalColunas
            // 
            this.txtTotalColunas.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTotalColunas.EnableAll = true;
            this.txtTotalColunas.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalColunas.Location = new System.Drawing.Point(3, 185);
            this.txtTotalColunas.Name = "txtTotalColunas";
            this.txtTotalColunas.Size = new System.Drawing.Size(807, 24);
            this.txtTotalColunas.TabIndex = 7;
            this.txtTotalColunas.Texto = "";
            this.txtTotalColunas.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Centro;
            this.txtTotalColunas.TextoEsquerda = "Total Colunas";
            this.txtTotalColunas.TextoLargura = 90;
            this.txtTotalColunas.TextoMaiusculo = true;
            this.txtTotalColunas.TextoSenha = false;
            this.txtTotalColunas.TextoStatus = "Total Colunas";
            this.txtTotalColunas.VisibleAll = true;
            // 
            // txtAlinhamento
            // 
            this.txtAlinhamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAlinhamento.EnableAll = true;
            this.txtAlinhamento.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAlinhamento.Location = new System.Drawing.Point(3, 209);
            this.txtAlinhamento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAlinhamento.Name = "txtAlinhamento";
            this.txtAlinhamento.Size = new System.Drawing.Size(807, 24);
            this.txtAlinhamento.StatuBarComponent = null;
            this.txtAlinhamento.TabIndex = 8;
            this.txtAlinhamento.TextoCentro = null;
            this.txtAlinhamento.TextoDireita = "";
            this.txtAlinhamento.TextoEsquerda = "Alinhamento";
            this.txtAlinhamento.TextoStatus = null;
            this.txtAlinhamento.ButtonClick += new System.EventHandler(this.txtAlinhamento_ButtonClick);
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.chkStatus);
            this.panelStatus.Controls.Add(this.label14);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatus.Location = new System.Drawing.Point(3, 233);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(807, 25);
            this.panelStatus.TabIndex = 19;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(149, 5);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(51, 17);
            this.chkStatus.TabIndex = 3;
            this.chkStatus.Text = "Ativo";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(94, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Status";
            // 
            // frmRegistroPoltrona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 553);
            this.Controls.Add(this.panel1);
            this.Name = "frmRegistroPoltrona";
            this.Text = "Registro de Poltronas";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.grpCadastro, 0);
            this.grpCadastro.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Componentes.TextBox.txtBoxBtnLabel txtEmbarcacao;
        private Componentes.TextBox.txtBoxLabel txtLetra;
        private Componentes.TextBox.txtBoxLabel txtCodigo;
        private Componentes.TextBox.txtBoxLabel txtFim;
        private Componentes.TextBox.txtBoxLabel txtInicio;
        private Componentes.TextBox.txtBoxLabel txtEixoY;
        private Componentes.TextBox.txtBoxLabel txtEixoX;
        private Componentes.TextBox.txtBoxLabel txtTotalColunas;
        private Componentes.TextBox.txtBoxBtnLabel txtAlinhamento;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.Label label14;
    }
}