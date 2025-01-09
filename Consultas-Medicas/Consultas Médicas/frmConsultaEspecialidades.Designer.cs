namespace Consultas_Médicas
{
    partial class frmConsultaEspecialidades
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
            this.lblNovaEspecialidadeMedico = new System.Windows.Forms.Label();
            this.lvwExibirEspecialidades = new System.Windows.Forms.ListView();
            this.chEspecialidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtNovaEspecialidade = new System.Windows.Forms.TextBox();
            this.btnAdicionarEspecialidade = new System.Windows.Forms.Button();
            this.btnRemoverEspecialidade = new System.Windows.Forms.Button();
            this.gbCadastrarRemoverEspecialidade = new System.Windows.Forms.GroupBox();
            this.gbCadastrarRemoverEspecialidade.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNovaEspecialidadeMedico
            // 
            this.lblNovaEspecialidadeMedico.AutoSize = true;
            this.lblNovaEspecialidadeMedico.Location = new System.Drawing.Point(3, 22);
            this.lblNovaEspecialidadeMedico.Name = "lblNovaEspecialidadeMedico";
            this.lblNovaEspecialidadeMedico.Size = new System.Drawing.Size(76, 13);
            this.lblNovaEspecialidadeMedico.TabIndex = 0;
            this.lblNovaEspecialidadeMedico.Text = "Especialidade:";
            // 
            // lvwExibirEspecialidades
            // 
            this.lvwExibirEspecialidades.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chEspecialidade});
            this.lvwExibirEspecialidades.FullRowSelect = true;
            this.lvwExibirEspecialidades.HideSelection = false;
            this.lvwExibirEspecialidades.Location = new System.Drawing.Point(6, 45);
            this.lvwExibirEspecialidades.MultiSelect = false;
            this.lvwExibirEspecialidades.Name = "lvwExibirEspecialidades";
            this.lvwExibirEspecialidades.Size = new System.Drawing.Size(189, 201);
            this.lvwExibirEspecialidades.TabIndex = 1;
            this.lvwExibirEspecialidades.UseCompatibleStateImageBehavior = false;
            this.lvwExibirEspecialidades.View = System.Windows.Forms.View.Details;
            // 
            // chEspecialidade
            // 
            this.chEspecialidade.Text = "Especialidade";
            this.chEspecialidade.Width = 180;
            // 
            // txtNovaEspecialidade
            // 
            this.txtNovaEspecialidade.Location = new System.Drawing.Point(95, 19);
            this.txtNovaEspecialidade.Name = "txtNovaEspecialidade";
            this.txtNovaEspecialidade.Size = new System.Drawing.Size(100, 20);
            this.txtNovaEspecialidade.TabIndex = 2;
            // 
            // btnAdicionarEspecialidade
            // 
            this.btnAdicionarEspecialidade.Location = new System.Drawing.Point(3, 252);
            this.btnAdicionarEspecialidade.Name = "btnAdicionarEspecialidade";
            this.btnAdicionarEspecialidade.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarEspecialidade.TabIndex = 3;
            this.btnAdicionarEspecialidade.Text = "Adicionar";
            this.btnAdicionarEspecialidade.UseVisualStyleBackColor = true;
            this.btnAdicionarEspecialidade.Click += new System.EventHandler(this.btnAdicionarEspecialidade_Click_1);
            // 
            // btnRemoverEspecialidade
            // 
            this.btnRemoverEspecialidade.Location = new System.Drawing.Point(120, 252);
            this.btnRemoverEspecialidade.Name = "btnRemoverEspecialidade";
            this.btnRemoverEspecialidade.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverEspecialidade.TabIndex = 4;
            this.btnRemoverEspecialidade.Text = "Remover";
            this.btnRemoverEspecialidade.UseVisualStyleBackColor = true;
            this.btnRemoverEspecialidade.Click += new System.EventHandler(this.btnRemoverEspecialidade_Click);
            // 
            // gbCadastrarRemoverEspecialidade
            // 
            this.gbCadastrarRemoverEspecialidade.Controls.Add(this.lblNovaEspecialidadeMedico);
            this.gbCadastrarRemoverEspecialidade.Controls.Add(this.btnRemoverEspecialidade);
            this.gbCadastrarRemoverEspecialidade.Controls.Add(this.lvwExibirEspecialidades);
            this.gbCadastrarRemoverEspecialidade.Controls.Add(this.btnAdicionarEspecialidade);
            this.gbCadastrarRemoverEspecialidade.Controls.Add(this.txtNovaEspecialidade);
            this.gbCadastrarRemoverEspecialidade.Location = new System.Drawing.Point(12, 12);
            this.gbCadastrarRemoverEspecialidade.Name = "gbCadastrarRemoverEspecialidade";
            this.gbCadastrarRemoverEspecialidade.Size = new System.Drawing.Size(204, 288);
            this.gbCadastrarRemoverEspecialidade.TabIndex = 5;
            this.gbCadastrarRemoverEspecialidade.TabStop = false;
            this.gbCadastrarRemoverEspecialidade.Text = "Cadastrar e Remover Especialidade";
            // 
            // frmConsultaEspecialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbCadastrarRemoverEspecialidade);
            this.Name = "frmConsultaEspecialidades";
            this.Text = "frmConsultaEspecialidades";
            this.gbCadastrarRemoverEspecialidade.ResumeLayout(false);
            this.gbCadastrarRemoverEspecialidade.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNovaEspecialidadeMedico;
        private System.Windows.Forms.ListView lvwExibirEspecialidades;
        private System.Windows.Forms.ColumnHeader chEspecialidade;
        private System.Windows.Forms.TextBox txtNovaEspecialidade;
        private System.Windows.Forms.Button btnAdicionarEspecialidade;
        private System.Windows.Forms.Button btnRemoverEspecialidade;
        private System.Windows.Forms.GroupBox gbCadastrarRemoverEspecialidade;
    }
}