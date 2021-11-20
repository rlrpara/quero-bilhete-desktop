namespace QueroBilhete.Desktop.formularios.Passageiro
{
    partial class frmPassageiro
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
            this.txtCodigo = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtNome = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtRG = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtCPF = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtTelefone = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtCelular = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtEmail = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtCep = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtEstado = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtCidade = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtBairro = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtRua = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtNumero = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
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
            this.grpCadastro.Controls.Add(this.txtEmail);
            this.grpCadastro.Controls.Add(this.txtCelular);
            this.grpCadastro.Controls.Add(this.txtTelefone);
            this.grpCadastro.Controls.Add(this.txtCPF);
            this.grpCadastro.Controls.Add(this.txtRG);
            this.grpCadastro.Controls.Add(this.txtNome);
            this.grpCadastro.Controls.Add(this.txtCodigo);
            this.grpCadastro.Size = new System.Drawing.Size(800, 382);
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
            // txtCodigo
            // 
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCodigo.EnableAll = true;
            this.txtCodigo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigo.Location = new System.Drawing.Point(3, 18);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(794, 24);
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
            // txtNome
            // 
            this.txtNome.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNome.EnableAll = true;
            this.txtNome.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(3, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(794, 24);
            this.txtNome.TabIndex = 1;
            this.txtNome.Texto = "";
            this.txtNome.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtNome.TextoEsquerda = "Nome";
            this.txtNome.TextoLargura = 500;
            this.txtNome.TextoMaiusculo = true;
            this.txtNome.TextoSenha = false;
            this.txtNome.TextoStatus = "Nome";
            this.txtNome.VisibleAll = true;
            // 
            // txtRG
            // 
            this.txtRG.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRG.EnableAll = true;
            this.txtRG.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRG.Location = new System.Drawing.Point(3, 66);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(794, 24);
            this.txtRG.TabIndex = 2;
            this.txtRG.Texto = "";
            this.txtRG.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtRG.TextoEsquerda = "RG";
            this.txtRG.TextoLargura = 90;
            this.txtRG.TextoMaiusculo = true;
            this.txtRG.TextoSenha = false;
            this.txtRG.TextoStatus = "RG";
            this.txtRG.VisibleAll = true;
            // 
            // txtCPF
            // 
            this.txtCPF.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCPF.EnableAll = true;
            this.txtCPF.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCPF.Location = new System.Drawing.Point(3, 90);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(794, 24);
            this.txtCPF.TabIndex = 3;
            this.txtCPF.Texto = "";
            this.txtCPF.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtCPF.TextoEsquerda = "CPF";
            this.txtCPF.TextoLargura = 150;
            this.txtCPF.TextoMaiusculo = true;
            this.txtCPF.TextoSenha = false;
            this.txtCPF.TextoStatus = "CPF";
            this.txtCPF.VisibleAll = true;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTelefone.EnableAll = true;
            this.txtTelefone.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelefone.Location = new System.Drawing.Point(3, 114);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(794, 24);
            this.txtTelefone.TabIndex = 4;
            this.txtTelefone.Texto = "";
            this.txtTelefone.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtTelefone.TextoEsquerda = "Telefone";
            this.txtTelefone.TextoLargura = 90;
            this.txtTelefone.TextoMaiusculo = true;
            this.txtTelefone.TextoSenha = false;
            this.txtTelefone.TextoStatus = "Telefone";
            this.txtTelefone.VisibleAll = true;
            // 
            // txtCelular
            // 
            this.txtCelular.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCelular.EnableAll = true;
            this.txtCelular.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCelular.Location = new System.Drawing.Point(3, 138);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(794, 24);
            this.txtCelular.TabIndex = 5;
            this.txtCelular.Texto = "";
            this.txtCelular.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtCelular.TextoEsquerda = "Celular";
            this.txtCelular.TextoLargura = 90;
            this.txtCelular.TextoMaiusculo = true;
            this.txtCelular.TextoSenha = false;
            this.txtCelular.TextoStatus = "Celular";
            this.txtCelular.VisibleAll = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEmail.EnableAll = true;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(3, 162);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(794, 24);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.Texto = "";
            this.txtEmail.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtEmail.TextoEsquerda = "E-Mail";
            this.txtEmail.TextoLargura = 200;
            this.txtEmail.TextoMaiusculo = true;
            this.txtEmail.TextoSenha = false;
            this.txtEmail.TextoStatus = "E-Mail";
            this.txtEmail.VisibleAll = true;
            // 
            // txtCep
            // 
            this.txtCep.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCep.EnableAll = true;
            this.txtCep.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCep.Location = new System.Drawing.Point(3, 186);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(794, 24);
            this.txtCep.TabIndex = 7;
            this.txtCep.Texto = "";
            this.txtCep.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtCep.TextoEsquerda = "CEP";
            this.txtCep.TextoLargura = 90;
            this.txtCep.TextoMaiusculo = true;
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
            this.txtEstado.Location = new System.Drawing.Point(3, 210);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(794, 24);
            this.txtEstado.TabIndex = 8;
            this.txtEstado.Texto = "";
            this.txtEstado.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
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
            this.txtCidade.Location = new System.Drawing.Point(3, 234);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(794, 24);
            this.txtCidade.TabIndex = 9;
            this.txtCidade.Texto = "";
            this.txtCidade.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtCidade.TextoEsquerda = "Cidade";
            this.txtCidade.TextoLargura = 120;
            this.txtCidade.TextoMaiusculo = true;
            this.txtCidade.TextoSenha = false;
            this.txtCidade.TextoStatus = "Cidade";
            this.txtCidade.VisibleAll = true;
            // 
            // txtBairro
            // 
            this.txtBairro.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBairro.EnableAll = true;
            this.txtBairro.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBairro.Location = new System.Drawing.Point(3, 258);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(794, 24);
            this.txtBairro.TabIndex = 10;
            this.txtBairro.Texto = "";
            this.txtBairro.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtBairro.TextoEsquerda = "Bairro";
            this.txtBairro.TextoLargura = 200;
            this.txtBairro.TextoMaiusculo = true;
            this.txtBairro.TextoSenha = false;
            this.txtBairro.TextoStatus = "Bairro";
            this.txtBairro.VisibleAll = true;
            // 
            // txtRua
            // 
            this.txtRua.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRua.EnableAll = true;
            this.txtRua.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRua.Location = new System.Drawing.Point(3, 282);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(794, 24);
            this.txtRua.TabIndex = 11;
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
            this.txtNumero.Location = new System.Drawing.Point(3, 306);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(794, 24);
            this.txtNumero.TabIndex = 12;
            this.txtNumero.Texto = "";
            this.txtNumero.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtNumero.TextoEsquerda = "Número";
            this.txtNumero.TextoLargura = 90;
            this.txtNumero.TextoMaiusculo = true;
            this.txtNumero.TextoSenha = false;
            this.txtNumero.TextoStatus = "Número";
            this.txtNumero.VisibleAll = true;
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.chkStatus);
            this.panelStatus.Controls.Add(this.label14);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatus.Location = new System.Drawing.Point(3, 330);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(794, 25);
            this.panelStatus.TabIndex = 13;
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
            this.chkStatus.Click += new System.EventHandler(this.chkStatus_Click);
            this.chkStatus.Enter += new System.EventHandler(this.chkStatus_Enter);
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
            // frmPassageiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmPassageiro";
            this.Text = "frmPassageiro";
            this.grpCadastro.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.TextBox.txtBoxLabel txtCodigo;
        private Componentes.TextBox.txtBoxLabel txtNome;
        private Componentes.TextBox.txtBoxLabel txtCelular;
        private Componentes.TextBox.txtBoxLabel txtTelefone;
        private Componentes.TextBox.txtBoxLabel txtCPF;
        private Componentes.TextBox.txtBoxLabel txtRG;
        private Componentes.TextBox.txtBoxLabel txtEmail;
        private Componentes.TextBox.txtBoxLabel txtCidade;
        private Componentes.TextBox.txtBoxLabel txtEstado;
        private Componentes.TextBox.txtBoxLabel txtCep;
        private Componentes.TextBox.txtBoxLabel txtNumero;
        private Componentes.TextBox.txtBoxLabel txtRua;
        private Componentes.TextBox.txtBoxLabel txtBairro;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.Label label14;
    }
}