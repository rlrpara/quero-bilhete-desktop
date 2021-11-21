namespace QueroBilhete.Desktop.formularios.Empresa
{
    partial class frmEmpresa
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
            this.txtLogo = new QueroBilhete.Componentes.TextBox.txtBoxBtnLabel();
            this.txtCodigo = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtUid = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtRazaoSocial = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtCnpj = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtIE = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtIM = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtTelefone = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtCelular = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtEmail = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtSite = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtCep = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtEstado = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtCidade = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtRua = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtNumero = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtBairro = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
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
            this.grpCadastro.Controls.Add(this.txtNumero);
            this.grpCadastro.Controls.Add(this.txtRua);
            this.grpCadastro.Controls.Add(this.txtBairro);
            this.grpCadastro.Controls.Add(this.txtCidade);
            this.grpCadastro.Controls.Add(this.txtEstado);
            this.grpCadastro.Controls.Add(this.txtCep);
            this.grpCadastro.Controls.Add(this.txtLogo);
            this.grpCadastro.Controls.Add(this.txtSite);
            this.grpCadastro.Controls.Add(this.txtEmail);
            this.grpCadastro.Controls.Add(this.txtCelular);
            this.grpCadastro.Controls.Add(this.txtTelefone);
            this.grpCadastro.Controls.Add(this.txtIM);
            this.grpCadastro.Controls.Add(this.txtIE);
            this.grpCadastro.Controls.Add(this.txtCnpj);
            this.grpCadastro.Controls.Add(this.txtRazaoSocial);
            this.grpCadastro.Controls.Add(this.txtUid);
            this.grpCadastro.Controls.Add(this.txtCodigo);
            this.grpCadastro.Size = new System.Drawing.Size(959, 484);
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
            // txtLogo
            // 
            this.txtLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLogo.EnableAll = false;
            this.txtLogo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLogo.Location = new System.Drawing.Point(3, 257);
            this.txtLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.Size = new System.Drawing.Size(953, 24);
            this.txtLogo.StatuBarComponent = null;
            this.txtLogo.TabIndex = 10;
            this.txtLogo.TextoCentro = null;
            this.txtLogo.TextoDireita = "";
            this.txtLogo.TextoEsquerda = "Logo";
            this.txtLogo.TextoStatus = "Logo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCodigo.EnableAll = true;
            this.txtCodigo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigo.Location = new System.Drawing.Point(3, 17);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(953, 24);
            this.txtCodigo.StatuBarComponent = this.toolStripStatusLabel2;
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
            // txtUid
            // 
            this.txtUid.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUid.EnableAll = true;
            this.txtUid.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUid.Location = new System.Drawing.Point(3, 41);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(953, 24);
            this.txtUid.StatuBarComponent = this.toolStripStatusLabel2;
            this.txtUid.TabIndex = 1;
            this.txtUid.Texto = "";
            this.txtUid.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtUid.TextoEsquerda = "Uid";
            this.txtUid.TextoLargura = 200;
            this.txtUid.TextoMaiusculo = false;
            this.txtUid.TextoSenha = false;
            this.txtUid.TextoStatus = "Uid";
            this.txtUid.VisibleAll = true;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRazaoSocial.EnableAll = true;
            this.txtRazaoSocial.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRazaoSocial.Location = new System.Drawing.Point(3, 65);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(953, 24);
            this.txtRazaoSocial.StatuBarComponent = this.toolStripStatusLabel2;
            this.txtRazaoSocial.TabIndex = 2;
            this.txtRazaoSocial.Texto = "";
            this.txtRazaoSocial.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtRazaoSocial.TextoEsquerda = "Razão Social";
            this.txtRazaoSocial.TextoLargura = 500;
            this.txtRazaoSocial.TextoMaiusculo = true;
            this.txtRazaoSocial.TextoSenha = false;
            this.txtRazaoSocial.TextoStatus = "Razão Social";
            this.txtRazaoSocial.VisibleAll = true;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCnpj.EnableAll = true;
            this.txtCnpj.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCnpj.Location = new System.Drawing.Point(3, 89);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(953, 24);
            this.txtCnpj.StatuBarComponent = this.toolStripStatusLabel2;
            this.txtCnpj.TabIndex = 3;
            this.txtCnpj.Texto = "";
            this.txtCnpj.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtCnpj.TextoEsquerda = "Cnpj";
            this.txtCnpj.TextoLargura = 200;
            this.txtCnpj.TextoMaiusculo = false;
            this.txtCnpj.TextoSenha = false;
            this.txtCnpj.TextoStatus = "Cnpj";
            this.txtCnpj.VisibleAll = true;
            this.txtCnpj.Validating += new System.ComponentModel.CancelEventHandler(this.txtCnpj_Validating);
            // 
            // txtIE
            // 
            this.txtIE.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtIE.EnableAll = true;
            this.txtIE.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIE.Location = new System.Drawing.Point(3, 113);
            this.txtIE.Name = "txtIE";
            this.txtIE.Size = new System.Drawing.Size(953, 24);
            this.txtIE.TabIndex = 4;
            this.txtIE.Texto = "";
            this.txtIE.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtIE.TextoEsquerda = "Inscrição Estadual";
            this.txtIE.TextoLargura = 70;
            this.txtIE.TextoMaiusculo = false;
            this.txtIE.TextoSenha = false;
            this.txtIE.TextoStatus = "Inscrição Estadual";
            this.txtIE.VisibleAll = true;
            // 
            // txtIM
            // 
            this.txtIM.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtIM.EnableAll = true;
            this.txtIM.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIM.Location = new System.Drawing.Point(3, 137);
            this.txtIM.Name = "txtIM";
            this.txtIM.Size = new System.Drawing.Size(953, 24);
            this.txtIM.TabIndex = 5;
            this.txtIM.Texto = "";
            this.txtIM.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtIM.TextoEsquerda = "Inscrição Municipal";
            this.txtIM.TextoLargura = 70;
            this.txtIM.TextoMaiusculo = false;
            this.txtIM.TextoSenha = false;
            this.txtIM.TextoStatus = "Inscrição Municipal";
            this.txtIM.VisibleAll = true;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTelefone.EnableAll = true;
            this.txtTelefone.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelefone.Location = new System.Drawing.Point(3, 161);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(953, 24);
            this.txtTelefone.TabIndex = 6;
            this.txtTelefone.Texto = "";
            this.txtTelefone.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtTelefone.TextoEsquerda = "Telefone";
            this.txtTelefone.TextoLargura = 90;
            this.txtTelefone.TextoMaiusculo = false;
            this.txtTelefone.TextoSenha = false;
            this.txtTelefone.TextoStatus = "Telefone";
            this.txtTelefone.VisibleAll = true;
            // 
            // txtCelular
            // 
            this.txtCelular.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCelular.EnableAll = true;
            this.txtCelular.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCelular.Location = new System.Drawing.Point(3, 185);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(953, 24);
            this.txtCelular.TabIndex = 7;
            this.txtCelular.Texto = "";
            this.txtCelular.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtCelular.TextoEsquerda = "Celular";
            this.txtCelular.TextoLargura = 90;
            this.txtCelular.TextoMaiusculo = false;
            this.txtCelular.TextoSenha = false;
            this.txtCelular.TextoStatus = "Celular";
            this.txtCelular.VisibleAll = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEmail.EnableAll = true;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(3, 209);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(953, 24);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Texto = "";
            this.txtEmail.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtEmail.TextoEsquerda = "E-Mail";
            this.txtEmail.TextoLargura = 200;
            this.txtEmail.TextoMaiusculo = false;
            this.txtEmail.TextoSenha = false;
            this.txtEmail.TextoStatus = "E-Mail";
            this.txtEmail.VisibleAll = true;
            // 
            // txtSite
            // 
            this.txtSite.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSite.EnableAll = true;
            this.txtSite.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSite.Location = new System.Drawing.Point(3, 233);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(953, 24);
            this.txtSite.TabIndex = 9;
            this.txtSite.Texto = "";
            this.txtSite.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtSite.TextoEsquerda = "Site";
            this.txtSite.TextoLargura = 300;
            this.txtSite.TextoMaiusculo = false;
            this.txtSite.TextoSenha = false;
            this.txtSite.TextoStatus = "Site";
            this.txtSite.VisibleAll = true;
            // 
            // txtCep
            // 
            this.txtCep.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCep.EnableAll = true;
            this.txtCep.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCep.Location = new System.Drawing.Point(3, 281);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(953, 24);
            this.txtCep.TabIndex = 11;
            this.txtCep.Texto = "";
            this.txtCep.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtCep.TextoEsquerda = "CEP";
            this.txtCep.TextoLargura = 90;
            this.txtCep.TextoMaiusculo = false;
            this.txtCep.TextoSenha = false;
            this.txtCep.TextoStatus = "CEP";
            this.txtCep.VisibleAll = true;
            this.txtCep.Validated += new System.EventHandler(this.txtCep_Validated);
            // 
            // txtEstado
            // 
            this.txtEstado.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEstado.EnableAll = true;
            this.txtEstado.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEstado.Location = new System.Drawing.Point(3, 305);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(953, 24);
            this.txtEstado.TabIndex = 12;
            this.txtEstado.Texto = "";
            this.txtEstado.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Centro;
            this.txtEstado.TextoEsquerda = "Estado";
            this.txtEstado.TextoLargura = 40;
            this.txtEstado.TextoMaiusculo = true;
            this.txtEstado.TextoSenha = false;
            this.txtEstado.TextoStatus = "Estado";
            this.txtEstado.VisibleAll = true;
            // 
            // txtCidade
            // 
            this.txtCidade.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCidade.EnableAll = true;
            this.txtCidade.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCidade.Location = new System.Drawing.Point(3, 329);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(953, 24);
            this.txtCidade.TabIndex = 13;
            this.txtCidade.Texto = "";
            this.txtCidade.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtCidade.TextoEsquerda = "Cidade";
            this.txtCidade.TextoLargura = 90;
            this.txtCidade.TextoMaiusculo = true;
            this.txtCidade.TextoSenha = false;
            this.txtCidade.TextoStatus = "Cidade";
            this.txtCidade.VisibleAll = true;
            // 
            // txtRua
            // 
            this.txtRua.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRua.EnableAll = true;
            this.txtRua.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRua.Location = new System.Drawing.Point(3, 377);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(953, 24);
            this.txtRua.TabIndex = 15;
            this.txtRua.Texto = "";
            this.txtRua.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtRua.TextoEsquerda = "Rua";
            this.txtRua.TextoLargura = 500;
            this.txtRua.TextoMaiusculo = true;
            this.txtRua.TextoSenha = false;
            this.txtRua.TextoStatus = "Rua";
            this.txtRua.VisibleAll = true;
            // 
            // txtNumero
            // 
            this.txtNumero.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNumero.EnableAll = true;
            this.txtNumero.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumero.Location = new System.Drawing.Point(3, 401);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(953, 24);
            this.txtNumero.TabIndex = 16;
            this.txtNumero.Texto = "";
            this.txtNumero.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtNumero.TextoEsquerda = "Número";
            this.txtNumero.TextoLargura = 70;
            this.txtNumero.TextoMaiusculo = false;
            this.txtNumero.TextoSenha = false;
            this.txtNumero.TextoStatus = "Número";
            this.txtNumero.VisibleAll = true;
            // 
            // txtBairro
            // 
            this.txtBairro.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBairro.EnableAll = true;
            this.txtBairro.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBairro.Location = new System.Drawing.Point(3, 353);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(953, 24);
            this.txtBairro.TabIndex = 14;
            this.txtBairro.Texto = "";
            this.txtBairro.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtBairro.TextoEsquerda = "Bairro";
            this.txtBairro.TextoLargura = 90;
            this.txtBairro.TextoMaiusculo = true;
            this.txtBairro.TextoSenha = false;
            this.txtBairro.TextoStatus = "Bairro";
            this.txtBairro.VisibleAll = true;
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.chkStatus);
            this.panelStatus.Controls.Add(this.label14);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatus.Location = new System.Drawing.Point(3, 425);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(953, 25);
            this.panelStatus.TabIndex = 17;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(149, 5);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(51, 17);
            this.chkStatus.TabIndex = 12;
            this.chkStatus.Text = "Ativo";
            this.chkStatus.UseVisualStyleBackColor = true;
            this.chkStatus.Click += new System.EventHandler(this.chkStatus_Enter);
            this.chkStatus.Enter += new System.EventHandler(this.chkStatus_Enter);
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
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 552);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmEmpresa";
            this.Text = "frmEmpresa";
            this.grpCadastro.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Componentes.TextBox.txtBoxBtnLabel txtLogo;
        private Componentes.TextBox.txtBoxLabel txtUid;
        private Componentes.TextBox.txtBoxLabel txtCodigo;
        private Componentes.TextBox.txtBoxLabel txtRazaoSocial;
        private Componentes.TextBox.txtBoxLabel txtIM;
        private Componentes.TextBox.txtBoxLabel txtIE;
        private Componentes.TextBox.txtBoxLabel txtCnpj;
        private Componentes.TextBox.txtBoxLabel txtTelefone;
        private Componentes.TextBox.txtBoxLabel txtCelular;
        private Componentes.TextBox.txtBoxLabel txtEmail;
        private Componentes.TextBox.txtBoxLabel txtSite;
        private Componentes.TextBox.txtBoxLabel txtCidade;
        private Componentes.TextBox.txtBoxLabel txtEstado;
        private Componentes.TextBox.txtBoxLabel txtCep;
        private Componentes.TextBox.txtBoxLabel txtRua;
        private Componentes.TextBox.txtBoxLabel txtNumero;
        private Componentes.TextBox.txtBoxLabel txtBairro;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.Label label14;
    }
}