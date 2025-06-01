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
            this.btnCadastroProfessores = new System.Windows.Forms.Button();
            this.btnCadastroTurmas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastroAlunos
            // 
            this.btnCadastroAlunos.Location = new System.Drawing.Point(79, 64);
            this.btnCadastroAlunos.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastroAlunos.Name = "btnCadastroAlunos";
            this.btnCadastroAlunos.Size = new System.Drawing.Size(100, 57);
            this.btnCadastroAlunos.TabIndex = 0;
            this.btnCadastroAlunos.Text = "Cadastro Alunos";
            this.btnCadastroAlunos.UseVisualStyleBackColor = true;
            this.btnCadastroAlunos.Click += new System.EventHandler(this.btnCadastroAlunos_Click);
            // 
            // btnCadastroProfessores
            // 
            this.btnCadastroProfessores.Location = new System.Drawing.Point(187, 64);
            this.btnCadastroProfessores.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastroProfessores.Name = "btnCadastroProfessores";
            this.btnCadastroProfessores.Size = new System.Drawing.Size(100, 57);
            this.btnCadastroProfessores.TabIndex = 1;
            this.btnCadastroProfessores.Text = "Cadastro Professores";
            this.btnCadastroProfessores.UseVisualStyleBackColor = true;
            this.btnCadastroProfessores.Click += new System.EventHandler(this.btnCadastroProfessores_Click);
            // 
            // btnCadastroTurmas
            // 
            this.btnCadastroTurmas.Location = new System.Drawing.Point(295, 64);
            this.btnCadastroTurmas.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastroTurmas.Name = "btnCadastroTurmas";
            this.btnCadastroTurmas.Size = new System.Drawing.Size(100, 57);
            this.btnCadastroTurmas.TabIndex = 2;
            this.btnCadastroTurmas.Text = "Cadastro Turmas";
            this.btnCadastroTurmas.UseVisualStyleBackColor = true;
            this.btnCadastroTurmas.Click += new System.EventHandler(this.btnCadastroTurmas_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnCadastroTurmas);
            this.Controls.Add(this.btnCadastroProfessores);
            this.Controls.Add(this.btnCadastroAlunos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Principal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroAlunos;
        private System.Windows.Forms.Button btnCadastroProfessores;
        private System.Windows.Forms.Button btnCadastroTurmas;
    }
}

