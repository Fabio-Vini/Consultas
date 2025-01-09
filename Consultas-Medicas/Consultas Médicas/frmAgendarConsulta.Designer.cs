namespace Consultas_Médicas
{
    partial class frmAgendarConsulta
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
            this.cbConsultarDisponibilidade = new System.Windows.Forms.GroupBox();
            this.lblMédicos = new System.Windows.Forms.Label();
            this.lblFiltrarEspecialidade = new System.Windows.Forms.Label();
            this.lvwMedicos = new System.Windows.Forms.ListView();
            this.chNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCrm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEspecialidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chValorHora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpFiltrarDataDisponibilidade = new System.Windows.Forms.DateTimePicker();
            this.lvwHorariosDisponiveisMedico = new System.Windows.Forms.ListView();
            this.chHorarios = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbEspecialidadeMedico = new System.Windows.Forms.ComboBox();
            this.lblFiltrarData = new System.Windows.Forms.Label();
            this.lvwConsultaPaciente = new System.Windows.Forms.ListView();
            this.chNomePaciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCpfPaciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProntuarioPaciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSexoPaciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSaldoPaciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbPacientesCadastrados = new System.Windows.Forms.GroupBox();
            this.txtFiltrarCpfPaciente = new System.Windows.Forms.TextBox();
            this.txtFiltrarNomePaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgendarConsulta = new System.Windows.Forms.Button();
            this.cbConsultarDisponibilidade.SuspendLayout();
            this.gbPacientesCadastrados.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbConsultarDisponibilidade
            // 
            this.cbConsultarDisponibilidade.Controls.Add(this.lblMédicos);
            this.cbConsultarDisponibilidade.Controls.Add(this.lblFiltrarEspecialidade);
            this.cbConsultarDisponibilidade.Controls.Add(this.lvwMedicos);
            this.cbConsultarDisponibilidade.Controls.Add(this.dtpFiltrarDataDisponibilidade);
            this.cbConsultarDisponibilidade.Controls.Add(this.lvwHorariosDisponiveisMedico);
            this.cbConsultarDisponibilidade.Controls.Add(this.cbEspecialidadeMedico);
            this.cbConsultarDisponibilidade.Controls.Add(this.lblFiltrarData);
            this.cbConsultarDisponibilidade.Location = new System.Drawing.Point(350, 12);
            this.cbConsultarDisponibilidade.Name = "cbConsultarDisponibilidade";
            this.cbConsultarDisponibilidade.Size = new System.Drawing.Size(438, 374);
            this.cbConsultarDisponibilidade.TabIndex = 7;
            this.cbConsultarDisponibilidade.TabStop = false;
            this.cbConsultarDisponibilidade.Text = "Médicos e Horários Disponíveis";
            // 
            // lblMédicos
            // 
            this.lblMédicos.AutoSize = true;
            this.lblMédicos.Location = new System.Drawing.Point(9, 47);
            this.lblMédicos.Name = "lblMédicos";
            this.lblMédicos.Size = new System.Drawing.Size(50, 13);
            this.lblMédicos.TabIndex = 1;
            this.lblMédicos.Text = "Médicos:";
            // 
            // lblFiltrarEspecialidade
            // 
            this.lblFiltrarEspecialidade.AutoSize = true;
            this.lblFiltrarEspecialidade.Location = new System.Drawing.Point(9, 24);
            this.lblFiltrarEspecialidade.Name = "lblFiltrarEspecialidade";
            this.lblFiltrarEspecialidade.Size = new System.Drawing.Size(104, 13);
            this.lblFiltrarEspecialidade.TabIndex = 1;
            this.lblFiltrarEspecialidade.Text = "Filtrar Especialidade:";
            // 
            // lvwMedicos
            // 
            this.lvwMedicos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNome,
            this.chCrm,
            this.chEspecialidade,
            this.chValorHora});
            this.lvwMedicos.FullRowSelect = true;
            this.lvwMedicos.HideSelection = false;
            this.lvwMedicos.Location = new System.Drawing.Point(12, 66);
            this.lvwMedicos.MultiSelect = false;
            this.lvwMedicos.Name = "lvwMedicos";
            this.lvwMedicos.Size = new System.Drawing.Size(415, 164);
            this.lvwMedicos.TabIndex = 0;
            this.lvwMedicos.UseCompatibleStateImageBehavior = false;
            this.lvwMedicos.View = System.Windows.Forms.View.Details;
            this.lvwMedicos.SelectedIndexChanged += new System.EventHandler(this.lvwMedicos_SelectedIndexChanged);
            // 
            // chNome
            // 
            this.chNome.Text = "Nome";
            this.chNome.Width = 114;
            // 
            // chCrm
            // 
            this.chCrm.Text = "CRM";
            // 
            // chEspecialidade
            // 
            this.chEspecialidade.Text = "Especialidade";
            this.chEspecialidade.Width = 171;
            // 
            // chValorHora
            // 
            this.chValorHora.Text = "Valor Hora";
            this.chValorHora.Width = 78;
            // 
            // dtpFiltrarDataDisponibilidade
            // 
            this.dtpFiltrarDataDisponibilidade.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtpFiltrarDataDisponibilidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFiltrarDataDisponibilidade.Location = new System.Drawing.Point(119, 240);
            this.dtpFiltrarDataDisponibilidade.Name = "dtpFiltrarDataDisponibilidade";
            this.dtpFiltrarDataDisponibilidade.Size = new System.Drawing.Size(121, 20);
            this.dtpFiltrarDataDisponibilidade.TabIndex = 4;
            this.dtpFiltrarDataDisponibilidade.ValueChanged += new System.EventHandler(this.dtpFiltrarDataDisponibilidade_ValueChanged);
            // 
            // lvwHorariosDisponiveisMedico
            // 
            this.lvwHorariosDisponiveisMedico.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chHorarios});
            this.lvwHorariosDisponiveisMedico.FullRowSelect = true;
            this.lvwHorariosDisponiveisMedico.HideSelection = false;
            this.lvwHorariosDisponiveisMedico.Location = new System.Drawing.Point(12, 266);
            this.lvwHorariosDisponiveisMedico.MultiSelect = false;
            this.lvwHorariosDisponiveisMedico.Name = "lvwHorariosDisponiveisMedico";
            this.lvwHorariosDisponiveisMedico.Size = new System.Drawing.Size(415, 97);
            this.lvwHorariosDisponiveisMedico.TabIndex = 0;
            this.lvwHorariosDisponiveisMedico.UseCompatibleStateImageBehavior = false;
            this.lvwHorariosDisponiveisMedico.View = System.Windows.Forms.View.Details;
            // 
            // chHorarios
            // 
            this.chHorarios.Text = "Horários";
            this.chHorarios.Width = 391;
            // 
            // cbEspecialidadeMedico
            // 
            this.cbEspecialidadeMedico.FormattingEnabled = true;
            this.cbEspecialidadeMedico.Location = new System.Drawing.Point(119, 19);
            this.cbEspecialidadeMedico.Name = "cbEspecialidadeMedico";
            this.cbEspecialidadeMedico.Size = new System.Drawing.Size(121, 21);
            this.cbEspecialidadeMedico.TabIndex = 2;
            this.cbEspecialidadeMedico.SelectedIndexChanged += new System.EventHandler(this.cbEspecialidadeMedico_SelectedIndexChanged);
            // 
            // lblFiltrarData
            // 
            this.lblFiltrarData.AutoSize = true;
            this.lblFiltrarData.Location = new System.Drawing.Point(9, 244);
            this.lblFiltrarData.Name = "lblFiltrarData";
            this.lblFiltrarData.Size = new System.Drawing.Size(61, 13);
            this.lblFiltrarData.TabIndex = 1;
            this.lblFiltrarData.Text = "Filtrar Data:";
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
            this.gbPacientesCadastrados.TabIndex = 8;
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
            // btnAgendarConsulta
            // 
            this.btnAgendarConsulta.Location = new System.Drawing.Point(18, 402);
            this.btnAgendarConsulta.Name = "btnAgendarConsulta";
            this.btnAgendarConsulta.Size = new System.Drawing.Size(759, 23);
            this.btnAgendarConsulta.TabIndex = 9;
            this.btnAgendarConsulta.Text = "Agendar Consulta";
            this.btnAgendarConsulta.UseVisualStyleBackColor = true;
            this.btnAgendarConsulta.Click += new System.EventHandler(this.btnAgendarConsulta_Click);
            // 
            // frmAgendarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.btnAgendarConsulta);
            this.Controls.Add(this.gbPacientesCadastrados);
            this.Controls.Add(this.cbConsultarDisponibilidade);
            this.Name = "frmAgendarConsulta";
            this.Text = "frmAgendarConsulta";
            this.cbConsultarDisponibilidade.ResumeLayout(false);
            this.cbConsultarDisponibilidade.PerformLayout();
            this.gbPacientesCadastrados.ResumeLayout(false);
            this.gbPacientesCadastrados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cbConsultarDisponibilidade;
        private System.Windows.Forms.Label lblMédicos;
        private System.Windows.Forms.Label lblFiltrarEspecialidade;
        private System.Windows.Forms.ListView lvwMedicos;
        private System.Windows.Forms.ColumnHeader chNome;
        private System.Windows.Forms.ColumnHeader chEspecialidade;
        private System.Windows.Forms.ColumnHeader chValorHora;
        private System.Windows.Forms.DateTimePicker dtpFiltrarDataDisponibilidade;
        private System.Windows.Forms.ListView lvwHorariosDisponiveisMedico;
        private System.Windows.Forms.ColumnHeader chHorarios;
        private System.Windows.Forms.ComboBox cbEspecialidadeMedico;
        private System.Windows.Forms.Label lblFiltrarData;
        private System.Windows.Forms.ListView lvwConsultaPaciente;
        private System.Windows.Forms.ColumnHeader chNomePaciente;
        private System.Windows.Forms.ColumnHeader chCpfPaciente;
        private System.Windows.Forms.ColumnHeader chProntuarioPaciente;
        private System.Windows.Forms.ColumnHeader chSexoPaciente;
        private System.Windows.Forms.ColumnHeader chSaldoPaciente;
        private System.Windows.Forms.GroupBox gbPacientesCadastrados;
        private System.Windows.Forms.ColumnHeader chCrm;
        private System.Windows.Forms.TextBox txtFiltrarCpfPaciente;
        private System.Windows.Forms.TextBox txtFiltrarNomePaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgendarConsulta;
    }
}