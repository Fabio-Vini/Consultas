using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Consultas_Médicas
{
    public partial class frmConsultaPaciente : Form
    {
        List<Paciente> pacientes;
        List<Medico> medicos;

        //Forms
        frmCadastroPaciente frmCadastroPacienteObj;
        frmAtualizarPaciente frmAtualizarPacienteObj;

        public frmConsultaPaciente(List<Paciente> pacientes, List<Medico> medicos)
        {
            InitializeComponent();
            this.pacientes = pacientes;
            this.medicos = medicos;

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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao filtrar paciente por nome: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFiltrarCpfPaciente_TextChanged(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao filtrar paciente por CPF: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarConsultas_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwConsultasMarcadas.SelectedItems.Count > 0 && lvwConsultaPaciente.SelectedItems.Count > 0)
                {
                    int prontuarioPaciente = Convert.ToInt32(lvwConsultaPaciente.SelectedItems[0].SubItems[2].Text);
                    Paciente pacienteSelecionado = pacientes.SingleOrDefault(x => x.Prontuario == prontuarioPaciente);

                    if (pacienteSelecionado != null)
                    {
                        List<Consulta> consultasParaRemover = new List<Consulta>();

                        foreach (ListViewItem selectedItem in lvwConsultasMarcadas.SelectedItems)
                        {
                            DateTime dataHoraConsulta = DateTime.Parse(selectedItem.SubItems[3].Text);

                            if ((dataHoraConsulta - DateTime.Now).TotalDays >= 3)
                            {
                                var consulta = pacienteSelecionado.Consultas.FirstOrDefault(c => c.DataHora == dataHoraConsulta);

                                if (consulta != null)
                                {
                                    consulta.CancelarConsultaComAtualizacao(pacientes, medicos); // Atualização aqui
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
                        MessageBox.Show("Paciente não encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("Selecione uma consulta para cancelar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cancelar consultas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvwConsultaPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwConsultaPaciente.SelectedItems.Count > 0)
                {
                    int prontuarioPaciente = Convert.ToInt32(lvwConsultaPaciente.SelectedItems[0].SubItems[2].Text);
                    Paciente pacienteSelecionado = pacientes.SingleOrDefault(x => x.Prontuario == prontuarioPaciente);

                    if (pacienteSelecionado != null)
                    {
                        lvwConsultasMarcadas.Items.Clear();

                        foreach (var consulta in pacienteSelecionado.Consultas)
                        {
                            if (consulta.Status != "cancelada")
                            {
                                ListViewItem item = new ListViewItem(consulta.NomeMedico);
                                item.SubItems.Add(consulta.CrmMedico.ToString());
                                item.SubItems.Add(consulta.EspecialidadeMedico);
                                item.SubItems.Add(consulta.DataHora.ToString());
                                item.SubItems.Add(consulta.Valor.ToString());
                                lvwConsultasMarcadas.Items.Add(item);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Paciente não encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar consultas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoverPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwConsultaPaciente.SelectedItems.Count > 0) 
                {
                    foreach (ListViewItem item in lvwConsultaPaciente.SelectedItems)
                    {
                        int prontuario = Convert.ToInt32(item.SubItems[2].Text);
                        var pacienteRemover = pacientes.Single(x => x.Prontuario == prontuario);
                        if (pacienteRemover.Consultas.Count > 0)
                        {
                            foreach (var consulta in pacienteRemover.Consultas.ToList()) 
                            {
                                consulta.CancelarConsultaComAtualizacao(pacientes, medicos);
                            }
                        }
                        if (pacienteRemover != null)
                        {
                            pacientes.Remove(pacienteRemover);
                        }
                        lvwConsultaPaciente.Items.Remove(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover paciente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdicionarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                Form frmCadastroPaciente = this.MdiParent;
                if (frmCadastroPacienteObj == null || frmCadastroPacienteObj.IsDisposed)
                {
                    frmCadastroPacienteObj = new frmCadastroPaciente(pacientes);
                    frmCadastroPacienteObj.MdiParent = frmCadastroPaciente;
                    frmCadastroPacienteObj.Show();
                }
                else
                {
                    frmCadastroPacienteObj.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar paciente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtualizarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwConsultaPaciente.SelectedItems.Count > 0) 
                {
                    int prontuarioPaciente = Convert.ToInt32(lvwConsultaPaciente.SelectedItems[0].SubItems[2].Text);
                    Paciente pacienteSelecionado = pacientes.Single(x => x.Prontuario == prontuarioPaciente);
                    Form frmAtualizarPaciente = this.MdiParent;
                    if (frmAtualizarPacienteObj == null || frmAtualizarPacienteObj.IsDisposed)
                    {
                        frmAtualizarPacienteObj = new frmAtualizarPaciente(pacientes, pacienteSelecionado);
                        frmAtualizarPacienteObj.MdiParent = frmAtualizarPaciente;
                        frmAtualizarPacienteObj.Show();
                    }
                    else
                    {
                        frmAtualizarPacienteObj.Activate();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar paciente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}