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
            this.lblHorarioDisponibilidade = new System.Windows.Forms.Label();
            this.lblDataDisponibilidade = new System.Windows.Forms.Label();
            this.cbCadastroMédico = new System.Windows.Forms.GroupBox();
            this.gbAdicionarDisponibilidade.SuspendLayout();
            this.cbCadastroMédico.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCadastroCrmMedico
            // 
            this.lblCadastroCrmMedico.AutoSize = true;
            this.lblCadastroCrmMedico.Location = new System.Drawing.Point(9, 57);
            this.lblCadastroCrmMedico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastroCrmMedico.Name = "lblCadastroCrmMedico";
            this.lblCadastroCrmMedico.Size = new System.Drawing.Size(40, 16);
            this.lblCadastroCrmMedico.TabIndex = 0;
            this.lblCadastroCrmMedico.Text = "CRM:";
            // 
            // txtCadastroCrmMedico
            // 
            this.txtCadastroCrmMedico.Location = new System.Drawing.Point(189, 53);
            this.txtCadastroCrmMedico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCadastroCrmMedico.Name = "txtCadastroCrmMedico";
            this.txtCadastroCrmMedico.Size = new System.Drawing.Size(139, 22);
            this.txtCadastroCrmMedico.TabIndex = 1;
            this.txtCadastroCrmMedico.Text = "1234567";
            this.txtCadastroCrmMedico.TextChanged += new System.EventHandler(this.txtCadastroCrmMedico_TextChanged);
            // 
            // lblCadastroEspecialiadadeMedico
            // 
            this.lblCadastroEspecialiadadeMedico.AutoSize = true;
            this.lblCadastroEspecialiadadeMedico.Location = new System.Drawing.Point(9, 89);
            this.lblCadastroEspecialiadadeMedico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastroEspecialiadadeMedico.Name = "lblCadastroEspecialiadadeMedico";
            this.lblCadastroEspecialiadadeMedico.Size = new System.Drawing.Size(98, 16);
            this.lblCadastroEspecialiadadeMedico.TabIndex = 0;
            this.lblCadastroEspecialiadadeMedico.Text = "Especialidade:";
            // 
            // lblCadastroValorHoraMedico
            // 
            this.lblCadastroValorHoraMedico.AutoSize = true;
            this.lblCadastroValorHoraMedico.Location = new System.Drawing.Point(9, 380);
            this.lblCadastroValorHoraMedico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastroValorHoraMedico.Name = "lblCadastroValorHoraMedico";
            this.lblCadastroValorHoraMedico.Size = new System.Drawing.Size(76, 16);
            this.lblCadastroValorHoraMedico.TabIndex = 0;
            this.lblCadastroValorHoraMedico.Text = "Valor-Hora:";
            // 
            // txtCadastroValorHoraMedico
            // 
            this.txtCadastroValorHoraMedico.Location = new System.Drawing.Point(189, 377);
            this.txtCadastroValorHoraMedico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCadastroValorHoraMedico.Name = "txtCadastroValorHoraMedico";
            this.txtCadastroValorHoraMedico.Size = new System.Drawing.Size(139, 22);
            this.txtCadastroValorHoraMedico.TabIndex = 1;
            this.txtCadastroValorHoraMedico.Text = "100";
            // 
            // btnCadastroMedico
            // 
            this.btnCadastroMedico.Location = new System.Drawing.Point(13, 420);
            this.btnCadastroMedico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadastroMedico.Name = "btnCadastroMedico";
            this.btnCadastroMedico.Size = new System.Drawing.Size(316, 28);
            this.btnCadastroMedico.TabIndex = 2;
            this.btnCadastroMedico.Text = "Cadastro";
            this.btnCadastroMedico.UseVisualStyleBackColor = true;
            this.btnCadastroMedico.Click += new System.EventHandler(this.btnCadastroMedico_Click);
            // 
            // dtpDataDisponibilidade
            // 
            this.dtpDataDisponibilidade.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtpDataDisponibilidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDisponibilidade.Location = new System.Drawing.Point(7, 47);
            this.dtpDataDisponibilidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDataDisponibilidade.Name = "dtpDataDisponibilidade";
            this.dtpDataDisponibilidade.Size = new System.Drawing.Size(132, 22);
            this.dtpDataDisponibilidade.TabIndex = 3;
            // 
            // lvwDatasDisponibilidade
            // 
            this.lvwDatasDisponibilidade.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDataDisponibilidade});
            this.lvwDatasDisponibilidade.FullRowSelect = true;
            this.lvwDatasDisponibilidade.HideSelection = false;
            this.lvwDatasDisponibilidade.Location = new System.Drawing.Point(7, 82);
            this.lvwDatasDisponibilidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvwDatasDisponibilidade.MultiSelect = false;
            this.lvwDatasDisponibilidade.Name = "lvwDatasDisponibilidade";
            this.lvwDatasDisponibilidade.Size = new System.Drawing.Size(301, 118);
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
            this.btnAdicionarData.Location = new System.Drawing.Point(7, 209);
            this.btnAdicionarData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdicionarData.Name = "btnAdicionarData";
            this.btnAdicionarData.Size = new System.Drawing.Size(133, 28);
            this.btnAdicionarData.TabIndex = 5;
            this.btnAdicionarData.Text = "Adicionar";
            this.btnAdicionarData.UseVisualStyleBackColor = true;
            this.btnAdicionarData.Click += new System.EventHandler(this.btnAdicionarData_Click);
            // 
            // dtpHoraDisponibilidade
            // 
            this.dtpHoraDisponibilidade.CustomFormat = "HH";
            this.dtpHoraDisponibilidade.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraDisponibilidade.Location = new System.Drawing.Point(176, 47);
            this.dtpHoraDisponibilidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpHoraDisponibilidade.Name = "dtpHoraDisponibilidade";
            this.dtpHoraDisponibilidade.ShowUpDown = true;
            this.dtpHoraDisponibilidade.Size = new System.Drawing.Size(132, 22);
            this.dtpHoraDisponibilidade.TabIndex = 6;
            // 
            // btnRemoverData
            // 
            this.btnRemoverData.Location = new System.Drawing.Point(176, 209);
            this.btnRemoverData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoverData.Name = "btnRemoverData";
            this.btnRemoverData.Size = new System.Drawing.Size(133, 28);
            this.btnRemoverData.TabIndex = 7;
            this.btnRemoverData.Text = "Remover";
            this.btnRemoverData.UseVisualStyleBackColor = true;
            this.btnRemoverData.Click += new System.EventHandler(this.btnRemoverData_Click);
            // 
            // cbCadastroEspecialidadeMedico
            // 
            this.cbCadastroEspecialidadeMedico.FormattingEnabled = true;
            this.cbCadastroEspecialidadeMedico.Location = new System.Drawing.Point(189, 85);
            this.cbCadastroEspecialidadeMedico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCadastroEspecialidadeMedico.Name = "cbCadastroEspecialidadeMedico";
            this.cbCadastroEspecialidadeMedico.Size = new System.Drawing.Size(139, 24);
            this.cbCadastroEspecialidadeMedico.TabIndex = 8;
            this.cbCadastroEspecialidadeMedico.SelectedIndexChanged += new System.EventHandler(this.cbCadastroEspecialidadeMedico_SelectedIndexChanged);
            // 
            // lblCadastroNomeMedico
            // 
            this.lblCadastroNomeMedico.AutoSize = true;
            this.lblCadastroNomeMedico.Location = new System.Drawing.Point(9, 27);
            this.lblCadastroNomeMedico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastroNomeMedico.Name = "lblCadastroNomeMedico";
            this.lblCadastroNomeMedico.Size = new System.Drawing.Size(47, 16);
            this.lblCadastroNomeMedico.TabIndex = 0;
            this.lblCadastroNomeMedico.Text = "Nome:";
            // 
            // txtCadastroNomeMedico
            // 
            this.txtCadastroNomeMedico.Location = new System.Drawing.Point(189, 23);
            this.txtCadastroNomeMedico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCadastroNomeMedico.Name = "txtCadastroNomeMedico";
            this.txtCadastroNomeMedico.Size = new System.Drawing.Size(139, 22);
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
            this.gbAdicionarDisponibilidade.Location = new System.Drawing.Point(13, 122);
            this.gbAdicionarDisponibilidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAdicionarDisponibilidade.Name = "gbAdicionarDisponibilidade";
            this.gbAdicionarDisponibilidade.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAdicionarDisponibilidade.Size = new System.Drawing.Size(316, 247);
            this.gbAdicionarDisponibilidade.TabIndex = 9;
            this.gbAdicionarDisponibilidade.TabStop = false;
            this.gbAdicionarDisponibilidade.Text = "Adicionar Disponibilidade";
            // 
            // lblHorarioDisponibilidade
            // 
            this.lblHorarioDisponibilidade.AutoSize = true;
            this.lblHorarioDisponibilidade.Location = new System.Drawing.Point(172, 23);
            this.lblHorarioDisponibilidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHorarioDisponibilidade.Name = "lblHorarioDisponibilidade";
            this.lblHorarioDisponibilidade.Size = new System.Drawing.Size(55, 16);
            this.lblHorarioDisponibilidade.TabIndex = 0;
            this.lblHorarioDisponibilidade.Text = "Horario:";
            // 
            // lblDataDisponibilidade
            // 
            this.lblDataDisponibilidade.AutoSize = true;
            this.lblDataDisponibilidade.Location = new System.Drawing.Point(3, 23);
            this.lblDataDisponibilidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataDisponibilidade.Name = "lblDataDisponibilidade";
            this.lblDataDisponibilidade.Size = new System.Drawing.Size(39, 16);
            this.lblDataDisponibilidade.TabIndex = 0;
            this.lblDataDisponibilidade.Text = "Data:";
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
            this.cbCadastroMédico.Location = new System.Drawing.Point(16, 15);
            this.cbCadastroMédico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCadastroMédico.Name = "cbCadastroMédico";
            this.cbCadastroMédico.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCadastroMédico.Size = new System.Drawing.Size(343, 458);
            this.cbCadastroMédico.TabIndex = 10;
            this.cbCadastroMédico.TabStop = false;
            this.cbCadastroMédico.Text = "Cadastro do Médico";
            // 
            // frmCadastroMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cbCadastroMédico);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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