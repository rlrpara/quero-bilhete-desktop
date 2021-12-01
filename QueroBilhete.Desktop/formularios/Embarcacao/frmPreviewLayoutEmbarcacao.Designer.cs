namespace QueroBilhete.Desktop.formularios.Embarcacao
{
    partial class frmPreviewLayoutEmbarcacao
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
            this.panelSelecaoAcentos = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelSelecaoAcentos
            // 
            this.panelSelecaoAcentos.AutoScroll = true;
            this.panelSelecaoAcentos.AutoSize = true;
            this.panelSelecaoAcentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSelecaoAcentos.Location = new System.Drawing.Point(0, 0);
            this.panelSelecaoAcentos.Name = "panelSelecaoAcentos";
            this.panelSelecaoAcentos.Size = new System.Drawing.Size(1147, 735);
            this.panelSelecaoAcentos.TabIndex = 1;
            // 
            // frmPreviewLayoutEmbarcacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 735);
            this.Controls.Add(this.panelSelecaoAcentos);
            this.KeyPreview = true;
            this.Name = "frmPreviewLayoutEmbarcacao";
            this.Text = "frmPreviewLayoutEmbarcacao";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPreviewLayoutEmbarcacao_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSelecaoAcentos;
    }
}