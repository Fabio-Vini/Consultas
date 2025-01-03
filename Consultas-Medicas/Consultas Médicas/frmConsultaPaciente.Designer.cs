namespace Consultas_Médicas
{
    partial class frmConsultaPaciente
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
            this.lvwConsultaPaciente = new System.Windows.Forms.ListView();
            this.chNomePaciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCpfPaciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProntuarioPaciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSexoPaciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLogradouroPaciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCidadePaciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEstadoPaciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPaisPaciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSaldoPaciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbConsultarPacientes = new System.Windows.Forms.GroupBox();
            this.txtFiltrarCpfPaciente = new System.Windows.Forms.TextBox();
            this.txtFiltrarNomePaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbConsultarPacientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwConsultaPaciente
            // 
            this.lvwConsultaPaciente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNomePaciente,
            this.chCpfPaciente,
            this.chProntuarioPaciente,
            this.chSexoPaciente,
            this.chLogradouroPaciente,
            this.chCidadePaciente,
            this.chEstadoPaciente,
            this.chPaisPaciente,
            this.chSaldoPaciente});
            this.lvwConsultaPaciente.FullRowSelect = true;
            this.lvwConsultaPaciente.HideSelection = false;
            this.lvwConsultaPaciente.Location = new System.Drawing.Point(9, 45);
            this.lvwConsultaPaciente.MultiSelect = false;
            this.lvwConsultaPaciente.Name = "lvwConsultaPaciente";
            this.lvwConsultaPaciente.Size = new System.Drawing.Size(758, 248);
            this.lvwConsultaPaciente.TabIndex = 0;
            this.lvwConsultaPaciente.UseCompatibleStateImageBehavior = false;
            this.lvwConsultaPaciente.View = System.Windows.Forms.View.Details;
            // 
            // chNomePaciente
            // 
            this.chNomePaciente.Text = "Nome";
            this.chNomePaciente.Width = 87;
            // 
            // chCpfPaciente
            // 
            this.chCpfPaciente.Text = "CPF";
            // 
            // chProntuarioPaciente
            // 
            this.chProntuarioPaciente.Text = "Prontuário";
            this.chProntuarioPaciente.Width = 74;
            // 
            // chSexoPaciente
            // 
            this.chSexoPaciente.Text = "Sexo";
            // 
            // chLogradouroPaciente
            // 
            this.chLogradouroPaciente.DisplayIndex = 8;
            this.chLogradouroPaciente.Text = "Logradouro";
            this.chLogradouroPaciente.Width = 128;
            // 
            // chCidadePaciente
            // 
            this.chCidadePaciente.Text = "Cidade";
            this.chCidadePaciente.Width = 82;
            // 
            // chEstadoPaciente
            // 
            this.chEstadoPaciente.Text = "Paciente";
            this.chEstadoPaciente.Width = 81;
            // 
            // chPaisPaciente
            // 
            this.chPaisPaciente.Text = "País";
            // 
            // chSaldoPaciente
            // 
            this.chSaldoPaciente.DisplayIndex = 4;
            this.chSaldoPaciente.Text = "Saldo";
            // 
            // gbConsultarPacientes
            // 
            this.gbConsultarPacientes.Controls.Add(this.txtFiltrarCpfPaciente);
            this.gbConsultarPacientes.Controls.Add(this.lvwConsultaPaciente);
            this.gbConsultarPacientes.Controls.Add(this.txtFiltrarNomePaciente);
            this.gbConsultarPacientes.Controls.Add(this.label2);
            this.gbConsultarPacientes.Controls.Add(this.label1);
            this.gbConsultarPacientes.Location = new System.Drawing.Point(12, 12);
            this.gbConsultarPacientes.Name = "gbConsultarPacientes";
            this.gbConsultarPacientes.Size = new System.Drawing.Size(776, 307);
            this.gbConsultarPacientes.TabIndex = 9;
            this.gbConsultarPacientes.TabStop = false;
            this.gbConsultarPacientes.Text = "Consultar Pacientes";
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
            // frmConsultaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbConsultarPacientes);
            this.Name = "frmConsultaPaciente";
            this.Text = "frmConsultaPaciente";
            this.gbConsultarPacientes.ResumeLayout(false);
            this.gbConsultarPacientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwConsultaPaciente;
        private System.Windows.Forms.ColumnHeader chNomePaciente;
        private System.Windows.Forms.ColumnHeader chProntuarioPaciente;
        private System.Windows.Forms.ColumnHeader chSexoPaciente;
        private System.Windows.Forms.ColumnHeader chSaldoPaciente;
        private System.Windows.Forms.ColumnHeader chCpfPaciente;
        private System.Windows.Forms.ColumnHeader chCidadePaciente;
        private System.Windows.Forms.ColumnHeader chEstadoPaciente;
        private System.Windows.Forms.ColumnHeader chPaisPaciente;
        private System.Windows.Forms.ColumnHeader chLogradouroPaciente;
        private System.Windows.Forms.GroupBox gbConsultarPacientes;
        private System.Windows.Forms.TextBox txtFiltrarCpfPaciente;
        private System.Windows.Forms.TextBox txtFiltrarNomePaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}