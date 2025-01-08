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
            this.btnAdicionarPaciente = new System.Windows.Forms.Button();
            this.btnRemoverPaciente = new System.Windows.Forms.Button();
            this.txtFiltrarCpfPaciente = new System.Windows.Forms.TextBox();
            this.txtFiltrarNomePaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarConsultas = new System.Windows.Forms.Button();
            this.lvwConsultasMarcadas = new System.Windows.Forms.ListView();
            this.chNomeMedico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCrmMedico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEspecialidadeMedico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDataHora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chValorConsulta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbConsultarConsultas = new System.Windows.Forms.GroupBox();
            this.btnAtualizarPaciente = new System.Windows.Forms.Button();
            this.gbConsultarPacientes.SuspendLayout();
            this.gbConsultarConsultas.SuspendLayout();
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
            this.lvwConsultaPaciente.Location = new System.Drawing.Point(5, 45);
            this.lvwConsultaPaciente.MultiSelect = false;
            this.lvwConsultaPaciente.Name = "lvwConsultaPaciente";
            this.lvwConsultaPaciente.Size = new System.Drawing.Size(765, 221);
            this.lvwConsultaPaciente.TabIndex = 0;
            this.lvwConsultaPaciente.UseCompatibleStateImageBehavior = false;
            this.lvwConsultaPaciente.View = System.Windows.Forms.View.Details;
            this.lvwConsultaPaciente.SelectedIndexChanged += new System.EventHandler(this.lvwConsultaPaciente_SelectedIndexChanged);
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
            this.gbConsultarPacientes.Controls.Add(this.btnAtualizarPaciente);
            this.gbConsultarPacientes.Controls.Add(this.btnAdicionarPaciente);
            this.gbConsultarPacientes.Controls.Add(this.btnRemoverPaciente);
            this.gbConsultarPacientes.Controls.Add(this.txtFiltrarCpfPaciente);
            this.gbConsultarPacientes.Controls.Add(this.lvwConsultaPaciente);
            this.gbConsultarPacientes.Controls.Add(this.txtFiltrarNomePaciente);
            this.gbConsultarPacientes.Controls.Add(this.label2);
            this.gbConsultarPacientes.Controls.Add(this.label1);
            this.gbConsultarPacientes.Location = new System.Drawing.Point(3, 19);
            this.gbConsultarPacientes.Name = "gbConsultarPacientes";
            this.gbConsultarPacientes.Size = new System.Drawing.Size(776, 304);
            this.gbConsultarPacientes.TabIndex = 9;
            this.gbConsultarPacientes.TabStop = false;
            this.gbConsultarPacientes.Text = "Consultar Pacientes";
            // 
            // btnAdicionarPaciente
            // 
            this.btnAdicionarPaciente.Location = new System.Drawing.Point(5, 272);
            this.btnAdicionarPaciente.Name = "btnAdicionarPaciente";
            this.btnAdicionarPaciente.Size = new System.Drawing.Size(101, 23);
            this.btnAdicionarPaciente.TabIndex = 12;
            this.btnAdicionarPaciente.Text = "Adicionar";
            this.btnAdicionarPaciente.UseVisualStyleBackColor = true;
            this.btnAdicionarPaciente.Click += new System.EventHandler(this.btnAdicionarPaciente_Click);
            // 
            // btnRemoverPaciente
            // 
            this.btnRemoverPaciente.Location = new System.Drawing.Point(670, 272);
            this.btnRemoverPaciente.Name = "btnRemoverPaciente";
            this.btnRemoverPaciente.Size = new System.Drawing.Size(100, 23);
            this.btnRemoverPaciente.TabIndex = 11;
            this.btnRemoverPaciente.Text = "Remover";
            this.btnRemoverPaciente.UseVisualStyleBackColor = true;
            this.btnRemoverPaciente.Click += new System.EventHandler(this.btnRemoverPaciente_Click);
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
            // btnCancelarConsultas
            // 
            this.btnCancelarConsultas.Location = new System.Drawing.Point(338, 194);
            this.btnCancelarConsultas.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarConsultas.Name = "btnCancelarConsultas";
            this.btnCancelarConsultas.Size = new System.Drawing.Size(112, 32);
            this.btnCancelarConsultas.TabIndex = 11;
            this.btnCancelarConsultas.Text = "Cancelar Consultas";
            this.btnCancelarConsultas.UseVisualStyleBackColor = true;
            this.btnCancelarConsultas.Click += new System.EventHandler(this.btnCancelarConsultas_Click);
            // 
            // lvwConsultasMarcadas
            // 
            this.lvwConsultasMarcadas.AutoArrange = false;
            this.lvwConsultasMarcadas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNomeMedico,
            this.chCrmMedico,
            this.chEspecialidadeMedico,
            this.chDataHora,
            this.chValorConsulta});
            this.lvwConsultasMarcadas.FullRowSelect = true;
            this.lvwConsultasMarcadas.HideSelection = false;
            this.lvwConsultasMarcadas.Location = new System.Drawing.Point(5, 18);
            this.lvwConsultasMarcadas.Margin = new System.Windows.Forms.Padding(2);
            this.lvwConsultasMarcadas.Name = "lvwConsultasMarcadas";
            this.lvwConsultasMarcadas.Size = new System.Drawing.Size(766, 172);
            this.lvwConsultasMarcadas.TabIndex = 12;
            this.lvwConsultasMarcadas.UseCompatibleStateImageBehavior = false;
            this.lvwConsultasMarcadas.View = System.Windows.Forms.View.Details;
            // 
            // chNomeMedico
            // 
            this.chNomeMedico.Text = "Nome";
            // 
            // chCrmMedico
            // 
            this.chCrmMedico.Text = "Crm";
            this.chCrmMedico.Width = 80;
            // 
            // chEspecialidadeMedico
            // 
            this.chEspecialidadeMedico.Text = "Especialidade";
            this.chEspecialidadeMedico.Width = 159;
            // 
            // chDataHora
            // 
            this.chDataHora.Text = "Data/Hora";
            this.chDataHora.Width = 120;
            // 
            // chValorConsulta
            // 
            this.chValorConsulta.Text = "Valor Consulta";
            this.chValorConsulta.Width = 136;
            // 
            // gbConsultarConsultas
            // 
            this.gbConsultarConsultas.Controls.Add(this.lvwConsultasMarcadas);
            this.gbConsultarConsultas.Controls.Add(this.btnCancelarConsultas);
            this.gbConsultarConsultas.Location = new System.Drawing.Point(3, 329);
            this.gbConsultarConsultas.Name = "gbConsultarConsultas";
            this.gbConsultarConsultas.Size = new System.Drawing.Size(776, 231);
            this.gbConsultarConsultas.TabIndex = 13;
            this.gbConsultarConsultas.TabStop = false;
            this.gbConsultarConsultas.Text = "Consultar Consultas";
            // 
            // btnAtualizarPaciente
            // 
            this.btnAtualizarPaciente.Location = new System.Drawing.Point(338, 272);
            this.btnAtualizarPaciente.Name = "btnAtualizarPaciente";
            this.btnAtualizarPaciente.Size = new System.Drawing.Size(101, 23);
            this.btnAtualizarPaciente.TabIndex = 13;
            this.btnAtualizarPaciente.Text = "Atualizar";
            this.btnAtualizarPaciente.UseVisualStyleBackColor = true;
            this.btnAtualizarPaciente.Click += new System.EventHandler(this.btnAtualizarPaciente_Click);
            // 
            // frmConsultaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.gbConsultarConsultas);
            this.Controls.Add(this.gbConsultarPacientes);
            this.Name = "frmConsultaPaciente";
            this.Text = "frmConsultaPaciente";
            this.gbConsultarPacientes.ResumeLayout(false);
            this.gbConsultarPacientes.PerformLayout();
            this.gbConsultarConsultas.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnCancelarConsultas;
        private System.Windows.Forms.ListView lvwConsultasMarcadas;
        private System.Windows.Forms.ColumnHeader chDataHora;
        private System.Windows.Forms.ColumnHeader chCrmMedico;
        private System.Windows.Forms.GroupBox gbConsultarConsultas;
        private System.Windows.Forms.ColumnHeader chNomeMedico;
        private System.Windows.Forms.ColumnHeader chEspecialidadeMedico;
        private System.Windows.Forms.ColumnHeader chValorConsulta;
        private System.Windows.Forms.Button btnRemoverPaciente;
        private System.Windows.Forms.Button btnAdicionarPaciente;
        private System.Windows.Forms.Button btnAtualizarPaciente;
    }
}