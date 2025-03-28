
namespace matriz_2_treino
{
    partial class frmMatriz
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
            this.btnExibir = new System.Windows.Forms.Button();
            this.lblExibir = new System.Windows.Forms.Label();
            this.txtExibirMaior = new System.Windows.Forms.TextBox();
            this.txtMatriz = new System.Windows.Forms.TextBox();
            this.txtValores = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(321, 285);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 0;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // lblExibir
            // 
            this.lblExibir.AutoSize = true;
            this.lblExibir.Location = new System.Drawing.Point(177, 245);
            this.lblExibir.Name = "lblExibir";
            this.lblExibir.Size = new System.Drawing.Size(108, 13);
            this.lblExibir.TabIndex = 1;
            this.lblExibir.Text = "Exiba o número maior";
            // 
            // txtExibirMaior
            // 
            this.txtExibirMaior.Location = new System.Drawing.Point(311, 238);
            this.txtExibirMaior.Name = "txtExibirMaior";
            this.txtExibirMaior.Size = new System.Drawing.Size(100, 20);
            this.txtExibirMaior.TabIndex = 2;
            // 
            // txtMatriz
            // 
            this.txtMatriz.Location = new System.Drawing.Point(301, 65);
            this.txtMatriz.Name = "txtMatriz";
            this.txtMatriz.Size = new System.Drawing.Size(128, 20);
            this.txtMatriz.TabIndex = 3;
            this.txtMatriz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatriz_KeyPress);
            // 
            // txtValores
            // 
            this.txtValores.Location = new System.Drawing.Point(301, 117);
            this.txtValores.Multiline = true;
            this.txtValores.Name = "txtValores";
            this.txtValores.Size = new System.Drawing.Size(128, 94);
            this.txtValores.TabIndex = 4;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(504, 89);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // frmMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtValores);
            this.Controls.Add(this.txtMatriz);
            this.Controls.Add(this.txtExibirMaior);
            this.Controls.Add(this.lblExibir);
            this.Controls.Add(this.btnExibir);
            this.Name = "frmMatriz";
            this.Text = "Matriz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Label lblExibir;
        private System.Windows.Forms.TextBox txtExibirMaior;
        private System.Windows.Forms.TextBox txtMatriz;
        private System.Windows.Forms.TextBox txtValores;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnEnviar;
    }
}

