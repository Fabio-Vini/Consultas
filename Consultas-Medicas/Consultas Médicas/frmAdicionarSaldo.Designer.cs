namespace Consultas_Médicas
{
    partial class frmAdicionarSaldo
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
            this.gbPacientesCadastrados = new System.Windows.Forms.GroupBox();
            this.txtFiltrarCpfPaciente = new System.Windows.Forms.TextBox();
            this.txtFiltrarNomePaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvwConsultaPaciente = new System.Windows.Forms.ListView();
            this.chNomePaciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCpfPaciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProntuarioPaciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSexoPaciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSaldoPaciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbAdicionarSaldo = new System.Windows.Forms.GroupBox();
            this.btnAdicionarSaldo = new System.Windows.Forms.Button();
            this.txtAdicionarSaldoPaciente = new System.Windows.Forms.TextBox();
            this.lblAdicionarSaldoPaciente = new System.Windows.Forms.Label();
            this.gbRemoverSaldo = new System.Windows.Forms.GroupBox();
            this.txtRemoverSaldo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemoverSaldo = new System.Windows.Forms.Button();
            this.gbPacientesCadastrados.SuspendLayout();
            this.gbAdicionarSaldo.SuspendLayout();
            this.gbRemoverSaldo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPacientesCadastrados
            // 
            this.gbPacientesCadastrados.Controls.Add(this.txtFiltrarCpfPaciente);
            this.gbPacientesCadastrados.Controls.Add(this.txtFiltrarNomePaciente);
            this.gbPacientesCadastrados.Controls.Add(this.label2);
            this.gbPacientesCadastrados.Controls.Add(this.label1);
            this.gbPacientesCadastrados.Controls.Add(this.lvwConsultaPaciente);
            this.gbPacientesCadastrados.Location = new System.Drawing.Point(12, 12);
            this.gbPacientesCadastrados.Name = "gbPacientesCadastrados";
            this.gbPacientesCadastrados.Size = new System.Drawing.Size(332, 374);
            this.gbPacientesCadastrados.TabIndex = 9;
            this.gbPacientesCadastrados.TabStop = false;
            this.gbPacientesCadastrados.Text = "Pacientes Cadastrados";
            // 
            // txtFiltrarCpfPaciente
            // 
            this.txtFiltrarCpfPaciente.Location = new System.Drawing.Point(226, 19);
            this.txtFiltrarCpfPaciente.Name = "txtFiltrarCpfPaciente";
            this.txtFiltrarCpfPaciente.Size = new System.Drawing.Size(100, 20);
            this.txtFiltrarCpfPaciente.TabIndex = 10;
            this.txtFiltrarCpfPaciente.TextChanged += new System.EventHandler(this.txtFiltrarCpfPaciente_TextChanged);
            // 
            // txtFiltrarNomePaciente
            // 
            this.txtFiltrarNomePaciente.Location = new System.Drawing.Point(50, 19);
            this.txtFiltrarNomePaciente.Name = "txtFiltrarNomePaciente";
            this.txtFiltrarNomePaciente.Size = new System.Drawing.Size(100, 20);
            this.txtFiltrarNomePaciente.TabIndex = 10;
            this.txtFiltrarNomePaciente.TextChanged += new System.EventHandler(this.txtFiltrarNomePaciente_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome:";
            // 
            // lvwConsultaPaciente
            // 
            this.lvwConsultaPaciente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNomePaciente,
            this.chCpfPaciente,
            this.chProntuarioPaciente,
            this.chSexoPaciente,
            this.chSaldoPaciente});
            this.lvwConsultaPaciente.FullRowSelect = true;
            this.lvwConsultaPaciente.HideSelection = false;
            this.lvwConsultaPaciente.Location = new System.Drawing.Point(6, 47);
            this.lvwConsultaPaciente.MultiSelect = false;
            this.lvwConsultaPaciente.Name = "lvwConsultaPaciente";
            this.lvwConsultaPaciente.Size = new System.Drawing.Size(320, 316);
            this.lvwConsultaPaciente.TabIndex = 8;
            this.lvwConsultaPaciente.UseCompatibleStateImageBehavior = false;
            this.lvwConsultaPaciente.View = System.Windows.Forms.View.Details;
            // 
            // chNomePaciente
            // 
            this.chNomePaciente.Text = "Nome";
            this.chNomePaciente.Width = 75;
            // 
            // chCpfPaciente
            // 
            this.chCpfPaciente.Text = "CPF";
            // 
            // chProntuarioPaciente
            // 
            this.chProntuarioPaciente.Text = "Prontuário";
            // 
            // chSexoPaciente
            // 
            this.chSexoPaciente.Text = "Sexo";
            // 
            // chSaldoPaciente
            // 
            this.chSaldoPaciente.Text = "Saldo";
            // 
            // gbAdicionarSaldo
            // 
            this.gbAdicionarSaldo.Controls.Add(this.btnAdicionarSaldo);
            this.gbAdicionarSaldo.Controls.Add(this.txtAdicionarSaldoPaciente);
            this.gbAdicionarSaldo.Controls.Add(this.lblAdicionarSaldoPaciente);
            this.gbAdicionarSaldo.Location = new System.Drawing.Point(350, 12);
            this.gbAdicionarSaldo.Name = "gbAdicionarSaldo";
            this.gbAdicionarSaldo.Size = new System.Drawing.Size(159, 77);
            this.gbAdicionarSaldo.TabIndex = 10;
            this.gbAdicionarSaldo.TabStop = false;
            this.gbAdicionarSaldo.Text = "Adicionar Saldo";
            // 
            // btnAdicionarSaldo
            // 
            this.btnAdicionarSaldo.Location = new System.Drawing.Point(9, 47);
            this.btnAdicionarSaldo.Name = "btnAdicionarSaldo";
            this.btnAdicionarSaldo.Size = new System.Drawing.Size(140, 23);
            this.btnAdicionarSaldo.TabIndex = 2;
            this.btnAdicionarSaldo.Text = "Adicionar";
            this.btnAdicionarSaldo.UseVisualStyleBackColor = true;
            this.btnAdicionarSaldo.Click += new System.EventHandler(this.btnAdicionarSaldo_Click);
            // 
            // txtAdicionarSaldoPaciente
            // 
            this.txtAdicionarSaldoPaciente.Location = new System.Drawing.Point(49, 20);
            this.txtAdicionarSaldoPaciente.Name = "txtAdicionarSaldoPaciente";
            this.txtAdicionarSaldoPaciente.Size = new System.Drawing.Size(100, 20);
            this.txtAdicionarSaldoPaciente.TabIndex = 1;
            // 
            // lblAdicionarSaldoPaciente
            // 
            this.lblAdicionarSaldoPaciente.AutoSize = true;
            this.lblAdicionarSaldoPaciente.Location = new System.Drawing.Point(6, 23);
            this.lblAdicionarSaldoPaciente.Name = "lblAdicionarSaldoPaciente";
            this.lblAdicionarSaldoPaciente.Size = new System.Drawing.Size(37, 13);
            this.lblAdicionarSaldoPaciente.TabIndex = 0;
            this.lblAdicionarSaldoPaciente.Text = "Saldo:";
            // 
            // gbRemoverSaldo
            // 
            this.gbRemoverSaldo.Controls.Add(this.btnRemoverSaldo);
            this.gbRemoverSaldo.Controls.Add(this.txtRemoverSaldo);
            this.gbRemoverSaldo.Controls.Add(this.label3);
            this.gbRemoverSaldo.Location = new System.Drawing.Point(350, 95);
            this.gbRemoverSaldo.Name = "gbRemoverSaldo";
            this.gbRemoverSaldo.Size = new System.Drawing.Size(159, 77);
            this.gbRemoverSaldo.TabIndex = 11;
            this.gbRemoverSaldo.TabStop = false;
            this.gbRemoverSaldo.Text = "Remover Saldo";
            // 
            // txtRemoverSaldo
            // 
            this.txtRemoverSaldo.Location = new System.Drawing.Point(49, 20);
            this.txtRemoverSaldo.Name = "txtRemoverSaldo";
            this.txtRemoverSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtRemoverSaldo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Saldo:";
            // 
            // btnRemoverSaldo
            // 
            this.btnRemoverSaldo.Location = new System.Drawing.Point(9, 46);
            this.btnRemoverSaldo.Name = "btnRemoverSaldo";
            this.btnRemoverSaldo.Size = new System.Drawing.Size(140, 23);
            this.btnRemoverSaldo.TabIndex = 3;
            this.btnRemoverSaldo.Text = "Remover";
            this.btnRemoverSaldo.UseVisualStyleBackColor = true;
            this.btnRemoverSaldo.Click += new System.EventHandler(this.btnRemoverSaldo_Click);
            // 
            // frmAdicionarSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbRemoverSaldo);
            this.Controls.Add(this.gbAdicionarSaldo);
            this.Controls.Add(this.gbPacientesCadastrados);
            this.Name = "frmAdicionarSaldo";
            this.Text = "frmAdicionarSaldo";
            this.gbPacientesCadastrados.ResumeLayout(false);
            this.gbPacientesCadastrados.PerformLayout();
            this.gbAdicionarSaldo.ResumeLayout(false);
            this.gbAdicionarSaldo.PerformLayout();
            this.gbRemoverSaldo.ResumeLayout(false);
            this.gbRemoverSaldo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPacientesCadastrados;
        private System.Windows.Forms.TextBox txtFiltrarCpfPaciente;
        private System.Windows.Forms.TextBox txtFiltrarNomePaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvwConsultaPaciente;
        private System.Windows.Forms.ColumnHeader chNomePaciente;
        private System.Windows.Forms.ColumnHeader chCpfPaciente;
        private System.Windows.Forms.ColumnHeader chProntuarioPaciente;
        private System.Windows.Forms.ColumnHeader chSexoPaciente;
        private System.Windows.Forms.ColumnHeader chSaldoPaciente;
        private System.Windows.Forms.GroupBox gbAdicionarSaldo;
        private System.Windows.Forms.Button btnAdicionarSaldo;
        private System.Windows.Forms.TextBox txtAdicionarSaldoPaciente;
        private System.Windows.Forms.Label lblAdicionarSaldoPaciente;
        private System.Windows.Forms.GroupBox gbRemoverSaldo;
        private System.Windows.Forms.Button btnRemoverSaldo;
        private System.Windows.Forms.TextBox txtRemoverSaldo;
        private System.Windows.Forms.Label label3;
    }
}