﻿namespace QueroBilhete.Desktop.formularios.Trajeto
{
    partial class frmTrajeto
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
            this.panelStatus = new System.Windows.Forms.Panel();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDestino = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtOrigem = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtEmbarcacao = new QueroBilhete.Componentes.TextBox.txtBoxBtnLabel();
            this.txtCodigo = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.panelDados.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDados
            // 
            this.panelDados.Size = new System.Drawing.Size(800, 64);
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
            this.panelDados.Controls.Add(this.txtDestino);
            this.panelDados.Controls.Add(this.txtOrigem);
            this.panelDados.Controls.Add(this.txtEmbarcacao);
            this.panelDados.Controls.Add(this.txtCodigo);
            this.panelDados.Location = new System.Drawing.Point(0, 110);
            this.panelDados.Size = new System.Drawing.Size(800, 318);
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.chkStatus);
            this.panelStatus.Controls.Add(this.label14);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatus.Location = new System.Drawing.Point(0, 96);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(800, 25);
            this.panelStatus.TabIndex = 23;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(149, 5);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(52, 17);
            this.chkStatus.TabIndex = 12;
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
            // txtDestino
            // 
            this.txtDestino.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDestino.EnableAll = true;
            this.txtDestino.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDestino.Location = new System.Drawing.Point(0, 72);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(800, 24);
            this.txtDestino.TabIndex = 22;
            this.txtDestino.Texto = "";
            this.txtDestino.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtDestino.TextoEsquerda = "Destino";
            this.txtDestino.TextoLargura = 500;
            this.txtDestino.TextoMaiusculo = true;
            this.txtDestino.TextoSenha = false;
            this.txtDestino.TextoStatus = "Destino";
            this.txtDestino.VisibleAll = true;
            // 
            // txtOrigem
            // 
            this.txtOrigem.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtOrigem.EnableAll = true;
            this.txtOrigem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOrigem.Location = new System.Drawing.Point(0, 48);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(800, 24);
            this.txtOrigem.TabIndex = 21;
            this.txtOrigem.Texto = "";
            this.txtOrigem.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtOrigem.TextoEsquerda = "Origem";
            this.txtOrigem.TextoLargura = 500;
            this.txtOrigem.TextoMaiusculo = true;
            this.txtOrigem.TextoSenha = false;
            this.txtOrigem.TextoStatus = "Origem";
            this.txtOrigem.VisibleAll = true;
            // 
            // txtEmbarcacao
            // 
            this.txtEmbarcacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEmbarcacao.EnableAll = true;
            this.txtEmbarcacao.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmbarcacao.Location = new System.Drawing.Point(0, 24);
            this.txtEmbarcacao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmbarcacao.Name = "txtEmbarcacao";
            this.txtEmbarcacao.Size = new System.Drawing.Size(800, 24);
            this.txtEmbarcacao.StatuBarComponent = null;
            this.txtEmbarcacao.TabIndex = 20;
            this.txtEmbarcacao.TextoCentro = null;
            this.txtEmbarcacao.TextoDireita = "";
            this.txtEmbarcacao.TextoEsquerda = "Embarcação";
            this.txtEmbarcacao.TextoStatus = "Logo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCodigo.EnableAll = true;
            this.txtCodigo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigo.Location = new System.Drawing.Point(0, 0);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(800, 24);
            this.txtCodigo.TabIndex = 19;
            this.txtCodigo.Texto = "";
            this.txtCodigo.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Centro;
            this.txtCodigo.TextoEsquerda = "Código";
            this.txtCodigo.TextoLargura = 90;
            this.txtCodigo.TextoMaiusculo = false;
            this.txtCodigo.TextoSenha = false;
            this.txtCodigo.TextoStatus = "Código";
            this.txtCodigo.VisibleAll = true;
            // 
            // frmTrajeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmTrajeto";
            this.Text = "frmTrajeto";
            this.panelDados.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.Label label14;
        private Componentes.TextBox.txtBoxLabel txtDestino;
        private Componentes.TextBox.txtBoxLabel txtOrigem;
        private Componentes.TextBox.txtBoxBtnLabel txtEmbarcacao;
        private Componentes.TextBox.txtBoxLabel txtCodigo;
    }
}