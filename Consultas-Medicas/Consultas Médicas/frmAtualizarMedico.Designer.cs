namespace Consultas_Médicas
{
    partial class frmAtualizarMedico
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
            this.cbCadastroMédico = new System.Windows.Forms.GroupBox();
            this.lblCadastroNomeMedico = new System.Windows.Forms.Label();
            this.lblCadastroCrmMedico = new System.Windows.Forms.Label();
            this.cbCadastroEspecialidadeMedico = new System.Windows.Forms.ComboBox();
            this.txtCadastroCrmMedico = new System.Windows.Forms.TextBox();
            this.btnAtualizarMedico = new System.Windows.Forms.Button();
            this.txtCadastroNomeMedico = new System.Windows.Forms.TextBox();
            this.txtCadastroValorHoraMedico = new System.Windows.Forms.TextBox();
            this.lblCadastroEspecialiadadeMedico = new System.Windows.Forms.Label();
            this.lblCadastroValorHoraMedico = new System.Windows.Forms.Label();
            this.cbCadastroMédico.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCadastroMédico
            // 
            this.cbCadastroMédico.Controls.Add(this.lblCadastroNomeMedico);
            this.cbCadastroMédico.Controls.Add(this.lblCadastroCrmMedico);
            this.cbCadastroMédico.Controls.Add(this.cbCadastroEspecialidadeMedico);
            this.cbCadastroMédico.Controls.Add(this.txtCadastroCrmMedico);
            this.cbCadastroMédico.Controls.Add(this.btnAtualizarMedico);
            this.cbCadastroMédico.Controls.Add(this.txtCadastroNomeMedico);
            this.cbCadastroMédico.Controls.Add(this.txtCadastroValorHoraMedico);
            this.cbCadastroMédico.Controls.Add(this.lblCadastroEspecialiadadeMedico);
            this.cbCadastroMédico.Controls.Add(this.lblCadastroValorHoraMedico);
            this.cbCadastroMédico.Location = new System.Drawing.Point(16, 15);
            this.cbCadastroMédico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCadastroMédico.Name = "cbCadastroMédico";
            this.cbCadastroMédico.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCadastroMédico.Size = new System.Drawing.Size(343, 202);
            this.cbCadastroMédico.TabIndex = 11;
            this.cbCadastroMédico.TabStop = false;
            this.cbCadastroMédico.Text = "Cadastro do Médico";
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
            // cbCadastroEspecialidadeMedico
            // 
            this.cbCadastroEspecialidadeMedico.FormattingEnabled = true;
            this.cbCadastroEspecialidadeMedico.Location = new System.Drawing.Point(189, 85);
            this.cbCadastroEspecialidadeMedico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCadastroEspecialidadeMedico.Name = "cbCadastroEspecialidadeMedico";
            this.cbCadastroEspecialidadeMedico.Size = new System.Drawing.Size(139, 24);
            this.cbCadastroEspecialidadeMedico.TabIndex = 8;
            // 
            // txtCadastroCrmMedico
            // 
            this.txtCadastroCrmMedico.Location = new System.Drawing.Point(189, 53);
            this.txtCadastroCrmMedico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCadastroCrmMedico.Name = "txtCadastroCrmMedico";
            this.txtCadastroCrmMedico.Size = new System.Drawing.Size(139, 22);
            this.txtCadastroCrmMedico.TabIndex = 1;
            // 
            // btnAtualizarMedico
            // 
            this.btnAtualizarMedico.Location = new System.Drawing.Point(13, 161);
            this.btnAtualizarMedico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAtualizarMedico.Name = "btnAtualizarMedico";
            this.btnAtualizarMedico.Size = new System.Drawing.Size(316, 28);
            this.btnAtualizarMedico.TabIndex = 2;
            this.btnAtualizarMedico.Text = "Atualizar";
            this.btnAtualizarMedico.UseVisualStyleBackColor = true;
            this.btnAtualizarMedico.Click += new System.EventHandler(this.btnAtualizarMedico_Click);
            // 
            // txtCadastroNomeMedico
            // 
            this.txtCadastroNomeMedico.Location = new System.Drawing.Point(189, 23);
            this.txtCadastroNomeMedico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCadastroNomeMedico.Name = "txtCadastroNomeMedico";
            this.txtCadastroNomeMedico.Size = new System.Drawing.Size(139, 22);
            this.txtCadastroNomeMedico.TabIndex = 1;
            this.txtCadastroNomeMedico.TextChanged += new System.EventHandler(this.txtCadastroNomeMedico_TextChanged);
            // 
            // txtCadastroValorHoraMedico
            // 
            this.txtCadastroValorHoraMedico.Location = new System.Drawing.Point(189, 118);
            this.txtCadastroValorHoraMedico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCadastroValorHoraMedico.Name = "txtCadastroValorHoraMedico";
            this.txtCadastroValorHoraMedico.Size = new System.Drawing.Size(139, 22);
            this.txtCadastroValorHoraMedico.TabIndex = 1;
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
            this.lblCadastroValorHoraMedico.Location = new System.Drawing.Point(9, 122);
            this.lblCadastroValorHoraMedico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastroValorHoraMedico.Name = "lblCadastroValorHoraMedico";
            this.lblCadastroValorHoraMedico.Size = new System.Drawing.Size(76, 16);
            this.lblCadastroValorHoraMedico.TabIndex = 0;
            this.lblCadastroValorHoraMedico.Text = "Valor-Hora:";
            // 
            // frmAtualizarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cbCadastroMédico);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAtualizarMedico";
            this.Text = "frmAtualizarMedico";
            this.cbCadastroMédico.ResumeLayout(false);
            this.cbCadastroMédico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cbCadastroMédico;
        private System.Windows.Forms.Label lblCadastroNomeMedico;
        private System.Windows.Forms.Label lblCadastroCrmMedico;
        private System.Windows.Forms.ComboBox cbCadastroEspecialidadeMedico;
        private System.Windows.Forms.TextBox txtCadastroCrmMedico;
        private System.Windows.Forms.Button btnAtualizarMedico;
        private System.Windows.Forms.TextBox txtCadastroNomeMedico;
        private System.Windows.Forms.TextBox txtCadastroValorHoraMedico;
        private System.Windows.Forms.Label lblCadastroEspecialiadadeMedico;
        private System.Windows.Forms.Label lblCadastroValorHoraMedico;
    }
}