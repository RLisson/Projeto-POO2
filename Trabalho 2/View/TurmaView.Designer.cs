namespace Trabalho_2.View
{
    partial class TurmaView
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.dgvProfessor = new System.Windows.Forms.DataGridView();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCapacidade = new System.Windows.Forms.TextBox();
            this.btnAdicionarTurma = new System.Windows.Forms.Button();
            this.btnExibirTurmas = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnConsultarPorProfessor = new System.Windows.Forms.Button();
            this.btnRemoverTurma = new System.Windows.Forms.Button();
            this.dgvTurmas = new System.Windows.Forms.DataGridView();
            this.btnAdicionarAluno = new System.Windows.Forms.Button();
            this.txtAluno = new System.Windows.Forms.TextBox();
            this.btnSelecionarAluno = new System.Windows.Forms.Button();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurmas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Professor";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(221, 67);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(221, 98);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(142, 22);
            this.txtNome.TabIndex = 4;
            // 
            // txtProfessor
            // 
            this.txtProfessor.Location = new System.Drawing.Point(221, 129);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.ReadOnly = true;
            this.txtProfessor.Size = new System.Drawing.Size(54, 22);
            this.txtProfessor.TabIndex = 5;
            // 
            // dgvProfessor
            // 
            this.dgvProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfessor.Location = new System.Drawing.Point(548, 26);
            this.dgvProfessor.Name = "dgvProfessor";
            this.dgvProfessor.RowHeadersWidth = 51;
            this.dgvProfessor.RowTemplate.Height = 24;
            this.dgvProfessor.Size = new System.Drawing.Size(240, 150);
            this.dgvProfessor.TabIndex = 6;
            this.dgvProfessor.Visible = false;
            this.dgvProfessor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfessoresCellDoubleClick);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(288, 129);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(99, 23);
            this.btnSelecionar.TabIndex = 7;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Capacidade";
            // 
            // txtCapacidade
            // 
            this.txtCapacidade.Location = new System.Drawing.Point(221, 157);
            this.txtCapacidade.Name = "txtCapacidade";
            this.txtCapacidade.Size = new System.Drawing.Size(88, 22);
            this.txtCapacidade.TabIndex = 9;
            // 
            // btnAdicionarTurma
            // 
            this.btnAdicionarTurma.Location = new System.Drawing.Point(96, 222);
            this.btnAdicionarTurma.Name = "btnAdicionarTurma";
            this.btnAdicionarTurma.Size = new System.Drawing.Size(119, 23);
            this.btnAdicionarTurma.TabIndex = 10;
            this.btnAdicionarTurma.Text = "Adicionar turma";
            this.btnAdicionarTurma.UseVisualStyleBackColor = true;
            this.btnAdicionarTurma.Click += new System.EventHandler(this.btnAdicionarTurma_Click);
            // 
            // btnExibirTurmas
            // 
            this.btnExibirTurmas.Location = new System.Drawing.Point(96, 251);
            this.btnExibirTurmas.Name = "btnExibirTurmas";
            this.btnExibirTurmas.Size = new System.Drawing.Size(119, 23);
            this.btnExibirTurmas.TabIndex = 11;
            this.btnExibirTurmas.Text = "Exibir turmas";
            this.btnExibirTurmas.UseVisualStyleBackColor = true;
            this.btnExibirTurmas.Click += new System.EventHandler(this.btnExibirTurmas_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(96, 282);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(119, 23);
            this.btnConsultar.TabIndex = 12;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnConsultarPorProfessor
            // 
            this.btnConsultarPorProfessor.Location = new System.Drawing.Point(96, 311);
            this.btnConsultarPorProfessor.Name = "btnConsultarPorProfessor";
            this.btnConsultarPorProfessor.Size = new System.Drawing.Size(119, 40);
            this.btnConsultarPorProfessor.TabIndex = 13;
            this.btnConsultarPorProfessor.Text = "Consultar por Professor";
            this.btnConsultarPorProfessor.UseVisualStyleBackColor = true;
            this.btnConsultarPorProfessor.Click += new System.EventHandler(this.btnConsultarPorProfessor_Click);
            // 
            // btnRemoverTurma
            // 
            this.btnRemoverTurma.Location = new System.Drawing.Point(96, 357);
            this.btnRemoverTurma.Name = "btnRemoverTurma";
            this.btnRemoverTurma.Size = new System.Drawing.Size(119, 23);
            this.btnRemoverTurma.TabIndex = 14;
            this.btnRemoverTurma.Text = "Remover turma";
            this.btnRemoverTurma.UseVisualStyleBackColor = true;
            this.btnRemoverTurma.Click += new System.EventHandler(this.btnRemoverTurma_Click);
            // 
            // dgvTurmas
            // 
            this.dgvTurmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurmas.Location = new System.Drawing.Point(548, 182);
            this.dgvTurmas.Name = "dgvTurmas";
            this.dgvTurmas.RowHeadersWidth = 51;
            this.dgvTurmas.RowTemplate.Height = 24;
            this.dgvTurmas.Size = new System.Drawing.Size(240, 150);
            this.dgvTurmas.TabIndex = 15;
            this.dgvTurmas.Visible = false;
            this.dgvTurmas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurmasCellDoubleClick);
            this.dgvTurmas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvTurmasKeyDown);
            // 
            // btnAdicionarAluno
            // 
            this.btnAdicionarAluno.Location = new System.Drawing.Point(330, 311);
            this.btnAdicionarAluno.Name = "btnAdicionarAluno";
            this.btnAdicionarAluno.Size = new System.Drawing.Size(119, 40);
            this.btnAdicionarAluno.TabIndex = 16;
            this.btnAdicionarAluno.Text = "Adicionar aluno";
            this.btnAdicionarAluno.UseVisualStyleBackColor = true;
            // 
            // txtAluno
            // 
            this.txtAluno.Location = new System.Drawing.Point(330, 292);
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.ReadOnly = true;
            this.txtAluno.Size = new System.Drawing.Size(119, 22);
            this.txtAluno.TabIndex = 17;
            // 
            // btnSelecionarAluno
            // 
            this.btnSelecionarAluno.Location = new System.Drawing.Point(455, 292);
            this.btnSelecionarAluno.Name = "btnSelecionarAluno";
            this.btnSelecionarAluno.Size = new System.Drawing.Size(99, 23);
            this.btnSelecionarAluno.TabIndex = 18;
            this.btnSelecionarAluno.Text = "Selecionar";
            this.btnSelecionarAluno.UseVisualStyleBackColor = true;
            this.btnSelecionarAluno.Click += new System.EventHandler(this.btnSelecionarAluno_Click);
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Location = new System.Drawing.Point(302, 29);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.RowHeadersWidth = 51;
            this.dgvAlunos.RowTemplate.Height = 24;
            this.dgvAlunos.Size = new System.Drawing.Size(240, 150);
            this.dgvAlunos.TabIndex = 19;
            this.dgvAlunos.Visible = false;
            this.dgvAlunos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunosCellDoubleClick);
            this.dgvAlunos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvAlunosKeyDown);
            // 
            // TurmaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAlunos);
            this.Controls.Add(this.btnSelecionarAluno);
            this.Controls.Add(this.txtAluno);
            this.Controls.Add(this.btnAdicionarAluno);
            this.Controls.Add(this.dgvTurmas);
            this.Controls.Add(this.btnRemoverTurma);
            this.Controls.Add(this.btnConsultarPorProfessor);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnExibirTurmas);
            this.Controls.Add(this.btnAdicionarTurma);
            this.Controls.Add(this.txtCapacidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.dgvProfessor);
            this.Controls.Add(this.txtProfessor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TurmaView";
            this.Text = "TurmaView";
            this.Load += new System.EventHandler(this.TurmaView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurmas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.DataGridView dgvProfessor;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCapacidade;
        private System.Windows.Forms.Button btnAdicionarTurma;
        private System.Windows.Forms.Button btnExibirTurmas;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnConsultarPorProfessor;
        private System.Windows.Forms.Button btnRemoverTurma;
        private System.Windows.Forms.DataGridView dgvTurmas;
        private System.Windows.Forms.Button btnAdicionarAluno;
        private System.Windows.Forms.TextBox txtAluno;
        private System.Windows.Forms.Button btnSelecionarAluno;
        private System.Windows.Forms.DataGridView dgvAlunos;
    }
}