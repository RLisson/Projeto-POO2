namespace Trabalho_2
{
    partial class Principal
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
            this.btnCadastroAlunos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastroAlunos
            // 
            this.btnCadastroAlunos.Location = new System.Drawing.Point(59, 52);
            this.btnCadastroAlunos.Name = "btnCadastroAlunos";
            this.btnCadastroAlunos.Size = new System.Drawing.Size(75, 46);
            this.btnCadastroAlunos.TabIndex = 0;
            this.btnCadastroAlunos.Text = "Cadastro Alunos";
            this.btnCadastroAlunos.UseVisualStyleBackColor = true;
            this.btnCadastroAlunos.Click += new System.EventHandler(this.btnCadastroAlunos_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastroAlunos);
            this.Name = "Principal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroAlunos;
    }
}

