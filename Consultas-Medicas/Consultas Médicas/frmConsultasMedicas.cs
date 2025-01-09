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
        
        //Novo
        frmConsultarDisponibilidade frmCadastroConsultaObj;
        
        //Cadastro
        frmCadastroPaciente frmCadastroPacienteObj;
        frmCadastroMedico frmCadastroMedicoObj;
        frmAdicionarSaldo frmAdicionarSaldoObj;

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



        private void médicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmConsultaPacienteObj == null || frmConsultaPacienteObj.IsDisposed)
            {
                frmConsultaPacienteObj = new frmConsultaPaciente(pacienteLista, medicoLista);
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
                frmConsultaMedicoObj = new frmConsultaMedico(medicoLista, especialidadeMedico, pacienteLista);
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

        private void pacienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmCadastroPacienteObj == null || frmCadastroPacienteObj.IsDisposed)
            {
                frmCadastroPacienteObj = new frmCadastroPaciente(pacienteLista);
                frmCadastroPacienteObj.MdiParent = this;
                frmCadastroPacienteObj.Show();
            }
            else
            {
                frmCadastroPacienteObj.Activate();
            }
        }

        private void médicoToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void saldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmAdicionarSaldoObj == null || frmAdicionarSaldoObj.IsDisposed)
            {
                frmAdicionarSaldoObj = new frmAdicionarSaldo(pacienteLista);
                frmAdicionarSaldoObj.MdiParent = this;
                frmAdicionarSaldoObj.Show();
            }
            else
            {
                frmAdicionarSaldoObj.Activate();

            }
        }
    }
}
