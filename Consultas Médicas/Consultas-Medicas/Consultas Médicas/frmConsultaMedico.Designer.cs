namespace Consultas_Médicas
{
    partial class frmConsultaMedico
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
            this.lvwConsultaMedico = new System.Windows.Forms.ListView();
            this.chNomeMedico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCrmMedico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEspecialidadeMedico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chValorHoraMedico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbConsultarMedicos = new System.Windows.Forms.GroupBox();
            this.btnRemoverMedico = new System.Windows.Forms.Button();
            this.btnAdicionarMedico = new System.Windows.Forms.Button();
            this.lblMédicos = new System.Windows.Forms.Label();
            this.lblFiltrarEspecialidade = new System.Windows.Forms.Label();
            this.cbEspecialidadeMedico = new System.Windows.Forms.ComboBox();
            this.cbConsultarDisponibilidade = new System.Windows.Forms.GroupBox();
            this.dtpDataDisponibilidade = new System.Windows.Forms.DateTimePicker();
            this.dtpFiltrarDataDisponibilidade = new System.Windows.Forms.DateTimePicker();
            this.lblHorarioDisponibilidade = new System.Windows.Forms.Label();
            this.lblDataDisponibilidade = new System.Windows.Forms.Label();
            this.lvwHorariosDisponiveisMedico = new System.Windows.Forms.ListView();
            this.chHorarios = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpHoraDisponibilidade = new System.Windows.Forms.DateTimePicker();
            this.lblFiltrarData = new System.Windows.Forms.Label();
            this.btnRemoverData = new System.Windows.Forms.Button();
            this.btnAdicionarData = new System.Windows.Forms.Button();
            this.btnAtualizarMedico = new System.Windows.Forms.Button();
            this.cbConsultarMedicos.SuspendLayout();
            this.cbConsultarDisponibilidade.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwConsultaMedico
            // 
            this.lvwConsultaMedico.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNomeMedico,
            this.chCrmMedico,
            this.chEspecialidadeMedico,
            this.chValorHoraMedico});
            this.lvwConsultaMedico.FullRowSelect = true;
            this.lvwConsultaMedico.HideSelection = false;
            this.lvwConsultaMedico.Location = new System.Drawing.Point(12, 73);
            this.lvwConsultaMedico.MultiSelect = false;
            this.lvwConsultaMedico.Name = "lvwConsultaMedico";
            this.lvwConsultaMedico.Size = new System.Drawing.Size(406, 268);
            this.lvwConsultaMedico.TabIndex = 0;
            this.lvwConsultaMedico.UseCompatibleStateImageBehavior = false;
            this.lvwConsultaMedico.View = System.Windows.Forms.View.Details;
            this.lvwConsultaMedico.SelectedIndexChanged += new System.EventHandler(this.lvwConsultaMedico_SelectedIndexChanged);
            // 
            // chNomeMedico
            // 
            this.chNomeMedico.Text = "Nome";
            this.chNomeMedico.Width = 78;
            // 
            // chCrmMedico
            // 
            this.chCrmMedico.Text = "CRM";
            this.chCrmMedico.Width = 87;
            // 
            // chEspecialidadeMedico
            // 
            this.chEspecialidadeMedico.Text = "Especialidade";
            this.chEspecialidadeMedico.Width = 166;
            // 
            // chValorHoraMedico
            // 
            this.chValorHoraMedico.Text = "Valor Hora";
            this.chValorHoraMedico.Width = 63;
            // 
            // cbConsultarMedicos
            // 
            this.cbConsultarMedicos.Controls.Add(this.btnAtualizarMedico);
            this.cbConsultarMedicos.Controls.Add(this.btnRemoverMedico);
            this.cbConsultarMedicos.Controls.Add(this.btnAdicionarMedico);
            this.cbConsultarMedicos.Controls.Add(this.lblMédicos);
            this.cbConsultarMedicos.Controls.Add(this.lvwConsultaMedico);
            this.cbConsultarMedicos.Controls.Add(this.lblFiltrarEspecialidade);
            this.cbConsultarMedicos.Controls.Add(this.cbEspecialidadeMedico);
            this.cbConsultarMedicos.Location = new System.Drawing.Point(12, 12);
            this.cbConsultarMedicos.Name = "cbConsultarMedicos";
            this.cbConsultarMedicos.Size = new System.Drawing.Size(429, 385);
            this.cbConsultarMedicos.TabIndex = 7;
            this.cbConsultarMedicos.TabStop = false;
            this.cbConsultarMedicos.Text = "Consultar Médicos";
            // 
            // btnRemoverMedico
            // 
            this.btnRemoverMedico.Location = new System.Drawing.Point(318, 347);
            this.btnRemoverMedico.Name = "btnRemoverMedico";
            this.btnRemoverMedico.Size = new System.Drawing.Size(100, 23);
            this.btnRemoverMedico.TabIndex = 8;
            this.btnRemoverMedico.Text = "Remover";
            this.btnRemoverMedico.UseVisualStyleBackColor = true;
            this.btnRemoverMedico.Click += new System.EventHandler(this.btnRemoverMedico_Click);
            // 
            // btnAdicionarMedico
            // 
            this.btnAdicionarMedico.Location = new System.Drawing.Point(13, 347);
            this.btnAdicionarMedico.Name = "btnAdicionarMedico";
            this.btnAdicionarMedico.Size = new System.Drawing.Size(100, 23);
            this.btnAdicionarMedico.TabIndex = 3;
            this.btnAdicionarMedico.Text = "Adicionar";
            this.btnAdicionarMedico.UseVisualStyleBackColor = true;
            this.btnAdicionarMedico.Click += new System.EventHandler(this.btnAdicionarMedico_Click);
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
            // cbEspecialidadeMedico
            // 
            this.cbEspecialidadeMedico.FormattingEnabled = true;
            this.cbEspecialidadeMedico.Location = new System.Drawing.Point(119, 19);
            this.cbEspecialidadeMedico.Name = "cbEspecialidadeMedico";
            this.cbEspecialidadeMedico.Size = new System.Drawing.Size(121, 21);
            this.cbEspecialidadeMedico.TabIndex = 2;
            this.cbEspecialidadeMedico.SelectedIndexChanged += new System.EventHandler(this.cbEspecialidadeMedico_SelectedIndexChanged);
            // 
            // cbConsultarDisponibilidade
            // 
            this.cbConsultarDisponibilidade.Controls.Add(this.dtpDataDisponibilidade);
            this.cbConsultarDisponibilidade.Controls.Add(this.dtpFiltrarDataDisponibilidade);
            this.cbConsultarDisponibilidade.Controls.Add(this.lblHorarioDisponibilidade);
            this.cbConsultarDisponibilidade.Controls.Add(this.lblDataDisponibilidade);
            this.cbConsultarDisponibilidade.Controls.Add(this.lvwHorariosDisponiveisMedico);
            this.cbConsultarDisponibilidade.Controls.Add(this.dtpHoraDisponibilidade);
            this.cbConsultarDisponibilidade.Controls.Add(this.lblFiltrarData);
            this.cbConsultarDisponibilidade.Controls.Add(this.btnRemoverData);
            this.cbConsultarDisponibilidade.Controls.Add(this.btnAdicionarData);
            this.cbConsultarDisponibilidade.Location = new System.Drawing.Point(447, 12);
            this.cbConsultarDisponibilidade.Name = "cbConsultarDisponibilidade";
            this.cbConsultarDisponibilidade.Size = new System.Drawing.Size(341, 385);
            this.cbConsultarDisponibilidade.TabIndex = 7;
            this.cbConsultarDisponibilidade.TabStop = false;
            this.cbConsultarDisponibilidade.Text = "Consultar Disponibilidade";
            // 
            // dtpDataDisponibilidade
            // 
            this.dtpDataDisponibilidade.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtpDataDisponibilidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDisponibilidade.Location = new System.Drawing.Point(17, 66);
            this.dtpDataDisponibilidade.Name = "dtpDataDisponibilidade";
            this.dtpDataDisponibilidade.Size = new System.Drawing.Size(100, 20);
            this.dtpDataDisponibilidade.TabIndex = 3;
            // 
            // dtpFiltrarDataDisponibilidade
            // 
            this.dtpFiltrarDataDisponibilidade.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtpFiltrarDataDisponibilidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFiltrarDataDisponibilidade.Location = new System.Drawing.Point(79, 18);
            this.dtpFiltrarDataDisponibilidade.Name = "dtpFiltrarDataDisponibilidade";
            this.dtpFiltrarDataDisponibilidade.Size = new System.Drawing.Size(121, 20);
            this.dtpFiltrarDataDisponibilidade.TabIndex = 4;
            this.dtpFiltrarDataDisponibilidade.ValueChanged += new System.EventHandler(this.dtpFiltrarDataDisponibilidade_ValueChanged);
            // 
            // lblHorarioDisponibilidade
            // 
            this.lblHorarioDisponibilidade.AutoSize = true;
            this.lblHorarioDisponibilidade.Location = new System.Drawing.Point(141, 47);
            this.lblHorarioDisponibilidade.Name = "lblHorarioDisponibilidade";
            this.lblHorarioDisponibilidade.Size = new System.Drawing.Size(44, 13);
            this.lblHorarioDisponibilidade.TabIndex = 0;
            this.lblHorarioDisponibilidade.Text = "Horario:";
            // 
            // lblDataDisponibilidade
            // 
            this.lblDataDisponibilidade.AutoSize = true;
            this.lblDataDisponibilidade.Location = new System.Drawing.Point(14, 47);
            this.lblDataDisponibilidade.Name = "lblDataDisponibilidade";
            this.lblDataDisponibilidade.Size = new System.Drawing.Size(33, 13);
            this.lblDataDisponibilidade.TabIndex = 0;
            this.lblDataDisponibilidade.Text = "Data:";
            // 
            // lvwHorariosDisponiveisMedico
            // 
            this.lvwHorariosDisponiveisMedico.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chHorarios});
            this.lvwHorariosDisponiveisMedico.FullRowSelect = true;
            this.lvwHorariosDisponiveisMedico.HideSelection = false;
            this.lvwHorariosDisponiveisMedico.Location = new System.Drawing.Point(17, 92);
            this.lvwHorariosDisponiveisMedico.MultiSelect = false;
            this.lvwHorariosDisponiveisMedico.Name = "lvwHorariosDisponiveisMedico";
            this.lvwHorariosDisponiveisMedico.Size = new System.Drawing.Size(311, 249);
            this.lvwHorariosDisponiveisMedico.TabIndex = 0;
            this.lvwHorariosDisponiveisMedico.UseCompatibleStateImageBehavior = false;
            this.lvwHorariosDisponiveisMedico.View = System.Windows.Forms.View.Details;
            // 
            // chHorarios
            // 
            this.chHorarios.Text = "Horários";
            this.chHorarios.Width = 288;
            // 
            // dtpHoraDisponibilidade
            // 
            this.dtpHoraDisponibilidade.CustomFormat = "HH";
            this.dtpHoraDisponibilidade.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraDisponibilidade.Location = new System.Drawing.Point(144, 66);
            this.dtpHoraDisponibilidade.Name = "dtpHoraDisponibilidade";
            this.dtpHoraDisponibilidade.ShowUpDown = true;
            this.dtpHoraDisponibilidade.Size = new System.Drawing.Size(100, 20);
            this.dtpHoraDisponibilidade.TabIndex = 6;
            // 
            // lblFiltrarData
            // 
            this.lblFiltrarData.AutoSize = true;
            this.lblFiltrarData.Location = new System.Drawing.Point(14, 20);
            this.lblFiltrarData.Name = "lblFiltrarData";
            this.lblFiltrarData.Size = new System.Drawing.Size(61, 13);
            this.lblFiltrarData.TabIndex = 1;
            this.lblFiltrarData.Text = "Filtrar Data:";
            // 
            // btnRemoverData
            // 
            this.btnRemoverData.Location = new System.Drawing.Point(228, 347);
            this.btnRemoverData.Name = "btnRemoverData";
            this.btnRemoverData.Size = new System.Drawing.Size(100, 23);
            this.btnRemoverData.TabIndex = 7;
            this.btnRemoverData.Text = "Remover";
            this.btnRemoverData.UseVisualStyleBackColor = true;
            this.btnRemoverData.Click += new System.EventHandler(this.btnRemoverData_Click);
            // 
            // btnAdicionarData
            // 
            this.btnAdicionarData.Location = new System.Drawing.Point(17, 347);
            this.btnAdicionarData.Name = "btnAdicionarData";
            this.btnAdicionarData.Size = new System.Drawing.Size(100, 23);
            this.btnAdicionarData.TabIndex = 5;
            this.btnAdicionarData.Text = "Adicionar";
            this.btnAdicionarData.UseVisualStyleBackColor = true;
            this.btnAdicionarData.Click += new System.EventHandler(this.btnAdicionarData_Click);
            // 
            // btnAtualizarMedico
            // 
            this.btnAtualizarMedico.Location = new System.Drawing.Point(171, 347);
            this.btnAtualizarMedico.Name = "btnAtualizarMedico";
            this.btnAtualizarMedico.Size = new System.Drawing.Size(100, 23);
            this.btnAtualizarMedico.TabIndex = 9;
            this.btnAtualizarMedico.Text = "Atualizar";
            this.btnAtualizarMedico.UseVisualStyleBackColor = true;
            this.btnAtualizarMedico.Click += new System.EventHandler(this.btnAtualizarMedico_Click);
            // 
            // frmConsultaMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbConsultarDisponibilidade);
            this.Controls.Add(this.cbConsultarMedicos);
            this.Name = "frmConsultaMedico";
            this.Text = "frmConsultaMedico";
            this.cbConsultarMedicos.ResumeLayout(false);
            this.cbConsultarMedicos.PerformLayout();
            this.cbConsultarDisponibilidade.ResumeLayout(false);
            this.cbConsultarDisponibilidade.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwConsultaMedico;
        private System.Windows.Forms.ColumnHeader chCrmMedico;
        private System.Windows.Forms.ColumnHeader chEspecialidadeMedico;
        private System.Windows.Forms.ColumnHeader chValorHoraMedico;
        private System.Windows.Forms.ColumnHeader chNomeMedico;
        private System.Windows.Forms.GroupBox cbConsultarMedicos;
        private System.Windows.Forms.Label lblMédicos;
        private System.Windows.Forms.Label lblFiltrarEspecialidade;
        private System.Windows.Forms.ComboBox cbEspecialidadeMedico;
        private System.Windows.Forms.GroupBox cbConsultarDisponibilidade;
        private System.Windows.Forms.DateTimePicker dtpFiltrarDataDisponibilidade;
        private System.Windows.Forms.ListView lvwHorariosDisponiveisMedico;
        private System.Windows.Forms.ColumnHeader chHorarios;
        private System.Windows.Forms.Label lblFiltrarData;
        private System.Windows.Forms.DateTimePicker dtpDataDisponibilidade;
        private System.Windows.Forms.Label lblHorarioDisponibilidade;
        private System.Windows.Forms.Label lblDataDisponibilidade;
        private System.Windows.Forms.Button btnRemoverData;
        private System.Windows.Forms.Button btnAdicionarData;
        private System.Windows.Forms.DateTimePicker dtpHoraDisponibilidade;
        private System.Windows.Forms.Button btnAdicionarMedico;
        private System.Windows.Forms.Button btnRemoverMedico;
        private System.Windows.Forms.Button btnAtualizarMedico;
    }
}