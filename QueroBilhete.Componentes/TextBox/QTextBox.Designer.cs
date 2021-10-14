
namespace QueroBilhete.Componentes.TextBox
{
    partial class QTextBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn1 = new System.Windows.Forms.Button();
            this.lblDireita = new System.Windows.Forms.Label();
            this.labelEsquerda = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.lblDireita);
            this.panel1.Controls.Add(this.labelEsquerda);
            this.panel1.Controls.Add(this.txtBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 26);
            this.panel1.TabIndex = 0;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(206, 0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(24, 25);
            this.btn1.TabIndex = 2;
            this.btn1.TabStop = false;
            this.btn1.Text = "...";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lblDireita
            // 
            this.lblDireita.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDireita.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDireita.Location = new System.Drawing.Point(232, 3);
            this.lblDireita.Name = "lblDireita";
            this.lblDireita.Size = new System.Drawing.Size(421, 18);
            this.lblDireita.TabIndex = 3;
            this.lblDireita.Text = "label2";
            this.lblDireita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEsquerda
            // 
            this.labelEsquerda.Location = new System.Drawing.Point(8, 3);
            this.labelEsquerda.Name = "labelEsquerda";
            this.labelEsquerda.Size = new System.Drawing.Size(128, 18);
            this.labelEsquerda.TabIndex = 0;
            this.labelEsquerda.Text = "label1";
            this.labelEsquerda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(152, 1);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(53, 23);
            this.txtBox.TabIndex = 1;
            this.txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            this.txtBox.Leave += new System.EventHandler(this.txtBox_Leave);
            this.txtBox.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_Validating);
            // 
            // QTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "QTextBox";
            this.Size = new System.Drawing.Size(661, 26);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDireita;
        private System.Windows.Forms.Label labelEsquerda;
        private System.Windows.Forms.TextBox txtBox;
        public System.Windows.Forms.Button btn1;
    }
}
