
namespace QueroBilhete.Componentes.TextBox
{
    partial class txtBoxLabel
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
            this.labelEsquerda = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelEsquerda);
            this.panel1.Controls.Add(this.txtBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 22);
            this.panel1.TabIndex = 1;
            // 
            // labelEsquerda
            // 
            this.labelEsquerda.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEsquerda.Location = new System.Drawing.Point(8, 3);
            this.labelEsquerda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEsquerda.Name = "labelEsquerda";
            this.labelEsquerda.Size = new System.Drawing.Size(150, 16);
            this.labelEsquerda.TabIndex = 0;
            this.labelEsquerda.Text = "label1";
            this.labelEsquerda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBox
            // 
            this.txtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox.Location = new System.Drawing.Point(174, 1);
            this.txtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(53, 21);
            this.txtBox.TabIndex = 1;
            this.txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            this.txtBox.Leave += new System.EventHandler(this.txtBox_Leave);
            this.txtBox.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_Validating);
            // 
            // txtBoxLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "txtBoxLabel";
            this.Size = new System.Drawing.Size(662, 22);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelEsquerda;
        private System.Windows.Forms.TextBox txtBox;
    }
}
