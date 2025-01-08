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
            txtCadastroNomePaciente.Text= paciente.Nome;
            txtCadastroSexoPaciente.Text = paciente.Sexo;
            txtCadastroLogradouroPaciente.Text = paciente.Logradouro;
            txtCadastroCidadePaciente.Text = paciente.Cidade;
            txtCadastroEstadoPaciente.Text = paciente.Estado;
            txtCadastroPaisPaciente.Text = paciente.Pais;
        }

        private void btnAtualizarPaciente_Click(object sender, EventArgs e)
        {
            listaPacientes.Single(x => x.Prontuario == paciente.Prontuario).Cpf = txtCadastroCpfPaciente.Text;
            listaPacientes.Single(x => x.Prontuario == paciente.Prontuario).Nome = txtCadastroNomePaciente.Text;
            listaPacientes.Single(x => x.Prontuario == paciente.Prontuario).Sexo = txtCadastroSexoPaciente.Text;
            listaPacientes.Single(x => x.Prontuario == paciente.Prontuario).Logradouro = txtCadastroLogradouroPaciente.Text;
            listaPacientes.Single(x => x.Prontuario == paciente.Prontuario).Cidade = txtCadastroCidadePaciente.Text;
            listaPacientes.Single(x => x.Prontuario == paciente.Prontuario).Estado = txtCadastroEstadoPaciente.Text;
            listaPacientes.Single(x => x.Prontuario == paciente.Prontuario).Pais = txtCadastroPaisPaciente.Text;
        }
    }
}
