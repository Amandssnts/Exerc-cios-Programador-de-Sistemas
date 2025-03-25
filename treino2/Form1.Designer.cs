
namespace treino2
{
    partial class frmMaiorouMenor
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMaiorMenor = new System.Windows.Forms.Button();
            this.txtMaiorMenor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMaiorMenor
            // 
            this.btnMaiorMenor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMaiorMenor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaiorMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaiorMenor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMaiorMenor.Location = new System.Drawing.Point(351, 137);
            this.btnMaiorMenor.Name = "btnMaiorMenor";
            this.btnMaiorMenor.Size = new System.Drawing.Size(100, 30);
            this.btnMaiorMenor.TabIndex = 0;
            this.btnMaiorMenor.Text = "Verificar";
            this.btnMaiorMenor.UseVisualStyleBackColor = false;
            this.btnMaiorMenor.Click += new System.EventHandler(this.btnMaiorMenor_Click);
            // 
            // txtMaiorMenor
            // 
            this.txtMaiorMenor.Location = new System.Drawing.Point(351, 94);
            this.txtMaiorMenor.Name = "txtMaiorMenor";
            this.txtMaiorMenor.Size = new System.Drawing.Size(100, 20);
            this.txtMaiorMenor.TabIndex = 1;
            // 
            // frmMaiorouMenor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMaiorMenor);
            this.Controls.Add(this.btnMaiorMenor);
            this.Name = "frmMaiorouMenor";
            this.Text = "Maior ou menor que 10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMaiorMenor;
        private System.Windows.Forms.TextBox txtMaiorMenor;
    }
}

