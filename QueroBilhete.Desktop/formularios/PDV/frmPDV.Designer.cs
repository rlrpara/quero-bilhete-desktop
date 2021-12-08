
namespace QueroBilhete.Desktop.formularios.PDV
{
    partial class frmPDV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnF12 = new System.Windows.Forms.Button();
            this.btnF11 = new System.Windows.Forms.Button();
            this.btnF10 = new System.Windows.Forms.Button();
            this.btnF9 = new System.Windows.Forms.Button();
            this.btnF8 = new System.Windows.Forms.Button();
            this.btnF7 = new System.Windows.Forms.Button();
            this.btnF5 = new System.Windows.Forms.Button();
            this.btnF4 = new System.Windows.Forms.Button();
            this.btnF6 = new System.Windows.Forms.Button();
            this.btnF3 = new System.Windows.Forms.Button();
            this.btnF2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtValorTroco = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtValorPago = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtValor = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtFormaPagamento = new QueroBilhete.Componentes.TextBox.txtBoxBtnLabel();
            this.txtPoltrona = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtNacionalidade = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtRG = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtNome = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtCPF = new QueroBilhete.Componentes.TextBox.txtBoxLabel();
            this.txtTipo = new QueroBilhete.Componentes.TextBox.txtBoxBtnLabel();
            this.pnlJanela = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbEmbarcacao = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.cmbTrajeto = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Passagem,
            this.Qtd,
            this.ValorUnitario,
            this.ValorTotal});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(503, 570);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id.FillWeight = 26.6417F;
            this.Id.HeaderText = "Cód.";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 57;
            // 
            // Passagem
            // 
            this.Passagem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Passagem.DefaultCellStyle = dataGridViewCellStyle2;
            this.Passagem.FillWeight = 279.1878F;
            this.Passagem.HeaderText = "Descricao";
            this.Passagem.Name = "Passagem";
            this.Passagem.ReadOnly = true;
            // 
            // Qtd
            // 
            this.Qtd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Qtd.DefaultCellStyle = dataGridViewCellStyle3;
            this.Qtd.FillWeight = 52.32397F;
            this.Qtd.HeaderText = "Qtd.";
            this.Qtd.Name = "Qtd";
            this.Qtd.ReadOnly = true;
            this.Qtd.Width = 55;
            // 
            // ValorUnitario
            // 
            this.ValorUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ValorUnitario.DefaultCellStyle = dataGridViewCellStyle4;
            this.ValorUnitario.FillWeight = 63.46081F;
            this.ValorUnitario.HeaderText = "Preço";
            this.ValorUnitario.Name = "ValorUnitario";
            this.ValorUnitario.ReadOnly = true;
            this.ValorUnitario.Width = 62;
            // 
            // ValorTotal
            // 
            this.ValorTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ValorTotal.DefaultCellStyle = dataGridViewCellStyle5;
            this.ValorTotal.FillWeight = 78.3857F;
            this.ValorTotal.HeaderText = "Total";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            this.ValorTotal.Width = 57;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnF12);
            this.panel2.Controls.Add(this.btnF11);
            this.panel2.Controls.Add(this.btnF10);
            this.panel2.Controls.Add(this.btnF9);
            this.panel2.Controls.Add(this.btnF8);
            this.panel2.Controls.Add(this.btnF7);
            this.panel2.Controls.Add(this.btnF5);
            this.panel2.Controls.Add(this.btnF4);
            this.panel2.Controls.Add(this.btnF6);
            this.panel2.Controls.Add(this.btnF3);
            this.panel2.Controls.Add(this.btnF2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 670);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1549, 67);
            this.panel2.TabIndex = 1;
            // 
            // btnF12
            // 
            this.btnF12.Location = new System.Drawing.Point(885, 6);
            this.btnF12.Name = "btnF12";
            this.btnF12.Size = new System.Drawing.Size(86, 54);
            this.btnF12.TabIndex = 10;
            this.btnF12.Text = "F12";
            this.btnF12.UseVisualStyleBackColor = true;
            // 
            // btnF11
            // 
            this.btnF11.Location = new System.Drawing.Point(797, 6);
            this.btnF11.Name = "btnF11";
            this.btnF11.Size = new System.Drawing.Size(86, 54);
            this.btnF11.TabIndex = 9;
            this.btnF11.Text = "Lançar direto F11";
            this.btnF11.UseVisualStyleBackColor = true;
            // 
            // btnF10
            // 
            this.btnF10.Location = new System.Drawing.Point(709, 6);
            this.btnF10.Name = "btnF10";
            this.btnF10.Size = new System.Drawing.Size(86, 54);
            this.btnF10.TabIndex = 8;
            this.btnF10.Text = "Adicionar Passagem  F10";
            this.btnF10.UseVisualStyleBackColor = true;
            // 
            // btnF9
            // 
            this.btnF9.Location = new System.Drawing.Point(621, 6);
            this.btnF9.Name = "btnF9";
            this.btnF9.Size = new System.Drawing.Size(86, 54);
            this.btnF9.TabIndex = 7;
            this.btnF9.Text = "Canelar Passagem   F9";
            this.btnF9.UseVisualStyleBackColor = true;
            // 
            // btnF8
            // 
            this.btnF8.Location = new System.Drawing.Point(533, 6);
            this.btnF8.Name = "btnF8";
            this.btnF8.Size = new System.Drawing.Size(86, 54);
            this.btnF8.TabIndex = 6;
            this.btnF8.Text = "F8";
            this.btnF8.UseVisualStyleBackColor = true;
            // 
            // btnF7
            // 
            this.btnF7.Location = new System.Drawing.Point(445, 6);
            this.btnF7.Name = "btnF7";
            this.btnF7.Size = new System.Drawing.Size(86, 54);
            this.btnF7.TabIndex = 5;
            this.btnF7.Text = "F7";
            this.btnF7.UseVisualStyleBackColor = true;
            // 
            // btnF5
            // 
            this.btnF5.Location = new System.Drawing.Point(269, 6);
            this.btnF5.Name = "btnF5";
            this.btnF5.Size = new System.Drawing.Size(86, 54);
            this.btnF5.TabIndex = 4;
            this.btnF5.Text = "F5";
            this.btnF5.UseVisualStyleBackColor = true;
            // 
            // btnF4
            // 
            this.btnF4.Location = new System.Drawing.Point(181, 6);
            this.btnF4.Name = "btnF4";
            this.btnF4.Size = new System.Drawing.Size(86, 54);
            this.btnF4.TabIndex = 3;
            this.btnF4.Text = "Fechar Venda F4";
            this.btnF4.UseVisualStyleBackColor = true;
            this.btnF4.Click += new System.EventHandler(this.btnF4_Click);
            // 
            // btnF6
            // 
            this.btnF6.Location = new System.Drawing.Point(357, 6);
            this.btnF6.Name = "btnF6";
            this.btnF6.Size = new System.Drawing.Size(86, 54);
            this.btnF6.TabIndex = 2;
            this.btnF6.Text = "Fechar Caixa F6";
            this.btnF6.UseVisualStyleBackColor = true;
            this.btnF6.Click += new System.EventHandler(this.btnFecharCaixa_Click);
            // 
            // btnF3
            // 
            this.btnF3.Location = new System.Drawing.Point(93, 6);
            this.btnF3.Name = "btnF3";
            this.btnF3.Size = new System.Drawing.Size(86, 54);
            this.btnF3.TabIndex = 1;
            this.btnF3.Text = "Canelar Venda F3";
            this.btnF3.UseVisualStyleBackColor = true;
            // 
            // btnF2
            // 
            this.btnF2.Location = new System.Drawing.Point(5, 6);
            this.btnF2.Name = "btnF2";
            this.btnF2.Size = new System.Drawing.Size(86, 54);
            this.btnF2.TabIndex = 0;
            this.btnF2.Text = "Nova Venda F2";
            this.btnF2.UseVisualStyleBackColor = true;
            this.btnF2.Click += new System.EventHandler(this.btnNovaVenda_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1549, 670);
            this.panel5.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.pnlJanela);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1549, 570);
            this.panel4.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtValorTroco);
            this.panel3.Controls.Add(this.txtValorPago);
            this.panel3.Controls.Add(this.txtValor);
            this.panel3.Controls.Add(this.txtFormaPagamento);
            this.panel3.Controls.Add(this.txtPoltrona);
            this.panel3.Controls.Add(this.txtNacionalidade);
            this.panel3.Controls.Add(this.txtRG);
            this.panel3.Controls.Add(this.txtNome);
            this.panel3.Controls.Add(this.txtCPF);
            this.panel3.Controls.Add(this.txtTipo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(657, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(389, 570);
            this.panel3.TabIndex = 6;
            // 
            // txtValorTroco
            // 
            this.txtValorTroco.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtValorTroco.EnableAll = false;
            this.txtValorTroco.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorTroco.Location = new System.Drawing.Point(0, 216);
            this.txtValorTroco.Name = "txtValorTroco";
            this.txtValorTroco.Size = new System.Drawing.Size(389, 24);
            this.txtValorTroco.TabIndex = 10;
            this.txtValorTroco.Texto = "";
            this.txtValorTroco.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Direita;
            this.txtValorTroco.TextoEsquerda = "Troco";
            this.txtValorTroco.TextoLargura = 90;
            this.txtValorTroco.TextoMaiusculo = true;
            this.txtValorTroco.TextoSenha = false;
            this.txtValorTroco.TextoStatus = "Troco";
            this.txtValorTroco.VisibleAll = true;
            // 
            // txtValorPago
            // 
            this.txtValorPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtValorPago.EnableAll = true;
            this.txtValorPago.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorPago.Location = new System.Drawing.Point(0, 192);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(389, 24);
            this.txtValorPago.TabIndex = 9;
            this.txtValorPago.Texto = "";
            this.txtValorPago.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Direita;
            this.txtValorPago.TextoEsquerda = "Pago";
            this.txtValorPago.TextoLargura = 90;
            this.txtValorPago.TextoMaiusculo = true;
            this.txtValorPago.TextoSenha = false;
            this.txtValorPago.TextoStatus = "Pago";
            this.txtValorPago.VisibleAll = true;
            // 
            // txtValor
            // 
            this.txtValor.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtValor.EnableAll = false;
            this.txtValor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValor.Location = new System.Drawing.Point(0, 168);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(389, 24);
            this.txtValor.TabIndex = 8;
            this.txtValor.Texto = "";
            this.txtValor.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Direita;
            this.txtValor.TextoEsquerda = "Valor";
            this.txtValor.TextoLargura = 90;
            this.txtValor.TextoMaiusculo = true;
            this.txtValor.TextoSenha = false;
            this.txtValor.TextoStatus = "Valor";
            this.txtValor.VisibleAll = true;
            // 
            // txtFormaPagamento
            // 
            this.txtFormaPagamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFormaPagamento.EnableAll = true;
            this.txtFormaPagamento.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFormaPagamento.Location = new System.Drawing.Point(0, 144);
            this.txtFormaPagamento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFormaPagamento.Name = "txtFormaPagamento";
            this.txtFormaPagamento.Size = new System.Drawing.Size(389, 24);
            this.txtFormaPagamento.StatuBarComponent = null;
            this.txtFormaPagamento.TabIndex = 11;
            this.txtFormaPagamento.TextoCentro = null;
            this.txtFormaPagamento.TextoDireita = "";
            this.txtFormaPagamento.TextoEsquerda = "Forma Pagamento";
            this.txtFormaPagamento.TextoStatus = null;
            // 
            // txtPoltrona
            // 
            this.txtPoltrona.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPoltrona.EnableAll = true;
            this.txtPoltrona.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPoltrona.Location = new System.Drawing.Point(0, 120);
            this.txtPoltrona.Name = "txtPoltrona";
            this.txtPoltrona.Size = new System.Drawing.Size(389, 24);
            this.txtPoltrona.TabIndex = 6;
            this.txtPoltrona.Texto = "";
            this.txtPoltrona.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Centro;
            this.txtPoltrona.TextoEsquerda = "Poltrona";
            this.txtPoltrona.TextoLargura = 90;
            this.txtPoltrona.TextoMaiusculo = true;
            this.txtPoltrona.TextoSenha = false;
            this.txtPoltrona.TextoStatus = "Poltrona";
            this.txtPoltrona.VisibleAll = true;
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNacionalidade.EnableAll = true;
            this.txtNacionalidade.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNacionalidade.Location = new System.Drawing.Point(0, 96);
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Size = new System.Drawing.Size(389, 24);
            this.txtNacionalidade.TabIndex = 5;
            this.txtNacionalidade.Texto = "Brasileira";
            this.txtNacionalidade.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtNacionalidade.TextoEsquerda = "Nacionalidade";
            this.txtNacionalidade.TextoLargura = 90;
            this.txtNacionalidade.TextoMaiusculo = true;
            this.txtNacionalidade.TextoSenha = false;
            this.txtNacionalidade.TextoStatus = "RG";
            this.txtNacionalidade.VisibleAll = true;
            // 
            // txtRG
            // 
            this.txtRG.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRG.EnableAll = true;
            this.txtRG.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRG.Location = new System.Drawing.Point(0, 72);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(389, 24);
            this.txtRG.TabIndex = 4;
            this.txtRG.Texto = "";
            this.txtRG.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtRG.TextoEsquerda = "RG";
            this.txtRG.TextoLargura = 90;
            this.txtRG.TextoMaiusculo = false;
            this.txtRG.TextoSenha = false;
            this.txtRG.TextoStatus = "RG";
            this.txtRG.VisibleAll = true;
            // 
            // txtNome
            // 
            this.txtNome.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNome.EnableAll = true;
            this.txtNome.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(0, 48);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(389, 24);
            this.txtNome.TabIndex = 3;
            this.txtNome.Texto = "";
            this.txtNome.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtNome.TextoEsquerda = "Nome";
            this.txtNome.TextoLargura = 90;
            this.txtNome.TextoMaiusculo = true;
            this.txtNome.TextoSenha = false;
            this.txtNome.TextoStatus = "Nome";
            this.txtNome.VisibleAll = true;
            // 
            // txtCPF
            // 
            this.txtCPF.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCPF.EnableAll = true;
            this.txtCPF.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCPF.Location = new System.Drawing.Point(0, 24);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(389, 24);
            this.txtCPF.TabIndex = 2;
            this.txtCPF.Texto = "";
            this.txtCPF.TextoAlinhamento = QueroBilhete.Componentes.Enumeradores.EAlinhamento.Esquerda;
            this.txtCPF.TextoEsquerda = "CPF";
            this.txtCPF.TextoLargura = 90;
            this.txtCPF.TextoMaiusculo = true;
            this.txtCPF.TextoSenha = false;
            this.txtCPF.TextoStatus = "CPF";
            this.txtCPF.VisibleAll = true;
            // 
            // txtTipo
            // 
            this.txtTipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTipo.EnableAll = true;
            this.txtTipo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTipo.Location = new System.Drawing.Point(0, 0);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(389, 24);
            this.txtTipo.StatuBarComponent = null;
            this.txtTipo.TabIndex = 0;
            this.txtTipo.TextoCentro = null;
            this.txtTipo.TextoDireita = "";
            this.txtTipo.TextoEsquerda = "Tipo Passagem";
            this.txtTipo.TextoStatus = null;
            this.txtTipo.ButtonClick += new System.EventHandler(this.txtTipo_ButtonClick);
            this.txtTipo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTipo_KeyDown);
            this.txtTipo.Validating += new System.ComponentModel.CancelEventHandler(this.txtTipo_Validating);
            // 
            // pnlJanela
            // 
            this.pnlJanela.AutoScroll = true;
            this.pnlJanela.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlJanela.Enabled = false;
            this.pnlJanela.Location = new System.Drawing.Point(0, 0);
            this.pnlJanela.Name = "pnlJanela";
            this.pnlJanela.Padding = new System.Windows.Forms.Padding(3);
            this.pnlJanela.Size = new System.Drawing.Size(657, 570);
            this.pnlJanela.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1046, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(503, 570);
            this.panel6.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbEmbarcacao);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dateTimePicker6);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.cmbTrajeto);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1549, 100);
            this.panel1.TabIndex = 4;
            // 
            // cmbEmbarcacao
            // 
            this.cmbEmbarcacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmbarcacao.FormattingEnabled = true;
            this.cmbEmbarcacao.Items.AddRange(new object[] {
            "125 - Catamarâ",
            "3352 - Salmista"});
            this.cmbEmbarcacao.Location = new System.Drawing.Point(6, 69);
            this.cmbEmbarcacao.Name = "cmbEmbarcacao";
            this.cmbEmbarcacao.Size = new System.Drawing.Size(175, 23);
            this.cmbEmbarcacao.TabIndex = 10;
            this.cmbEmbarcacao.SelectedIndexChanged += new System.EventHandler(this.txtEmbarcacao_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Embarcação";
            // 
            // dateTimePicker6
            // 
            this.dateTimePicker6.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker6.Location = new System.Drawing.Point(527, 69);
            this.dateTimePicker6.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.Size = new System.Drawing.Size(130, 23);
            this.dateTimePicker6.TabIndex = 6;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(527, 51);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(31, 15);
            this.label24.TabIndex = 5;
            this.label24.Text = "Data";
            // 
            // cmbTrajeto
            // 
            this.cmbTrajeto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrajeto.FormattingEnabled = true;
            this.cmbTrajeto.Items.AddRange(new object[] {
            "Belém - Ponta de Pedras",
            "Ponta de Pedras - Belém"});
            this.cmbTrajeto.Location = new System.Drawing.Point(187, 69);
            this.cmbTrajeto.Name = "cmbTrajeto";
            this.cmbTrajeto.Size = new System.Drawing.Size(336, 23);
            this.cmbTrajeto.TabIndex = 2;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(187, 51);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(42, 15);
            this.label22.TabIndex = 1;
            this.label22.Text = "Trajeto";
            // 
            // frmPDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 737);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "frmPDV";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPDV";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPDV_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlJanela;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnF6;
        private System.Windows.Forms.Button btnF3;
        private System.Windows.Forms.Button btnF2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.DateTimePicker dateTimePicker6;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cmbTrajeto;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cmbEmbarcacao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnF5;
        private System.Windows.Forms.Button btnF4;
        private System.Windows.Forms.Button btnF10;
        private System.Windows.Forms.Button btnF9;
        private System.Windows.Forms.Button btnF8;
        private System.Windows.Forms.Button btnF7;
        private System.Windows.Forms.Button btnF12;
        private System.Windows.Forms.Button btnF11;
        private System.Windows.Forms.Panel panel3;
        private Componentes.TextBox.txtBoxBtnLabel txtTipo;
        private Componentes.TextBox.txtBoxLabel txtCPF;
        private Componentes.TextBox.txtBoxLabel txtNome;
        private Componentes.TextBox.txtBoxLabel txtRG;
        private Componentes.TextBox.txtBoxLabel txtPoltrona;
        private Componentes.TextBox.txtBoxLabel txtNacionalidade;
        private Componentes.TextBox.txtBoxLabel txtValorPago;
        private Componentes.TextBox.txtBoxLabel txtValor;
        private Componentes.TextBox.txtBoxLabel txtValorTroco;
        private Componentes.TextBox.txtBoxBtnLabel txtFormaPagamento;
    }
}