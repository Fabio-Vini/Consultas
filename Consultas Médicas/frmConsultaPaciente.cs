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

        public frmConsultaPaciente(List<Paciente> pacientes)
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

        private void btnCancelarConsultas_Click(object sender, EventArgs e)
        {
            if (lvwConsultasMarcadas.SelectedItems.Count > 0 && lvwConsultaPaciente.SelectedItems.Count > 0)
            {
                int prontuarioPaciente = Convert.ToInt32(lvwConsultaPaciente.SelectedItems[0].SubItems[2].Text);
                Paciente pacienteSelecionado = pacientes.SingleOrDefault(x => x.Prontuario == prontuarioPaciente);

                List<Consulta> consultasParaRemover = new List<Consulta>();

                foreach (ListViewItem selectedItem in lvwConsultasMarcadas.SelectedItems)
                {
                    DateTime dataHoraConsulta = DateTime.Parse(selectedItem.Text);

                    if ((dataHoraConsulta - DateTime.Now).TotalDays >= 3)
                    {
                        var consulta = pacienteSelecionado.Consultas.FirstOrDefault(c => c.DataHora == dataHoraConsulta);

                        if (consulta != null)
                        {
                            consulta.CancelarConsulta();
                            consultasParaRemover.Add(consulta);
                            lvwConsultasMarcadas.Items.Remove(selectedItem);

                            pacienteSelecionado.AdicionarSaldo(consulta.Valor);
                        }
                        else
                        {
                            MessageBox.Show("Consulta não encontrada.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Consultas só podem ser canceladas com pelo menos 3 dias de antecedência.");
                    }
                }

                // Aqui remove as consultas da lista do paciente
                foreach (var consulta in consultasParaRemover)
                {
                    pacienteSelecionado.Consultas.Remove(consulta);
                }

                if (consultasParaRemover.Count > 0)
                {
                    MessageBox.Show("Consultas canceladas e saldo reembolsado com sucesso!");
                }
            }
            else
            {
                MessageBox.Show("Selecione uma consulta para cancelar.");
            }
        }

        private void lvwConsultaPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwConsultaPaciente.SelectedItems.Count > 0)
            {
                int prontuarioPaciente = Convert.ToInt32(lvwConsultaPaciente.SelectedItems[0].SubItems[2].Text);
                Paciente pacienteSelecionado = pacientes.Single(x => x.Prontuario == prontuarioPaciente);

                lvwConsultasMarcadas.Items.Clear();

                foreach (var consulta in pacienteSelecionado.Consultas)
                {
                    ListViewItem item = new ListViewItem(consulta.DataHora.ToString());
                    item.SubItems.Add(consulta.CrmMedico.ToString()); // Se quiser colocar o nome do médico
                    lvwConsultasMarcadas.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Selecione um paciente para listar as consultas.");
            }
        }
    }
}