namespace Trabalho_2.View
{
    partial class AlunoView
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnConsultaMatricula = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(114, 35);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(77, 20);
            this.txtId.TabIndex = 1;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(114, 68);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(165, 20);
            this.txtNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(114, 101);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(2);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(165, 20);
            this.txtCPF.TabIndex = 5;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(114, 136);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(80, 20);
            this.txtMatricula.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Matricula";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(64, 193);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(88, 19);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(191, 193);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(88, 19);
            this.btnRemover.TabIndex = 9;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(191, 216);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(88, 19);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "Consultar ID";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnConsultaMatricula
            // 
            this.btnConsultaMatricula.Location = new System.Drawing.Point(191, 239);
            this.btnConsultaMatricula.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultaMatricula.Name = "btnConsultaMatricula";
            this.btnConsultaMatricula.Size = new System.Drawing.Size(88, 39);
            this.btnConsultaMatricula.TabIndex = 11;
            this.btnConsultaMatricula.Text = "Consulta Matricula";
            this.btnConsultaMatricula.UseVisualStyleBackColor = true;
            this.btnConsultaMatricula.Click += new System.EventHandler(this.btnConsultaMatricula_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(64, 239);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(88, 23);
            this.btnAtualizar.TabIndex = 12;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(64, 216);
            this.btnExibir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(88, 19);
            this.btnExibir.TabIndex = 13;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Location = new System.Drawing.Point(-3, -2);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.Size = new System.Drawing.Size(423, 368);
            this.dgvAlunos.TabIndex = 14;
            this.dgvAlunos.Visible = false;
            this.dgvAlunos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunosCellContentDoubleClick);
            this.dgvAlunos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunosCelltDoubleClick);
            this.dgvAlunos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvAlunosKeyDown);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(64, 266);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(88, 23);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // AlunoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 366);
            this.Controls.Add(this.dgvAlunos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnConsultaMatricula);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AlunoView";
            this.Text = "Alunos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnConsultaMatricula;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.Button btnLimpar;
    }
}