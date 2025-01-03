namespace Consultas_Médicas
{
    partial class frmConsultarDisponibilidade
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
            this.lvwMedicos = new System.Windows.Forms.ListView();
            this.chNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCrm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEspecialidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chValorHora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwHorariosDisponiveisMedico = new System.Windows.Forms.ListView();
            this.chHorarios = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblFiltrarEspecialidade = new System.Windows.Forms.Label();
            this.cbEspecialidadeMedico = new System.Windows.Forms.ComboBox();
            this.dtpFiltrarDataDisponibilidade = new System.Windows.Forms.DateTimePicker();
            this.lblFiltrarData = new System.Windows.Forms.Label();
            this.lblAgendarConsulta = new System.Windows.Forms.Button();
            this.cbConsultarDisponibilidade = new System.Windows.Forms.GroupBox();
            this.lblMédicos = new System.Windows.Forms.Label();
            this.cbConsultarDisponibilidade.SuspendLayout();
            this.SuspendLayout();
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
            this.lvwMedicos.Location = new System.Drawing.Point(16, 81);
            this.lvwMedicos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvwMedicos.MultiSelect = false;
            this.lvwMedicos.Name = "lvwMedicos";
            this.lvwMedicos.Size = new System.Drawing.Size(552, 201);
            this.lvwMedicos.TabIndex = 0;
            this.lvwMedicos.UseCompatibleStateImageBehavior = false;
            this.lvwMedicos.View = System.Windows.Forms.View.Details;
            this.lvwMedicos.SelectedIndexChanged += new System.EventHandler(this.lvwMedicos_SelectedIndexChanged_1);
            // 
            // chNome
            // 
            this.chNome.Text = "Nome";
            this.chNome.Width = 127;
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
            // lvwHorariosDisponiveisMedico
            // 
            this.lvwHorariosDisponiveisMedico.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chHorarios});
            this.lvwHorariosDisponiveisMedico.FullRowSelect = true;
            this.lvwHorariosDisponiveisMedico.HideSelection = false;
            this.lvwHorariosDisponiveisMedico.Location = new System.Drawing.Point(16, 327);
            this.lvwHorariosDisponiveisMedico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvwHorariosDisponiveisMedico.MultiSelect = false;
            this.lvwHorariosDisponiveisMedico.Name = "lvwHorariosDisponiveisMedico";
            this.lvwHorariosDisponiveisMedico.Size = new System.Drawing.Size(552, 118);
            this.lvwHorariosDisponiveisMedico.TabIndex = 0;
            this.lvwHorariosDisponiveisMedico.UseCompatibleStateImageBehavior = false;
            this.lvwHorariosDisponiveisMedico.View = System.Windows.Forms.View.Details;
            // 
            // chHorarios
            // 
            this.chHorarios.Text = "Horários";
            this.chHorarios.Width = 391;
            // 
            // lblFiltrarEspecialidade
            // 
            this.lblFiltrarEspecialidade.AutoSize = true;
            this.lblFiltrarEspecialidade.Location = new System.Drawing.Point(12, 30);
            this.lblFiltrarEspecialidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltrarEspecialidade.Name = "lblFiltrarEspecialidade";
            this.lblFiltrarEspecialidade.Size = new System.Drawing.Size(134, 16);
            this.lblFiltrarEspecialidade.TabIndex = 1;
            this.lblFiltrarEspecialidade.Text = "Filtrar Especialidade:";
            // 
            // cbEspecialidadeMedico
            // 
            this.cbEspecialidadeMedico.FormattingEnabled = true;
            this.cbEspecialidadeMedico.Location = new System.Drawing.Point(159, 23);
            this.cbEspecialidadeMedico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEspecialidadeMedico.Name = "cbEspecialidadeMedico";
            this.cbEspecialidadeMedico.Size = new System.Drawing.Size(160, 24);
            this.cbEspecialidadeMedico.TabIndex = 2;
            this.cbEspecialidadeMedico.SelectedIndexChanged += new System.EventHandler(this.cbEspecialidadeMedico_SelectedIndexChanged);
            // 
            // dtpFiltrarDataDisponibilidade
            // 
            this.dtpFiltrarDataDisponibilidade.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtpFiltrarDataDisponibilidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFiltrarDataDisponibilidade.Location = new System.Drawing.Point(159, 295);
            this.dtpFiltrarDataDisponibilidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFiltrarDataDisponibilidade.Name = "dtpFiltrarDataDisponibilidade";
            this.dtpFiltrarDataDisponibilidade.Size = new System.Drawing.Size(160, 22);
            this.dtpFiltrarDataDisponibilidade.TabIndex = 4;
            this.dtpFiltrarDataDisponibilidade.ValueChanged += new System.EventHandler(this.dtpFiltrarDataDisponibilidade_ValueChanged);
            // 
            // lblFiltrarData
            // 
            this.lblFiltrarData.AutoSize = true;
            this.lblFiltrarData.Location = new System.Drawing.Point(12, 300);
            this.lblFiltrarData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltrarData.Name = "lblFiltrarData";
            this.lblFiltrarData.Size = new System.Drawing.Size(75, 16);
            this.lblFiltrarData.TabIndex = 1;
            this.lblFiltrarData.Text = "Filtrar Data:";
            // 
            // lblAgendarConsulta
            // 
            this.lblAgendarConsulta.Location = new System.Drawing.Point(16, 454);
            this.lblAgendarConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblAgendarConsulta.Name = "lblAgendarConsulta";
            this.lblAgendarConsulta.Size = new System.Drawing.Size(553, 28);
            this.lblAgendarConsulta.TabIndex = 5;
            this.lblAgendarConsulta.Text = "Agendar Consulta";
            this.lblAgendarConsulta.UseVisualStyleBackColor = true;
            this.lblAgendarConsulta.Click += new System.EventHandler(this.lblAgendarConsulta_Click);
            // 
            // cbConsultarDisponibilidade
            // 
            this.cbConsultarDisponibilidade.Controls.Add(this.lblMédicos);
            this.cbConsultarDisponibilidade.Controls.Add(this.lblFiltrarEspecialidade);
            this.cbConsultarDisponibilidade.Controls.Add(this.lblAgendarConsulta);
            this.cbConsultarDisponibilidade.Controls.Add(this.lvwMedicos);
            this.cbConsultarDisponibilidade.Controls.Add(this.dtpFiltrarDataDisponibilidade);
            this.cbConsultarDisponibilidade.Controls.Add(this.lvwHorariosDisponiveisMedico);
            this.cbConsultarDisponibilidade.Controls.Add(this.cbEspecialidadeMedico);
            this.cbConsultarDisponibilidade.Controls.Add(this.lblFiltrarData);
            this.cbConsultarDisponibilidade.Location = new System.Drawing.Point(16, 15);
            this.cbConsultarDisponibilidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbConsultarDisponibilidade.Name = "cbConsultarDisponibilidade";
            this.cbConsultarDisponibilidade.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbConsultarDisponibilidade.Size = new System.Drawing.Size(584, 495);
            this.cbConsultarDisponibilidade.TabIndex = 6;
            this.cbConsultarDisponibilidade.TabStop = false;
            this.cbConsultarDisponibilidade.Text = "Consultar Disponibilidade";
            // 
            // lblMédicos
            // 
            this.lblMédicos.AutoSize = true;
            this.lblMédicos.Location = new System.Drawing.Point(12, 58);
            this.lblMédicos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMédicos.Name = "lblMédicos";
            this.lblMédicos.Size = new System.Drawing.Size(62, 16);
            this.lblMédicos.TabIndex = 1;
            this.lblMédicos.Text = "Médicos:";
            // 
            // frmConsultarDisponibilidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cbConsultarDisponibilidade);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmConsultarDisponibilidade";
            this.Text = "Consulta Disponibilidade";
            this.cbConsultarDisponibilidade.ResumeLayout(false);
            this.cbConsultarDisponibilidade.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwMedicos;
        private System.Windows.Forms.ListView lvwHorariosDisponiveisMedico;
        private System.Windows.Forms.ColumnHeader chNome;
        private System.Windows.Forms.ColumnHeader chEspecialidade;
        private System.Windows.Forms.ColumnHeader chHorarios;
        private System.Windows.Forms.ColumnHeader chValorHora;
        private System.Windows.Forms.Label lblFiltrarEspecialidade;
        private System.Windows.Forms.ComboBox cbEspecialidadeMedico;
        private System.Windows.Forms.DateTimePicker dtpFiltrarDataDisponibilidade;
        private System.Windows.Forms.Label lblFiltrarData;
        private System.Windows.Forms.Button lblAgendarConsulta;
        private System.Windows.Forms.GroupBox cbConsultarDisponibilidade;
        private System.Windows.Forms.Label lblMédicos;
        private System.Windows.Forms.ColumnHeader chCrm;
    }
}