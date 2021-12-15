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
            this.panelStatus = new System.Windows.Forms.Panel();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNumero = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtRua = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtBairro = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtCidade = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtEstado = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtCep = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtLogo = new QueroBilhete.Componentes.TextBox.txtBoxBtnLabel();
            this.txtSite = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtEmail = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtCelular = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtTelefone = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtRegime = new QueroBilhete.Componentes.TextBox.txtBoxBtnLabel();
            this.txtIM = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtIE = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtCnpj = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtRazaoSocial = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtUid = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtCodigo = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtAmbiente = new QueroBilhete.Componentes.TextBox.txtBoxBtnLabel();
            this.panelDados.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.SuspendLayout();
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
            this.panelDados.Controls.Add(this.txtAmbiente);
            this.panelDados.Controls.Add(this.txtNumero);
            this.panelDados.Controls.Add(this.txtRua);
            this.panelDados.Controls.Add(this.txtBairro);
            this.panelDados.Controls.Add(this.txtCidade);
            this.panelDados.Controls.Add(this.txtEstado);
            this.panelDados.Controls.Add(this.txtCep);
            this.panelDados.Controls.Add(this.txtLogo);
            this.panelDados.Controls.Add(this.txtSite);
            this.panelDados.Controls.Add(this.txtEmail);
            this.panelDados.Controls.Add(this.txtCelular);
            this.panelDados.Controls.Add(this.txtTelefone);
            this.panelDados.Controls.Add(this.txtRegime);
            this.panelDados.Controls.Add(this.txtIM);
            this.panelDados.Controls.Add(this.txtIE);
            this.panelDados.Controls.Add(this.txtCnpj);
            this.panelDados.Controls.Add(this.txtRazaoSocial);
            this.panelDados.Controls.Add(this.txtUid);
            this.panelDados.Controls.Add(this.txtCodigo);
            this.panelDados.Size = new System.Drawing.Size(959, 538);
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.chkStatus);
            this.panelStatus.Controls.Add(this.label14);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatus.Location = new System.Drawing.Point(0, 456);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(959, 25);
            this.panelStatus.TabIndex = 37;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(149, 5);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(51, 17);
            this.chkStatus.TabIndex = 1;
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
            // txtNumero
            // 
            this.txtNumero.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNumero.EnableAll = true;
            this.txtNumero.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumero.Location = new System.Drawing.Point(0, 408);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(959, 24);
            this.txtNumero.TabIndex = 35;
            this.txtNumero.Texto = "";
            this.txtNumero.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Centro;
            this.txtNumero.TextoEsquerda = "Número";
            this.txtNumero.TextoLargura = 70;
            this.txtNumero.TextoMaiusculo = false;
            this.txtNumero.TextoSenha = false;
            this.txtNumero.TextoStatus = "Número";
            this.txtNumero.VisibleAll = true;
            // 
            // txtRua
            // 
            this.txtRua.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRua.EnableAll = true;
            this.txtRua.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRua.Location = new System.Drawing.Point(0, 384);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(959, 24);
            this.txtRua.TabIndex = 34;
            this.txtRua.Texto = "";
            this.txtRua.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtRua.TextoEsquerda = "Rua";
            this.txtRua.TextoLargura = 500;
            this.txtRua.TextoMaiusculo = true;
            this.txtRua.TextoSenha = false;
            this.txtRua.TextoStatus = "Rua";
            this.txtRua.VisibleAll = true;
            // 
            // txtBairro
            // 
            this.txtBairro.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBairro.EnableAll = true;
            this.txtBairro.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBairro.Location = new System.Drawing.Point(0, 360);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(959, 24);
            this.txtBairro.TabIndex = 33;
            this.txtBairro.Texto = "";
            this.txtBairro.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtBairro.TextoEsquerda = "Bairro";
            this.txtBairro.TextoLargura = 150;
            this.txtBairro.TextoMaiusculo = true;
            this.txtBairro.TextoSenha = false;
            this.txtBairro.TextoStatus = "Bairro";
            this.txtBairro.VisibleAll = true;
            // 
            // txtCidade
            // 
            this.txtCidade.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCidade.EnableAll = true;
            this.txtCidade.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCidade.Location = new System.Drawing.Point(0, 336);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(959, 24);
            this.txtCidade.TabIndex = 32;
            this.txtCidade.Texto = "";
            this.txtCidade.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtCidade.TextoEsquerda = "Cidade";
            this.txtCidade.TextoLargura = 150;
            this.txtCidade.TextoMaiusculo = true;
            this.txtCidade.TextoSenha = false;
            this.txtCidade.TextoStatus = "Cidade";
            this.txtCidade.VisibleAll = true;
            // 
            // txtEstado
            // 
            this.txtEstado.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEstado.EnableAll = true;
            this.txtEstado.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEstado.Location = new System.Drawing.Point(0, 312);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(959, 24);
            this.txtEstado.TabIndex = 31;
            this.txtEstado.Texto = "";
            this.txtEstado.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Centro;
            this.txtEstado.TextoEsquerda = "Estado";
            this.txtEstado.TextoLargura = 40;
            this.txtEstado.TextoMaiusculo = true;
            this.txtEstado.TextoSenha = false;
            this.txtEstado.TextoStatus = "Estado";
            this.txtEstado.VisibleAll = true;
            // 
            // txtCep
            // 
            this.txtCep.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCep.EnableAll = true;
            this.txtCep.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCep.Location = new System.Drawing.Point(0, 288);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(959, 24);
            this.txtCep.TabIndex = 30;
            this.txtCep.Texto = "";
            this.txtCep.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Centro;
            this.txtCep.TextoEsquerda = "CEP";
            this.txtCep.TextoLargura = 90;
            this.txtCep.TextoMaiusculo = false;
            this.txtCep.TextoSenha = false;
            this.txtCep.TextoStatus = "CEP";
            this.txtCep.VisibleAll = true;
            // 
            // txtLogo
            // 
            this.txtLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLogo.EnableAll = false;
            this.txtLogo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLogo.Location = new System.Drawing.Point(0, 264);
            this.txtLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.Size = new System.Drawing.Size(959, 24);
            this.txtLogo.StatuBarComponent = null;
            this.txtLogo.TabIndex = 29;
            this.txtLogo.TextoCentro = null;
            this.txtLogo.TextoDireita = "";
            this.txtLogo.TextoEsquerda = "Logo";
            this.txtLogo.TextoStatus = "Logo";
            // 
            // txtSite
            // 
            this.txtSite.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSite.EnableAll = true;
            this.txtSite.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSite.Location = new System.Drawing.Point(0, 240);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(959, 24);
            this.txtSite.TabIndex = 28;
            this.txtSite.Texto = "";
            this.txtSite.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtSite.TextoEsquerda = "Site";
            this.txtSite.TextoLargura = 300;
            this.txtSite.TextoMaiusculo = false;
            this.txtSite.TextoSenha = false;
            this.txtSite.TextoStatus = "Site";
            this.txtSite.VisibleAll = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEmail.EnableAll = true;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(0, 216);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(959, 24);
            this.txtEmail.TabIndex = 27;
            this.txtEmail.Texto = "";
            this.txtEmail.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtEmail.TextoEsquerda = "E-Mail";
            this.txtEmail.TextoLargura = 200;
            this.txtEmail.TextoMaiusculo = false;
            this.txtEmail.TextoSenha = false;
            this.txtEmail.TextoStatus = "E-Mail";
            this.txtEmail.VisibleAll = true;
            // 
            // txtCelular
            // 
            this.txtCelular.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCelular.EnableAll = true;
            this.txtCelular.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCelular.Location = new System.Drawing.Point(0, 192);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(959, 24);
            this.txtCelular.TabIndex = 26;
            this.txtCelular.Texto = "";
            this.txtCelular.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtCelular.TextoEsquerda = "Celular";
            this.txtCelular.TextoLargura = 90;
            this.txtCelular.TextoMaiusculo = false;
            this.txtCelular.TextoSenha = false;
            this.txtCelular.TextoStatus = "Celular";
            this.txtCelular.VisibleAll = true;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTelefone.EnableAll = true;
            this.txtTelefone.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelefone.Location = new System.Drawing.Point(0, 168);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(959, 24);
            this.txtTelefone.TabIndex = 25;
            this.txtTelefone.Texto = "";
            this.txtTelefone.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtTelefone.TextoEsquerda = "Telefone";
            this.txtTelefone.TextoLargura = 90;
            this.txtTelefone.TextoMaiusculo = false;
            this.txtTelefone.TextoSenha = false;
            this.txtTelefone.TextoStatus = "Telefone";
            this.txtTelefone.VisibleAll = true;
            // 
            // txtRegime
            // 
            this.txtRegime.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRegime.EnableAll = true;
            this.txtRegime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRegime.Location = new System.Drawing.Point(0, 144);
            this.txtRegime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRegime.Name = "txtRegime";
            this.txtRegime.Size = new System.Drawing.Size(959, 24);
            this.txtRegime.StatuBarComponent = null;
            this.txtRegime.TabIndex = 24;
            this.txtRegime.TextoCentro = null;
            this.txtRegime.TextoDireita = "";
            this.txtRegime.TextoEsquerda = "Regime Tributário";
            this.txtRegime.TextoStatus = "Regime Tributário";
            this.txtRegime.ButtonClick += new System.EventHandler(this.txtRegime_ButtonClick);
            this.txtRegime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRegime_KeyDown);
            this.txtRegime.Validating += new System.ComponentModel.CancelEventHandler(this.txtRegime_Validating);
            // 
            // txtIM
            // 
            this.txtIM.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtIM.EnableAll = true;
            this.txtIM.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIM.Location = new System.Drawing.Point(0, 120);
            this.txtIM.Name = "txtIM";
            this.txtIM.Size = new System.Drawing.Size(959, 24);
            this.txtIM.TabIndex = 23;
            this.txtIM.Texto = "";
            this.txtIM.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtIM.TextoEsquerda = "Inscrição Municipal";
            this.txtIM.TextoLargura = 70;
            this.txtIM.TextoMaiusculo = false;
            this.txtIM.TextoSenha = false;
            this.txtIM.TextoStatus = "Inscrição Municipal";
            this.txtIM.VisibleAll = true;
            // 
            // txtIE
            // 
            this.txtIE.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtIE.EnableAll = true;
            this.txtIE.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIE.Location = new System.Drawing.Point(0, 96);
            this.txtIE.Name = "txtIE";
            this.txtIE.Size = new System.Drawing.Size(959, 24);
            this.txtIE.TabIndex = 22;
            this.txtIE.Texto = "";
            this.txtIE.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtIE.TextoEsquerda = "Inscrição Estadual";
            this.txtIE.TextoLargura = 70;
            this.txtIE.TextoMaiusculo = false;
            this.txtIE.TextoSenha = false;
            this.txtIE.TextoStatus = "Inscrição Estadual";
            this.txtIE.VisibleAll = true;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCnpj.EnableAll = true;
            this.txtCnpj.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCnpj.Location = new System.Drawing.Point(0, 72);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(959, 24);
            this.txtCnpj.TabIndex = 21;
            this.txtCnpj.Texto = "";
            this.txtCnpj.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtCnpj.TextoEsquerda = "Cnpj";
            this.txtCnpj.TextoLargura = 200;
            this.txtCnpj.TextoMaiusculo = false;
            this.txtCnpj.TextoSenha = false;
            this.txtCnpj.TextoStatus = "Cnpj";
            this.txtCnpj.VisibleAll = true;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRazaoSocial.EnableAll = true;
            this.txtRazaoSocial.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRazaoSocial.Location = new System.Drawing.Point(0, 48);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(959, 24);
            this.txtRazaoSocial.TabIndex = 20;
            this.txtRazaoSocial.Texto = "";
            this.txtRazaoSocial.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtRazaoSocial.TextoEsquerda = "Razão Social";
            this.txtRazaoSocial.TextoLargura = 500;
            this.txtRazaoSocial.TextoMaiusculo = true;
            this.txtRazaoSocial.TextoSenha = false;
            this.txtRazaoSocial.TextoStatus = "Razão Social";
            this.txtRazaoSocial.VisibleAll = true;
            // 
            // txtUid
            // 
            this.txtUid.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUid.EnableAll = true;
            this.txtUid.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUid.Location = new System.Drawing.Point(0, 24);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(959, 24);
            this.txtUid.StatuBarComponent = this.toolStripStatusLabel2;
            this.txtUid.TabIndex = 19;
            this.txtUid.Texto = "";
            this.txtUid.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtUid.TextoEsquerda = "Uid";
            this.txtUid.TextoLargura = 200;
            this.txtUid.TextoMaiusculo = false;
            this.txtUid.TextoSenha = false;
            this.txtUid.TextoStatus = "Uid";
            this.txtUid.VisibleAll = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCodigo.EnableAll = true;
            this.txtCodigo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigo.Location = new System.Drawing.Point(0, 0);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(959, 24);
            this.txtCodigo.StatuBarComponent = this.toolStripStatusLabel2;
            this.txtCodigo.TabIndex = 18;
            this.txtCodigo.Texto = "";
            this.txtCodigo.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Centro;
            this.txtCodigo.TextoEsquerda = "Código";
            this.txtCodigo.TextoLargura = 90;
            this.txtCodigo.TextoMaiusculo = false;
            this.txtCodigo.TextoSenha = false;
            this.txtCodigo.TextoStatus = "Código";
            this.txtCodigo.VisibleAll = true;
            // 
            // txtAmbiente
            // 
            this.txtAmbiente.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAmbiente.EnableAll = true;
            this.txtAmbiente.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAmbiente.Location = new System.Drawing.Point(0, 432);
            this.txtAmbiente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAmbiente.Name = "txtAmbiente";
            this.txtAmbiente.Size = new System.Drawing.Size(959, 24);
            this.txtAmbiente.StatuBarComponent = null;
            this.txtAmbiente.TabIndex = 36;
            this.txtAmbiente.TextoCentro = null;
            this.txtAmbiente.TextoDireita = "";
            this.txtAmbiente.TextoEsquerda = "Ambiente";
            this.txtAmbiente.TextoStatus = "Ambiente";
            this.txtAmbiente.ButtonClick += new System.EventHandler(this.txtAmbiente_ButtonClick);
            this.txtAmbiente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmbiente_KeyDown);
            this.txtAmbiente.Validating += new System.ComponentModel.CancelEventHandler(this.txtAmbiente_Validating);
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 606);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmEmpresa";
            this.Text = "frmEmpresa";
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
        private Componentes.TextBox.txtBoxLabel txtNumero;
        private Componentes.TextBox.txtBoxLabel txtRua;
        private Componentes.TextBox.txtBoxLabel txtBairro;
        private Componentes.TextBox.txtBoxLabel txtCidade;
        private Componentes.TextBox.txtBoxLabel txtEstado;
        private Componentes.TextBox.txtBoxLabel txtCep;
        private Componentes.TextBox.txtBoxBtnLabel txtLogo;
        private Componentes.TextBox.txtBoxLabel txtSite;
        private Componentes.TextBox.txtBoxLabel txtEmail;
        private Componentes.TextBox.txtBoxLabel txtCelular;
        private Componentes.TextBox.txtBoxLabel txtTelefone;
        private Componentes.TextBox.txtBoxBtnLabel txtRegime;
        private Componentes.TextBox.txtBoxLabel txtIM;
        private Componentes.TextBox.txtBoxLabel txtIE;
        private Componentes.TextBox.txtBoxLabel txtCnpj;
        private Componentes.TextBox.txtBoxLabel txtRazaoSocial;
        private Componentes.TextBox.txtBoxLabel txtUid;
        private Componentes.TextBox.txtBoxLabel txtCodigo;
        private Componentes.TextBox.txtBoxBtnLabel txtAmbiente;
    }
}