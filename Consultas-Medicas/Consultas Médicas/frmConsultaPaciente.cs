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
    public partial class frmConsultaPaciente : Form
    {
        List<Paciente> pacientes;
        public frmConsultaPaciente(List <Paciente> pacientes)
        {
            InitializeComponent();
            this.pacientes = pacientes;

            foreach (var paciente in pacientes)
            {
                ListViewItem item = new ListViewItem(paciente.Nome);
                item.SubItems.Add(paciente.Cpf);
                item.SubItems.Add(paciente.Prontuario.ToString());
                item.SubItems.Add(paciente.Sexo);
                item.SubItems.Add(paciente.Logradouro);
                item.SubItems.Add(paciente.Cidade);
                item.SubItems.Add(paciente.Estado);
                item.SubItems.Add(paciente.Pais);
                item.SubItems.Add(paciente.Saldo.ToString());
                lvwConsultaPaciente.Items.Add(item);
            }
        }

        private void txtFiltrarNomePaciente_TextChanged(object sender, EventArgs e)
        {
            lvwConsultaPaciente.Items.Clear();
            int tamanhoPesquisa = txtFiltrarNomePaciente.Text.Length;
            if (txtFiltrarNomePaciente.Text != "")
            {
                foreach (var paciente in pacientes)
                {
                    if (txtFiltrarNomePaciente.Text.ToLower() == paciente.Nome.Substring(0, tamanhoPesquisa).ToLower())
                    {
                        ListViewItem item = new ListViewItem(paciente.Nome);
                        item.SubItems.Add(paciente.Cpf.ToString());
                        item.SubItems.Add(paciente.Prontuario.ToString());
                        item.SubItems.Add(paciente.Sexo);
                        item.SubItems.Add(paciente.Saldo.ToString());
                        lvwConsultaPaciente.Items.Add(item);
                    }
                }
            }
            else if (txtFiltrarNomePaciente.Text == "")
            {
                foreach (var paciente in pacientes)
                {
                    ListViewItem item = new ListViewItem(paciente.Nome);
                    item.SubItems.Add(paciente.Cpf);
                    item.SubItems.Add(paciente.Prontuario.ToString());
                    item.SubItems.Add(paciente.Sexo);
                    item.SubItems.Add(paciente.Saldo.ToString());
                    lvwConsultaPaciente.Items.Add(item);
                }
            }
        }

        private void txtFiltrarCpfPaciente_TextChanged(object sender, EventArgs e)
        {
            lvwConsultaPaciente.Items.Clear();
            int tamanhoPesquisa = txtFiltrarCpfPaciente.Text.Length;
            if (txtFiltrarCpfPaciente.Text != "")
            {
                foreach (var paciente in pacientes)
                {
                    if (txtFiltrarCpfPaciente.Text.ToLower() == paciente.Cpf.Substring(0, tamanhoPesquisa).ToLower())
                    {
                        ListViewItem item = new ListViewItem(paciente.Nome);
                        item.SubItems.Add(paciente.Cpf.ToString());
                        item.SubItems.Add(paciente.Prontuario.ToString());
                        item.SubItems.Add(paciente.Sexo);
                        item.SubItems.Add(paciente.Saldo.ToString());
                        lvwConsultaPaciente.Items.Add(item);
                    }
                }
            }
            else if (txtFiltrarCpfPaciente.Text == "")
            {
                foreach (var paciente in pacientes)
                {
                    ListViewItem item = new ListViewItem(paciente.Nome);
                    item.SubItems.Add(paciente.Cpf);
                    item.SubItems.Add(paciente.Prontuario.ToString());
                    item.SubItems.Add(paciente.Sexo);
                    item.SubItems.Add(paciente.Saldo.ToString());
                    lvwConsultaPaciente.Items.Add(item);
                }
            }
        }
    }
}
