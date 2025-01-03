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
    public partial class frmCadastroPaciente : Form
    {
        //Formulários
        frmAdicionarSaldo frmAdicionarSaldoObj;

        //Listas
        List<Paciente> pacienteLista;
        List<Medico> medicoLista;
        List<String> especialidadeMedico;
        Medico medicoSelecionado;
        DateTime horarioSelecionado;
        List<Consulta> consultasMarcadas;
        public frmCadastroPaciente(
            List<Paciente> pacienteLista,
            List<Medico> medicoLista,
            List<string> especialidadeMedico,
            Medico medicoSelecionado,
            DateTime horarioSelecionado,
            List<Consulta> consultasMarcadas
)
        {
            InitializeComponent();
            this.pacienteLista = pacienteLista;
            this.medicoLista = medicoLista;
            this.especialidadeMedico = especialidadeMedico;
            this.medicoSelecionado = medicoSelecionado;
            this.horarioSelecionado = horarioSelecionado;
            this.consultasMarcadas = consultasMarcadas;
        }

        private void btnCadastroPaciente_Click(object sender, EventArgs e)
        {
            Paciente pacienteSelecionado = new Paciente(txtCadastroCpfPaciente.Text, txtCadastroNomePaciente.Text, txtCadastroSexoPaciente.Text, txtCadastroLogradouroPaciente.Text, txtCadastroCidadePaciente.Text, txtCadastroEstadoPaciente.Text, txtCadastroPaisPaciente.Text, pacienteLista);
            pacienteLista.Add(pacienteSelecionado);
            //decimal saldoInformado = Convert.ToDecimal(txtCadastroSaldoPaciente.Text);
            
            Form frmConsultasMedicas = this.MdiParent;
            if (frmAdicionarSaldoObj == null || frmAdicionarSaldoObj.IsDisposed)
            {
                frmAdicionarSaldoObj = new frmAdicionarSaldo(pacienteLista, medicoLista, especialidadeMedico, medicoSelecionado, horarioSelecionado, pacienteSelecionado, consultasMarcadas);
                frmAdicionarSaldoObj.MdiParent = frmConsultasMedicas;
                frmAdicionarSaldoObj.Show();
            }   
            else
            {
                frmAdicionarSaldoObj.Activate();
            }
        }
    }
}
