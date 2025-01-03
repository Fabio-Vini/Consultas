using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultas_Médicas
{
    public partial class frmConsultaMedica : Form
    {
        //Cadastro
        frmCadastroPaciente frmCadastroPacienteObj;
        frmCadastroMedico frmCadastroMedicoObj;
        frmConsultarDisponibilidade frmCadastroConsultaObj;

        //Consulta
        frmConsultaPaciente frmConsultaPacienteObj;
        frmConsultaMedico frmConsultaMedicoObj;
        frmConsultaEspecialidades frmConsultaEspecialidadesObj;

        //Listas
        List<Paciente> pacienteLista = new List<Paciente>();
        List<Medico> medicoLista = new List<Medico>();
        List<String> especialidadeMedico = new List<String> { "Clínico Geral", "Ortopedista", "Pediatra", "Cardiologista", "Psiquiatra", "Pediatraa", "Ginecologista", "Neurologista", "Dermatologista" };
        List<Consulta> consultasMarcadas = new List<Consulta>();
        public frmConsultaMedica()
        {
            InitializeComponent();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmCadastroPacienteObj == null || frmCadastroPacienteObj.IsDisposed)
            {
                frmCadastroPacienteObj = new frmCadastroPaciente(
                    pacienteLista,            // Lista de pacientes
                    medicoLista,               // Lista de médicos
                    especialidadeMedico,       // Lista de especialidades
                    null,                      // Médico selecionado (por enquanto null)
                    DateTime.Now,              // Data/hora da consulta (ou algum valor padrão)
                    consultasMarcadas          // Lista de consultas já realizadas
                );
                frmCadastroPacienteObj.MdiParent = this;
                frmCadastroPacienteObj.Show();
            }
            else
            {
                frmCadastroPacienteObj.Activate();
            }
        }


        private void médicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmCadastroMedicoObj == null || frmCadastroMedicoObj.IsDisposed)
            {
                frmCadastroMedicoObj = new frmCadastroMedico(medicoLista, especialidadeMedico);
                frmCadastroMedicoObj.MdiParent = this;
                frmCadastroMedicoObj.Show();
            }
            else
            {
                frmCadastroMedicoObj.Activate();

            }
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmConsultaPacienteObj == null || frmConsultaPacienteObj.IsDisposed)
            {
                frmConsultaPacienteObj = new frmConsultaPaciente(pacienteLista);
                frmConsultaPacienteObj.MdiParent = this;
                frmConsultaPacienteObj.Show();
            }
            else
            {
                frmConsultaPacienteObj.Activate();

            }
        }

        private void medicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmConsultaMedicoObj == null || frmConsultaMedicoObj.IsDisposed)
            {
                frmConsultaMedicoObj = new frmConsultaMedico(medicoLista, especialidadeMedico);
                frmConsultaMedicoObj.MdiParent = this;
                frmConsultaMedicoObj.Show();
            }
            else
            {
                frmConsultaMedicoObj.Activate();

            }
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmCadastroConsultaObj == null || frmCadastroConsultaObj.IsDisposed)
            {
                frmCadastroConsultaObj = new frmConsultarDisponibilidade(medicoLista, pacienteLista, especialidadeMedico, consultasMarcadas);
                frmCadastroConsultaObj.MdiParent = this;
                frmCadastroConsultaObj.Show();
            }
            else
            {
                frmCadastroConsultaObj.Activate();

            }
        }

        private void especialidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmConsultaEspecialidadesObj == null || frmConsultaEspecialidadesObj.IsDisposed)
            {
                frmConsultaEspecialidadesObj = new frmConsultaEspecialidades(especialidadeMedico);
                frmConsultaEspecialidadesObj.MdiParent = this;
                frmConsultaEspecialidadesObj.Show();
            }
            else
            {
                frmConsultaEspecialidadesObj.Activate();

            }
        }
    }
}
