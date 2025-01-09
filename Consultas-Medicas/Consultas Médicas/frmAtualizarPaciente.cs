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
    public partial class frmAtualizarPaciente : Form
    {
        Paciente paciente;
        List<Paciente> listaPacientes;
        public frmAtualizarPaciente(List<Paciente> listaPacientes, Paciente paciente)
        {
            InitializeComponent();
            this.paciente = paciente;
            this.listaPacientes = listaPacientes;

            txtCadastroCpfPaciente.Text = paciente.Cpf;
            txtCadastroNomePaciente.Text = paciente.Nome;
            /* txtCadastroSexoPaciente.Text = paciente.Sexo;*/
            cbCadastroSexoPaciente.Items.AddRange(new string[] { "Masculino", "Feminino", "Outro" });
            cbCadastroSexoPaciente.SelectedItem = paciente.Sexo;
            txtCadastroLogradouroPaciente.Text = paciente.Logradouro;
            txtCadastroCidadePaciente.Text = paciente.Cidade;
            txtCadastroEstadoPaciente.Text = paciente.Estado;
            txtCadastroPaisPaciente.Text = paciente.Pais;
        }

        private void btnAtualizarPaciente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCadastroCpfPaciente.Text) ||
        txtCadastroCpfPaciente.Text.Length != 11 ||
        !txtCadastroCpfPaciente.Text.All(char.IsDigit))
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

            try
            {
                var pacienteAtualizar = listaPacientes.Single(x => x.Prontuario == paciente.Prontuario);

                pacienteAtualizar.Cpf = txtCadastroCpfPaciente.Text;
                pacienteAtualizar.Nome = txtCadastroNomePaciente.Text;
                pacienteAtualizar.Sexo = cbCadastroSexoPaciente.SelectedItem.ToString();
                pacienteAtualizar.Logradouro = txtCadastroLogradouroPaciente.Text;
                pacienteAtualizar.Cidade = txtCadastroCidadePaciente.Text;
                pacienteAtualizar.Estado = txtCadastroEstadoPaciente.Text;
                pacienteAtualizar.Pais = txtCadastroPaisPaciente.Text;

                MessageBox.Show("Dados do paciente atualizados com sucesso!", "Sucesso");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Paciente não encontrado na lista.",
                                "Erro de Atualização",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao atualizar o paciente: {ex.Message}",
                                "Erro de Atualização",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }

        private void txtCadastroCpfPaciente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
