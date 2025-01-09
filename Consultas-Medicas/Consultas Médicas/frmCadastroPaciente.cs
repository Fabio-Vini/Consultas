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
            List<Consulta> consultasMarcadas)
        {
            InitializeComponent();
            this.pacienteLista = pacienteLista;
            this.medicoLista = medicoLista;
            this.especialidadeMedico = especialidadeMedico;
            this.medicoSelecionado = medicoSelecionado;
            this.horarioSelecionado = horarioSelecionado;
            this.consultasMarcadas = consultasMarcadas;

            cbCadastroSexoPaciente.Items.AddRange(new string[] { "Masculino", "Feminino", "Outro" });
        }

        public frmCadastroPaciente(List<Paciente> pacienteLista)
        {
            InitializeComponent();
            this.pacienteLista = pacienteLista;

            cbCadastroSexoPaciente.Items.AddRange(new string[] { "Masculino", "Feminino", "Outro" });
        }

        private void btnCadastroPaciente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCadastroCpfPaciente.Text) || txtCadastroCpfPaciente.Text.Length != 11 || !txtCadastroCpfPaciente.Text.All(char.IsDigit))
            {
                MessageBox.Show("O CPF deve conter 11 dígitos numéricos sem traços e pontos.",
                                "Erro de Cadastro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCadastroNomePaciente.Text))
            {
                MessageBox.Show("Informe o nome do paciente.",
                                "Erro de Cadastro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            /*if (string.IsNullOrWhiteSpace(txtCadastroSexoPaciente.Text))
            {
                MessageBox.Show("Informe o sexo do paciente.",
                                "Erro de Cadastro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }*/

            if (cbCadastroSexoPaciente.SelectedIndex == -1)
            {
                MessageBox.Show("Informe o sexo do paciente.",
                                "Erro de Cadastro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCadastroLogradouroPaciente.Text))
            {
                MessageBox.Show("Informe o logradouro do paciente.",
                                "Erro de Cadastro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCadastroCidadePaciente.Text))
            {
                MessageBox.Show("Informe a cidade do paciente.",
                                "Erro de Cadastro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCadastroEstadoPaciente.Text))
            {
                MessageBox.Show("Informe o estado do paciente.",
                                "Erro de Cadastro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCadastroPaisPaciente.Text))
            {
                MessageBox.Show("Informe o país do paciente.",
                                "Erro de Cadastro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            Paciente pacienteSelecionado = new Paciente(
                txtCadastroCpfPaciente.Text,
                txtCadastroNomePaciente.Text,
                cbCadastroSexoPaciente.Text,
                /*txtCadastroSexoPaciente.Text,*/
                txtCadastroLogradouroPaciente.Text,
                txtCadastroCidadePaciente.Text,
                txtCadastroEstadoPaciente.Text,
                txtCadastroPaisPaciente.Text,
                pacienteLista
            );
            pacienteLista.Add(pacienteSelecionado);
            MessageBox.Show("Paciente Adicionado!", "Sucesso");

            LimparCampos();

            if (medicoLista != null)
            {
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

        private void LimparCampos()
        {
            txtCadastroCpfPaciente.Clear();
            txtCadastroNomePaciente.Clear();
            cbCadastroSexoPaciente.SelectedIndex = -1; // Deseleciona o dropdown
            txtCadastroLogradouroPaciente.Clear();
            txtCadastroCidadePaciente.Clear();
            txtCadastroEstadoPaciente.Clear();
            txtCadastroPaisPaciente.Clear();
        }

        private void txtCadastroCpfPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCadastroSexoPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
