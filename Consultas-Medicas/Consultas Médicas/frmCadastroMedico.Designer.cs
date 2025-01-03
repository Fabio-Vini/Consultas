namespace Consultas_Médicas
{
    partial class frmCadastroMedico
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
            this.lblCadastroCrmMedico = new System.Windows.Forms.Label();
            this.txtCadastroCrmMedico = new System.Windows.Forms.TextBox();
            this.lblCadastroEspecialiadadeMedico = new System.Windows.Forms.Label();
            this.lblCadastroValorHoraMedico = new System.Windows.Forms.Label();
            this.txtCadastroValorHoraMedico = new System.Windows.Forms.TextBox();
            this.btnCadastroMedico = new System.Windows.Forms.Button();
            this.dtpDataDisponibilidade = new System.Windows.Forms.DateTimePicker();
            this.lvwDatasDisponibilidade = new System.Windows.Forms.ListView();
            this.columnDataDisponibilidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdicionarData = new System.Windows.Forms.Button();
            this.dtpHoraDisponibilidade = new System.Windows.Forms.DateTimePicker();
            this.btnRemoverData = new System.Windows.Forms.Button();
            this.cbCadastroEspecialidadeMedico = new System.Windows.Forms.ComboBox();
            this.lblCadastroNomeMedico = new System.Windows.Forms.Label();
            this.txtCadastroNomeMedico = new System.Windows.Forms.TextBox();
            this.gbAdicionarDisponibilidade = new System.Windows.Forms.GroupBox();
            this.cbCadastroMédico = new System.Windows.Forms.GroupBox();
            this.lblDataDisponibilidade = new System.Windows.Forms.Label();
            this.lblHorarioDisponibilidade = new System.Windows.Forms.Label();
            this.gbAdicionarDisponibilidade.SuspendLayout();
            this.cbCadastroMédico.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCadastroCrmMedico
            // 
            this.lblCadastroCrmMedico.AutoSize = true;
            this.lblCadastroCrmMedico.Location = new System.Drawing.Point(7, 46);
            this.lblCadastroCrmMedico.Name = "lblCadastroCrmMedico";
            this.lblCadastroCrmMedico.Size = new System.Drawing.Size(34, 13);
            this.lblCadastroCrmMedico.TabIndex = 0;
            this.lblCadastroCrmMedico.Text = "CRM:";
            // 
            // txtCadastroCrmMedico
            // 
            this.txtCadastroCrmMedico.Location = new System.Drawing.Point(142, 43);
            this.txtCadastroCrmMedico.Name = "txtCadastroCrmMedico";
            this.txtCadastroCrmMedico.Size = new System.Drawing.Size(105, 20);
            this.txtCadastroCrmMedico.TabIndex = 1;
            this.txtCadastroCrmMedico.Text = "1234567";
            // 
            // lblCadastroEspecialiadadeMedico
            // 
            this.lblCadastroEspecialiadadeMedico.AutoSize = true;
            this.lblCadastroEspecialiadadeMedico.Location = new System.Drawing.Point(7, 72);
            this.lblCadastroEspecialiadadeMedico.Name = "lblCadastroEspecialiadadeMedico";
            this.lblCadastroEspecialiadadeMedico.Size = new System.Drawing.Size(76, 13);
            this.lblCadastroEspecialiadadeMedico.TabIndex = 0;
            this.lblCadastroEspecialiadadeMedico.Text = "Especialidade:";
            // 
            // lblCadastroValorHoraMedico
            // 
            this.lblCadastroValorHoraMedico.AutoSize = true;
            this.lblCadastroValorHoraMedico.Location = new System.Drawing.Point(7, 309);
            this.lblCadastroValorHoraMedico.Name = "lblCadastroValorHoraMedico";
            this.lblCadastroValorHoraMedico.Size = new System.Drawing.Size(60, 13);
            this.lblCadastroValorHoraMedico.TabIndex = 0;
            this.lblCadastroValorHoraMedico.Text = "Valor-Hora:";
            // 
            // txtCadastroValorHoraMedico
            // 
            this.txtCadastroValorHoraMedico.Location = new System.Drawing.Point(142, 306);
            this.txtCadastroValorHoraMedico.Name = "txtCadastroValorHoraMedico";
            this.txtCadastroValorHoraMedico.Size = new System.Drawing.Size(105, 20);
            this.txtCadastroValorHoraMedico.TabIndex = 1;
            this.txtCadastroValorHoraMedico.Text = "100";
            // 
            // btnCadastroMedico
            // 
            this.btnCadastroMedico.Location = new System.Drawing.Point(10, 341);
            this.btnCadastroMedico.Name = "btnCadastroMedico";
            this.btnCadastroMedico.Size = new System.Drawing.Size(237, 23);
            this.btnCadastroMedico.TabIndex = 2;
            this.btnCadastroMedico.Text = "Cadastro";
            this.btnCadastroMedico.UseVisualStyleBackColor = true;
            this.btnCadastroMedico.Click += new System.EventHandler(this.btnCadastroMedico_Click);
            // 
            // dtpDataDisponibilidade
            // 
            this.dtpDataDisponibilidade.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtpDataDisponibilidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDisponibilidade.Location = new System.Drawing.Point(5, 38);
            this.dtpDataDisponibilidade.Name = "dtpDataDisponibilidade";
            this.dtpDataDisponibilidade.Size = new System.Drawing.Size(100, 20);
            this.dtpDataDisponibilidade.TabIndex = 3;
            // 
            // lvwDatasDisponibilidade
            // 
            this.lvwDatasDisponibilidade.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDataDisponibilidade});
            this.lvwDatasDisponibilidade.FullRowSelect = true;
            this.lvwDatasDisponibilidade.HideSelection = false;
            this.lvwDatasDisponibilidade.Location = new System.Drawing.Point(5, 67);
            this.lvwDatasDisponibilidade.MultiSelect = false;
            this.lvwDatasDisponibilidade.Name = "lvwDatasDisponibilidade";
            this.lvwDatasDisponibilidade.Size = new System.Drawing.Size(227, 97);
            this.lvwDatasDisponibilidade.TabIndex = 4;
            this.lvwDatasDisponibilidade.UseCompatibleStateImageBehavior = false;
            this.lvwDatasDisponibilidade.View = System.Windows.Forms.View.Details;
            // 
            // columnDataDisponibilidade
            // 
            this.columnDataDisponibilidade.Text = "Data";
            this.columnDataDisponibilidade.Width = 194;
            // 
            // btnAdicionarData
            // 
            this.btnAdicionarData.Location = new System.Drawing.Point(5, 170);
            this.btnAdicionarData.Name = "btnAdicionarData";
            this.btnAdicionarData.Size = new System.Drawing.Size(100, 23);
            this.btnAdicionarData.TabIndex = 5;
            this.btnAdicionarData.Text = "Adicionar";
            this.btnAdicionarData.UseVisualStyleBackColor = true;
            this.btnAdicionarData.Click += new System.EventHandler(this.btnAdicionarData_Click);
            // 
            // dtpHoraDisponibilidade
            // 
            this.dtpHoraDisponibilidade.CustomFormat = "HH";
            this.dtpHoraDisponibilidade.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraDisponibilidade.Location = new System.Drawing.Point(132, 38);
            this.dtpHoraDisponibilidade.Name = "dtpHoraDisponibilidade";
            this.dtpHoraDisponibilidade.ShowUpDown = true;
            this.dtpHoraDisponibilidade.Size = new System.Drawing.Size(100, 20);
            this.dtpHoraDisponibilidade.TabIndex = 6;
            // 
            // btnRemoverData
            // 
            this.btnRemoverData.Location = new System.Drawing.Point(132, 170);
            this.btnRemoverData.Name = "btnRemoverData";
            this.btnRemoverData.Size = new System.Drawing.Size(100, 23);
            this.btnRemoverData.TabIndex = 7;
            this.btnRemoverData.Text = "Remover";
            this.btnRemoverData.UseVisualStyleBackColor = true;
            this.btnRemoverData.Click += new System.EventHandler(this.btnRemoverData_Click);
            // 
            // cbCadastroEspecialidadeMedico
            // 
            this.cbCadastroEspecialidadeMedico.FormattingEnabled = true;
            this.cbCadastroEspecialidadeMedico.Location = new System.Drawing.Point(142, 69);
            this.cbCadastroEspecialidadeMedico.Name = "cbCadastroEspecialidadeMedico";
            this.cbCadastroEspecialidadeMedico.Size = new System.Drawing.Size(105, 21);
            this.cbCadastroEspecialidadeMedico.TabIndex = 8;
            // 
            // lblCadastroNomeMedico
            // 
            this.lblCadastroNomeMedico.AutoSize = true;
            this.lblCadastroNomeMedico.Location = new System.Drawing.Point(7, 22);
            this.lblCadastroNomeMedico.Name = "lblCadastroNomeMedico";
            this.lblCadastroNomeMedico.Size = new System.Drawing.Size(38, 13);
            this.lblCadastroNomeMedico.TabIndex = 0;
            this.lblCadastroNomeMedico.Text = "Nome:";
            // 
            // txtCadastroNomeMedico
            // 
            this.txtCadastroNomeMedico.Location = new System.Drawing.Point(142, 19);
            this.txtCadastroNomeMedico.Name = "txtCadastroNomeMedico";
            this.txtCadastroNomeMedico.Size = new System.Drawing.Size(105, 20);
            this.txtCadastroNomeMedico.TabIndex = 1;
            this.txtCadastroNomeMedico.Text = "Cleiton";
            // 
            // gbAdicionarDisponibilidade
            // 
            this.gbAdicionarDisponibilidade.Controls.Add(this.dtpDataDisponibilidade);
            this.gbAdicionarDisponibilidade.Controls.Add(this.lvwDatasDisponibilidade);
            this.gbAdicionarDisponibilidade.Controls.Add(this.lblHorarioDisponibilidade);
            this.gbAdicionarDisponibilidade.Controls.Add(this.lblDataDisponibilidade);
            this.gbAdicionarDisponibilidade.Controls.Add(this.btnRemoverData);
            this.gbAdicionarDisponibilidade.Controls.Add(this.btnAdicionarData);
            this.gbAdicionarDisponibilidade.Controls.Add(this.dtpHoraDisponibilidade);
            this.gbAdicionarDisponibilidade.Location = new System.Drawing.Point(10, 99);
            this.gbAdicionarDisponibilidade.Name = "gbAdicionarDisponibilidade";
            this.gbAdicionarDisponibilidade.Size = new System.Drawing.Size(237, 201);
            this.gbAdicionarDisponibilidade.TabIndex = 9;
            this.gbAdicionarDisponibilidade.TabStop = false;
            this.gbAdicionarDisponibilidade.Text = "Adicionar Disponibilidade";
            // 
            // cbCadastroMédico
            // 
            this.cbCadastroMédico.Controls.Add(this.lblCadastroNomeMedico);
            this.cbCadastroMédico.Controls.Add(this.gbAdicionarDisponibilidade);
            this.cbCadastroMédico.Controls.Add(this.lblCadastroCrmMedico);
            this.cbCadastroMédico.Controls.Add(this.cbCadastroEspecialidadeMedico);
            this.cbCadastroMédico.Controls.Add(this.txtCadastroCrmMedico);
            this.cbCadastroMédico.Controls.Add(this.btnCadastroMedico);
            this.cbCadastroMédico.Controls.Add(this.txtCadastroNomeMedico);
            this.cbCadastroMédico.Controls.Add(this.txtCadastroValorHoraMedico);
            this.cbCadastroMédico.Controls.Add(this.lblCadastroEspecialiadadeMedico);
            this.cbCadastroMédico.Controls.Add(this.lblCadastroValorHoraMedico);
            this.cbCadastroMédico.Location = new System.Drawing.Point(12, 12);
            this.cbCadastroMédico.Name = "cbCadastroMédico";
            this.cbCadastroMédico.Size = new System.Drawing.Size(257, 372);
            this.cbCadastroMédico.TabIndex = 10;
            this.cbCadastroMédico.TabStop = false;
            this.cbCadastroMédico.Text = "Cadastro do Médico";
            // 
            // lblDataDisponibilidade
            // 
            this.lblDataDisponibilidade.AutoSize = true;
            this.lblDataDisponibilidade.Location = new System.Drawing.Point(2, 19);
            this.lblDataDisponibilidade.Name = "lblDataDisponibilidade";
            this.lblDataDisponibilidade.Size = new System.Drawing.Size(33, 13);
            this.lblDataDisponibilidade.TabIndex = 0;
            this.lblDataDisponibilidade.Text = "Data:";
            // 
            // lblHorarioDisponibilidade
            // 
            this.lblHorarioDisponibilidade.AutoSize = true;
            this.lblHorarioDisponibilidade.Location = new System.Drawing.Point(129, 19);
            this.lblHorarioDisponibilidade.Name = "lblHorarioDisponibilidade";
            this.lblHorarioDisponibilidade.Size = new System.Drawing.Size(44, 13);
            this.lblHorarioDisponibilidade.TabIndex = 0;
            this.lblHorarioDisponibilidade.Text = "Horario:";
            // 
            // frmCadastroMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbCadastroMédico);
            this.Name = "frmCadastroMedico";
            this.Text = "CadastroMedico";
            this.gbAdicionarDisponibilidade.ResumeLayout(false);
            this.gbAdicionarDisponibilidade.PerformLayout();
            this.cbCadastroMédico.ResumeLayout(false);
            this.cbCadastroMédico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCadastroCrmMedico;
        private System.Windows.Forms.TextBox txtCadastroCrmMedico;
        private System.Windows.Forms.Label lblCadastroEspecialiadadeMedico;
        private System.Windows.Forms.Label lblCadastroValorHoraMedico;
        private System.Windows.Forms.TextBox txtCadastroValorHoraMedico;
        private System.Windows.Forms.Button btnCadastroMedico;
        private System.Windows.Forms.DateTimePicker dtpDataDisponibilidade;
        private System.Windows.Forms.ListView lvwDatasDisponibilidade;
        private System.Windows.Forms.Button btnAdicionarData;
        private System.Windows.Forms.ColumnHeader columnDataDisponibilidade;
        private System.Windows.Forms.DateTimePicker dtpHoraDisponibilidade;
        private System.Windows.Forms.Button btnRemoverData;
        private System.Windows.Forms.ComboBox cbCadastroEspecialidadeMedico;
        private System.Windows.Forms.Label lblCadastroNomeMedico;
        private System.Windows.Forms.TextBox txtCadastroNomeMedico;
        private System.Windows.Forms.GroupBox gbAdicionarDisponibilidade;
        private System.Windows.Forms.Label lblHorarioDisponibilidade;
        private System.Windows.Forms.Label lblDataDisponibilidade;
        private System.Windows.Forms.GroupBox cbCadastroMédico;
    }
}